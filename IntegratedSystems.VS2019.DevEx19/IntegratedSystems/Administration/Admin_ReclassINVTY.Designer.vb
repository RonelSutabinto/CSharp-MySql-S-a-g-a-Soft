<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_ReclassINVTY
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    private sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_ReclassINVTY))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolnew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolFindItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolUPDATE = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_brand = New System.Windows.Forms.ComboBox()
        Me.txt_color = New System.Windows.Forms.ComboBox()
        Me.txt_model = New System.Windows.Forms.ComboBox()
        Me.txt_descrip = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_keynumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_ChassisNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_EngineNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_PrevID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Remarks = New System.Windows.Forms.TextBox()
        Me.txt_CustName = New System.Windows.Forms.TextBox()
        Me.txt_whdesc = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_whcode = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_IfExist = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.receivedDate = New System.Windows.Forms.DateTimePicker()
        Me.txt_itemgroup = New System.Windows.Forms.TextBox()
        Me.txt_InventoryStatus = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_BranchCode = New System.Windows.Forms.TextBox()
        Me.txt_BranchName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolnew, Me.ToolStripSeparator1, Me.toolFindItem, Me.ToolStripSeparator3, Me.toolUPDATE})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(794, 33)
        Me.ToolStrip1.TabIndex = 110
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolnew
        '
        Me.toolnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolnew.Image = CType(resources.GetObject("toolnew.Image"), System.Drawing.Image)
        Me.toolnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolnew.Name = "toolnew"
        Me.toolnew.Size = New System.Drawing.Size(23, 30)
        Me.toolnew.Text = "new"
        Me.toolnew.ToolTipText = "NEW Application"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'toolFindItem
        '
        Me.toolFindItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolFindItem.Image = CType(resources.GetObject("toolFindItem.Image"), System.Drawing.Image)
        Me.toolFindItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolFindItem.Name = "toolFindItem"
        Me.toolFindItem.Size = New System.Drawing.Size(23, 30)
        Me.toolFindItem.Text = "FIND"
        Me.toolFindItem.ToolTipText = "FIND ITEM"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 33)
        '
        'toolUPDATE
        '
        Me.toolUPDATE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolUPDATE.Image = CType(resources.GetObject("toolUPDATE.Image"), System.Drawing.Image)
        Me.toolUPDATE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolUPDATE.Name = "toolUPDATE"
        Me.toolUPDATE.Size = New System.Drawing.Size(23, 30)
        Me.toolUPDATE.Text = "ToolStripButton2"
        Me.toolUPDATE.ToolTipText = "UPDATE"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txt_brand)
        Me.GroupBox1.Controls.Add(Me.txt_color)
        Me.GroupBox1.Controls.Add(Me.txt_model)
        Me.GroupBox1.Controls.Add(Me.txt_descrip)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_keynumber)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.txt_code)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txt_ChassisNo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_EngineNo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(4, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 197)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETAILS"
        '
        'txt_brand
        '
        Me.txt_brand.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.ForeColor = System.Drawing.Color.Red
        Me.txt_brand.FormattingEnabled = True
        Me.txt_brand.Location = New System.Drawing.Point(104, 44)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(138, 26)
        Me.txt_brand.TabIndex = 122
        '
        'txt_color
        '
        Me.txt_color.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_color.ForeColor = System.Drawing.Color.Red
        Me.txt_color.FormattingEnabled = True
        Me.txt_color.Location = New System.Drawing.Point(248, 44)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(186, 26)
        Me.txt_color.TabIndex = 121
        '
        'txt_model
        '
        Me.txt_model.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_model.ForeColor = System.Drawing.Color.Red
        Me.txt_model.FormattingEnabled = True
        Me.txt_model.Location = New System.Drawing.Point(104, 15)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(220, 26)
        Me.txt_model.TabIndex = 120
        '
        'txt_descrip
        '
        Me.txt_descrip.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descrip.Location = New System.Drawing.Point(104, 74)
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.ReadOnly = True
        Me.txt_descrip.Size = New System.Drawing.Size(330, 26)
        Me.txt_descrip.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(5, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 19)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "MODEL/CODE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(105, 104)
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
        Me.txt_keynumber.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_keynumber.Location = New System.Drawing.Point(135, 103)
        Me.txt_keynumber.Name = "txt_keynumber"
        Me.txt_keynumber.Size = New System.Drawing.Size(299, 26)
        Me.txt_keynumber.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(5, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 19)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "KEY NUMBER"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(5, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 19)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "DESCRIPTION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Enabled = False
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(104, 161)
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
        Me.Button5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(104, 132)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 23)
        Me.Button5.TabIndex = 33
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txt_code
        '
        Me.txt_code.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.Location = New System.Drawing.Point(330, 15)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(104, 26)
        Me.txt_code.TabIndex = 37
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Teal
        Me.Label17.Location = New System.Drawing.Point(5, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 19)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "BRAND/COLOR"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_ChassisNo
        '
        Me.txt_ChassisNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ChassisNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ChassisNo.Location = New System.Drawing.Point(134, 161)
        Me.txt_ChassisNo.Name = "txt_ChassisNo"
        Me.txt_ChassisNo.Size = New System.Drawing.Size(300, 26)
        Me.txt_ChassisNo.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(5, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 19)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "CHASSIS NO:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_EngineNo
        '
        Me.txt_EngineNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_EngineNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EngineNo.Location = New System.Drawing.Point(134, 132)
        Me.txt_EngineNo.Name = "txt_EngineNo"
        Me.txt_EngineNo.Size = New System.Drawing.Size(300, 26)
        Me.txt_EngineNo.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(5, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 19)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "ENGINE NO:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txt_PrevID)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_Remarks)
        Me.GroupBox2.Controls.Add(Me.txt_CustName)
        Me.GroupBox2.Controls.Add(Me.txt_whdesc)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_whcode)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_IfExist)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(450, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 241)
        Me.GroupBox2.TabIndex = 114
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETAILS"
        '
        'txt_PrevID
        '
        Me.txt_PrevID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrevID.Location = New System.Drawing.Point(104, 168)
        Me.txt_PrevID.Name = "txt_PrevID"
        Me.txt_PrevID.Size = New System.Drawing.Size(232, 26)
        Me.txt_PrevID.TabIndex = 133
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(11, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "PrevID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Location = New System.Drawing.Point(104, 138)
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(232, 26)
        Me.txt_Remarks.TabIndex = 131
        '
        'txt_CustName
        '
        Me.txt_CustName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CustName.Location = New System.Drawing.Point(104, 109)
        Me.txt_CustName.Name = "txt_CustName"
        Me.txt_CustName.Size = New System.Drawing.Size(232, 26)
        Me.txt_CustName.TabIndex = 130
        '
        'txt_whdesc
        '
        Me.txt_whdesc.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_whdesc.Location = New System.Drawing.Point(124, 77)
        Me.txt_whdesc.Name = "txt_whdesc"
        Me.txt_whdesc.ReadOnly = True
        Me.txt_whdesc.Size = New System.Drawing.Size(212, 26)
        Me.txt_whdesc.TabIndex = 129
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Teal
        Me.Label13.Location = New System.Drawing.Point(11, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 19)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "WH DESCRIPTION"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(11, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "CUSTOMER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(11, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 19)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "REMARKS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_whcode
        '
        Me.txt_whcode.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_whcode.ForeColor = System.Drawing.Color.Red
        Me.txt_whcode.FormattingEnabled = True
        Me.txt_whcode.Location = New System.Drawing.Point(104, 46)
        Me.txt_whcode.Name = "txt_whcode"
        Me.txt_whcode.Size = New System.Drawing.Size(232, 26)
        Me.txt_whcode.TabIndex = 119
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Teal
        Me.Label9.Location = New System.Drawing.Point(11, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 19)
        Me.Label9.TabIndex = 124
        Me.Label9.Text = "IFEXIST"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_IfExist
        '
        Me.txt_IfExist.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IfExist.Location = New System.Drawing.Point(104, 15)
        Me.txt_IfExist.Name = "txt_IfExist"
        Me.txt_IfExist.Size = New System.Drawing.Size(74, 26)
        Me.txt_IfExist.TabIndex = 123
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(9, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 19)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "WH CODE"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(477, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 19)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "ITEM GROUP"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(10, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 19)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "INV ID #"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(136, 42)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(148, 26)
        Me.txt_id.TabIndex = 119
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.receivedDate)
        Me.GroupBox3.Controls.Add(Me.txt_itemgroup)
        Me.GroupBox3.Controls.Add(Me.txt_InventoryStatus)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_BranchCode)
        Me.GroupBox3.Controls.Add(Me.txt_BranchName)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_id)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(2, 39)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(790, 104)
        Me.GroupBox3.TabIndex = 115
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PARAMETERS"
        '
        'receivedDate
        '
        Me.receivedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.receivedDate.Location = New System.Drawing.Point(610, 44)
        Me.receivedDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.receivedDate.Name = "receivedDate"
        Me.receivedDate.Size = New System.Drawing.Size(174, 23)
        Me.receivedDate.TabIndex = 124
        '
        'txt_itemgroup
        '
        Me.txt_itemgroup.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_itemgroup.Location = New System.Drawing.Point(610, 72)
        Me.txt_itemgroup.Name = "txt_itemgroup"
        Me.txt_itemgroup.ReadOnly = True
        Me.txt_itemgroup.Size = New System.Drawing.Size(174, 26)
        Me.txt_itemgroup.TabIndex = 132
        Me.txt_itemgroup.Text = "MOTORCYCLE"
        '
        'txt_InventoryStatus
        '
        Me.txt_InventoryStatus.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_InventoryStatus.Location = New System.Drawing.Point(137, 71)
        Me.txt_InventoryStatus.Name = "txt_InventoryStatus"
        Me.txt_InventoryStatus.ReadOnly = True
        Me.txt_InventoryStatus.Size = New System.Drawing.Size(147, 26)
        Me.txt_InventoryStatus.TabIndex = 130
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Teal
        Me.Label14.Location = New System.Drawing.Point(10, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 19)
        Me.Label14.TabIndex = 129
        Me.Label14.Text = "INVTY STATUS"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Teal
        Me.Label16.Location = New System.Drawing.Point(475, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(139, 24)
        Me.Label16.TabIndex = 125
        Me.Label16.Text = "TRANSACTION DATE"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_BranchCode
        '
        Me.txt_BranchCode.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BranchCode.Location = New System.Drawing.Point(136, 13)
        Me.txt_BranchCode.Name = "txt_BranchCode"
        Me.txt_BranchCode.ReadOnly = True
        Me.txt_BranchCode.Size = New System.Drawing.Size(148, 26)
        Me.txt_BranchCode.TabIndex = 123
        '
        'txt_BranchName
        '
        Me.txt_BranchName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BranchName.Location = New System.Drawing.Point(290, 13)
        Me.txt_BranchName.Name = "txt_BranchName"
        Me.txt_BranchName.ReadOnly = True
        Me.txt_BranchName.Size = New System.Drawing.Size(494, 26)
        Me.txt_BranchName.TabIndex = 121
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Teal
        Me.Label15.Location = New System.Drawing.Point(10, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 19)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "VENDOR / BRANCH"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Admin_ReclassINVTY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(794, 391)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admin_ReclassINVTY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECLASS INVENTORY"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolnew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolFindItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_keynumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_descrip As System.Windows.Forms.TextBox
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_ChassisNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_EngineNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents toolUPDATE As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_whcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_IfExist As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_BranchCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_BranchName As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_CustName As System.Windows.Forms.TextBox
    Friend WithEvents txt_whdesc As System.Windows.Forms.TextBox
    Friend WithEvents txt_InventoryStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents receivedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents txt_itemgroup As System.Windows.Forms.TextBox
    Friend WithEvents txt_model As System.Windows.Forms.ComboBox
    Friend WithEvents txt_color As System.Windows.Forms.ComboBox
    Friend WithEvents txt_brand As System.Windows.Forms.ComboBox
    Friend WithEvents txt_PrevID As TextBox
    Friend WithEvents Label5 As Label
End Class
