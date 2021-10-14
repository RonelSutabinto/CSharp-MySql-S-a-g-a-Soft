<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wzf_Voucher
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Me.WizardPage1 = New DevExpress.XtraWizard.WizardPage()
        Me.CompletionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
        Me.WizardPage2 = New DevExpress.XtraWizard.WizardPage()
        Me.xuc_Voucher = New Controls.Accounting.xuc_Voucher()
        Me.xuc_Journal_Entries = New Controls.Accounting.xuc_Journal_Entries()
        CType(Me.WizardControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WizardControl.SuspendLayout()
        Me.WizardPage1.SuspendLayout()
        Me.WizardPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'WizardControl
        '
        Me.WizardControl.Controls.Add(Me.WelcomeWizardPage1)
        Me.WizardControl.Controls.Add(Me.WizardPage1)
        Me.WizardControl.Controls.Add(Me.CompletionWizardPage1)
        Me.WizardControl.Controls.Add(Me.WizardPage2)
        Me.WizardControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WizardControl.Name = "WizardControl"
        Me.WizardControl.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.WelcomeWizardPage1, Me.WizardPage1, Me.WizardPage2, Me.CompletionWizardPage1})
        Me.WizardControl.Size = New System.Drawing.Size(622, 571)
        Me.WizardControl.Text = "Voucher Profile"
        Me.WizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero
        '
        'WelcomeWizardPage1
        '
        Me.WelcomeWizardPage1.Name = "WelcomeWizardPage1"
        Me.WelcomeWizardPage1.Size = New System.Drawing.Size(562, 404)
        Me.WelcomeWizardPage1.Text = "Welcome to the New Cash/Check Voucher wizard"
        '
        'WizardPage1
        '
        Me.WizardPage1.Controls.Add(Me.xuc_Voucher)
        Me.WizardPage1.Name = "WizardPage1"
        Me.WizardPage1.Size = New System.Drawing.Size(562, 404)
        Me.WizardPage1.Text = "Cash/Check Voucher setup"
        '
        'CompletionWizardPage1
        '
        Me.CompletionWizardPage1.Name = "CompletionWizardPage1"
        Me.CompletionWizardPage1.Size = New System.Drawing.Size(562, 404)
        '
        'WizardPage2
        '
        Me.WizardPage2.Controls.Add(Me.xuc_Journal_Entries)
        Me.WizardPage2.Name = "WizardPage2"
        Me.WizardPage2.Size = New System.Drawing.Size(562, 404)
        Me.WizardPage2.Text = "Journal Entries"
        '
        'xuc_Voucher
        '
        Me.xuc_Voucher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xuc_Voucher.Location = New System.Drawing.Point(0, 0)
        Me.xuc_Voucher.Name = "xuc_Voucher"
        Me.xuc_Voucher.Size = New System.Drawing.Size(562, 404)
        Me.xuc_Voucher.TabIndex = 0
        '
        'xuc_Journal_Entries
        '
        Me.xuc_Journal_Entries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xuc_Journal_Entries.Location = New System.Drawing.Point(0, 0)
        Me.xuc_Journal_Entries.Name = "xuc_Journal_Entries"
        Me.xuc_Journal_Entries.Size = New System.Drawing.Size(562, 404)
        Me.xuc_Journal_Entries.TabIndex = 0
        '
        'wzf_Voucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 571)
        Me.Controls.Add(Me.WizardControl)
        Me.Name = "wzf_Voucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Voucher"
        CType(Me.WizardControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WizardControl.ResumeLayout(False)
        Me.WizardPage1.ResumeLayout(False)
        Me.WizardPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WizardControl As DevExpress.XtraWizard.WizardControl
    Friend WithEvents WelcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
    Friend WithEvents WizardPage1 As DevExpress.XtraWizard.WizardPage
    Friend WithEvents CompletionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
    Friend WithEvents xuc_Voucher As Controls.Accounting.xuc_Voucher
    Friend WithEvents WizardPage2 As DevExpress.XtraWizard.WizardPage
    Friend WithEvents xuc_Journal_Entries As Controls.Accounting.xuc_Journal_Entries
End Class
