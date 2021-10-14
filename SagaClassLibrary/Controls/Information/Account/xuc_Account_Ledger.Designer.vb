Namespace Controls.Information.Account
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Account_Ledger
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
            Me.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.SequenceNumber = New DevExpress.XtraEditors.TextEdit()
            Me.TransactionDate = New DevExpress.XtraEditors.DateEdit()
            Me.ReferenceNumber = New DevExpress.XtraEditors.TextEdit()
            Me.ORNumber = New DevExpress.XtraEditors.TextEdit()
            Me.TransactedBy = New DevExpress.XtraEditors.TextEdit()
            Me.Note = New DevExpress.XtraEditors.MemoEdit()
            Me.Remarks = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.TransCode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Mnemonic = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.BeginningBalance = New DevExpress.XtraEditors.CalcEdit()
            Me.Debit = New DevExpress.XtraEditors.CalcEdit()
            Me.Credit = New DevExpress.XtraEditors.CalcEdit()
            Me.EndingBalance = New DevExpress.XtraEditors.CalcEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForSequenceNumber = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForTransCode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForDebit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForCredit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForEndingBalance = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForTransactedBy = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForRemarks = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForNote = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForTransactionDate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForMnemonic = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForReferenceNumber = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForORNumber = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForBeginningBalance = New DevExpress.XtraLayout.LayoutControlItem()
            Me.OutsBal = New DevExpress.XtraEditors.CalcEdit()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl.SuspendLayout()
            CType(Me.SequenceNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TransactionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TransactionDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ReferenceNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ORNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TransactedBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Remarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TransCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Mnemonic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BeginningBalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Debit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Credit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EndingBalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForSequenceNumber, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForTransCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForDebit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForCredit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForEndingBalance, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForTransactedBy, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForNote, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForTransactionDate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForMnemonic, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForReferenceNumber, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForORNumber, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForBeginningBalance, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OutsBal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'LayoutControl
            '
            Me.LayoutControl.Controls.Add(Me.OutsBal)
            Me.LayoutControl.Controls.Add(Me.SequenceNumber)
            Me.LayoutControl.Controls.Add(Me.TransactionDate)
            Me.LayoutControl.Controls.Add(Me.ReferenceNumber)
            Me.LayoutControl.Controls.Add(Me.ORNumber)
            Me.LayoutControl.Controls.Add(Me.TransactedBy)
            Me.LayoutControl.Controls.Add(Me.Note)
            Me.LayoutControl.Controls.Add(Me.Remarks)
            Me.LayoutControl.Controls.Add(Me.TransCode)
            Me.LayoutControl.Controls.Add(Me.Mnemonic)
            Me.LayoutControl.Controls.Add(Me.BeginningBalance)
            Me.LayoutControl.Controls.Add(Me.Debit)
            Me.LayoutControl.Controls.Add(Me.Credit)
            Me.LayoutControl.Controls.Add(Me.EndingBalance)
            Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl.Name = "LayoutControl"
            Me.LayoutControl.Root = Me.Root
            Me.LayoutControl.Size = New System.Drawing.Size(300, 440)
            Me.LayoutControl.TabIndex = 0
            Me.LayoutControl.Text = "LayoutControl"
            '
            'SequenceNumber
            '
            Me.SequenceNumber.Enabled = False
            Me.SequenceNumber.Location = New System.Drawing.Point(110, 12)
            Me.SequenceNumber.Name = "SequenceNumber"
            Me.SequenceNumber.Size = New System.Drawing.Size(178, 20)
            Me.SequenceNumber.StyleController = Me.LayoutControl
            Me.SequenceNumber.TabIndex = 0
            '
            'TransactionDate
            '
            Me.TransactionDate.EditValue = Nothing
            Me.TransactionDate.Location = New System.Drawing.Point(110, 276)
            Me.TransactionDate.Name = "TransactionDate"
            Me.TransactionDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.TransactionDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.TransactionDate.Size = New System.Drawing.Size(178, 20)
            Me.TransactionDate.StyleController = Me.LayoutControl
            Me.TransactionDate.TabIndex = 11
            '
            'ReferenceNumber
            '
            Me.ReferenceNumber.Location = New System.Drawing.Point(110, 84)
            Me.ReferenceNumber.Name = "ReferenceNumber"
            Me.ReferenceNumber.Size = New System.Drawing.Size(178, 20)
            Me.ReferenceNumber.StyleController = Me.LayoutControl
            Me.ReferenceNumber.TabIndex = 3
            '
            'ORNumber
            '
            Me.ORNumber.Location = New System.Drawing.Point(110, 108)
            Me.ORNumber.Name = "ORNumber"
            Me.ORNumber.Size = New System.Drawing.Size(178, 20)
            Me.ORNumber.StyleController = Me.LayoutControl
            Me.ORNumber.TabIndex = 4
            '
            'TransactedBy
            '
            Me.TransactedBy.Enabled = False
            Me.TransactedBy.Location = New System.Drawing.Point(110, 252)
            Me.TransactedBy.Name = "TransactedBy"
            Me.TransactedBy.Size = New System.Drawing.Size(178, 20)
            Me.TransactedBy.StyleController = Me.LayoutControl
            Me.TransactedBy.TabIndex = 10
            '
            'Note
            '
            Me.Note.Location = New System.Drawing.Point(12, 340)
            Me.Note.Name = "Note"
            Me.Note.Size = New System.Drawing.Size(276, 88)
            Me.Note.StyleController = Me.LayoutControl
            Me.Note.TabIndex = 13
            '
            'Remarks
            '
            Me.Remarks.Location = New System.Drawing.Point(110, 300)
            Me.Remarks.Name = "Remarks"
            Me.Remarks.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Remarks.Size = New System.Drawing.Size(178, 20)
            Me.Remarks.StyleController = Me.LayoutControl
            Me.Remarks.TabIndex = 12
            '
            'TransCode
            '
            Me.TransCode.Location = New System.Drawing.Point(110, 36)
            Me.TransCode.Name = "TransCode"
            Me.TransCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.TransCode.Size = New System.Drawing.Size(178, 20)
            Me.TransCode.StyleController = Me.LayoutControl
            Me.TransCode.TabIndex = 1
            '
            'Mnemonic
            '
            Me.Mnemonic.Location = New System.Drawing.Point(110, 60)
            Me.Mnemonic.Name = "Mnemonic"
            Me.Mnemonic.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Mnemonic.Size = New System.Drawing.Size(178, 20)
            Me.Mnemonic.StyleController = Me.LayoutControl
            Me.Mnemonic.TabIndex = 2
            '
            'BeginningBalance
            '
            Me.BeginningBalance.Location = New System.Drawing.Point(110, 132)
            Me.BeginningBalance.Name = "BeginningBalance"
            Me.BeginningBalance.Properties.Appearance.Options.UseTextOptions = True
            Me.BeginningBalance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.BeginningBalance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.BeginningBalance.Properties.Mask.EditMask = "G"
            Me.BeginningBalance.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.BeginningBalance.Size = New System.Drawing.Size(178, 20)
            Me.BeginningBalance.StyleController = Me.LayoutControl
            Me.BeginningBalance.TabIndex = 5
            '
            'Debit
            '
            Me.Debit.Location = New System.Drawing.Point(110, 156)
            Me.Debit.Name = "Debit"
            Me.Debit.Properties.Appearance.Options.UseTextOptions = True
            Me.Debit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Debit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Debit.Properties.Mask.EditMask = "G"
            Me.Debit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.Debit.Size = New System.Drawing.Size(178, 20)
            Me.Debit.StyleController = Me.LayoutControl
            Me.Debit.TabIndex = 6
            '
            'Credit
            '
            Me.Credit.Location = New System.Drawing.Point(110, 180)
            Me.Credit.Name = "Credit"
            Me.Credit.Properties.Appearance.Options.UseTextOptions = True
            Me.Credit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Credit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Credit.Properties.Mask.EditMask = "G"
            Me.Credit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.Credit.Size = New System.Drawing.Size(178, 20)
            Me.Credit.StyleController = Me.LayoutControl
            Me.Credit.TabIndex = 7
            '
            'EndingBalance
            '
            Me.EndingBalance.Location = New System.Drawing.Point(110, 204)
            Me.EndingBalance.Name = "EndingBalance"
            Me.EndingBalance.Properties.Appearance.Options.UseTextOptions = True
            Me.EndingBalance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.EndingBalance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.EndingBalance.Properties.Mask.EditMask = "G"
            Me.EndingBalance.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.EndingBalance.Size = New System.Drawing.Size(178, 20)
            Me.EndingBalance.StyleController = Me.LayoutControl
            Me.EndingBalance.TabIndex = 8
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(300, 440)
            Me.Root.TextVisible = False
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.AllowDrawBackground = False
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForSequenceNumber, Me.ItemForTransCode, Me.ItemForDebit, Me.ItemForCredit, Me.ItemForEndingBalance, Me.ItemForTransactedBy, Me.ItemForRemarks, Me.ItemForNote, Me.ItemForTransactionDate, Me.ItemForMnemonic, Me.ItemForReferenceNumber, Me.ItemForORNumber, Me.ItemForBeginningBalance, Me.LayoutControlItem1})
            Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup1.Name = "autoGeneratedGroup0"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(280, 420)
            '
            'ItemForSequenceNumber
            '
            Me.ItemForSequenceNumber.Control = Me.SequenceNumber
            Me.ItemForSequenceNumber.Location = New System.Drawing.Point(0, 0)
            Me.ItemForSequenceNumber.Name = "ItemForSequenceNumber"
            Me.ItemForSequenceNumber.Size = New System.Drawing.Size(280, 24)
            Me.ItemForSequenceNumber.Text = "ID"
            Me.ItemForSequenceNumber.TextSize = New System.Drawing.Size(95, 13)
            '
            'ItemForTransCode
            '
            Me.ItemForTransCode.Control = Me.TransCode
            Me.ItemForTransCode.Location = New System.Drawing.Point(0, 24)
            Me.ItemForTransCode.Name = "ItemForTransCode"
            Me.ItemForTransCode.Size = New System.Drawing.Size(280, 24)
            Me.ItemForTransCode.Text = "Type"
            Me.ItemForTransCode.TextSize = New System.Drawing.Size(95, 13)
            '
            'ItemForDebit
            '
            Me.ItemForDebit.Control = Me.Debit
            Me.ItemForDebit.Location = New System.Drawing.Point(0, 144)
            Me.ItemForDebit.Name = "ItemForDebit"
            Me.ItemForDebit.Size = New System.Drawing.Size(280, 24)
            Me.ItemForDebit.Text = "Debit"
            Me.ItemForDebit.TextSize = New System.Drawing.Size(95, 13)
            '
            'ItemForCredit
            '
            Me.ItemForCredit.Control = Me.Credit
            Me.ItemForCredit.Location = New System.Drawing.Point(0, 168)
            Me.ItemForCredit.Name = "ItemForCredit"
            Me.ItemForCredit.Size = New System.Drawing.Size(280, 24)
            Me.ItemForCredit.Text = "Credit"
            Me.ItemForCredit.TextSize = New System.Drawing.Size(95, 13)
            '
            'ItemForEndingBalance
            '
            Me.ItemForEndingBalance.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.ItemForEndingBalance.AppearanceItemCaption.Options.UseForeColor = True
            Me.ItemForEndingBalance.Control = Me.EndingBalance
            Me.ItemForEndingBalance.Location = New System.Drawing.Point(0, 192)
            Me.ItemForEndingBalance.Name = "ItemForEndingBalance"
            Me.ItemForEndingBalance.Size = New System.Drawing.Size(280, 24)
            Me.ItemForEndingBalance.Text = "Ending Balance"
            Me.ItemForEndingBalance.TextSize = New System.Drawing.Size(95, 13)
            '
            'ItemForTransactedBy
            '
            Me.ItemForTransactedBy.Control = Me.TransactedBy
            Me.ItemForTransactedBy.Location = New System.Drawing.Point(0, 240)
            Me.ItemForTransactedBy.Name = "ItemForTransactedBy"
            Me.ItemForTransactedBy.Size = New System.Drawing.Size(280, 24)
            Me.ItemForTransactedBy.Text = "Transacted By"
            Me.ItemForTransactedBy.TextSize = New System.Drawing.Size(95, 13)
            '
            'ItemForRemarks
            '
            Me.ItemForRemarks.Control = Me.Remarks
            Me.ItemForRemarks.Location = New System.Drawing.Point(0, 288)
            Me.ItemForRemarks.Name = "ItemForRemarks"
            Me.ItemForRemarks.Size = New System.Drawing.Size(280, 24)
            Me.ItemForRemarks.Text = "Remarks"
            Me.ItemForRemarks.TextSize = New System.Drawing.Size(95, 13)
            '
            'ItemForNote
            '
            Me.ItemForNote.Control = Me.Note
            Me.ItemForNote.Location = New System.Drawing.Point(0, 312)
            Me.ItemForNote.Name = "ItemForNote"
            Me.ItemForNote.Size = New System.Drawing.Size(280, 108)
            Me.ItemForNote.Text = "Note"
            Me.ItemForNote.TextLocation = DevExpress.Utils.Locations.Top
            Me.ItemForNote.TextSize = New System.Drawing.Size(95, 13)
            '
            'ItemForTransactionDate
            '
            Me.ItemForTransactionDate.Control = Me.TransactionDate
            Me.ItemForTransactionDate.Location = New System.Drawing.Point(0, 264)
            Me.ItemForTransactionDate.Name = "ItemForTransactionDate"
            Me.ItemForTransactionDate.Size = New System.Drawing.Size(280, 24)
            Me.ItemForTransactionDate.Text = "Transaction Date"
            Me.ItemForTransactionDate.TextSize = New System.Drawing.Size(95, 13)
            '
            'ItemForMnemonic
            '
            Me.ItemForMnemonic.Control = Me.Mnemonic
            Me.ItemForMnemonic.Location = New System.Drawing.Point(0, 48)
            Me.ItemForMnemonic.Name = "ItemForMnemonic"
            Me.ItemForMnemonic.Size = New System.Drawing.Size(280, 24)
            Me.ItemForMnemonic.Text = "Profile"
            Me.ItemForMnemonic.TextSize = New System.Drawing.Size(95, 13)
            '
            'ItemForReferenceNumber
            '
            Me.ItemForReferenceNumber.Control = Me.ReferenceNumber
            Me.ItemForReferenceNumber.Location = New System.Drawing.Point(0, 72)
            Me.ItemForReferenceNumber.Name = "ItemForReferenceNumber"
            Me.ItemForReferenceNumber.Size = New System.Drawing.Size(280, 24)
            Me.ItemForReferenceNumber.Text = "Reference"
            Me.ItemForReferenceNumber.TextSize = New System.Drawing.Size(95, 13)
            '
            'ItemForORNumber
            '
            Me.ItemForORNumber.Control = Me.ORNumber
            Me.ItemForORNumber.Location = New System.Drawing.Point(0, 96)
            Me.ItemForORNumber.Name = "ItemForORNumber"
            Me.ItemForORNumber.Size = New System.Drawing.Size(280, 24)
            Me.ItemForORNumber.Text = "OR Number"
            Me.ItemForORNumber.TextSize = New System.Drawing.Size(95, 13)
            '
            'ItemForBeginningBalance
            '
            Me.ItemForBeginningBalance.Control = Me.BeginningBalance
            Me.ItemForBeginningBalance.Location = New System.Drawing.Point(0, 120)
            Me.ItemForBeginningBalance.Name = "ItemForBeginningBalance"
            Me.ItemForBeginningBalance.Size = New System.Drawing.Size(280, 24)
            Me.ItemForBeginningBalance.Text = "Beginning Balance"
            Me.ItemForBeginningBalance.TextSize = New System.Drawing.Size(95, 13)
            '
            'OutsBal
            '
            Me.OutsBal.Location = New System.Drawing.Point(110, 228)
            Me.OutsBal.Name = "OutsBal"
            Me.OutsBal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.OutsBal.Size = New System.Drawing.Size(178, 20)
            Me.OutsBal.StyleController = Me.LayoutControl
            Me.OutsBal.TabIndex = 9
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.OutsBal
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 216)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(280, 24)
            Me.LayoutControlItem1.Text = "Outstanding"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(95, 13)
            '
            'xuc_Account_Ledger
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.LayoutControl)
            Me.Name = "xuc_Account_Ledger"
            Me.Size = New System.Drawing.Size(300, 440)
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType(Me.SequenceNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TransactionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TransactionDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ReferenceNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ORNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TransactedBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Remarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TransCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Mnemonic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BeginningBalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Debit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Credit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EndingBalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForSequenceNumber, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForTransCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForDebit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForCredit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForEndingBalance, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForTransactedBy, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForRemarks, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForNote, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForTransactionDate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForMnemonic, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForReferenceNumber, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForORNumber, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForBeginningBalance, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OutsBal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents LayoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents SequenceNumber As DevExpress.XtraEditors.TextEdit
        Friend WithEvents TransactionDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents ReferenceNumber As DevExpress.XtraEditors.TextEdit
        Friend WithEvents ORNumber As DevExpress.XtraEditors.TextEdit
        Friend WithEvents TransactedBy As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents ItemForSequenceNumber As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ItemForTransCode As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ItemForTransactionDate As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ItemForReferenceNumber As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ItemForMnemonic As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ItemForBeginningBalance As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ItemForDebit As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ItemForCredit As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ItemForEndingBalance As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ItemForORNumber As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ItemForTransactedBy As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ItemForRemarks As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ItemForNote As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Note As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Remarks As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents TransCode As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents Mnemonic As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents BeginningBalance As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Debit As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Credit As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents EndingBalance As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents OutsBal As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace