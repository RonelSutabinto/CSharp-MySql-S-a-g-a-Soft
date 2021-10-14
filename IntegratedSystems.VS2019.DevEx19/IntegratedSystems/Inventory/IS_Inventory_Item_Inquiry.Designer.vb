<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Inventory_Item_Inquiry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Inventory_Item_Inquiry))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_inventStatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.txt_uniPrice = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_keynumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_descrip = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.quickSearch = New System.Windows.Forms.TextBox()
        Me.LViewItemsOutgoing = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.transdate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.model = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.color = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chasisno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EngineNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.keyno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.inventoryStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_cnt = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_inventStatus)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_note)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.txt_uniPrice)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(627, 308)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 169)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OTHER"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(9, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 20)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "NOTE"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(92, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(237, 26)
        Me.TextBox2.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(9, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "STATUS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_inventStatus
        '
        Me.txt_inventStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_inventStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_inventStatus.Location = New System.Drawing.Point(91, 128)
        Me.txt_inventStatus.Name = "txt_inventStatus"
        Me.txt_inventStatus.Size = New System.Drawing.Size(238, 26)
        Me.txt_inventStatus.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(8, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "NOTE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_note
        '
        Me.txt_note.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_note.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_note.Location = New System.Drawing.Point(92, 58)
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(237, 26)
        Me.txt_note.TabIndex = 53
        '
        'Button10
        '
        Me.Button10.AutoSize = True
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(88, 26)
        Me.Button10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(24, 25)
        Me.Button10.TabIndex = 38
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button10.UseVisualStyleBackColor = True
        '
        'txt_uniPrice
        '
        Me.txt_uniPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_uniPrice.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uniPrice.ForeColor = System.Drawing.Color.Red
        Me.txt_uniPrice.Location = New System.Drawing.Point(124, 22)
        Me.txt_uniPrice.Name = "txt_uniPrice"
        Me.txt_uniPrice.Size = New System.Drawing.Size(205, 29)
        Me.txt_uniPrice.TabIndex = 4
        Me.txt_uniPrice.Text = "0.00"
        Me.txt_uniPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Teal
        Me.Label16.Location = New System.Drawing.Point(7, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 19)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "UNIT PRICE"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_keynumber)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_descrip)
        Me.GroupBox1.Controls.Add(Me.Label1)
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
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(627, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 277)
        Me.GroupBox1.TabIndex = 45
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
        Me.Button1.Location = New System.Drawing.Point(117, 164)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 25)
        Me.Button1.TabIndex = 43
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_keynumber
        '
        Me.txt_keynumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_keynumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_keynumber.Location = New System.Drawing.Point(147, 164)
        Me.txt_keynumber.Name = "txt_keynumber"
        Me.txt_keynumber.Size = New System.Drawing.Size(182, 26)
        Me.txt_keynumber.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(6, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "KEY NUMBER"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(9, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "DESCRIPTION"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_descrip
        '
        Me.txt_descrip.Enabled = False
        Me.txt_descrip.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descrip.Location = New System.Drawing.Point(115, 89)
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Size = New System.Drawing.Size(214, 26)
        Me.txt_descrip.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(10, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "CODE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_code
        '
        Me.txt_code.Enabled = False
        Me.txt_code.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.Location = New System.Drawing.Point(58, 17)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(134, 26)
        Me.txt_code.TabIndex = 37
        '
        'txt_model
        '
        Me.txt_model.Enabled = False
        Me.txt_model.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_model.Location = New System.Drawing.Point(10, 55)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(182, 26)
        Me.txt_model.TabIndex = 36
        '
        'txt_color
        '
        Me.txt_color.Enabled = False
        Me.txt_color.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_color.Location = New System.Drawing.Point(199, 55)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(130, 26)
        Me.txt_color.TabIndex = 35
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Enabled = False
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(117, 238)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 25)
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
        Me.Button5.Location = New System.Drawing.Point(117, 200)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 25)
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
        Me.Button2.Location = New System.Drawing.Point(75, 128)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 25)
        Me.Button2.TabIndex = 30
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_brand
        '
        Me.txt_brand.Enabled = False
        Me.txt_brand.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(117, 126)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(212, 26)
        Me.txt_brand.TabIndex = 28
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Teal
        Me.Label17.Location = New System.Drawing.Point(7, 130)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 20)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "BRAND"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_ChassisNo
        '
        Me.txt_ChassisNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ChassisNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ChassisNo.Location = New System.Drawing.Point(147, 238)
        Me.txt_ChassisNo.Name = "txt_ChassisNo"
        Me.txt_ChassisNo.Size = New System.Drawing.Size(182, 26)
        Me.txt_ChassisNo.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(6, 244)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 20)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "CHASSIS NO:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_EngineNo
        '
        Me.txt_EngineNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_EngineNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EngineNo.Location = New System.Drawing.Point(147, 200)
        Me.txt_EngineNo.Name = "txt_EngineNo"
        Me.txt_EngineNo.Size = New System.Drawing.Size(182, 26)
        Me.txt_EngineNo.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(6, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "ENGINE NO:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(1, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Quicksearch"
        '
        'quickSearch
        '
        Me.quickSearch.Location = New System.Drawing.Point(80, 23)
        Me.quickSearch.Name = "quickSearch"
        Me.quickSearch.Size = New System.Drawing.Size(541, 20)
        Me.quickSearch.TabIndex = 110
        '
        'LViewItemsOutgoing
        '
        Me.LViewItemsOutgoing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LViewItemsOutgoing.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.code, Me.brcode, Me.transdate, Me.model, Me.desc, Me.color, Me.brand, Me.chasisno, Me.EngineNo, Me.unitcost, Me.vat, Me.totalcost, Me.unitPrice, Me.keyno, Me.inventoryStatus})
        Me.LViewItemsOutgoing.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItemsOutgoing.ForeColor = System.Drawing.Color.Teal
        Me.LViewItemsOutgoing.FullRowSelect = True
        Me.LViewItemsOutgoing.GridLines = True
        Me.LViewItemsOutgoing.HideSelection = False
        Me.LViewItemsOutgoing.Location = New System.Drawing.Point(5, 52)
        Me.LViewItemsOutgoing.Name = "LViewItemsOutgoing"
        Me.LViewItemsOutgoing.Size = New System.Drawing.Size(616, 427)
        Me.LViewItemsOutgoing.TabIndex = 112
        Me.LViewItemsOutgoing.UseCompatibleStateImageBehavior = False
        Me.LViewItemsOutgoing.View = System.Windows.Forms.View.Details
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
        'brcode
        '
        Me.brcode.Text = "BRANCH"
        '
        'transdate
        '
        Me.transdate.Text = "DATE"
        '
        'model
        '
        Me.model.Text = "MODEL"
        Me.model.Width = 90
        '
        'desc
        '
        Me.desc.Text = "DESCRIPTION"
        Me.desc.Width = 149
        '
        'color
        '
        Me.color.Text = "COLOR"
        Me.color.Width = 88
        '
        'brand
        '
        Me.brand.Text = "BRAND"
        Me.brand.Width = 95
        '
        'chasisno
        '
        Me.chasisno.Text = "CHASSIS  No"
        Me.chasisno.Width = 105
        '
        'EngineNo
        '
        Me.EngineNo.Text = "ENGINE No"
        Me.EngineNo.Width = 105
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
        'inventoryStatus
        '
        Me.inventoryStatus.Text = "InventoryStatus"
        '
        'lbl_cnt
        '
        Me.lbl_cnt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cnt.ForeColor = System.Drawing.Color.White
        Me.lbl_cnt.Location = New System.Drawing.Point(77, 482)
        Me.lbl_cnt.Name = "lbl_cnt"
        Me.lbl_cnt.Size = New System.Drawing.Size(61, 25)
        Me.lbl_cnt.TabIndex = 113
        Me.lbl_cnt.Text = "0"
        Me.lbl_cnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 482)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 25)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "COUNT"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IS_Inventory_Item_Inquiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(983, 508)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_cnt)
        Me.Controls.Add(Me.LViewItemsOutgoing)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.quickSearch)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Inventory_Item_Inquiry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INQUIRY - SOLD ITEM"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents txt_uniPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_keynumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_descrip As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_inventStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_note As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents quickSearch As System.Windows.Forms.TextBox
    Friend WithEvents LViewItemsOutgoing As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents code As System.Windows.Forms.ColumnHeader
    Friend WithEvents model As System.Windows.Forms.ColumnHeader
    Friend WithEvents desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents color As System.Windows.Forms.ColumnHeader
    Friend WithEvents brand As System.Windows.Forms.ColumnHeader
    Friend WithEvents chasisno As System.Windows.Forms.ColumnHeader
    Friend WithEvents EngineNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents vat As System.Windows.Forms.ColumnHeader
    Friend WithEvents totalcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents keyno As System.Windows.Forms.ColumnHeader
    Friend WithEvents inventoryStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents transdate As System.Windows.Forms.ColumnHeader
    Friend WithEvents brcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_cnt As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
