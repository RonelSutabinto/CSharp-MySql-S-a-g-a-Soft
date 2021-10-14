Namespace Forms.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class wzFrm_Cash_Check_Voucher
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
            Me.WizardControl = New DevExpress.XtraWizard.WizardControl()
            Me.WelcomeWizardPage = New DevExpress.XtraWizard.WelcomeWizardPage()
            Me.WizardPage_Voucher = New DevExpress.XtraWizard.WizardPage()
            Me.xuc_Voucher = New SagaClassLibrary.Controls.Accounting.xuc_Voucher()
            Me.CompletionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
            Me.WizardPage_Voucher_Type = New DevExpress.XtraWizard.WizardPage()
            Me.Voucher_Type = New DevExpress.XtraEditors.LookUpEdit()
            Me.WizardPage_Posting_Date = New DevExpress.XtraWizard.WizardPage()
            Me.Posting_Date = New DevExpress.XtraEditors.DateEdit()
            Me.WizardPage_Branch = New DevExpress.XtraWizard.WizardPage()
            Me.Branch_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.WizardPage_Account_Name = New DevExpress.XtraWizard.WizardPage()
            Me.PopupContainerControl = New DevExpress.XtraEditors.PopupContainerControl()
            Me.xuc_Account_Search = New SagaClassLibrary.Controls.Information.Account.xuc_Account_Search()
            Me.Account_Name = New DevExpress.XtraEditors.PopupContainerEdit()
            Me.WizardPage_Approver = New DevExpress.XtraWizard.WizardPage()
            Me.Voucher_Approver = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.WizardPage_Profile = New DevExpress.XtraWizard.WizardPage()
            Me.Journal_Profile = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.WizardPage_Description = New DevExpress.XtraWizard.WizardPage()
            Me.Voucher_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.WizardPage_Bank_Check = New DevExpress.XtraWizard.WizardPage()
            Me.COA_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Voucher_Check = New DevExpress.XtraEditors.TokenEdit()
            Me.WizardPage_Cash_Advance = New DevExpress.XtraWizard.WizardPage()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.Toggle_Cash_Advance = New DevExpress.XtraEditors.ToggleSwitch()
            Me.Toggle_LTO = New DevExpress.XtraEditors.ToggleSwitch()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType(Me.WizardControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardControl.SuspendLayout()
            Me.WizardPage_Voucher.SuspendLayout()
            Me.WizardPage_Voucher_Type.SuspendLayout()
            CType(Me.Voucher_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_Posting_Date.SuspendLayout()
            CType(Me.Posting_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Posting_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_Branch.SuspendLayout()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_Account_Name.SuspendLayout()
            CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PopupContainerControl.SuspendLayout()
            CType(Me.Account_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_Approver.SuspendLayout()
            CType(Me.Voucher_Approver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_Profile.SuspendLayout()
            CType(Me.Journal_Profile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_Description.SuspendLayout()
            CType(Me.Voucher_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_Bank_Check.SuspendLayout()
            CType(Me.COA_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Voucher_Check.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_Cash_Advance.SuspendLayout()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.Toggle_Cash_Advance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Toggle_LTO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'WizardControl
            '
            Me.WizardControl.Controls.Add(Me.WelcomeWizardPage)
            Me.WizardControl.Controls.Add(Me.WizardPage_Voucher)
            Me.WizardControl.Controls.Add(Me.CompletionWizardPage1)
            Me.WizardControl.Controls.Add(Me.WizardPage_Voucher_Type)
            Me.WizardControl.Controls.Add(Me.WizardPage_Posting_Date)
            Me.WizardControl.Controls.Add(Me.WizardPage_Branch)
            Me.WizardControl.Controls.Add(Me.WizardPage_Account_Name)
            Me.WizardControl.Controls.Add(Me.WizardPage_Approver)
            Me.WizardControl.Controls.Add(Me.WizardPage_Profile)
            Me.WizardControl.Controls.Add(Me.WizardPage_Description)
            Me.WizardControl.Controls.Add(Me.WizardPage_Bank_Check)
            Me.WizardControl.Controls.Add(Me.WizardPage_Cash_Advance)
            Me.WizardControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.WizardControl.Name = "WizardControl"
            Me.WizardControl.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.WelcomeWizardPage, Me.WizardPage_Voucher_Type, Me.WizardPage_Branch, Me.WizardPage_Posting_Date, Me.WizardPage_Account_Name, Me.WizardPage_Approver, Me.WizardPage_Profile, Me.WizardPage_Description, Me.WizardPage_Bank_Check, Me.WizardPage_Cash_Advance, Me.WizardPage_Voucher, Me.CompletionWizardPage1})
            Me.WizardControl.Size = New System.Drawing.Size(598, 568)
            Me.WizardControl.Text = "Cash/Check Voucher"
            Me.WizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero
            '
            'WelcomeWizardPage
            '
            Me.WelcomeWizardPage.Name = "WelcomeWizardPage"
            Me.WelcomeWizardPage.Size = New System.Drawing.Size(538, 401)
            Me.WelcomeWizardPage.Text = "Welcome to the Cash/Check Voucher"
            '
            'WizardPage_Voucher
            '
            Me.WizardPage_Voucher.Controls.Add(Me.xuc_Voucher)
            Me.WizardPage_Voucher.Name = "WizardPage_Voucher"
            Me.WizardPage_Voucher.Size = New System.Drawing.Size(538, 401)
            Me.WizardPage_Voucher.Text = "Voucher Profile"
            '
            'Xuc_Voucher
            '
            Me.xuc_Voucher.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Voucher.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Voucher.Name = "Xuc_Voucher"
            Me.xuc_Voucher.Size = New System.Drawing.Size(538, 401)
            Me.xuc_Voucher.TabIndex = 0
            '
            'CompletionWizardPage1
            '
            Me.CompletionWizardPage1.Name = "CompletionWizardPage1"
            Me.CompletionWizardPage1.Size = New System.Drawing.Size(538, 401)
            Me.CompletionWizardPage1.Text = "Completing the Cash/Check Voucher"
            '
            'WizardPage_Voucher_Type
            '
            Me.WizardPage_Voucher_Type.Controls.Add(Me.Voucher_Type)
            Me.WizardPage_Voucher_Type.Name = "WizardPage_Voucher_Type"
            Me.WizardPage_Voucher_Type.Size = New System.Drawing.Size(538, 401)
            Me.WizardPage_Voucher_Type.Text = "Select Voucher Type"
            '
            'Voucher_Type
            '
            Me.Voucher_Type.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Voucher_Type.Location = New System.Drawing.Point(100, 100)
            Me.Voucher_Type.Name = "Voucher_Type"
            Me.Voucher_Type.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Voucher_Type.Properties.Appearance.Options.UseFont = True
            Me.Voucher_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Voucher_Type.Size = New System.Drawing.Size(350, 26)
            Me.Voucher_Type.TabIndex = 0
            '
            'WizardPage_Posting_Date
            '
            Me.WizardPage_Posting_Date.Controls.Add(Me.Posting_Date)
            Me.WizardPage_Posting_Date.Name = "WizardPage_Posting_Date"
            Me.WizardPage_Posting_Date.Size = New System.Drawing.Size(538, 401)
            Me.WizardPage_Posting_Date.Text = "Set Posting Date"
            '
            'Posting_Date
            '
            Me.Posting_Date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Posting_Date.EditValue = Nothing
            Me.Posting_Date.Location = New System.Drawing.Point(100, 100)
            Me.Posting_Date.Name = "Posting_Date"
            Me.Posting_Date.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Posting_Date.Properties.Appearance.Options.UseFont = True
            Me.Posting_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Posting_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Posting_Date.Properties.DisplayFormat.FormatString = ""
            Me.Posting_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.Posting_Date.Properties.EditFormat.FormatString = ""
            Me.Posting_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.Posting_Date.Properties.MaskSettings.Set("mask", "")
            Me.Posting_Date.Properties.NullText = "[EditValue is null]"
            Me.Posting_Date.Size = New System.Drawing.Size(350, 26)
            Me.Posting_Date.TabIndex = 2
            '
            'WizardPage_Branch
            '
            Me.WizardPage_Branch.Controls.Add(Me.Branch_Code)
            Me.WizardPage_Branch.Name = "WizardPage_Branch"
            Me.WizardPage_Branch.Size = New System.Drawing.Size(538, 401)
            Me.WizardPage_Branch.Text = "Select Branch"
            '
            'Branch_Code
            '
            Me.Branch_Code.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Branch_Code.Location = New System.Drawing.Point(100, 100)
            Me.Branch_Code.Name = "Branch_Code"
            Me.Branch_Code.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Branch_Code.Properties.Appearance.Options.UseFont = True
            Me.Branch_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Branch_Code.Size = New System.Drawing.Size(350, 26)
            Me.Branch_Code.TabIndex = 1
            '
            'WizardPage_Account_Name
            '
            Me.WizardPage_Account_Name.Controls.Add(Me.PopupContainerControl)
            Me.WizardPage_Account_Name.Controls.Add(Me.Account_Name)
            Me.WizardPage_Account_Name.Name = "WizardPage_Account_Name"
            Me.WizardPage_Account_Name.Size = New System.Drawing.Size(538, 401)
            Me.WizardPage_Account_Name.Text = "Set Account Name"
            '
            'PopupContainerControl
            '
            Me.PopupContainerControl.Controls.Add(Me.xuc_Account_Search)
            Me.PopupContainerControl.Location = New System.Drawing.Point(100, 132)
            Me.PopupContainerControl.Name = "PopupContainerControl"
            Me.PopupContainerControl.Size = New System.Drawing.Size(350, 217)
            Me.PopupContainerControl.TabIndex = 23
            '
            'xuc_Account_Search
            '
            Me.xuc_Account_Search.AccountName = Nothing
            Me.xuc_Account_Search.Amount = New Decimal(New Integer() {0, 0, 0, 0})
            Me.xuc_Account_Search.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.xuc_Account_Search.Appearance.Options.UseFont = True
            Me.xuc_Account_Search.Code = Nothing
            Me.xuc_Account_Search.Code2 = Nothing
            Me.xuc_Account_Search.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Account_Search.ID = 0
            Me.xuc_Account_Search.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Account_Search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.xuc_Account_Search.Name = "xuc_Account_Search"
            Me.xuc_Account_Search.Others = Nothing
            Me.xuc_Account_Search.searchMode = SagaClassLibrary.Controls.Information.Account.xuc_Account_Search.Search_Mode.searchGlobal
            Me.xuc_Account_Search.Size = New System.Drawing.Size(350, 217)
            Me.xuc_Account_Search.TabIndex = 0
            Me.xuc_Account_Search.Type = Nothing
            '
            'Account_Name
            '
            Me.Account_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Account_Name.Location = New System.Drawing.Point(100, 100)
            Me.Account_Name.Name = "Account_Name"
            Me.Account_Name.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Account_Name.Properties.Appearance.Options.UseFont = True
            Me.Account_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Account_Name.Properties.NullText = "[EditValue is null]"
            Me.Account_Name.Properties.PopupControl = Me.PopupContainerControl
            Me.Account_Name.Size = New System.Drawing.Size(350, 26)
            Me.Account_Name.TabIndex = 3
            '
            'WizardPage_Approver
            '
            Me.WizardPage_Approver.Controls.Add(Me.Voucher_Approver)
            Me.WizardPage_Approver.Name = "WizardPage_Approver"
            Me.WizardPage_Approver.Size = New System.Drawing.Size(538, 401)
            Me.WizardPage_Approver.Text = "Set Approver"
            '
            'Voucher_Approver
            '
            Me.Voucher_Approver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Voucher_Approver.Location = New System.Drawing.Point(100, 100)
            Me.Voucher_Approver.Name = "Voucher_Approver"
            Me.Voucher_Approver.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Voucher_Approver.Properties.Appearance.Options.UseFont = True
            Me.Voucher_Approver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Voucher_Approver.Properties.NullText = "[EditValue is null]"
            Me.Voucher_Approver.Properties.PopupSizeable = True
            Me.Voucher_Approver.Size = New System.Drawing.Size(350, 26)
            Me.Voucher_Approver.TabIndex = 2
            '
            'WizardPage_Profile
            '
            Me.WizardPage_Profile.Controls.Add(Me.Journal_Profile)
            Me.WizardPage_Profile.Name = "WizardPage_Profile"
            Me.WizardPage_Profile.Size = New System.Drawing.Size(538, 401)
            Me.WizardPage_Profile.Text = "Set Profile"
            '
            'Journal_Profile
            '
            Me.Journal_Profile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Journal_Profile.Location = New System.Drawing.Point(100, 100)
            Me.Journal_Profile.Name = "Journal_Profile"
            Me.Journal_Profile.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Journal_Profile.Properties.Appearance.Options.UseFont = True
            Me.Journal_Profile.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Journal_Profile.Properties.NullText = "[EditValue is null]"
            Me.Journal_Profile.Properties.PopupSizeable = True
            Me.Journal_Profile.Size = New System.Drawing.Size(350, 26)
            Me.Journal_Profile.TabIndex = 3
            '
            'WizardPage_Description
            '
            Me.WizardPage_Description.Controls.Add(Me.Voucher_Description)
            Me.WizardPage_Description.Name = "WizardPage_Description"
            Me.WizardPage_Description.Size = New System.Drawing.Size(538, 401)
            Me.WizardPage_Description.Text = "Set Remarks / Description"
            '
            'Voucher_Description
            '
            Me.Voucher_Description.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Voucher_Description.Location = New System.Drawing.Point(0, 0)
            Me.Voucher_Description.Name = "Voucher_Description"
            Me.Voucher_Description.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Voucher_Description.Properties.Appearance.Options.UseFont = True
            Me.Voucher_Description.Properties.NullText = "[EditValue is null]"
            Me.Voucher_Description.Size = New System.Drawing.Size(538, 401)
            Me.Voucher_Description.TabIndex = 4
            '
            'WizardPage_Bank_Check
            '
            Me.WizardPage_Bank_Check.Controls.Add(Me.COA_Code)
            Me.WizardPage_Bank_Check.Controls.Add(Me.Voucher_Check)
            Me.WizardPage_Bank_Check.Name = "WizardPage_Bank_Check"
            Me.WizardPage_Bank_Check.Size = New System.Drawing.Size(538, 401)
            Me.WizardPage_Bank_Check.Text = "Set Bank and Check"
            '
            'COA_Code
            '
            Me.COA_Code.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.COA_Code.Location = New System.Drawing.Point(100, 100)
            Me.COA_Code.Name = "COA_Code"
            Me.COA_Code.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.COA_Code.Properties.Appearance.Options.UseFont = True
            Me.COA_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.COA_Code.Size = New System.Drawing.Size(350, 26)
            Me.COA_Code.TabIndex = 4
            '
            'Voucher_Check
            '
            Me.Voucher_Check.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Voucher_Check.Location = New System.Drawing.Point(100, 150)
            Me.Voucher_Check.Name = "Voucher_Check"
            Me.Voucher_Check.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Voucher_Check.Properties.Appearance.Options.UseFont = True
            Me.Voucher_Check.Properties.NullText = "[EditValue is null]"
            Me.Voucher_Check.Properties.Separators.AddRange(New String() {","})
            Me.Voucher_Check.Size = New System.Drawing.Size(350, 26)
            Me.Voucher_Check.TabIndex = 5
            '
            'WizardPage_Cash_Advance
            '
            Me.WizardPage_Cash_Advance.Controls.Add(Me.layoutControl)
            Me.WizardPage_Cash_Advance.Name = "WizardPage_Cash_Advance"
            Me.WizardPage_Cash_Advance.Size = New System.Drawing.Size(538, 401)
            Me.WizardPage_Cash_Advance.Text = "Cash Advance"
            '
            'LayoutControl1
            '
            Me.layoutControl.Controls.Add(Me.Toggle_Cash_Advance)
            Me.layoutControl.Controls.Add(Me.Toggle_LTO)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "LayoutControl1"
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(538, 401)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "LayoutControl1"
            '
            'Toggle_Cash_Advance
            '
            Me.Toggle_Cash_Advance.Location = New System.Drawing.Point(121, 12)
            Me.Toggle_Cash_Advance.Name = "Toggle_Cash_Advance"
            Me.Toggle_Cash_Advance.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.Toggle_Cash_Advance.Properties.Appearance.Options.UseFont = True
            Me.Toggle_Cash_Advance.Properties.OffText = "Off"
            Me.Toggle_Cash_Advance.Properties.OnText = "On"
            Me.Toggle_Cash_Advance.Size = New System.Drawing.Size(405, 26)
            Me.Toggle_Cash_Advance.StyleController = Me.layoutControl
            Me.Toggle_Cash_Advance.TabIndex = 4
            '
            'Toggle_LTO
            '
            Me.Toggle_LTO.Location = New System.Drawing.Point(121, 92)
            Me.Toggle_LTO.Name = "Toggle_LTO"
            Me.Toggle_LTO.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.Toggle_LTO.Properties.Appearance.Options.UseFont = True
            Me.Toggle_LTO.Properties.OffText = "Employee"
            Me.Toggle_LTO.Properties.OnText = "LTO"
            Me.Toggle_LTO.Size = New System.Drawing.Size(405, 26)
            Me.Toggle_LTO.StyleController = Me.layoutControl
            Me.Toggle_LTO.TabIndex = 5
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.LayoutControlItem2, Me.EmptySpaceItem6})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(538, 401)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem1.Control = Me.Toggle_Cash_Advance
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(518, 30)
            Me.LayoutControlItem1.Text = "Cash Advance"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(97, 21)
            '
            'EmptySpaceItem2
            '
            Me.EmptySpaceItem2.AllowHotTrack = False
            Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 110)
            Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
            Me.EmptySpaceItem2.Size = New System.Drawing.Size(518, 271)
            Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem2.Control = Me.Toggle_LTO
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 80)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(518, 30)
            Me.LayoutControlItem2.Text = "Advance Type"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(97, 21)
            '
            'EmptySpaceItem6
            '
            Me.EmptySpaceItem6.AllowHotTrack = False
            Me.EmptySpaceItem6.Location = New System.Drawing.Point(0, 30)
            Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
            Me.EmptySpaceItem6.Size = New System.Drawing.Size(518, 50)
            Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
            '
            'wzFrm_Cash_Check_Voucher
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(598, 568)
            Me.Controls.Add(Me.WizardControl)
            Me.Name = "wzFrm_Cash_Check_Voucher"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "New Cash/Check Voucher Wizard Form"
            CType(Me.WizardControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardControl.ResumeLayout(False)
            Me.WizardPage_Voucher.ResumeLayout(False)
            Me.WizardPage_Voucher_Type.ResumeLayout(False)
            CType(Me.Voucher_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_Posting_Date.ResumeLayout(False)
            CType(Me.Posting_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Posting_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_Branch.ResumeLayout(False)
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_Account_Name.ResumeLayout(False)
            CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PopupContainerControl.ResumeLayout(False)
            CType(Me.Account_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_Approver.ResumeLayout(False)
            CType(Me.Voucher_Approver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_Profile.ResumeLayout(False)
            CType(Me.Journal_Profile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_Description.ResumeLayout(False)
            CType(Me.Voucher_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_Bank_Check.ResumeLayout(False)
            CType(Me.COA_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Voucher_Check.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_Cash_Advance.ResumeLayout(False)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.Toggle_Cash_Advance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Toggle_LTO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents WizardControl As DevExpress.XtraWizard.WizardControl
        Friend WithEvents WelcomeWizardPage As DevExpress.XtraWizard.WelcomeWizardPage
        Friend WithEvents WizardPage_Voucher As DevExpress.XtraWizard.WizardPage
        Friend WithEvents CompletionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
        Friend WithEvents WizardPage_Voucher_Type As DevExpress.XtraWizard.WizardPage
        Friend WithEvents Voucher_Type As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents WizardPage_Posting_Date As DevExpress.XtraWizard.WizardPage
        Friend WithEvents WizardPage_Branch As DevExpress.XtraWizard.WizardPage
        Friend WithEvents Branch_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents xuc_Voucher As Controls.Accounting.xuc_Voucher
        Friend WithEvents Posting_Date As DevExpress.XtraEditors.DateEdit
        Friend WithEvents WizardPage_Account_Name As DevExpress.XtraWizard.WizardPage
        Friend WithEvents Account_Name As DevExpress.XtraEditors.PopupContainerEdit
        Friend WithEvents PopupContainerControl As DevExpress.XtraEditors.PopupContainerControl
        Friend WithEvents xuc_Account_Search As Controls.Information.Account.xuc_Account_Search
        Friend WithEvents WizardPage_Approver As DevExpress.XtraWizard.WizardPage
        Friend WithEvents Voucher_Approver As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents WizardPage_Profile As DevExpress.XtraWizard.WizardPage
        Friend WithEvents Journal_Profile As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents WizardPage_Description As DevExpress.XtraWizard.WizardPage
        Friend WithEvents Voucher_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents WizardPage_Bank_Check As DevExpress.XtraWizard.WizardPage
        Friend WithEvents WizardPage_Cash_Advance As DevExpress.XtraWizard.WizardPage
        Friend WithEvents COA_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Voucher_Check As DevExpress.XtraEditors.TokenEdit
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Toggle_Cash_Advance As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents Toggle_LTO As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace