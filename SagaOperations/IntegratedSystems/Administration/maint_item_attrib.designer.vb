<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maint_item_attrib
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
        Me.LViewItemsBrand = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.itemgroup = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.maker = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.model = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.year = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.color = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.distributor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vendor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitprice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Save = New System.Windows.Forms.Button()
        Me.Dellete = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.newbtn = New System.Windows.Forms.Button()
        Me.date_txtbx = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Cost_txtbx = New System.Windows.Forms.TextBox()
        Me.price_txtbx = New System.Windows.Forms.TextBox()
        Me.color_cmb = New System.Windows.Forms.ComboBox()
        Me.category_cmb = New System.Windows.Forms.ComboBox()
        Me.distributor_cmb = New System.Windows.Forms.ComboBox()
        Me.vendor_cmb = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.model_cmb = New System.Windows.Forms.ComboBox()
        Me.maker_cmb = New System.Windows.Forms.ComboBox()
        Me.brand_cmb = New System.Windows.Forms.ComboBox()
        Me.Group_cmb = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Code_txtbx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.quantity_txtbx = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exportbtn = New System.Windows.Forms.Button()
        Me.LViewItems = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.descrip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LViewItemsBrand
        '
        Me.LViewItemsBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LViewItemsBrand.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.code, Me.description, Me.itemgroup, Me.brand, Me.maker, Me.model, Me.year, Me.color, Me.category, Me.distributor, Me.vendor, Me.unitcost, Me.unitprice, Me.quantity})
        Me.LViewItemsBrand.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LViewItemsBrand.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItemsBrand.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewItemsBrand.FullRowSelect = True
        Me.LViewItemsBrand.GridLines = True
        Me.LViewItemsBrand.HideSelection = False
        Me.LViewItemsBrand.Location = New System.Drawing.Point(3, 228)
        Me.LViewItemsBrand.Name = "LViewItemsBrand"
        Me.LViewItemsBrand.Size = New System.Drawing.Size(931, 316)
        Me.LViewItemsBrand.TabIndex = 29
        Me.LViewItemsBrand.UseCompatibleStateImageBehavior = False
        Me.LViewItemsBrand.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        '
        'code
        '
        Me.code.Text = "CODE"
        Me.code.Width = 120
        '
        'description
        '
        Me.description.Text = "DESCRIPTION"
        Me.description.Width = 160
        '
        'itemgroup
        '
        Me.itemgroup.Text = "ITEM GROUP"
        Me.itemgroup.Width = 100
        '
        'brand
        '
        Me.brand.Text = "BRAND"
        Me.brand.Width = 100
        '
        'maker
        '
        Me.maker.Text = "MAKER"
        Me.maker.Width = 100
        '
        'model
        '
        Me.model.Text = "MODEL"
        Me.model.Width = 100
        '
        'year
        '
        Me.year.Text = "YEAR"
        Me.year.Width = 100
        '
        'color
        '
        Me.color.Text = "COLOR"
        Me.color.Width = 100
        '
        'category
        '
        Me.category.Text = "CATEGORY"
        Me.category.Width = 100
        '
        'distributor
        '
        Me.distributor.Text = "DISTRIBUTOR"
        Me.distributor.Width = 100
        '
        'vendor
        '
        Me.vendor.Text = "VENDOR"
        Me.vendor.Width = 100
        '
        'unitcost
        '
        Me.unitcost.Text = "UNIT COST"
        Me.unitcost.Width = 100
        '
        'unitprice
        '
        Me.unitprice.Text = "UNIT PRICE"
        Me.unitprice.Width = 100
        '
        'quantity
        '
        Me.quantity.Text = "QUANTITY"
        Me.quantity.Width = 100
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DelleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(111, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DelleteToolStripMenuItem
        '
        Me.DelleteToolStripMenuItem.Name = "DelleteToolStripMenuItem"
        Me.DelleteToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.DelleteToolStripMenuItem.Text = "Dellete"
        '
        'Save
        '
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Save.Location = New System.Drawing.Point(11, 550)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(109, 29)
        Me.Save.TabIndex = 30
        Me.Save.Text = "&ADD"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Dellete
        '
        Me.Dellete.BackColor = System.Drawing.SystemColors.Control
        Me.Dellete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dellete.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Dellete.Location = New System.Drawing.Point(126, 550)
        Me.Dellete.Name = "Dellete"
        Me.Dellete.Size = New System.Drawing.Size(109, 29)
        Me.Dellete.TabIndex = 32
        Me.Dellete.Text = "&DELETE"
        Me.Dellete.UseVisualStyleBackColor = False
        '
        'CloseBtn
        '
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CloseBtn.Location = New System.Drawing.Point(356, 550)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(109, 29)
        Me.CloseBtn.TabIndex = 33
        Me.CloseBtn.Text = "&CLOSE"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(315, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Color:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(331, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Category:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'newbtn
        '
        Me.newbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newbtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.newbtn.Location = New System.Drawing.Point(241, 550)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(109, 29)
        Me.newbtn.TabIndex = 82
        Me.newbtn.Text = "&NEW"
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'date_txtbx
        '
        Me.date_txtbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_txtbx.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_txtbx.Location = New System.Drawing.Point(412, 53)
        Me.date_txtbx.Name = "date_txtbx"
        Me.date_txtbx.Size = New System.Drawing.Size(178, 22)
        Me.date_txtbx.TabIndex = 83
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label9.Location = New System.Drawing.Point(318, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 20)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Year:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label10.Location = New System.Drawing.Point(321, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 20)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Distributor:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label11.Location = New System.Drawing.Point(337, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 20)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Vendor:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label12.Location = New System.Drawing.Point(647, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 20)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Unit Cost:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label13.Location = New System.Drawing.Point(647, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 20)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "Unit Price:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label14.Location = New System.Drawing.Point(650, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 20)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "Quantity:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Cost_txtbx
        '
        Me.Cost_txtbx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cost_txtbx.Location = New System.Drawing.Point(737, 54)
        Me.Cost_txtbx.Name = "Cost_txtbx"
        Me.Cost_txtbx.Size = New System.Drawing.Size(178, 22)
        Me.Cost_txtbx.TabIndex = 101
        '
        'price_txtbx
        '
        Me.price_txtbx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price_txtbx.Location = New System.Drawing.Point(737, 86)
        Me.price_txtbx.Name = "price_txtbx"
        Me.price_txtbx.Size = New System.Drawing.Size(178, 22)
        Me.price_txtbx.TabIndex = 102
        '
        'color_cmb
        '
        Me.color_cmb.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.color_cmb.FormattingEnabled = True
        Me.color_cmb.Location = New System.Drawing.Point(412, 86)
        Me.color_cmb.Name = "color_cmb"
        Me.color_cmb.Size = New System.Drawing.Size(178, 23)
        Me.color_cmb.TabIndex = 108
        '
        'category_cmb
        '
        Me.category_cmb.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_cmb.FormattingEnabled = True
        Me.category_cmb.Location = New System.Drawing.Point(412, 119)
        Me.category_cmb.Name = "category_cmb"
        Me.category_cmb.Size = New System.Drawing.Size(178, 23)
        Me.category_cmb.TabIndex = 109
        '
        'distributor_cmb
        '
        Me.distributor_cmb.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distributor_cmb.FormattingEnabled = True
        Me.distributor_cmb.Location = New System.Drawing.Point(412, 154)
        Me.distributor_cmb.Name = "distributor_cmb"
        Me.distributor_cmb.Size = New System.Drawing.Size(178, 23)
        Me.distributor_cmb.TabIndex = 110
        '
        'vendor_cmb
        '
        Me.vendor_cmb.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vendor_cmb.FormattingEnabled = True
        Me.vendor_cmb.Location = New System.Drawing.Point(412, 186)
        Me.vendor_cmb.Name = "vendor_cmb"
        Me.vendor_cmb.Size = New System.Drawing.Size(178, 23)
        Me.vendor_cmb.TabIndex = 111
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(931, 188)
        Me.PictureBox1.TabIndex = 112
        Me.PictureBox1.TabStop = False
        '
        'model_cmb
        '
        Me.model_cmb.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.model_cmb.FormattingEnabled = True
        Me.model_cmb.Location = New System.Drawing.Point(99, 182)
        Me.model_cmb.Name = "model_cmb"
        Me.model_cmb.Size = New System.Drawing.Size(178, 23)
        Me.model_cmb.TabIndex = 122
        '
        'maker_cmb
        '
        Me.maker_cmb.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maker_cmb.FormattingEnabled = True
        Me.maker_cmb.Location = New System.Drawing.Point(99, 149)
        Me.maker_cmb.Name = "maker_cmb"
        Me.maker_cmb.Size = New System.Drawing.Size(178, 23)
        Me.maker_cmb.TabIndex = 121
        '
        'brand_cmb
        '
        Me.brand_cmb.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brand_cmb.FormattingEnabled = True
        Me.brand_cmb.Location = New System.Drawing.Point(100, 116)
        Me.brand_cmb.Name = "brand_cmb"
        Me.brand_cmb.Size = New System.Drawing.Size(178, 23)
        Me.brand_cmb.TabIndex = 120
        '
        'Group_cmb
        '
        Me.Group_cmb.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_cmb.FormattingEnabled = True
        Me.Group_cmb.Location = New System.Drawing.Point(99, 83)
        Me.Group_cmb.Name = "Group_cmb"
        Me.Group_cmb.Size = New System.Drawing.Size(178, 23)
        Me.Group_cmb.TabIndex = 119
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label8.Location = New System.Drawing.Point(7, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 20)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "Model:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(8, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 20)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Maker:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(7, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 20)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Brand:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(3, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Item Group:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Code_txtbx
        '
        Me.Code_txtbx.Enabled = False
        Me.Code_txtbx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code_txtbx.Location = New System.Drawing.Point(100, 52)
        Me.Code_txtbx.Name = "Code_txtbx"
        Me.Code_txtbx.Size = New System.Drawing.Size(178, 22)
        Me.Code_txtbx.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(9, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Code:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'quantity_txtbx
        '
        Me.quantity_txtbx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity_txtbx.Location = New System.Drawing.Point(737, 119)
        Me.quantity_txtbx.Name = "quantity_txtbx"
        Me.quantity_txtbx.Size = New System.Drawing.Size(178, 22)
        Me.quantity_txtbx.TabIndex = 103
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(-3, -5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(971, 33)
        Me.PictureBox2.TabIndex = 123
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "New"
        '
        'exportbtn
        '
        Me.exportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exportbtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.exportbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.exportbtn.Location = New System.Drawing.Point(471, 550)
        Me.exportbtn.Name = "exportbtn"
        Me.exportbtn.Size = New System.Drawing.Size(109, 29)
        Me.exportbtn.TabIndex = 125
        Me.exportbtn.Text = "&EXPORT"
        Me.exportbtn.UseVisualStyleBackColor = True
        '
        'LViewItems
        '
        Me.LViewItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.descrip, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LViewItems.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LViewItems.ForeColor = System.Drawing.Color.Blue
        Me.LViewItems.FullRowSelect = True
        Me.LViewItems.GridLines = True
        Me.LViewItems.Location = New System.Drawing.Point(977, 87)
        Me.LViewItems.Name = "LViewItems"
        Me.LViewItems.Size = New System.Drawing.Size(721, 392)
        Me.LViewItems.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LViewItems.TabIndex = 126
        Me.LViewItems.UseCompatibleStateImageBehavior = False
        Me.LViewItems.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "MODEL"
        Me.ColumnHeader1.Width = 112
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "CODE"
        Me.ColumnHeader2.Width = 120
        '
        'descrip
        '
        Me.descrip.Text = "DESCRIPTION"
        Me.descrip.Width = 189
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "MAKER"
        Me.ColumnHeader3.Width = 102
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "BRAND"
        Me.ColumnHeader4.Width = 104
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "COLOR"
        Me.ColumnHeader5.Width = 100
        '
        'maint_item_attrib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(937, 585)
        Me.Controls.Add(Me.LViewItems)
        Me.Controls.Add(Me.exportbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.model_cmb)
        Me.Controls.Add(Me.maker_cmb)
        Me.Controls.Add(Me.brand_cmb)
        Me.Controls.Add(Me.Group_cmb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Code_txtbx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.vendor_cmb)
        Me.Controls.Add(Me.distributor_cmb)
        Me.Controls.Add(Me.category_cmb)
        Me.Controls.Add(Me.color_cmb)
        Me.Controls.Add(Me.quantity_txtbx)
        Me.Controls.Add(Me.price_txtbx)
        Me.Controls.Add(Me.Cost_txtbx)
        Me.Controls.Add(Me.date_txtbx)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.Dellete)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.LViewItemsBrand)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "maint_item_attrib"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Item Attrib"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LViewItemsBrand As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Private WithEvents code As System.Windows.Forms.ColumnHeader
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Dellete As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents description As System.Windows.Forms.ColumnHeader
    Friend WithEvents itemgroup As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents brand As System.Windows.Forms.ColumnHeader
    Friend WithEvents maker As System.Windows.Forms.ColumnHeader
    Friend WithEvents model As System.Windows.Forms.ColumnHeader
    Friend WithEvents newbtn As System.Windows.Forms.Button
    Friend WithEvents date_txtbx As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Cost_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents price_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents color_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents category_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents distributor_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents vendor_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents model_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents maker_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents brand_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Group_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Code_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents quantity_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents year As System.Windows.Forms.ColumnHeader
    Friend WithEvents color As System.Windows.Forms.ColumnHeader
    Friend WithEvents category As System.Windows.Forms.ColumnHeader
    Friend WithEvents distributor As System.Windows.Forms.ColumnHeader
    Friend WithEvents vendor As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitprice As System.Windows.Forms.ColumnHeader
    Friend WithEvents quantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents exportbtn As System.Windows.Forms.Button
    Friend WithEvents LViewItems As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents descrip As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class
