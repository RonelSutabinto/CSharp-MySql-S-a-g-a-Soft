Namespace Controls.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Check
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
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.Check_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.PopupContainerControl = New DevExpress.XtraEditors.PopupContainerControl()
            Me.xuc_Account_Search = New SagaClassLibrary.Controls.Information.Account.xuc_Account_Search()
            Me.Checks = New DevExpress.XtraEditors.SpinEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.IsCancelled = New DevExpress.XtraEditors.ToggleSwitch()
            Me.Issued_Date = New DevExpress.XtraEditors.DateEdit()
            Me.Check_Amount_Words = New DevExpress.XtraEditors.MemoEdit()
            Me.Check_Number = New DevExpress.XtraEditors.TextEdit()
            Me.Check_Code = New DevExpress.XtraEditors.TextEdit()
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.Bank_Account = New DevExpress.XtraEditors.LookUpEdit()
            Me.Check_Amount = New DevExpress.XtraEditors.CalcEdit()
            Me.Reference = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Check_Payee = New DevExpress.XtraEditors.PopupContainerEdit()
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
            Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.Check_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PopupContainerControl.SuspendLayout()
            CType(Me.Checks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsCancelled.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Issued_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Issued_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Amount_Words.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Bank_Account.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Reference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Payee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.Check_Description)
            Me.layoutControl.Controls.Add(Me.PopupContainerControl)
            Me.layoutControl.Controls.Add(Me.Checks)
            Me.layoutControl.Controls.Add(Me.Notes)
            Me.layoutControl.Controls.Add(Me.IsCancelled)
            Me.layoutControl.Controls.Add(Me.Issued_Date)
            Me.layoutControl.Controls.Add(Me.Check_Amount_Words)
            Me.layoutControl.Controls.Add(Me.Check_Number)
            Me.layoutControl.Controls.Add(Me.Check_Code)
            Me.layoutControl.Controls.Add(Me.ID)
            Me.layoutControl.Controls.Add(Me.Bank_Account)
            Me.layoutControl.Controls.Add(Me.Check_Amount)
            Me.layoutControl.Controls.Add(Me.Reference)
            Me.layoutControl.Controls.Add(Me.Check_Payee)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(350, 400)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "LayoutControl1"
            '
            'Check_Description
            '
            Me.Check_Description.Location = New System.Drawing.Point(93, 252)
            Me.Check_Description.Name = "Check_Description"
            Me.Check_Description.Properties.ReadOnly = True
            Me.Check_Description.Size = New System.Drawing.Size(245, 46)
            Me.Check_Description.StyleController = Me.layoutControl
            Me.Check_Description.TabIndex = 11
            '
            'PopupContainerControl
            '
            Me.PopupContainerControl.Controls.Add(Me.xuc_Account_Search)
            Me.PopupContainerControl.Location = New System.Drawing.Point(132, 218)
            Me.PopupContainerControl.Name = "PopupContainerControl"
            Me.PopupContainerControl.Size = New System.Drawing.Size(183, 136)
            Me.PopupContainerControl.TabIndex = 13
            '
            'xuc_Account_Search
            '
            Me.xuc_Account_Search.AccountName = Nothing
            Me.xuc_Account_Search.Amount = New Decimal(New Integer() {0, 0, 0, 0})
            Me.xuc_Account_Search.Code = Nothing
            Me.xuc_Account_Search.Code2 = Nothing
            Me.xuc_Account_Search.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Account_Search.ID = 0
            Me.xuc_Account_Search.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Account_Search.Name = "xuc_Account_Search"
            Me.xuc_Account_Search.Others = Nothing
            Me.xuc_Account_Search.searchMode = SagaClassLibrary.Controls.Information.Account.xuc_Account_Search.Search_Mode.searchGlobal
            Me.xuc_Account_Search.Size = New System.Drawing.Size(183, 136)
            Me.xuc_Account_Search.TabIndex = 0
            Me.xuc_Account_Search.Type = Nothing
            '
            'Checks
            '
            Me.Checks.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.Checks.Location = New System.Drawing.Point(258, 36)
            Me.Checks.Name = "Checks"
            Me.Checks.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Checks.Size = New System.Drawing.Size(80, 20)
            Me.Checks.StyleController = Me.layoutControl
            Me.Checks.TabIndex = 3
            '
            'Notes
            '
            Me.Notes.Location = New System.Drawing.Point(93, 312)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(245, 76)
            Me.Notes.StyleController = Me.layoutControl
            Me.Notes.TabIndex = 12
            '
            'IsCancelled
            '
            Me.IsCancelled.Location = New System.Drawing.Point(93, 230)
            Me.IsCancelled.Name = "IsCancelled"
            Me.IsCancelled.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.IsCancelled.Properties.OffText = "Off"
            Me.IsCancelled.Properties.OnText = "On"
            Me.IsCancelled.Size = New System.Drawing.Size(245, 18)
            Me.IsCancelled.StyleController = Me.layoutControl
            Me.IsCancelled.TabIndex = 10
            '
            'Issued_Date
            '
            Me.Issued_Date.EditValue = Nothing
            Me.Issued_Date.Location = New System.Drawing.Point(93, 206)
            Me.Issued_Date.Name = "Issued_Date"
            Me.Issued_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Issued_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Issued_Date.Properties.ReadOnly = True
            Me.Issued_Date.Size = New System.Drawing.Size(245, 20)
            Me.Issued_Date.StyleController = Me.layoutControl
            Me.Issued_Date.TabIndex = 9
            '
            'Check_Amount_Words
            '
            Me.Check_Amount_Words.Enabled = False
            Me.Check_Amount_Words.Location = New System.Drawing.Point(93, 156)
            Me.Check_Amount_Words.Name = "Check_Amount_Words"
            Me.Check_Amount_Words.Properties.ReadOnly = True
            Me.Check_Amount_Words.Size = New System.Drawing.Size(245, 46)
            Me.Check_Amount_Words.StyleController = Me.layoutControl
            Me.Check_Amount_Words.TabIndex = 8
            '
            'Check_Number
            '
            Me.Check_Number.Location = New System.Drawing.Point(93, 36)
            Me.Check_Number.Name = "Check_Number"
            Me.Check_Number.Size = New System.Drawing.Size(80, 20)
            Me.Check_Number.StyleController = Me.layoutControl
            Me.Check_Number.TabIndex = 2
            '
            'Check_Code
            '
            Me.Check_Code.Enabled = False
            Me.Check_Code.Location = New System.Drawing.Point(258, 12)
            Me.Check_Code.Name = "Check_Code"
            Me.Check_Code.Size = New System.Drawing.Size(80, 20)
            Me.Check_Code.StyleController = Me.layoutControl
            Me.Check_Code.TabIndex = 1
            '
            'ID
            '
            Me.ID.Location = New System.Drawing.Point(93, 12)
            Me.ID.Name = "ID"
            Me.ID.Size = New System.Drawing.Size(80, 20)
            Me.ID.StyleController = Me.layoutControl
            Me.ID.TabIndex = 0
            '
            'Bank_Account
            '
            Me.Bank_Account.Location = New System.Drawing.Point(93, 60)
            Me.Bank_Account.Name = "Bank_Account"
            Me.Bank_Account.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Bank_Account.Properties.DataSource = GetType(SagaClassLibrary.acc_Banks)
            Me.Bank_Account.Properties.DisplayMember = "Bank_Name"
            Me.Bank_Account.Properties.NullText = ""
            Me.Bank_Account.Properties.ValueMember = "Bank_Code"
            Me.Bank_Account.Size = New System.Drawing.Size(245, 20)
            Me.Bank_Account.StyleController = Me.layoutControl
            Me.Bank_Account.TabIndex = 4
            '
            'Check_Amount
            '
            Me.Check_Amount.Location = New System.Drawing.Point(93, 132)
            Me.Check_Amount.Name = "Check_Amount"
            Me.Check_Amount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Check_Amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.Check_Amount.Properties.ReadOnly = True
            Me.Check_Amount.Size = New System.Drawing.Size(245, 20)
            Me.Check_Amount.StyleController = Me.layoutControl
            Me.Check_Amount.TabIndex = 7
            '
            'Reference
            '
            Me.Reference.Location = New System.Drawing.Point(93, 84)
            Me.Reference.Name = "Reference"
            Me.Reference.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Reference.Properties.Items.AddRange(New Object() {"CANCELLED"})
            Me.Reference.Size = New System.Drawing.Size(245, 20)
            Me.Reference.StyleController = Me.layoutControl
            Me.Reference.TabIndex = 5
            '
            'Check_Payee
            '
            Me.Check_Payee.Location = New System.Drawing.Point(93, 108)
            Me.Check_Payee.Name = "Check_Payee"
            Me.Check_Payee.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Check_Payee.Properties.PopupControl = Me.PopupContainerControl
            Me.Check_Payee.Size = New System.Drawing.Size(245, 20)
            Me.Check_Payee.StyleController = Me.layoutControl
            Me.Check_Payee.TabIndex = 6
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.SplitterItem1, Me.LayoutControlItem13, Me.LayoutControlItem2})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(350, 400)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.ID
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(165, 24)
            Me.LayoutControlItem1.Text = "ID"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Check_Code
            Me.LayoutControlItem2.CustomizationFormText = "Check Code"
            Me.LayoutControlItem2.Location = New System.Drawing.Point(165, 0)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(165, 24)
            Me.LayoutControlItem2.Text = "Check Code"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Check_Number
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(165, 24)
            Me.LayoutControlItem3.Text = "Check Number"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Bank_Account
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(330, 24)
            Me.LayoutControlItem4.Text = "Bank Account"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Reference
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(330, 24)
            Me.LayoutControlItem5.Text = "Reference"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.Check_Payee
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(330, 24)
            Me.LayoutControlItem6.Text = "Payee Name"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.Check_Amount
            Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 120)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(330, 24)
            Me.LayoutControlItem7.Text = "Amount"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.Check_Amount_Words
            Me.LayoutControlItem8.CustomizationFormText = "Amount Text"
            Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 144)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(330, 50)
            Me.LayoutControlItem8.Text = "Amount Text"
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem9
            '
            Me.LayoutControlItem9.Control = Me.Issued_Date
            Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 194)
            Me.LayoutControlItem9.Name = "LayoutControlItem9"
            Me.LayoutControlItem9.Size = New System.Drawing.Size(330, 24)
            Me.LayoutControlItem9.Text = "Date of Issue"
            Me.LayoutControlItem9.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem10
            '
            Me.LayoutControlItem10.Control = Me.IsCancelled
            Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 218)
            Me.LayoutControlItem10.Name = "LayoutControlItem10"
            Me.LayoutControlItem10.Size = New System.Drawing.Size(330, 22)
            Me.LayoutControlItem10.Text = "Cancelled"
            Me.LayoutControlItem10.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem11
            '
            Me.LayoutControlItem11.Control = Me.Check_Description
            Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 240)
            Me.LayoutControlItem11.Name = "LayoutControlItem11"
            Me.LayoutControlItem11.Size = New System.Drawing.Size(330, 50)
            Me.LayoutControlItem11.Text = "Description"
            Me.LayoutControlItem11.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem12
            '
            Me.LayoutControlItem12.Control = Me.Notes
            Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 300)
            Me.LayoutControlItem12.Name = "LayoutControlItem12"
            Me.LayoutControlItem12.Size = New System.Drawing.Size(330, 80)
            Me.LayoutControlItem12.Text = "Notes"
            Me.LayoutControlItem12.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem13
            '
            Me.LayoutControlItem13.Control = Me.Checks
            Me.LayoutControlItem13.Location = New System.Drawing.Point(165, 24)
            Me.LayoutControlItem13.Name = "LayoutControlItem13"
            Me.LayoutControlItem13.Size = New System.Drawing.Size(165, 24)
            Me.LayoutControlItem13.Text = "Check Pages"
            Me.LayoutControlItem13.TextSize = New System.Drawing.Size(69, 13)
            '
            'SplitterItem1
            '
            Me.SplitterItem1.AllowHotTrack = True
            Me.SplitterItem1.Location = New System.Drawing.Point(0, 290)
            Me.SplitterItem1.Name = "SplitterItem1"
            Me.SplitterItem1.Size = New System.Drawing.Size(330, 10)
            '
            'xuc_Check
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "xuc_Check"
            Me.Size = New System.Drawing.Size(350, 400)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.Check_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PopupContainerControl.ResumeLayout(False)
            CType(Me.Checks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsCancelled.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Issued_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Issued_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Amount_Words.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Bank_Account.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Reference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Payee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents IsCancelled As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents Issued_Date As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Check_Amount_Words As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Check_Number As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Check_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Bank_Account As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Check_Amount As DevExpress.XtraEditors.CalcEdit
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
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Check_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Checks As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Reference As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents Check_Payee As DevExpress.XtraEditors.PopupContainerEdit
        Friend WithEvents PopupContainerControl As DevExpress.XtraEditors.PopupContainerControl
        Friend WithEvents xuc_Account_Search As Controls.Information.Account.xuc_Account_Search
        Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    End Class
End Namespace