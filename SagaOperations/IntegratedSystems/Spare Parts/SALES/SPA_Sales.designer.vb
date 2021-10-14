<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SPA_Sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPA_Sales))
        Me.lv_Parts = New System.Windows.Forms.ListView()
        Me.BranchCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Unit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grossTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Discount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Discount_PCT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.discountSPR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.subTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.prev_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partsNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partsName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_Payment = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_AmountPaid = New System.Windows.Forms.Label()
        Me.lbl_Tendered = New System.Windows.Forms.Label()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Change = New System.Windows.Forms.Label()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.lbl_Quantity = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkNonVAT = New System.Windows.Forms.RadioButton()
        Me.chkVAT = New System.Windows.Forms.RadioButton()
        Me.panelRight = New System.Windows.Forms.Panel()
        Me.lv_Parts1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_Note1 = New System.Windows.Forms.Label()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.dtp_Date1 = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Address1 = New System.Windows.Forms.Label()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Custname1 = New System.Windows.Forms.Label()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_CustDep = New System.Windows.Forms.Label()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Change1 = New System.Windows.Forms.Label()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Tendered1 = New System.Windows.Forms.Label()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_AmountPaid1 = New System.Windows.Forms.Label()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_TotalAmount1 = New System.Windows.Forms.Label()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_totalVAT = New System.Windows.Forms.Label()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_AddVAT = New System.Windows.Forms.Label()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Due = New System.Windows.Forms.Label()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Tamount = New System.Windows.Forms.Label()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_TotalLess1 = New System.Windows.Forms.Label()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_totalLess = New System.Windows.Forms.Label()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_PWD = New System.Windows.Forms.Label()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_NetVat = New System.Windows.Forms.Label()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_lessVAT = New System.Windows.Forms.Label()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Total1 = New System.Windows.Forms.Label()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_VAT2 = New System.Windows.Forms.Label()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_VAT1 = New System.Windows.Forms.Label()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_AccountNumber = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_LedgerSetNumber = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Error = New DevExpress.XtraEditors.TextEdit()
        Me.txt_CustName = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_CRNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Address = New DevExpress.XtraEditors.TextEdit()
        Me.txt_custCodeLedger = New DevExpress.XtraEditors.TextEdit()
        Me.txt_TransCode = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ID = New DevExpress.XtraEditors.TextEdit()
        Me.cmb_Pricing = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmb_Terms = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_partsName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_partsNumber = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Bill = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_Note = New DevExpress.XtraEditors.TextEdit()
        Me.txt_SINo = New DevExpress.XtraEditors.TextEdit()
        Me.dtp_Date = New DevExpress.XtraEditors.DateEdit()
        Me.toolNew = New System.Windows.Forms.ToolStripButton()
        Me.toolSave = New System.Windows.Forms.ToolStripButton()
        Me.toolPrint = New System.Windows.Forms.ToolStripButton()
        Me.cmb_SI_Code = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmb_TransCategory = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_Search = New DevExpress.XtraEditors.TextEdit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelRight.SuspendLayout()
        CType(Me.txt_Error.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CustName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CRNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_custCodeLedger.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TransCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Pricing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Terms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_partsName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_partsNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SINo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_SI_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_TransCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lv_Parts
        '
        Me.lv_Parts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BranchCode, Me.quantity, Me.Unit, Me.description, Me.unitPrice, Me.grossTotal, Me.Discount, Me.Discount_PCT, Me.discountSPR, Me.subTotal, Me.prev_ID, Me.partsNumber, Me.partsName})
        Me.lv_Parts.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_Parts.ForeColor = System.Drawing.Color.Teal
        Me.lv_Parts.FullRowSelect = True
        Me.lv_Parts.GridLines = True
        Me.lv_Parts.HideSelection = False
        Me.lv_Parts.Location = New System.Drawing.Point(13, 338)
        Me.lv_Parts.Margin = New System.Windows.Forms.Padding(4)
        Me.lv_Parts.Name = "lv_Parts"
        Me.lv_Parts.Size = New System.Drawing.Size(1009, 169)
        Me.lv_Parts.TabIndex = 4
        Me.lv_Parts.UseCompatibleStateImageBehavior = False
        Me.lv_Parts.View = System.Windows.Forms.View.Details
        '
        'BranchCode
        '
        Me.BranchCode.Text = "Branch Code"
        Me.BranchCode.Width = 0
        '
        'quantity
        '
        Me.quantity.Text = "Quantity"
        Me.quantity.Width = 85
        '
        'Unit
        '
        Me.Unit.Text = "Unit"
        Me.Unit.Width = 0
        '
        'description
        '
        Me.description.Text = "Description"
        Me.description.Width = 260
        '
        'unitPrice
        '
        Me.unitPrice.Text = "Unit Price"
        Me.unitPrice.Width = 122
        '
        'grossTotal
        '
        Me.grossTotal.Text = "Gross Total"
        Me.grossTotal.Width = 129
        '
        'Discount
        '
        Me.Discount.Text = "Discount"
        Me.Discount.Width = 132
        '
        'Discount_PCT
        '
        Me.Discount_PCT.Text = "Discount PCT"
        Me.Discount_PCT.Width = 128
        '
        'discountSPR
        '
        Me.discountSPR.Text = "Discounted Unit Price"
        Me.discountSPR.Width = 150
        '
        'subTotal
        '
        Me.subTotal.Text = "SubTotal"
        Me.subTotal.Width = 150
        '
        'prev_ID
        '
        Me.prev_ID.Text = "prev_ID"
        Me.prev_ID.Width = 0
        '
        'partsNumber
        '
        Me.partsNumber.Text = "PARTS NUMBER"
        Me.partsNumber.Width = 0
        '
        'partsName
        '
        Me.partsName.Text = "PARTS NAME"
        Me.partsName.Width = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(570, 511)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(126, 19)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Total Amount Due"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(13, 35)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(230, 29)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Transaction Category"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(650, 209)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 29)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "Date"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(49, 79)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(175, 29)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Customer Name"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(643, 35)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(88, 29)
        Me.LabelControl8.TabIndex = 17
        Me.LabelControl8.Text = "Invoices"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(13, 299)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(230, 29)
        Me.LabelControl9.TabIndex = 18
        Me.LabelControl9.Text = "Search Parts Number"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolNew, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.toolSave, Me.ToolStripSeparator4, Me.ToolStripSeparator1, Me.toolPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1407, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btn_Payment
        '
        Me.btn_Payment.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Payment.Appearance.Options.UseFont = True
        Me.btn_Payment.Location = New System.Drawing.Point(14, 539)
        Me.btn_Payment.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Payment.Name = "btn_Payment"
        Me.btn_Payment.Size = New System.Drawing.Size(198, 67)
        Me.btn_Payment.TabIndex = 22
        Me.btn_Payment.Text = "Input Payment"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(570, 560)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(129, 19)
        Me.LabelControl1.TabIndex = 23
        Me.LabelControl1.Text = "Total Amount Paid"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(570, 536)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(125, 19)
        Me.LabelControl10.TabIndex = 25
        Me.LabelControl10.Text = "Amount Tendered"
        '
        'lbl_AmountPaid
        '
        Me.lbl_AmountPaid.AutoSize = True
        Me.lbl_AmountPaid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AmountPaid.ForeColor = System.Drawing.Color.White
        Me.lbl_AmountPaid.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_AmountPaid.Location = New System.Drawing.Point(868, 560)
        Me.lbl_AmountPaid.Name = "lbl_AmountPaid"
        Me.lbl_AmountPaid.Size = New System.Drawing.Size(37, 19)
        Me.lbl_AmountPaid.TabIndex = 24
        Me.lbl_AmountPaid.Text = "0.00"
        Me.lbl_AmountPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Tendered
        '
        Me.lbl_Tendered.AutoSize = True
        Me.lbl_Tendered.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tendered.ForeColor = System.Drawing.Color.White
        Me.lbl_Tendered.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Tendered.Location = New System.Drawing.Point(868, 536)
        Me.lbl_Tendered.Name = "lbl_Tendered"
        Me.lbl_Tendered.Size = New System.Drawing.Size(37, 19)
        Me.lbl_Tendered.TabIndex = 26
        Me.lbl_Tendered.Text = "0.00"
        Me.lbl_Tendered.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.ForeColor = System.Drawing.Color.White
        Me.lbl_Total.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Total.Location = New System.Drawing.Point(868, 511)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(37, 19)
        Me.lbl_Total.TabIndex = 19
        Me.lbl_Total.Text = "0.00"
        Me.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(109, 164)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(115, 29)
        Me.LabelControl7.TabIndex = 28
        Me.LabelControl7.Text = "SI Number"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(135, 124)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(89, 29)
        Me.LabelControl6.TabIndex = 30
        Me.LabelControl6.Text = "Address"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(172, 254)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(52, 29)
        Me.LabelControl11.TabIndex = 32
        Me.LabelControl11.Text = "Note"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(154, 209)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(70, 29)
        Me.LabelControl12.TabIndex = 38
        Me.LabelControl12.Text = "Terms"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(14, 513)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(250, 23)
        Me.LabelControl13.TabIndex = 39
        Me.LabelControl13.Text = "Double click the Item to Remove."
        '
        'lbl_Change
        '
        Me.lbl_Change.AutoSize = True
        Me.lbl_Change.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Change.ForeColor = System.Drawing.Color.White
        Me.lbl_Change.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Change.Location = New System.Drawing.Point(868, 585)
        Me.lbl_Change.Name = "lbl_Change"
        Me.lbl_Change.Size = New System.Drawing.Size(37, 19)
        Me.lbl_Change.TabIndex = 41
        Me.lbl_Change.Text = "0.00"
        Me.lbl_Change.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Appearance.Options.UseForeColor = True
        Me.LabelControl14.Location = New System.Drawing.Point(570, 585)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(89, 19)
        Me.LabelControl14.TabIndex = 40
        Me.LabelControl14.Text = "Total Change"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Appearance.Options.UseForeColor = True
        Me.LabelControl15.Location = New System.Drawing.Point(744, 299)
        Me.LabelControl15.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(75, 29)
        Me.LabelControl15.TabIndex = 42
        Me.LabelControl15.Text = "Pricing"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'lbl_Quantity
        '
        Me.lbl_Quantity.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Quantity.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_Quantity.Appearance.Options.UseFont = True
        Me.lbl_Quantity.Appearance.Options.UseForeColor = True
        Me.lbl_Quantity.Location = New System.Drawing.Point(373, 458)
        Me.lbl_Quantity.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_Quantity.Name = "lbl_Quantity"
        Me.lbl_Quantity.Size = New System.Drawing.Size(13, 29)
        Me.lbl_Quantity.TabIndex = 106
        Me.lbl_Quantity.Text = "0"
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl28.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl28.Appearance.Options.UseFont = True
        Me.LabelControl28.Appearance.Options.UseForeColor = True
        Me.LabelControl28.Location = New System.Drawing.Point(581, 164)
        Me.LabelControl28.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(127, 29)
        Me.LabelControl28.TabIndex = 108
        Me.LabelControl28.Text = "CR Number"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkNonVAT)
        Me.Panel1.Controls.Add(Me.chkVAT)
        Me.Panel1.Location = New System.Drawing.Point(257, 556)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 48)
        Me.Panel1.TabIndex = 109
        '
        'chkNonVAT
        '
        Me.chkNonVAT.AutoSize = True
        Me.chkNonVAT.ForeColor = System.Drawing.Color.White
        Me.chkNonVAT.Location = New System.Drawing.Point(116, 10)
        Me.chkNonVAT.Name = "chkNonVAT"
        Me.chkNonVAT.Size = New System.Drawing.Size(77, 23)
        Me.chkNonVAT.TabIndex = 1
        Me.chkNonVAT.Text = "NonVAT"
        Me.chkNonVAT.UseVisualStyleBackColor = True
        '
        'chkVAT
        '
        Me.chkVAT.AutoSize = True
        Me.chkVAT.Checked = True
        Me.chkVAT.ForeColor = System.Drawing.Color.White
        Me.chkVAT.Location = New System.Drawing.Point(14, 10)
        Me.chkVAT.Name = "chkVAT"
        Me.chkVAT.Size = New System.Drawing.Size(51, 23)
        Me.chkVAT.TabIndex = 0
        Me.chkVAT.TabStop = True
        Me.chkVAT.Text = "VAT"
        Me.chkVAT.UseVisualStyleBackColor = True
        '
        'panelRight
        '
        Me.panelRight.Controls.Add(Me.lv_Parts1)
        Me.panelRight.Controls.Add(Me.txt_Note1)
        Me.panelRight.Controls.Add(Me.LabelControl37)
        Me.panelRight.Controls.Add(Me.dtp_Date1)
        Me.panelRight.Controls.Add(Me.LabelControl31)
        Me.panelRight.Controls.Add(Me.txt_Address1)
        Me.panelRight.Controls.Add(Me.LabelControl30)
        Me.panelRight.Controls.Add(Me.txt_Custname1)
        Me.panelRight.Controls.Add(Me.LabelControl29)
        Me.panelRight.Location = New System.Drawing.Point(1043, 32)
        Me.panelRight.Name = "panelRight"
        Me.panelRight.Size = New System.Drawing.Size(556, 251)
        Me.panelRight.TabIndex = 110
        '
        'lv_Parts1
        '
        Me.lv_Parts1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.lv_Parts1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_Parts1.ForeColor = System.Drawing.Color.Teal
        Me.lv_Parts1.FullRowSelect = True
        Me.lv_Parts1.GridLines = True
        Me.lv_Parts1.HideSelection = False
        Me.lv_Parts1.Location = New System.Drawing.Point(20, 132)
        Me.lv_Parts1.Margin = New System.Windows.Forms.Padding(4)
        Me.lv_Parts1.Name = "lv_Parts1"
        Me.lv_Parts1.Size = New System.Drawing.Size(523, 112)
        Me.lv_Parts1.TabIndex = 154
        Me.lv_Parts1.UseCompatibleStateImageBehavior = False
        Me.lv_Parts1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Branch Code"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Quantity"
        Me.ColumnHeader2.Width = 110
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Unit"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Description"
        Me.ColumnHeader4.Width = 260
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Unit Price"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Discounted Unit Price"
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Gross Total"
        Me.ColumnHeader7.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Discount"
        Me.ColumnHeader8.Width = 150
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Discount PCT"
        Me.ColumnHeader9.Width = 150
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "SubTotal"
        Me.ColumnHeader10.Width = 150
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "prev_ID"
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "PARTS NUMBER"
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "PARTS NAME"
        Me.ColumnHeader13.Width = 0
        '
        'txt_Note1
        '
        Me.txt_Note1.AutoSize = True
        Me.txt_Note1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Note1.ForeColor = System.Drawing.Color.White
        Me.txt_Note1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txt_Note1.Location = New System.Drawing.Point(158, 101)
        Me.txt_Note1.Name = "txt_Note1"
        Me.txt_Note1.Size = New System.Drawing.Size(20, 18)
        Me.txt_Note1.TabIndex = 152
        Me.txt_Note1.Text = "..."
        Me.txt_Note1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl37
        '
        Me.LabelControl37.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl37.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl37.Appearance.Options.UseFont = True
        Me.LabelControl37.Appearance.Options.UseForeColor = True
        Me.LabelControl37.Location = New System.Drawing.Point(16, 101)
        Me.LabelControl37.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(31, 18)
        Me.LabelControl37.TabIndex = 151
        Me.LabelControl37.Text = "Note"
        '
        'dtp_Date1
        '
        Me.dtp_Date1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Date1.Location = New System.Drawing.Point(161, 65)
        Me.dtp_Date1.Name = "dtp_Date1"
        Me.dtp_Date1.Size = New System.Drawing.Size(106, 27)
        Me.dtp_Date1.TabIndex = 150
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl31.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl31.Appearance.Options.UseFont = True
        Me.LabelControl31.Appearance.Options.UseForeColor = True
        Me.LabelControl31.Location = New System.Drawing.Point(16, 70)
        Me.LabelControl31.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(29, 18)
        Me.LabelControl31.TabIndex = 140
        Me.LabelControl31.Text = "Date"
        '
        'txt_Address1
        '
        Me.txt_Address1.AutoSize = True
        Me.txt_Address1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address1.ForeColor = System.Drawing.Color.White
        Me.txt_Address1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txt_Address1.Location = New System.Drawing.Point(158, 44)
        Me.txt_Address1.Name = "txt_Address1"
        Me.txt_Address1.Size = New System.Drawing.Size(15, 18)
        Me.txt_Address1.TabIndex = 139
        Me.txt_Address1.Text = "0"
        Me.txt_Address1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl30
        '
        Me.LabelControl30.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl30.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl30.Appearance.Options.UseFont = True
        Me.LabelControl30.Appearance.Options.UseForeColor = True
        Me.LabelControl30.Location = New System.Drawing.Point(16, 44)
        Me.LabelControl30.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(50, 18)
        Me.LabelControl30.TabIndex = 138
        Me.LabelControl30.Text = "Address"
        '
        'txt_Custname1
        '
        Me.txt_Custname1.AutoSize = True
        Me.txt_Custname1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Custname1.ForeColor = System.Drawing.Color.White
        Me.txt_Custname1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txt_Custname1.Location = New System.Drawing.Point(158, 15)
        Me.txt_Custname1.Name = "txt_Custname1"
        Me.txt_Custname1.Size = New System.Drawing.Size(15, 18)
        Me.txt_Custname1.TabIndex = 137
        Me.txt_Custname1.Text = "0"
        Me.txt_Custname1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl29.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl29.Appearance.Options.UseFont = True
        Me.LabelControl29.Appearance.Options.UseForeColor = True
        Me.LabelControl29.Location = New System.Drawing.Point(16, 15)
        Me.LabelControl29.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(37, 18)
        Me.LabelControl29.TabIndex = 136
        Me.LabelControl29.Text = "Name"
        '
        'lbl_CustDep
        '
        Me.lbl_CustDep.AutoSize = True
        Me.lbl_CustDep.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CustDep.ForeColor = System.Drawing.Color.White
        Me.lbl_CustDep.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_CustDep.Location = New System.Drawing.Point(1361, 468)
        Me.lbl_CustDep.Name = "lbl_CustDep"
        Me.lbl_CustDep.Size = New System.Drawing.Size(37, 19)
        Me.lbl_CustDep.TabIndex = 186
        Me.lbl_CustDep.Text = "0.00"
        Me.lbl_CustDep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl36.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl36.Appearance.Options.UseFont = True
        Me.LabelControl36.Appearance.Options.UseForeColor = True
        Me.LabelControl36.Location = New System.Drawing.Point(1063, 468)
        Me.LabelControl36.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(153, 19)
        Me.LabelControl36.TabIndex = 185
        Me.LabelControl36.Text = "Total Customer Deposit"
        '
        'lbl_Change1
        '
        Me.lbl_Change1.AutoSize = True
        Me.lbl_Change1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Change1.ForeColor = System.Drawing.Color.White
        Me.lbl_Change1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Change1.Location = New System.Drawing.Point(1361, 569)
        Me.lbl_Change1.Name = "lbl_Change1"
        Me.lbl_Change1.Size = New System.Drawing.Size(37, 19)
        Me.lbl_Change1.TabIndex = 184
        Me.lbl_Change1.Text = "0.00"
        Me.lbl_Change1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl32.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl32.Appearance.Options.UseFont = True
        Me.LabelControl32.Appearance.Options.UseForeColor = True
        Me.LabelControl32.Location = New System.Drawing.Point(1063, 569)
        Me.LabelControl32.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(86, 19)
        Me.LabelControl32.TabIndex = 183
        Me.LabelControl32.Text = "Total Change"
        '
        'lbl_Tendered1
        '
        Me.lbl_Tendered1.AutoSize = True
        Me.lbl_Tendered1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tendered1.ForeColor = System.Drawing.Color.White
        Me.lbl_Tendered1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Tendered1.Location = New System.Drawing.Point(1361, 520)
        Me.lbl_Tendered1.Name = "lbl_Tendered1"
        Me.lbl_Tendered1.Size = New System.Drawing.Size(37, 19)
        Me.lbl_Tendered1.TabIndex = 182
        Me.lbl_Tendered1.Text = "0.00"
        Me.lbl_Tendered1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl33
        '
        Me.LabelControl33.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl33.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl33.Appearance.Options.UseFont = True
        Me.LabelControl33.Appearance.Options.UseForeColor = True
        Me.LabelControl33.Location = New System.Drawing.Point(1063, 520)
        Me.LabelControl33.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(115, 19)
        Me.LabelControl33.TabIndex = 181
        Me.LabelControl33.Text = "Amount Tendered"
        '
        'lbl_AmountPaid1
        '
        Me.lbl_AmountPaid1.AutoSize = True
        Me.lbl_AmountPaid1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AmountPaid1.ForeColor = System.Drawing.Color.White
        Me.lbl_AmountPaid1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_AmountPaid1.Location = New System.Drawing.Point(1361, 544)
        Me.lbl_AmountPaid1.Name = "lbl_AmountPaid1"
        Me.lbl_AmountPaid1.Size = New System.Drawing.Size(37, 19)
        Me.lbl_AmountPaid1.TabIndex = 180
        Me.lbl_AmountPaid1.Text = "0.00"
        Me.lbl_AmountPaid1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl34.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl34.Appearance.Options.UseFont = True
        Me.LabelControl34.Appearance.Options.UseForeColor = True
        Me.LabelControl34.Location = New System.Drawing.Point(1063, 544)
        Me.LabelControl34.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(119, 19)
        Me.LabelControl34.TabIndex = 179
        Me.LabelControl34.Text = "Total Amount Paid"
        '
        'lbl_TotalAmount1
        '
        Me.lbl_TotalAmount1.AutoSize = True
        Me.lbl_TotalAmount1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalAmount1.ForeColor = System.Drawing.Color.White
        Me.lbl_TotalAmount1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_TotalAmount1.Location = New System.Drawing.Point(1361, 495)
        Me.lbl_TotalAmount1.Name = "lbl_TotalAmount1"
        Me.lbl_TotalAmount1.Size = New System.Drawing.Size(37, 19)
        Me.lbl_TotalAmount1.TabIndex = 178
        Me.lbl_TotalAmount1.Text = "0.00"
        Me.lbl_TotalAmount1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl35.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl35.Appearance.Options.UseFont = True
        Me.LabelControl35.Appearance.Options.UseForeColor = True
        Me.LabelControl35.Location = New System.Drawing.Point(1063, 495)
        Me.LabelControl35.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(117, 19)
        Me.LabelControl35.TabIndex = 177
        Me.LabelControl35.Text = "Total Amount Due"
        '
        'lbl_totalVAT
        '
        Me.lbl_totalVAT.AutoSize = True
        Me.lbl_totalVAT.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalVAT.ForeColor = System.Drawing.Color.White
        Me.lbl_totalVAT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_totalVAT.Location = New System.Drawing.Point(1572, 629)
        Me.lbl_totalVAT.Name = "lbl_totalVAT"
        Me.lbl_totalVAT.Size = New System.Drawing.Size(33, 18)
        Me.lbl_totalVAT.TabIndex = 176
        Me.lbl_totalVAT.Text = "0.00"
        Me.lbl_totalVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Appearance.Options.UseForeColor = True
        Me.LabelControl22.Location = New System.Drawing.Point(1425, 626)
        Me.LabelControl22.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(112, 18)
        Me.LabelControl22.TabIndex = 175
        Me.LabelControl22.Text = "Total Amount Due"
        '
        'lbl_AddVAT
        '
        Me.lbl_AddVAT.AutoSize = True
        Me.lbl_AddVAT.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AddVAT.ForeColor = System.Drawing.Color.White
        Me.lbl_AddVAT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_AddVAT.Location = New System.Drawing.Point(1572, 603)
        Me.lbl_AddVAT.Name = "lbl_AddVAT"
        Me.lbl_AddVAT.Size = New System.Drawing.Size(33, 18)
        Me.lbl_AddVAT.TabIndex = 174
        Me.lbl_AddVAT.Text = "0.00"
        Me.lbl_AddVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl23.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl23.Appearance.Options.UseFont = True
        Me.LabelControl23.Appearance.Options.UseForeColor = True
        Me.LabelControl23.Location = New System.Drawing.Point(1425, 600)
        Me.LabelControl23.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(53, 18)
        Me.LabelControl23.TabIndex = 173
        Me.LabelControl23.Text = "Add VAT"
        '
        'lbl_Due
        '
        Me.lbl_Due.AutoSize = True
        Me.lbl_Due.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Due.ForeColor = System.Drawing.Color.White
        Me.lbl_Due.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Due.Location = New System.Drawing.Point(1572, 577)
        Me.lbl_Due.Name = "lbl_Due"
        Me.lbl_Due.Size = New System.Drawing.Size(33, 18)
        Me.lbl_Due.TabIndex = 172
        Me.lbl_Due.Text = "0.00"
        Me.lbl_Due.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl24.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl24.Appearance.Options.UseFont = True
        Me.LabelControl24.Appearance.Options.UseForeColor = True
        Me.LabelControl24.Location = New System.Drawing.Point(1425, 574)
        Me.LabelControl24.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(78, 18)
        Me.LabelControl24.TabIndex = 171
        Me.LabelControl24.Text = "Amount Due"
        '
        'lbl_Tamount
        '
        Me.lbl_Tamount.AutoSize = True
        Me.lbl_Tamount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tamount.ForeColor = System.Drawing.Color.White
        Me.lbl_Tamount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Tamount.Location = New System.Drawing.Point(1566, 284)
        Me.lbl_Tamount.Name = "lbl_Tamount"
        Me.lbl_Tamount.Size = New System.Drawing.Size(15, 18)
        Me.lbl_Tamount.TabIndex = 170
        Me.lbl_Tamount.Text = "0"
        Me.lbl_Tamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Appearance.Options.UseForeColor = True
        Me.LabelControl21.Location = New System.Drawing.Point(1424, 287)
        Me.LabelControl21.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(84, 18)
        Me.LabelControl21.TabIndex = 169
        Me.LabelControl21.Text = "Total Amount"
        '
        'lbl_TotalLess1
        '
        Me.lbl_TotalLess1.AutoSize = True
        Me.lbl_TotalLess1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalLess1.ForeColor = System.Drawing.Color.White
        Me.lbl_TotalLess1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_TotalLess1.Location = New System.Drawing.Point(1567, 394)
        Me.lbl_TotalLess1.Name = "lbl_TotalLess1"
        Me.lbl_TotalLess1.Size = New System.Drawing.Size(15, 18)
        Me.lbl_TotalLess1.TabIndex = 168
        Me.lbl_TotalLess1.Text = "0"
        Me.lbl_TotalLess1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Appearance.Options.UseForeColor = True
        Me.LabelControl20.Location = New System.Drawing.Point(1425, 391)
        Me.LabelControl20.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(59, 18)
        Me.LabelControl20.TabIndex = 167
        Me.LabelControl20.Text = "Total VAT"
        '
        'lbl_totalLess
        '
        Me.lbl_totalLess.AutoSize = True
        Me.lbl_totalLess.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalLess.ForeColor = System.Drawing.Color.White
        Me.lbl_totalLess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_totalLess.Location = New System.Drawing.Point(1567, 341)
        Me.lbl_totalLess.Name = "lbl_totalLess"
        Me.lbl_totalLess.Size = New System.Drawing.Size(15, 18)
        Me.lbl_totalLess.TabIndex = 166
        Me.lbl_totalLess.Text = "0"
        Me.lbl_totalLess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Appearance.Options.UseForeColor = True
        Me.LabelControl19.Location = New System.Drawing.Point(1425, 338)
        Me.LabelControl19.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(85, 18)
        Me.LabelControl19.TabIndex = 165
        Me.LabelControl19.Text = "Total Net VAT"
        '
        'lbl_PWD
        '
        Me.lbl_PWD.AutoSize = True
        Me.lbl_PWD.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PWD.ForeColor = System.Drawing.Color.White
        Me.lbl_PWD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_PWD.Location = New System.Drawing.Point(1572, 553)
        Me.lbl_PWD.Name = "lbl_PWD"
        Me.lbl_PWD.Size = New System.Drawing.Size(33, 18)
        Me.lbl_PWD.TabIndex = 164
        Me.lbl_PWD.Text = "0.00"
        Me.lbl_PWD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl25.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl25.Appearance.Options.UseFont = True
        Me.LabelControl25.Appearance.Options.UseForeColor = True
        Me.LabelControl25.Location = New System.Drawing.Point(1424, 550)
        Me.LabelControl25.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(141, 18)
        Me.LabelControl25.TabIndex = 163
        Me.LabelControl25.Text = "Less: SC/PWD Discount"
        '
        'lbl_NetVat
        '
        Me.lbl_NetVat.AutoSize = True
        Me.lbl_NetVat.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NetVat.ForeColor = System.Drawing.Color.White
        Me.lbl_NetVat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_NetVat.Location = New System.Drawing.Point(1571, 528)
        Me.lbl_NetVat.Name = "lbl_NetVat"
        Me.lbl_NetVat.Size = New System.Drawing.Size(33, 18)
        Me.lbl_NetVat.TabIndex = 162
        Me.lbl_NetVat.Text = "0.00"
        Me.lbl_NetVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl26.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl26.Appearance.Options.UseFont = True
        Me.LabelControl26.Appearance.Options.UseForeColor = True
        Me.LabelControl26.Location = New System.Drawing.Point(1424, 525)
        Me.LabelControl26.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(103, 18)
        Me.LabelControl26.TabIndex = 161
        Me.LabelControl26.Text = "AMT NET OF VAT"
        '
        'lbl_lessVAT
        '
        Me.lbl_lessVAT.AutoSize = True
        Me.lbl_lessVAT.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lessVAT.ForeColor = System.Drawing.Color.White
        Me.lbl_lessVAT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_lessVAT.Location = New System.Drawing.Point(1571, 502)
        Me.lbl_lessVAT.Name = "lbl_lessVAT"
        Me.lbl_lessVAT.Size = New System.Drawing.Size(33, 18)
        Me.lbl_lessVAT.TabIndex = 160
        Me.lbl_lessVAT.Text = "0.00"
        Me.lbl_lessVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl27.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl27.Appearance.Options.UseFont = True
        Me.LabelControl27.Appearance.Options.UseForeColor = True
        Me.LabelControl27.Location = New System.Drawing.Point(1424, 499)
        Me.LabelControl27.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(54, 18)
        Me.LabelControl27.TabIndex = 159
        Me.LabelControl27.Text = "Less VAT"
        '
        'lbl_Total1
        '
        Me.lbl_Total1.AutoSize = True
        Me.lbl_Total1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total1.ForeColor = System.Drawing.Color.White
        Me.lbl_Total1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Total1.Location = New System.Drawing.Point(1567, 414)
        Me.lbl_Total1.Name = "lbl_Total1"
        Me.lbl_Total1.Size = New System.Drawing.Size(33, 18)
        Me.lbl_Total1.TabIndex = 158
        Me.lbl_Total1.Text = "1.00"
        Me.lbl_Total1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Appearance.Options.UseForeColor = True
        Me.LabelControl18.Location = New System.Drawing.Point(1425, 417)
        Me.LabelControl18.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(59, 18)
        Me.LabelControl18.TabIndex = 157
        Me.LabelControl18.Text = "Total VAT"
        '
        'lbl_VAT2
        '
        Me.lbl_VAT2.AutoSize = True
        Me.lbl_VAT2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VAT2.ForeColor = System.Drawing.Color.White
        Me.lbl_VAT2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_VAT2.Location = New System.Drawing.Point(1567, 361)
        Me.lbl_VAT2.Name = "lbl_VAT2"
        Me.lbl_VAT2.Size = New System.Drawing.Size(33, 18)
        Me.lbl_VAT2.TabIndex = 156
        Me.lbl_VAT2.Text = "0.12"
        Me.lbl_VAT2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Appearance.Options.UseForeColor = True
        Me.LabelControl17.Location = New System.Drawing.Point(1425, 364)
        Me.LabelControl17.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(53, 18)
        Me.LabelControl17.TabIndex = 155
        Me.LabelControl17.Text = "VAT 0.12"
        '
        'lbl_VAT1
        '
        Me.lbl_VAT1.AutoSize = True
        Me.lbl_VAT1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VAT1.ForeColor = System.Drawing.Color.White
        Me.lbl_VAT1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_VAT1.Location = New System.Drawing.Point(1567, 309)
        Me.lbl_VAT1.Name = "lbl_VAT1"
        Me.lbl_VAT1.Size = New System.Drawing.Size(33, 18)
        Me.lbl_VAT1.TabIndex = 154
        Me.lbl_VAT1.Text = "1.12"
        Me.lbl_VAT1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Appearance.Options.UseForeColor = True
        Me.LabelControl16.Location = New System.Drawing.Point(1425, 312)
        Me.LabelControl16.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(53, 18)
        Me.LabelControl16.TabIndex = 153
        Me.LabelControl16.Text = "VAT 1.12"
        '
        'lbl_AccountNumber
        '
        Me.lbl_AccountNumber.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_AccountNumber.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AccountNumber.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_AccountNumber.Appearance.Options.UseBackColor = True
        Me.lbl_AccountNumber.Appearance.Options.UseFont = True
        Me.lbl_AccountNumber.Appearance.Options.UseForeColor = True
        Me.lbl_AccountNumber.Location = New System.Drawing.Point(701, 77)
        Me.lbl_AccountNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_AccountNumber.Name = "lbl_AccountNumber"
        Me.lbl_AccountNumber.Size = New System.Drawing.Size(39, 29)
        Me.lbl_AccountNumber.TabIndex = 187
        Me.lbl_AccountNumber.Text = "000"
        Me.lbl_AccountNumber.Visible = False
        '
        'lbl_LedgerSetNumber
        '
        Me.lbl_LedgerSetNumber.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LedgerSetNumber.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_LedgerSetNumber.Appearance.Options.UseFont = True
        Me.lbl_LedgerSetNumber.Appearance.Options.UseForeColor = True
        Me.lbl_LedgerSetNumber.Location = New System.Drawing.Point(373, 76)
        Me.lbl_LedgerSetNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_LedgerSetNumber.Name = "lbl_LedgerSetNumber"
        Me.lbl_LedgerSetNumber.Size = New System.Drawing.Size(39, 29)
        Me.lbl_LedgerSetNumber.TabIndex = 188
        Me.lbl_LedgerSetNumber.Text = "000"
        Me.lbl_LedgerSetNumber.Visible = False
        '
        'txt_Error
        '
        Me.txt_Error.Location = New System.Drawing.Point(13, 210)
        Me.txt_Error.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Error.Name = "txt_Error"
        Me.txt_Error.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Error.Properties.Appearance.Options.UseFont = True
        Me.txt_Error.Size = New System.Drawing.Size(108, 36)
        Me.txt_Error.TabIndex = 189
        Me.txt_Error.Visible = False
        '
        'txt_CustName
        '
        Me.txt_CustName.Enabled = False
        Me.txt_CustName.Location = New System.Drawing.Point(257, 73)
        Me.txt_CustName.Name = "txt_CustName"
        Me.txt_CustName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CustName.Properties.Appearance.Options.UseFont = True
        Me.txt_CustName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_CustName.Size = New System.Drawing.Size(718, 36)
        Me.txt_CustName.TabIndex = 73
        '
        'txt_CRNumber
        '
        Me.txt_CRNumber.Location = New System.Drawing.Point(716, 161)
        Me.txt_CRNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_CRNumber.Name = "txt_CRNumber"
        Me.txt_CRNumber.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CRNumber.Properties.Appearance.Options.UseFont = True
        Me.txt_CRNumber.Size = New System.Drawing.Size(306, 36)
        Me.txt_CRNumber.TabIndex = 107
        '
        'txt_Address
        '
        Me.txt_Address.EnterMoveNextControl = True
        Me.txt_Address.Location = New System.Drawing.Point(257, 117)
        Me.txt_Address.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address.Properties.Appearance.Options.UseFont = True
        Me.txt_Address.Properties.ReadOnly = True
        Me.txt_Address.Size = New System.Drawing.Size(765, 36)
        Me.txt_Address.TabIndex = 29
        '
        'txt_custCodeLedger
        '
        Me.txt_custCodeLedger.Location = New System.Drawing.Point(359, 121)
        Me.txt_custCodeLedger.Name = "txt_custCodeLedger"
        Me.txt_custCodeLedger.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_custCodeLedger.Properties.Appearance.Options.UseFont = True
        Me.txt_custCodeLedger.Properties.ReadOnly = True
        Me.txt_custCodeLedger.Size = New System.Drawing.Size(250, 26)
        Me.txt_custCodeLedger.TabIndex = 105
        '
        'txt_TransCode
        '
        Me.txt_TransCode.Enabled = False
        Me.txt_TransCode.Location = New System.Drawing.Point(526, 30)
        Me.txt_TransCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_TransCode.Name = "txt_TransCode"
        Me.txt_TransCode.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TransCode.Properties.Appearance.Options.UseFont = True
        Me.txt_TransCode.Size = New System.Drawing.Size(93, 36)
        Me.txt_TransCode.TabIndex = 8
        '
        'txt_ID
        '
        Me.txt_ID.Enabled = False
        Me.txt_ID.Location = New System.Drawing.Point(568, 31)
        Me.txt_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Properties.Appearance.Options.UseFont = True
        Me.txt_ID.Size = New System.Drawing.Size(41, 36)
        Me.txt_ID.TabIndex = 72
        '
        'cmb_Pricing
        '
        Me.cmb_Pricing.EditValue = "1"
        Me.cmb_Pricing.EnterMoveNextControl = True
        Me.cmb_Pricing.Location = New System.Drawing.Point(832, 296)
        Me.cmb_Pricing.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_Pricing.Name = "cmb_Pricing"
        Me.cmb_Pricing.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Pricing.Properties.Appearance.Options.UseFont = True
        Me.cmb_Pricing.Properties.AutoHeight = False
        Me.cmb_Pricing.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Pricing.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmb_Pricing.Size = New System.Drawing.Size(190, 36)
        Me.cmb_Pricing.TabIndex = 43
        '
        'cmb_Terms
        '
        Me.cmb_Terms.EditValue = "0"
        Me.cmb_Terms.Enabled = False
        Me.cmb_Terms.EnterMoveNextControl = True
        Me.cmb_Terms.Location = New System.Drawing.Point(257, 206)
        Me.cmb_Terms.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_Terms.Name = "cmb_Terms"
        Me.cmb_Terms.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Terms.Properties.Appearance.Options.UseFont = True
        Me.cmb_Terms.Properties.AutoHeight = False
        Me.cmb_Terms.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Terms.Properties.Items.AddRange(New Object() {"30", "45", "60"})
        Me.cmb_Terms.Size = New System.Drawing.Size(314, 36)
        Me.cmb_Terms.TabIndex = 37
        '
        'txt_partsName
        '
        Me.txt_partsName.Location = New System.Drawing.Point(716, 451)
        Me.txt_partsName.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_partsName.Name = "txt_partsName"
        Me.txt_partsName.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_partsName.Properties.Appearance.Options.UseFont = True
        Me.txt_partsName.Size = New System.Drawing.Size(195, 36)
        Me.txt_partsName.TabIndex = 35
        '
        'txt_partsNumber
        '
        Me.txt_partsNumber.Location = New System.Drawing.Point(716, 439)
        Me.txt_partsNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_partsNumber.Name = "txt_partsNumber"
        Me.txt_partsNumber.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_partsNumber.Properties.Appearance.Options.UseFont = True
        Me.txt_partsNumber.Size = New System.Drawing.Size(195, 36)
        Me.txt_partsNumber.TabIndex = 34
        '
        'btn_Bill
        '
        Me.btn_Bill.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Bill.Appearance.Options.UseFont = True
        Me.btn_Bill.ImageOptions.Image = CType(resources.GetObject("btn_Bill.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Bill.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter
        Me.btn_Bill.Location = New System.Drawing.Point(982, 71)
        Me.btn_Bill.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Bill.Name = "btn_Bill"
        Me.btn_Bill.Size = New System.Drawing.Size(40, 38)
        Me.btn_Bill.TabIndex = 33
        '
        'txt_Note
        '
        Me.txt_Note.EnterMoveNextControl = True
        Me.txt_Note.Location = New System.Drawing.Point(257, 251)
        Me.txt_Note.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Note.Name = "txt_Note"
        Me.txt_Note.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Note.Properties.Appearance.Options.UseFont = True
        Me.txt_Note.Size = New System.Drawing.Size(765, 36)
        Me.txt_Note.TabIndex = 31
        '
        'txt_SINo
        '
        Me.txt_SINo.Location = New System.Drawing.Point(257, 161)
        Me.txt_SINo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_SINo.Name = "txt_SINo"
        Me.txt_SINo.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SINo.Properties.Appearance.Options.UseFont = True
        Me.txt_SINo.Size = New System.Drawing.Size(314, 36)
        Me.txt_SINo.TabIndex = 27
        '
        'dtp_Date
        '
        Me.dtp_Date.EditValue = Nothing
        Me.dtp_Date.EnterMoveNextControl = True
        Me.dtp_Date.Location = New System.Drawing.Point(716, 206)
        Me.dtp_Date.Name = "dtp_Date"
        Me.dtp_Date.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date.Properties.Appearance.Options.UseFont = True
        Me.dtp_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_Date.Properties.DisplayFormat.FormatString = "MM/dd/ yyyy"
        Me.dtp_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_Date.Properties.EditFormat.FormatString = "MM/dd/ yyyy"
        Me.dtp_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_Date.Properties.Mask.EditMask = "MM/dd/ yyyy"
        Me.dtp_Date.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dtp_Date.Size = New System.Drawing.Size(306, 36)
        Me.dtp_Date.TabIndex = 21
        '
        'toolNew
        '
        Me.toolNew.AutoSize = False
        Me.toolNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolNew.Image = CType(resources.GetObject("toolNew.Image"), System.Drawing.Image)
        Me.toolNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolNew.Name = "toolNew"
        Me.toolNew.Size = New System.Drawing.Size(23, 22)
        Me.toolNew.Text = "NEW"
        '
        'toolSave
        '
        Me.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolSave.Image = CType(resources.GetObject("toolSave.Image"), System.Drawing.Image)
        Me.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolSave.Name = "toolSave"
        Me.toolSave.Size = New System.Drawing.Size(23, 22)
        Me.toolSave.Text = "POST"
        '
        'toolPrint
        '
        Me.toolPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolPrint.Image = CType(resources.GetObject("toolPrint.Image"), System.Drawing.Image)
        Me.toolPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolPrint.Name = "toolPrint"
        Me.toolPrint.Size = New System.Drawing.Size(23, 22)
        Me.toolPrint.Text = "PRINT"
        '
        'cmb_SI_Code
        '
        Me.cmb_SI_Code.EnterMoveNextControl = True
        Me.cmb_SI_Code.Location = New System.Drawing.Point(744, 32)
        Me.cmb_SI_Code.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_SI_Code.Name = "cmb_SI_Code"
        Me.cmb_SI_Code.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_SI_Code.Properties.Appearance.Options.UseFont = True
        Me.cmb_SI_Code.Properties.AutoHeight = False
        Me.cmb_SI_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_SI_Code.Size = New System.Drawing.Size(278, 36)
        Me.cmb_SI_Code.TabIndex = 6
        '
        'cmb_TransCategory
        '
        Me.cmb_TransCategory.EnterMoveNextControl = True
        Me.cmb_TransCategory.Location = New System.Drawing.Point(257, 29)
        Me.cmb_TransCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_TransCategory.Name = "cmb_TransCategory"
        Me.cmb_TransCategory.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TransCategory.Properties.Appearance.Options.UseFont = True
        Me.cmb_TransCategory.Properties.AutoHeight = False
        Me.cmb_TransCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_TransCategory.Properties.Items.AddRange(New Object() {"Cash Invoice", "Charge Invoice", "Ads & Promos", "Maintenance Issue", "Recon Expenses"})
        Me.cmb_TransCategory.Size = New System.Drawing.Size(261, 36)
        Me.cmb_TransCategory.TabIndex = 1
        '
        'txt_Search
        '
        Me.txt_Search.Location = New System.Drawing.Point(257, 296)
        Me.txt_Search.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Properties.Appearance.Options.UseFont = True
        Me.txt_Search.Size = New System.Drawing.Size(474, 36)
        Me.txt_Search.TabIndex = 7
        '
        'SPA_Sales
        '
        Me.Appearance.BackColor = System.Drawing.Color.Teal
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 614)
        Me.Controls.Add(Me.txt_Error)
        Me.Controls.Add(Me.txt_CustName)
        Me.Controls.Add(Me.lbl_CustDep)
        Me.Controls.Add(Me.LabelControl36)
        Me.Controls.Add(Me.lbl_Change1)
        Me.Controls.Add(Me.LabelControl32)
        Me.Controls.Add(Me.lbl_Tendered1)
        Me.Controls.Add(Me.LabelControl33)
        Me.Controls.Add(Me.lbl_AmountPaid1)
        Me.Controls.Add(Me.LabelControl34)
        Me.Controls.Add(Me.lbl_TotalAmount1)
        Me.Controls.Add(Me.LabelControl35)
        Me.Controls.Add(Me.lbl_totalVAT)
        Me.Controls.Add(Me.LabelControl22)
        Me.Controls.Add(Me.lbl_AddVAT)
        Me.Controls.Add(Me.LabelControl23)
        Me.Controls.Add(Me.lbl_Due)
        Me.Controls.Add(Me.LabelControl24)
        Me.Controls.Add(Me.lbl_Tamount)
        Me.Controls.Add(Me.LabelControl21)
        Me.Controls.Add(Me.lbl_TotalLess1)
        Me.Controls.Add(Me.LabelControl20)
        Me.Controls.Add(Me.lbl_totalLess)
        Me.Controls.Add(Me.LabelControl19)
        Me.Controls.Add(Me.lbl_PWD)
        Me.Controls.Add(Me.LabelControl25)
        Me.Controls.Add(Me.lbl_NetVat)
        Me.Controls.Add(Me.LabelControl26)
        Me.Controls.Add(Me.lbl_lessVAT)
        Me.Controls.Add(Me.LabelControl27)
        Me.Controls.Add(Me.lbl_Total1)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.lbl_VAT2)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.lbl_VAT1)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.panelRight)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelControl28)
        Me.Controls.Add(Me.txt_CRNumber)
        Me.Controls.Add(Me.lv_Parts)
        Me.Controls.Add(Me.lbl_Quantity)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.txt_custCodeLedger)
        Me.Controls.Add(Me.txt_TransCode)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.cmb_Pricing)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.lbl_Change)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.cmb_Terms)
        Me.Controls.Add(Me.txt_partsName)
        Me.Controls.Add(Me.txt_partsNumber)
        Me.Controls.Add(Me.btn_Bill)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txt_Note)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txt_SINo)
        Me.Controls.Add(Me.lbl_Tendered)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.lbl_AmountPaid)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_Payment)
        Me.Controls.Add(Me.dtp_Date)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.cmb_SI_Code)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmb_TransCategory)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.lbl_AccountNumber)
        Me.Controls.Add(Me.lbl_LedgerSetNumber)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(963, 646)
        Me.Name = "SPA_Sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALES"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelRight.ResumeLayout(False)
        Me.panelRight.PerformLayout()
        CType(Me.txt_Error.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CustName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CRNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_custCodeLedger.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TransCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Pricing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Terms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_partsName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_partsNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SINo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_SI_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_TransCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv_Parts As ListView
    Friend WithEvents BranchCode As ColumnHeader
    Friend WithEvents quantity As ColumnHeader
    Friend WithEvents Unit As ColumnHeader
    Friend WithEvents description As ColumnHeader
    Friend WithEvents unitPrice As ColumnHeader
    Friend WithEvents subTotal As ColumnHeader
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents toolNew As ToolStripButton
    Friend WithEvents toolSave As ToolStripButton
    Friend WithEvents toolPrint As ToolStripButton
    Friend WithEvents txt_Search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmb_SI_Code As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmb_TransCategory As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_TransCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtp_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btn_Payment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_AmountPaid As Label
    Friend WithEvents lbl_Tendered As Label
    Friend WithEvents lbl_Total As Label
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_SINo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Address As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Note As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Bill As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents prev_ID As ColumnHeader
    Friend WithEvents txt_partsNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_partsName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Terms As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Change As Label
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Pricing As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents partsNumber As ColumnHeader
    Friend WithEvents partsName As ColumnHeader
    Friend WithEvents txt_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_CustName As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents txt_custCodeLedger As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_Quantity As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_CRNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Discount As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkNonVAT As RadioButton
    Friend WithEvents chkVAT As RadioButton
    Friend WithEvents panelRight As Panel
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Address1 As Label
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Custname1 As Label
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtp_Date1 As DateTimePicker
    Friend WithEvents lbl_CustDep As Label
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Change1 As Label
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Tendered1 As Label
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_AmountPaid1 As Label
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_TotalAmount1 As Label
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_totalVAT As Label
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_AddVAT As Label
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Due As Label
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Tamount As Label
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_TotalLess1 As Label
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_totalLess As Label
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_PWD As Label
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_NetVat As Label
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_lessVAT As Label
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Total1 As Label
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_VAT2 As Label
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_VAT1 As Label
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_AccountNumber As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_LedgerSetNumber As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Error As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Note1 As Label
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Discount_PCT As ColumnHeader
    Friend WithEvents discountSPR As ColumnHeader
    Friend WithEvents grossTotal As ColumnHeader
    Friend WithEvents lv_Parts1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
End Class
