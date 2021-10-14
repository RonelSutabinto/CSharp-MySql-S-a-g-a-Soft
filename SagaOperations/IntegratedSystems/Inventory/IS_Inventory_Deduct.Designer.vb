<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Inventory_Deduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Inventory_Deduct))
        Me.lbl_vendorCode = New System.Windows.Forms.Label()
        Me.txt_whcode = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_warehouse = New System.Windows.Forms.ComboBox()
        Me.cmd_showInvent = New System.Windows.Forms.Button()
        Me.lbl_vendor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.receivedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_vendor = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmd_assump = New System.Windows.Forms.Button()
        Me.cmd_redeem = New System.Windows.Forms.Button()
        Me.cmb_financed = New System.Windows.Forms.Button()
        Me.cmb_cod = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.txt_uniPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.engineno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.keyno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.color = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_keynumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_descrip = New System.Windows.Forms.TextBox()
        Me.desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_model = New System.Windows.Forms.TextBox()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_chassisNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_engineNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LViewItems4Deduct = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chasisno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.model = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.quickSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_count = New System.Windows.Forms.Label()
        Me.cmd_LotSale = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_vendorCode
        '
        Me.lbl_vendorCode.BackColor = System.Drawing.Color.White
        Me.lbl_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_vendorCode.ForeColor = System.Drawing.Color.Black
        Me.lbl_vendorCode.Location = New System.Drawing.Point(386, 12)
        Me.lbl_vendorCode.Name = "lbl_vendorCode"
        Me.lbl_vendorCode.Size = New System.Drawing.Size(93, 22)
        Me.lbl_vendorCode.TabIndex = 139
        '
        'txt_whcode
        '
        Me.txt_whcode.Enabled = False
        Me.txt_whcode.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_whcode.Location = New System.Drawing.Point(242, 43)
        Me.txt_whcode.Name = "txt_whcode"
        Me.txt_whcode.Size = New System.Drawing.Size(75, 26)
        Me.txt_whcode.TabIndex = 126
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(56, 42)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(29, 27)
        Me.Button4.TabIndex = 125
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(7, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 35)
        Me.Label10.TabIndex = 124
        Me.Label10.Text = "WARE HOUSE"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_warehouse
        '
        Me.cmb_warehouse.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_warehouse.FormattingEnabled = True
        Me.cmb_warehouse.Location = New System.Drawing.Point(91, 41)
        Me.cmb_warehouse.Name = "cmb_warehouse"
        Me.cmb_warehouse.Size = New System.Drawing.Size(143, 28)
        Me.cmb_warehouse.TabIndex = 123
        '
        'cmd_showInvent
        '
        Me.cmd_showInvent.AutoSize = True
        Me.cmd_showInvent.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmd_showInvent.BackgroundImage = CType(resources.GetObject("cmd_showInvent.BackgroundImage"), System.Drawing.Image)
        Me.cmd_showInvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_showInvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_showInvent.Location = New System.Drawing.Point(482, 39)
        Me.cmd_showInvent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd_showInvent.Name = "cmd_showInvent"
        Me.cmd_showInvent.Size = New System.Drawing.Size(34, 32)
        Me.cmd_showInvent.TabIndex = 122
        Me.cmd_showInvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_showInvent.UseVisualStyleBackColor = False
        '
        'lbl_vendor
        '
        Me.lbl_vendor.BackColor = System.Drawing.Color.White
        Me.lbl_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_vendor.ForeColor = System.Drawing.Color.Black
        Me.lbl_vendor.Location = New System.Drawing.Point(91, 12)
        Me.lbl_vendor.Name = "lbl_vendor"
        Me.lbl_vendor.Size = New System.Drawing.Size(289, 22)
        Me.lbl_vendor.TabIndex = 109
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(317, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 22)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "DATE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(351, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 112
        Me.PictureBox1.TabStop = False
        '
        'receivedDate
        '
        Me.receivedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.receivedDate.Location = New System.Drawing.Point(385, 45)
        Me.receivedDate.Name = "receivedDate"
        Me.receivedDate.Size = New System.Drawing.Size(94, 21)
        Me.receivedDate.TabIndex = 111
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "BRANCH"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmd_vendor
        '
        Me.cmd_vendor.AutoSize = True
        Me.cmd_vendor.BackgroundImage = CType(resources.GetObject("cmd_vendor.BackgroundImage"), System.Drawing.Image)
        Me.cmd_vendor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_vendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_vendor.Location = New System.Drawing.Point(487, 9)
        Me.cmd_vendor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd_vendor.Name = "cmd_vendor"
        Me.cmd_vendor.Size = New System.Drawing.Size(29, 27)
        Me.cmd_vendor.TabIndex = 108
        Me.cmd_vendor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_vendor.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.cmd_LotSale)
        Me.GroupBox2.Controls.Add(Me.cmd_assump)
        Me.GroupBox2.Controls.Add(Me.cmd_redeem)
        Me.GroupBox2.Controls.Add(Me.cmb_financed)
        Me.GroupBox2.Controls.Add(Me.cmb_cod)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.txt_uniPrice)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(523, 255)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 136)
        Me.GroupBox2.TabIndex = 152
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRICES"
        '
        'cmd_assump
        '
        Me.cmd_assump.BackColor = System.Drawing.Color.Teal
        Me.cmd_assump.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_assump.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_assump.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmd_assump.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_assump.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmd_assump.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_assump.ForeColor = System.Drawing.Color.White
        Me.cmd_assump.Image = CType(resources.GetObject("cmd_assump.Image"), System.Drawing.Image)
        Me.cmd_assump.Location = New System.Drawing.Point(258, 79)
        Me.cmd_assump.Name = "cmd_assump"
        Me.cmd_assump.Size = New System.Drawing.Size(110, 43)
        Me.cmd_assump.TabIndex = 40
        Me.cmd_assump.Text = "&ASSUMPTION"
        Me.cmd_assump.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_assump.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_assump.UseVisualStyleBackColor = False
        '
        'cmd_redeem
        '
        Me.cmd_redeem.BackColor = System.Drawing.Color.Teal
        Me.cmd_redeem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_redeem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_redeem.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmd_redeem.FlatAppearance.BorderSize = 0
        Me.cmd_redeem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_redeem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmd_redeem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_redeem.ForeColor = System.Drawing.Color.White
        Me.cmd_redeem.Image = CType(resources.GetObject("cmd_redeem.Image"), System.Drawing.Image)
        Me.cmd_redeem.Location = New System.Drawing.Point(176, 79)
        Me.cmd_redeem.Name = "cmd_redeem"
        Me.cmd_redeem.Size = New System.Drawing.Size(89, 43)
        Me.cmd_redeem.TabIndex = 39
        Me.cmd_redeem.Text = "   &REDEEM"
        Me.cmd_redeem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_redeem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_redeem.UseVisualStyleBackColor = False
        '
        'cmb_financed
        '
        Me.cmb_financed.BackColor = System.Drawing.Color.Teal
        Me.cmb_financed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmb_financed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_financed.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmb_financed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_financed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmb_financed.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_financed.ForeColor = System.Drawing.Color.White
        Me.cmb_financed.Image = CType(resources.GetObject("cmb_financed.Image"), System.Drawing.Image)
        Me.cmb_financed.Location = New System.Drawing.Point(85, 79)
        Me.cmb_financed.Name = "cmb_financed"
        Me.cmb_financed.Size = New System.Drawing.Size(100, 43)
        Me.cmb_financed.TabIndex = 6
        Me.cmb_financed.Text = "&FINANCED"
        Me.cmb_financed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmb_financed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmb_financed.UseVisualStyleBackColor = False
        '
        'cmb_cod
        '
        Me.cmb_cod.BackColor = System.Drawing.Color.Teal
        Me.cmb_cod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmb_cod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_cod.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmb_cod.FlatAppearance.BorderSize = 0
        Me.cmb_cod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_cod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmb_cod.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_cod.ForeColor = System.Drawing.Color.White
        Me.cmb_cod.Image = CType(resources.GetObject("cmb_cod.Image"), System.Drawing.Image)
        Me.cmb_cod.Location = New System.Drawing.Point(5, 79)
        Me.cmb_cod.Name = "cmb_cod"
        Me.cmb_cod.Size = New System.Drawing.Size(86, 43)
        Me.cmb_cod.TabIndex = 5
        Me.cmb_cod.Text = "   &COD"
        Me.cmb_cod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmb_cod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmb_cod.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.AutoSize = True
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(73, 31)
        Me.Button10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(31, 31)
        Me.Button10.TabIndex = 38
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button10.UseVisualStyleBackColor = True
        '
        'txt_uniPrice
        '
        Me.txt_uniPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_uniPrice.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uniPrice.ForeColor = System.Drawing.Color.Red
        Me.txt_uniPrice.Location = New System.Drawing.Point(107, 33)
        Me.txt_uniPrice.Name = "txt_uniPrice"
        Me.txt_uniPrice.Size = New System.Drawing.Size(336, 29)
        Me.txt_uniPrice.TabIndex = 4
        Me.txt_uniPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 45)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "UNIT PRICE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'totalcost
        '
        Me.totalcost.Text = "TOTAL COST"
        Me.totalcost.Width = 95
        '
        'vat
        '
        Me.vat.Text = "VAT"
        Me.vat.Width = 71
        '
        'unitcost
        '
        Me.unitcost.Text = "UNIT COST"
        Me.unitcost.Width = 107
        '
        'engineno
        '
        Me.engineno.Text = "ENGINE No"
        Me.engineno.Width = 105
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
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(80, 109)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 43
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'brand
        '
        Me.brand.Text = "BRAND"
        Me.brand.Width = 95
        '
        'color
        '
        Me.color.Text = "COLOR"
        Me.color.Width = 92
        '
        'txt_keynumber
        '
        Me.txt_keynumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_keynumber.Enabled = False
        Me.txt_keynumber.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_keynumber.ForeColor = System.Drawing.Color.Red
        Me.txt_keynumber.Location = New System.Drawing.Point(117, 109)
        Me.txt_keynumber.Name = "txt_keynumber"
        Me.txt_keynumber.Size = New System.Drawing.Size(331, 21)
        Me.txt_keynumber.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(6, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "KEY No"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(8, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "DESCRIPTION"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_descrip
        '
        Me.txt_descrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_descrip.Enabled = False
        Me.txt_descrip.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descrip.ForeColor = System.Drawing.Color.Red
        Me.txt_descrip.Location = New System.Drawing.Point(115, 77)
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Size = New System.Drawing.Size(333, 21)
        Me.txt_descrip.TabIndex = 39
        '
        'desc
        '
        Me.desc.Text = "DESCRIPTION"
        Me.desc.Width = 149
        '
        'Label6
        '
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(10, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 19)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "CODE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_code
        '
        Me.txt_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_code.Enabled = False
        Me.txt_code.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.ForeColor = System.Drawing.Color.Red
        Me.txt_code.Location = New System.Drawing.Point(117, 18)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(142, 21)
        Me.txt_code.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_keynumber)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_descrip)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_code)
        Me.GroupBox1.Controls.Add(Me.txt_model)
        Me.GroupBox1.Controls.Add(Me.txt_color)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txt_brand)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txt_chassisNo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_engineNo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(523, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 177)
        Me.GroupBox1.TabIndex = 151
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETAILS"
        '
        'Label8
        '
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(266, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 19)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "ID"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_id
        '
        Me.txt_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id.Enabled = False
        Me.txt_id.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.ForeColor = System.Drawing.Color.Red
        Me.txt_id.Location = New System.Drawing.Point(315, 18)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(133, 21)
        Me.txt_id.TabIndex = 44
        '
        'txt_model
        '
        Me.txt_model.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_model.Enabled = False
        Me.txt_model.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_model.ForeColor = System.Drawing.Color.Red
        Me.txt_model.Location = New System.Drawing.Point(10, 48)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(131, 21)
        Me.txt_model.TabIndex = 36
        '
        'txt_color
        '
        Me.txt_color.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_color.Enabled = False
        Me.txt_color.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_color.ForeColor = System.Drawing.Color.Red
        Me.txt_color.Location = New System.Drawing.Point(148, 48)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(111, 21)
        Me.txt_color.TabIndex = 35
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Enabled = False
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(282, 137)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 23)
        Me.Button6.TabIndex = 34
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(59, 140)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 23)
        Me.Button5.TabIndex = 33
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(315, 48)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 23)
        Me.Button2.TabIndex = 30
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_brand
        '
        Me.txt_brand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_brand.Enabled = False
        Me.txt_brand.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.ForeColor = System.Drawing.Color.Red
        Me.txt_brand.Location = New System.Drawing.Point(340, 48)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(108, 21)
        Me.txt_brand.TabIndex = 28
        '
        'Label17
        '
        Me.Label17.Enabled = False
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Teal
        Me.Label17.Location = New System.Drawing.Point(266, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 19)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "BRAND"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_chassisNo
        '
        Me.txt_chassisNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_chassisNo.Enabled = False
        Me.txt_chassisNo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chassisNo.ForeColor = System.Drawing.Color.Red
        Me.txt_chassisNo.Location = New System.Drawing.Point(312, 139)
        Me.txt_chassisNo.Name = "txt_chassisNo"
        Me.txt_chassisNo.Size = New System.Drawing.Size(136, 21)
        Me.txt_chassisNo.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(224, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 30)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "CHASSIS No"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_engineNo
        '
        Me.txt_engineNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_engineNo.Enabled = False
        Me.txt_engineNo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_engineNo.ForeColor = System.Drawing.Color.Red
        Me.txt_engineNo.Location = New System.Drawing.Point(85, 140)
        Me.txt_engineNo.Name = "txt_engineNo"
        Me.txt_engineNo.Size = New System.Drawing.Size(138, 21)
        Me.txt_engineNo.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.Enabled = False
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(6, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 33)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "ENGINE No"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LViewItems4Deduct
        '
        Me.LViewItems4Deduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LViewItems4Deduct.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.code, Me.chasisno, Me.engineno, Me.model, Me.desc, Me.color, Me.brand, Me.unitcost, Me.vat, Me.totalcost, Me.unitPrice, Me.keyno})
        Me.LViewItems4Deduct.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItems4Deduct.ForeColor = System.Drawing.Color.Black
        Me.LViewItems4Deduct.FullRowSelect = True
        Me.LViewItems4Deduct.GridLines = True
        Me.LViewItems4Deduct.HideSelection = False
        Me.LViewItems4Deduct.Location = New System.Drawing.Point(5, 101)
        Me.LViewItems4Deduct.Name = "LViewItems4Deduct"
        Me.LViewItems4Deduct.Size = New System.Drawing.Size(512, 290)
        Me.LViewItems4Deduct.TabIndex = 150
        Me.LViewItems4Deduct.UseCompatibleStateImageBehavior = False
        Me.LViewItems4Deduct.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        '
        'code
        '
        Me.code.Text = "CODE"
        Me.code.Width = 77
        '
        'chasisno
        '
        Me.chasisno.Text = "CHASSIS  No"
        Me.chasisno.Width = 105
        '
        'model
        '
        Me.model.Text = "MODEL"
        Me.model.Width = 95
        '
        'Label14
        '
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(2, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 15)
        Me.Label14.TabIndex = 146
        Me.Label14.Text = "Quicksearch"
        '
        'quickSearch
        '
        Me.quickSearch.Location = New System.Drawing.Point(91, 75)
        Me.quickSearch.Name = "quickSearch"
        Me.quickSearch.Size = New System.Drawing.Size(426, 21)
        Me.quickSearch.TabIndex = 145
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(7, 394)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 20)
        Me.Label9.TabIndex = 153
        Me.Label9.Text = "COUNT"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_count
        '
        Me.lbl_count.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_count.ForeColor = System.Drawing.Color.White
        Me.lbl_count.Location = New System.Drawing.Point(62, 394)
        Me.lbl_count.Name = "lbl_count"
        Me.lbl_count.Size = New System.Drawing.Size(49, 20)
        Me.lbl_count.TabIndex = 154
        Me.lbl_count.Text = "0"
        Me.lbl_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmd_LotSale
        '
        Me.cmd_LotSale.BackColor = System.Drawing.Color.Teal
        Me.cmd_LotSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_LotSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_LotSale.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmd_LotSale.FlatAppearance.BorderSize = 0
        Me.cmd_LotSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_LotSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmd_LotSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_LotSale.ForeColor = System.Drawing.Color.White
        Me.cmd_LotSale.Image = CType(resources.GetObject("cmd_LotSale.Image"), System.Drawing.Image)
        Me.cmd_LotSale.Location = New System.Drawing.Point(362, 79)
        Me.cmd_LotSale.Name = "cmd_LotSale"
        Me.cmd_LotSale.Size = New System.Drawing.Size(86, 43)
        Me.cmd_LotSale.TabIndex = 41
        Me.cmd_LotSale.Text = "   &COD"
        Me.cmd_LotSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_LotSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_LotSale.UseVisualStyleBackColor = False
        '
        'IS_Inventory_Deduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(983, 423)
        Me.Controls.Add(Me.lbl_count)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LViewItems4Deduct)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.quickSearch)
        Me.Controls.Add(Me.lbl_vendorCode)
        Me.Controls.Add(Me.txt_whcode)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmb_warehouse)
        Me.Controls.Add(Me.cmd_showInvent)
        Me.Controls.Add(Me.lbl_vendor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.receivedDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmd_vendor)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Inventory_Deduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IS_Inventory_Deduct"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_vendorCode As System.Windows.Forms.Label
    Friend WithEvents txt_whcode As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_showInvent As System.Windows.Forms.Button
    Friend WithEvents lbl_vendor As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents receivedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_vendor As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_financed As System.Windows.Forms.Button
    Friend WithEvents cmb_cod As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents txt_uniPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents totalcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents vat As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents engineno As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents keyno As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents brand As System.Windows.Forms.ColumnHeader
    Friend WithEvents color As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_keynumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_descrip As System.Windows.Forms.TextBox
    Friend WithEvents desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_model As System.Windows.Forms.TextBox
    Friend WithEvents txt_color As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_brand As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_chassisNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_engineNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LViewItems4Deduct As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents code As System.Windows.Forms.ColumnHeader
    Friend WithEvents model As System.Windows.Forms.ColumnHeader
    Friend WithEvents chasisno As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents quickSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_count As System.Windows.Forms.Label
    Friend WithEvents cmd_assump As System.Windows.Forms.Button
    Friend WithEvents cmd_redeem As System.Windows.Forms.Button
    Friend WithEvents cmd_LotSale As System.Windows.Forms.Button
End Class
