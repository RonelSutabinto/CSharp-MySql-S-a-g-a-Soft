<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPA_Checker_Approver_Receiving
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPA_Checker_Approver_Receiving))
        Me.lbl_Discount = New System.Windows.Forms.Label()
        Me.lbl_GrandTotal = New System.Windows.Forms.Label()
        Me.lbl_Less = New System.Windows.Forms.Label()
        Me.lbl_SubTotal = New System.Windows.Forms.Label()
        Me.lbl_Count = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Btn_DisApproved = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lvParts = New System.Windows.Forms.ListView()
        Me.partsNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partsName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.srp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.spCostWoVAT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.spCostWVAT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DiscountPCT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DiscountAMT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.priceWVAT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.priceWOVAT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.modelCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.modelName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.transactedBy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.prev_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.binBox = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_Approved = New System.Windows.Forms.Button()
        Me.lbl_Status1 = New System.Windows.Forms.Label()
        Me.txt_Approver = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.btn_Add_SPA = New System.Windows.Forms.Button()
        Me.dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.cmb_WhCategory = New System.Windows.Forms.ComboBox()
        Me.btn_Vendor = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Note = New System.Windows.Forms.TextBox()
        Me.txt_POno = New System.Windows.Forms.TextBox()
        Me.txt_WhCode = New System.Windows.Forms.TextBox()
        Me.txt_RefNo = New System.Windows.Forms.TextBox()
        Me.txt_Checker = New System.Windows.Forms.TextBox()
        Me.txt_Status = New System.Windows.Forms.TextBox()
        Me.txt_Vendor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Remarks = New System.Windows.Forms.TextBox()
        Me.txt_Source = New System.Windows.Forms.TextBox()
        Me.txt_BrCode = New System.Windows.Forms.TextBox()
        Me.btn_Print = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Discount
        '
        Me.lbl_Discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Discount.AutoSize = True
        Me.lbl_Discount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Discount.ForeColor = System.Drawing.Color.Black
        Me.lbl_Discount.Location = New System.Drawing.Point(945, 570)
        Me.lbl_Discount.Name = "lbl_Discount"
        Me.lbl_Discount.Size = New System.Drawing.Size(31, 15)
        Me.lbl_Discount.TabIndex = 45
        Me.lbl_Discount.Text = "0.00"
        '
        'lbl_GrandTotal
        '
        Me.lbl_GrandTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_GrandTotal.AutoSize = True
        Me.lbl_GrandTotal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GrandTotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_GrandTotal.Location = New System.Drawing.Point(945, 552)
        Me.lbl_GrandTotal.Name = "lbl_GrandTotal"
        Me.lbl_GrandTotal.Size = New System.Drawing.Size(31, 15)
        Me.lbl_GrandTotal.TabIndex = 44
        Me.lbl_GrandTotal.Text = "0.00"
        '
        'lbl_Less
        '
        Me.lbl_Less.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Less.AutoSize = True
        Me.lbl_Less.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Less.ForeColor = System.Drawing.Color.Black
        Me.lbl_Less.Location = New System.Drawing.Point(945, 534)
        Me.lbl_Less.Name = "lbl_Less"
        Me.lbl_Less.Size = New System.Drawing.Size(31, 15)
        Me.lbl_Less.TabIndex = 43
        Me.lbl_Less.Text = "0.00"
        '
        'lbl_SubTotal
        '
        Me.lbl_SubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_SubTotal.AutoSize = True
        Me.lbl_SubTotal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubTotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_SubTotal.Location = New System.Drawing.Point(945, 516)
        Me.lbl_SubTotal.Name = "lbl_SubTotal"
        Me.lbl_SubTotal.Size = New System.Drawing.Size(31, 15)
        Me.lbl_SubTotal.TabIndex = 42
        Me.lbl_SubTotal.Text = "0.00"
        '
        'lbl_Count
        '
        Me.lbl_Count.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Count.AutoSize = True
        Me.lbl_Count.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Count.ForeColor = System.Drawing.Color.Black
        Me.lbl_Count.Location = New System.Drawing.Point(593, 537)
        Me.lbl_Count.Name = "lbl_Count"
        Me.lbl_Count.Size = New System.Drawing.Size(20, 23)
        Me.lbl_Count.TabIndex = 41
        Me.lbl_Count.Text = "0"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(745, 570)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 15)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "TOTAL DISCOUNT"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(745, 552)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 15)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "GRAND TOTAL"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(745, 534)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 15)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "TOTAL VAT AMT"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(745, 516)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 15)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "TOTAL UNIT COST"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(393, 537)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 23)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "ITEM COUNT"
        '
        'Btn_DisApproved
        '
        Me.Btn_DisApproved.BackgroundImage = CType(resources.GetObject("Btn_DisApproved.BackgroundImage"), System.Drawing.Image)
        Me.Btn_DisApproved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_DisApproved.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_DisApproved.Location = New System.Drawing.Point(84, 533)
        Me.Btn_DisApproved.Name = "Btn_DisApproved"
        Me.Btn_DisApproved.Size = New System.Drawing.Size(65, 54)
        Me.Btn_DisApproved.TabIndex = 35
        Me.Btn_DisApproved.Tag = "Disapproved"
        Me.Btn_DisApproved.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 516)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(209, 14)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Double click item on the table to remove."
        '
        'lvParts
        '
        Me.lvParts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvParts.BackColor = System.Drawing.Color.White
        Me.lvParts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.partsNumber, Me.partsName, Me.brand, Me.srp, Me.quantity, Me.spCostWoVAT, Me.spCostWVAT, Me.DiscountPCT, Me.DiscountAMT, Me.priceWVAT, Me.priceWOVAT, Me.modelCode, Me.modelName, Me.transactedBy, Me.prev_ID, Me.category, Me.binBox})
        Me.lvParts.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvParts.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lvParts.FullRowSelect = True
        Me.lvParts.GridLines = True
        Me.lvParts.HoverSelection = True
        Me.lvParts.Location = New System.Drawing.Point(10, 176)
        Me.lvParts.Name = "lvParts"
        Me.lvParts.Size = New System.Drawing.Size(1042, 333)
        Me.lvParts.TabIndex = 14
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
        'brand
        '
        Me.brand.Text = "BRAND"
        Me.brand.Width = 150
        '
        'srp
        '
        Me.srp.Text = "SRP"
        Me.srp.Width = 150
        '
        'quantity
        '
        Me.quantity.Text = "QUANTITY"
        Me.quantity.Width = 100
        '
        'spCostWoVAT
        '
        Me.spCostWoVAT.Text = "COST WOVAT"
        Me.spCostWoVAT.Width = 140
        '
        'spCostWVAT
        '
        Me.spCostWVAT.Text = "COST WVAT"
        Me.spCostWVAT.Width = 140
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
        'transactedBy
        '
        Me.transactedBy.Text = "Transacted By"
        '
        'prev_ID
        '
        Me.prev_ID.Text = "prev_ID"
        '
        'category
        '
        Me.category.Text = "CATEGORY"
        '
        'binBox
        '
        Me.binBox.Text = "BIN BOX"
        '
        'btn_Approved
        '
        Me.btn_Approved.BackgroundImage = CType(resources.GetObject("btn_Approved.BackgroundImage"), System.Drawing.Image)
        Me.btn_Approved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Approved.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Approved.Location = New System.Drawing.Point(14, 533)
        Me.btn_Approved.Name = "btn_Approved"
        Me.btn_Approved.Size = New System.Drawing.Size(65, 54)
        Me.btn_Approved.TabIndex = 48
        Me.btn_Approved.Tag = "Approved"
        Me.btn_Approved.UseVisualStyleBackColor = True
        '
        'lbl_Status1
        '
        Me.lbl_Status1.AutoSize = True
        Me.lbl_Status1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status1.ForeColor = System.Drawing.Color.Black
        Me.lbl_Status1.Location = New System.Drawing.Point(383, 118)
        Me.lbl_Status1.Name = "lbl_Status1"
        Me.lbl_Status1.Size = New System.Drawing.Size(75, 18)
        Me.lbl_Status1.TabIndex = 69
        Me.lbl_Status1.Text = "APPROVER"
        '
        'txt_Approver
        '
        Me.txt_Approver.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_Approver.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Approver.Location = New System.Drawing.Point(475, 112)
        Me.txt_Approver.Name = "txt_Approver"
        Me.txt_Approver.ReadOnly = True
        Me.txt_Approver.Size = New System.Drawing.Size(221, 26)
        Me.txt_Approver.TabIndex = 68
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(383, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 18)
        Me.Label24.TabIndex = 67
        Me.Label24.Text = "P.O. Number"
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.ForeColor = System.Drawing.Color.Black
        Me.lbl_Status.Location = New System.Drawing.Point(9, 115)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(63, 18)
        Me.lbl_Status.TabIndex = 66
        Me.lbl_Status.Text = "CHECKER"
        '
        'btn_Add_SPA
        '
        Me.btn_Add_SPA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Add_SPA.BackColor = System.Drawing.Color.White
        Me.btn_Add_SPA.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add_SPA.Location = New System.Drawing.Point(920, 6)
        Me.btn_Add_SPA.Name = "btn_Add_SPA"
        Me.btn_Add_SPA.Size = New System.Drawing.Size(132, 102)
        Me.btn_Add_SPA.TabIndex = 65
        Me.btn_Add_SPA.Text = "SHOW Spare Parts Here"
        Me.btn_Add_SPA.UseVisualStyleBackColor = False
        '
        'dtp_Date
        '
        Me.dtp_Date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_Date.CalendarMonthBackground = System.Drawing.Color.Gainsboro
        Me.dtp_Date.Enabled = False
        Me.dtp_Date.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Date.Location = New System.Drawing.Point(802, 13)
        Me.dtp_Date.Name = "dtp_Date"
        Me.dtp_Date.Size = New System.Drawing.Size(112, 26)
        Me.dtp_Date.TabIndex = 64
        '
        'cmb_WhCategory
        '
        Me.cmb_WhCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_WhCategory.BackColor = System.Drawing.Color.Gainsboro
        Me.cmb_WhCategory.Enabled = False
        Me.cmb_WhCategory.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_WhCategory.FormattingEnabled = True
        Me.cmb_WhCategory.Items.AddRange(New Object() {"BRAND NEW", "OLD"})
        Me.cmb_WhCategory.Location = New System.Drawing.Point(802, 46)
        Me.cmb_WhCategory.Name = "cmb_WhCategory"
        Me.cmb_WhCategory.Size = New System.Drawing.Size(112, 26)
        Me.cmb_WhCategory.TabIndex = 63
        '
        'btn_Vendor
        '
        Me.btn_Vendor.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Vendor.Location = New System.Drawing.Point(648, 10)
        Me.btn_Vendor.Name = "btn_Vendor"
        Me.btn_Vendor.Size = New System.Drawing.Size(48, 30)
        Me.btn_Vendor.TabIndex = 62
        Me.btn_Vendor.Text = "Click"
        Me.btn_Vendor.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "NOTE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 18)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "REFERENCE No."
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(745, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 41)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "WARE HOUSE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(757, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 18)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "DATE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "STATUS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 18)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "BRANCH / VENDOR"
        '
        'txt_Note
        '
        Me.txt_Note.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_Note.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Note.Location = New System.Drawing.Point(146, 144)
        Me.txt_Note.Name = "txt_Note"
        Me.txt_Note.ReadOnly = True
        Me.txt_Note.Size = New System.Drawing.Size(550, 26)
        Me.txt_Note.TabIndex = 54
        '
        'txt_POno
        '
        Me.txt_POno.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_POno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_POno.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POno.Location = New System.Drawing.Point(475, 45)
        Me.txt_POno.Name = "txt_POno"
        Me.txt_POno.ReadOnly = True
        Me.txt_POno.Size = New System.Drawing.Size(221, 26)
        Me.txt_POno.TabIndex = 53
        '
        'txt_WhCode
        '
        Me.txt_WhCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_WhCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_WhCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_WhCode.Enabled = False
        Me.txt_WhCode.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_WhCode.Location = New System.Drawing.Point(801, 79)
        Me.txt_WhCode.Name = "txt_WhCode"
        Me.txt_WhCode.Size = New System.Drawing.Size(113, 26)
        Me.txt_WhCode.TabIndex = 52
        '
        'txt_RefNo
        '
        Me.txt_RefNo.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_RefNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_RefNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RefNo.Location = New System.Drawing.Point(146, 45)
        Me.txt_RefNo.Name = "txt_RefNo"
        Me.txt_RefNo.ReadOnly = True
        Me.txt_RefNo.Size = New System.Drawing.Size(231, 26)
        Me.txt_RefNo.TabIndex = 51
        '
        'txt_Checker
        '
        Me.txt_Checker.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_Checker.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Checker.Location = New System.Drawing.Point(146, 112)
        Me.txt_Checker.Name = "txt_Checker"
        Me.txt_Checker.ReadOnly = True
        Me.txt_Checker.Size = New System.Drawing.Size(231, 26)
        Me.txt_Checker.TabIndex = 50
        '
        'txt_Status
        '
        Me.txt_Status.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_Status.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Status.Location = New System.Drawing.Point(146, 78)
        Me.txt_Status.Name = "txt_Status"
        Me.txt_Status.ReadOnly = True
        Me.txt_Status.Size = New System.Drawing.Size(550, 26)
        Me.txt_Status.TabIndex = 55
        '
        'txt_Vendor
        '
        Me.txt_Vendor.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_Vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Vendor.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Vendor.Location = New System.Drawing.Point(146, 12)
        Me.txt_Vendor.Name = "txt_Vendor"
        Me.txt_Vendor.ReadOnly = True
        Me.txt_Vendor.Size = New System.Drawing.Size(496, 26)
        Me.txt_Vendor.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(727, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 18)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "REMARKS"
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Remarks.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Location = New System.Drawing.Point(801, 112)
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(251, 58)
        Me.txt_Remarks.TabIndex = 70
        '
        'txt_Source
        '
        Me.txt_Source.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Source.Location = New System.Drawing.Point(438, 283)
        Me.txt_Source.Name = "txt_Source"
        Me.txt_Source.ReadOnly = True
        Me.txt_Source.Size = New System.Drawing.Size(182, 26)
        Me.txt_Source.TabIndex = 72
        '
        'txt_BrCode
        '
        Me.txt_BrCode.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BrCode.Location = New System.Drawing.Point(438, 315)
        Me.txt_BrCode.Name = "txt_BrCode"
        Me.txt_BrCode.ReadOnly = True
        Me.txt_BrCode.Size = New System.Drawing.Size(85, 26)
        Me.txt_BrCode.TabIndex = 73
        '
        'btn_Print
        '
        Me.btn_Print.BackgroundImage = CType(resources.GetObject("btn_Print.BackgroundImage"), System.Drawing.Image)
        Me.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Print.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Print.Location = New System.Drawing.Point(14, 534)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.Size = New System.Drawing.Size(65, 54)
        Me.btn_Print.TabIndex = 74
        Me.btn_Print.Tag = "Approved"
        Me.btn_Print.UseVisualStyleBackColor = True
        '
        'SPA_Checker_Approver_Receiving
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1058, 593)
        Me.Controls.Add(Me.lvParts)
        Me.Controls.Add(Me.txt_BrCode)
        Me.Controls.Add(Me.txt_Source)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Remarks)
        Me.Controls.Add(Me.lbl_Status1)
        Me.Controls.Add(Me.txt_Approver)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lbl_Status)
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
        Me.Controls.Add(Me.Btn_DisApproved)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_Approved)
        Me.Controls.Add(Me.btn_Print)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1074, 632)
        Me.Name = "SPA_Checker_Approver_Receiving"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECEIVING INVENTORY"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Discount As Label
    Friend WithEvents lbl_GrandTotal As Label
    Friend WithEvents lbl_Less As Label
    Friend WithEvents lbl_SubTotal As Label
    Friend WithEvents lbl_Count As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Btn_DisApproved As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lvParts As ListView
    Friend WithEvents partsNumber As ColumnHeader
    Friend WithEvents partsName As ColumnHeader
    Friend WithEvents brand As ColumnHeader
    Friend WithEvents srp As ColumnHeader
    Friend WithEvents DiscountPCT As ColumnHeader
    Friend WithEvents DiscountAMT As ColumnHeader
    Friend WithEvents priceWVAT As ColumnHeader
    Friend WithEvents priceWOVAT As ColumnHeader
    Friend WithEvents modelCode As ColumnHeader
    Friend WithEvents modelName As ColumnHeader
    Friend WithEvents quantity As ColumnHeader
    Friend WithEvents spCostWVAT As ColumnHeader
    Friend WithEvents spCostWoVAT As ColumnHeader
    Friend WithEvents btn_Approved As Button
    Friend WithEvents lbl_Status1 As Label
    Friend WithEvents txt_Approver As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents lbl_Status As Label
    Friend WithEvents btn_Add_SPA As Button
    Friend WithEvents dtp_Date As DateTimePicker
    Friend WithEvents cmb_WhCategory As ComboBox
    Friend WithEvents btn_Vendor As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Note As TextBox
    Friend WithEvents txt_POno As TextBox
    Friend WithEvents txt_WhCode As TextBox
    Friend WithEvents txt_RefNo As TextBox
    Friend WithEvents txt_Checker As TextBox
    Friend WithEvents txt_Status As TextBox
    Friend WithEvents txt_Vendor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Remarks As TextBox
    Friend WithEvents txt_Source As TextBox
    Friend WithEvents txt_BrCode As TextBox
    Friend WithEvents transactedBy As ColumnHeader
    Friend WithEvents prev_ID As ColumnHeader
    Friend WithEvents btn_Print As Button
    Friend WithEvents category As ColumnHeader
    Friend WithEvents binBox As ColumnHeader
End Class
