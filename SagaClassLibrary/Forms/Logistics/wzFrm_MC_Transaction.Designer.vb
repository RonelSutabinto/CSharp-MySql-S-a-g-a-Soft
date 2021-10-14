Namespace Forms.Logistics
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class wzFrm_MC_Transaction
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wzFrm_MC_Transaction))
            Me.WizardControl = New DevExpress.XtraWizard.WizardControl()
            Me.WelcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
            Me.WizardPage_Profile = New DevExpress.XtraWizard.WizardPage()
            Me.xuc_MC_Transaction = New SagaClassLibrary.Controls.Logistics.xuc_MC_Transaction()
            Me.CompletionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
            Me.WizardPage_Units = New DevExpress.XtraWizard.WizardPage()
            Me.xuc_MC_Transaction_Units = New SagaClassLibrary.Controls.Logistics.xuc_MC_Transaction_Units()
            Me.WizardPage_Branch_To = New DevExpress.XtraWizard.WizardPage()
            Me.Branch_To = New DevExpress.XtraEditors.LookUpEdit()
            Me.WizardPage_Transaction = New DevExpress.XtraWizard.WizardPage()
            Me.Transaction_Type = New DevExpress.XtraEditors.LookUpEdit()
            Me.WizardPage_Branch_From = New DevExpress.XtraWizard.WizardPage()
            Me.Branch_From = New DevExpress.XtraEditors.LookUpEdit()
            Me.WizardPage_Reference = New DevExpress.XtraWizard.WizardPage()
            Me.Reference = New DevExpress.XtraEditors.TextEdit()
            Me.WizardPage_Purchase_Order = New DevExpress.XtraWizard.WizardPage()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.xuc_Purchase_Order_Units = New SagaClassLibrary.Controls.Logistics.xuc_Purchase_Order_Units()
            Me.Order_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.WizardPage_PO_Generate = New DevExpress.XtraWizard.WizardPage()
            Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.xuc_Purchase_Order_Units_Generate = New SagaClassLibrary.Controls.Logistics.xuc_Purchase_Order_Units()
            Me.btn_Generate = New DevExpress.XtraEditors.SimpleButton()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.WizardPage_WHCode = New DevExpress.XtraWizard.WizardPage()
            Me.WHCode = New DevExpress.XtraEditors.LookUpEdit()
            CType(Me.WizardControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardControl.SuspendLayout()
            Me.WizardPage_Profile.SuspendLayout()
            Me.WizardPage_Units.SuspendLayout()
            Me.WizardPage_Branch_To.SuspendLayout()
            CType(Me.Branch_To.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_Transaction.SuspendLayout()
            CType(Me.Transaction_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_Branch_From.SuspendLayout()
            CType(Me.Branch_From.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_Reference.SuspendLayout()
            CType(Me.Reference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_Purchase_Order.SuspendLayout()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl.SuspendLayout()
            CType(Me.Order_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_PO_Generate.SuspendLayout()
            CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl2.SuspendLayout()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_WHCode.SuspendLayout()
            CType(Me.WHCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'WizardControl
            '
            Me.WizardControl.Controls.Add(Me.WelcomeWizardPage1)
            Me.WizardControl.Controls.Add(Me.WizardPage_Profile)
            Me.WizardControl.Controls.Add(Me.CompletionWizardPage1)
            Me.WizardControl.Controls.Add(Me.WizardPage_Units)
            Me.WizardControl.Controls.Add(Me.WizardPage_Branch_To)
            Me.WizardControl.Controls.Add(Me.WizardPage_Transaction)
            Me.WizardControl.Controls.Add(Me.WizardPage_Branch_From)
            Me.WizardControl.Controls.Add(Me.WizardPage_Reference)
            Me.WizardControl.Controls.Add(Me.WizardPage_Purchase_Order)
            Me.WizardControl.Controls.Add(Me.WizardPage_PO_Generate)
            Me.WizardControl.Controls.Add(Me.WizardPage_WHCode)
            Me.WizardControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.WizardControl.Name = "WizardControl"
            Me.WizardControl.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.WelcomeWizardPage1, Me.WizardPage_Transaction, Me.WizardPage_Branch_From, Me.WizardPage_Branch_To, Me.WizardPage_Purchase_Order, Me.WizardPage_Reference, Me.WizardPage_WHCode, Me.WizardPage_Profile, Me.WizardPage_PO_Generate, Me.WizardPage_Units, Me.CompletionWizardPage1})
            Me.WizardControl.Size = New System.Drawing.Size(598, 468)
            Me.WizardControl.Text = "Receive/Transfer/Deposit MC Units"
            Me.WizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero
            '
            'WelcomeWizardPage1
            '
            Me.WelcomeWizardPage1.Name = "WelcomeWizardPage1"
            Me.WelcomeWizardPage1.Size = New System.Drawing.Size(538, 301)
            Me.WelcomeWizardPage1.Text = "Welcome to the Receiving/Transfering MC Units"
            '
            'WizardPage_Profile
            '
            Me.WizardPage_Profile.Controls.Add(Me.xuc_MC_Transaction)
            Me.WizardPage_Profile.Name = "WizardPage_Profile"
            Me.WizardPage_Profile.Size = New System.Drawing.Size(538, 301)
            Me.WizardPage_Profile.Text = "Receive/Transfer/Deposit Profile"
            '
            'xuc_MC_Transaction
            '
            Me.xuc_MC_Transaction.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_MC_Transaction.Location = New System.Drawing.Point(0, 0)
            Me.xuc_MC_Transaction.Name = "xuc_MC_Transaction"
            Me.xuc_MC_Transaction.Size = New System.Drawing.Size(538, 301)
            Me.xuc_MC_Transaction.TabIndex = 0
            '
            'CompletionWizardPage1
            '
            Me.CompletionWizardPage1.Name = "CompletionWizardPage1"
            Me.CompletionWizardPage1.Size = New System.Drawing.Size(538, 301)
            Me.CompletionWizardPage1.Text = "Completing the Receive/Transfer"
            '
            'WizardPage_Units
            '
            Me.WizardPage_Units.Controls.Add(Me.xuc_MC_Transaction_Units)
            Me.WizardPage_Units.Name = "WizardPage_Units"
            Me.WizardPage_Units.Size = New System.Drawing.Size(538, 301)
            Me.WizardPage_Units.Text = "Receive/Transfer/Deposit Units"
            '
            'xuc_MC_Transaction_Units
            '
            Me.xuc_MC_Transaction_Units.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_MC_Transaction_Units.Location = New System.Drawing.Point(0, 0)
            Me.xuc_MC_Transaction_Units.Name = "xuc_MC_Transaction_Units"
            Me.xuc_MC_Transaction_Units.Size = New System.Drawing.Size(538, 301)
            Me.xuc_MC_Transaction_Units.TabIndex = 0
            '
            'WizardPage_Branch_To
            '
            Me.WizardPage_Branch_To.Controls.Add(Me.Branch_To)
            Me.WizardPage_Branch_To.Name = "WizardPage_Branch_To"
            Me.WizardPage_Branch_To.Size = New System.Drawing.Size(538, 301)
            Me.WizardPage_Branch_To.Text = "Select Receiving Branch (for Transfer only)"
            '
            'Branch_To
            '
            Me.Branch_To.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Branch_To.Location = New System.Drawing.Point(100, 100)
            Me.Branch_To.Name = "Branch_To"
            Me.Branch_To.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Branch_To.Properties.Appearance.Options.UseFont = True
            Me.Branch_To.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Branch_To.Properties.NullText = ""
            Me.Branch_To.Size = New System.Drawing.Size(350, 26)
            Me.Branch_To.TabIndex = 0
            '
            'WizardPage_Transaction
            '
            Me.WizardPage_Transaction.Controls.Add(Me.Transaction_Type)
            Me.WizardPage_Transaction.Name = "WizardPage_Transaction"
            Me.WizardPage_Transaction.Size = New System.Drawing.Size(538, 301)
            Me.WizardPage_Transaction.Text = "Select Transaction"
            '
            'Transaction_Type
            '
            Me.Transaction_Type.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Transaction_Type.Location = New System.Drawing.Point(100, 100)
            Me.Transaction_Type.Name = "Transaction_Type"
            Me.Transaction_Type.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Transaction_Type.Properties.Appearance.Options.UseFont = True
            Me.Transaction_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Transaction_Type.Properties.NullText = ""
            Me.Transaction_Type.Properties.PopupSizeable = False
            Me.Transaction_Type.Size = New System.Drawing.Size(350, 26)
            Me.Transaction_Type.TabIndex = 0
            '
            'WizardPage_Branch_From
            '
            Me.WizardPage_Branch_From.Controls.Add(Me.Branch_From)
            Me.WizardPage_Branch_From.Name = "WizardPage_Branch_From"
            Me.WizardPage_Branch_From.Size = New System.Drawing.Size(538, 301)
            Me.WizardPage_Branch_From.Text = "Select Branch/Dealer"
            '
            'Branch_From
            '
            Me.Branch_From.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Branch_From.Location = New System.Drawing.Point(100, 100)
            Me.Branch_From.Name = "Branch_From"
            Me.Branch_From.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Branch_From.Properties.Appearance.Options.UseFont = True
            Me.Branch_From.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Branch_From.Properties.NullText = ""
            Me.Branch_From.Properties.PopupSizeable = False
            Me.Branch_From.Size = New System.Drawing.Size(350, 26)
            Me.Branch_From.TabIndex = 1
            '
            'WizardPage_Reference
            '
            Me.WizardPage_Reference.Controls.Add(Me.Reference)
            Me.WizardPage_Reference.Name = "WizardPage_Reference"
            Me.WizardPage_Reference.Size = New System.Drawing.Size(538, 301)
            Me.WizardPage_Reference.Text = "Set Reference (Delivery Receipt for Receiving)"
            '
            'Reference
            '
            Me.Reference.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Reference.EditValue = ""
            Me.Reference.Location = New System.Drawing.Point(100, 100)
            Me.Reference.Name = "Reference"
            Me.Reference.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Reference.Properties.Appearance.Options.UseFont = True
            Me.Reference.Properties.NullText = "[EditValue is null]"
            Me.Reference.Size = New System.Drawing.Size(350, 26)
            Me.Reference.TabIndex = 1
            '
            'WizardPage_Purchase_Order
            '
            Me.WizardPage_Purchase_Order.Controls.Add(Me.layoutControl)
            Me.WizardPage_Purchase_Order.Name = "WizardPage_Purchase_Order"
            Me.WizardPage_Purchase_Order.Size = New System.Drawing.Size(538, 301)
            Me.WizardPage_Purchase_Order.Text = "Purchase Orders (for Receiving only)"
            '
            'LayoutControl1
            '
            Me.LayoutControl.Controls.Add(Me.xuc_Purchase_Order_Units)
            Me.LayoutControl.Controls.Add(Me.Order_Code)
            Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl.Name = "LayoutControl1"
            Me.LayoutControl.Root = Me.Root
            Me.LayoutControl.Size = New System.Drawing.Size(538, 301)
            Me.LayoutControl.TabIndex = 0
            Me.LayoutControl.Text = "LayoutControl1"
            '
            'xuc_Purchase_Order_Units
            '
            Me.xuc_Purchase_Order_Units.Location = New System.Drawing.Point(12, 36)
            Me.xuc_Purchase_Order_Units.Name = "xuc_Purchase_Order_Units"
            Me.xuc_Purchase_Order_Units.Size = New System.Drawing.Size(514, 253)
            Me.xuc_Purchase_Order_Units.TabIndex = 5
            '
            'Order_Code
            '
            Me.Order_Code.Location = New System.Drawing.Point(167, 12)
            Me.Order_Code.Name = "Order_Code"
            Me.Order_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Order_Code.Properties.NullText = ""
            Me.Order_Code.Properties.PopupSizeable = False
            Me.Order_Code.Size = New System.Drawing.Size(359, 20)
            Me.Order_Code.StyleController = Me.layoutControl
            Me.Order_Code.TabIndex = 4
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(538, 301)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.Order_Code
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(518, 24)
            Me.LayoutControlItem1.Text = "Purchase Order / MC Request"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(143, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.xuc_Purchase_Order_Units
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(518, 257)
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem2.TextVisible = False
            '
            'WizardPage_PO_Generate
            '
            Me.WizardPage_PO_Generate.Controls.Add(Me.LayoutControl2)
            Me.WizardPage_PO_Generate.Name = "WizardPage_PO_Generate"
            Me.WizardPage_PO_Generate.Size = New System.Drawing.Size(538, 301)
            Me.WizardPage_PO_Generate.Text = "Generate Purchase Orders (for Receiving only)"
            '
            'LayoutControl2
            '
            Me.LayoutControl2.Controls.Add(Me.xuc_Purchase_Order_Units_Generate)
            Me.LayoutControl2.Controls.Add(Me.btn_Generate)
            Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl2.Name = "LayoutControl2"
            Me.LayoutControl2.Root = Me.LayoutControlGroup1
            Me.LayoutControl2.Size = New System.Drawing.Size(538, 301)
            Me.LayoutControl2.TabIndex = 1
            Me.LayoutControl2.Text = "LayoutControl2"
            '
            'xuc_Purchase_Order_Units_Generate
            '
            Me.xuc_Purchase_Order_Units_Generate.Location = New System.Drawing.Point(12, 12)
            Me.xuc_Purchase_Order_Units_Generate.Name = "xuc_Purchase_Order_Units_Generate"
            Me.xuc_Purchase_Order_Units_Generate.Size = New System.Drawing.Size(514, 251)
            Me.xuc_Purchase_Order_Units_Generate.TabIndex = 0
            '
            'btn_Generate
            '
            Me.btn_Generate.ImageOptions.Image = CType(resources.GetObject("btn_Generate.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Generate.Location = New System.Drawing.Point(448, 267)
            Me.btn_Generate.Name = "btn_Generate"
            Me.btn_Generate.Size = New System.Drawing.Size(78, 22)
            Me.btn_Generate.StyleController = Me.LayoutControl2
            Me.btn_Generate.TabIndex = 4
            Me.btn_Generate.Text = "Generate"
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1})
            Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(538, 301)
            Me.LayoutControlGroup1.TextVisible = False
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.xuc_Purchase_Order_Units_Generate
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(518, 255)
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem3.TextVisible = False
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.btn_Generate
            Me.LayoutControlItem4.Location = New System.Drawing.Point(436, 255)
            Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(82, 26)
            Me.LayoutControlItem4.MinSize = New System.Drawing.Size(82, 26)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(82, 26)
            Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem4.TextVisible = False
            '
            'EmptySpaceItem1
            '
            Me.EmptySpaceItem1.AllowHotTrack = False
            Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 255)
            Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
            Me.EmptySpaceItem1.Size = New System.Drawing.Size(436, 26)
            Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'WizardPage_WHCode
            '
            Me.WizardPage_WHCode.Controls.Add(Me.WHCode)
            Me.WizardPage_WHCode.Name = "WizardPage_WHCode"
            Me.WizardPage_WHCode.Size = New System.Drawing.Size(538, 301)
            Me.WizardPage_WHCode.Text = "Select MC Unit Warehouse Inventory Status"
            '
            'WHCode
            '
            Me.WHCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.WHCode.EditValue = ""
            Me.WHCode.Location = New System.Drawing.Point(100, 100)
            Me.WHCode.Name = "WHCode"
            Me.WHCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.WHCode.Properties.Appearance.Options.UseFont = True
            Me.WHCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.WHCode.Size = New System.Drawing.Size(350, 26)
            Me.WHCode.TabIndex = 2
            '
            'wzFrm_MC_Transaction
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(598, 468)
            Me.Controls.Add(Me.WizardControl)
            Me.Name = "wzFrm_MC_Transaction"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "wzFrm_MC_Transaction"
            CType(Me.WizardControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardControl.ResumeLayout(False)
            Me.WizardPage_Profile.ResumeLayout(False)
            Me.WizardPage_Units.ResumeLayout(False)
            Me.WizardPage_Branch_To.ResumeLayout(False)
            CType(Me.Branch_To.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_Transaction.ResumeLayout(False)
            CType(Me.Transaction_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_Branch_From.ResumeLayout(False)
            CType(Me.Branch_From.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_Reference.ResumeLayout(False)
            CType(Me.Reference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_Purchase_Order.ResumeLayout(False)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType(Me.Order_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_PO_Generate.ResumeLayout(False)
            CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl2.ResumeLayout(False)
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_WHCode.ResumeLayout(False)
            CType(Me.WHCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents WizardControl As DevExpress.XtraWizard.WizardControl
        Friend WithEvents WelcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
        Friend WithEvents WizardPage_Profile As DevExpress.XtraWizard.WizardPage
        Friend WithEvents CompletionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
        Friend WithEvents WizardPage_Units As DevExpress.XtraWizard.WizardPage
        Friend WithEvents WizardPage_Branch_To As DevExpress.XtraWizard.WizardPage
        Friend WithEvents Branch_To As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents xuc_MC_Transaction As Controls.Logistics.xuc_MC_Transaction
        Friend WithEvents WizardPage_Transaction As DevExpress.XtraWizard.WizardPage
        Friend WithEvents WizardPage_Branch_From As DevExpress.XtraWizard.WizardPage
        Friend WithEvents WizardPage_Reference As DevExpress.XtraWizard.WizardPage
        Friend WithEvents Reference As DevExpress.XtraEditors.TextEdit
        Friend WithEvents xuc_MC_Transaction_Units As Controls.Logistics.xuc_MC_Transaction_Units
        Friend WithEvents Branch_From As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents WizardPage_Purchase_Order As DevExpress.XtraWizard.WizardPage
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Order_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents xuc_Purchase_Order_Units As Controls.Logistics.xuc_Purchase_Order_Units
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents WizardPage_PO_Generate As DevExpress.XtraWizard.WizardPage
        Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents xuc_Purchase_Order_Units_Generate As Controls.Logistics.xuc_Purchase_Order_Units
        Friend WithEvents btn_Generate As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents WizardPage_WHCode As DevExpress.XtraWizard.WizardPage
        Friend WithEvents WHCode As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Transaction_Type As DevExpress.XtraEditors.LookUpEdit
    End Class
End Namespace