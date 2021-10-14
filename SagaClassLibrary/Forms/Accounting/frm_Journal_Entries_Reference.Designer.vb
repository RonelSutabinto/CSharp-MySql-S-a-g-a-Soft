Namespace Forms.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Journal_Entries_Reference
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Journal_Entries_Reference))
            Me.PopupMenu_Save = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Save_Template = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save_Approval = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save_Print_Voucher = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save_Print_Check = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Print_Check = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar2 = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Document_Title = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemComboBox_Document_Title = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.BarEditItem_Remarks = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemTextEdit_Remarks = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.Bar3 = New DevExpress.XtraBars.Bar()
            Me.Toggle_Auto_Credit = New DevExpress.XtraBars.BarToggleSwitchItem()
            Me.Toggle_Unbalanced = New DevExpress.XtraBars.BarToggleSwitchItem()
            Me.BarEditItemToggle_COA_Type = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemtoggle_COA_Type = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
            Me.Bar4 = New DevExpress.XtraBars.Bar()
            Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Validate = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Approval = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Approve = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar5 = New DevExpress.XtraBars.Bar()
            Me.btn_Refresh_Connection = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Regenerate_Codes = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.RepositoryItemTextEdit_Document_Title = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.RepositoryItemcheckEdit_Check_Unbalanced = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            Me.RepositoryItemcheckEdit_Check_Auto_Credit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            Me.RepositoryItemComboBox_Paper_Size = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.xuc_Journal_Entries = New SagaClassLibrary.Controls.Accounting.xuc_Journal_Entries()
            Me.PopupMenu_Reload = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Load_Deleted = New DevExpress.XtraBars.BarButtonItem()
            CType(Me.PopupMenu_Save, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Document_Title, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemTextEdit_Remarks, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemtoggle_COA_Type, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemTextEdit_Document_Title, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemcheckEdit_Check_Unbalanced, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemcheckEdit_Check_Auto_Credit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Paper_Size, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'PopupMenu_Save
            '
            Me.PopupMenu_Save.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_Template), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_Approval), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_Print_Voucher), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_Print_Check), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_Close)})
            Me.PopupMenu_Save.Manager = Me.BarManager
            Me.PopupMenu_Save.Name = "PopupMenu_Save"
            '
            'btn_Save_Template
            '
            Me.btn_Save_Template.Caption = "Save as Template"
            Me.btn_Save_Template.Id = 37
            Me.btn_Save_Template.Name = "btn_Save_Template"
            '
            'btn_Save_Approval
            '
            Me.btn_Save_Approval.Caption = "Save and Approval"
            Me.btn_Save_Approval.Id = 38
            Me.btn_Save_Approval.ImageOptions.Image = CType(resources.GetObject("btn_Save_Approval.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Save_Approval.ImageOptions.LargeImage = CType(resources.GetObject("btn_Save_Approval.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Save_Approval.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.A))
            Me.btn_Save_Approval.Name = "btn_Save_Approval"
            '
            'btn_Save_Print_Voucher
            '
            Me.btn_Save_Print_Voucher.Caption = "Save and Print Voucher"
            Me.btn_Save_Print_Voucher.Id = 0
            Me.btn_Save_Print_Voucher.ImageOptions.Image = CType(resources.GetObject("btn_Save_Print_Voucher.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Save_Print_Voucher.ImageOptions.LargeImage = CType(resources.GetObject("btn_Save_Print_Voucher.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Save_Print_Voucher.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), (System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V))
            Me.btn_Save_Print_Voucher.Name = "btn_Save_Print_Voucher"
            '
            'btn_Save_Print_Check
            '
            Me.btn_Save_Print_Check.Caption = "Save and Print Check"
            Me.btn_Save_Print_Check.Id = 2
            Me.btn_Save_Print_Check.ImageOptions.Image = CType(resources.GetObject("btn_Save_Print_Check.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Save_Print_Check.ImageOptions.LargeImage = CType(resources.GetObject("btn_Save_Print_Check.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Save_Print_Check.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), (System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
            Me.btn_Save_Print_Check.Name = "btn_Save_Print_Check"
            '
            'btn_Save_Close
            '
            Me.btn_Save_Close.Caption = "Save and Close"
            Me.btn_Save_Close.Id = 1
            Me.btn_Save_Close.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.S))
            Me.btn_Save_Close.Name = "btn_Save_Close"
            '
            'BarManager
            '
            Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3, Me.Bar4, Me.Bar5})
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Save_Print_Voucher, Me.btn_Save_Close, Me.btn_Save_Print_Check, Me.btn_New, Me.btn_Reload, Me.btn_Save, Me.btn_Preview, Me.btn_Print_Check, Me.btn_Close, Me.BarEditItem_Remarks, Me.btn_Approval, Me.btn_Validate, Me.btn_Approve, Me.BarEditItem_Document_Title, Me.btn_Initialize, Me.btn_Update, Me.btn_Refresh_Connection, Me.btn_Verify, Me.btn_Regenerate_Codes, Me.Toggle_Auto_Credit, Me.Toggle_Unbalanced, Me.BarEditItemToggle_COA_Type, Me.btn_Save_Template, Me.btn_Save_Approval, Me.btn_Load_Deleted})
            Me.BarManager.MaxItemId = 40
            Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit_Document_Title, Me.RepositoryItemcheckEdit_Check_Unbalanced, Me.RepositoryItemcheckEdit_Check_Auto_Credit, Me.RepositoryItemComboBox_Paper_Size, Me.RepositoryItemTextEdit_Remarks, Me.RepositoryItemComboBox_Document_Title, Me.RepositoryItemtoggle_COA_Type})
            '
            'Bar1
            '
            Me.Bar1.BarName = "Commands"
            Me.Bar1.DockCol = 1
            Me.Bar1.DockRow = 0
            Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Print_Check), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.Bar1.Offset = 282
            Me.Bar1.Text = "Commands"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 25
            Me.btn_Initialize.ImageOptions.ImageIndex = 12
            Me.btn_Initialize.ImageOptions.LargeImageIndex = 12
            Me.btn_Initialize.Name = "btn_Initialize"
            '
            'btn_New
            '
            Me.btn_New.Caption = "New"
            Me.btn_New.Id = 3
            Me.btn_New.ImageOptions.ImageIndex = 1
            Me.btn_New.Name = "btn_New"
            '
            'btn_Reload
            '
            Me.btn_Reload.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.DropDownControl = Me.PopupMenu_Reload
            Me.btn_Reload.Id = 4
            Me.btn_Reload.ImageOptions.ImageIndex = 0
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_Update
            '
            Me.btn_Update.Caption = "Update"
            Me.btn_Update.Id = 28
            Me.btn_Update.ImageOptions.ImageIndex = 13
            Me.btn_Update.ImageOptions.LargeImageIndex = 13
            Me.btn_Update.Name = "btn_Update"
            '
            'btn_Save
            '
            Me.btn_Save.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.DropDownControl = Me.PopupMenu_Save
            Me.btn_Save.Id = 5
            Me.btn_Save.ImageOptions.ImageIndex = 2
            Me.btn_Save.Name = "btn_Save"
            '
            'btn_Preview
            '
            Me.btn_Preview.Caption = "&Preview"
            Me.btn_Preview.Id = 6
            Me.btn_Preview.ImageOptions.ImageIndex = 3
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_Print_Check
            '
            Me.btn_Print_Check.Caption = "&Print Check "
            Me.btn_Print_Check.Id = 7
            Me.btn_Print_Check.ImageOptions.ImageIndex = 4
            Me.btn_Print_Check.Name = "btn_Print_Check"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 8
            Me.btn_Close.ImageOptions.ImageIndex = 5
            Me.btn_Close.Name = "btn_Close"
            '
            'Bar2
            '
            Me.Bar2.BarName = "Parameters"
            Me.Bar2.DockCol = 0
            Me.Bar2.DockRow = 2
            Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Document_Title), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Remarks)})
            Me.Bar2.Text = "Parameters"
            '
            'BarEditItem_Document_Title
            '
            Me.BarEditItem_Document_Title.Caption = "Document Title"
            Me.BarEditItem_Document_Title.Edit = Me.RepositoryItemComboBox_Document_Title
            Me.BarEditItem_Document_Title.EditWidth = 200
            Me.BarEditItem_Document_Title.Id = 24
            Me.BarEditItem_Document_Title.ImageOptions.ImageIndex = 7
            Me.BarEditItem_Document_Title.Name = "BarEditItem_Document_Title"
            '
            'RepositoryItemComboBox_Document_Title
            '
            Me.RepositoryItemComboBox_Document_Title.AutoHeight = False
            Me.RepositoryItemComboBox_Document_Title.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Document_Title.Items.AddRange(New Object() {"CASH/CHECK VOUCHER", "JOURNAL ENTRIES"})
            Me.RepositoryItemComboBox_Document_Title.Name = "RepositoryItemComboBox_Document_Title"
            Me.RepositoryItemComboBox_Document_Title.Sorted = True
            Me.RepositoryItemComboBox_Document_Title.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'BarEditItem_Remarks
            '
            Me.BarEditItem_Remarks.AutoFillWidth = True
            Me.BarEditItem_Remarks.Caption = "Remarks"
            Me.BarEditItem_Remarks.Edit = Me.RepositoryItemTextEdit_Remarks
            Me.BarEditItem_Remarks.Id = 20
            Me.BarEditItem_Remarks.ImageOptions.ImageIndex = 7
            Me.BarEditItem_Remarks.Name = "BarEditItem_Remarks"
            '
            'RepositoryItemTextEdit_Remarks
            '
            Me.RepositoryItemTextEdit_Remarks.AutoHeight = False
            Me.RepositoryItemTextEdit_Remarks.Name = "RepositoryItemTextEdit_Remarks"
            '
            'Bar3
            '
            Me.Bar3.BarName = "Options"
            Me.Bar3.DockCol = 0
            Me.Bar3.DockRow = 1
            Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Toggle_Auto_Credit), New DevExpress.XtraBars.LinkPersistInfo(Me.Toggle_Unbalanced), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItemToggle_COA_Type, True)})
            Me.Bar3.Text = "Options"
            '
            'Toggle_Auto_Credit
            '
            Me.Toggle_Auto_Credit.Caption = "Auto Credit"
            Me.Toggle_Auto_Credit.Id = 32
            Me.Toggle_Auto_Credit.ImageOptions.Image = CType(resources.GetObject("Toggle_Auto_Credit.ImageOptions.Image"), System.Drawing.Image)
            Me.Toggle_Auto_Credit.ImageOptions.ImageIndex = 8
            Me.Toggle_Auto_Credit.ImageOptions.LargeImage = CType(resources.GetObject("Toggle_Auto_Credit.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.Toggle_Auto_Credit.ImageOptions.LargeImageIndex = 8
            Me.Toggle_Auto_Credit.Name = "Toggle_Auto_Credit"
            '
            'Toggle_Unbalanced
            '
            Me.Toggle_Unbalanced.Caption = "Unbalanced"
            Me.Toggle_Unbalanced.Id = 34
            Me.Toggle_Unbalanced.ImageOptions.Image = CType(resources.GetObject("Toggle_Unbalanced.ImageOptions.Image"), System.Drawing.Image)
            Me.Toggle_Unbalanced.ImageOptions.ImageIndex = 6
            Me.Toggle_Unbalanced.ImageOptions.LargeImage = CType(resources.GetObject("Toggle_Unbalanced.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.Toggle_Unbalanced.ImageOptions.LargeImageIndex = 6
            Me.Toggle_Unbalanced.Name = "Toggle_Unbalanced"
            '
            'BarEditItemToggle_COA_Type
            '
            Me.BarEditItemToggle_COA_Type.Caption = "Accounts"
            Me.BarEditItemToggle_COA_Type.Edit = Me.RepositoryItemtoggle_COA_Type
            Me.BarEditItemToggle_COA_Type.Id = 36
            Me.BarEditItemToggle_COA_Type.ImageOptions.Image = CType(resources.GetObject("BarEditItemToggle_COA_Type.ImageOptions.Image"), System.Drawing.Image)
            Me.BarEditItemToggle_COA_Type.ImageOptions.LargeImage = CType(resources.GetObject("BarEditItemToggle_COA_Type.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.BarEditItemToggle_COA_Type.Name = "BarEditItemToggle_COA_Type"
            Me.BarEditItemToggle_COA_Type.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'RepositoryItemtoggle_COA_Type
            '
            Me.RepositoryItemtoggle_COA_Type.AutoHeight = False
            Me.RepositoryItemtoggle_COA_Type.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.RepositoryItemtoggle_COA_Type.Name = "RepositoryItemtoggle_COA_Type"
            Me.RepositoryItemtoggle_COA_Type.OffText = "Details"
            Me.RepositoryItemtoggle_COA_Type.OnText = "All"
            '
            'Bar4
            '
            Me.Bar4.BarName = "Status"
            Me.Bar4.DockCol = 1
            Me.Bar4.DockRow = 1
            Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Validate), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approval), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approve)})
            Me.Bar4.Offset = 522
            Me.Bar4.Text = "Status"
            '
            'btn_Verify
            '
            Me.btn_Verify.Caption = "Verify"
            Me.btn_Verify.Id = 30
            Me.btn_Verify.ImageOptions.ImageIndex = 15
            Me.btn_Verify.ImageOptions.LargeImageIndex = 15
            Me.btn_Verify.Name = "btn_Verify"
            '
            'btn_Validate
            '
            Me.btn_Validate.Caption = "Vali&dation"
            Me.btn_Validate.Id = 22
            Me.btn_Validate.ImageOptions.ImageIndex = 9
            Me.btn_Validate.ImageOptions.LargeImageIndex = 9
            Me.btn_Validate.Name = "btn_Validate"
            '
            'btn_Approval
            '
            Me.btn_Approval.Caption = "For Appr&oval"
            Me.btn_Approval.Id = 21
            Me.btn_Approval.ImageOptions.ImageIndex = 10
            Me.btn_Approval.ImageOptions.LargeImageIndex = 10
            Me.btn_Approval.Name = "btn_Approval"
            '
            'btn_Approve
            '
            Me.btn_Approve.Caption = "&Approve"
            Me.btn_Approve.Id = 23
            Me.btn_Approve.ImageOptions.ImageIndex = 11
            Me.btn_Approve.ImageOptions.LargeImageIndex = 11
            Me.btn_Approve.Name = "btn_Approve"
            '
            'Bar5
            '
            Me.Bar5.BarName = "Tools"
            Me.Bar5.DockCol = 0
            Me.Bar5.DockRow = 0
            Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Refresh_Connection), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Regenerate_Codes)})
            Me.Bar5.Text = "Tools"
            '
            'btn_Refresh_Connection
            '
            Me.btn_Refresh_Connection.Caption = "Re&fresh Connection"
            Me.btn_Refresh_Connection.Id = 29
            Me.btn_Refresh_Connection.ImageOptions.ImageIndex = 14
            Me.btn_Refresh_Connection.ImageOptions.LargeImageIndex = 14
            Me.btn_Refresh_Connection.Name = "btn_Refresh_Connection"
            '
            'btn_Regenerate_Codes
            '
            Me.btn_Regenerate_Codes.Caption = "Repair Primary Keys"
            Me.btn_Regenerate_Codes.Id = 31
            Me.btn_Regenerate_Codes.ImageOptions.ImageIndex = 16
            Me.btn_Regenerate_Codes.ImageOptions.LargeImageIndex = 16
            Me.btn_Regenerate_Codes.Name = "btn_Regenerate_Codes"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(913, 66)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 351)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(913, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 66)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 285)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(913, 66)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 285)
            '
            'RepositoryItemTextEdit_Document_Title
            '
            Me.RepositoryItemTextEdit_Document_Title.AutoHeight = False
            Me.RepositoryItemTextEdit_Document_Title.Name = "RepositoryItemTextEdit_Document_Title"
            '
            'RepositoryItemcheckEdit_Check_Unbalanced
            '
            Me.RepositoryItemcheckEdit_Check_Unbalanced.Caption = ""
            Me.RepositoryItemcheckEdit_Check_Unbalanced.Name = "RepositoryItemcheckEdit_Check_Unbalanced"
            '
            'RepositoryItemcheckEdit_Check_Auto_Credit
            '
            Me.RepositoryItemcheckEdit_Check_Auto_Credit.AutoHeight = False
            Me.RepositoryItemcheckEdit_Check_Auto_Credit.Name = "RepositoryItemcheckEdit_Check_Auto_Credit"
            '
            'RepositoryItemComboBox_Paper_Size
            '
            Me.RepositoryItemComboBox_Paper_Size.AutoHeight = False
            Me.RepositoryItemComboBox_Paper_Size.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Paper_Size.Items.AddRange(New Object() {"FULL", "HALF"})
            Me.RepositoryItemComboBox_Paper_Size.Name = "RepositoryItemComboBox_Paper_Size"
            Me.RepositoryItemComboBox_Paper_Size.Sorted = True
            Me.RepositoryItemComboBox_Paper_Size.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Print_Check), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approval), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approve), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'xuc_Journal_Entries
            '
            Me.xuc_Journal_Entries.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Journal_Entries.Location = New System.Drawing.Point(0, 66)
            Me.xuc_Journal_Entries.Name = "xuc_Journal_Entries"
            Me.xuc_Journal_Entries.Size = New System.Drawing.Size(913, 285)
            Me.xuc_Journal_Entries.TabIndex = 4
            '
            'PopupMenu_Reload
            '
            Me.PopupMenu_Reload.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Load_Deleted)})
            Me.PopupMenu_Reload.Manager = Me.BarManager
            Me.PopupMenu_Reload.Name = "PopupMenu_Reload"
            '
            'btn_Load_Deleted
            '
            Me.btn_Load_Deleted.Caption = "Load Deleted"
            Me.btn_Load_Deleted.Id = 39
            Me.btn_Load_Deleted.ImageOptions.Image = CType(resources.GetObject("btn_Load_Deleted.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Load_Deleted.ImageOptions.LargeImage = CType(resources.GetObject("btn_Load_Deleted.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Load_Deleted.Name = "btn_Load_Deleted"
            '
            'frm_Journal_Entries_Reference
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(913, 351)
            Me.Controls.Add(Me.xuc_Journal_Entries)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Journal_Entries_Reference"
            Me.Text = "Journal Entry [Reference]"
            CType(Me.PopupMenu_Save, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Document_Title, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemTextEdit_Remarks, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemtoggle_COA_Type, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemTextEdit_Document_Title, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemcheckEdit_Check_Unbalanced, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemcheckEdit_Check_Auto_Credit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Paper_Size, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PopupMenu_Save As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Save_Print_Voucher As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save_Print_Check As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Print_Check As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents RepositoryItemTextEdit_Document_Title As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents RepositoryItemcheckEdit_Check_Auto_Credit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents RepositoryItemcheckEdit_Check_Unbalanced As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents RepositoryItemComboBox_Paper_Size As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents BarEditItem_Remarks As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemTextEdit_Remarks As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Approval As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
        Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Validate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Approve As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents BarEditItem_Document_Title As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemComboBox_Document_Title As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Refresh_Connection As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Regenerate_Codes As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Toggle_Auto_Credit As DevExpress.XtraBars.BarToggleSwitchItem
        Friend WithEvents Toggle_Unbalanced As DevExpress.XtraBars.BarToggleSwitchItem
        Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
        Friend WithEvents xuc_Journal_Entries As Controls.Accounting.xuc_Journal_Entries
        Friend WithEvents BarEditItemToggle_COA_Type As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemtoggle_COA_Type As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
        Friend WithEvents btn_Save_Template As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save_Approval As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_Reload As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Load_Deleted As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace