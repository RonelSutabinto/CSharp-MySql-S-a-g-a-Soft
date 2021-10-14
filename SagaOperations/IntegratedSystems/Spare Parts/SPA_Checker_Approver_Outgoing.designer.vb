<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SPA_Checker_Approver_Outgoing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPA_Checker_Approver_Outgoing))
        Me.txt_Source = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Remarks = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Note = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_WHCode = New System.Windows.Forms.TextBox()
        Me.lbl_Partsman = New System.Windows.Forms.Label()
        Me.lbl_Approver = New System.Windows.Forms.Label()
        Me.txt_Approver = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_RefNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Status = New System.Windows.Forms.TextBox()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.txt_BrCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_Branch = New System.Windows.Forms.Button()
        Me.cmb_WHCategory = New System.Windows.Forms.ComboBox()
        Me.dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.txt_RBranch = New System.Windows.Forms.TextBox()
        Me.totals = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvParts = New System.Windows.Forms.ListView()
        Me.partsNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partsName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.transactedby = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.subTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.binBox = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_GrandTotal = New System.Windows.Forms.Label()
        Me.lbl_Less = New System.Windows.Forms.Label()
        Me.lbl_SubTotal = New System.Windows.Forms.Label()
        Me.lbl_Count = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_Approved = New System.Windows.Forms.Button()
        Me.Btn_DisApproved = New System.Windows.Forms.Button()
        Me.btn_Print = New System.Windows.Forms.Button()
        Me.txt_PONo = New System.Windows.Forms.TextBox()
        Me.txt_Partsman = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_Source
        '
        Me.txt_Source.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Source.Location = New System.Drawing.Point(438, 281)
        Me.txt_Source.Name = "txt_Source"
        Me.txt_Source.ReadOnly = True
        Me.txt_Source.Size = New System.Drawing.Size(181, 26)
        Me.txt_Source.TabIndex = 166
        '
        'Label11
        '
        Me.Label11.AllowDrop = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(696, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 22)
        Me.Label11.TabIndex = 148
        Me.Label11.Text = "DATE"
        '
        'Label8
        '
        Me.Label8.AllowDrop = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(17, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 23)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "REMARKS"
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Remarks.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Location = New System.Drawing.Point(104, 142)
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(947, 26)
        Me.txt_Remarks.TabIndex = 145
        '
        'Label7
        '
        Me.Label7.AllowDrop = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(17, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 23)
        Me.Label7.TabIndex = 142
        Me.Label7.Text = "NOTE"
        '
        'txt_Note
        '
        Me.txt_Note.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Note.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_Note.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Note.Location = New System.Drawing.Point(104, 110)
        Me.txt_Note.Name = "txt_Note"
        Me.txt_Note.ReadOnly = True
        Me.txt_Note.Size = New System.Drawing.Size(947, 26)
        Me.txt_Note.TabIndex = 143
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(696, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 36)
        Me.Label6.TabIndex = 150
        Me.Label6.Text = "WARE HOUSE"
        '
        'txt_WHCode
        '
        Me.txt_WHCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_WHCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_WHCode.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_WHCode.Location = New System.Drawing.Point(858, 78)
        Me.txt_WHCode.Name = "txt_WHCode"
        Me.txt_WHCode.ReadOnly = True
        Me.txt_WHCode.Size = New System.Drawing.Size(60, 26)
        Me.txt_WHCode.TabIndex = 152
        '
        'lbl_Partsman
        '
        Me.lbl_Partsman.AllowDrop = True
        Me.lbl_Partsman.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Partsman.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_Partsman.Location = New System.Drawing.Point(345, 81)
        Me.lbl_Partsman.Name = "lbl_Partsman"
        Me.lbl_Partsman.Size = New System.Drawing.Size(79, 23)
        Me.lbl_Partsman.TabIndex = 140
        Me.lbl_Partsman.Text = "PARTSMAN"
        '
        'lbl_Approver
        '
        Me.lbl_Approver.AllowDrop = True
        Me.lbl_Approver.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Approver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_Approver.Location = New System.Drawing.Point(11, 81)
        Me.lbl_Approver.Name = "lbl_Approver"
        Me.lbl_Approver.Size = New System.Drawing.Size(80, 23)
        Me.lbl_Approver.TabIndex = 138
        Me.lbl_Approver.Text = "APPROVER"
        '
        'txt_Approver
        '
        Me.txt_Approver.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_Approver.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Approver.Location = New System.Drawing.Point(104, 78)
        Me.txt_Approver.Name = "txt_Approver"
        Me.txt_Approver.ReadOnly = True
        Me.txt_Approver.Size = New System.Drawing.Size(232, 26)
        Me.txt_Approver.TabIndex = 139
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(360, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 23)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "PO No."
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(11, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "REF No."
        '
        'txt_RefNo
        '
        Me.txt_RefNo.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_RefNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RefNo.Location = New System.Drawing.Point(104, 46)
        Me.txt_RefNo.Name = "txt_RefNo"
        Me.txt_RefNo.ReadOnly = True
        Me.txt_RefNo.Size = New System.Drawing.Size(232, 26)
        Me.txt_RefNo.TabIndex = 135
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(696, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 22)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "STATUS"
        '
        'txt_Status
        '
        Me.txt_Status.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Status.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_Status.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Status.Location = New System.Drawing.Point(753, 14)
        Me.txt_Status.Name = "txt_Status"
        Me.txt_Status.ReadOnly = True
        Me.txt_Status.Size = New System.Drawing.Size(165, 26)
        Me.txt_Status.TabIndex = 147
        Me.txt_Status.Text = "For Transport"
        '
        'btn_Add
        '
        Me.btn_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Add.BackColor = System.Drawing.Color.White
        Me.btn_Add.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(924, 14)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(127, 90)
        Me.btn_Add.TabIndex = 153
        Me.btn_Add.Text = "ADD SPARE PARTS"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'txt_BrCode
        '
        Me.txt_BrCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_BrCode.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BrCode.Location = New System.Drawing.Point(547, 14)
        Me.txt_BrCode.Name = "txt_BrCode"
        Me.txt_BrCode.ReadOnly = True
        Me.txt_BrCode.Size = New System.Drawing.Size(72, 26)
        Me.txt_BrCode.TabIndex = 132
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(11, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 41)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "RECEIVING BRANCH"
        '
        'btn_Branch
        '
        Me.btn_Branch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Branch.Location = New System.Drawing.Point(622, 14)
        Me.btn_Branch.Name = "btn_Branch"
        Me.btn_Branch.Size = New System.Drawing.Size(46, 26)
        Me.btn_Branch.TabIndex = 133
        Me.btn_Branch.Text = "click"
        Me.btn_Branch.UseVisualStyleBackColor = True
        '
        'cmb_WHCategory
        '
        Me.cmb_WHCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_WHCategory.BackColor = System.Drawing.Color.Gainsboro
        Me.cmb_WHCategory.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_WHCategory.FormattingEnabled = True
        Me.cmb_WHCategory.Items.AddRange(New Object() {"BRAND NEW", "OLD"})
        Me.cmb_WHCategory.Location = New System.Drawing.Point(769, 78)
        Me.cmb_WHCategory.Name = "cmb_WHCategory"
        Me.cmb_WHCategory.Size = New System.Drawing.Size(83, 26)
        Me.cmb_WHCategory.TabIndex = 151
        '
        'dtp_Date
        '
        Me.dtp_Date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_Date.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Date.Location = New System.Drawing.Point(779, 46)
        Me.dtp_Date.Name = "dtp_Date"
        Me.dtp_Date.Size = New System.Drawing.Size(139, 26)
        Me.dtp_Date.TabIndex = 149
        '
        'txt_RBranch
        '
        Me.txt_RBranch.AccessibleDescription = "f"
        Me.txt_RBranch.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_RBranch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RBranch.Location = New System.Drawing.Point(104, 14)
        Me.txt_RBranch.Name = "txt_RBranch"
        Me.txt_RBranch.ReadOnly = True
        Me.txt_RBranch.Size = New System.Drawing.Size(437, 26)
        Me.txt_RBranch.TabIndex = 131
        '
        'totals
        '
        Me.totals.Text = "Total Quantity"
        Me.totals.Width = 0
        '
        'lvParts
        '
        Me.lvParts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvParts.BackColor = System.Drawing.Color.White
        Me.lvParts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.partsNumber, Me.partsName, Me.brand, Me.sc_SpareParts, Me.srp, Me.quantity, Me.spCostWoVAT, Me.spCostWVAT, Me.DiscountPCT, Me.DiscountAMT, Me.priceWVAT, Me.priceWOVAT, Me.modelCode, Me.modelName, Me.totals, Me.id, Me.transactedby, Me.subTotal, Me.category, Me.binBox})
        Me.lvParts.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvParts.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lvParts.FullRowSelect = True
        Me.lvParts.GridLines = True
        Me.lvParts.HoverSelection = True
        Me.lvParts.Location = New System.Drawing.Point(9, 178)
        Me.lvParts.Name = "lvParts"
        Me.lvParts.Size = New System.Drawing.Size(1042, 333)
        Me.lvParts.TabIndex = 154
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
        'sc_SpareParts
        '
        Me.sc_SpareParts.Text = "SUPER CEEDING P/N"
        Me.sc_SpareParts.Width = 150
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
        'id
        '
        Me.id.Text = "ID"
        '
        'transactedby
        '
        Me.transactedby.Text = "Transacted By"
        '
        'subTotal
        '
        Me.subTotal.Text = "SUB TOTAL"
        '
        'category
        '
        Me.category.Text = "CATEGORY"
        '
        'binBox
        '
        Me.binBox.Text = "BIN BOX"
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(959, 568)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 15)
        Me.Label21.TabIndex = 157
        Me.Label21.Text = "0.00"
        '
        'lbl_GrandTotal
        '
        Me.lbl_GrandTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_GrandTotal.AutoSize = True
        Me.lbl_GrandTotal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GrandTotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_GrandTotal.Location = New System.Drawing.Point(959, 550)
        Me.lbl_GrandTotal.Name = "lbl_GrandTotal"
        Me.lbl_GrandTotal.Size = New System.Drawing.Size(31, 15)
        Me.lbl_GrandTotal.TabIndex = 160
        Me.lbl_GrandTotal.Text = "0.00"
        '
        'lbl_Less
        '
        Me.lbl_Less.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Less.AutoSize = True
        Me.lbl_Less.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Less.ForeColor = System.Drawing.Color.Black
        Me.lbl_Less.Location = New System.Drawing.Point(959, 532)
        Me.lbl_Less.Name = "lbl_Less"
        Me.lbl_Less.Size = New System.Drawing.Size(31, 15)
        Me.lbl_Less.TabIndex = 158
        Me.lbl_Less.Text = "0.00"
        '
        'lbl_SubTotal
        '
        Me.lbl_SubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_SubTotal.AutoSize = True
        Me.lbl_SubTotal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubTotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_SubTotal.Location = New System.Drawing.Point(959, 514)
        Me.lbl_SubTotal.Name = "lbl_SubTotal"
        Me.lbl_SubTotal.Size = New System.Drawing.Size(31, 15)
        Me.lbl_SubTotal.TabIndex = 159
        Me.lbl_SubTotal.Text = "0.00"
        '
        'lbl_Count
        '
        Me.lbl_Count.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Count.AutoSize = True
        Me.lbl_Count.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Count.ForeColor = System.Drawing.Color.Black
        Me.lbl_Count.Location = New System.Drawing.Point(611, 541)
        Me.lbl_Count.Name = "lbl_Count"
        Me.lbl_Count.Size = New System.Drawing.Size(20, 23)
        Me.lbl_Count.TabIndex = 165
        Me.lbl_Count.Text = "0"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(765, 568)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(143, 15)
        Me.Label20.TabIndex = 161
        Me.Label20.Text = "TOTAL SPARE PARTS PRICE"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(765, 550)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 15)
        Me.Label18.TabIndex = 162
        Me.Label18.Text = "GRAND TOTAL"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(765, 532)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 15)
        Me.Label16.TabIndex = 163
        Me.Label16.Text = "TOTAL VAT AMT"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(765, 514)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 15)
        Me.Label14.TabIndex = 164
        Me.Label14.Text = "TOTAL UNIT COST"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(411, 541)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 23)
        Me.Label12.TabIndex = 156
        Me.Label12.Text = "ITEM COUNT"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 514)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(209, 14)
        Me.Label10.TabIndex = 155
        Me.Label10.Text = "Double click item on the table to remove."
        '
        'btn_Approved
        '
        Me.btn_Approved.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Approved.BackgroundImage = CType(resources.GetObject("btn_Approved.BackgroundImage"), System.Drawing.Image)
        Me.btn_Approved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Approved.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Approved.Location = New System.Drawing.Point(9, 531)
        Me.btn_Approved.Name = "btn_Approved"
        Me.btn_Approved.Size = New System.Drawing.Size(65, 54)
        Me.btn_Approved.TabIndex = 168
        Me.btn_Approved.Tag = "Approved"
        Me.btn_Approved.UseVisualStyleBackColor = True
        '
        'Btn_DisApproved
        '
        Me.Btn_DisApproved.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_DisApproved.BackgroundImage = CType(resources.GetObject("Btn_DisApproved.BackgroundImage"), System.Drawing.Image)
        Me.Btn_DisApproved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_DisApproved.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_DisApproved.Location = New System.Drawing.Point(79, 531)
        Me.Btn_DisApproved.Name = "Btn_DisApproved"
        Me.Btn_DisApproved.Size = New System.Drawing.Size(65, 54)
        Me.Btn_DisApproved.TabIndex = 167
        Me.Btn_DisApproved.Tag = "Disapproved"
        Me.Btn_DisApproved.UseVisualStyleBackColor = True
        '
        'btn_Print
        '
        Me.btn_Print.BackgroundImage = CType(resources.GetObject("btn_Print.BackgroundImage"), System.Drawing.Image)
        Me.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Print.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Print.Location = New System.Drawing.Point(9, 532)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.Size = New System.Drawing.Size(65, 54)
        Me.btn_Print.TabIndex = 169
        Me.btn_Print.Tag = "Approved"
        Me.btn_Print.UseVisualStyleBackColor = True
        '
        'txt_PONo
        '
        Me.txt_PONo.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_PONo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PONo.Location = New System.Drawing.Point(430, 46)
        Me.txt_PONo.Name = "txt_PONo"
        Me.txt_PONo.ReadOnly = True
        Me.txt_PONo.Size = New System.Drawing.Size(239, 26)
        Me.txt_PONo.TabIndex = 137
        '
        'txt_Partsman
        '
        Me.txt_Partsman.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_Partsman.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Partsman.Location = New System.Drawing.Point(430, 78)
        Me.txt_Partsman.Name = "txt_Partsman"
        Me.txt_Partsman.ReadOnly = True
        Me.txt_Partsman.Size = New System.Drawing.Size(239, 26)
        Me.txt_Partsman.TabIndex = 141
        '
        'SPA_Checker_Approver_Outgoing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1057, 593)
        Me.Controls.Add(Me.lvParts)
        Me.Controls.Add(Me.Btn_DisApproved)
        Me.Controls.Add(Me.txt_Source)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_Remarks)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_Note)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_WHCode)
        Me.Controls.Add(Me.lbl_Partsman)
        Me.Controls.Add(Me.txt_Partsman)
        Me.Controls.Add(Me.lbl_Approver)
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
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lbl_GrandTotal)
        Me.Controls.Add(Me.lbl_Less)
        Me.Controls.Add(Me.lbl_SubTotal)
        Me.Controls.Add(Me.lbl_Count)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_Approved)
        Me.Controls.Add(Me.btn_Print)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SPA_Checker_Approver_Outgoing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OUTGOING INVENTORY"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Source As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Remarks As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_Note As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_WHCode As TextBox
    Friend WithEvents lbl_Partsman As Label
    Friend WithEvents lbl_Approver As Label
    Friend WithEvents txt_Approver As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_RefNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Status As TextBox
    Friend WithEvents btn_Add As Button
    Friend WithEvents txt_BrCode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_Branch As Button
    Friend WithEvents cmb_WHCategory As ComboBox
    Friend WithEvents dtp_Date As DateTimePicker
    Friend WithEvents txt_RBranch As TextBox
    Friend WithEvents totals As ColumnHeader
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
    Friend WithEvents Label21 As Label
    Friend WithEvents lbl_GrandTotal As Label
    Friend WithEvents lbl_Less As Label
    Friend WithEvents lbl_SubTotal As Label
    Friend WithEvents lbl_Count As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_Approved As Button
    Friend WithEvents Btn_DisApproved As Button
    Friend WithEvents id As ColumnHeader
    Friend WithEvents sc_SpareParts As ColumnHeader
    Friend WithEvents transactedby As ColumnHeader
    Friend WithEvents btn_Print As Button
    Friend WithEvents subTotal As ColumnHeader
    Friend WithEvents txt_PONo As TextBox
    Friend WithEvents txt_Partsman As TextBox
    Friend WithEvents category As ColumnHeader
    Friend WithEvents binBox As ColumnHeader
End Class
