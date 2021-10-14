<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Inventory_Receiving_SP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides sub Dispose(ByVal disposing As Boolean)
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
    private sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Inventory_Receiving_SP))
        Me.statuserror = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_path = New System.Windows.Forms.TextBox()
        Me.cmd_import = New System.Windows.Forms.Button()
        Me.txt_notes = New System.Windows.Forms.TextBox()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.eventform = New System.Windows.Forms.TextBox()
        Me.lbl_totUnitPrice = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_count = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_grandTotal = New System.Windows.Forms.Label()
        Me.label99 = New System.Windows.Forms.Label()
        Me.lbl_totVatAmt = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmd_showInvent = New System.Windows.Forms.Button()
        Me.lbl_tot_unit = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_approver = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_whcode = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LViewItems = New System.Windows.Forms.ListView()
        Me.partsno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PartsName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.categ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.srp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DiscountPct = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DiscAmt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PriceWVAT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PriceWOVAT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ModelCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.modelName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.note = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_invenStat = New System.Windows.Forms.TextBox()
        Me.txt_TransCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_pono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_refno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.receivedDate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_vendor = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_warehouse = New System.Windows.Forms.ComboBox()
        Me.cmd_vendor = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statuserror
        '
        Me.statuserror.Location = New System.Drawing.Point(531, 492)
        Me.statuserror.Name = "statuserror"
        Me.statuserror.Size = New System.Drawing.Size(189, 23)
        Me.statuserror.TabIndex = 135
        Me.statuserror.Text = "statuserror1"
        Me.statuserror.Visible = False
        '
        'Label15
        '
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(601, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 23)
        Me.Label15.TabIndex = 134
        Me.Label15.Text = "PATH"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_path
        '
        Me.txt_path.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_path.Location = New System.Drawing.Point(678, 150)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(162, 23)
        Me.txt_path.TabIndex = 133
        '
        'cmd_import
        '
        Me.cmd_import.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmd_import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_import.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_import.Image = CType(resources.GetObject("cmd_import.Image"), System.Drawing.Image)
        Me.cmd_import.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_import.Location = New System.Drawing.Point(846, 148)
        Me.cmd_import.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd_import.Name = "cmd_import"
        Me.cmd_import.Size = New System.Drawing.Size(145, 28)
        Me.cmd_import.TabIndex = 132
        Me.cmd_import.Text = "Import"
        Me.cmd_import.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_import.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.cmd_import, "IMPORT")
        Me.cmd_import.UseVisualStyleBackColor = False
        '
        'txt_notes
        '
        Me.txt_notes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_notes.Location = New System.Drawing.Point(120, 117)
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.Size = New System.Drawing.Size(468, 23)
        Me.txt_notes.TabIndex = 130
        '
        'txt_remarks
        '
        Me.txt_remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_remarks.Location = New System.Drawing.Point(119, 148)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(468, 23)
        Me.txt_remarks.TabIndex = 128
        '
        'cmd_save
        '
        Me.cmd_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmd_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_save.ForeColor = System.Drawing.Color.White
        Me.cmd_save.Image = CType(resources.GetObject("cmd_save.Image"), System.Drawing.Image)
        Me.cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_save.Location = New System.Drawing.Point(15, 460)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(106, 52)
        Me.cmd_save.TabIndex = 125
        Me.cmd_save.Text = "  &SEND"
        Me.cmd_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.cmd_save, "Send form ForApproval!")
        Me.cmd_save.UseVisualStyleBackColor = True
        '
        'eventform
        '
        Me.eventform.Location = New System.Drawing.Point(531, 460)
        Me.eventform.Name = "eventform"
        Me.eventform.Size = New System.Drawing.Size(189, 23)
        Me.eventform.TabIndex = 124
        Me.eventform.Text = "eventform"
        Me.eventform.Visible = False
        '
        'lbl_totUnitPrice
        '
        Me.lbl_totUnitPrice.ForeColor = System.Drawing.Color.White
        Me.lbl_totUnitPrice.Location = New System.Drawing.Point(860, 505)
        Me.lbl_totUnitPrice.Name = "lbl_totUnitPrice"
        Me.lbl_totUnitPrice.Size = New System.Drawing.Size(119, 23)
        Me.lbl_totUnitPrice.TabIndex = 123
        Me.lbl_totUnitPrice.Text = "000.00"
        Me.lbl_totUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(731, 505)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 23)
        Me.Label13.TabIndex = 122
        Me.Label13.Text = "TOTAL UNIT PRICE"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_count
        '
        Me.lbl_count.ForeColor = System.Drawing.Color.White
        Me.lbl_count.Location = New System.Drawing.Point(516, 422)
        Me.lbl_count.Name = "lbl_count"
        Me.lbl_count.Size = New System.Drawing.Size(119, 23)
        Me.lbl_count.TabIndex = 121
        Me.lbl_count.Text = "0"
        Me.lbl_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(423, 422)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 23)
        Me.Label16.TabIndex = 120
        Me.Label16.Text = "ITEM COUNT"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_grandTotal
        '
        Me.lbl_grandTotal.ForeColor = System.Drawing.Color.White
        Me.lbl_grandTotal.Location = New System.Drawing.Point(860, 462)
        Me.lbl_grandTotal.Name = "lbl_grandTotal"
        Me.lbl_grandTotal.Size = New System.Drawing.Size(119, 23)
        Me.lbl_grandTotal.TabIndex = 119
        Me.lbl_grandTotal.Text = "000.00"
        Me.lbl_grandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label99
        '
        Me.label99.ForeColor = System.Drawing.Color.White
        Me.label99.Location = New System.Drawing.Point(731, 460)
        Me.label99.Name = "label99"
        Me.label99.Size = New System.Drawing.Size(133, 23)
        Me.label99.TabIndex = 118
        Me.label99.Text = "GRAND TOTAL"
        Me.label99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_totVatAmt
        '
        Me.lbl_totVatAmt.ForeColor = System.Drawing.Color.White
        Me.lbl_totVatAmt.Location = New System.Drawing.Point(860, 442)
        Me.lbl_totVatAmt.Name = "lbl_totVatAmt"
        Me.lbl_totVatAmt.Size = New System.Drawing.Size(119, 23)
        Me.lbl_totVatAmt.TabIndex = 117
        Me.lbl_totVatAmt.Text = "000.00"
        Me.lbl_totVatAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(731, 442)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 23)
        Me.Label12.TabIndex = 116
        Me.Label12.Text = "TOTAL VAT AMT"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Integrated Core Systems"
        '
        'cmd_showInvent
        '
        Me.cmd_showInvent.AutoSize = True
        Me.cmd_showInvent.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmd_showInvent.BackgroundImage = CType(resources.GetObject("cmd_showInvent.BackgroundImage"), System.Drawing.Image)
        Me.cmd_showInvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_showInvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_showInvent.Location = New System.Drawing.Point(844, 18)
        Me.cmd_showInvent.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd_showInvent.Name = "cmd_showInvent"
        Me.cmd_showInvent.Size = New System.Drawing.Size(147, 125)
        Me.cmd_showInvent.TabIndex = 105
        Me.cmd_showInvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmd_showInvent, "FIND")
        Me.cmd_showInvent.UseVisualStyleBackColor = False
        '
        'lbl_tot_unit
        '
        Me.lbl_tot_unit.ForeColor = System.Drawing.Color.White
        Me.lbl_tot_unit.Location = New System.Drawing.Point(860, 424)
        Me.lbl_tot_unit.Name = "lbl_tot_unit"
        Me.lbl_tot_unit.Size = New System.Drawing.Size(119, 23)
        Me.lbl_tot_unit.TabIndex = 115
        Me.lbl_tot_unit.Text = "000.00"
        Me.lbl_tot_unit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(731, 422)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 23)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "TOTAL UNIT COST"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 420)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(247, 23)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "Double click item on the table to remove."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_approver
        '
        Me.txt_approver.Enabled = False
        Me.txt_approver.Location = New System.Drawing.Point(405, 51)
        Me.txt_approver.Name = "txt_approver"
        Me.txt_approver.Size = New System.Drawing.Size(182, 23)
        Me.txt_approver.TabIndex = 111
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(317, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 23)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "APPROVER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_whcode
        '
        Me.txt_whcode.Enabled = False
        Me.txt_whcode.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_whcode.Location = New System.Drawing.Point(678, 117)
        Me.txt_whcode.Name = "txt_whcode"
        Me.txt_whcode.Size = New System.Drawing.Size(162, 26)
        Me.txt_whcode.TabIndex = 109
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(639, 82)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(29, 27)
        Me.Button4.TabIndex = 108
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LViewItems
        '
        Me.LViewItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LViewItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.partsno, Me.PartsName, Me.categ, Me.srp, Me.DiscountPct, Me.DiscAmt, Me.PriceWVAT, Me.PriceWOVAT, Me.ModelCode, Me.modelName, Me.note})
        Me.LViewItems.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItems.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewItems.FullRowSelect = True
        Me.LViewItems.GridLines = True
        Me.LViewItems.HideSelection = False
        Me.LViewItems.Location = New System.Drawing.Point(7, 180)
        Me.LViewItems.Name = "LViewItems"
        Me.LViewItems.Size = New System.Drawing.Size(1137, 204)
        Me.LViewItems.TabIndex = 104
        Me.LViewItems.UseCompatibleStateImageBehavior = False
        Me.LViewItems.View = System.Windows.Forms.View.Details
        '
        'partsno
        '
        Me.partsno.Text = "PARTS #"
        Me.partsno.Width = 146
        '
        'PartsName
        '
        Me.PartsName.Text = "PARTS NAME"
        Me.PartsName.Width = 232
        '
        'categ
        '
        Me.categ.Text = "CATEGORY"
        Me.categ.Width = 116
        '
        'srp
        '
        Me.srp.Text = "SRP"
        Me.srp.Width = 115
        '
        'DiscountPct
        '
        Me.DiscountPct.Text = "DISCOUNT PCT"
        Me.DiscountPct.Width = 127
        '
        'DiscAmt
        '
        Me.DiscAmt.Text = "DISCOUNT AMT"
        Me.DiscAmt.Width = 132
        '
        'PriceWVAT
        '
        Me.PriceWVAT.Text = "PRICE WVAT"
        Me.PriceWVAT.Width = 121
        '
        'PriceWOVAT
        '
        Me.PriceWOVAT.Text = "PRICE WOVAT"
        Me.PriceWOVAT.Width = 118
        '
        'ModelCode
        '
        Me.ModelCode.Text = "MODELCODE"
        Me.ModelCode.Width = 128
        '
        'modelName
        '
        Me.modelName.Text = "MODEL NAME"
        Me.modelName.Width = 172
        '
        'note
        '
        Me.note.Text = "NOTE"
        Me.note.Width = 72
        '
        'txt_invenStat
        '
        Me.txt_invenStat.Enabled = False
        Me.txt_invenStat.Location = New System.Drawing.Point(120, 48)
        Me.txt_invenStat.Name = "txt_invenStat"
        Me.txt_invenStat.Size = New System.Drawing.Size(189, 23)
        Me.txt_invenStat.TabIndex = 103
        Me.txt_invenStat.Text = "For Approval"
        '
        'txt_TransCode
        '
        Me.txt_TransCode.Enabled = False
        Me.txt_TransCode.Location = New System.Drawing.Point(677, 18)
        Me.txt_TransCode.Name = "txt_TransCode"
        Me.txt_TransCode.Size = New System.Drawing.Size(163, 23)
        Me.txt_TransCode.TabIndex = 101
        Me.txt_TransCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(596, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 23)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "TRANS CODE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_pono
        '
        Me.txt_pono.Location = New System.Drawing.Point(406, 83)
        Me.txt_pono.Name = "txt_pono"
        Me.txt_pono.Size = New System.Drawing.Size(181, 23)
        Me.txt_pono.TabIndex = 99
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(317, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 23)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "P.O. No."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_refno
        '
        Me.txt_refno.Location = New System.Drawing.Point(120, 81)
        Me.txt_refno.Name = "txt_refno"
        Me.txt_refno.Size = New System.Drawing.Size(189, 23)
        Me.txt_refno.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(598, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 23)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "DATE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(638, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 94
        Me.PictureBox1.TabStop = False
        '
        'receivedDate
        '
        Me.receivedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.receivedDate.Location = New System.Drawing.Point(677, 50)
        Me.receivedDate.Name = "receivedDate"
        Me.receivedDate.Size = New System.Drawing.Size(163, 23)
        Me.receivedDate.TabIndex = 93
        '
        'lbl_vendor
        '
        Me.lbl_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_vendor.Location = New System.Drawing.Point(120, 20)
        Me.lbl_vendor.Name = "lbl_vendor"
        Me.lbl_vendor.Size = New System.Drawing.Size(430, 23)
        Me.lbl_vendor.TabIndex = 91
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(595, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 42)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "WARE HOUSE"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_warehouse
        '
        Me.cmb_warehouse.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_warehouse.FormattingEnabled = True
        Me.cmb_warehouse.Location = New System.Drawing.Point(677, 80)
        Me.cmb_warehouse.Name = "cmb_warehouse"
        Me.cmb_warehouse.Size = New System.Drawing.Size(163, 28)
        Me.cmb_warehouse.TabIndex = 106
        '
        'cmd_vendor
        '
        Me.cmd_vendor.AutoSize = True
        Me.cmd_vendor.BackgroundImage = CType(resources.GetObject("cmd_vendor.BackgroundImage"), System.Drawing.Image)
        Me.cmd_vendor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_vendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_vendor.Location = New System.Drawing.Point(556, 16)
        Me.cmd_vendor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd_vendor.Name = "cmd_vendor"
        Me.cmd_vendor.Size = New System.Drawing.Size(29, 27)
        Me.cmd_vendor.TabIndex = 90
        Me.cmd_vendor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_vendor.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(22, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 20)
        Me.Label14.TabIndex = 140
        Me.Label14.Text = "NOTE"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(21, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 20)
        Me.Label11.TabIndex = 139
        Me.Label11.Text = "REMARKS"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(21, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 20)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "STATUS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "REFERENCE No."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "VENDOR"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IS_Inventory_Receiving_SP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(994, 536)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.statuserror)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_path)
        Me.Controls.Add(Me.cmd_import)
        Me.Controls.Add(Me.txt_notes)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.cmd_save)
        Me.Controls.Add(Me.eventform)
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
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_approver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_whcode)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cmd_showInvent)
        Me.Controls.Add(Me.LViewItems)
        Me.Controls.Add(Me.txt_invenStat)
        Me.Controls.Add(Me.txt_TransCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_pono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_refno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.receivedDate)
        Me.Controls.Add(Me.lbl_vendor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmb_warehouse)
        Me.Controls.Add(Me.cmd_vendor)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Inventory_Receiving_SP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IS_Inventory_Receiving_SP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statuserror As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_path As System.Windows.Forms.TextBox
    Friend WithEvents cmd_import As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txt_notes As System.Windows.Forms.TextBox
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents cmd_save As System.Windows.Forms.Button
    Friend WithEvents eventform As System.Windows.Forms.TextBox
    Friend WithEvents lbl_totUnitPrice As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_count As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbl_grandTotal As System.Windows.Forms.Label
    Friend WithEvents label99 As System.Windows.Forms.Label
    Friend WithEvents lbl_totVatAmt As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmd_showInvent As System.Windows.Forms.Button
    Friend WithEvents lbl_tot_unit As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_approver As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_whcode As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LViewItems As System.Windows.Forms.ListView
    Friend WithEvents partsno As System.Windows.Forms.ColumnHeader
    Friend WithEvents PartsName As System.Windows.Forms.ColumnHeader
    Friend WithEvents categ As System.Windows.Forms.ColumnHeader
    Friend WithEvents DiscountPct As System.Windows.Forms.ColumnHeader
    Friend WithEvents srp As System.Windows.Forms.ColumnHeader
    Friend WithEvents DiscAmt As System.Windows.Forms.ColumnHeader
    Friend WithEvents PriceWVAT As System.Windows.Forms.ColumnHeader
    Friend WithEvents PriceWOVAT As System.Windows.Forms.ColumnHeader
    Friend WithEvents ModelCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents modelName As System.Windows.Forms.ColumnHeader
    Friend WithEvents note As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_invenStat As System.Windows.Forms.TextBox
    Friend WithEvents txt_TransCode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_pono As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_refno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents receivedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_vendor As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_vendor As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
