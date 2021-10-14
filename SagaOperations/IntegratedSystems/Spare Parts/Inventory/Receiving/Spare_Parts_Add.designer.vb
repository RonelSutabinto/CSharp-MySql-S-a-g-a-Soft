<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Spare_Parts_Add
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Spare_Parts_Add))
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_Quantity1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_Category = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_BinBox = New System.Windows.Forms.TextBox()
        Me.lbl_Category = New System.Windows.Forms.Label()
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
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_Remarks = New System.Windows.Forms.TextBox()
        Me.txt_Note = New System.Windows.Forms.TextBox()
        Me.txt_ModelName = New System.Windows.Forms.TextBox()
        Me.txt_ModelCode = New System.Windows.Forms.TextBox()
        Me.txt_Brand = New System.Windows.Forms.TextBox()
        Me.txt_PartsName = New System.Windows.Forms.TextBox()
        Me.txt_PartsNumber = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.txt_DiscountAMT = New System.Windows.Forms.TextBox()
        Me.txt_DiscountPCT = New System.Windows.Forms.TextBox()
        Me.txt_SRP = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
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
        Me.lbl_VAT = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbl_Less = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_Vendor = New System.Windows.Forms.TextBox()
        Me.lbl_Total1 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_SRP12 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.ForeColor = System.Drawing.Color.White
        Me.lbl_Total.Location = New System.Drawing.Point(1129, 140)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(17, 19)
        Me.lbl_Total.TabIndex = 31
        Me.lbl_Total.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(969, 140)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 19)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "TOTAL"
        '
        'lbl_Quantity1
        '
        Me.lbl_Quantity1.AutoSize = True
        Me.lbl_Quantity1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Quantity1.ForeColor = System.Drawing.Color.White
        Me.lbl_Quantity1.Location = New System.Drawing.Point(1129, 249)
        Me.lbl_Quantity1.Name = "lbl_Quantity1"
        Me.lbl_Quantity1.Size = New System.Drawing.Size(17, 19)
        Me.lbl_Quantity1.TabIndex = 29
        Me.lbl_Quantity1.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(969, 249)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 19)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Quantity1"
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(656, 416)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(208, 35)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'txt_ID
        '
        Me.txt_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_ID.Enabled = False
        Me.txt_ID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(135, 36)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(279, 27)
        Me.txt_ID.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 19)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ID #"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cmb_Category)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.txt_BinBox)
        Me.GroupBox1.Controls.Add(Me.lbl_Category)
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
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.txt_Remarks)
        Me.GroupBox1.Controls.Add(Me.txt_Note)
        Me.GroupBox1.Controls.Add(Me.txt_ModelName)
        Me.GroupBox1.Controls.Add(Me.txt_ModelCode)
        Me.GroupBox1.Controls.Add(Me.txt_Brand)
        Me.GroupBox1.Controls.Add(Me.txt_PartsName)
        Me.GroupBox1.Controls.Add(Me.txt_PartsNumber)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 439)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETAILS"
        '
        'cmb_Category
        '
        Me.cmb_Category.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Category.FormattingEnabled = True
        Me.cmb_Category.Location = New System.Drawing.Point(163, 180)
        Me.cmb_Category.Name = "cmb_Category"
        Me.cmb_Category.Size = New System.Drawing.Size(247, 27)
        Me.cmb_Category.TabIndex = 50
        Me.cmb_Category.Text = "Spare Parts"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(16, 222)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 19)
        Me.Label29.TabIndex = 48
        Me.Label29.Text = "BIN BOX"
        '
        'txt_BinBox
        '
        Me.txt_BinBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_BinBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_BinBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BinBox.Location = New System.Drawing.Point(163, 219)
        Me.txt_BinBox.Name = "txt_BinBox"
        Me.txt_BinBox.Size = New System.Drawing.Size(247, 27)
        Me.txt_BinBox.TabIndex = 49
        '
        'lbl_Category
        '
        Me.lbl_Category.AutoSize = True
        Me.lbl_Category.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Category.Location = New System.Drawing.Point(16, 183)
        Me.lbl_Category.Name = "lbl_Category"
        Me.lbl_Category.Size = New System.Drawing.Size(80, 19)
        Me.lbl_Category.TabIndex = 46
        Me.lbl_Category.Text = "CATEGORY"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(146, 19)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "SUPER CEEDING P/N"
        '
        'dpt_PDate
        '
        Me.dpt_PDate.Enabled = False
        Me.dpt_PDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpt_PDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpt_PDate.Location = New System.Drawing.Point(163, 401)
        Me.dpt_PDate.Name = "dpt_PDate"
        Me.dpt_PDate.Size = New System.Drawing.Size(168, 27)
        Me.dpt_PDate.TabIndex = 44
        '
        'txt_SC_SpareParts
        '
        Me.txt_SC_SpareParts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_SC_SpareParts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_SC_SpareParts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SC_SpareParts.Location = New System.Drawing.Point(163, 61)
        Me.txt_SC_SpareParts.Name = "txt_SC_SpareParts"
        Me.txt_SC_SpareParts.ReadOnly = True
        Me.txt_SC_SpareParts.Size = New System.Drawing.Size(247, 27)
        Me.txt_SC_SpareParts.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 404)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 19)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "POSTING DATE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 19)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "REMARKS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 19)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "NOTE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 19)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "MODEL NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 19)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "MODEL CODE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "BRAND"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "PARTS NAME"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(16, 25)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 19)
        Me.Label27.TabIndex = 32
        Me.Label27.Text = "PARTS #"
        '
        'txt_Remarks
        '
        Me.txt_Remarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Remarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_Remarks.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Location = New System.Drawing.Point(163, 365)
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.ReadOnly = True
        Me.txt_Remarks.Size = New System.Drawing.Size(247, 27)
        Me.txt_Remarks.TabIndex = 43
        '
        'txt_Note
        '
        Me.txt_Note.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Note.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_Note.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Note.Location = New System.Drawing.Point(163, 329)
        Me.txt_Note.Name = "txt_Note"
        Me.txt_Note.Size = New System.Drawing.Size(247, 27)
        Me.txt_Note.TabIndex = 42
        '
        'txt_ModelName
        '
        Me.txt_ModelName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_ModelName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_ModelName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ModelName.Location = New System.Drawing.Point(163, 292)
        Me.txt_ModelName.Name = "txt_ModelName"
        Me.txt_ModelName.ReadOnly = True
        Me.txt_ModelName.Size = New System.Drawing.Size(247, 27)
        Me.txt_ModelName.TabIndex = 41
        '
        'txt_ModelCode
        '
        Me.txt_ModelCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_ModelCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_ModelCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ModelCode.Location = New System.Drawing.Point(163, 256)
        Me.txt_ModelCode.Name = "txt_ModelCode"
        Me.txt_ModelCode.ReadOnly = True
        Me.txt_ModelCode.Size = New System.Drawing.Size(247, 27)
        Me.txt_ModelCode.TabIndex = 40
        '
        'txt_Brand
        '
        Me.txt_Brand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Brand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_Brand.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Brand.Location = New System.Drawing.Point(163, 141)
        Me.txt_Brand.Name = "txt_Brand"
        Me.txt_Brand.ReadOnly = True
        Me.txt_Brand.Size = New System.Drawing.Size(247, 27)
        Me.txt_Brand.TabIndex = 31
        '
        'txt_PartsName
        '
        Me.txt_PartsName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_PartsName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_PartsName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsName.Location = New System.Drawing.Point(163, 100)
        Me.txt_PartsName.Name = "txt_PartsName"
        Me.txt_PartsName.ReadOnly = True
        Me.txt_PartsName.Size = New System.Drawing.Size(247, 27)
        Me.txt_PartsName.TabIndex = 30
        '
        'txt_PartsNumber
        '
        Me.txt_PartsNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_PartsNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_PartsNumber.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsNumber.Location = New System.Drawing.Point(163, 22)
        Me.txt_PartsNumber.Name = "txt_PartsNumber"
        Me.txt_PartsNumber.ReadOnly = True
        Me.txt_PartsNumber.Size = New System.Drawing.Size(247, 27)
        Me.txt_PartsNumber.TabIndex = 28
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btn_Add
        '
        Me.btn_Add.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.Image = CType(resources.GetObject("btn_Add.Image"), System.Drawing.Image)
        Me.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Add.Location = New System.Drawing.Point(437, 416)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(208, 35)
        Me.btn_Add.TabIndex = 2
        Me.btn_Add.Text = "ADD"
        Me.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'txt_DiscountAMT
        '
        Me.txt_DiscountAMT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_DiscountAMT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_DiscountAMT.Enabled = False
        Me.txt_DiscountAMT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DiscountAMT.Location = New System.Drawing.Point(144, 144)
        Me.txt_DiscountAMT.Name = "txt_DiscountAMT"
        Me.txt_DiscountAMT.Size = New System.Drawing.Size(256, 27)
        Me.txt_DiscountAMT.TabIndex = 3
        Me.txt_DiscountAMT.Text = "0.00"
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
        Me.txt_SRP.Text = "0.00"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label22)
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
        Me.GroupBox2.Location = New System.Drawing.Point(437, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(427, 385)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRICES"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(378, 107)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(21, 19)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "%"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 310)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 19)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "QUANTITY"
        '
        'txt_Quantity
        '
        Me.txt_Quantity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Quantity.Location = New System.Drawing.Point(144, 308)
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
        Me.txt_Total.Enabled = False
        Me.txt_Total.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(144, 348)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.Size = New System.Drawing.Size(256, 27)
        Me.txt_Total.TabIndex = 8
        Me.txt_Total.Text = "0.00"
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
        Me.txt_CostWoVAT.Text = "0.00"
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
        Me.txt_CostWVAT.Text = "0.00"
        '
        'txt_PriceWoVAT
        '
        Me.txt_PriceWoVAT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_PriceWoVAT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_PriceWoVAT.Enabled = False
        Me.txt_PriceWoVAT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PriceWoVAT.Location = New System.Drawing.Point(144, 226)
        Me.txt_PriceWoVAT.Name = "txt_PriceWoVAT"
        Me.txt_PriceWoVAT.Size = New System.Drawing.Size(256, 27)
        Me.txt_PriceWoVAT.TabIndex = 5
        Me.txt_PriceWoVAT.Text = "0.00"
        '
        'txt_PriceWVAT
        '
        Me.txt_PriceWVAT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_PriceWVAT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_PriceWVAT.Enabled = False
        Me.txt_PriceWVAT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PriceWVAT.Location = New System.Drawing.Point(144, 185)
        Me.txt_PriceWVAT.Name = "txt_PriceWVAT"
        Me.txt_PriceWVAT.Size = New System.Drawing.Size(256, 27)
        Me.txt_PriceWVAT.TabIndex = 4
        Me.txt_PriceWVAT.Text = "0.00"
        '
        'lbl_VAT
        '
        Me.lbl_VAT.AutoSize = True
        Me.lbl_VAT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VAT.ForeColor = System.Drawing.Color.White
        Me.lbl_VAT.Location = New System.Drawing.Point(1129, 221)
        Me.lbl_VAT.Name = "lbl_VAT"
        Me.lbl_VAT.Size = New System.Drawing.Size(37, 19)
        Me.lbl_VAT.TabIndex = 33
        Me.lbl_VAT.Text = "1.12"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(969, 221)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(31, 19)
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "Vat"
        '
        'lbl_Less
        '
        Me.lbl_Less.AutoSize = True
        Me.lbl_Less.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Less.ForeColor = System.Drawing.Color.White
        Me.lbl_Less.Location = New System.Drawing.Point(1129, 275)
        Me.lbl_Less.Name = "lbl_Less"
        Me.lbl_Less.Size = New System.Drawing.Size(17, 19)
        Me.lbl_Less.TabIndex = 35
        Me.lbl_Less.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(969, 275)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 19)
        Me.Label25.TabIndex = 34
        Me.Label25.Text = "Less"
        '
        'txt_Vendor
        '
        Me.txt_Vendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Vendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_Vendor.Enabled = False
        Me.txt_Vendor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Vendor.Location = New System.Drawing.Point(1024, 297)
        Me.txt_Vendor.Name = "txt_Vendor"
        Me.txt_Vendor.Size = New System.Drawing.Size(156, 27)
        Me.txt_Vendor.TabIndex = 36
        '
        'lbl_Total1
        '
        Me.lbl_Total1.AutoSize = True
        Me.lbl_Total1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total1.ForeColor = System.Drawing.Color.White
        Me.lbl_Total1.Location = New System.Drawing.Point(1129, 172)
        Me.lbl_Total1.Name = "lbl_Total1"
        Me.lbl_Total1.Size = New System.Drawing.Size(17, 19)
        Me.lbl_Total1.TabIndex = 38
        Me.lbl_Total1.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(969, 172)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 19)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "TOTAL"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(971, 101)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(35, 19)
        Me.Label24.TabIndex = 39
        Me.Label24.Text = "SRP"
        '
        'txt_SRP12
        '
        Me.txt_SRP12.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_SRP12.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_SRP12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SRP12.Location = New System.Drawing.Point(1024, 98)
        Me.txt_SRP12.Name = "txt_SRP12"
        Me.txt_SRP12.Size = New System.Drawing.Size(96, 27)
        Me.txt_SRP12.TabIndex = 40
        Me.txt_SRP12.Text = "0"
        '
        'Spare_Parts_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(869, 463)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txt_SRP12)
        Me.Controls.Add(Me.lbl_Total1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txt_Vendor)
        Me.Controls.Add(Me.lbl_Less)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lbl_VAT)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lbl_Quantity1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(885, 502)
        Me.Name = "Spare_Parts_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD SPARE PARTS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Total As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lbl_Quantity1 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btn_Add As Button
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
    Friend WithEvents lbl_VAT As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lbl_Less As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_Vendor As TextBox
    Friend WithEvents lbl_Total1 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_SRP12 As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txt_BinBox As TextBox
    Friend WithEvents lbl_Category As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents dpt_PDate As DateTimePicker
    Friend WithEvents txt_SC_SpareParts As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txt_Remarks As TextBox
    Friend WithEvents txt_Note As TextBox
    Friend WithEvents txt_ModelName As TextBox
    Friend WithEvents txt_ModelCode As TextBox
    Friend WithEvents txt_Brand As TextBox
    Friend WithEvents txt_PartsName As TextBox
    Friend WithEvents txt_PartsNumber As TextBox
    Friend WithEvents cmb_Category As ComboBox
End Class
