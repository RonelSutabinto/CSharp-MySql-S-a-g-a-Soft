Namespace Controls.Persons
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_User
        Inherits DevExpress.XtraEditors.XtraUserControl

        'UserControl overrides dispose to clean up the component list.
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
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.user_LName = New DevExpress.XtraEditors.TextEdit()
            Me.user_MName = New DevExpress.XtraEditors.TextEdit()
            Me.user_FName = New DevExpress.XtraEditors.TextEdit()
            Me.user_Full_Name = New DevExpress.XtraEditors.TextEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.Employee_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.User_Password = New DevExpress.XtraEditors.TextEdit()
            Me.User_Password2 = New DevExpress.XtraEditors.ButtonEdit()
            Me.User_Name = New DevExpress.XtraEditors.TextEdit()
            Me.user_Branch = New DevExpress.XtraEditors.LookUpEdit()
            Me.progress_Password_Stregnth = New DevExpress.XtraEditors.ProgressBarControl()
            Me.user_Approver = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.user_Position = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Corporation = New DevExpress.XtraEditors.LookUpEdit()
            Me.User_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.isSuperUser = New DevExpress.XtraEditors.ToggleSwitch()
            Me.isMaintenance = New DevExpress.XtraEditors.ToggleSwitch()
            Me.isLogistics = New DevExpress.XtraEditors.ToggleSwitch()
            Me.isAccounting = New DevExpress.XtraEditors.ToggleSwitch()
            Me.isAdministator = New DevExpress.XtraEditors.ToggleSwitch()
            Me.isApprover = New DevExpress.XtraEditors.ToggleSwitch()
            Me.isCollection = New DevExpress.XtraEditors.ToggleSwitch()
            Me.isCashier = New DevExpress.XtraEditors.ToggleSwitch()
            Me.isReceptionist = New DevExpress.XtraEditors.ToggleSwitch()
            Me.isBookkeeper = New DevExpress.XtraEditors.ToggleSwitch()
            Me.isSpareParts = New DevExpress.XtraEditors.ToggleSwitch()
            Me.isInventory = New DevExpress.XtraEditors.ToggleSwitch()
            Me.isNewAccounts = New DevExpress.XtraEditors.ToggleSwitch()
            Me.isRelease = New DevExpress.XtraEditors.ToggleSwitch()
            Me.IsReports = New DevExpress.XtraEditors.ToggleSwitch()
            Me.isBackDate = New DevExpress.XtraEditors.ToggleSwitch()
            Me.IsUpdate = New DevExpress.XtraEditors.ToggleSwitch()
            Me.IsBetaTester = New DevExpress.XtraEditors.ToggleSwitch()
            Me.isAudit = New DevExpress.XtraEditors.ToggleSwitch()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.XtraTabControl = New DevExpress.XtraLayout.TabbedControlGroup()
            Me.XtraTabPage2item = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.user_Approveritem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.user_Positionitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.XtraTabPage1item = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.IDitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.User_Passworditem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.User_Password2item = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Corporationitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.User_Nameitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.user_Branchitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.progress_Password_Stregnthitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.XtraTabPage3item = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.IsAccountingitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IsLogisticsitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IsAudititem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.IsAdministatoritem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IsApproveritem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IsCollectionitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IsCashieritem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.IsReceptionistitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IsSparePartsitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IsReportsitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IsBackDateitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IsNewAccountsitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IsReleaseitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IsBookkeeperitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IsInventoryitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.IsSuperUseritem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IsMaintenanceitem = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.user_LName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.user_MName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.user_FName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.user_Full_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Employee_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.User_Password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.User_Password2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.User_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.user_Branch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.progress_Password_Stregnth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.user_Approver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.user_Position.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Corporation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.User_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isSuperUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isMaintenance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isLogistics.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isAccounting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isAdministator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isApprover.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isCollection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isCashier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isReceptionist.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isBookkeeper.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isSpareParts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isNewAccounts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isRelease.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsReports.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isBackDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsUpdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsBetaTester.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isAudit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XtraTabPage2item, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.user_Approveritem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.user_Positionitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XtraTabPage1item, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IDitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.User_Passworditem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.User_Password2item, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Corporationitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.User_Nameitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.user_Branchitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.progress_Password_Stregnthitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XtraTabPage3item, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsAccountingitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsLogisticsitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsAudititem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsAdministatoritem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsApproveritem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsCollectionitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsCashieritem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsReceptionistitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsSparePartsitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsReportsitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsBackDateitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsNewAccountsitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsReleaseitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsBookkeeperitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsInventoryitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsSuperUseritem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsMaintenanceitem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ID
            '
            Me.ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ID.Location = New System.Drawing.Point(104, 47)
            Me.ID.Name = "ID"
            Me.ID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.ID.Size = New System.Drawing.Size(272, 20)
            Me.ID.StyleController = Me.layoutControl
            Me.ID.TabIndex = 0
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.user_LName)
            Me.layoutControl.Controls.Add(Me.user_MName)
            Me.layoutControl.Controls.Add(Me.user_FName)
            Me.layoutControl.Controls.Add(Me.user_Full_Name)
            Me.layoutControl.Controls.Add(Me.Notes)
            Me.layoutControl.Controls.Add(Me.Employee_Code)
            Me.layoutControl.Controls.Add(Me.ID)
            Me.layoutControl.Controls.Add(Me.User_Password)
            Me.layoutControl.Controls.Add(Me.User_Password2)
            Me.layoutControl.Controls.Add(Me.User_Name)
            Me.layoutControl.Controls.Add(Me.user_Branch)
            Me.layoutControl.Controls.Add(Me.progress_Password_Stregnth)
            Me.layoutControl.Controls.Add(Me.user_Approver)
            Me.layoutControl.Controls.Add(Me.user_Position)
            Me.layoutControl.Controls.Add(Me.Corporation)
            Me.layoutControl.Controls.Add(Me.User_Description)
            Me.layoutControl.Controls.Add(Me.isSuperUser)
            Me.layoutControl.Controls.Add(Me.isMaintenance)
            Me.layoutControl.Controls.Add(Me.isLogistics)
            Me.layoutControl.Controls.Add(Me.isAccounting)
            Me.layoutControl.Controls.Add(Me.isAdministator)
            Me.layoutControl.Controls.Add(Me.isApprover)
            Me.layoutControl.Controls.Add(Me.isCollection)
            Me.layoutControl.Controls.Add(Me.isCashier)
            Me.layoutControl.Controls.Add(Me.isReceptionist)
            Me.layoutControl.Controls.Add(Me.isBookkeeper)
            Me.layoutControl.Controls.Add(Me.isSpareParts)
            Me.layoutControl.Controls.Add(Me.isInventory)
            Me.layoutControl.Controls.Add(Me.isNewAccounts)
            Me.layoutControl.Controls.Add(Me.isRelease)
            Me.layoutControl.Controls.Add(Me.IsReports)
            Me.layoutControl.Controls.Add(Me.isBackDate)
            Me.layoutControl.Controls.Add(Me.IsUpdate)
            Me.layoutControl.Controls.Add(Me.IsBetaTester)
            Me.layoutControl.Controls.Add(Me.isAudit)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(696, 41, 650, 400)
            Me.layoutControl.Root = Me.LayoutControlGroup1
            Me.layoutControl.Size = New System.Drawing.Size(400, 550)
            Me.layoutControl.TabIndex = 0
            '
            'user_LName
            '
            Me.user_LName.Location = New System.Drawing.Point(104, 95)
            Me.user_LName.Name = "user_LName"
            Me.user_LName.Size = New System.Drawing.Size(272, 20)
            Me.user_LName.StyleController = Me.layoutControl
            Me.user_LName.TabIndex = 2
            '
            'user_MName
            '
            Me.user_MName.Location = New System.Drawing.Point(104, 71)
            Me.user_MName.Name = "user_MName"
            Me.user_MName.Size = New System.Drawing.Size(272, 20)
            Me.user_MName.StyleController = Me.layoutControl
            Me.user_MName.TabIndex = 1
            '
            'user_FName
            '
            Me.user_FName.Location = New System.Drawing.Point(104, 47)
            Me.user_FName.Name = "user_FName"
            Me.user_FName.Size = New System.Drawing.Size(272, 20)
            Me.user_FName.StyleController = Me.layoutControl
            Me.user_FName.TabIndex = 0
            '
            'user_Full_Name
            '
            Me.user_Full_Name.Location = New System.Drawing.Point(104, 119)
            Me.user_Full_Name.Name = "user_Full_Name"
            Me.user_Full_Name.Size = New System.Drawing.Size(272, 20)
            Me.user_Full_Name.StyleController = Me.layoutControl
            Me.user_Full_Name.TabIndex = 3
            '
            'Notes
            '
            Me.Notes.Location = New System.Drawing.Point(104, 251)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(272, 275)
            Me.Notes.StyleController = Me.layoutControl
            Me.Notes.TabIndex = 7
            '
            'Employee_Code
            '
            Me.Employee_Code.Location = New System.Drawing.Point(104, 119)
            Me.Employee_Code.Name = "Employee_Code"
            Me.Employee_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Employee_Code.Size = New System.Drawing.Size(272, 20)
            Me.Employee_Code.StyleController = Me.layoutControl
            Me.Employee_Code.TabIndex = 3
            '
            'User_Password
            '
            Me.User_Password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.User_Password.Location = New System.Drawing.Point(104, 167)
            Me.User_Password.Name = "User_Password"
            Me.User_Password.Properties.UseSystemPasswordChar = True
            Me.User_Password.Size = New System.Drawing.Size(272, 20)
            Me.User_Password.StyleController = Me.layoutControl
            Me.User_Password.TabIndex = 5
            '
            'User_Password2
            '
            Me.User_Password2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.User_Password2.Location = New System.Drawing.Point(104, 191)
            Me.User_Password2.Name = "User_Password2"
            Me.User_Password2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
            Me.User_Password2.Properties.UseSystemPasswordChar = True
            Me.User_Password2.Size = New System.Drawing.Size(272, 20)
            Me.User_Password2.StyleController = Me.layoutControl
            Me.User_Password2.TabIndex = 6
            '
            'User_Name
            '
            Me.User_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.User_Name.Location = New System.Drawing.Point(104, 143)
            Me.User_Name.Name = "User_Name"
            Me.User_Name.Size = New System.Drawing.Size(272, 20)
            Me.User_Name.StyleController = Me.layoutControl
            Me.User_Name.TabIndex = 4
            '
            'user_Branch
            '
            Me.user_Branch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.user_Branch.Location = New System.Drawing.Point(104, 95)
            Me.user_Branch.Name = "user_Branch"
            Me.user_Branch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.user_Branch.Size = New System.Drawing.Size(272, 20)
            Me.user_Branch.StyleController = Me.layoutControl
            Me.user_Branch.TabIndex = 2
            '
            'progress_Password_Stregnth
            '
            Me.progress_Password_Stregnth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.progress_Password_Stregnth.Location = New System.Drawing.Point(104, 215)
            Me.progress_Password_Stregnth.Name = "progress_Password_Stregnth"
            Me.progress_Password_Stregnth.Properties.ShowTitle = True
            Me.progress_Password_Stregnth.Size = New System.Drawing.Size(272, 18)
            Me.progress_Password_Stregnth.StyleController = Me.layoutControl
            Me.progress_Password_Stregnth.TabIndex = 7
            '
            'user_Approver
            '
            Me.user_Approver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.user_Approver.Location = New System.Drawing.Point(104, 167)
            Me.user_Approver.Name = "user_Approver"
            Me.user_Approver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.user_Approver.Size = New System.Drawing.Size(272, 20)
            Me.user_Approver.StyleController = Me.layoutControl
            Me.user_Approver.TabIndex = 5
            '
            'user_Position
            '
            Me.user_Position.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.user_Position.Location = New System.Drawing.Point(104, 143)
            Me.user_Position.Name = "user_Position"
            Me.user_Position.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.user_Position.Size = New System.Drawing.Size(272, 20)
            Me.user_Position.StyleController = Me.layoutControl
            Me.user_Position.TabIndex = 4
            '
            'Corporation
            '
            Me.Corporation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Corporation.Location = New System.Drawing.Point(104, 71)
            Me.Corporation.Name = "Corporation"
            Me.Corporation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Corporation.Properties.NullText = ""
            Me.Corporation.Properties.PopupSizeable = False
            Me.Corporation.Size = New System.Drawing.Size(272, 20)
            Me.Corporation.StyleController = Me.layoutControl
            Me.Corporation.TabIndex = 1
            '
            'User_Description
            '
            Me.User_Description.Location = New System.Drawing.Point(104, 191)
            Me.User_Description.Name = "User_Description"
            Me.User_Description.Size = New System.Drawing.Size(272, 46)
            Me.User_Description.StyleController = Me.layoutControl
            Me.User_Description.TabIndex = 6
            '
            'isSuperUser
            '
            Me.isSuperUser.Location = New System.Drawing.Point(116, 80)
            Me.isSuperUser.Name = "isSuperUser"
            Me.isSuperUser.Properties.OffText = "Off"
            Me.isSuperUser.Properties.OnText = "On"
            Me.isSuperUser.Size = New System.Drawing.Size(82, 18)
            Me.isSuperUser.StyleController = Me.layoutControl
            Me.isSuperUser.TabIndex = 0
            '
            'isMaintenance
            '
            Me.isMaintenance.Location = New System.Drawing.Point(282, 80)
            Me.isMaintenance.Name = "isMaintenance"
            Me.isMaintenance.Properties.OffText = "Off"
            Me.isMaintenance.Properties.OnText = "On"
            Me.isMaintenance.Size = New System.Drawing.Size(82, 18)
            Me.isMaintenance.StyleController = Me.layoutControl
            Me.isMaintenance.TabIndex = 1
            '
            'isLogistics
            '
            Me.isLogistics.Location = New System.Drawing.Point(116, 147)
            Me.isLogistics.Name = "isLogistics"
            Me.isLogistics.Properties.OffText = "Off"
            Me.isLogistics.Properties.OnText = "On"
            Me.isLogistics.Size = New System.Drawing.Size(82, 18)
            Me.isLogistics.StyleController = Me.layoutControl
            Me.isLogistics.TabIndex = 2
            '
            'isAccounting
            '
            Me.isAccounting.Location = New System.Drawing.Point(282, 147)
            Me.isAccounting.Name = "isAccounting"
            Me.isAccounting.Properties.OffText = "Off"
            Me.isAccounting.Properties.OnText = "On"
            Me.isAccounting.Size = New System.Drawing.Size(82, 18)
            Me.isAccounting.StyleController = Me.layoutControl
            Me.isAccounting.TabIndex = 4
            '
            'isAdministator
            '
            Me.isAdministator.Location = New System.Drawing.Point(116, 236)
            Me.isAdministator.Name = "isAdministator"
            Me.isAdministator.Properties.OffText = "Off"
            Me.isAdministator.Properties.OnText = "On"
            Me.isAdministator.Size = New System.Drawing.Size(82, 18)
            Me.isAdministator.StyleController = Me.layoutControl
            Me.isAdministator.TabIndex = 5
            '
            'isApprover
            '
            Me.isApprover.Location = New System.Drawing.Point(116, 258)
            Me.isApprover.Name = "isApprover"
            Me.isApprover.Properties.OffText = "Off"
            Me.isApprover.Properties.OnText = "On"
            Me.isApprover.Size = New System.Drawing.Size(82, 18)
            Me.isApprover.StyleController = Me.layoutControl
            Me.isApprover.TabIndex = 6
            '
            'isCollection
            '
            Me.isCollection.Location = New System.Drawing.Point(282, 236)
            Me.isCollection.Name = "isCollection"
            Me.isCollection.Properties.OffText = "Off"
            Me.isCollection.Properties.OnText = "On"
            Me.isCollection.Size = New System.Drawing.Size(82, 18)
            Me.isCollection.StyleController = Me.layoutControl
            Me.isCollection.TabIndex = 7
            '
            'isCashier
            '
            Me.isCashier.Location = New System.Drawing.Point(282, 258)
            Me.isCashier.Name = "isCashier"
            Me.isCashier.Properties.OffText = "Off"
            Me.isCashier.Properties.OnText = "On"
            Me.isCashier.Size = New System.Drawing.Size(82, 18)
            Me.isCashier.StyleController = Me.layoutControl
            Me.isCashier.TabIndex = 8
            '
            'isReceptionist
            '
            Me.isReceptionist.Location = New System.Drawing.Point(116, 325)
            Me.isReceptionist.Name = "isReceptionist"
            Me.isReceptionist.Properties.OffText = "Off"
            Me.isReceptionist.Properties.OnText = "On"
            Me.isReceptionist.Size = New System.Drawing.Size(82, 18)
            Me.isReceptionist.StyleController = Me.layoutControl
            Me.isReceptionist.TabIndex = 9
            '
            'isBookkeeper
            '
            Me.isBookkeeper.Location = New System.Drawing.Point(116, 347)
            Me.isBookkeeper.Name = "isBookkeeper"
            Me.isBookkeeper.Properties.OffText = "Off"
            Me.isBookkeeper.Properties.OnText = "On"
            Me.isBookkeeper.Size = New System.Drawing.Size(82, 18)
            Me.isBookkeeper.StyleController = Me.layoutControl
            Me.isBookkeeper.TabIndex = 10
            '
            'isSpareParts
            '
            Me.isSpareParts.Location = New System.Drawing.Point(116, 369)
            Me.isSpareParts.Name = "isSpareParts"
            Me.isSpareParts.Properties.OffText = "Off"
            Me.isSpareParts.Properties.OnText = "On"
            Me.isSpareParts.Size = New System.Drawing.Size(82, 18)
            Me.isSpareParts.StyleController = Me.layoutControl
            Me.isSpareParts.TabIndex = 11
            '
            'isInventory
            '
            Me.isInventory.Location = New System.Drawing.Point(116, 391)
            Me.isInventory.Name = "isInventory"
            Me.isInventory.Properties.OffText = "Off"
            Me.isInventory.Properties.OnText = "On"
            Me.isInventory.Size = New System.Drawing.Size(82, 18)
            Me.isInventory.StyleController = Me.layoutControl
            Me.isInventory.TabIndex = 12
            '
            'isNewAccounts
            '
            Me.isNewAccounts.Location = New System.Drawing.Point(282, 325)
            Me.isNewAccounts.Name = "isNewAccounts"
            Me.isNewAccounts.Properties.OffText = "Off"
            Me.isNewAccounts.Properties.OnText = "On"
            Me.isNewAccounts.Size = New System.Drawing.Size(82, 18)
            Me.isNewAccounts.StyleController = Me.layoutControl
            Me.isNewAccounts.TabIndex = 13
            '
            'isRelease
            '
            Me.isRelease.Location = New System.Drawing.Point(282, 347)
            Me.isRelease.Name = "isRelease"
            Me.isRelease.Properties.OffText = "Off"
            Me.isRelease.Properties.OnText = "On"
            Me.isRelease.Size = New System.Drawing.Size(82, 18)
            Me.isRelease.StyleController = Me.layoutControl
            Me.isRelease.TabIndex = 14
            '
            'IsReports
            '
            Me.IsReports.Location = New System.Drawing.Point(282, 369)
            Me.IsReports.Name = "IsReports"
            Me.IsReports.Properties.OffText = "Off"
            Me.IsReports.Properties.OnText = "On"
            Me.IsReports.Size = New System.Drawing.Size(82, 18)
            Me.IsReports.StyleController = Me.layoutControl
            Me.IsReports.TabIndex = 15
            '
            'isBackDate
            '
            Me.isBackDate.Location = New System.Drawing.Point(282, 391)
            Me.isBackDate.Name = "isBackDate"
            Me.isBackDate.Properties.OffText = "Off"
            Me.isBackDate.Properties.OnText = "On"
            Me.isBackDate.Size = New System.Drawing.Size(82, 18)
            Me.isBackDate.StyleController = Me.layoutControl
            Me.isBackDate.TabIndex = 16
            '
            'IsUpdate
            '
            Me.IsUpdate.Location = New System.Drawing.Point(116, 458)
            Me.IsUpdate.Name = "IsUpdate"
            Me.IsUpdate.Properties.OffText = "Off"
            Me.IsUpdate.Properties.OnText = "On"
            Me.IsUpdate.Size = New System.Drawing.Size(82, 18)
            Me.IsUpdate.StyleController = Me.layoutControl
            Me.IsUpdate.TabIndex = 17
            '
            'IsBetaTester
            '
            Me.IsBetaTester.Location = New System.Drawing.Point(282, 458)
            Me.IsBetaTester.Name = "IsBetaTester"
            Me.IsBetaTester.Properties.OffText = "Off"
            Me.IsBetaTester.Properties.OnText = "On"
            Me.IsBetaTester.Size = New System.Drawing.Size(82, 18)
            Me.IsBetaTester.StyleController = Me.layoutControl
            Me.IsBetaTester.TabIndex = 18
            '
            'isAudit
            '
            Me.isAudit.Location = New System.Drawing.Point(116, 169)
            Me.isAudit.Name = "isAudit"
            Me.isAudit.Properties.OffText = "Off"
            Me.isAudit.Properties.OnText = "On"
            Me.isAudit.Size = New System.Drawing.Size(248, 18)
            Me.isAudit.StyleController = Me.layoutControl
            Me.isAudit.TabIndex = 3
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.XtraTabControl})
            Me.LayoutControlGroup1.Name = "Root"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(400, 550)
            Me.LayoutControlGroup1.TextVisible = False
            '
            'XtraTabControl
            '
            Me.XtraTabControl.Location = New System.Drawing.Point(0, 0)
            Me.XtraTabControl.Name = "XtraTabControl"
            Me.XtraTabControl.SelectedTabPage = Me.XtraTabPage1item
            Me.XtraTabControl.Size = New System.Drawing.Size(380, 530)
            Me.XtraTabControl.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.XtraTabPage1item, Me.XtraTabPage2item, Me.XtraTabPage3item})
            '
            'XtraTabPage2item
            '
            Me.XtraTabPage2item.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.user_Approveritem, Me.user_Positionitem, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem3, Me.LayoutControlItem9, Me.SplitterItem1})
            Me.XtraTabPage2item.Location = New System.Drawing.Point(0, 0)
            Me.XtraTabPage2item.Name = "XtraTabPage2item"
            Me.XtraTabPage2item.Size = New System.Drawing.Size(356, 483)
            Me.XtraTabPage2item.Text = "Information"
            '
            'user_Approveritem
            '
            Me.user_Approveritem.Control = Me.user_Approver
            Me.user_Approveritem.Location = New System.Drawing.Point(0, 120)
            Me.user_Approveritem.Name = "user_Approveritem"
            Me.user_Approveritem.Size = New System.Drawing.Size(356, 24)
            Me.user_Approveritem.Text = "Approver"
            Me.user_Approveritem.TextLocation = DevExpress.Utils.Locations.Left
            Me.user_Approveritem.TextSize = New System.Drawing.Size(68, 13)
            '
            'user_Positionitem
            '
            Me.user_Positionitem.Control = Me.user_Position
            Me.user_Positionitem.Location = New System.Drawing.Point(0, 96)
            Me.user_Positionitem.Name = "user_Positionitem"
            Me.user_Positionitem.Size = New System.Drawing.Size(356, 24)
            Me.user_Positionitem.Text = "Position"
            Me.user_Positionitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.user_Positionitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Notes
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 204)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(356, 279)
            Me.LayoutControlItem2.Text = "Notes"
            Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.user_FName
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(356, 24)
            Me.LayoutControlItem4.Text = "First Name"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.user_MName
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(356, 24)
            Me.LayoutControlItem5.Text = "Middle Initial"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.user_LName
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(356, 24)
            Me.LayoutControlItem6.Text = "Last Name"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.user_Full_Name
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(356, 24)
            Me.LayoutControlItem3.Text = "Full Name"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem9
            '
            Me.LayoutControlItem9.Control = Me.User_Description
            Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 144)
            Me.LayoutControlItem9.Name = "LayoutControlItem9"
            Me.LayoutControlItem9.Size = New System.Drawing.Size(356, 50)
            Me.LayoutControlItem9.Text = "Description"
            Me.LayoutControlItem9.TextSize = New System.Drawing.Size(68, 13)
            '
            'SplitterItem1
            '
            Me.SplitterItem1.AllowHotTrack = True
            Me.SplitterItem1.Location = New System.Drawing.Point(0, 194)
            Me.SplitterItem1.Name = "SplitterItem1"
            Me.SplitterItem1.Size = New System.Drawing.Size(356, 10)
            '
            'XtraTabPage1item
            '
            Me.XtraTabPage1item.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.IDitem, Me.User_Passworditem, Me.User_Password2item, Me.Corporationitem, Me.User_Nameitem, Me.user_Branchitem, Me.progress_Password_Stregnthitem, Me.LayoutControlItem1})
            Me.XtraTabPage1item.Location = New System.Drawing.Point(0, 0)
            Me.XtraTabPage1item.Name = "XtraTabPage1item"
            Me.XtraTabPage1item.Size = New System.Drawing.Size(356, 483)
            Me.XtraTabPage1item.Text = "Security"
            '
            'IDitem
            '
            Me.IDitem.Control = Me.ID
            Me.IDitem.Location = New System.Drawing.Point(0, 0)
            Me.IDitem.Name = "IDitem"
            Me.IDitem.Size = New System.Drawing.Size(356, 24)
            Me.IDitem.Text = "ID"
            Me.IDitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.IDitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'User_Passworditem
            '
            Me.User_Passworditem.Control = Me.User_Password
            Me.User_Passworditem.Location = New System.Drawing.Point(0, 120)
            Me.User_Passworditem.Name = "User_Passworditem"
            Me.User_Passworditem.Size = New System.Drawing.Size(356, 24)
            Me.User_Passworditem.Text = "Password"
            Me.User_Passworditem.TextLocation = DevExpress.Utils.Locations.Left
            Me.User_Passworditem.TextSize = New System.Drawing.Size(68, 13)
            '
            'User_Password2item
            '
            Me.User_Password2item.Control = Me.User_Password2
            Me.User_Password2item.Location = New System.Drawing.Point(0, 144)
            Me.User_Password2item.Name = "User_Password2item"
            Me.User_Password2item.Size = New System.Drawing.Size(356, 24)
            Me.User_Password2item.Text = "Confirm"
            Me.User_Password2item.TextLocation = DevExpress.Utils.Locations.Left
            Me.User_Password2item.TextSize = New System.Drawing.Size(68, 13)
            '
            'Corporationitem
            '
            Me.Corporationitem.Control = Me.Corporation
            Me.Corporationitem.Location = New System.Drawing.Point(0, 24)
            Me.Corporationitem.Name = "Corporationitem"
            Me.Corporationitem.Size = New System.Drawing.Size(356, 24)
            Me.Corporationitem.Text = "Corporation"
            Me.Corporationitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Corporationitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'User_Nameitem
            '
            Me.User_Nameitem.Control = Me.User_Name
            Me.User_Nameitem.Location = New System.Drawing.Point(0, 96)
            Me.User_Nameitem.Name = "User_Nameitem"
            Me.User_Nameitem.Size = New System.Drawing.Size(356, 24)
            Me.User_Nameitem.Text = "User Name"
            Me.User_Nameitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.User_Nameitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'user_Branchitem
            '
            Me.user_Branchitem.Control = Me.user_Branch
            Me.user_Branchitem.Location = New System.Drawing.Point(0, 48)
            Me.user_Branchitem.Name = "user_Branchitem"
            Me.user_Branchitem.Size = New System.Drawing.Size(356, 24)
            Me.user_Branchitem.Text = "Branch"
            Me.user_Branchitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.user_Branchitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'progress_Password_Stregnthitem
            '
            Me.progress_Password_Stregnthitem.Control = Me.progress_Password_Stregnth
            Me.progress_Password_Stregnthitem.Location = New System.Drawing.Point(0, 168)
            Me.progress_Password_Stregnthitem.Name = "progress_Password_Stregnthitem"
            Me.progress_Password_Stregnthitem.Size = New System.Drawing.Size(356, 315)
            Me.progress_Password_Stregnthitem.Text = "Stregnth"
            Me.progress_Password_Stregnthitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.Employee_Code
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(356, 24)
            Me.LayoutControlItem1.Text = "Name"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(68, 13)
            '
            'XtraTabPage3item
            '
            Me.XtraTabPage3item.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.LayoutControlGroup6, Me.EmptySpaceItem1, Me.LayoutControlGroup2})
            Me.XtraTabPage3item.Location = New System.Drawing.Point(0, 0)
            Me.XtraTabPage3item.Name = "XtraTabPage3item"
            Me.XtraTabPage3item.Size = New System.Drawing.Size(356, 483)
            Me.XtraTabPage3item.Text = "Privileges"
            '
            'LayoutControlGroup3
            '
            Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.IsAccountingitem, Me.IsLogisticsitem, Me.IsAudititem})
            Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 67)
            Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
            Me.LayoutControlGroup3.Size = New System.Drawing.Size(356, 89)
            Me.LayoutControlGroup3.Text = "Level 2"
            '
            'IsAccountingitem
            '
            Me.IsAccountingitem.Control = Me.isAccounting
            Me.IsAccountingitem.Location = New System.Drawing.Point(166, 0)
            Me.IsAccountingitem.Name = "isAccountingitem"
            Me.IsAccountingitem.Size = New System.Drawing.Size(166, 22)
            Me.IsAccountingitem.Text = "Accounting"
            Me.IsAccountingitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'IsLogisticsitem
            '
            Me.IsLogisticsitem.Control = Me.isLogistics
            Me.IsLogisticsitem.Location = New System.Drawing.Point(0, 0)
            Me.IsLogisticsitem.Name = "isLogisticsitem"
            Me.IsLogisticsitem.Size = New System.Drawing.Size(166, 22)
            Me.IsLogisticsitem.Text = "Logistics"
            Me.IsLogisticsitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'IsAudititem
            '
            Me.IsAudititem.Control = Me.isAudit
            Me.IsAudititem.Location = New System.Drawing.Point(0, 22)
            Me.IsAudititem.Name = "isAudititem"
            Me.IsAudititem.Size = New System.Drawing.Size(332, 22)
            Me.IsAudititem.Text = "Audit"
            Me.IsAudititem.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlGroup4
            '
            Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.IsAdministatoritem, Me.IsApproveritem, Me.IsCollectionitem, Me.IsCashieritem})
            Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 156)
            Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
            Me.LayoutControlGroup4.Size = New System.Drawing.Size(356, 89)
            Me.LayoutControlGroup4.Text = "Level 3"
            '
            'IsAdministatoritem
            '
            Me.IsAdministatoritem.Control = Me.isAdministator
            Me.IsAdministatoritem.Location = New System.Drawing.Point(0, 0)
            Me.IsAdministatoritem.Name = "isAdministatoritem"
            Me.IsAdministatoritem.Size = New System.Drawing.Size(166, 22)
            Me.IsAdministatoritem.Text = "Administrative"
            Me.IsAdministatoritem.TextSize = New System.Drawing.Size(68, 13)
            '
            'IsApproveritem
            '
            Me.IsApproveritem.Control = Me.isApprover
            Me.IsApproveritem.Location = New System.Drawing.Point(0, 22)
            Me.IsApproveritem.Name = "isApproveritem"
            Me.IsApproveritem.Size = New System.Drawing.Size(166, 22)
            Me.IsApproveritem.Text = "Approver"
            Me.IsApproveritem.TextSize = New System.Drawing.Size(68, 13)
            '
            'IsCollectionitem
            '
            Me.IsCollectionitem.Control = Me.isCollection
            Me.IsCollectionitem.Location = New System.Drawing.Point(166, 0)
            Me.IsCollectionitem.Name = "isCollectionitem"
            Me.IsCollectionitem.Size = New System.Drawing.Size(166, 22)
            Me.IsCollectionitem.Text = "Collection"
            Me.IsCollectionitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'IsCashieritem
            '
            Me.IsCashieritem.Control = Me.isCashier
            Me.IsCashieritem.Location = New System.Drawing.Point(166, 22)
            Me.IsCashieritem.Name = "isCashieritem"
            Me.IsCashieritem.Size = New System.Drawing.Size(166, 22)
            Me.IsCashieritem.Text = "Cashier"
            Me.IsCashieritem.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlGroup5
            '
            Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.IsReceptionistitem, Me.IsSparePartsitem, Me.IsReportsitem, Me.IsBackDateitem, Me.IsNewAccountsitem, Me.IsReleaseitem, Me.IsBookkeeperitem, Me.IsInventoryitem})
            Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 245)
            Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
            Me.LayoutControlGroup5.Size = New System.Drawing.Size(356, 133)
            Me.LayoutControlGroup5.Text = "Level 4"
            '
            'IsReceptionistitem
            '
            Me.IsReceptionistitem.Control = Me.isReceptionist
            Me.IsReceptionistitem.Location = New System.Drawing.Point(0, 0)
            Me.IsReceptionistitem.Name = "isReceptionistitem"
            Me.IsReceptionistitem.Size = New System.Drawing.Size(166, 22)
            Me.IsReceptionistitem.Text = "Receptionist"
            Me.IsReceptionistitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'IsSparePartsitem
            '
            Me.IsSparePartsitem.Control = Me.isSpareParts
            Me.IsSparePartsitem.Location = New System.Drawing.Point(0, 44)
            Me.IsSparePartsitem.Name = "isSparePartsitem"
            Me.IsSparePartsitem.Size = New System.Drawing.Size(166, 22)
            Me.IsSparePartsitem.Text = "Spare Parts"
            Me.IsSparePartsitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'IsReportsitem
            '
            Me.IsReportsitem.Control = Me.IsReports
            Me.IsReportsitem.Location = New System.Drawing.Point(166, 44)
            Me.IsReportsitem.Name = "isReportsitem"
            Me.IsReportsitem.Size = New System.Drawing.Size(166, 22)
            Me.IsReportsitem.Text = "Reports"
            Me.IsReportsitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'IsBackDateitem
            '
            Me.IsBackDateitem.Control = Me.isBackDate
            Me.IsBackDateitem.Location = New System.Drawing.Point(166, 66)
            Me.IsBackDateitem.Name = "isBackDateitem"
            Me.IsBackDateitem.Size = New System.Drawing.Size(166, 22)
            Me.IsBackDateitem.Text = "Back Date"
            Me.IsBackDateitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'IsNewAccountsitem
            '
            Me.IsNewAccountsitem.Control = Me.isNewAccounts
            Me.IsNewAccountsitem.Location = New System.Drawing.Point(166, 0)
            Me.IsNewAccountsitem.Name = "isNewAccountsitem"
            Me.IsNewAccountsitem.Size = New System.Drawing.Size(166, 22)
            Me.IsNewAccountsitem.Text = "New Account"
            Me.IsNewAccountsitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'IsReleaseitem
            '
            Me.IsReleaseitem.Control = Me.isRelease
            Me.IsReleaseitem.Location = New System.Drawing.Point(166, 22)
            Me.IsReleaseitem.Name = "isReleaseitem"
            Me.IsReleaseitem.Size = New System.Drawing.Size(166, 22)
            Me.IsReleaseitem.Text = "Release"
            Me.IsReleaseitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'IsBookkeeperitem
            '
            Me.IsBookkeeperitem.Control = Me.isBookkeeper
            Me.IsBookkeeperitem.Location = New System.Drawing.Point(0, 22)
            Me.IsBookkeeperitem.Name = "isBookkeeperitem"
            Me.IsBookkeeperitem.Size = New System.Drawing.Size(166, 22)
            Me.IsBookkeeperitem.Text = "Bookkeeper"
            Me.IsBookkeeperitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'IsInventoryitem
            '
            Me.IsInventoryitem.Control = Me.isInventory
            Me.IsInventoryitem.Location = New System.Drawing.Point(0, 66)
            Me.IsInventoryitem.Name = "isInventoryitem"
            Me.IsInventoryitem.Size = New System.Drawing.Size(166, 22)
            Me.IsInventoryitem.Text = "Inventory"
            Me.IsInventoryitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlGroup6
            '
            Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem7})
            Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 378)
            Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
            Me.LayoutControlGroup6.Size = New System.Drawing.Size(356, 67)
            Me.LayoutControlGroup6.Text = "Level 5"
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.IsUpdate
            Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(166, 22)
            Me.LayoutControlItem8.Text = "Update"
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.IsBetaTester
            Me.LayoutControlItem7.Location = New System.Drawing.Point(166, 0)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(166, 22)
            Me.LayoutControlItem7.Text = "Tester"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(68, 13)
            '
            'EmptySpaceItem1
            '
            Me.EmptySpaceItem1.AllowHotTrack = False
            Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 445)
            Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
            Me.EmptySpaceItem1.Size = New System.Drawing.Size(356, 38)
            Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'LayoutControlGroup2
            '
            Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.IsSuperUseritem, Me.IsMaintenanceitem})
            Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
            Me.LayoutControlGroup2.Size = New System.Drawing.Size(356, 67)
            Me.LayoutControlGroup2.Text = "Level 1"
            '
            'IsSuperUseritem
            '
            Me.IsSuperUseritem.Control = Me.isSuperUser
            Me.IsSuperUseritem.Location = New System.Drawing.Point(0, 0)
            Me.IsSuperUseritem.Name = "isSuperUseritem"
            Me.IsSuperUseritem.Size = New System.Drawing.Size(166, 22)
            Me.IsSuperUseritem.Text = "Administrator"
            Me.IsSuperUseritem.TextSize = New System.Drawing.Size(68, 13)
            '
            'IsMaintenanceitem
            '
            Me.IsMaintenanceitem.Control = Me.isMaintenance
            Me.IsMaintenanceitem.Location = New System.Drawing.Point(166, 0)
            Me.IsMaintenanceitem.Name = "isMaintenanceitem"
            Me.IsMaintenanceitem.Size = New System.Drawing.Size(166, 22)
            Me.IsMaintenanceitem.Text = "Maintenance"
            Me.IsMaintenanceitem.TextSize = New System.Drawing.Size(68, 13)
            '
            'xuc_User
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "xuc_User"
            Me.Size = New System.Drawing.Size(400, 550)
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.user_LName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.user_MName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.user_FName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.user_Full_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Employee_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.User_Password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.User_Password2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.User_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.user_Branch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.progress_Password_Stregnth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.user_Approver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.user_Position.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Corporation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.User_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isSuperUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isMaintenance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isLogistics.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isAccounting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isAdministator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isApprover.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isCollection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isCashier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isReceptionist.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isBookkeeper.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isSpareParts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isNewAccounts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isRelease.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsReports.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isBackDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsUpdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsBetaTester.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isAudit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XtraTabPage2item, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.user_Approveritem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.user_Positionitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XtraTabPage1item, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IDitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.User_Passworditem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.User_Password2item, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Corporationitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.User_Nameitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.user_Branchitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.progress_Password_Stregnthitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XtraTabPage3item, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsAccountingitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsLogisticsitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsAudititem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsAdministatoritem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsApproveritem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsCollectionitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsCashieritem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsReceptionistitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsSparePartsitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsReportsitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsBackDateitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsNewAccountsitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsReleaseitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsBookkeeperitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsInventoryitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsSuperUseritem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsMaintenanceitem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents User_Password2 As DevExpress.XtraEditors.ButtonEdit
        Friend User_Name As DevExpress.XtraEditors.TextEdit
        Friend user_Position As DevExpress.XtraEditors.ComboBoxEdit
        Private user_Approver As DevExpress.XtraEditors.ComboBoxEdit
        Friend user_Branch As DevExpress.XtraEditors.LookUpEdit
        Private progress_Password_Stregnth As DevExpress.XtraEditors.ProgressBarControl
        Private User_Password As DevExpress.XtraEditors.TextEdit
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents XtraTabControl As DevExpress.XtraLayout.TabbedControlGroup
        Friend WithEvents XtraTabPage1item As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents IDitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents User_Passworditem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents User_Password2item As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Corporationitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents User_Nameitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents user_Branchitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents progress_Password_Stregnthitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents XtraTabPage2item As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents user_Approveritem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents user_Positionitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents XtraTabPage3item As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents IsSuperUseritem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsAdministatoritem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsReceptionistitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsMaintenanceitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsAudititem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsNewAccountsitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsBookkeeperitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsCashieritem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsApproveritem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsSparePartsitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsLogisticsitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsInventoryitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsAccountingitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsBackDateitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsCollectionitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsReportsitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsReleaseitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Employee_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents user_LName As DevExpress.XtraEditors.TextEdit
        Friend WithEvents user_MName As DevExpress.XtraEditors.TextEdit
        Friend WithEvents user_FName As DevExpress.XtraEditors.TextEdit
        Friend WithEvents user_Full_Name As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Corporation As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents User_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
        Friend WithEvents isSuperUser As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents isMaintenance As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents isLogistics As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents isAccounting As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents isAdministator As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents isApprover As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents isCollection As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents isCashier As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents isReceptionist As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents isBookkeeper As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents isSpareParts As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents isInventory As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents isNewAccounts As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents isRelease As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents IsReports As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents isBackDate As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents IsUpdate As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents IsBetaTester As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents isAudit As DevExpress.XtraEditors.ToggleSwitch
    End Class
End Namespace
