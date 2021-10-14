<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Inventory_Receiving_View
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Inventory_Receiving_View))
        Me.engineno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_approver = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.unitCost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_whcode = New System.Windows.Forms.TextBox()
        Me.totalcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.unitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmb_warehouse = New System.Windows.Forms.ComboBox()
        Me.chasisno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LViewItems = New System.Windows.Forms.ListView()
        Me.code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.model = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.color = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.keyno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.note = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_invenStat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_TransCode = New System.Windows.Forms.TextBox()
        Me.txt_pono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_refno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.receivedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_vendor = New System.Windows.Forms.Label()
        Me.cmd_disapproved = New System.Windows.Forms.Button()
        Me.cmd_approved = New System.Windows.Forms.Button()
        Me.lbl_count = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_grandTotal = New System.Windows.Forms.Label()
        Me.label99 = New System.Windows.Forms.Label()
        Me.lbl_totVatAmt = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_tot_unit = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmd_print = New System.Windows.Forms.Button()
        Me.lbl_totUnitPrice = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_sender = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_originatingBranch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grp_remarks = New System.Windows.Forms.GroupBox()
        Me.cmb_disapp = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_disappr_remarks = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_notes = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.txt_rptTitle = New System.Windows.Forms.Label()
        Me.GCInTransitMC = New DevExpress.XtraGrid.GridControl()
        Me.GViewMCIntransit = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chassisno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.vatamt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_BranchName = New System.Windows.Forms.TextBox()
        Me.txt_ValidatedBy = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ConfirmedBy = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ReceivedBy = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ApprovedBy = New DevExpress.XtraEditors.TextEdit()
        Me.txt_TransactedBy = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_GrandTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_UnitPriceTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_VatTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Count = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txt_Warehouse = New System.Windows.Forms.TextBox()
        Me.txt_Date = New System.Windows.Forms.TextBox()
        Me.txt_vendor = New System.Windows.Forms.TextBox()
        Me.txt_phoneNo = New System.Windows.Forms.TextBox()
        Me.txt_BranchAddress = New System.Windows.Forms.TextBox()
        Me.txt_BranchCode = New System.Windows.Forms.TextBox()
        Me.txt_UnitCostTot = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_remarks.SuspendLayout()
        CType(Me.GCInTransitMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GViewMCIntransit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ValidatedBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ConfirmedBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ReceivedBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ApprovedBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TransactedBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GrandTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_UnitPriceTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_VatTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_UnitCostTot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'engineno
        '
        Me.engineno.Text = "ENGINE No"
        Me.engineno.Width = 91
        '
        'txt_approver
        '
        Me.txt_approver.Enabled = False
        Me.txt_approver.Location = New System.Drawing.Point(416, 88)
        Me.txt_approver.Name = "txt_approver"
        Me.txt_approver.Size = New System.Drawing.Size(217, 22)
        Me.txt_approver.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(329, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "APPROVER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'unitCost
        '
        Me.unitCost.Text = "UNIT COST"
        Me.unitCost.Width = 107
        '
        'vat
        '
        Me.vat.Text = "VAT"
        Me.vat.Width = 71
        '
        'txt_whcode
        '
        Me.txt_whcode.Enabled = False
        Me.txt_whcode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_whcode.Location = New System.Drawing.Point(908, 80)
        Me.txt_whcode.Name = "txt_whcode"
        Me.txt_whcode.Size = New System.Drawing.Size(81, 22)
        Me.txt_whcode.TabIndex = 73
        '
        'totalcost
        '
        Me.totalcost.Text = "TOTAL COST"
        Me.totalcost.Width = 95
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(726, 80)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(29, 29)
        Me.Button4.TabIndex = 72
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(641, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 23)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "WAREHOUSE:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'unitPrice
        '
        Me.unitPrice.Text = "UNIT PRICE"
        Me.unitPrice.Width = 72
        '
        'cmb_warehouse
        '
        Me.cmb_warehouse.Enabled = False
        Me.cmb_warehouse.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_warehouse.FormattingEnabled = True
        Me.cmb_warehouse.Location = New System.Drawing.Point(761, 79)
        Me.cmb_warehouse.Name = "cmb_warehouse"
        Me.cmb_warehouse.Size = New System.Drawing.Size(139, 23)
        Me.cmb_warehouse.TabIndex = 70
        '
        'chasisno
        '
        Me.chasisno.Text = "CHASSIS  No"
        Me.chasisno.Width = 100
        '
        'brand
        '
        Me.brand.Text = "BRAND"
        Me.brand.Width = 95
        '
        'LViewItems
        '
        Me.LViewItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.code, Me.model, Me.desc, Me.color, Me.brand, Me.chasisno, Me.engineno, Me.unitCost, Me.vat, Me.totalcost, Me.unitPrice, Me.keyno, Me.note})
        Me.LViewItems.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItems.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewItems.FullRowSelect = True
        Me.LViewItems.GridLines = True
        Me.LViewItems.HideSelection = False
        Me.LViewItems.Location = New System.Drawing.Point(20, 170)
        Me.LViewItems.Name = "LViewItems"
        Me.LViewItems.Size = New System.Drawing.Size(969, 262)
        Me.LViewItems.TabIndex = 64
        Me.LViewItems.UseCompatibleStateImageBehavior = False
        Me.LViewItems.View = System.Windows.Forms.View.Details
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
        'keyno
        '
        Me.keyno.Text = "KEY No"
        '
        'note
        '
        Me.note.Text = "NOTE"
        '
        'txt_invenStat
        '
        Me.txt_invenStat.Enabled = False
        Me.txt_invenStat.Location = New System.Drawing.Point(132, 91)
        Me.txt_invenStat.Name = "txt_invenStat"
        Me.txt_invenStat.Size = New System.Drawing.Size(189, 22)
        Me.txt_invenStat.TabIndex = 63
        Me.txt_invenStat.Text = "For Approval"
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(19, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 24)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "STATUS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_TransCode
        '
        Me.txt_TransCode.Enabled = False
        Me.txt_TransCode.Location = New System.Drawing.Point(726, 12)
        Me.txt_TransCode.Name = "txt_TransCode"
        Me.txt_TransCode.Size = New System.Drawing.Size(263, 22)
        Me.txt_TransCode.TabIndex = 61
        Me.txt_TransCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pono
        '
        Me.txt_pono.Enabled = False
        Me.txt_pono.Location = New System.Drawing.Point(418, 40)
        Me.txt_pono.Name = "txt_pono"
        Me.txt_pono.Size = New System.Drawing.Size(215, 22)
        Me.txt_pono.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(640, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 24)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "TRANS CODE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(329, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 24)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "P.O. No."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 24)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "REFERENCE No."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txt_refno
        '
        Me.txt_refno.Enabled = False
        Me.txt_refno.Location = New System.Drawing.Point(132, 40)
        Me.txt_refno.Name = "txt_refno"
        Me.txt_refno.Size = New System.Drawing.Size(189, 22)
        Me.txt_refno.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(641, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "DATE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(727, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'receivedDate
        '
        Me.receivedDate.Enabled = False
        Me.receivedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.receivedDate.Location = New System.Drawing.Point(761, 45)
        Me.receivedDate.Name = "receivedDate"
        Me.receivedDate.Size = New System.Drawing.Size(228, 22)
        Me.receivedDate.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 24)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "VENDOR"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lbl_vendor
        '
        Me.lbl_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_vendor.ForeColor = System.Drawing.Color.White
        Me.lbl_vendor.Location = New System.Drawing.Point(132, 13)
        Me.lbl_vendor.Name = "lbl_vendor"
        Me.lbl_vendor.Size = New System.Drawing.Size(501, 24)
        Me.lbl_vendor.TabIndex = 51
        '
        'cmd_disapproved
        '
        Me.cmd_disapproved.AutoSize = True
        Me.cmd_disapproved.BackgroundImage = CType(resources.GetObject("cmd_disapproved.BackgroundImage"), System.Drawing.Image)
        Me.cmd_disapproved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_disapproved.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmd_disapproved.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_disapproved.Location = New System.Drawing.Point(76, 441)
        Me.cmd_disapproved.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd_disapproved.Name = "cmd_disapproved"
        Me.cmd_disapproved.Size = New System.Drawing.Size(64, 52)
        Me.cmd_disapproved.TabIndex = 78
        Me.cmd_disapproved.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmd_disapproved, "Disapproved Transaction")
        Me.cmd_disapproved.UseVisualStyleBackColor = True
        Me.cmd_disapproved.Visible = False
        '
        'cmd_approved
        '
        Me.cmd_approved.AutoSize = True
        Me.cmd_approved.BackgroundImage = CType(resources.GetObject("cmd_approved.BackgroundImage"), System.Drawing.Image)
        Me.cmd_approved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_approved.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmd_approved.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_approved.ForeColor = System.Drawing.Color.Teal
        Me.cmd_approved.Location = New System.Drawing.Point(13, 441)
        Me.cmd_approved.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd_approved.Name = "cmd_approved"
        Me.cmd_approved.Size = New System.Drawing.Size(64, 52)
        Me.cmd_approved.TabIndex = 79
        Me.cmd_approved.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmd_approved, "Approved Transaction")
        Me.cmd_approved.UseVisualStyleBackColor = True
        Me.cmd_approved.Visible = False
        '
        'lbl_count
        '
        Me.lbl_count.ForeColor = System.Drawing.Color.White
        Me.lbl_count.Location = New System.Drawing.Point(476, 435)
        Me.lbl_count.Name = "lbl_count"
        Me.lbl_count.Size = New System.Drawing.Size(119, 24)
        Me.lbl_count.TabIndex = 87
        Me.lbl_count.Text = "0"
        Me.lbl_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(383, 435)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 24)
        Me.Label16.TabIndex = 86
        Me.Label16.Text = "ITEM COUNT"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_grandTotal
        '
        Me.lbl_grandTotal.ForeColor = System.Drawing.Color.White
        Me.lbl_grandTotal.Location = New System.Drawing.Point(861, 475)
        Me.lbl_grandTotal.Name = "lbl_grandTotal"
        Me.lbl_grandTotal.Size = New System.Drawing.Size(119, 24)
        Me.lbl_grandTotal.TabIndex = 85
        Me.lbl_grandTotal.Text = "000.00"
        Me.lbl_grandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label99
        '
        Me.label99.ForeColor = System.Drawing.Color.White
        Me.label99.Location = New System.Drawing.Point(736, 477)
        Me.label99.Name = "label99"
        Me.label99.Size = New System.Drawing.Size(133, 24)
        Me.label99.TabIndex = 84
        Me.label99.Text = "GRAND TOTAL"
        Me.label99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_totVatAmt
        '
        Me.lbl_totVatAmt.ForeColor = System.Drawing.Color.White
        Me.lbl_totVatAmt.Location = New System.Drawing.Point(861, 455)
        Me.lbl_totVatAmt.Name = "lbl_totVatAmt"
        Me.lbl_totVatAmt.Size = New System.Drawing.Size(119, 24)
        Me.lbl_totVatAmt.TabIndex = 83
        Me.lbl_totVatAmt.Text = "000.00"
        Me.lbl_totVatAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(736, 456)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 24)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "TOTAL VAT AMT"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_tot_unit
        '
        Me.lbl_tot_unit.ForeColor = System.Drawing.Color.White
        Me.lbl_tot_unit.Location = New System.Drawing.Point(861, 435)
        Me.lbl_tot_unit.Name = "lbl_tot_unit"
        Me.lbl_tot_unit.Size = New System.Drawing.Size(119, 24)
        Me.lbl_tot_unit.TabIndex = 81
        Me.lbl_tot_unit.Text = "000.00"
        Me.lbl_tot_unit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(736, 435)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 24)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "TOTAL UNIT COST"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Integrated Core System"
        '
        'cmd_print
        '
        Me.cmd_print.AutoSize = True
        Me.cmd_print.BackgroundImage = CType(resources.GetObject("cmd_print.BackgroundImage"), System.Drawing.Image)
        Me.cmd_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_print.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmd_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_print.Location = New System.Drawing.Point(139, 441)
        Me.cmd_print.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(64, 52)
        Me.cmd_print.TabIndex = 90
        Me.cmd_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmd_print, "Print Transaction")
        Me.cmd_print.UseVisualStyleBackColor = True
        Me.cmd_print.Visible = False
        '
        'lbl_totUnitPrice
        '
        Me.lbl_totUnitPrice.ForeColor = System.Drawing.Color.White
        Me.lbl_totUnitPrice.Location = New System.Drawing.Point(861, 510)
        Me.lbl_totUnitPrice.Name = "lbl_totUnitPrice"
        Me.lbl_totUnitPrice.Size = New System.Drawing.Size(119, 24)
        Me.lbl_totUnitPrice.TabIndex = 89
        Me.lbl_totUnitPrice.Text = "000.00"
        Me.lbl_totUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(736, 511)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 24)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "TOTAL UNIT PRICE"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_sender
        '
        Me.txt_sender.Enabled = False
        Me.txt_sender.Location = New System.Drawing.Point(132, 65)
        Me.txt_sender.Name = "txt_sender"
        Me.txt_sender.Size = New System.Drawing.Size(189, 22)
        Me.txt_sender.TabIndex = 92
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(19, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 24)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "SENDER"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_originatingBranch
        '
        Me.txt_originatingBranch.Enabled = False
        Me.txt_originatingBranch.Location = New System.Drawing.Point(417, 64)
        Me.txt_originatingBranch.Name = "txt_originatingBranch"
        Me.txt_originatingBranch.Size = New System.Drawing.Size(216, 22)
        Me.txt_originatingBranch.TabIndex = 94
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(330, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 24)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "BRANCH"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grp_remarks
        '
        Me.grp_remarks.Controls.Add(Me.cmb_disapp)
        Me.grp_remarks.Controls.Add(Me.Label14)
        Me.grp_remarks.Controls.Add(Me.txt_disappr_remarks)
        Me.grp_remarks.Location = New System.Drawing.Point(194, 218)
        Me.grp_remarks.Name = "grp_remarks"
        Me.grp_remarks.Size = New System.Drawing.Size(588, 100)
        Me.grp_remarks.TabIndex = 95
        Me.grp_remarks.TabStop = False
        Me.grp_remarks.Visible = False
        '
        'cmb_disapp
        '
        Me.cmb_disapp.AutoSize = True
        Me.cmb_disapp.BackColor = System.Drawing.Color.White
        Me.cmb_disapp.BackgroundImage = CType(resources.GetObject("cmb_disapp.BackgroundImage"), System.Drawing.Image)
        Me.cmb_disapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmb_disapp.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmb_disapp.Location = New System.Drawing.Point(516, 19)
        Me.cmb_disapp.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmb_disapp.Name = "cmb_disapp"
        Me.cmb_disapp.Size = New System.Drawing.Size(59, 60)
        Me.cmb_disapp.TabIndex = 82
        Me.cmb_disapp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmb_disapp.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 20)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "REMARKS"
        '
        'txt_disappr_remarks
        '
        Me.txt_disappr_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_disappr_remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_disappr_remarks.Location = New System.Drawing.Point(134, 19)
        Me.txt_disappr_remarks.Multiline = True
        Me.txt_disappr_remarks.Name = "txt_disappr_remarks"
        Me.txt_disappr_remarks.Size = New System.Drawing.Size(376, 60)
        Me.txt_disappr_remarks.TabIndex = 80
        '
        'Label15
        '
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(19, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 20)
        Me.Label15.TabIndex = 99
        Me.Label15.Text = "NOTE"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_notes
        '
        Me.txt_notes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_notes.Enabled = False
        Me.txt_notes.Location = New System.Drawing.Point(132, 116)
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.Size = New System.Drawing.Size(857, 22)
        Me.txt_notes.TabIndex = 98
        '
        'Label17
        '
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(19, 141)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 20)
        Me.Label17.TabIndex = 97
        Me.Label17.Text = "REMARKS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_remarks
        '
        Me.txt_remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_remarks.Enabled = False
        Me.txt_remarks.Location = New System.Drawing.Point(132, 142)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(857, 22)
        Me.txt_remarks.TabIndex = 96
        '
        'txt_rptTitle
        '
        Me.txt_rptTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_rptTitle.Location = New System.Drawing.Point(372, 477)
        Me.txt_rptTitle.Name = "txt_rptTitle"
        Me.txt_rptTitle.Size = New System.Drawing.Size(178, 24)
        Me.txt_rptTitle.TabIndex = 142
        Me.txt_rptTitle.Text = "SAGA"
        Me.txt_rptTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.txt_rptTitle.Visible = False
        '
        'GCInTransitMC
        '
        Me.GCInTransitMC.Location = New System.Drawing.Point(1326, 12)
        Me.GCInTransitMC.MainView = Me.GViewMCIntransit
        Me.GCInTransitMC.Name = "GCInTransitMC"
        Me.GCInTransitMC.Size = New System.Drawing.Size(492, 357)
        Me.GCInTransitMC.TabIndex = 145
        Me.GCInTransitMC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GViewMCIntransit})
        Me.GCInTransitMC.Visible = False
        '
        'GViewMCIntransit
        '
        Me.GViewMCIntransit.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ItemDescription, Me.GridColumn1, Me.chassisno, Me.GridColumn2, Me.vatamt, Me.GridColumn3, Me.GridColumn4})
        Me.GViewMCIntransit.GridControl = Me.GCInTransitMC
        Me.GViewMCIntransit.Name = "GViewMCIntransit"
        Me.GViewMCIntransit.OptionsView.ColumnAutoWidth = False
        '
        'ItemDescription
        '
        Me.ItemDescription.Caption = "Description"
        Me.ItemDescription.FieldName = "ItemDescription"
        Me.ItemDescription.Name = "ItemDescription"
        Me.ItemDescription.Visible = True
        Me.ItemDescription.VisibleIndex = 0
        Me.ItemDescription.Width = 149
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Engine No"
        Me.GridColumn1.FieldName = "engineno"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 77
        '
        'chassisno
        '
        Me.chassisno.Caption = "Chassis No"
        Me.chassisno.FieldName = "chassisno"
        Me.chassisno.Name = "chassisno"
        Me.chassisno.Visible = True
        Me.chassisno.VisibleIndex = 2
        Me.chassisno.Width = 82
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Unit Cost"
        Me.GridColumn2.FieldName = "unitcost"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 60
        '
        'vatamt
        '
        Me.vatamt.Caption = "VAT"
        Me.vatamt.FieldName = "vatamt"
        Me.vatamt.Name = "vatamt"
        Me.vatamt.Visible = True
        Me.vatamt.VisibleIndex = 4
        Me.vatamt.Width = 47
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Total Cost"
        Me.GridColumn3.FieldName = "totalcost"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 5
        Me.GridColumn3.Width = 67
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Unit Price"
        Me.GridColumn4.FieldName = "unitprice"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 6
        Me.GridColumn4.Width = 67
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(1017, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 22)
        Me.TextBox1.TabIndex = 166
        Me.TextBox1.Text = "TXT_WHCODE"
        Me.TextBox1.Visible = False
        '
        'txt_BranchName
        '
        Me.txt_BranchName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_BranchName.Enabled = False
        Me.txt_BranchName.Location = New System.Drawing.Point(1017, 262)
        Me.txt_BranchName.Name = "txt_BranchName"
        Me.txt_BranchName.Size = New System.Drawing.Size(161, 22)
        Me.txt_BranchName.TabIndex = 165
        Me.txt_BranchName.Text = "TXT_BRANCHNAME"
        Me.txt_BranchName.Visible = False
        '
        'txt_ValidatedBy
        '
        Me.txt_ValidatedBy.EditValue = "txt_ValidatedBy"
        Me.txt_ValidatedBy.Location = New System.Drawing.Point(1034, 232)
        Me.txt_ValidatedBy.Name = "txt_ValidatedBy"
        Me.txt_ValidatedBy.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_ValidatedBy.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_ValidatedBy.Size = New System.Drawing.Size(144, 22)
        Me.txt_ValidatedBy.TabIndex = 164
        Me.txt_ValidatedBy.Visible = False
        '
        'txt_ConfirmedBy
        '
        Me.txt_ConfirmedBy.EditValue = "txt_ConfirmedBy"
        Me.txt_ConfirmedBy.Location = New System.Drawing.Point(1193, 268)
        Me.txt_ConfirmedBy.Name = "txt_ConfirmedBy"
        Me.txt_ConfirmedBy.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_ConfirmedBy.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_ConfirmedBy.Size = New System.Drawing.Size(127, 22)
        Me.txt_ConfirmedBy.TabIndex = 163
        Me.txt_ConfirmedBy.Visible = False
        '
        'txt_ReceivedBy
        '
        Me.txt_ReceivedBy.EditValue = "txt_ReceivedBy"
        Me.txt_ReceivedBy.Location = New System.Drawing.Point(1193, 240)
        Me.txt_ReceivedBy.Name = "txt_ReceivedBy"
        Me.txt_ReceivedBy.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_ReceivedBy.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_ReceivedBy.Size = New System.Drawing.Size(127, 22)
        Me.txt_ReceivedBy.TabIndex = 162
        Me.txt_ReceivedBy.Visible = False
        '
        'txt_ApprovedBy
        '
        Me.txt_ApprovedBy.EditValue = "txt_ApprovedBy"
        Me.txt_ApprovedBy.Location = New System.Drawing.Point(1034, 198)
        Me.txt_ApprovedBy.Name = "txt_ApprovedBy"
        Me.txt_ApprovedBy.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_ApprovedBy.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_ApprovedBy.Size = New System.Drawing.Size(144, 22)
        Me.txt_ApprovedBy.TabIndex = 161
        Me.txt_ApprovedBy.Visible = False
        '
        'txt_TransactedBy
        '
        Me.txt_TransactedBy.EditValue = "txt_PreparedBy"
        Me.txt_TransactedBy.Location = New System.Drawing.Point(1034, 170)
        Me.txt_TransactedBy.Name = "txt_TransactedBy"
        Me.txt_TransactedBy.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_TransactedBy.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_TransactedBy.Size = New System.Drawing.Size(144, 22)
        Me.txt_TransactedBy.TabIndex = 160
        Me.txt_TransactedBy.Visible = False
        '
        'TextEdit4
        '
        Me.TextEdit4.EditValue = "0"
        Me.TextEdit4.Location = New System.Drawing.Point(1193, 212)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit4.Properties.DisplayFormat.FormatString = "n2"
        Me.TextEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit4.Size = New System.Drawing.Size(127, 22)
        Me.TextEdit4.TabIndex = 159
        Me.TextEdit4.Visible = False
        '
        'txt_GrandTotal
        '
        Me.txt_GrandTotal.EditValue = "0"
        Me.txt_GrandTotal.Location = New System.Drawing.Point(1193, 170)
        Me.txt_GrandTotal.Name = "txt_GrandTotal"
        Me.txt_GrandTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_GrandTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_GrandTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_GrandTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_GrandTotal.Size = New System.Drawing.Size(127, 22)
        Me.txt_GrandTotal.TabIndex = 158
        Me.txt_GrandTotal.Visible = False
        '
        'txt_UnitPriceTotal
        '
        Me.txt_UnitPriceTotal.EditValue = "0"
        Me.txt_UnitPriceTotal.Location = New System.Drawing.Point(1193, 191)
        Me.txt_UnitPriceTotal.Name = "txt_UnitPriceTotal"
        Me.txt_UnitPriceTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_UnitPriceTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_UnitPriceTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_UnitPriceTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_UnitPriceTotal.Size = New System.Drawing.Size(127, 22)
        Me.txt_UnitPriceTotal.TabIndex = 157
        Me.txt_UnitPriceTotal.Visible = False
        '
        'txt_VatTotal
        '
        Me.txt_VatTotal.EditValue = "0"
        Me.txt_VatTotal.Location = New System.Drawing.Point(1193, 149)
        Me.txt_VatTotal.Name = "txt_VatTotal"
        Me.txt_VatTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_VatTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_VatTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_VatTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_VatTotal.Size = New System.Drawing.Size(127, 22)
        Me.txt_VatTotal.TabIndex = 156
        Me.txt_VatTotal.Visible = False
        '
        'txt_Count
        '
        Me.txt_Count.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Count.Enabled = False
        Me.txt_Count.Location = New System.Drawing.Point(1017, 126)
        Me.txt_Count.Name = "txt_Count"
        Me.txt_Count.Size = New System.Drawing.Size(161, 22)
        Me.txt_Count.TabIndex = 154
        Me.txt_Count.Text = "TXT_COUNT"
        Me.txt_Count.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(1193, 108)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(127, 22)
        Me.TextBox2.TabIndex = 153
        Me.TextBox2.Text = "TXT_PONO"
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(1193, 86)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(127, 22)
        Me.TextBox3.TabIndex = 152
        Me.TextBox3.Text = "TXT_REFNO"
        Me.TextBox3.Visible = False
        '
        'txt_Warehouse
        '
        Me.txt_Warehouse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Warehouse.Enabled = False
        Me.txt_Warehouse.Location = New System.Drawing.Point(1017, 59)
        Me.txt_Warehouse.Name = "txt_Warehouse"
        Me.txt_Warehouse.Size = New System.Drawing.Size(161, 22)
        Me.txt_Warehouse.TabIndex = 151
        Me.txt_Warehouse.Text = "TXT_WAREHOUSE"
        Me.txt_Warehouse.Visible = False
        '
        'txt_Date
        '
        Me.txt_Date.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Date.Enabled = False
        Me.txt_Date.Location = New System.Drawing.Point(1017, 38)
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.Size = New System.Drawing.Size(161, 22)
        Me.txt_Date.TabIndex = 150
        Me.txt_Date.Text = "TXT_DATE"
        Me.txt_Date.Visible = False
        '
        'txt_vendor
        '
        Me.txt_vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_vendor.Enabled = False
        Me.txt_vendor.Location = New System.Drawing.Point(1017, 16)
        Me.txt_vendor.Name = "txt_vendor"
        Me.txt_vendor.Size = New System.Drawing.Size(161, 22)
        Me.txt_vendor.TabIndex = 149
        Me.txt_vendor.Text = "TXT_VENDOR"
        Me.txt_vendor.Visible = False
        '
        'txt_phoneNo
        '
        Me.txt_phoneNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_phoneNo.Enabled = False
        Me.txt_phoneNo.Location = New System.Drawing.Point(1193, 57)
        Me.txt_phoneNo.Name = "txt_phoneNo"
        Me.txt_phoneNo.Size = New System.Drawing.Size(127, 22)
        Me.txt_phoneNo.TabIndex = 148
        Me.txt_phoneNo.Text = "TXT_PHONENO"
        Me.txt_phoneNo.Visible = False
        '
        'txt_BranchAddress
        '
        Me.txt_BranchAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_BranchAddress.Enabled = False
        Me.txt_BranchAddress.Location = New System.Drawing.Point(1193, 36)
        Me.txt_BranchAddress.Name = "txt_BranchAddress"
        Me.txt_BranchAddress.Size = New System.Drawing.Size(127, 22)
        Me.txt_BranchAddress.TabIndex = 147
        Me.txt_BranchAddress.Text = "TXT_BRANCHADDRESS"
        Me.txt_BranchAddress.Visible = False
        '
        'txt_BranchCode
        '
        Me.txt_BranchCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_BranchCode.Enabled = False
        Me.txt_BranchCode.Location = New System.Drawing.Point(1193, 14)
        Me.txt_BranchCode.Name = "txt_BranchCode"
        Me.txt_BranchCode.Size = New System.Drawing.Size(127, 22)
        Me.txt_BranchCode.TabIndex = 146
        Me.txt_BranchCode.Text = "TXT_BRANCHCODE"
        Me.txt_BranchCode.Visible = False
        '
        'txt_UnitCostTot
        '
        Me.txt_UnitCostTot.EditValue = "0"
        Me.txt_UnitCostTot.Location = New System.Drawing.Point(1193, 130)
        Me.txt_UnitCostTot.Name = "txt_UnitCostTot"
        Me.txt_UnitCostTot.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_UnitCostTot.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_UnitCostTot.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_UnitCostTot.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_UnitCostTot.Size = New System.Drawing.Size(127, 22)
        Me.txt_UnitCostTot.TabIndex = 155
        Me.txt_UnitCostTot.Visible = False
        '
        'IS_Inventory_Receiving_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1000, 545)
        Me.Controls.Add(Me.GCInTransitMC)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txt_BranchName)
        Me.Controls.Add(Me.txt_ValidatedBy)
        Me.Controls.Add(Me.txt_ConfirmedBy)
        Me.Controls.Add(Me.txt_ReceivedBy)
        Me.Controls.Add(Me.txt_ApprovedBy)
        Me.Controls.Add(Me.txt_TransactedBy)
        Me.Controls.Add(Me.TextEdit4)
        Me.Controls.Add(Me.txt_GrandTotal)
        Me.Controls.Add(Me.txt_UnitPriceTotal)
        Me.Controls.Add(Me.txt_VatTotal)
        Me.Controls.Add(Me.txt_Count)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txt_Warehouse)
        Me.Controls.Add(Me.txt_Date)
        Me.Controls.Add(Me.txt_vendor)
        Me.Controls.Add(Me.txt_phoneNo)
        Me.Controls.Add(Me.txt_BranchAddress)
        Me.Controls.Add(Me.txt_BranchCode)
        Me.Controls.Add(Me.txt_UnitCostTot)
        Me.Controls.Add(Me.txt_rptTitle)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_notes)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.grp_remarks)
        Me.Controls.Add(Me.txt_originatingBranch)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_sender)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmd_print)
        Me.Controls.Add(Me.lbl_totUnitPrice)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbl_count)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbl_grandTotal)
        Me.Controls.Add(Me.label99)
        Me.Controls.Add(Me.lbl_totVatAmt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_tot_unit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmd_approved)
        Me.Controls.Add(Me.cmd_disapproved)
        Me.Controls.Add(Me.txt_approver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_whcode)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmb_warehouse)
        Me.Controls.Add(Me.LViewItems)
        Me.Controls.Add(Me.txt_invenStat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_TransCode)
        Me.Controls.Add(Me.txt_pono)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_refno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.receivedDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_vendor)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Inventory_Receiving_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANSACTION LIST DETAILED"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_remarks.ResumeLayout(False)
        Me.grp_remarks.PerformLayout()
        CType(Me.GCInTransitMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GViewMCIntransit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ValidatedBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ConfirmedBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ReceivedBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ApprovedBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TransactedBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GrandTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_UnitPriceTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_VatTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_UnitCostTot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents engineno As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_approver As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents unitCost As System.Windows.Forms.ColumnHeader
    Friend WithEvents vat As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_whcode As System.Windows.Forms.TextBox
    Friend WithEvents totalcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents unitPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmb_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents chasisno As System.Windows.Forms.ColumnHeader
    Friend WithEvents brand As System.Windows.Forms.ColumnHeader
    Friend WithEvents LViewItems As System.Windows.Forms.ListView
    Friend WithEvents code As System.Windows.Forms.ColumnHeader
    Friend WithEvents model As System.Windows.Forms.ColumnHeader
    Friend WithEvents desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents color As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_invenStat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_TransCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_pono As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_refno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents receivedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_vendor As System.Windows.Forms.Label
    Friend WithEvents cmd_disapproved As System.Windows.Forms.Button
    Friend WithEvents cmd_approved As System.Windows.Forms.Button
    Friend WithEvents lbl_count As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbl_grandTotal As System.Windows.Forms.Label
    Friend WithEvents label99 As System.Windows.Forms.Label
    Friend WithEvents lbl_totVatAmt As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_tot_unit As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_totUnitPrice As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmd_print As System.Windows.Forms.Button
    Friend WithEvents txt_sender As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_originatingBranch As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents keyno As System.Windows.Forms.ColumnHeader
    Friend WithEvents grp_remarks As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_disapp As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_disappr_remarks As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_notes As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents txt_rptTitle As System.Windows.Forms.Label
    Friend WithEvents note As System.Windows.Forms.ColumnHeader
    Friend WithEvents GCInTransitMC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GViewMCIntransit As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chassisno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents vatamt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_BranchName As TextBox
    Friend WithEvents txt_ValidatedBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ConfirmedBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ReceivedBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ApprovedBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_TransactedBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_GrandTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_UnitPriceTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_VatTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Count As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txt_Warehouse As TextBox
    Friend WithEvents txt_Date As TextBox
    Friend WithEvents txt_vendor As TextBox
    Friend WithEvents txt_phoneNo As TextBox
    Friend WithEvents txt_BranchAddress As TextBox
    Friend WithEvents txt_BranchCode As TextBox
    Friend WithEvents txt_UnitCostTot As DevExpress.XtraEditors.TextEdit
End Class
