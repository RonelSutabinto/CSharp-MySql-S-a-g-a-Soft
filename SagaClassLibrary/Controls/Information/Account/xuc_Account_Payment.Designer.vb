Namespace Controls.Information.Account
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Account_Payment
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
            Me.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.Penalty = New DevExpress.XtraEditors.CalcEdit()
            Me.TransactionDate = New DevExpress.XtraEditors.DateEdit()
            Me.OR_Number = New DevExpress.XtraEditors.TextEdit()
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.Amount_Paid = New DevExpress.XtraEditors.CalcEdit()
            Me.VAT = New DevExpress.XtraEditors.CalcEdit()
            Me.No_VAT = New DevExpress.XtraEditors.CalcEdit()
            Me.BranchCode = New DevExpress.XtraEditors.LookUpEdit()
            Me.PostingDate = New DevExpress.XtraEditors.DateEdit()
            Me.Payment_Type = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.AccountName = New DevExpress.XtraEditors.ButtonEdit()
            Me.Note = New DevExpress.XtraEditors.MemoEdit()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.TransactionDateitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.OR_Numberitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IDitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Amount_Paiditem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.VATitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.No_VATitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.BranchCodeitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.PostingDateitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Payment_Typeitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.AccountNameitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.labelNote = New DevExpress.XtraLayout.LayoutControlItem()
            Me.TransactedBy = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl.SuspendLayout()
            CType(Me.Penalty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TransactionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TransactionDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OR_Number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Amount_Paid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.VAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.No_VAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BranchCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PostingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PostingDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Payment_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AccountName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TransactionDateitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OR_Numberitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IDitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Amount_Paiditem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.VATitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.No_VATitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BranchCodeitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PostingDateitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Payment_Typeitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AccountNameitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.labelNote, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TransactedBy, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'LayoutControl
            '
            Me.LayoutControl.Controls.Add(Me.Penalty)
            Me.LayoutControl.Controls.Add(Me.TransactionDate)
            Me.LayoutControl.Controls.Add(Me.OR_Number)
            Me.LayoutControl.Controls.Add(Me.ID)
            Me.LayoutControl.Controls.Add(Me.Amount_Paid)
            Me.LayoutControl.Controls.Add(Me.VAT)
            Me.LayoutControl.Controls.Add(Me.No_VAT)
            Me.LayoutControl.Controls.Add(Me.BranchCode)
            Me.LayoutControl.Controls.Add(Me.PostingDate)
            Me.LayoutControl.Controls.Add(Me.Payment_Type)
            Me.LayoutControl.Controls.Add(Me.AccountName)
            Me.LayoutControl.Controls.Add(Me.Note)
            Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl.Name = "LayoutControl"
            Me.LayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(415, 159, 650, 400)
            Me.LayoutControl.Root = Me.LayoutControlGroup1
            Me.LayoutControl.Size = New System.Drawing.Size(250, 348)
            Me.LayoutControl.TabIndex = 0
            '
            'Penalty
            '
            Me.Penalty.Location = New System.Drawing.Point(90, 108)
            Me.Penalty.Name = "Penalty"
            Me.Penalty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Penalty.Size = New System.Drawing.Size(148, 20)
            Me.Penalty.StyleController = Me.LayoutControl
            Me.Penalty.TabIndex = 4
            '
            'TransactionDate
            '
            Me.TransactionDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TransactionDate.EditValue = New Date(2021, 2, 5, 0, 0, 0, 0)
            Me.TransactionDate.Location = New System.Drawing.Point(90, 252)
            Me.TransactionDate.Name = "TransactionDate"
            Me.TransactionDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.TransactionDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.TransactionDate.Size = New System.Drawing.Size(148, 20)
            Me.TransactionDate.StyleController = Me.LayoutControl
            Me.TransactionDate.TabIndex = 10
            '
            'OR_Number
            '
            Me.OR_Number.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.OR_Number.Location = New System.Drawing.Point(90, 84)
            Me.OR_Number.Name = "OR_Number"
            Me.OR_Number.Size = New System.Drawing.Size(148, 20)
            Me.OR_Number.StyleController = Me.LayoutControl
            Me.OR_Number.TabIndex = 3
            '
            'ID
            '
            Me.ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ID.Location = New System.Drawing.Point(90, 12)
            Me.ID.Name = "ID"
            Me.ID.Size = New System.Drawing.Size(148, 20)
            Me.ID.StyleController = Me.LayoutControl
            Me.ID.TabIndex = 0
            '
            'Amount_Paid
            '
            Me.Amount_Paid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Amount_Paid.Location = New System.Drawing.Point(90, 132)
            Me.Amount_Paid.Name = "Amount_Paid"
            Me.Amount_Paid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Amount_Paid.Size = New System.Drawing.Size(148, 20)
            Me.Amount_Paid.StyleController = Me.LayoutControl
            Me.Amount_Paid.TabIndex = 5
            '
            'VAT
            '
            Me.VAT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.VAT.Location = New System.Drawing.Point(90, 156)
            Me.VAT.Name = "VAT"
            Me.VAT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.VAT.Size = New System.Drawing.Size(148, 20)
            Me.VAT.StyleController = Me.LayoutControl
            Me.VAT.TabIndex = 6
            '
            'No_VAT
            '
            Me.No_VAT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.No_VAT.Location = New System.Drawing.Point(90, 180)
            Me.No_VAT.Name = "No_VAT"
            Me.No_VAT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.No_VAT.Size = New System.Drawing.Size(148, 20)
            Me.No_VAT.StyleController = Me.LayoutControl
            Me.No_VAT.TabIndex = 7
            '
            'BranchCode
            '
            Me.BranchCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BranchCode.Enabled = False
            Me.BranchCode.Location = New System.Drawing.Point(90, 36)
            Me.BranchCode.Name = "BranchCode"
            Me.BranchCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.BranchCode.Properties.NullText = ""
            Me.BranchCode.Size = New System.Drawing.Size(148, 20)
            Me.BranchCode.StyleController = Me.LayoutControl
            Me.BranchCode.TabIndex = 1
            '
            'PostingDate
            '
            Me.PostingDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PostingDate.EditValue = New Date(2021, 2, 5, 0, 0, 0, 0)
            Me.PostingDate.Location = New System.Drawing.Point(90, 228)
            Me.PostingDate.Name = "PostingDate"
            Me.PostingDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.PostingDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.PostingDate.Size = New System.Drawing.Size(148, 20)
            Me.PostingDate.StyleController = Me.LayoutControl
            Me.PostingDate.TabIndex = 9
            '
            'Payment_Type
            '
            Me.Payment_Type.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Payment_Type.Location = New System.Drawing.Point(90, 60)
            Me.Payment_Type.Name = "Payment_Type"
            Me.Payment_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Payment_Type.Size = New System.Drawing.Size(148, 20)
            Me.Payment_Type.StyleController = Me.LayoutControl
            Me.Payment_Type.TabIndex = 2
            '
            'AccountName
            '
            Me.AccountName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.AccountName.Location = New System.Drawing.Point(90, 204)
            Me.AccountName.Name = "AccountName"
            Me.AccountName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
            Me.AccountName.Size = New System.Drawing.Size(148, 20)
            Me.AccountName.StyleController = Me.LayoutControl
            Me.AccountName.TabIndex = 8
            '
            'Note
            '
            Me.Note.Location = New System.Drawing.Point(90, 276)
            Me.Note.Name = "Note"
            Me.Note.Size = New System.Drawing.Size(148, 43)
            Me.Note.StyleController = Me.LayoutControl
            Me.Note.TabIndex = 11
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TransactionDateitem, Me.OR_Numberitem, Me.IDitem, Me.Amount_Paiditem, Me.VATitem, Me.No_VATitem, Me.BranchCodeitem, Me.PostingDateitem, Me.Payment_Typeitem, Me.AccountNameitem, Me.labelNote, Me.TransactedBy, Me.LayoutControlItem1})
            Me.LayoutControlGroup1.Name = "Root"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(250, 348)
            Me.LayoutControlGroup1.TextVisible = False
            '
            'TransactionDateitem
            '
            Me.TransactionDateitem.Control = Me.TransactionDate
            Me.TransactionDateitem.Location = New System.Drawing.Point(0, 240)
            Me.TransactionDateitem.Name = "TransactionDateitem"
            Me.TransactionDateitem.Size = New System.Drawing.Size(230, 24)
            Me.TransactionDateitem.Text = "Transacted"
            Me.TransactionDateitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.TransactionDateitem.TextSize = New System.Drawing.Size(66, 13)
            '
            'OR_Numberitem
            '
            Me.OR_Numberitem.Control = Me.OR_Number
            Me.OR_Numberitem.Location = New System.Drawing.Point(0, 72)
            Me.OR_Numberitem.Name = "OR_Numberitem"
            Me.OR_Numberitem.Size = New System.Drawing.Size(230, 24)
            Me.OR_Numberitem.Text = "OR Code"
            Me.OR_Numberitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.OR_Numberitem.TextSize = New System.Drawing.Size(66, 13)
            '
            'IDitem
            '
            Me.IDitem.Control = Me.ID
            Me.IDitem.Location = New System.Drawing.Point(0, 0)
            Me.IDitem.Name = "IDitem"
            Me.IDitem.Size = New System.Drawing.Size(230, 24)
            Me.IDitem.Text = "Table ID"
            Me.IDitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.IDitem.TextSize = New System.Drawing.Size(66, 13)
            '
            'Amount_Paiditem
            '
            Me.Amount_Paiditem.Control = Me.Amount_Paid
            Me.Amount_Paiditem.Location = New System.Drawing.Point(0, 120)
            Me.Amount_Paiditem.Name = "Amount_Paiditem"
            Me.Amount_Paiditem.Size = New System.Drawing.Size(230, 24)
            Me.Amount_Paiditem.Text = "Paid"
            Me.Amount_Paiditem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Amount_Paiditem.TextSize = New System.Drawing.Size(66, 13)
            '
            'VATitem
            '
            Me.VATitem.Control = Me.VAT
            Me.VATitem.Location = New System.Drawing.Point(0, 144)
            Me.VATitem.Name = "VATitem"
            Me.VATitem.Size = New System.Drawing.Size(230, 24)
            Me.VATitem.Text = "VAT"
            Me.VATitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.VATitem.TextSize = New System.Drawing.Size(66, 13)
            '
            'No_VATitem
            '
            Me.No_VATitem.Control = Me.No_VAT
            Me.No_VATitem.Location = New System.Drawing.Point(0, 168)
            Me.No_VATitem.Name = "No_VATitem"
            Me.No_VATitem.Size = New System.Drawing.Size(230, 24)
            Me.No_VATitem.Text = "No VAT"
            Me.No_VATitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.No_VATitem.TextSize = New System.Drawing.Size(66, 13)
            '
            'BranchCodeitem
            '
            Me.BranchCodeitem.Control = Me.BranchCode
            Me.BranchCodeitem.Location = New System.Drawing.Point(0, 24)
            Me.BranchCodeitem.Name = "BranchCodeitem"
            Me.BranchCodeitem.Size = New System.Drawing.Size(230, 24)
            Me.BranchCodeitem.Text = "Branch"
            Me.BranchCodeitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.BranchCodeitem.TextSize = New System.Drawing.Size(66, 13)
            '
            'PostingDateitem
            '
            Me.PostingDateitem.Control = Me.PostingDate
            Me.PostingDateitem.Location = New System.Drawing.Point(0, 216)
            Me.PostingDateitem.Name = "PostingDateitem"
            Me.PostingDateitem.Size = New System.Drawing.Size(230, 24)
            Me.PostingDateitem.Text = "Posting"
            Me.PostingDateitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.PostingDateitem.TextSize = New System.Drawing.Size(66, 13)
            '
            'Payment_Typeitem
            '
            Me.Payment_Typeitem.Control = Me.Payment_Type
            Me.Payment_Typeitem.Location = New System.Drawing.Point(0, 48)
            Me.Payment_Typeitem.Name = "Payment_Typeitem"
            Me.Payment_Typeitem.Size = New System.Drawing.Size(230, 24)
            Me.Payment_Typeitem.Text = "Type"
            Me.Payment_Typeitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Payment_Typeitem.TextSize = New System.Drawing.Size(66, 13)
            '
            'AccountNameitem
            '
            Me.AccountNameitem.Control = Me.AccountName
            Me.AccountNameitem.Location = New System.Drawing.Point(0, 192)
            Me.AccountNameitem.Name = "AccountNameitem"
            Me.AccountNameitem.Size = New System.Drawing.Size(230, 24)
            Me.AccountNameitem.Text = "Name"
            Me.AccountNameitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.AccountNameitem.TextSize = New System.Drawing.Size(66, 13)
            '
            'labelNote
            '
            Me.labelNote.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.labelNote.AppearanceItemCaption.Options.UseForeColor = True
            Me.labelNote.Control = Me.Note
            Me.labelNote.Location = New System.Drawing.Point(0, 264)
            Me.labelNote.Name = "labelNote"
            Me.labelNote.Size = New System.Drawing.Size(230, 47)
            Me.labelNote.Text = "Notes"
            Me.labelNote.TextSize = New System.Drawing.Size(66, 13)
            '
            'TransactedBy
            '
            Me.TransactedBy.AllowHotTrack = False
            Me.TransactedBy.Location = New System.Drawing.Point(0, 311)
            Me.TransactedBy.Name = "TransactedBy"
            Me.TransactedBy.Size = New System.Drawing.Size(230, 17)
            Me.TransactedBy.Text = "TransactedBy"
            Me.TransactedBy.TextSize = New System.Drawing.Size(66, 13)
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.Penalty
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem1.Text = "Penalty"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(66, 13)
            '
            'xuc_Account_Payment
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.LayoutControl)
            Me.Name = "xuc_Account_Payment"
            Me.Size = New System.Drawing.Size(250, 348)
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType(Me.Penalty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TransactionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TransactionDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OR_Number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Amount_Paid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.VAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.No_VAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BranchCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PostingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PostingDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Payment_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AccountName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TransactionDateitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OR_Numberitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IDitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Amount_Paiditem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.VATitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.No_VATitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BranchCodeitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PostingDateitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Payment_Typeitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AccountNameitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.labelNote, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TransactedBy, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents OR_Number As DevExpress.XtraEditors.TextEdit
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Amount_Paid As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents VAT As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents No_VAT As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents BranchCode As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents PostingDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents TransactionDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Payment_Type As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents AccountName As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents TransactionDateitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents OR_Numberitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IDitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Amount_Paiditem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents VATitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents No_VATitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents BranchCodeitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents PostingDateitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Payment_Typeitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents AccountNameitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Note As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents labelNote As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents TransactedBy As DevExpress.XtraLayout.SimpleLabelItem
        Friend WithEvents Penalty As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace