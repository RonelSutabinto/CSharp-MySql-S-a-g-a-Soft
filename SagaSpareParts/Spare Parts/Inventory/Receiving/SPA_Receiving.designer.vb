<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SPA_Receiving
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPA_Receiving))
        Me.lvParts = New System.Windows.Forms.ListView()
        Me.partsNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partsName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sc_SpareParts = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.srp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.spCostWVAT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.spCostWoVAT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DiscountPCT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DiscountAMT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.priceWVAT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.priceWOVAT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.modelCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.modelName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.subTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BinBox = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_Vendor = New System.Windows.Forms.TextBox()
        Me.txt_Status = New System.Windows.Forms.TextBox()
        Me.txt_RefNo = New System.Windows.Forms.TextBox()
        Me.txt_Note = New System.Windows.Forms.TextBox()
        Me.txt_Checker = New System.Windows.Forms.TextBox()
        Me.txt_POno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_WhCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_WhCategory = New System.Windows.Forms.ComboBox()
        Me.dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_Count = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_SubTotal = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_Less = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_GrandTotal = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbl_Discount = New System.Windows.Forms.Label()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Approver = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Remarks = New System.Windows.Forms.TextBox()
        Me.txt_Source = New System.Windows.Forms.TextBox()
        Me.lbl_TotalSum = New System.Windows.Forms.Label()
        Me.lbl_TotalLess = New System.Windows.Forms.Label()
        Me.lbl_VATLess = New System.Windows.Forms.Label()
        Me.btn_Send = New System.Windows.Forms.Button()
        Me.btn_Add_SPA = New System.Windows.Forms.Button()
        Me.btn_Vendor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvParts
        '
        Me.lvParts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvParts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.partsNumber, Me.partsName, Me.Brand, Me.sc_SpareParts, Me.srp, Me.quantity, Me.spCostWVAT, Me.spCostWoVAT, Me.DiscountPCT, Me.DiscountAMT, Me.priceWVAT, Me.priceWOVAT, Me.modelCode, Me.modelName, Me.subTotal, Me.Category, Me.BinBox})
        Me.lvParts.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvParts.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lvParts.FullRowSelect = True
        Me.lvParts.GridLines = True
        Me.lvParts.HoverSelection = True
        Me.lvParts.Location = New System.Drawing.Point(9, 179)
        Me.lvParts.Name = "lvParts"
        Me.lvParts.Size = New System.Drawing.Size(880, 333)
        Me.lvParts.TabIndex = 0
        Me.lvParts.UseCompatibleStateImageBehavior = False
        Me.lvParts.View = System.Windows.Forms.View.Details
        '
        'partsNumber
        '
        Me.partsNumber.Text = "PARTS NUMBER"
        Me.partsNumber.Width = 150
        '
        'partsName
        '
        Me.partsName.Text = "PARTS NAME"
        Me.partsName.Width = 150
        '
        'Brand
        '
        Me.Brand.Text = "BRAND"
        Me.Brand.Width = 150
        '
        'sc_SpareParts
        '
        Me.sc_SpareParts.Text = "SUPER SEEDING P/N"
        Me.sc_SpareParts.Width = 200
        '
        'srp
        '
        Me.srp.Text = "SRP"
        Me.srp.Width = 120
        '
        'quantity
        '
        Me.quantity.Text = "QUANTITY"
        Me.quantity.Width = 100
        '
        'spCostWVAT
        '
        Me.spCostWVAT.Text = "COST WVAT"
        Me.spCostWVAT.Width = 140
        '
        'spCostWoVAT
        '
        Me.spCostWoVAT.Text = "COST WOVAT"
        Me.spCostWoVAT.Width = 140
        '
        'DiscountPCT
        '
        Me.DiscountPCT.Text = "DISCOUNT PCT"
        Me.DiscountPCT.Width = 150
        '
        'DiscountAMT
        '
        Me.DiscountAMT.Text = "DISCOUNT AMT"
        Me.DiscountAMT.Width = 150
        '
        'priceWVAT
        '
        Me.priceWVAT.Text = "PRICE WVAT"
        Me.priceWVAT.Width = 150
        '
        'priceWOVAT
        '
        Me.priceWOVAT.Text = "PRICE WOVAT"
        Me.priceWOVAT.Width = 150
        '
        'modelCode
        '
        Me.modelCode.Text = "MODEL CODE"
        Me.modelCode.Width = 150
        '
        'modelName
        '
        Me.modelName.Text = "MODEL NAME"
        Me.modelName.Width = 150
        '
        'subTotal
        '
        Me.subTotal.Text = "SUB Total"
        '
        'Category
        '
        Me.Category.Text = "Category"
        '
        'BinBox
        '
        Me.BinBox.Text = "BinBox"
        '
        'txt_Vendor
        '
        Me.txt_Vendor.BackColor = System.Drawing.Color.White
        Me.txt_Vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Vendor.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Vendor.Location = New System.Drawing.Point(143, 11)
        Me.txt_Vendor.Name = "txt_Vendor"
        Me.txt_Vendor.ReadOnly = True
        Me.txt_Vendor.Size = New System.Drawing.Size(291, 26)
        Me.txt_Vendor.TabIndex = 0
        '
        'txt_Status
        '
        Me.txt_Status.BackColor = System.Drawing.Color.White
        Me.txt_Status.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Status.Location = New System.Drawing.Point(143, 77)
        Me.txt_Status.Name = "txt_Status"
        Me.txt_Status.ReadOnly = True
        Me.txt_Status.Size = New System.Drawing.Size(404, 26)
        Me.txt_Status.TabIndex = 4
        Me.txt_Status.Text = "New"
        '
        'txt_RefNo
        '
        Me.txt_RefNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_RefNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RefNo.Location = New System.Drawing.Point(143, 44)
        Me.txt_RefNo.Name = "txt_RefNo"
        Me.txt_RefNo.Size = New System.Drawing.Size(156, 26)
        Me.txt_RefNo.TabIndex = 2
        '
        'txt_Note
        '
        Me.txt_Note.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Note.Location = New System.Drawing.Point(143, 143)
        Me.txt_Note.Name = "txt_Note"
        Me.txt_Note.Size = New System.Drawing.Size(404, 26)
        Me.txt_Note.TabIndex = 7
        '
        'txt_Checker
        '
        Me.txt_Checker.BackColor = System.Drawing.Color.White
        Me.txt_Checker.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Checker.Location = New System.Drawing.Point(143, 111)
        Me.txt_Checker.Name = "txt_Checker"
        Me.txt_Checker.ReadOnly = True
        Me.txt_Checker.Size = New System.Drawing.Size(156, 26)
        Me.txt_Checker.TabIndex = 5
        '
        'txt_POno
        '
        Me.txt_POno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_POno.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POno.Location = New System.Drawing.Point(398, 44)
        Me.txt_POno.Name = "txt_POno"
        Me.txt_POno.Size = New System.Drawing.Size(149, 26)
        Me.txt_POno.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BRANCH / VENDOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "STATUS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Ref No. / SI No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "NOTE"
        '
        'txt_WhCode
        '
        Me.txt_WhCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_WhCode.BackColor = System.Drawing.Color.White
        Me.txt_WhCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_WhCode.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_WhCode.Location = New System.Drawing.Point(647, 81)
        Me.txt_WhCode.Name = "txt_WhCode"
        Me.txt_WhCode.ReadOnly = True
        Me.txt_WhCode.Size = New System.Drawing.Size(134, 26)
        Me.txt_WhCode.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(555, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "DATE"
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(555, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "WARE HOUSE"
        '
        'cmb_WhCategory
        '
        Me.cmb_WhCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmb_WhCategory.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_WhCategory.FormattingEnabled = True
        Me.cmb_WhCategory.Items.AddRange(New Object() {"BRAND NEW", "OLD"})
        Me.cmb_WhCategory.Location = New System.Drawing.Point(647, 48)
        Me.cmb_WhCategory.Name = "cmb_WhCategory"
        Me.cmb_WhCategory.Size = New System.Drawing.Size(134, 26)
        Me.cmb_WhCategory.TabIndex = 9
        '
        'dtp_Date
        '
        Me.dtp_Date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtp_Date.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Date.Location = New System.Drawing.Point(647, 15)
        Me.dtp_Date.Name = "dtp_Date"
        Me.dtp_Date.Size = New System.Drawing.Size(134, 26)
        Me.dtp_Date.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 515)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(209, 14)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Double click item on the table to remove."
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(360, 538)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 23)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "ITEM COUNT"
        '
        'lbl_Count
        '
        Me.lbl_Count.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Count.AutoSize = True
        Me.lbl_Count.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Count.ForeColor = System.Drawing.Color.Black
        Me.lbl_Count.Location = New System.Drawing.Point(560, 538)
        Me.lbl_Count.Name = "lbl_Count"
        Me.lbl_Count.Size = New System.Drawing.Size(20, 23)
        Me.lbl_Count.TabIndex = 10
        Me.lbl_Count.Text = "0"
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(631, 517)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 15)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "TOTAL UNIT COST"
        '
        'lbl_SubTotal
        '
        Me.lbl_SubTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_SubTotal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubTotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_SubTotal.Location = New System.Drawing.Point(787, 517)
        Me.lbl_SubTotal.Name = "lbl_SubTotal"
        Me.lbl_SubTotal.Size = New System.Drawing.Size(79, 15)
        Me.lbl_SubTotal.TabIndex = 10
        Me.lbl_SubTotal.Text = "0"
        Me.lbl_SubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(631, 535)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 15)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "TOTAL VAT AMT"
        '
        'lbl_Less
        '
        Me.lbl_Less.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Less.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Less.ForeColor = System.Drawing.Color.Black
        Me.lbl_Less.Location = New System.Drawing.Point(787, 535)
        Me.lbl_Less.Name = "lbl_Less"
        Me.lbl_Less.Size = New System.Drawing.Size(79, 15)
        Me.lbl_Less.TabIndex = 10
        Me.lbl_Less.Text = "0"
        Me.lbl_Less.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(631, 554)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 15)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "GRAND TOTAL"
        '
        'lbl_GrandTotal
        '
        Me.lbl_GrandTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_GrandTotal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GrandTotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_GrandTotal.Location = New System.Drawing.Point(787, 554)
        Me.lbl_GrandTotal.Name = "lbl_GrandTotal"
        Me.lbl_GrandTotal.Size = New System.Drawing.Size(79, 15)
        Me.lbl_GrandTotal.TabIndex = 10
        Me.lbl_GrandTotal.Text = "0"
        Me.lbl_GrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(631, 573)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 15)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "TOTAL DISCOUNT"
        '
        'lbl_Discount
        '
        Me.lbl_Discount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Discount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Discount.ForeColor = System.Drawing.Color.Black
        Me.lbl_Discount.Location = New System.Drawing.Point(787, 573)
        Me.lbl_Discount.Name = "lbl_Discount"
        Me.lbl_Discount.Size = New System.Drawing.Size(79, 15)
        Me.lbl_Discount.TabIndex = 10
        Me.lbl_Discount.Text = "0"
        Me.lbl_Discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.ForeColor = System.Drawing.Color.Black
        Me.lbl_Status.Location = New System.Drawing.Point(6, 114)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(63, 18)
        Me.lbl_Status.TabIndex = 12
        Me.lbl_Status.Text = "CHECKER"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(306, 47)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 18)
        Me.Label24.TabIndex = 13
        Me.Label24.Text = "P.O. Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(306, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "APPROVER"
        '
        'txt_Approver
        '
        Me.txt_Approver.BackColor = System.Drawing.Color.White
        Me.txt_Approver.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Approver.Location = New System.Drawing.Point(398, 111)
        Me.txt_Approver.Name = "txt_Approver"
        Me.txt_Approver.ReadOnly = True
        Me.txt_Approver.Size = New System.Drawing.Size(149, 26)
        Me.txt_Approver.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(555, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 18)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "REMARKS"
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Remarks.BackColor = System.Drawing.Color.White
        Me.txt_Remarks.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Location = New System.Drawing.Point(647, 114)
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.ReadOnly = True
        Me.txt_Remarks.Size = New System.Drawing.Size(242, 58)
        Me.txt_Remarks.TabIndex = 11
        '
        'txt_Source
        '
        Me.txt_Source.Enabled = False
        Me.txt_Source.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Source.Location = New System.Drawing.Point(438, 283)
        Me.txt_Source.Name = "txt_Source"
        Me.txt_Source.Size = New System.Drawing.Size(182, 26)
        Me.txt_Source.TabIndex = 74
        Me.txt_Source.Text = "RECEIVING"
        '
        'lbl_TotalSum
        '
        Me.lbl_TotalSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalSum.AutoSize = True
        Me.lbl_TotalSum.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalSum.ForeColor = System.Drawing.Color.White
        Me.lbl_TotalSum.Location = New System.Drawing.Point(852, 336)
        Me.lbl_TotalSum.Name = "lbl_TotalSum"
        Me.lbl_TotalSum.Size = New System.Drawing.Size(31, 15)
        Me.lbl_TotalSum.TabIndex = 75
        Me.lbl_TotalSum.Text = "0.00"
        Me.lbl_TotalSum.Visible = False
        '
        'lbl_TotalLess
        '
        Me.lbl_TotalLess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalLess.AutoSize = True
        Me.lbl_TotalLess.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalLess.ForeColor = System.Drawing.Color.White
        Me.lbl_TotalLess.Location = New System.Drawing.Point(852, 361)
        Me.lbl_TotalLess.Name = "lbl_TotalLess"
        Me.lbl_TotalLess.Size = New System.Drawing.Size(31, 15)
        Me.lbl_TotalLess.TabIndex = 76
        Me.lbl_TotalLess.Text = "0.00"
        Me.lbl_TotalLess.Visible = False
        '
        'lbl_VATLess
        '
        Me.lbl_VATLess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_VATLess.AutoSize = True
        Me.lbl_VATLess.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VATLess.ForeColor = System.Drawing.Color.White
        Me.lbl_VATLess.Location = New System.Drawing.Point(852, 388)
        Me.lbl_VATLess.Name = "lbl_VATLess"
        Me.lbl_VATLess.Size = New System.Drawing.Size(14, 15)
        Me.lbl_VATLess.TabIndex = 77
        Me.lbl_VATLess.Text = "0"
        Me.lbl_VATLess.Visible = False
        '
        'btn_Send
        '
        Me.btn_Send.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_Send.BackColor = System.Drawing.Color.White
        Me.btn_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Send.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Send.Image = CType(resources.GetObject("btn_Send.Image"), System.Drawing.Image)
        Me.btn_Send.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Send.Location = New System.Drawing.Point(9, 532)
        Me.btn_Send.Name = "btn_Send"
        Me.btn_Send.Size = New System.Drawing.Size(122, 56)
        Me.btn_Send.TabIndex = 13
        Me.btn_Send.Text = "SEND"
        Me.btn_Send.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Send.UseVisualStyleBackColor = False
        '
        'btn_Add_SPA
        '
        Me.btn_Add_SPA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Add_SPA.BackColor = System.Drawing.Color.Teal
        Me.btn_Add_SPA.BackgroundImage = CType(resources.GetObject("btn_Add_SPA.BackgroundImage"), System.Drawing.Image)
        Me.btn_Add_SPA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Add_SPA.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add_SPA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Add_SPA.Location = New System.Drawing.Point(787, 14)
        Me.btn_Add_SPA.Name = "btn_Add_SPA"
        Me.btn_Add_SPA.Size = New System.Drawing.Size(102, 94)
        Me.btn_Add_SPA.TabIndex = 12
        Me.btn_Add_SPA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Add_SPA.UseVisualStyleBackColor = False
        '
        'btn_Vendor
        '
        Me.btn_Vendor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_Vendor.BackColor = System.Drawing.Color.White
        Me.btn_Vendor.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Vendor.Image = CType(resources.GetObject("btn_Vendor.Image"), System.Drawing.Image)
        Me.btn_Vendor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Vendor.Location = New System.Drawing.Point(440, 11)
        Me.btn_Vendor.Name = "btn_Vendor"
        Me.btn_Vendor.Size = New System.Drawing.Size(107, 30)
        Me.btn_Vendor.TabIndex = 1
        Me.btn_Vendor.Text = "Vendor"
        Me.btn_Vendor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Vendor.UseVisualStyleBackColor = False
        '
        'SPA_Receiving
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(895, 593)
        Me.Controls.Add(Me.lvParts)
        Me.Controls.Add(Me.lbl_VATLess)
        Me.Controls.Add(Me.lbl_TotalLess)
        Me.Controls.Add(Me.lbl_TotalSum)
        Me.Controls.Add(Me.txt_Source)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Remarks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Approver)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.lbl_Discount)
        Me.Controls.Add(Me.lbl_GrandTotal)
        Me.Controls.Add(Me.lbl_Less)
        Me.Controls.Add(Me.lbl_SubTotal)
        Me.Controls.Add(Me.lbl_Count)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_Send)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_Add_SPA)
        Me.Controls.Add(Me.dtp_Date)
        Me.Controls.Add(Me.cmb_WhCategory)
        Me.Controls.Add(Me.btn_Vendor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Note)
        Me.Controls.Add(Me.txt_POno)
        Me.Controls.Add(Me.txt_WhCode)
        Me.Controls.Add(Me.txt_RefNo)
        Me.Controls.Add(Me.txt_Checker)
        Me.Controls.Add(Me.txt_Status)
        Me.Controls.Add(Me.txt_Vendor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SPA_Receiving"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECEIVING INVENTORY"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvParts As ListView
    Friend WithEvents partsNumber As ColumnHeader
    Friend WithEvents Brand As ColumnHeader
    Friend WithEvents srp As ColumnHeader
    Friend WithEvents DiscountPCT As ColumnHeader
    Friend WithEvents DiscountAMT As ColumnHeader
    Friend WithEvents priceWVAT As ColumnHeader
    Friend WithEvents priceWOVAT As ColumnHeader
    Friend WithEvents modelCode As ColumnHeader
    Friend WithEvents modelName As ColumnHeader
    Friend WithEvents txt_Vendor As TextBox
    Friend WithEvents txt_Status As TextBox
    Friend WithEvents txt_RefNo As TextBox
    Friend WithEvents txt_Note As TextBox
    Friend WithEvents txt_Checker As TextBox
    Friend WithEvents txt_POno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_Vendor As Button
    Friend WithEvents txt_WhCode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_WhCategory As ComboBox
    Friend WithEvents dtp_Date As DateTimePicker
    Friend WithEvents btn_Add_SPA As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_Send As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_Count As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_SubTotal As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbl_Less As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbl_GrandTotal As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbl_Discount As Label
    Friend WithEvents lbl_Status As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents partsName As ColumnHeader
    Friend WithEvents quantity As ColumnHeader
    Friend WithEvents spCostWVAT As ColumnHeader
    Friend WithEvents spCostWoVAT As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Approver As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Remarks As TextBox
    Friend WithEvents txt_Source As TextBox
    Friend WithEvents sc_SpareParts As ColumnHeader
    Friend WithEvents subTotal As ColumnHeader
    Friend WithEvents lbl_TotalSum As Label
    Friend WithEvents lbl_TotalLess As Label
    Friend WithEvents lbl_VATLess As Label
    Friend WithEvents Category As ColumnHeader
    Friend WithEvents BinBox As ColumnHeader
End Class
