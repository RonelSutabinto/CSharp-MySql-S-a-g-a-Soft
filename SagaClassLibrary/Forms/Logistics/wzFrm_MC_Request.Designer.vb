Namespace Forms.Logistics
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class wzFrm_MC_Request
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
            Me.WizardPage_Profile = New DevExpress.XtraWizard.WizardPage()
            Me.xuc_MC_Request = New SagaClassLibrary.Controls.Logistics.xuc_MC_Request()
            Me.CompletionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
            Me.WizardPage_MC_Units = New DevExpress.XtraWizard.WizardPage()
            Me.xuc_Purchase_Order_Units = New SagaClassLibrary.Controls.Logistics.xuc_Purchase_Order_Units()
            Me.WizardPage_Supplier = New DevExpress.XtraWizard.WizardPage()
            Me.Supplier_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.WizardPage_Reason = New DevExpress.XtraWizard.WizardPage()
            Me.Request_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.WizardPage_WHCode = New DevExpress.XtraWizard.WizardPage()
            Me.WHCode = New DevExpress.XtraEditors.LookUpEdit()
            CType(Me.WizardControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardControl.SuspendLayout()
            Me.WizardPage_Profile.SuspendLayout()
            Me.WizardPage_MC_Units.SuspendLayout()
            Me.WizardPage_Supplier.SuspendLayout()
            CType(Me.Supplier_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_Reason.SuspendLayout()
            CType(Me.Request_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardPage_WHCode.SuspendLayout()
            CType(Me.WHCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'WizardControl
            '
            Me.WizardControl.Controls.Add(Me.WelcomeWizardPage)
            Me.WizardControl.Controls.Add(Me.WizardPage_Profile)
            Me.WizardControl.Controls.Add(Me.CompletionWizardPage1)
            Me.WizardControl.Controls.Add(Me.WizardPage_MC_Units)
            Me.WizardControl.Controls.Add(Me.WizardPage_Supplier)
            Me.WizardControl.Controls.Add(Me.WizardPage_Reason)
            Me.WizardControl.Controls.Add(Me.WizardPage_WHCode)
            Me.WizardControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.WizardControl.Name = "WizardControl"
            Me.WizardControl.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.WelcomeWizardPage, Me.WizardPage_Supplier, Me.WizardPage_WHCode, Me.WizardPage_Reason, Me.WizardPage_Profile, Me.WizardPage_MC_Units, Me.CompletionWizardPage1})
            Me.WizardControl.Size = New System.Drawing.Size(598, 518)
            Me.WizardControl.Text = "MC Request/Order"
            Me.WizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero
            '
            'WelcomeWizardPage
            '
            Me.WelcomeWizardPage.Name = "WelcomeWizardPage"
            Me.WelcomeWizardPage.Size = New System.Drawing.Size(538, 351)
            Me.WelcomeWizardPage.Text = "Welcome to the MC Request"
            '
            'WizardPage_Profile
            '
            Me.WizardPage_Profile.Controls.Add(Me.xuc_MC_Request)
            Me.WizardPage_Profile.Name = "WizardPage_Profile"
            Me.WizardPage_Profile.Size = New System.Drawing.Size(538, 351)
            Me.WizardPage_Profile.Text = "Purchase Order Profile"
            '
            'xuc_MC_Request
            '
            Me.xuc_MC_Request.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_MC_Request.Location = New System.Drawing.Point(0, 0)
            Me.xuc_MC_Request.Name = "xuc_MC_Request"
            Me.xuc_MC_Request.Size = New System.Drawing.Size(538, 351)
            Me.xuc_MC_Request.TabIndex = 0
            '
            'CompletionWizardPage1
            '
            Me.CompletionWizardPage1.Name = "CompletionWizardPage1"
            Me.CompletionWizardPage1.Size = New System.Drawing.Size(538, 351)
            Me.CompletionWizardPage1.Text = "Completing the MC Request"
            '
            'WizardPage_MC_Units
            '
            Me.WizardPage_MC_Units.Controls.Add(Me.xuc_Purchase_Order_Units)
            Me.WizardPage_MC_Units.Name = "WizardPage_MC_Units"
            Me.WizardPage_MC_Units.Size = New System.Drawing.Size(538, 351)
            Me.WizardPage_MC_Units.Text = "Request MC Units"
            '
            'xuc_Purchase_Order_Units
            '
            Me.xuc_Purchase_Order_Units.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Purchase_Order_Units.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Purchase_Order_Units.Name = "xuc_Purchase_Order_Units"
            Me.xuc_Purchase_Order_Units.Size = New System.Drawing.Size(538, 351)
            Me.xuc_Purchase_Order_Units.TabIndex = 0
            '
            'WizardPage_Supplier
            '
            Me.WizardPage_Supplier.Controls.Add(Me.Supplier_Code)
            Me.WizardPage_Supplier.Name = "WizardPage_Supplier"
            Me.WizardPage_Supplier.Size = New System.Drawing.Size(538, 351)
            Me.WizardPage_Supplier.Text = "Select Branch/Supplier"
            '
            'Supplier_Code
            '
            Me.Supplier_Code.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Supplier_Code.Location = New System.Drawing.Point(100, 100)
            Me.Supplier_Code.Name = "Supplier_Code"
            Me.Supplier_Code.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Supplier_Code.Properties.Appearance.Options.UseFont = True
            Me.Supplier_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Supplier_Code.Size = New System.Drawing.Size(350, 26)
            Me.Supplier_Code.TabIndex = 0
            '
            'WizardPage_Reason
            '
            Me.WizardPage_Reason.Controls.Add(Me.Request_Description)
            Me.WizardPage_Reason.Name = "WizardPage_Reason"
            Me.WizardPage_Reason.Size = New System.Drawing.Size(538, 351)
            Me.WizardPage_Reason.Text = "Reason for Request"
            '
            'Request_Description
            '
            Me.Request_Description.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Request_Description.EditValue = ""
            Me.Request_Description.Location = New System.Drawing.Point(0, 0)
            Me.Request_Description.Name = "Request_Description"
            Me.Request_Description.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Request_Description.Properties.Appearance.Options.UseFont = True
            Me.Request_Description.Size = New System.Drawing.Size(538, 351)
            Me.Request_Description.TabIndex = 0
            '
            'WizardPage_WHCode
            '
            Me.WizardPage_WHCode.Controls.Add(Me.WHCode)
            Me.WizardPage_WHCode.Name = "WizardPage_WHCode"
            Me.WizardPage_WHCode.Size = New System.Drawing.Size(538, 351)
            Me.WizardPage_WHCode.Text = "Select Inventory Category"
            '
            'WHCode
            '
            Me.WHCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.WHCode.Location = New System.Drawing.Point(100, 100)
            Me.WHCode.Name = "WHCode"
            Me.WHCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.WHCode.Properties.Appearance.Options.UseFont = True
            Me.WHCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.WHCode.Size = New System.Drawing.Size(350, 26)
            Me.WHCode.TabIndex = 1
            '
            'wzFrm_MC_Request
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(598, 518)
            Me.Controls.Add(Me.WizardControl)
            Me.Name = "wzFrm_MC_Request"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MC Request/Order Wizard Form"
            CType(Me.WizardControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardControl.ResumeLayout(False)
            Me.WizardPage_Profile.ResumeLayout(False)
            Me.WizardPage_MC_Units.ResumeLayout(False)
            Me.WizardPage_Supplier.ResumeLayout(False)
            CType(Me.Supplier_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_Reason.ResumeLayout(False)
            CType(Me.Request_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardPage_WHCode.ResumeLayout(False)
            CType(Me.WHCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents WizardControl As DevExpress.XtraWizard.WizardControl
        Friend WithEvents WelcomeWizardPage As DevExpress.XtraWizard.WelcomeWizardPage
        Friend WithEvents WizardPage_Profile As DevExpress.XtraWizard.WizardPage
        Friend WithEvents CompletionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
        Friend WithEvents WizardPage_MC_Units As DevExpress.XtraWizard.WizardPage
        Friend WithEvents xuc_Purchase_Order_Units As Controls.Logistics.xuc_Purchase_Order_Units
        Friend WithEvents WizardPage_Supplier As DevExpress.XtraWizard.WizardPage
        Friend WithEvents Supplier_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents xuc_MC_Request As Controls.Logistics.xuc_MC_Request
        Friend WithEvents WizardPage_Reason As DevExpress.XtraWizard.WizardPage
        Friend WithEvents Request_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents WizardPage_WHCode As DevExpress.XtraWizard.WizardPage
        Friend WithEvents WHCode As DevExpress.XtraEditors.LookUpEdit
    End Class
End Namespace