<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Inventory_Deduct_item_find
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Inventory_Deduct_item_find))
        Me.chasisno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LViewItems4Deduct = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.model = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.color = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EngineNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.keyno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.quickSearch = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_keynumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_descrip = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_model = New System.Windows.Forms.TextBox()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_ChassisNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_EngineNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_cancel = New System.Windows.Forms.Button()
        Me.cmb_save = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.txt_uniPrice = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'chasisno
        '
        Me.chasisno.Text = "CHASSIS  No"
        Me.chasisno.Width = 100
        '
        'LViewItems4Deduct
        '
        Me.LViewItems4Deduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LViewItems4Deduct.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.code, Me.model, Me.desc, Me.color, Me.brand, Me.chasisno, Me.EngineNo, Me.unitcost, Me.vat, Me.totalcost, Me.unitPrice, Me.keyno})
        Me.LViewItems4Deduct.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItems4Deduct.ForeColor = System.Drawing.Color.Black
        Me.LViewItems4Deduct.FullRowSelect = True
        Me.LViewItems4Deduct.GridLines = True
        Me.LViewItems4Deduct.HideSelection = False
        Me.LViewItems4Deduct.Location = New System.Drawing.Point(12, 125)
        Me.LViewItems4Deduct.Name = "LViewItems4Deduct"
        Me.LViewItems4Deduct.Size = New System.Drawing.Size(512, 290)
        Me.LViewItems4Deduct.TabIndex = 34
        Me.LViewItems4Deduct.UseCompatibleStateImageBehavior = False
        Me.LViewItems4Deduct.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.ID.text = "ID"
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
        'EngineNo
        '
        Me.EngineNo.Text = "ENGINE No"
        Me.EngineNo.Width = 91
        '
        'unitcost
        '
        Me.unitcost.Text = "UNIT COST"
        Me.unitcost.Width = 107
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
        'ComboBox2
        '
        Me.ComboBox2.ForeColor = System.Drawing.Color.Blue
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(157, 96)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox2.TabIndex = 32
        Me.ComboBox2.Text = "Select Maker"
        '
        'ComboBox1
        '
        Me.ComboBox1.ForeColor = System.Drawing.Color.Blue
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(10, 96)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(132, 21)
        Me.ComboBox1.TabIndex = 31
        Me.ComboBox1.Text = "Select Model"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(9, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Quicksearch"
        '
        'quickSearch
        '
        Me.quickSearch.Location = New System.Drawing.Point(88, 70)
        Me.quickSearch.Name = "quickSearch"
        Me.quickSearch.Size = New System.Drawing.Size(436, 20)
        Me.quickSearch.TabIndex = 29
        '
        'ComboBox3
        '
        Me.ComboBox3.ForeColor = System.Drawing.Color.Blue
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(318, 97)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(206, 21)
        Me.ComboBox3.TabIndex = 33
        Me.ComboBox3.Text = "Select Brand"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_keynumber)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_descrip)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_code)
        Me.GroupBox1.Controls.Add(Me.txt_model)
        Me.GroupBox1.Controls.Add(Me.txt_color)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txt_brand)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txt_ChassisNo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_EngineNo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(530, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 177)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETAILS"
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
        'txt_keynumber
        '
        Me.txt_keynumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_keynumber.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_keynumber.Location = New System.Drawing.Point(117, 109)
        Me.txt_keynumber.Name = "txt_keynumber"
        Me.txt_keynumber.Size = New System.Drawing.Size(339, 21)
        Me.txt_keynumber.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "KEY No"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "DESCRIPTION"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_descrip
        '
        Me.txt_descrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_descrip.Enabled = False
        Me.txt_descrip.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descrip.Location = New System.Drawing.Point(115, 77)
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Size = New System.Drawing.Size(341, 21)
        Me.txt_descrip.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 19)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "CODE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_code
        '
        Me.txt_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_code.Enabled = False
        Me.txt_code.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.Location = New System.Drawing.Point(117, 18)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(339, 21)
        Me.txt_code.TabIndex = 37
        '
        'txt_model
        '
        Me.txt_model.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_model.Enabled = False
        Me.txt_model.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Button6.Location = New System.Drawing.Point(290, 137)
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
        Me.Button2.Location = New System.Drawing.Point(315, 50)
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
        Me.txt_brand.Location = New System.Drawing.Point(340, 48)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(116, 21)
        Me.txt_brand.TabIndex = 28
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(266, 55)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 19)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "BRAND"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_ChassisNo
        '
        Me.txt_ChassisNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ChassisNo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ChassisNo.Location = New System.Drawing.Point(320, 139)
        Me.txt_ChassisNo.Name = "txt_ChassisNo"
        Me.txt_ChassisNo.Size = New System.Drawing.Size(136, 21)
        Me.txt_ChassisNo.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(232, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 30)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "CHASSIS No"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_EngineNo
        '
        Me.txt_EngineNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_EngineNo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EngineNo.Location = New System.Drawing.Point(85, 140)
        Me.txt_EngineNo.Name = "txt_EngineNo"
        Me.txt_EngineNo.Size = New System.Drawing.Size(146, 21)
        Me.txt_EngineNo.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 33)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "ENGINE No"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.cmb_cancel)
        Me.GroupBox2.Controls.Add(Me.cmb_save)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.txt_uniPrice)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(530, 279)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(462, 136)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRICES"
        '
        'cmb_cancel
        '
        Me.cmb_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmb_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmb_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmb_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_cancel.Image = CType(resources.GetObject("cmb_cancel.Image"), System.Drawing.Image)
        Me.cmb_cancel.Location = New System.Drawing.Point(246, 61)
        Me.cmb_cancel.Name = "cmb_cancel"
        Me.cmb_cancel.Size = New System.Drawing.Size(197, 43)
        Me.cmb_cancel.TabIndex = 6
        Me.cmb_cancel.Text = "&FINANCED"
        Me.cmb_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmb_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmb_cancel.UseVisualStyleBackColor = False
        '
        'cmb_save
        '
        Me.cmb_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmb_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_save.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmb_save.FlatAppearance.BorderSize = 0
        Me.cmb_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmb_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_save.ForeColor = System.Drawing.Color.Black
        Me.cmb_save.Image = CType(resources.GetObject("cmb_save.Image"), System.Drawing.Image)
        Me.cmb_save.Location = New System.Drawing.Point(59, 61)
        Me.cmb_save.Name = "cmb_save"
        Me.cmb_save.Size = New System.Drawing.Size(162, 43)
        Me.cmb_save.TabIndex = 5
        Me.cmb_save.Text = "   &COD"
        Me.cmb_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmb_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmb_save.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.AutoSize = True
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(59, 30)
        Me.Button10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(24, 23)
        Me.Button10.TabIndex = 38
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button10.UseVisualStyleBackColor = True
        '
        'txt_uniPrice
        '
        Me.txt_uniPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_uniPrice.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uniPrice.Location = New System.Drawing.Point(107, 33)
        Me.txt_uniPrice.Name = "txt_uniPrice"
        Me.txt_uniPrice.Size = New System.Drawing.Size(336, 20)
        Me.txt_uniPrice.TabIndex = 4
        Me.txt_uniPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(6, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 33)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "UNIT PRICE"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IS_Inventory_Deduct_item_find
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(994, 447)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LViewItems4Deduct)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.quickSearch)
        Me.Controls.Add(Me.ComboBox3)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Inventory_Deduct_item_find"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IS_Inventory_Deduct_item_find"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chasisno As System.Windows.Forms.ColumnHeader
    Friend WithEvents LViewItems4Deduct As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents code As System.Windows.Forms.ColumnHeader
    Friend WithEvents model As System.Windows.Forms.ColumnHeader
    Friend WithEvents desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents color As System.Windows.Forms.ColumnHeader
    Friend WithEvents brand As System.Windows.Forms.ColumnHeader
    Friend WithEvents EngineNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents vat As System.Windows.Forms.ColumnHeader
    Friend WithEvents totalcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents keyno As System.Windows.Forms.ColumnHeader
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents quickSearch As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_keynumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_descrip As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents txt_model As System.Windows.Forms.TextBox
    Friend WithEvents txt_color As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_brand As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_ChassisNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_EngineNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_cancel As System.Windows.Forms.Button
    Friend WithEvents cmb_save As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents txt_uniPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
