Namespace Forms.Logistics
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class wzFrm_Purchase_Order
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
            Me.WelcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
            Me.WizardPage_Profile = New DevExpress.XtraWizard.WizardPage()
            Me.Xuc_Purchase_Order = New SagaClassLibrary.Controls.Logistics.xuc_Purchase_Order()
            Me.CompletionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
            Me.WizardPage_Units = New DevExpress.XtraWizard.WizardPage()
            Me.xuc_Purchase_Order_Units = New SagaClassLibrary.Controls.Logistics.xuc_Purchase_Order_Units()
            Me.WizardPage_Brand = New DevExpress.XtraWizard.WizardPage()
            Me.Brand_Dealer = New DevExpress.XtraEditors.LookUpEdit()
            CType(Me.WizardControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.WizardControl.SuspendLayout()
            Me.WizardPage_Profile.SuspendLayout()
            Me.WizardPage_Units.SuspendLayout()
            Me.WizardPage_Brand.SuspendLayout()
            CType(Me.Brand_Dealer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'WizardControl
            '
            Me.WizardControl.Controls.Add(Me.WelcomeWizardPage1)
            Me.WizardControl.Controls.Add(Me.WizardPage_Profile)
            Me.WizardControl.Controls.Add(Me.CompletionWizardPage1)
            Me.WizardControl.Controls.Add(Me.WizardPage_Units)
            Me.WizardControl.Controls.Add(Me.WizardPage_Brand)
            Me.WizardControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.WizardControl.Name = "WizardControl"
            Me.WizardControl.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.WelcomeWizardPage1, Me.WizardPage_Brand, Me.WizardPage_Profile, Me.WizardPage_Units, Me.CompletionWizardPage1})
            Me.WizardControl.Size = New System.Drawing.Size(598, 518)
            Me.WizardControl.Text = "Purchase Order"
            Me.WizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero
            '
            'WelcomeWizardPage1
            '
            Me.WelcomeWizardPage1.Name = "WelcomeWizardPage1"
            Me.WelcomeWizardPage1.Size = New System.Drawing.Size(538, 351)
            Me.WelcomeWizardPage1.Text = "Welcome to the Purchase Order"
            '
            'WizardPage_Profile
            '
            Me.WizardPage_Profile.Controls.Add(Me.Xuc_Purchase_Order)
            Me.WizardPage_Profile.Name = "WizardPage_Profile"
            Me.WizardPage_Profile.Size = New System.Drawing.Size(538, 351)
            Me.WizardPage_Profile.Text = "Purchase Order Profile"
            '
            'Xuc_Purchase_Order
            '
            Me.Xuc_Purchase_Order.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Xuc_Purchase_Order.Location = New System.Drawing.Point(0, 0)
            Me.Xuc_Purchase_Order.Name = "Xuc_Purchase_Order"
            Me.Xuc_Purchase_Order.Size = New System.Drawing.Size(538, 351)
            Me.Xuc_Purchase_Order.TabIndex = 0
            '
            'CompletionWizardPage1
            '
            Me.CompletionWizardPage1.Name = "CompletionWizardPage1"
            Me.CompletionWizardPage1.Size = New System.Drawing.Size(538, 351)
            Me.CompletionWizardPage1.Text = "Completing the Purchase Order"
            '
            'WizardPage_Units
            '
            Me.WizardPage_Units.Controls.Add(Me.xuc_Purchase_Order_Units)
            Me.WizardPage_Units.Name = "WizardPage_Units"
            Me.WizardPage_Units.Size = New System.Drawing.Size(538, 351)
            Me.WizardPage_Units.Text = "Purchase Order Units"
            '
            'xuc_Purchase_Order_Units
            '
            Me.xuc_Purchase_Order_Units.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Purchase_Order_Units.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Purchase_Order_Units.Name = "xuc_Purchase_Order_Units"
            Me.xuc_Purchase_Order_Units.Size = New System.Drawing.Size(538, 351)
            Me.xuc_Purchase_Order_Units.TabIndex = 0
            '
            'WizardPage_Brand
            '
            Me.WizardPage_Brand.Controls.Add(Me.Brand_Dealer)
            Me.WizardPage_Brand.Name = "WizardPage_Brand"
            Me.WizardPage_Brand.Size = New System.Drawing.Size(538, 351)
            Me.WizardPage_Brand.Text = "Select Brand/Dealer"
            '
            'Brand_Dealer
            '
            Me.Brand_Dealer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Brand_Dealer.Location = New System.Drawing.Point(84, 74)
            Me.Brand_Dealer.Name = "Brand_Dealer"
            Me.Brand_Dealer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Brand_Dealer.Properties.Appearance.Options.UseFont = True
            Me.Brand_Dealer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Brand_Dealer.Size = New System.Drawing.Size(367, 26)
            Me.Brand_Dealer.TabIndex = 0
            '
            'wzFrm_Purchase_Order
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(598, 518)
            Me.Controls.Add(Me.WizardControl)
            Me.Name = "wzFrm_Purchase_Order"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "wzFrm_Purchase_Order"
            CType(Me.WizardControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.WizardControl.ResumeLayout(False)
            Me.WizardPage_Profile.ResumeLayout(False)
            Me.WizardPage_Units.ResumeLayout(False)
            Me.WizardPage_Brand.ResumeLayout(False)
            CType(Me.Brand_Dealer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents WizardControl As DevExpress.XtraWizard.WizardControl
        Friend WithEvents WelcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
        Friend WithEvents WizardPage_Profile As DevExpress.XtraWizard.WizardPage
        Friend WithEvents CompletionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
        Friend WithEvents xuc_Purchase_Order As Controls.Logistics.xuc_Purchase_Order
        Friend WithEvents WizardPage_Units As DevExpress.XtraWizard.WizardPage
        Friend WithEvents xuc_Purchase_Order_Units As Controls.Logistics.xuc_Purchase_Order_Units
        Friend WithEvents WizardPage_Brand As DevExpress.XtraWizard.WizardPage
        Friend WithEvents Brand_Dealer As DevExpress.XtraEditors.LookUpEdit
    End Class
End Namespace