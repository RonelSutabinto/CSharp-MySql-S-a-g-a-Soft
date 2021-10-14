<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_UserManagement
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_UserManagement))
        Me.CheckIsAllowedBackDate = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckIsSuperUser = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckIsAdmin = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckIsMaintenance = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckIsAudit = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckIsReports = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckIsApprover = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_username = New DevExpress.XtraEditors.LookUpEdit()
        Me.CheckIsAccounting = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_pass = New DevExpress.XtraEditors.TextEdit()
        Me.PassUpdate = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckIsInventory = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckIsBookkeeper = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckIsSpareParts = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_brCode = New DevExpress.XtraEditors.TextEdit()
        Me.txt_FName = New DevExpress.XtraEditors.TextEdit()
        Me.CheckIsLogistics = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_MI = New DevExpress.XtraEditors.TextEdit()
        Me.CheckIsCollection = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckIsCashier = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_LName = New DevExpress.XtraEditors.TextEdit()
        Me.cmb_Branch = New DevExpress.XtraEditors.LookUpEdit()
        Me.CheckIsRelease = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_Designation = New DevExpress.XtraEditors.TextEdit()
        Me.CheckIsReceptionist = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckIsNewAccounts = New DevExpress.XtraEditors.CheckEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.usermgmt = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.usermgmtPanel = New System.Windows.Forms.Panel()
        Me.resetAllPass = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.cmd_ResetAll = New DevExpress.XtraEditors.SimpleButton()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Pass2Reset = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_username2Reset = New DevExpress.XtraEditors.TextEdit()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Btn_New = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Update = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.CheckIsAllowedBackDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckIsSuperUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsAdmin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsMaintenance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsAudit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsReports.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsApprover.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsAccounting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassUpdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsBookkeeper.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsSpareParts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_brCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_FName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsLogistics.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsCollection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsCashier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_LName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Branch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsRelease.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Designation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsReceptionist.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsNewAccounts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.usermgmt.SuspendLayout()
        Me.usermgmtPanel.SuspendLayout()
        Me.resetAllPass.SuspendLayout()
        CType(Me.txt_Pass2Reset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_username2Reset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckIsAllowedBackDate
        '
        Me.CheckIsAllowedBackDate.Location = New System.Drawing.Point(601, 124)
        Me.CheckIsAllowedBackDate.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsAllowedBackDate.Name = "CheckIsAllowedBackDate"
        Me.CheckIsAllowedBackDate.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsAllowedBackDate.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsAllowedBackDate.Properties.Appearance.Options.UseFont = True
        Me.CheckIsAllowedBackDate.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsAllowedBackDate.Properties.Caption = "IsAllowedBackDate"
        Me.CheckIsAllowedBackDate.Size = New System.Drawing.Size(283, 22)
        Me.CheckIsAllowedBackDate.StyleController = Me.LayoutControl1
        Me.CheckIsAllowedBackDate.TabIndex = 34
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CheckIsSuperUser)
        Me.LayoutControl1.Controls.Add(Me.CheckIsAdmin)
        Me.LayoutControl1.Controls.Add(Me.CheckIsAllowedBackDate)
        Me.LayoutControl1.Controls.Add(Me.CheckIsMaintenance)
        Me.LayoutControl1.Controls.Add(Me.CheckIsAudit)
        Me.LayoutControl1.Controls.Add(Me.CheckIsReports)
        Me.LayoutControl1.Controls.Add(Me.CheckIsApprover)
        Me.LayoutControl1.Controls.Add(Me.txt_username)
        Me.LayoutControl1.Controls.Add(Me.CheckIsAccounting)
        Me.LayoutControl1.Controls.Add(Me.txt_pass)
        Me.LayoutControl1.Controls.Add(Me.PassUpdate)
        Me.LayoutControl1.Controls.Add(Me.CheckIsInventory)
        Me.LayoutControl1.Controls.Add(Me.CheckIsBookkeeper)
        Me.LayoutControl1.Controls.Add(Me.CheckIsSpareParts)
        Me.LayoutControl1.Controls.Add(Me.txt_brCode)
        Me.LayoutControl1.Controls.Add(Me.txt_FName)
        Me.LayoutControl1.Controls.Add(Me.CheckIsLogistics)
        Me.LayoutControl1.Controls.Add(Me.txt_MI)
        Me.LayoutControl1.Controls.Add(Me.CheckIsCollection)
        Me.LayoutControl1.Controls.Add(Me.CheckIsCashier)
        Me.LayoutControl1.Controls.Add(Me.txt_LName)
        Me.LayoutControl1.Controls.Add(Me.cmb_Branch)
        Me.LayoutControl1.Controls.Add(Me.CheckIsRelease)
        Me.LayoutControl1.Controls.Add(Me.txt_Designation)
        Me.LayoutControl1.Controls.Add(Me.CheckIsReceptionist)
        Me.LayoutControl1.Controls.Add(Me.CheckIsNewAccounts)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(896, 315)
        Me.LayoutControl1.TabIndex = 35
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CheckIsSuperUser
        '
        Me.CheckIsSuperUser.Location = New System.Drawing.Point(601, 254)
        Me.CheckIsSuperUser.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsSuperUser.Name = "CheckIsSuperUser"
        Me.CheckIsSuperUser.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsSuperUser.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsSuperUser.Properties.Appearance.Options.UseFont = True
        Me.CheckIsSuperUser.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsSuperUser.Properties.Caption = "IsSuperUser"
        Me.CheckIsSuperUser.Size = New System.Drawing.Size(283, 22)
        Me.CheckIsSuperUser.StyleController = Me.LayoutControl1
        Me.CheckIsSuperUser.TabIndex = 29
        '
        'CheckIsAdmin
        '
        Me.CheckIsAdmin.Location = New System.Drawing.Point(601, 228)
        Me.CheckIsAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsAdmin.Name = "CheckIsAdmin"
        Me.CheckIsAdmin.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsAdmin.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsAdmin.Properties.Appearance.Options.UseFont = True
        Me.CheckIsAdmin.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsAdmin.Properties.Caption = "IsAdmin"
        Me.CheckIsAdmin.Size = New System.Drawing.Size(283, 22)
        Me.CheckIsAdmin.StyleController = Me.LayoutControl1
        Me.CheckIsAdmin.TabIndex = 16
        '
        'CheckIsMaintenance
        '
        Me.CheckIsMaintenance.Location = New System.Drawing.Point(601, 202)
        Me.CheckIsMaintenance.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsMaintenance.Name = "CheckIsMaintenance"
        Me.CheckIsMaintenance.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsMaintenance.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsMaintenance.Properties.Appearance.Options.UseFont = True
        Me.CheckIsMaintenance.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsMaintenance.Properties.Caption = "IsMaintenance"
        Me.CheckIsMaintenance.Size = New System.Drawing.Size(283, 22)
        Me.CheckIsMaintenance.StyleController = Me.LayoutControl1
        Me.CheckIsMaintenance.TabIndex = 19
        '
        'CheckIsAudit
        '
        Me.CheckIsAudit.Location = New System.Drawing.Point(306, 228)
        Me.CheckIsAudit.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsAudit.Name = "CheckIsAudit"
        Me.CheckIsAudit.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsAudit.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsAudit.Properties.Appearance.Options.UseFont = True
        Me.CheckIsAudit.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsAudit.Properties.Caption = "IsAudit"
        Me.CheckIsAudit.Size = New System.Drawing.Size(291, 22)
        Me.CheckIsAudit.StyleController = Me.LayoutControl1
        Me.CheckIsAudit.TabIndex = 18
        '
        'CheckIsReports
        '
        Me.CheckIsReports.Location = New System.Drawing.Point(601, 176)
        Me.CheckIsReports.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsReports.Name = "CheckIsReports"
        Me.CheckIsReports.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsReports.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsReports.Properties.Appearance.Options.UseFont = True
        Me.CheckIsReports.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsReports.Properties.Caption = "IsReports"
        Me.CheckIsReports.Size = New System.Drawing.Size(283, 22)
        Me.CheckIsReports.StyleController = Me.LayoutControl1
        Me.CheckIsReports.TabIndex = 32
        '
        'CheckIsApprover
        '
        Me.CheckIsApprover.Location = New System.Drawing.Point(601, 150)
        Me.CheckIsApprover.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsApprover.Name = "CheckIsApprover"
        Me.CheckIsApprover.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsApprover.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsApprover.Properties.Appearance.Options.UseFont = True
        Me.CheckIsApprover.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsApprover.Properties.Caption = "IsApprover"
        Me.CheckIsApprover.Size = New System.Drawing.Size(283, 22)
        Me.CheckIsApprover.StyleController = Me.LayoutControl1
        Me.CheckIsApprover.TabIndex = 15
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(81, 12)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Properties.Appearance.Options.UseFont = True
        Me.txt_username.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_username.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.txt_username.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.txt_username.Size = New System.Drawing.Size(220, 24)
        Me.txt_username.StyleController = Me.LayoutControl1
        Me.txt_username.TabIndex = 1
        '
        'CheckIsAccounting
        '
        Me.CheckIsAccounting.Location = New System.Drawing.Point(306, 124)
        Me.CheckIsAccounting.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsAccounting.Name = "CheckIsAccounting"
        Me.CheckIsAccounting.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsAccounting.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsAccounting.Properties.Appearance.Options.UseFont = True
        Me.CheckIsAccounting.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsAccounting.Properties.Caption = "IsAccounting"
        Me.CheckIsAccounting.Size = New System.Drawing.Size(291, 22)
        Me.CheckIsAccounting.StyleController = Me.LayoutControl1
        Me.CheckIsAccounting.TabIndex = 17
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(374, 12)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Properties.Appearance.Options.UseFont = True
        Me.txt_pass.Size = New System.Drawing.Size(341, 24)
        Me.txt_pass.StyleController = Me.LayoutControl1
        Me.txt_pass.TabIndex = 4
        '
        'PassUpdate
        '
        Me.PassUpdate.Location = New System.Drawing.Point(719, 12)
        Me.PassUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.PassUpdate.Name = "PassUpdate"
        Me.PassUpdate.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PassUpdate.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassUpdate.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PassUpdate.Properties.Appearance.Options.UseBackColor = True
        Me.PassUpdate.Properties.Appearance.Options.UseFont = True
        Me.PassUpdate.Properties.Appearance.Options.UseForeColor = True
        Me.PassUpdate.Properties.Appearance.Options.UseTextOptions = True
        Me.PassUpdate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.PassUpdate.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PassUpdate.Properties.Caption = "Update"
        Me.PassUpdate.Properties.GlyphVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PassUpdate.Size = New System.Drawing.Size(165, 19)
        Me.PassUpdate.StyleController = Me.LayoutControl1
        Me.PassUpdate.TabIndex = 31
        '
        'CheckIsInventory
        '
        Me.CheckIsInventory.Location = New System.Drawing.Point(12, 254)
        Me.CheckIsInventory.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsInventory.Name = "CheckIsInventory"
        Me.CheckIsInventory.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsInventory.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsInventory.Properties.Appearance.Options.UseFont = True
        Me.CheckIsInventory.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsInventory.Properties.Caption = "IsInventory"
        Me.CheckIsInventory.Size = New System.Drawing.Size(290, 22)
        Me.CheckIsInventory.StyleController = Me.LayoutControl1
        Me.CheckIsInventory.TabIndex = 24
        '
        'CheckIsBookkeeper
        '
        Me.CheckIsBookkeeper.Location = New System.Drawing.Point(306, 176)
        Me.CheckIsBookkeeper.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsBookkeeper.Name = "CheckIsBookkeeper"
        Me.CheckIsBookkeeper.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsBookkeeper.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsBookkeeper.Properties.Appearance.Options.UseFont = True
        Me.CheckIsBookkeeper.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsBookkeeper.Properties.Caption = "IsBookkeeper"
        Me.CheckIsBookkeeper.Size = New System.Drawing.Size(291, 22)
        Me.CheckIsBookkeeper.StyleController = Me.LayoutControl1
        Me.CheckIsBookkeeper.TabIndex = 20
        '
        'CheckIsSpareParts
        '
        Me.CheckIsSpareParts.Location = New System.Drawing.Point(306, 202)
        Me.CheckIsSpareParts.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsSpareParts.Name = "CheckIsSpareParts"
        Me.CheckIsSpareParts.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsSpareParts.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsSpareParts.Properties.Appearance.Options.UseFont = True
        Me.CheckIsSpareParts.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsSpareParts.Properties.Caption = "IsSpareParts"
        Me.CheckIsSpareParts.Size = New System.Drawing.Size(291, 22)
        Me.CheckIsSpareParts.StyleController = Me.LayoutControl1
        Me.CheckIsSpareParts.TabIndex = 28
        '
        'txt_brCode
        '
        Me.txt_brCode.Location = New System.Drawing.Point(649, 96)
        Me.txt_brCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_brCode.Name = "txt_brCode"
        Me.txt_brCode.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brCode.Properties.Appearance.Options.UseFont = True
        Me.txt_brCode.Properties.ReadOnly = True
        Me.txt_brCode.Size = New System.Drawing.Size(235, 24)
        Me.txt_brCode.StyleController = Me.LayoutControl1
        Me.txt_brCode.TabIndex = 14
        Me.txt_brCode.Visible = False
        '
        'txt_FName
        '
        Me.txt_FName.Location = New System.Drawing.Point(81, 40)
        Me.txt_FName.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_FName.Name = "txt_FName"
        Me.txt_FName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FName.Properties.Appearance.Options.UseFont = True
        Me.txt_FName.Size = New System.Drawing.Size(220, 24)
        Me.txt_FName.StyleController = Me.LayoutControl1
        Me.txt_FName.TabIndex = 6
        '
        'CheckIsLogistics
        '
        Me.CheckIsLogistics.Location = New System.Drawing.Point(306, 150)
        Me.CheckIsLogistics.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsLogistics.Name = "CheckIsLogistics"
        Me.CheckIsLogistics.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsLogistics.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsLogistics.Properties.Appearance.Options.UseFont = True
        Me.CheckIsLogistics.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsLogistics.Properties.Caption = "IsLogistics"
        Me.CheckIsLogistics.Size = New System.Drawing.Size(291, 22)
        Me.CheckIsLogistics.StyleController = Me.LayoutControl1
        Me.CheckIsLogistics.TabIndex = 27
        '
        'txt_MI
        '
        Me.txt_MI.Location = New System.Drawing.Point(374, 40)
        Me.txt_MI.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_MI.Name = "txt_MI"
        Me.txt_MI.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MI.Properties.Appearance.Options.UseFont = True
        Me.txt_MI.Size = New System.Drawing.Size(218, 24)
        Me.txt_MI.StyleController = Me.LayoutControl1
        Me.txt_MI.TabIndex = 8
        '
        'CheckIsCollection
        '
        Me.CheckIsCollection.Location = New System.Drawing.Point(12, 228)
        Me.CheckIsCollection.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsCollection.Name = "CheckIsCollection"
        Me.CheckIsCollection.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsCollection.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsCollection.Properties.Appearance.Options.UseFont = True
        Me.CheckIsCollection.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsCollection.Properties.Caption = "IsCollection"
        Me.CheckIsCollection.Size = New System.Drawing.Size(290, 22)
        Me.CheckIsCollection.StyleController = Me.LayoutControl1
        Me.CheckIsCollection.TabIndex = 23
        '
        'CheckIsCashier
        '
        Me.CheckIsCashier.Location = New System.Drawing.Point(12, 202)
        Me.CheckIsCashier.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsCashier.Name = "CheckIsCashier"
        Me.CheckIsCashier.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsCashier.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsCashier.Properties.Appearance.Options.UseFont = True
        Me.CheckIsCashier.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsCashier.Properties.Caption = "IsCashier"
        Me.CheckIsCashier.Size = New System.Drawing.Size(290, 22)
        Me.CheckIsCashier.StyleController = Me.LayoutControl1
        Me.CheckIsCashier.TabIndex = 25
        '
        'txt_LName
        '
        Me.txt_LName.Location = New System.Drawing.Point(665, 40)
        Me.txt_LName.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_LName.Name = "txt_LName"
        Me.txt_LName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LName.Properties.Appearance.Options.UseFont = True
        Me.txt_LName.Size = New System.Drawing.Size(219, 24)
        Me.txt_LName.StyleController = Me.LayoutControl1
        Me.txt_LName.TabIndex = 10
        '
        'cmb_Branch
        '
        Me.cmb_Branch.Location = New System.Drawing.Point(81, 96)
        Me.cmb_Branch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_Branch.Name = "cmb_Branch"
        Me.cmb_Branch.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Branch.Properties.Appearance.Options.UseFont = True
        Me.cmb_Branch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Branch.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cmb_Branch.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch
        Me.cmb_Branch.Size = New System.Drawing.Size(556, 24)
        Me.cmb_Branch.StyleController = Me.LayoutControl1
        Me.cmb_Branch.TabIndex = 2
        '
        'CheckIsRelease
        '
        Me.CheckIsRelease.Location = New System.Drawing.Point(12, 176)
        Me.CheckIsRelease.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsRelease.Name = "CheckIsRelease"
        Me.CheckIsRelease.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsRelease.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsRelease.Properties.Appearance.Options.UseFont = True
        Me.CheckIsRelease.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsRelease.Properties.Caption = "IsRelease"
        Me.CheckIsRelease.Size = New System.Drawing.Size(290, 22)
        Me.CheckIsRelease.StyleController = Me.LayoutControl1
        Me.CheckIsRelease.TabIndex = 22
        '
        'txt_Designation
        '
        Me.txt_Designation.Location = New System.Drawing.Point(81, 68)
        Me.txt_Designation.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Designation.Name = "txt_Designation"
        Me.txt_Designation.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Designation.Properties.Appearance.Options.UseFont = True
        Me.txt_Designation.Size = New System.Drawing.Size(803, 24)
        Me.txt_Designation.StyleController = Me.LayoutControl1
        Me.txt_Designation.TabIndex = 12
        '
        'CheckIsReceptionist
        '
        Me.CheckIsReceptionist.Location = New System.Drawing.Point(12, 150)
        Me.CheckIsReceptionist.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsReceptionist.Name = "CheckIsReceptionist"
        Me.CheckIsReceptionist.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsReceptionist.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsReceptionist.Properties.Appearance.Options.UseFont = True
        Me.CheckIsReceptionist.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsReceptionist.Properties.Caption = "IsReceptionist"
        Me.CheckIsReceptionist.Size = New System.Drawing.Size(290, 22)
        Me.CheckIsReceptionist.StyleController = Me.LayoutControl1
        Me.CheckIsReceptionist.TabIndex = 26
        '
        'CheckIsNewAccounts
        '
        Me.CheckIsNewAccounts.Location = New System.Drawing.Point(12, 124)
        Me.CheckIsNewAccounts.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIsNewAccounts.Name = "CheckIsNewAccounts"
        Me.CheckIsNewAccounts.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIsNewAccounts.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckIsNewAccounts.Properties.Appearance.Options.UseFont = True
        Me.CheckIsNewAccounts.Properties.Appearance.Options.UseForeColor = True
        Me.CheckIsNewAccounts.Properties.Caption = "IsNewAccounts"
        Me.CheckIsNewAccounts.Size = New System.Drawing.Size(290, 22)
        Me.CheckIsNewAccounts.StyleController = Me.LayoutControl1
        Me.CheckIsNewAccounts.TabIndex = 21
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem26})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(896, 315)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txt_username
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(293, 28)
        Me.LayoutControlItem1.Text = "Username"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(66, 15)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txt_pass
        Me.LayoutControlItem2.Location = New System.Drawing.Point(293, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(414, 28)
        Me.LayoutControlItem2.Text = "Password"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(66, 15)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.PassUpdate
        Me.LayoutControlItem3.Location = New System.Drawing.Point(707, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(169, 28)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txt_FName
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(293, 28)
        Me.LayoutControlItem4.Text = "First"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(66, 15)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txt_MI
        Me.LayoutControlItem5.Location = New System.Drawing.Point(293, 28)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(291, 28)
        Me.LayoutControlItem5.Text = "M.I."
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(66, 15)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txt_LName
        Me.LayoutControlItem6.Location = New System.Drawing.Point(584, 28)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(292, 28)
        Me.LayoutControlItem6.Text = "Last"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(66, 15)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txt_Designation
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 56)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(876, 28)
        Me.LayoutControlItem7.Text = "Designation"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(66, 15)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmb_Branch
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(94, 25)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(629, 28)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Branch"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(66, 15)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txt_brCode
        Me.LayoutControlItem9.Location = New System.Drawing.Point(629, 84)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(247, 28)
        Me.LayoutControlItem9.Text = " "
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(3, 15)
        Me.LayoutControlItem9.TextToControlDistance = 5
        Me.LayoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.CheckIsNewAccounts
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 112)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(294, 26)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.CheckIsAccounting
        Me.LayoutControlItem11.Location = New System.Drawing.Point(294, 112)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(295, 26)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.CheckIsReceptionist
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 138)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(294, 26)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.CheckIsRelease
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 164)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(294, 26)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.CheckIsCashier
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 190)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(294, 26)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.CheckIsCollection
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 216)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(294, 26)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.CheckIsLogistics
        Me.LayoutControlItem16.Location = New System.Drawing.Point(294, 138)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(295, 26)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.CheckIsSpareParts
        Me.LayoutControlItem17.Location = New System.Drawing.Point(294, 190)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(295, 26)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.CheckIsBookkeeper
        Me.LayoutControlItem18.Location = New System.Drawing.Point(294, 164)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(295, 26)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.CheckIsInventory
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 242)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(294, 53)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.CheckIsApprover
        Me.LayoutControlItem20.Location = New System.Drawing.Point(589, 138)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(287, 26)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.CheckIsAllowedBackDate
        Me.LayoutControlItem21.Location = New System.Drawing.Point(589, 112)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(287, 26)
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.CheckIsReports
        Me.LayoutControlItem22.Location = New System.Drawing.Point(589, 164)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(287, 26)
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.CheckIsAudit
        Me.LayoutControlItem23.Location = New System.Drawing.Point(294, 216)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(295, 79)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.CheckIsMaintenance
        Me.LayoutControlItem24.Location = New System.Drawing.Point(589, 190)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(287, 26)
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.CheckIsAdmin
        Me.LayoutControlItem25.Location = New System.Drawing.Point(589, 216)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(287, 26)
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.CheckIsSuperUser
        Me.LayoutControlItem26.Location = New System.Drawing.Point(589, 242)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(287, 53)
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextVisible = False
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.usermgmt)
        Me.TabPane1.Controls.Add(Me.resetAllPass)
        Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPane1.Location = New System.Drawing.Point(0, 24)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.usermgmt, Me.resetAllPass})
        Me.TabPane1.RegularSize = New System.Drawing.Size(919, 454)
        Me.TabPane1.SelectedPage = Me.usermgmt
        Me.TabPane1.Size = New System.Drawing.Size(919, 454)
        Me.TabPane1.TabIndex = 3
        Me.TabPane1.Text = "asds"
        '
        'usermgmt
        '
        Me.usermgmt.Caption = "USER MANAGEMENT"
        Me.usermgmt.Controls.Add(Me.usermgmtPanel)
        Me.usermgmt.Name = "usermgmt"
        Me.usermgmt.Size = New System.Drawing.Size(919, 427)
        '
        'usermgmtPanel
        '
        Me.usermgmtPanel.Controls.Add(Me.LayoutControl1)
        Me.usermgmtPanel.Location = New System.Drawing.Point(3, 3)
        Me.usermgmtPanel.Name = "usermgmtPanel"
        Me.usermgmtPanel.Size = New System.Drawing.Size(896, 315)
        Me.usermgmtPanel.TabIndex = 5
        '
        'resetAllPass
        '
        Me.resetAllPass.Caption = "RESET ALL PASSWORD"
        Me.resetAllPass.Controls.Add(Me.cmd_ResetAll)
        Me.resetAllPass.Controls.Add(Me.Label9)
        Me.resetAllPass.Controls.Add(Me.txt_Pass2Reset)
        Me.resetAllPass.Controls.Add(Me.Label8)
        Me.resetAllPass.Controls.Add(Me.txt_username2Reset)
        Me.resetAllPass.Name = "resetAllPass"
        Me.resetAllPass.Size = New System.Drawing.Size(921, 336)
        '
        'cmd_ResetAll
        '
        Me.cmd_ResetAll.ImageOptions.Image = CType(resources.GetObject("cmd_ResetAll.ImageOptions.Image"), System.Drawing.Image)
        Me.cmd_ResetAll.Location = New System.Drawing.Point(304, 66)
        Me.cmd_ResetAll.Name = "cmd_ResetAll"
        Me.cmd_ResetAll.Size = New System.Drawing.Size(75, 60)
        Me.cmd_ResetAll.TabIndex = 7
        Me.cmd_ResetAll.Text = "RESET"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(14, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "PASSWORD"
        '
        'txt_Pass2Reset
        '
        Me.txt_Pass2Reset.Location = New System.Drawing.Point(108, 99)
        Me.txt_Pass2Reset.Name = "txt_Pass2Reset"
        Me.txt_Pass2Reset.Size = New System.Drawing.Size(179, 22)
        Me.txt_Pass2Reset.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(14, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "USERNAME"
        '
        'txt_username2Reset
        '
        Me.txt_username2Reset.Location = New System.Drawing.Point(108, 66)
        Me.txt_username2Reset.Name = "txt_username2Reset"
        Me.txt_username2Reset.Size = New System.Drawing.Size(179, 22)
        Me.txt_username2Reset.TabIndex = 3
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Btn_New, Me.Btn_Save, Me.BarButtonItem3, Me.Btn_Update})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 4
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_New), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Update)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'Btn_New
        '
        Me.Btn_New.Caption = "New"
        Me.Btn_New.Id = 0
        Me.Btn_New.Name = "Btn_New"
        '
        'Btn_Save
        '
        Me.Btn_Save.Caption = "Register"
        Me.Btn_Save.Id = 1
        Me.Btn_Save.Name = "Btn_Save"
        '
        'Btn_Update
        '
        Me.Btn_Update.Caption = "Modify"
        Me.Btn_Update.Id = 3
        Me.Btn_Update.Name = "Btn_Update"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(919, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 478)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(919, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 454)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(919, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 454)
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Find"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'Admin_UserManagement
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 478)
        Me.Controls.Add(Me.TabPane1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IconOptions.Icon = CType(resources.GetObject("Admin_UserManagement.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Admin_UserManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USER MANAGEMENT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CheckIsAllowedBackDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckIsSuperUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsAdmin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsMaintenance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsAudit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsReports.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsApprover.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsAccounting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassUpdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsBookkeeper.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsSpareParts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_brCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_FName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsLogistics.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsCollection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsCashier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_LName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Branch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsRelease.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Designation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsReceptionist.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsNewAccounts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.usermgmt.ResumeLayout(False)
        Me.usermgmtPanel.ResumeLayout(False)
        Me.resetAllPass.ResumeLayout(False)
        Me.resetAllPass.PerformLayout()
        CType(Me.txt_Pass2Reset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_username2Reset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckIsSuperUser As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsSpareParts As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsLogistics As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsReceptionist As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsCashier As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsInventory As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsCollection As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsRelease As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsNewAccounts As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsBookkeeper As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsMaintenance As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsAudit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsAccounting As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsAdmin As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsApprover As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_brCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Designation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_LName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_MI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_FName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_pass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_username As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmb_Branch As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PassUpdate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsReports As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckIsAllowedBackDate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents usermgmt As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents resetAllPass As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents cmd_ResetAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Pass2Reset As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_username2Reset As DevExpress.XtraEditors.TextEdit
    Friend WithEvents usermgmtPanel As Panel
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
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
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Btn_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Update As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
