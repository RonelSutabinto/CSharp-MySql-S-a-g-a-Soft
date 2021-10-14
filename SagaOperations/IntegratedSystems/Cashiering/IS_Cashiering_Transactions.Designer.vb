<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Cashiering_Transactions
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Cashiering_Transactions))
        Me.cmb_transactions = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_invoices = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cust = New System.Windows.Forms.TextBox()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.txt_amt = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.newtool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolpostpayment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.infoTool = New System.Windows.Forms.ToolStripButton()
        Me.toolPrint = New System.Windows.Forms.ToolStripButton()
        Me.show_Account = New System.Windows.Forms.Button()
        Me.txt_cifkey = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_acctcodeMne = New System.Windows.Forms.TextBox()
        Me.txt_refno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.postingDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nonvat = New System.Windows.Forms.RadioButton()
        Me.vat = New System.Windows.Forms.RadioButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.postingDate2 = New System.Windows.Forms.DateTimePicker()
        Me.txt_refno2 = New System.Windows.Forms.TextBox()
        Me.txt_acctcodeMne2 = New System.Windows.Forms.TextBox()
        Me.txt_address2 = New System.Windows.Forms.TextBox()
        Me.txt_cifkey2 = New System.Windows.Forms.TextBox()
        Me.txt_amt2 = New System.Windows.Forms.TextBox()
        Me.txt_description2 = New System.Windows.Forms.TextBox()
        Me.txt_cust2 = New System.Windows.Forms.TextBox()
        Me.cmb_transactions2 = New System.Windows.Forms.TextBox()
        Me.cmb_invoices2 = New System.Windows.Forms.TextBox()
        Me.txt_vatamt = New System.Windows.Forms.TextBox()
        Me.txt_amtNetOfVat = New System.Windows.Forms.TextBox()
        Me.txt_discnt2 = New System.Windows.Forms.TextBox()
        Me.txt_discnt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_netgross2 = New System.Windows.Forms.TextBox()
        Me.txt_numtoword = New System.Windows.Forms.TextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.txt_BranchCodeCust = New System.Windows.Forms.TextBox()
        Me.txt_LedsetCust = New System.Windows.Forms.TextBox()
        Me.txt_AccountNumberCust = New System.Windows.Forms.TextBox()
        Me.txt_TransID = New System.Windows.Forms.TextBox()
        Me.txt_TargetFrm = New System.Windows.Forms.TextBox()
        Me.txt_FrmText = New System.Windows.Forms.TextBox()
        Me.txt_ErrNo = New DevExpress.XtraEditors.TextEdit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.txt_ErrNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_transactions
        '
        Me.cmb_transactions.FormattingEnabled = True
        Me.cmb_transactions.Location = New System.Drawing.Point(125, 40)
        Me.cmb_transactions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_transactions.Name = "cmb_transactions"
        Me.cmb_transactions.Size = New System.Drawing.Size(211, 26)
        Me.cmb_transactions.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TRANSACTIONS"
        '
        'cmb_invoices
        '
        Me.cmb_invoices.FormattingEnabled = True
        Me.cmb_invoices.Location = New System.Drawing.Point(125, 70)
        Me.cmb_invoices.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_invoices.Name = "cmb_invoices"
        Me.cmb_invoices.Size = New System.Drawing.Size(297, 26)
        Me.cmb_invoices.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "INVOICES"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "BILL TO"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DESCRIPTION"
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "AMOUNT DUE"
        '
        'txt_cust
        '
        Me.txt_cust.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cust.Location = New System.Drawing.Point(125, 137)
        Me.txt_cust.Name = "txt_cust"
        Me.txt_cust.ReadOnly = True
        Me.txt_cust.Size = New System.Drawing.Size(258, 26)
        Me.txt_cust.TabIndex = 7
        '
        'txt_description
        '
        Me.txt_description.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_description.Location = New System.Drawing.Point(125, 247)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(297, 90)
        Me.txt_description.TabIndex = 8
        '
        'txt_amt
        '
        Me.txt_amt.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amt.Location = New System.Drawing.Point(125, 339)
        Me.txt_amt.Name = "txt_amt"
        Me.txt_amt.Size = New System.Drawing.Size(297, 37)
        Me.txt_amt.TabIndex = 9
        Me.txt_amt.Text = "0.00"
        Me.txt_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newtool, Me.ToolStripSeparator2, Me.toolpostpayment, Me.ToolStripSeparator3, Me.infoTool, Me.toolPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(822, 32)
        Me.ToolStrip1.TabIndex = 223
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'newtool
        '
        Me.newtool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newtool.Image = CType(resources.GetObject("newtool.Image"), System.Drawing.Image)
        Me.newtool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newtool.Name = "newtool"
        Me.newtool.Size = New System.Drawing.Size(23, 29)
        Me.newtool.Text = "ToolStripButton2"
        Me.newtool.ToolTipText = "NEW"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'toolpostpayment
        '
        Me.toolpostpayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolpostpayment.Image = CType(resources.GetObject("toolpostpayment.Image"), System.Drawing.Image)
        Me.toolpostpayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolpostpayment.Name = "toolpostpayment"
        Me.toolpostpayment.Size = New System.Drawing.Size(23, 29)
        Me.toolpostpayment.Text = "ToolStripButton1"
        Me.toolpostpayment.ToolTipText = "UPDATE"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 32)
        '
        'infoTool
        '
        Me.infoTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.infoTool.Image = CType(resources.GetObject("infoTool.Image"), System.Drawing.Image)
        Me.infoTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.infoTool.Name = "infoTool"
        Me.infoTool.Size = New System.Drawing.Size(23, 29)
        Me.infoTool.Text = "infoTool"
        '
        'toolPrint
        '
        Me.toolPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolPrint.Image = CType(resources.GetObject("toolPrint.Image"), System.Drawing.Image)
        Me.toolPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolPrint.Name = "toolPrint"
        Me.toolPrint.Size = New System.Drawing.Size(23, 29)
        Me.toolPrint.Text = "OR"
        Me.toolPrint.ToolTipText = "Print"
        '
        'show_Account
        '
        Me.show_Account.BackColor = System.Drawing.Color.White
        Me.show_Account.BackgroundImage = CType(resources.GetObject("show_Account.BackgroundImage"), System.Drawing.Image)
        Me.show_Account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.show_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.show_Account.Location = New System.Drawing.Point(389, 137)
        Me.show_Account.Name = "show_Account"
        Me.show_Account.Size = New System.Drawing.Size(31, 26)
        Me.show_Account.TabIndex = 224
        Me.show_Account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.show_Account.UseVisualStyleBackColor = False
        '
        'txt_cifkey
        '
        Me.txt_cifkey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cifkey.Location = New System.Drawing.Point(125, 164)
        Me.txt_cifkey.Name = "txt_cifkey"
        Me.txt_cifkey.ReadOnly = True
        Me.txt_cifkey.Size = New System.Drawing.Size(211, 26)
        Me.txt_cifkey.TabIndex = 225
        '
        'txt_address
        '
        Me.txt_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_address.Location = New System.Drawing.Point(125, 191)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.ReadOnly = True
        Me.txt_address.Size = New System.Drawing.Size(297, 26)
        Me.txt_address.TabIndex = 226
        '
        'txt_acctcodeMne
        '
        Me.txt_acctcodeMne.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acctcodeMne.Location = New System.Drawing.Point(342, 39)
        Me.txt_acctcodeMne.Name = "txt_acctcodeMne"
        Me.txt_acctcodeMne.ReadOnly = True
        Me.txt_acctcodeMne.Size = New System.Drawing.Size(80, 27)
        Me.txt_acctcodeMne.TabIndex = 227
        '
        'txt_refno
        '
        Me.txt_refno.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_refno.Location = New System.Drawing.Point(125, 219)
        Me.txt_refno.Name = "txt_refno"
        Me.txt_refno.Size = New System.Drawing.Size(297, 26)
        Me.txt_refno.TabIndex = 229
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 228
        Me.Label6.Text = "REF NO"
        '
        'postingDate
        '
        Me.postingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.postingDate.Location = New System.Drawing.Point(125, 100)
        Me.postingDate.Name = "postingDate"
        Me.postingDate.Size = New System.Drawing.Size(211, 26)
        Me.postingDate.TabIndex = 230
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "POSTING DATE"
        '
        'nonvat
        '
        Me.nonvat.AutoSize = True
        Me.nonvat.Checked = True
        Me.nonvat.ForeColor = System.Drawing.Color.White
        Me.nonvat.Location = New System.Drawing.Point(189, 413)
        Me.nonvat.Name = "nonvat"
        Me.nonvat.Size = New System.Drawing.Size(75, 22)
        Me.nonvat.TabIndex = 231
        Me.nonvat.TabStop = True
        Me.nonvat.Text = "NonVAT"
        Me.nonvat.UseVisualStyleBackColor = True
        '
        'vat
        '
        Me.vat.AutoSize = True
        Me.vat.ForeColor = System.Drawing.Color.White
        Me.vat.Location = New System.Drawing.Point(125, 413)
        Me.vat.Name = "vat"
        Me.vat.Size = New System.Drawing.Size(49, 22)
        Me.vat.TabIndex = 231
        Me.vat.Text = "VAT"
        Me.vat.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'postingDate2
        '
        Me.postingDate2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.postingDate2.Location = New System.Drawing.Point(503, 101)
        Me.postingDate2.Name = "postingDate2"
        Me.postingDate2.Size = New System.Drawing.Size(123, 26)
        Me.postingDate2.TabIndex = 241
        Me.postingDate2.Visible = False
        '
        'txt_refno2
        '
        Me.txt_refno2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_refno2.Location = New System.Drawing.Point(503, 220)
        Me.txt_refno2.Name = "txt_refno2"
        Me.txt_refno2.Size = New System.Drawing.Size(297, 26)
        Me.txt_refno2.TabIndex = 240
        Me.txt_refno2.Visible = False
        '
        'txt_acctcodeMne2
        '
        Me.txt_acctcodeMne2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acctcodeMne2.Location = New System.Drawing.Point(720, 41)
        Me.txt_acctcodeMne2.Name = "txt_acctcodeMne2"
        Me.txt_acctcodeMne2.ReadOnly = True
        Me.txt_acctcodeMne2.Size = New System.Drawing.Size(80, 27)
        Me.txt_acctcodeMne2.TabIndex = 239
        Me.txt_acctcodeMne2.Visible = False
        '
        'txt_address2
        '
        Me.txt_address2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_address2.Location = New System.Drawing.Point(503, 192)
        Me.txt_address2.Name = "txt_address2"
        Me.txt_address2.ReadOnly = True
        Me.txt_address2.Size = New System.Drawing.Size(297, 26)
        Me.txt_address2.TabIndex = 238
        Me.txt_address2.Visible = False
        '
        'txt_cifkey2
        '
        Me.txt_cifkey2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cifkey2.Location = New System.Drawing.Point(503, 165)
        Me.txt_cifkey2.Name = "txt_cifkey2"
        Me.txt_cifkey2.ReadOnly = True
        Me.txt_cifkey2.Size = New System.Drawing.Size(211, 26)
        Me.txt_cifkey2.TabIndex = 237
        Me.txt_cifkey2.Visible = False
        '
        'txt_amt2
        '
        Me.txt_amt2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amt2.Location = New System.Drawing.Point(503, 340)
        Me.txt_amt2.Name = "txt_amt2"
        Me.txt_amt2.Size = New System.Drawing.Size(112, 37)
        Me.txt_amt2.TabIndex = 236
        Me.txt_amt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_amt2.Visible = False
        '
        'txt_description2
        '
        Me.txt_description2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_description2.Location = New System.Drawing.Point(503, 248)
        Me.txt_description2.Multiline = True
        Me.txt_description2.Name = "txt_description2"
        Me.txt_description2.Size = New System.Drawing.Size(297, 86)
        Me.txt_description2.TabIndex = 235
        Me.txt_description2.Visible = False
        '
        'txt_cust2
        '
        Me.txt_cust2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cust2.Location = New System.Drawing.Point(503, 138)
        Me.txt_cust2.Name = "txt_cust2"
        Me.txt_cust2.ReadOnly = True
        Me.txt_cust2.Size = New System.Drawing.Size(123, 26)
        Me.txt_cust2.TabIndex = 234
        Me.txt_cust2.Visible = False
        '
        'cmb_transactions2
        '
        Me.cmb_transactions2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmb_transactions2.Location = New System.Drawing.Point(503, 42)
        Me.cmb_transactions2.Name = "cmb_transactions2"
        Me.cmb_transactions2.ReadOnly = True
        Me.cmb_transactions2.Size = New System.Drawing.Size(211, 26)
        Me.cmb_transactions2.TabIndex = 242
        Me.cmb_transactions2.Visible = False
        '
        'cmb_invoices2
        '
        Me.cmb_invoices2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmb_invoices2.Location = New System.Drawing.Point(503, 72)
        Me.cmb_invoices2.Name = "cmb_invoices2"
        Me.cmb_invoices2.ReadOnly = True
        Me.cmb_invoices2.Size = New System.Drawing.Size(123, 26)
        Me.cmb_invoices2.TabIndex = 242
        Me.cmb_invoices2.Visible = False
        '
        'txt_vatamt
        '
        Me.txt_vatamt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vatamt.Location = New System.Drawing.Point(503, 380)
        Me.txt_vatamt.Name = "txt_vatamt"
        Me.txt_vatamt.Size = New System.Drawing.Size(102, 27)
        Me.txt_vatamt.TabIndex = 236
        Me.txt_vatamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_vatamt.Visible = False
        '
        'txt_amtNetOfVat
        '
        Me.txt_amtNetOfVat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amtNetOfVat.Location = New System.Drawing.Point(609, 380)
        Me.txt_amtNetOfVat.Name = "txt_amtNetOfVat"
        Me.txt_amtNetOfVat.Size = New System.Drawing.Size(94, 27)
        Me.txt_amtNetOfVat.TabIndex = 236
        Me.txt_amtNetOfVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_amtNetOfVat.Visible = False
        '
        'txt_discnt2
        '
        Me.txt_discnt2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_discnt2.Location = New System.Drawing.Point(706, 380)
        Me.txt_discnt2.Name = "txt_discnt2"
        Me.txt_discnt2.Size = New System.Drawing.Size(94, 27)
        Me.txt_discnt2.TabIndex = 236
        Me.txt_discnt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_discnt2.Visible = False
        '
        'txt_discnt
        '
        Me.txt_discnt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_discnt.Location = New System.Drawing.Point(254, 378)
        Me.txt_discnt.Name = "txt_discnt"
        Me.txt_discnt.Size = New System.Drawing.Size(168, 27)
        Me.txt_discnt.TabIndex = 9
        Me.txt_discnt.Text = "0.00"
        Me.txt_discnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(122, 380)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 23)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "DISCOUNT"
        '
        'txt_netgross2
        '
        Me.txt_netgross2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_netgross2.Location = New System.Drawing.Point(503, 408)
        Me.txt_netgross2.Name = "txt_netgross2"
        Me.txt_netgross2.Size = New System.Drawing.Size(102, 27)
        Me.txt_netgross2.TabIndex = 236
        Me.txt_netgross2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_netgross2.Visible = False
        '
        'txt_numtoword
        '
        Me.txt_numtoword.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numtoword.Location = New System.Drawing.Point(621, 339)
        Me.txt_numtoword.Name = "txt_numtoword"
        Me.txt_numtoword.Size = New System.Drawing.Size(179, 37)
        Me.txt_numtoword.TabIndex = 236
        Me.txt_numtoword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_numtoword.Visible = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'txt_BranchCodeCust
        '
        Me.txt_BranchCodeCust.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_BranchCodeCust.Location = New System.Drawing.Point(823, 113)
        Me.txt_BranchCodeCust.Name = "txt_BranchCodeCust"
        Me.txt_BranchCodeCust.ReadOnly = True
        Me.txt_BranchCodeCust.Size = New System.Drawing.Size(117, 26)
        Me.txt_BranchCodeCust.TabIndex = 243
        Me.txt_BranchCodeCust.Visible = False
        '
        'txt_LedsetCust
        '
        Me.txt_LedsetCust.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_LedsetCust.Location = New System.Drawing.Point(823, 177)
        Me.txt_LedsetCust.Name = "txt_LedsetCust"
        Me.txt_LedsetCust.ReadOnly = True
        Me.txt_LedsetCust.Size = New System.Drawing.Size(62, 26)
        Me.txt_LedsetCust.TabIndex = 245
        Me.txt_LedsetCust.Visible = False
        '
        'txt_AccountNumberCust
        '
        Me.txt_AccountNumberCust.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_AccountNumberCust.Location = New System.Drawing.Point(823, 145)
        Me.txt_AccountNumberCust.Name = "txt_AccountNumberCust"
        Me.txt_AccountNumberCust.ReadOnly = True
        Me.txt_AccountNumberCust.Size = New System.Drawing.Size(226, 26)
        Me.txt_AccountNumberCust.TabIndex = 246
        Me.txt_AccountNumberCust.Visible = False
        '
        'txt_TransID
        '
        Me.txt_TransID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TransID.Location = New System.Drawing.Point(720, 74)
        Me.txt_TransID.Name = "txt_TransID"
        Me.txt_TransID.ReadOnly = True
        Me.txt_TransID.Size = New System.Drawing.Size(80, 27)
        Me.txt_TransID.TabIndex = 247
        Me.txt_TransID.Text = "TransId"
        Me.txt_TransID.Visible = False
        '
        'txt_TargetFrm
        '
        Me.txt_TargetFrm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TargetFrm.Location = New System.Drawing.Point(644, 107)
        Me.txt_TargetFrm.Name = "txt_TargetFrm"
        Me.txt_TargetFrm.ReadOnly = True
        Me.txt_TargetFrm.Size = New System.Drawing.Size(156, 27)
        Me.txt_TargetFrm.TabIndex = 248
        Me.txt_TargetFrm.Text = "TransId"
        Me.txt_TargetFrm.Visible = False
        '
        'txt_FrmText
        '
        Me.txt_FrmText.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FrmText.Location = New System.Drawing.Point(644, 140)
        Me.txt_FrmText.Name = "txt_FrmText"
        Me.txt_FrmText.ReadOnly = True
        Me.txt_FrmText.Size = New System.Drawing.Size(156, 27)
        Me.txt_FrmText.TabIndex = 249
        Me.txt_FrmText.Text = "txt_FrmText"
        Me.txt_FrmText.Visible = False
        '
        'txt_ErrNo
        '
        Me.txt_ErrNo.EditValue = "1"
        Me.txt_ErrNo.Location = New System.Drawing.Point(839, 293)
        Me.txt_ErrNo.Name = "txt_ErrNo"
        Me.txt_ErrNo.Size = New System.Drawing.Size(100, 20)
        Me.txt_ErrNo.TabIndex = 250
        Me.txt_ErrNo.Visible = False
        '
        'IS_Cashiering_Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(822, 444)
        Me.Controls.Add(Me.txt_ErrNo)
        Me.Controls.Add(Me.txt_FrmText)
        Me.Controls.Add(Me.txt_TargetFrm)
        Me.Controls.Add(Me.txt_TransID)
        Me.Controls.Add(Me.txt_AccountNumberCust)
        Me.Controls.Add(Me.txt_LedsetCust)
        Me.Controls.Add(Me.txt_BranchCodeCust)
        Me.Controls.Add(Me.cmb_invoices2)
        Me.Controls.Add(Me.cmb_transactions2)
        Me.Controls.Add(Me.postingDate2)
        Me.Controls.Add(Me.txt_refno2)
        Me.Controls.Add(Me.txt_acctcodeMne2)
        Me.Controls.Add(Me.txt_address2)
        Me.Controls.Add(Me.txt_cifkey2)
        Me.Controls.Add(Me.txt_discnt2)
        Me.Controls.Add(Me.txt_amtNetOfVat)
        Me.Controls.Add(Me.txt_netgross2)
        Me.Controls.Add(Me.txt_vatamt)
        Me.Controls.Add(Me.txt_numtoword)
        Me.Controls.Add(Me.txt_amt2)
        Me.Controls.Add(Me.txt_description2)
        Me.Controls.Add(Me.txt_cust2)
        Me.Controls.Add(Me.vat)
        Me.Controls.Add(Me.nonvat)
        Me.Controls.Add(Me.postingDate)
        Me.Controls.Add(Me.txt_refno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_acctcodeMne)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_cifkey)
        Me.Controls.Add(Me.show_Account)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txt_discnt)
        Me.Controls.Add(Me.txt_amt)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.txt_cust)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_invoices)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_transactions)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Cashiering_Transactions"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CASHIERING"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.txt_ErrNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_transactions As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_invoices As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_cust As System.Windows.Forms.TextBox
    Friend WithEvents txt_description As System.Windows.Forms.TextBox
    Friend WithEvents txt_amt As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents newtool As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolpostpayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents infoTool As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents show_Account As System.Windows.Forms.Button
    Friend WithEvents txt_cifkey As System.Windows.Forms.TextBox
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents txt_acctcodeMne As System.Windows.Forms.TextBox
    Friend WithEvents txt_refno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents postingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nonvat As System.Windows.Forms.RadioButton
    Friend WithEvents vat As System.Windows.Forms.RadioButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents postingDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_refno2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_acctcodeMne2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_address2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_cifkey2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_amt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_description2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_cust2 As System.Windows.Forms.TextBox
    Friend WithEvents cmb_transactions2 As System.Windows.Forms.TextBox
    Friend WithEvents cmb_invoices2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_vatamt As System.Windows.Forms.TextBox
    Friend WithEvents txt_amtNetOfVat As System.Windows.Forms.TextBox
    Friend WithEvents txt_discnt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_discnt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_netgross2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_numtoword As System.Windows.Forms.TextBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents txt_BranchCodeCust As TextBox
    Friend WithEvents txt_LedsetCust As TextBox
    Friend WithEvents txt_AccountNumberCust As TextBox
    Friend WithEvents txt_TransID As TextBox
    Friend WithEvents txt_TargetFrm As TextBox
    Friend WithEvents txt_FrmText As TextBox
    Friend WithEvents txt_ErrNo As DevExpress.XtraEditors.TextEdit
End Class
