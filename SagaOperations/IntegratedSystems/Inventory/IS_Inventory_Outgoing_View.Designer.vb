<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Inventory_Outgoing_View
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Inventory_Outgoing_View))
        Me.txt_originatingBranch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_sender = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmd_print = New System.Windows.Forms.Button()
        Me.lbl_totUnitPrice = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_count = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_grandTotal = New System.Windows.Forms.Label()
        Me.label99 = New System.Windows.Forms.Label()
        Me.lbl_totVatAmt = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_tot_unit = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmd_approved = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_whcode = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmd_disapproved = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_warehouse = New System.Windows.Forms.ComboBox()
        Me.LViewItems = New System.Windows.Forms.ListView()
        Me.code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.model = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.color = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.engineno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chasisno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitCost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.keyno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.prevID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_invenStat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_TransCode = New System.Windows.Forms.TextBox()
        Me.txt_pono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_refno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.receivedDate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_vendor = New System.Windows.Forms.Label()
        Me.lbl_vendorCode = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_receiver = New DevExpress.XtraEditors.LookUpEdit()
        Me.lbl_approver = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_notes = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.txt_rptTitle = New System.Windows.Forms.Label()
        Me.grp_remarks = New System.Windows.Forms.GroupBox()
        Me.cmb_disapp = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_disappr_remarks = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_receiver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_remarks.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_originatingBranch
        '
        Me.txt_originatingBranch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_originatingBranch.Enabled = False
        Me.txt_originatingBranch.ForeColor = System.Drawing.Color.Teal
        Me.txt_originatingBranch.Location = New System.Drawing.Point(407, 60)
        Me.txt_originatingBranch.Name = "txt_originatingBranch"
        Me.txt_originatingBranch.Size = New System.Drawing.Size(216, 20)
        Me.txt_originatingBranch.TabIndex = 131
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(320, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 24)
        Me.Label11.TabIndex = 130
        Me.Label11.Text = "BRANCH:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_sender
        '
        Me.txt_sender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_sender.Enabled = False
        Me.txt_sender.ForeColor = System.Drawing.Color.Teal
        Me.txt_sender.Location = New System.Drawing.Point(122, 61)
        Me.txt_sender.Name = "txt_sender"
        Me.txt_sender.Size = New System.Drawing.Size(189, 20)
        Me.txt_sender.TabIndex = 129
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(9, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 24)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "SENDER:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmd_print
        '
        Me.cmd_print.AutoSize = True
        Me.cmd_print.BackgroundImage = CType(resources.GetObject("cmd_print.BackgroundImage"), System.Drawing.Image)
        Me.cmd_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_print.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmd_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_print.Location = New System.Drawing.Point(129, 437)
        Me.cmd_print.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(64, 52)
        Me.cmd_print.TabIndex = 127
        Me.cmd_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmd_print, "Print Transaction")
        Me.cmd_print.UseVisualStyleBackColor = True
        Me.cmd_print.Visible = False
        '
        'lbl_totUnitPrice
        '
        Me.lbl_totUnitPrice.ForeColor = System.Drawing.Color.White
        Me.lbl_totUnitPrice.Location = New System.Drawing.Point(851, 506)
        Me.lbl_totUnitPrice.Name = "lbl_totUnitPrice"
        Me.lbl_totUnitPrice.Size = New System.Drawing.Size(119, 24)
        Me.lbl_totUnitPrice.TabIndex = 126
        Me.lbl_totUnitPrice.Text = "000.00"
        Me.lbl_totUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(726, 507)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 24)
        Me.Label13.TabIndex = 125
        Me.Label13.Text = "TOTAL UNIT PRICE"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_count
        '
        Me.lbl_count.ForeColor = System.Drawing.Color.White
        Me.lbl_count.Location = New System.Drawing.Point(466, 431)
        Me.lbl_count.Name = "lbl_count"
        Me.lbl_count.Size = New System.Drawing.Size(119, 24)
        Me.lbl_count.TabIndex = 124
        Me.lbl_count.Text = "0"
        Me.lbl_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(373, 431)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 24)
        Me.Label16.TabIndex = 123
        Me.Label16.Text = "ITEM COUNT"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_grandTotal
        '
        Me.lbl_grandTotal.ForeColor = System.Drawing.Color.White
        Me.lbl_grandTotal.Location = New System.Drawing.Point(851, 471)
        Me.lbl_grandTotal.Name = "lbl_grandTotal"
        Me.lbl_grandTotal.Size = New System.Drawing.Size(119, 24)
        Me.lbl_grandTotal.TabIndex = 122
        Me.lbl_grandTotal.Text = "000.00"
        Me.lbl_grandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label99
        '
        Me.label99.ForeColor = System.Drawing.Color.White
        Me.label99.Location = New System.Drawing.Point(726, 473)
        Me.label99.Name = "label99"
        Me.label99.Size = New System.Drawing.Size(133, 24)
        Me.label99.TabIndex = 121
        Me.label99.Text = "GRAND TOTAL"
        Me.label99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_totVatAmt
        '
        Me.lbl_totVatAmt.ForeColor = System.Drawing.Color.White
        Me.lbl_totVatAmt.Location = New System.Drawing.Point(851, 451)
        Me.lbl_totVatAmt.Name = "lbl_totVatAmt"
        Me.lbl_totVatAmt.Size = New System.Drawing.Size(119, 24)
        Me.lbl_totVatAmt.TabIndex = 120
        Me.lbl_totVatAmt.Text = "000.00"
        Me.lbl_totVatAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(726, 452)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 24)
        Me.Label12.TabIndex = 119
        Me.Label12.Text = "TOTAL VAT AMT"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_tot_unit
        '
        Me.lbl_tot_unit.ForeColor = System.Drawing.Color.White
        Me.lbl_tot_unit.Location = New System.Drawing.Point(851, 431)
        Me.lbl_tot_unit.Name = "lbl_tot_unit"
        Me.lbl_tot_unit.Size = New System.Drawing.Size(119, 24)
        Me.lbl_tot_unit.TabIndex = 118
        Me.lbl_tot_unit.Text = "000.00"
        Me.lbl_tot_unit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(726, 431)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 24)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "TOTAL UNIT COST"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmd_approved
        '
        Me.cmd_approved.AutoSize = True
        Me.cmd_approved.BackgroundImage = CType(resources.GetObject("cmd_approved.BackgroundImage"), System.Drawing.Image)
        Me.cmd_approved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_approved.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmd_approved.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_approved.ForeColor = System.Drawing.Color.Teal
        Me.cmd_approved.Location = New System.Drawing.Point(3, 437)
        Me.cmd_approved.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd_approved.Name = "cmd_approved"
        Me.cmd_approved.Size = New System.Drawing.Size(64, 52)
        Me.cmd_approved.TabIndex = 116
        Me.cmd_approved.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmd_approved, "APPROVED TRANSACTION")
        Me.cmd_approved.UseVisualStyleBackColor = True
        Me.cmd_approved.Visible = False
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(319, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 24)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "RECIPIENT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_whcode
        '
        Me.txt_whcode.Enabled = False
        Me.txt_whcode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_whcode.ForeColor = System.Drawing.Color.Teal
        Me.txt_whcode.Location = New System.Drawing.Point(898, 76)
        Me.txt_whcode.Name = "txt_whcode"
        Me.txt_whcode.Size = New System.Drawing.Size(81, 22)
        Me.txt_whcode.TabIndex = 112
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(716, 76)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(29, 29)
        Me.Button4.TabIndex = 111
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Integrated Core System"
        '
        'cmd_disapproved
        '
        Me.cmd_disapproved.AutoSize = True
        Me.cmd_disapproved.BackgroundImage = CType(resources.GetObject("cmd_disapproved.BackgroundImage"), System.Drawing.Image)
        Me.cmd_disapproved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_disapproved.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmd_disapproved.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_disapproved.Location = New System.Drawing.Point(66, 437)
        Me.cmd_disapproved.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd_disapproved.Name = "cmd_disapproved"
        Me.cmd_disapproved.Size = New System.Drawing.Size(64, 52)
        Me.cmd_disapproved.TabIndex = 115
        Me.cmd_disapproved.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmd_disapproved, "DISAPPROVED TRANSACTION")
        Me.cmd_disapproved.UseVisualStyleBackColor = True
        Me.cmd_disapproved.Visible = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(632, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 36)
        Me.Label10.TabIndex = 110
        Me.Label10.Text = "WARE HOUSE"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_warehouse
        '
        Me.cmb_warehouse.Enabled = False
        Me.cmb_warehouse.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_warehouse.ForeColor = System.Drawing.Color.Teal
        Me.cmb_warehouse.FormattingEnabled = True
        Me.cmb_warehouse.Location = New System.Drawing.Point(751, 75)
        Me.cmb_warehouse.Name = "cmb_warehouse"
        Me.cmb_warehouse.Size = New System.Drawing.Size(139, 23)
        Me.cmb_warehouse.TabIndex = 109
        '
        'LViewItems
        '
        Me.LViewItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.code, Me.model, Me.desc, Me.color, Me.brand, Me.engineno, Me.chasisno, Me.unitCost, Me.vat, Me.totalcost, Me.unitPrice, Me.keyno, Me.prevID})
        Me.LViewItems.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItems.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewItems.FullRowSelect = True
        Me.LViewItems.GridLines = True
        Me.LViewItems.HideSelection = False
        Me.LViewItems.Location = New System.Drawing.Point(10, 166)
        Me.LViewItems.Name = "LViewItems"
        Me.LViewItems.Size = New System.Drawing.Size(969, 262)
        Me.LViewItems.TabIndex = 108
        Me.LViewItems.UseCompatibleStateImageBehavior = False
        Me.LViewItems.View = System.Windows.Forms.View.Details
        '
        'code
        '
        Me.code.Text = "CODE"
        Me.code.Width = 77
        '
        'model
        '
        Me.model.Text = "MODEL"
        Me.model.Width = 95
        '
        'desc
        '
        Me.desc.Text = "DESCRIPTION"
        Me.desc.Width = 149
        '
        'color
        '
        Me.color.Text = "COLOR"
        Me.color.Width = 92
        '
        'brand
        '
        Me.brand.Text = "BRAND"
        Me.brand.Width = 95
        '
        'engineno
        '
        Me.engineno.Text = "ENGINE No"
        Me.engineno.Width = 91
        '
        'chasisno
        '
        Me.chasisno.Text = "CHASSIS  No"
        Me.chasisno.Width = 100
        '
        'unitCost
        '
        Me.unitCost.Text = "UNIT COST"
        Me.unitCost.Width = 107
        '
        'vat
        '
        Me.vat.Text = "VAT"
        Me.vat.Width = 71
        '
        'totalcost
        '
        Me.totalcost.Text = "TOTAL COST"
        Me.totalcost.Width = 95
        '
        'unitPrice
        '
        Me.unitPrice.Text = "UNIT PRICE"
        Me.unitPrice.Width = 72
        '
        'keyno
        '
        Me.keyno.Text = "KEY No"
        '
        'prevID
        '
        Me.prevID.Text = "PrevID"
        '
        'txt_invenStat
        '
        Me.txt_invenStat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_invenStat.Enabled = False
        Me.txt_invenStat.ForeColor = System.Drawing.Color.Teal
        Me.txt_invenStat.Location = New System.Drawing.Point(122, 87)
        Me.txt_invenStat.Name = "txt_invenStat"
        Me.txt_invenStat.Size = New System.Drawing.Size(189, 20)
        Me.txt_invenStat.TabIndex = 107
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(9, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 24)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "STATUS:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_TransCode
        '
        Me.txt_TransCode.Enabled = False
        Me.txt_TransCode.ForeColor = System.Drawing.Color.Teal
        Me.txt_TransCode.Location = New System.Drawing.Point(751, 8)
        Me.txt_TransCode.Name = "txt_TransCode"
        Me.txt_TransCode.Size = New System.Drawing.Size(228, 20)
        Me.txt_TransCode.TabIndex = 105
        Me.txt_TransCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pono
        '
        Me.txt_pono.Enabled = False
        Me.txt_pono.ForeColor = System.Drawing.Color.Teal
        Me.txt_pono.Location = New System.Drawing.Point(408, 36)
        Me.txt_pono.Name = "txt_pono"
        Me.txt_pono.Size = New System.Drawing.Size(215, 20)
        Me.txt_pono.TabIndex = 103
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(630, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 24)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "TRANS CODE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(319, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 24)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "P.O. No.:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 24)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "REFERENCE No."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_refno
        '
        Me.txt_refno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_refno.Enabled = False
        Me.txt_refno.ForeColor = System.Drawing.Color.Teal
        Me.txt_refno.Location = New System.Drawing.Point(122, 36)
        Me.txt_refno.Name = "txt_refno"
        Me.txt_refno.Size = New System.Drawing.Size(189, 20)
        Me.txt_refno.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(631, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "DATE:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(717, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 98
        Me.PictureBox1.TabStop = False
        '
        'receivedDate
        '
        Me.receivedDate.Enabled = False
        Me.receivedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.receivedDate.Location = New System.Drawing.Point(751, 41)
        Me.receivedDate.Name = "receivedDate"
        Me.receivedDate.Size = New System.Drawing.Size(228, 20)
        Me.receivedDate.TabIndex = 97
        '
        'lbl_vendor
        '
        Me.lbl_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_vendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vendor.ForeColor = System.Drawing.Color.White
        Me.lbl_vendor.Location = New System.Drawing.Point(122, 9)
        Me.lbl_vendor.Name = "lbl_vendor"
        Me.lbl_vendor.Size = New System.Drawing.Size(359, 24)
        Me.lbl_vendor.TabIndex = 95
        Me.lbl_vendor.Text = "Mharjun Mharjun"
        Me.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_vendorCode
        '
        Me.lbl_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_vendorCode.ForeColor = System.Drawing.Color.White
        Me.lbl_vendorCode.Location = New System.Drawing.Point(510, 9)
        Me.lbl_vendorCode.Name = "lbl_vendorCode"
        Me.lbl_vendorCode.Size = New System.Drawing.Size(113, 24)
        Me.lbl_vendorCode.TabIndex = 132
        Me.lbl_vendorCode.Text = "lbl_vendorCode"
        Me.lbl_vendorCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(487, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 24)
        Me.Label14.TabIndex = 133
        Me.Label14.Text = " - "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_receiver
        '
        Me.txt_receiver.Location = New System.Drawing.Point(408, 83)
        Me.txt_receiver.Name = "txt_receiver"
        Me.txt_receiver.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_receiver.Properties.Appearance.ForeColor = System.Drawing.Color.Teal
        Me.txt_receiver.Properties.Appearance.Options.UseFont = True
        Me.txt_receiver.Properties.Appearance.Options.UseForeColor = True
        Me.txt_receiver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_receiver.Size = New System.Drawing.Size(215, 22)
        Me.txt_receiver.TabIndex = 134
        '
        'lbl_approver
        '
        Me.lbl_approver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_approver.ForeColor = System.Drawing.Color.White
        Me.lbl_approver.Location = New System.Drawing.Point(588, 485)
        Me.lbl_approver.Name = "lbl_approver"
        Me.lbl_approver.Size = New System.Drawing.Size(113, 24)
        Me.lbl_approver.TabIndex = 135
        Me.lbl_approver.Text = "Label15"
        Me.lbl_approver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_approver.Visible = False
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 33)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "RECEIVING BRANCH"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(11, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 20)
        Me.Label15.TabIndex = 140
        Me.Label15.Text = "NOTE"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_notes
        '
        Me.txt_notes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_notes.Enabled = False
        Me.txt_notes.ForeColor = System.Drawing.Color.Teal
        Me.txt_notes.Location = New System.Drawing.Point(122, 113)
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.Size = New System.Drawing.Size(857, 20)
        Me.txt_notes.TabIndex = 139
        '
        'Label17
        '
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(10, 139)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 20)
        Me.Label17.TabIndex = 138
        Me.Label17.Text = "REMARKS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_remarks
        '
        Me.txt_remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_remarks.Enabled = False
        Me.txt_remarks.ForeColor = System.Drawing.Color.Teal
        Me.txt_remarks.Location = New System.Drawing.Point(122, 140)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(857, 20)
        Me.txt_remarks.TabIndex = 137
        '
        'txt_rptTitle
        '
        Me.txt_rptTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_rptTitle.ForeColor = System.Drawing.Color.White
        Me.txt_rptTitle.Location = New System.Drawing.Point(322, 465)
        Me.txt_rptTitle.Name = "txt_rptTitle"
        Me.txt_rptTitle.Size = New System.Drawing.Size(232, 24)
        Me.txt_rptTitle.TabIndex = 141
        Me.txt_rptTitle.Text = "SAGA"
        Me.txt_rptTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.txt_rptTitle.Visible = False
        '
        'grp_remarks
        '
        Me.grp_remarks.Controls.Add(Me.cmb_disapp)
        Me.grp_remarks.Controls.Add(Me.Label18)
        Me.grp_remarks.Controls.Add(Me.txt_disappr_remarks)
        Me.grp_remarks.Location = New System.Drawing.Point(218, 217)
        Me.grp_remarks.Name = "grp_remarks"
        Me.grp_remarks.Size = New System.Drawing.Size(588, 100)
        Me.grp_remarks.TabIndex = 142
        Me.grp_remarks.TabStop = False
        Me.grp_remarks.Visible = False
        '
        'cmb_disapp
        '
        Me.cmb_disapp.AutoSize = True
        Me.cmb_disapp.BackColor = System.Drawing.Color.White
        Me.cmb_disapp.BackgroundImage = CType(resources.GetObject("cmb_disapp.BackgroundImage"), System.Drawing.Image)
        Me.cmb_disapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmb_disapp.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmb_disapp.Location = New System.Drawing.Point(516, 19)
        Me.cmb_disapp.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmb_disapp.Name = "cmb_disapp"
        Me.cmb_disapp.Size = New System.Drawing.Size(59, 60)
        Me.cmb_disapp.TabIndex = 82
        Me.cmb_disapp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmb_disapp.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(12, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 20)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "REMARKS"
        '
        'txt_disappr_remarks
        '
        Me.txt_disappr_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_disappr_remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_disappr_remarks.Location = New System.Drawing.Point(134, 19)
        Me.txt_disappr_remarks.Multiline = True
        Me.txt_disappr_remarks.Name = "txt_disappr_remarks"
        Me.txt_disappr_remarks.Size = New System.Drawing.Size(376, 60)
        Me.txt_disappr_remarks.TabIndex = 80
        '
        'IS_Inventory_Outgoing_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(984, 535)
        Me.Controls.Add(Me.grp_remarks)
        Me.Controls.Add(Me.txt_rptTitle)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_notes)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_approver)
        Me.Controls.Add(Me.txt_receiver)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbl_vendorCode)
        Me.Controls.Add(Me.txt_originatingBranch)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_sender)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmd_print)
        Me.Controls.Add(Me.lbl_totUnitPrice)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbl_count)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbl_grandTotal)
        Me.Controls.Add(Me.label99)
        Me.Controls.Add(Me.lbl_totVatAmt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_tot_unit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmd_approved)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_whcode)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cmd_disapproved)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmb_warehouse)
        Me.Controls.Add(Me.LViewItems)
        Me.Controls.Add(Me.txt_invenStat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_TransCode)
        Me.Controls.Add(Me.txt_pono)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_refno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.receivedDate)
        Me.Controls.Add(Me.lbl_vendor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Inventory_Outgoing_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IS_Inventory_Outgoing_View"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_receiver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_remarks.ResumeLayout(False)
        Me.grp_remarks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_originatingBranch As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_sender As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmd_print As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_totUnitPrice As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_count As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbl_grandTotal As System.Windows.Forms.Label
    Friend WithEvents label99 As System.Windows.Forms.Label
    Friend WithEvents lbl_totVatAmt As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_tot_unit As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmd_approved As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_whcode As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmd_disapproved As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents LViewItems As System.Windows.Forms.ListView
    Friend WithEvents code As System.Windows.Forms.ColumnHeader
    Friend WithEvents model As System.Windows.Forms.ColumnHeader
    Friend WithEvents desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents color As System.Windows.Forms.ColumnHeader
    Friend WithEvents brand As System.Windows.Forms.ColumnHeader
    Friend WithEvents chasisno As System.Windows.Forms.ColumnHeader
    Friend WithEvents engineno As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitCost As System.Windows.Forms.ColumnHeader
    Friend WithEvents vat As System.Windows.Forms.ColumnHeader
    Friend WithEvents totalcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_invenStat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_TransCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_pono As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_refno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents receivedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_vendor As System.Windows.Forms.Label
    Friend WithEvents lbl_vendorCode As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_receiver As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lbl_approver As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents keyno As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_notes As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents txt_rptTitle As System.Windows.Forms.Label
    Friend WithEvents grp_remarks As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_disapp As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_disappr_remarks As System.Windows.Forms.TextBox
    Friend WithEvents prevID As System.Windows.Forms.ColumnHeader
End Class
