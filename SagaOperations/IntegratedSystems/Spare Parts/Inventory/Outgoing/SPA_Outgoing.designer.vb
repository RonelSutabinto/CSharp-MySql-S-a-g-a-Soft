<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SPA_Outgoing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPA_Outgoing))
        Me.lbl_Count = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lvParts = New System.Windows.Forms.ListView()
        Me.partsNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partsName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sc_SpareParts = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.totals = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.transactedBy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.prev_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.subTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BinBox = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_RBranch = New System.Windows.Forms.TextBox()
        Me.dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.cmb_WHCategory = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_BrCode = New System.Windows.Forms.TextBox()
        Me.txt_Status = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_RefNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_PONo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Approver = New System.Windows.Forms.TextBox()
        Me.txt_WHCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Note = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Remarks = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Source = New System.Windows.Forms.TextBox()
        Me.lbl_TotalLess = New System.Windows.Forms.Label()
        Me.lbl_TotalSum = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_GrandTotal = New System.Windows.Forms.Label()
        Me.lbl_Less = New System.Windows.Forms.Label()
        Me.lbl_SubTotal = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_Partsman = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Branch = New System.Windows.Forms.Button()
        Me.btn_Send = New System.Windows.Forms.Button()
        Me.txt_error = New System.Windows.Forms.Label()
        Me.txt_Code = New System.Windows.Forms.TextBox()
        CType(Me.cmb_Partsman.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Count
        '
        Me.lbl_Count.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Count.AutoSize = True
        Me.lbl_Count.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Count.ForeColor = System.Drawing.Color.Black
        Me.lbl_Count.Location = New System.Drawing.Point(502, 552)
        Me.lbl_Count.Name = "lbl_Count"
        Me.lbl_Count.Size = New System.Drawing.Size(20, 23)
        Me.lbl_Count.TabIndex = 103
        Me.lbl_Count.Text = "0"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(302, 552)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 23)
        Me.Label12.TabIndex = 94
        Me.Label12.Text = "ITEM COUNT"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 522)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(209, 14)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "Double click item on the table to remove."
        '
        'lvParts
        '
        Me.lvParts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.partsNumber, Me.partsName, Me.Brand, Me.sc_SpareParts, Me.srp, Me.quantity, Me.spCostWoVAT, Me.spCostWVAT, Me.DiscountPCT, Me.DiscountAMT, Me.priceWVAT, Me.priceWOVAT, Me.modelCode, Me.modelName, Me.totals, Me.transactedBy, Me.prev_ID, Me.subTotal, Me.Category, Me.BinBox})
        Me.lvParts.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvParts.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lvParts.FullRowSelect = True
        Me.lvParts.GridLines = True
        Me.lvParts.HoverSelection = True
        Me.lvParts.Location = New System.Drawing.Point(10, 180)
        Me.lvParts.Name = "lvParts"
        Me.lvParts.Size = New System.Drawing.Size(877, 337)
        Me.lvParts.TabIndex = 74
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
        Me.Brand.Text = "Brand"
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
        'totals
        '
        Me.totals.Text = "Total Quantity"
        Me.totals.Width = 0
        '
        'transactedBy
        '
        Me.transactedBy.Text = "Transacted By"
        Me.transactedBy.Width = 0
        '
        'prev_ID
        '
        Me.prev_ID.Text = "prev_ID"
        Me.prev_ID.Width = 40
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
        'txt_RBranch
        '
        Me.txt_RBranch.AccessibleDescription = "f"
        Me.txt_RBranch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_RBranch.BackColor = System.Drawing.Color.White
        Me.txt_RBranch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RBranch.Location = New System.Drawing.Point(105, 16)
        Me.txt_RBranch.Name = "txt_RBranch"
        Me.txt_RBranch.ReadOnly = True
        Me.txt_RBranch.Size = New System.Drawing.Size(231, 26)
        Me.txt_RBranch.TabIndex = 0
        '
        'dtp_Date
        '
        Me.dtp_Date.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dtp_Date.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Date.Location = New System.Drawing.Point(605, 48)
        Me.dtp_Date.Name = "dtp_Date"
        Me.dtp_Date.Size = New System.Drawing.Size(158, 26)
        Me.dtp_Date.TabIndex = 6
        '
        'cmb_WHCategory
        '
        Me.cmb_WHCategory.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_WHCategory.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_WHCategory.FormattingEnabled = True
        Me.cmb_WHCategory.Items.AddRange(New Object() {"BRAND NEW", "OLD"})
        Me.cmb_WHCategory.Location = New System.Drawing.Point(605, 80)
        Me.cmb_WHCategory.Name = "cmb_WHCategory"
        Me.cmb_WHCategory.Size = New System.Drawing.Size(103, 26)
        Me.cmb_WHCategory.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 41)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "RECEIVING BRANCH"
        '
        'txt_BrCode
        '
        Me.txt_BrCode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_BrCode.BackColor = System.Drawing.Color.White
        Me.txt_BrCode.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BrCode.Location = New System.Drawing.Point(342, 16)
        Me.txt_BrCode.Name = "txt_BrCode"
        Me.txt_BrCode.ReadOnly = True
        Me.txt_BrCode.Size = New System.Drawing.Size(71, 26)
        Me.txt_BrCode.TabIndex = 1
        '
        'txt_Status
        '
        Me.txt_Status.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_Status.BackColor = System.Drawing.Color.White
        Me.txt_Status.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Status.Location = New System.Drawing.Point(605, 16)
        Me.txt_Status.Name = "txt_Status"
        Me.txt_Status.ReadOnly = True
        Me.txt_Status.Size = New System.Drawing.Size(158, 26)
        Me.txt_Status.TabIndex = 3
        Me.txt_Status.Text = "For Transport"
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(515, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 22)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "STATUS"
        '
        'txt_RefNo
        '
        Me.txt_RefNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_RefNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RefNo.Location = New System.Drawing.Point(105, 48)
        Me.txt_RefNo.Name = "txt_RefNo"
        Me.txt_RefNo.ReadOnly = True
        Me.txt_RefNo.Size = New System.Drawing.Size(147, 26)
        Me.txt_RefNo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "REF No."
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(258, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PO No."
        '
        'txt_PONo
        '
        Me.txt_PONo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_PONo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PONo.Location = New System.Drawing.Point(342, 49)
        Me.txt_PONo.Name = "txt_PONo"
        Me.txt_PONo.ReadOnly = True
        Me.txt_PONo.Size = New System.Drawing.Size(161, 26)
        Me.txt_PONo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(257, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "PARTSMAN"
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "APPROVER"
        '
        'txt_Approver
        '
        Me.txt_Approver.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_Approver.BackColor = System.Drawing.Color.White
        Me.txt_Approver.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Approver.Location = New System.Drawing.Point(105, 80)
        Me.txt_Approver.Name = "txt_Approver"
        Me.txt_Approver.ReadOnly = True
        Me.txt_Approver.Size = New System.Drawing.Size(147, 26)
        Me.txt_Approver.TabIndex = 7
        '
        'txt_WHCode
        '
        Me.txt_WHCode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_WHCode.BackColor = System.Drawing.Color.White
        Me.txt_WHCode.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_WHCode.Location = New System.Drawing.Point(715, 80)
        Me.txt_WHCode.Name = "txt_WHCode"
        Me.txt_WHCode.ReadOnly = True
        Me.txt_WHCode.Size = New System.Drawing.Size(60, 26)
        Me.txt_WHCode.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(514, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "WARE HOUSE"
        '
        'Label7
        '
        Me.Label7.AllowDrop = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "NOTE"
        '
        'txt_Note
        '
        Me.txt_Note.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Note.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Note.Location = New System.Drawing.Point(105, 112)
        Me.txt_Note.Name = "txt_Note"
        Me.txt_Note.Size = New System.Drawing.Size(782, 26)
        Me.txt_Note.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AllowDrop = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "REMARKS"
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Remarks.BackColor = System.Drawing.Color.White
        Me.txt_Remarks.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Location = New System.Drawing.Point(105, 144)
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.ReadOnly = True
        Me.txt_Remarks.Size = New System.Drawing.Size(782, 26)
        Me.txt_Remarks.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AllowDrop = True
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(514, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 22)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "DATE"
        '
        'txt_Source
        '
        Me.txt_Source.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Source.Location = New System.Drawing.Point(439, 283)
        Me.txt_Source.Name = "txt_Source"
        Me.txt_Source.Size = New System.Drawing.Size(181, 26)
        Me.txt_Source.TabIndex = 129
        Me.txt_Source.Text = "OUTGOING"
        '
        'lbl_TotalLess
        '
        Me.lbl_TotalLess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalLess.AutoSize = True
        Me.lbl_TotalLess.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalLess.ForeColor = System.Drawing.Color.White
        Me.lbl_TotalLess.Location = New System.Drawing.Point(834, 289)
        Me.lbl_TotalLess.Name = "lbl_TotalLess"
        Me.lbl_TotalLess.Size = New System.Drawing.Size(31, 15)
        Me.lbl_TotalLess.TabIndex = 131
        Me.lbl_TotalLess.Text = "0.00"
        '
        'lbl_TotalSum
        '
        Me.lbl_TotalSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalSum.AutoSize = True
        Me.lbl_TotalSum.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalSum.ForeColor = System.Drawing.Color.White
        Me.lbl_TotalSum.Location = New System.Drawing.Point(834, 264)
        Me.lbl_TotalSum.Name = "lbl_TotalSum"
        Me.lbl_TotalSum.Size = New System.Drawing.Size(31, 15)
        Me.lbl_TotalSum.TabIndex = 130
        Me.lbl_TotalSum.Text = "0.00"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label21.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(785, 584)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 18)
        Me.Label21.TabIndex = 132
        Me.Label21.Text = "0.00"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_GrandTotal
        '
        Me.lbl_GrandTotal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_GrandTotal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GrandTotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_GrandTotal.Location = New System.Drawing.Point(785, 564)
        Me.lbl_GrandTotal.Name = "lbl_GrandTotal"
        Me.lbl_GrandTotal.Size = New System.Drawing.Size(82, 18)
        Me.lbl_GrandTotal.TabIndex = 133
        Me.lbl_GrandTotal.Text = "0.00"
        Me.lbl_GrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Less
        '
        Me.lbl_Less.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Less.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Less.ForeColor = System.Drawing.Color.Black
        Me.lbl_Less.Location = New System.Drawing.Point(785, 544)
        Me.lbl_Less.Name = "lbl_Less"
        Me.lbl_Less.Size = New System.Drawing.Size(82, 18)
        Me.lbl_Less.TabIndex = 134
        Me.lbl_Less.Text = "0.00"
        Me.lbl_Less.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_SubTotal
        '
        Me.lbl_SubTotal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_SubTotal.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_SubTotal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubTotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_SubTotal.Location = New System.Drawing.Point(785, 524)
        Me.lbl_SubTotal.Name = "lbl_SubTotal"
        Me.lbl_SubTotal.Size = New System.Drawing.Size(82, 18)
        Me.lbl_SubTotal.TabIndex = 135
        Me.lbl_SubTotal.Text = "0.00"
        Me.lbl_SubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(613, 584)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(166, 18)
        Me.Label20.TabIndex = 136
        Me.Label20.Text = "TOTAL SPARE PARTS PRICE"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(613, 564)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 18)
        Me.Label18.TabIndex = 137
        Me.Label18.Text = "GRAND TOTAL"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(613, 544)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 18)
        Me.Label16.TabIndex = 138
        Me.Label16.Text = "TOTAL VAT AMT"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Gainsboro
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(613, 524)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 18)
        Me.Label14.TabIndex = 139
        Me.Label14.Text = "TOTAL UNIT COST"
        '
        'cmb_Partsman
        '
        Me.cmb_Partsman.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_Partsman.Location = New System.Drawing.Point(342, 80)
        Me.cmb_Partsman.Name = "cmb_Partsman"
        Me.cmb_Partsman.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Partsman.Properties.Appearance.Options.UseFont = True
        Me.cmb_Partsman.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Partsman.Size = New System.Drawing.Size(161, 26)
        Me.cmb_Partsman.TabIndex = 141
        '
        'btn_Add
        '
        Me.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_Add.BackColor = System.Drawing.Color.Teal
        Me.btn_Add.BackgroundImage = CType(resources.GetObject("btn_Add.BackgroundImage"), System.Drawing.Image)
        Me.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Add.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(784, 16)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(103, 90)
        Me.btn_Add.TabIndex = 13
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'btn_Branch
        '
        Me.btn_Branch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_Branch.BackColor = System.Drawing.Color.White
        Me.btn_Branch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Branch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Branch.Image = CType(resources.GetObject("btn_Branch.Image"), System.Drawing.Image)
        Me.btn_Branch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Branch.Location = New System.Drawing.Point(419, 16)
        Me.btn_Branch.Name = "btn_Branch"
        Me.btn_Branch.Size = New System.Drawing.Size(84, 26)
        Me.btn_Branch.TabIndex = 2
        Me.btn_Branch.Text = "Branch"
        Me.btn_Branch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Branch.UseVisualStyleBackColor = False
        '
        'btn_Send
        '
        Me.btn_Send.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_Send.BackColor = System.Drawing.Color.White
        Me.btn_Send.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Send.Image = CType(resources.GetObject("btn_Send.Image"), System.Drawing.Image)
        Me.btn_Send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Send.Location = New System.Drawing.Point(10, 542)
        Me.btn_Send.Name = "btn_Send"
        Me.btn_Send.Size = New System.Drawing.Size(103, 64)
        Me.btn_Send.TabIndex = 14
        Me.btn_Send.Text = "SEND"
        Me.btn_Send.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Send.UseVisualStyleBackColor = False
        '
        'txt_error
        '
        Me.txt_error.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_error.AutoSize = True
        Me.txt_error.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_error.ForeColor = System.Drawing.Color.White
        Me.txt_error.Location = New System.Drawing.Point(834, 237)
        Me.txt_error.Name = "txt_error"
        Me.txt_error.Size = New System.Drawing.Size(0, 15)
        Me.txt_error.TabIndex = 142
        '
        'txt_Code
        '
        Me.txt_Code.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_Code.BackColor = System.Drawing.Color.White
        Me.txt_Code.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Code.Location = New System.Drawing.Point(963, 144)
        Me.txt_Code.Name = "txt_Code"
        Me.txt_Code.ReadOnly = True
        Me.txt_Code.Size = New System.Drawing.Size(71, 26)
        Me.txt_Code.TabIndex = 143
        '
        'SPA_Outgoing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(899, 618)
        Me.Controls.Add(Me.txt_Code)
        Me.Controls.Add(Me.txt_error)
        Me.Controls.Add(Me.lvParts)
        Me.Controls.Add(Me.cmb_Partsman)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lbl_GrandTotal)
        Me.Controls.Add(Me.lbl_Less)
        Me.Controls.Add(Me.lbl_SubTotal)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbl_TotalLess)
        Me.Controls.Add(Me.lbl_TotalSum)
        Me.Controls.Add(Me.txt_Source)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_Remarks)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_Note)
        Me.Controls.Add(Me.txt_WHCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_Approver)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_PONo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_RefNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Status)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.txt_BrCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_Branch)
        Me.Controls.Add(Me.cmb_WHCategory)
        Me.Controls.Add(Me.dtp_Date)
        Me.Controls.Add(Me.txt_RBranch)
        Me.Controls.Add(Me.lbl_Count)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_Send)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(915, 535)
        Me.Name = "SPA_Outgoing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OUTGOING INVENTORY"
        CType(Me.cmb_Partsman.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Count As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_Send As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lvParts As ListView
    Friend WithEvents partsNumber As ColumnHeader
    Friend WithEvents partsName As ColumnHeader
    Friend WithEvents Brand As ColumnHeader
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
    Friend WithEvents txt_RBranch As TextBox
    Friend WithEvents dtp_Date As DateTimePicker
    Friend WithEvents cmb_WHCategory As ComboBox
    Friend WithEvents btn_Branch As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_BrCode As TextBox
    Friend WithEvents btn_Add As Button
    Friend WithEvents txt_Status As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_RefNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_PONo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Approver As TextBox
    Friend WithEvents txt_WHCode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_Note As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Remarks As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_Source As TextBox
    Friend WithEvents totals As ColumnHeader
    Friend WithEvents sc_SpareParts As ColumnHeader
    Friend WithEvents prev_ID As ColumnHeader
    Friend WithEvents transactedBy As ColumnHeader
    Friend WithEvents subTotal As ColumnHeader
    Friend WithEvents lbl_TotalLess As Label
    Friend WithEvents lbl_TotalSum As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lbl_GrandTotal As Label
    Friend WithEvents lbl_Less As Label
    Friend WithEvents lbl_SubTotal As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmb_Partsman As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Category As ColumnHeader
    Friend WithEvents BinBox As ColumnHeader
    Friend WithEvents txt_error As Label
    Friend WithEvents txt_Code As TextBox
End Class
