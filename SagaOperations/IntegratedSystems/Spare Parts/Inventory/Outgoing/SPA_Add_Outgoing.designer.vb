<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPA_Add_Outgoing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPA_Add_Outgoing))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_Quantity = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_CostWoVAT = New System.Windows.Forms.TextBox()
        Me.txt_CostWVAT = New System.Windows.Forms.TextBox()
        Me.txt_PriceWoVAT = New System.Windows.Forms.TextBox()
        Me.txt_PriceWVAT = New System.Windows.Forms.TextBox()
        Me.txt_DiscountAMT = New System.Windows.Forms.TextBox()
        Me.txt_DiscountPCT = New System.Windows.Forms.TextBox()
        Me.txt_SRP = New System.Windows.Forms.TextBox()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_BinBox = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_Category = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dpt_PDate = New System.Windows.Forms.DateTimePicker()
        Me.txt_SC_SpareParts = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Remarks = New System.Windows.Forms.TextBox()
        Me.txt_Note = New System.Windows.Forms.TextBox()
        Me.txt_ModelName = New System.Windows.Forms.TextBox()
        Me.txt_ModelCode = New System.Windows.Forms.TextBox()
        Me.txt_Brand = New System.Windows.Forms.TextBox()
        Me.txt_PartsName = New System.Windows.Forms.TextBox()
        Me.txt_PartsNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_Vendor = New System.Windows.Forms.TextBox()
        Me.lbl_Less = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbl_VAT = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_Quantity1 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txt_Quantity)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txt_Total)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_CostWoVAT)
        Me.GroupBox2.Controls.Add(Me.txt_CostWVAT)
        Me.GroupBox2.Controls.Add(Me.txt_PriceWoVAT)
        Me.GroupBox2.Controls.Add(Me.txt_PriceWVAT)
        Me.GroupBox2.Controls.Add(Me.txt_DiscountAMT)
        Me.GroupBox2.Controls.Add(Me.txt_DiscountPCT)
        Me.GroupBox2.Controls.Add(Me.txt_SRP)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(440, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(427, 385)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRICES"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 311)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 19)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "QUANTITY"
        '
        'txt_Quantity
        '
        Me.txt_Quantity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Quantity.Location = New System.Drawing.Point(144, 309)
        Me.txt_Quantity.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.txt_Quantity.Name = "txt_Quantity"
        Me.txt_Quantity.Size = New System.Drawing.Size(256, 27)
        Me.txt_Quantity.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 351)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 19)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "TOTAL"
        '
        'txt_Total
        '
        Me.txt_Total.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Total.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_Total.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(144, 348)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.ReadOnly = True
        Me.txt_Total.Size = New System.Drawing.Size(256, 27)
        Me.txt_Total.TabIndex = 8
        Me.txt_Total.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 19)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "COST WoVAT"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 19)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "COST WVAT"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 229)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 19)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "PRICE WoVAT"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 188)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 19)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "PRICE WVAT"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 19)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "DISCOUNT AMT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 19)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "DISCOUNT PCT"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 271)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 19)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "SRP"
        '
        'txt_CostWoVAT
        '
        Me.txt_CostWoVAT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_CostWoVAT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_CostWoVAT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CostWoVAT.Location = New System.Drawing.Point(144, 63)
        Me.txt_CostWoVAT.Name = "txt_CostWoVAT"
        Me.txt_CostWoVAT.Size = New System.Drawing.Size(256, 27)
        Me.txt_CostWoVAT.TabIndex = 1
        Me.txt_CostWoVAT.Text = "0"
        '
        'txt_CostWVAT
        '
        Me.txt_CostWVAT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_CostWVAT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_CostWVAT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CostWVAT.Location = New System.Drawing.Point(144, 22)
        Me.txt_CostWVAT.Name = "txt_CostWVAT"
        Me.txt_CostWVAT.Size = New System.Drawing.Size(256, 27)
        Me.txt_CostWVAT.TabIndex = 0
        Me.txt_CostWVAT.Text = "0"
        '
        'txt_PriceWoVAT
        '
        Me.txt_PriceWoVAT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_PriceWoVAT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_PriceWoVAT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PriceWoVAT.Location = New System.Drawing.Point(144, 226)
        Me.txt_PriceWoVAT.Name = "txt_PriceWoVAT"
        Me.txt_PriceWoVAT.ReadOnly = True
        Me.txt_PriceWoVAT.Size = New System.Drawing.Size(256, 27)
        Me.txt_PriceWoVAT.TabIndex = 5
        Me.txt_PriceWoVAT.Text = "0"
        '
        'txt_PriceWVAT
        '
        Me.txt_PriceWVAT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_PriceWVAT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_PriceWVAT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PriceWVAT.Location = New System.Drawing.Point(144, 185)
        Me.txt_PriceWVAT.Name = "txt_PriceWVAT"
        Me.txt_PriceWVAT.ReadOnly = True
        Me.txt_PriceWVAT.Size = New System.Drawing.Size(256, 27)
        Me.txt_PriceWVAT.TabIndex = 4
        Me.txt_PriceWVAT.Text = "0"
        '
        'txt_DiscountAMT
        '
        Me.txt_DiscountAMT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_DiscountAMT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_DiscountAMT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DiscountAMT.Location = New System.Drawing.Point(144, 144)
        Me.txt_DiscountAMT.Name = "txt_DiscountAMT"
        Me.txt_DiscountAMT.ReadOnly = True
        Me.txt_DiscountAMT.Size = New System.Drawing.Size(256, 27)
        Me.txt_DiscountAMT.TabIndex = 3
        Me.txt_DiscountAMT.Text = "0"
        '
        'txt_DiscountPCT
        '
        Me.txt_DiscountPCT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_DiscountPCT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_DiscountPCT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DiscountPCT.Location = New System.Drawing.Point(144, 103)
        Me.txt_DiscountPCT.Name = "txt_DiscountPCT"
        Me.txt_DiscountPCT.Size = New System.Drawing.Size(256, 27)
        Me.txt_DiscountPCT.TabIndex = 2
        Me.txt_DiscountPCT.Text = "0"
        '
        'txt_SRP
        '
        Me.txt_SRP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_SRP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_SRP.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SRP.Location = New System.Drawing.Point(144, 268)
        Me.txt_SRP.Name = "txt_SRP"
        Me.txt_SRP.Size = New System.Drawing.Size(256, 27)
        Me.txt_SRP.TabIndex = 6
        Me.txt_SRP.Text = "0"
        '
        'btn_Add
        '
        Me.btn_Add.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.Image = CType(resources.GetObject("btn_Add.Image"), System.Drawing.Image)
        Me.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Add.Location = New System.Drawing.Point(440, 416)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(208, 35)
        Me.btn_Add.TabIndex = 2
        Me.btn_Add.Text = "ADD"
        Me.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.txt_BinBox)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txt_Category)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.dpt_PDate)
        Me.GroupBox1.Controls.Add(Me.txt_SC_SpareParts)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_Remarks)
        Me.GroupBox1.Controls.Add(Me.txt_Note)
        Me.GroupBox1.Controls.Add(Me.txt_ModelName)
        Me.GroupBox1.Controls.Add(Me.txt_ModelCode)
        Me.GroupBox1.Controls.Add(Me.txt_Brand)
        Me.GroupBox1.Controls.Add(Me.txt_PartsName)
        Me.GroupBox1.Controls.Add(Me.txt_PartsNumber)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 439)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETAILS"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(6, 223)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 19)
        Me.Label29.TabIndex = 26
        Me.Label29.Text = "BIN BOX"
        '
        'txt_BinBox
        '
        Me.txt_BinBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_BinBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_BinBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BinBox.Location = New System.Drawing.Point(153, 220)
        Me.txt_BinBox.Name = "txt_BinBox"
        Me.txt_BinBox.Size = New System.Drawing.Size(247, 27)
        Me.txt_BinBox.TabIndex = 27
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 184)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 19)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "CATEGORY"
        '
        'txt_Category
        '
        Me.txt_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_Category.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Category.Location = New System.Drawing.Point(153, 181)
        Me.txt_Category.Name = "txt_Category"
        Me.txt_Category.Size = New System.Drawing.Size(247, 27)
        Me.txt_Category.TabIndex = 25
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(146, 19)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "SUPER CEEDING P/N"
        '
        'dpt_PDate
        '
        Me.dpt_PDate.Enabled = False
        Me.dpt_PDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpt_PDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpt_PDate.Location = New System.Drawing.Point(153, 402)
        Me.dpt_PDate.Name = "dpt_PDate"
        Me.dpt_PDate.Size = New System.Drawing.Size(168, 27)
        Me.dpt_PDate.TabIndex = 8
        '
        'txt_SC_SpareParts
        '
        Me.txt_SC_SpareParts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_SC_SpareParts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_SC_SpareParts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SC_SpareParts.Location = New System.Drawing.Point(153, 62)
        Me.txt_SC_SpareParts.Name = "txt_SC_SpareParts"
        Me.txt_SC_SpareParts.ReadOnly = True
        Me.txt_SC_SpareParts.Size = New System.Drawing.Size(247, 27)
        Me.txt_SC_SpareParts.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 405)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 19)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "POSTING DATE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 19)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "REMARKS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "NOTE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "MODEL NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "MODEL CODE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "BRAND"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PARTS NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PARTS #"
        '
        'txt_Remarks
        '
        Me.txt_Remarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Remarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_Remarks.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Location = New System.Drawing.Point(153, 366)
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.ReadOnly = True
        Me.txt_Remarks.Size = New System.Drawing.Size(247, 27)
        Me.txt_Remarks.TabIndex = 7
        '
        'txt_Note
        '
        Me.txt_Note.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Note.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_Note.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Note.Location = New System.Drawing.Point(153, 330)
        Me.txt_Note.Name = "txt_Note"
        Me.txt_Note.Size = New System.Drawing.Size(247, 27)
        Me.txt_Note.TabIndex = 6
        '
        'txt_ModelName
        '
        Me.txt_ModelName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_ModelName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_ModelName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ModelName.Location = New System.Drawing.Point(153, 293)
        Me.txt_ModelName.Name = "txt_ModelName"
        Me.txt_ModelName.ReadOnly = True
        Me.txt_ModelName.Size = New System.Drawing.Size(247, 27)
        Me.txt_ModelName.TabIndex = 5
        '
        'txt_ModelCode
        '
        Me.txt_ModelCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_ModelCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_ModelCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ModelCode.Location = New System.Drawing.Point(153, 257)
        Me.txt_ModelCode.Name = "txt_ModelCode"
        Me.txt_ModelCode.ReadOnly = True
        Me.txt_ModelCode.Size = New System.Drawing.Size(247, 27)
        Me.txt_ModelCode.TabIndex = 4
        '
        'txt_Brand
        '
        Me.txt_Brand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Brand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_Brand.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Brand.Location = New System.Drawing.Point(153, 142)
        Me.txt_Brand.Name = "txt_Brand"
        Me.txt_Brand.ReadOnly = True
        Me.txt_Brand.Size = New System.Drawing.Size(247, 27)
        Me.txt_Brand.TabIndex = 3
        '
        'txt_PartsName
        '
        Me.txt_PartsName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_PartsName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_PartsName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsName.Location = New System.Drawing.Point(153, 101)
        Me.txt_PartsName.Name = "txt_PartsName"
        Me.txt_PartsName.ReadOnly = True
        Me.txt_PartsName.Size = New System.Drawing.Size(247, 27)
        Me.txt_PartsName.TabIndex = 2
        '
        'txt_PartsNumber
        '
        Me.txt_PartsNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_PartsNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_PartsNumber.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsNumber.Location = New System.Drawing.Point(153, 23)
        Me.txt_PartsNumber.Name = "txt_PartsNumber"
        Me.txt_PartsNumber.ReadOnly = True
        Me.txt_PartsNumber.Size = New System.Drawing.Size(247, 27)
        Me.txt_PartsNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID #"
        '
        'txt_ID
        '
        Me.txt_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_ID.Enabled = False
        Me.txt_ID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(128, 32)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(279, 27)
        Me.txt_ID.TabIndex = 2
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.Location = New System.Drawing.Point(659, 416)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(208, 35)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(1174, 204)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(17, 19)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(1014, 204)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 19)
        Me.Label26.TabIndex = 48
        Me.Label26.Text = "TOTAL"
        '
        'txt_Vendor
        '
        Me.txt_Vendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Vendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_Vendor.Enabled = False
        Me.txt_Vendor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Vendor.Location = New System.Drawing.Point(1069, 329)
        Me.txt_Vendor.Name = "txt_Vendor"
        Me.txt_Vendor.Size = New System.Drawing.Size(156, 27)
        Me.txt_Vendor.TabIndex = 47
        '
        'lbl_Less
        '
        Me.lbl_Less.AutoSize = True
        Me.lbl_Less.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Less.ForeColor = System.Drawing.Color.White
        Me.lbl_Less.Location = New System.Drawing.Point(1174, 307)
        Me.lbl_Less.Name = "lbl_Less"
        Me.lbl_Less.Size = New System.Drawing.Size(17, 19)
        Me.lbl_Less.TabIndex = 46
        Me.lbl_Less.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(1014, 307)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 19)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "Less"
        '
        'lbl_VAT
        '
        Me.lbl_VAT.AutoSize = True
        Me.lbl_VAT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VAT.ForeColor = System.Drawing.Color.White
        Me.lbl_VAT.Location = New System.Drawing.Point(1174, 253)
        Me.lbl_VAT.Name = "lbl_VAT"
        Me.lbl_VAT.Size = New System.Drawing.Size(37, 19)
        Me.lbl_VAT.TabIndex = 44
        Me.lbl_VAT.Text = "1.12"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(1014, 253)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(31, 19)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "Vat"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(1174, 281)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(17, 19)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "0"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(1014, 281)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(77, 19)
        Me.Label28.TabIndex = 39
        Me.Label28.Text = "Quantity1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(1014, 156)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 19)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Quantity1"
        '
        'lbl_Quantity1
        '
        Me.lbl_Quantity1.AutoSize = True
        Me.lbl_Quantity1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Quantity1.ForeColor = System.Drawing.Color.White
        Me.lbl_Quantity1.Location = New System.Drawing.Point(1174, 156)
        Me.lbl_Quantity1.Name = "lbl_Quantity1"
        Me.lbl_Quantity1.Size = New System.Drawing.Size(17, 19)
        Me.lbl_Quantity1.TabIndex = 19
        Me.lbl_Quantity1.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(1014, 182)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 19)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "TOTAL"
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.ForeColor = System.Drawing.Color.White
        Me.lbl_Total.Location = New System.Drawing.Point(1174, 182)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(17, 19)
        Me.lbl_Total.TabIndex = 21
        Me.lbl_Total.Text = "0"
        '
        'SPA_Add_Outgoing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(873, 463)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txt_Vendor)
        Me.Controls.Add(Me.lbl_Less)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lbl_VAT)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lbl_Quantity1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(889, 502)
        Me.Name = "SPA_Add_Outgoing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD SPARE PARTS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_Quantity As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_Total As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_CostWoVAT As TextBox
    Friend WithEvents txt_CostWVAT As TextBox
    Friend WithEvents txt_PriceWoVAT As TextBox
    Friend WithEvents txt_PriceWVAT As TextBox
    Friend WithEvents txt_DiscountAMT As TextBox
    Friend WithEvents txt_DiscountPCT As TextBox
    Friend WithEvents txt_SRP As TextBox
    Friend WithEvents btn_Add As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dpt_PDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Remarks As TextBox
    Friend WithEvents txt_Note As TextBox
    Friend WithEvents txt_ModelName As TextBox
    Friend WithEvents txt_ModelCode As TextBox
    Friend WithEvents txt_Brand As TextBox
    Friend WithEvents txt_PartsName As TextBox
    Friend WithEvents txt_PartsNumber As TextBox
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_SC_SpareParts As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txt_Vendor As TextBox
    Friend WithEvents lbl_Less As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lbl_VAT As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lbl_Total As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lbl_Quantity1 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txt_BinBox As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_Category As TextBox
End Class
