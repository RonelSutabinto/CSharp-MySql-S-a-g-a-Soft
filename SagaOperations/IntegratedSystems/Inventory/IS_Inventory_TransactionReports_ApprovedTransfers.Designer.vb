<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Inventory_TransactionReports_ApprovedTransfers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Inventory_TransactionReports_ApprovedTransfers))
        Me.invstats = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.whCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_rptTitle = New System.Windows.Forms.TextBox()
        Me.source = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_trans = New System.Windows.Forms.TextBox()
        Me.refno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LViewList = New System.Windows.Forms.ListView()
        Me.daatee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmd_showInvent = New System.Windows.Forms.Button()
        Me.trans_date = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GCInTransitMC = New DevExpress.XtraGrid.GridControl()
        Me.GViewMCIntransit = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.engineno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chassisno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.unitcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.vatamt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.totalcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.unitprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txt_WhCode = New System.Windows.Forms.TextBox()
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
        Me.txt_PoNo = New System.Windows.Forms.TextBox()
        Me.txt_RefNo = New System.Windows.Forms.TextBox()
        Me.txt_Warehouse = New System.Windows.Forms.TextBox()
        Me.txt_Date = New System.Windows.Forms.TextBox()
        Me.txt_vendor = New System.Windows.Forms.TextBox()
        Me.txt_phoneNo = New System.Windows.Forms.TextBox()
        Me.txt_BranchAddress = New System.Windows.Forms.TextBox()
        Me.txt_BranchCode = New System.Windows.Forms.TextBox()
        Me.txt_UnitCostTot = New DevExpress.XtraEditors.TextEdit()
        Me.txt_OriginatingMaker = New DevExpress.XtraEditors.TextEdit()
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
        CType(Me.txt_OriginatingMaker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'invstats
        '
        Me.invstats.Text = "INVENTORY STATUS"
        Me.invstats.Width = 135
        '
        'whCode
        '
        Me.whCode.Text = "WH CODE"
        Me.whCode.Width = 79
        '
        'txt_rptTitle
        '
        Me.txt_rptTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_rptTitle.Enabled = False
        Me.txt_rptTitle.Location = New System.Drawing.Point(721, 16)
        Me.txt_rptTitle.Name = "txt_rptTitle"
        Me.txt_rptTitle.Size = New System.Drawing.Size(187, 20)
        Me.txt_rptTitle.TabIndex = 124
        Me.txt_rptTitle.Text = "SAGA INVENTORY - APPROVED TRANSFERS"
        '
        'source
        '
        Me.source.Text = "Source"
        Me.source.Width = 104
        '
        'pono
        '
        Me.pono.Text = "PO  No"
        Me.pono.Width = 112
        '
        'txt_trans
        '
        Me.txt_trans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_trans.Enabled = False
        Me.txt_trans.Location = New System.Drawing.Point(156, 16)
        Me.txt_trans.Name = "txt_trans"
        Me.txt_trans.Size = New System.Drawing.Size(458, 20)
        Me.txt_trans.TabIndex = 119
        Me.txt_trans.Text = "APPROVED"
        '
        'refno
        '
        Me.refno.Text = "ReF No"
        Me.refno.Width = 101
        '
        'LViewList
        '
        Me.LViewList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.refno, Me.pono, Me.whCode, Me.invstats, Me.source, Me.daatee})
        Me.LViewList.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewList.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewList.FullRowSelect = True
        Me.LViewList.GridLines = True
        Me.LViewList.HideSelection = False
        Me.LViewList.Location = New System.Drawing.Point(14, 71)
        Me.LViewList.Name = "LViewList"
        Me.LViewList.Size = New System.Drawing.Size(670, 267)
        Me.LViewList.TabIndex = 123
        Me.LViewList.UseCompatibleStateImageBehavior = False
        Me.LViewList.View = System.Windows.Forms.View.Details
        '
        'daatee
        '
        Me.daatee.Text = "TRANSDATE"
        Me.daatee.Width = 130
        '
        'cmd_showInvent
        '
        Me.cmd_showInvent.AutoSize = True
        Me.cmd_showInvent.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmd_showInvent.BackgroundImage = CType(resources.GetObject("cmd_showInvent.BackgroundImage"), System.Drawing.Image)
        Me.cmd_showInvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_showInvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_showInvent.Location = New System.Drawing.Point(620, 16)
        Me.cmd_showInvent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd_showInvent.Name = "cmd_showInvent"
        Me.cmd_showInvent.Size = New System.Drawing.Size(64, 51)
        Me.cmd_showInvent.TabIndex = 122
        Me.cmd_showInvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_showInvent.UseVisualStyleBackColor = False
        '
        'trans_date
        '
        Me.trans_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.trans_date.Location = New System.Drawing.Point(156, 44)
        Me.trans_date.Name = "trans_date"
        Me.trans_date.Size = New System.Drawing.Size(458, 20)
        Me.trans_date.TabIndex = 121
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 18)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "TRANSACTION DATE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 23)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "TRANSACTION TYPE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GCInTransitMC
        '
        Me.GCInTransitMC.Location = New System.Drawing.Point(147, 388)
        Me.GCInTransitMC.MainView = Me.GViewMCIntransit
        Me.GCInTransitMC.Name = "GCInTransitMC"
        Me.GCInTransitMC.Size = New System.Drawing.Size(429, 214)
        Me.GCInTransitMC.TabIndex = 125
        Me.GCInTransitMC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GViewMCIntransit})
        '
        'GViewMCIntransit
        '
        Me.GViewMCIntransit.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ItemDescription, Me.engineno, Me.chassisno, Me.unitcost, Me.vatamt, Me.totalcost, Me.unitprice})
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
        'engineno
        '
        Me.engineno.Caption = "Engine No"
        Me.engineno.FieldName = "engineno"
        Me.engineno.Name = "engineno"
        Me.engineno.Visible = True
        Me.engineno.VisibleIndex = 1
        Me.engineno.Width = 77
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
        'unitcost
        '
        Me.unitcost.Caption = "Unit Cost"
        Me.unitcost.FieldName = "unitcost"
        Me.unitcost.Name = "unitcost"
        Me.unitcost.Visible = True
        Me.unitcost.VisibleIndex = 3
        Me.unitcost.Width = 60
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
        'totalcost
        '
        Me.totalcost.Caption = "Total Cost"
        Me.totalcost.FieldName = "totalcost"
        Me.totalcost.Name = "totalcost"
        Me.totalcost.Visible = True
        Me.totalcost.VisibleIndex = 5
        Me.totalcost.Width = 67
        '
        'unitprice
        '
        Me.unitprice.Caption = "Unit Price"
        Me.unitprice.FieldName = "unitprice"
        Me.unitprice.Name = "unitprice"
        Me.unitprice.Visible = True
        Me.unitprice.VisibleIndex = 6
        Me.unitprice.Width = 67
        '
        'txt_WhCode
        '
        Me.txt_WhCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_WhCode.Enabled = False
        Me.txt_WhCode.Location = New System.Drawing.Point(701, 170)
        Me.txt_WhCode.Name = "txt_WhCode"
        Me.txt_WhCode.Size = New System.Drawing.Size(161, 20)
        Me.txt_WhCode.TabIndex = 165
        Me.txt_WhCode.Text = "TXT_WHCODE"
        '
        'txt_BranchName
        '
        Me.txt_BranchName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_BranchName.Enabled = False
        Me.txt_BranchName.Location = New System.Drawing.Point(922, 0)
        Me.txt_BranchName.Name = "txt_BranchName"
        Me.txt_BranchName.Size = New System.Drawing.Size(161, 20)
        Me.txt_BranchName.TabIndex = 164
        Me.txt_BranchName.Text = "TXT_BRANCHNAME"
        '
        'txt_ValidatedBy
        '
        Me.txt_ValidatedBy.EditValue = "txt_ValidatedBy"
        Me.txt_ValidatedBy.Location = New System.Drawing.Point(718, 314)
        Me.txt_ValidatedBy.Name = "txt_ValidatedBy"
        Me.txt_ValidatedBy.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_ValidatedBy.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_ValidatedBy.Size = New System.Drawing.Size(144, 22)
        Me.txt_ValidatedBy.TabIndex = 163
        '
        'txt_ConfirmedBy
        '
        Me.txt_ConfirmedBy.EditValue = "txt_ConfirmedBy"
        Me.txt_ConfirmedBy.Location = New System.Drawing.Point(922, 280)
        Me.txt_ConfirmedBy.Name = "txt_ConfirmedBy"
        Me.txt_ConfirmedBy.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_ConfirmedBy.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_ConfirmedBy.Size = New System.Drawing.Size(127, 22)
        Me.txt_ConfirmedBy.TabIndex = 162
        '
        'txt_ReceivedBy
        '
        Me.txt_ReceivedBy.EditValue = "txt_ReceivedBy"
        Me.txt_ReceivedBy.Location = New System.Drawing.Point(922, 252)
        Me.txt_ReceivedBy.Name = "txt_ReceivedBy"
        Me.txt_ReceivedBy.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_ReceivedBy.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_ReceivedBy.Size = New System.Drawing.Size(127, 22)
        Me.txt_ReceivedBy.TabIndex = 161
        '
        'txt_ApprovedBy
        '
        Me.txt_ApprovedBy.EditValue = "txt_ApprovedBy"
        Me.txt_ApprovedBy.Location = New System.Drawing.Point(718, 280)
        Me.txt_ApprovedBy.Name = "txt_ApprovedBy"
        Me.txt_ApprovedBy.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_ApprovedBy.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_ApprovedBy.Size = New System.Drawing.Size(144, 22)
        Me.txt_ApprovedBy.TabIndex = 160
        '
        'txt_TransactedBy
        '
        Me.txt_TransactedBy.EditValue = "txt_PreparedBy"
        Me.txt_TransactedBy.Location = New System.Drawing.Point(718, 252)
        Me.txt_TransactedBy.Name = "txt_TransactedBy"
        Me.txt_TransactedBy.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_TransactedBy.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_TransactedBy.Size = New System.Drawing.Size(144, 22)
        Me.txt_TransactedBy.TabIndex = 159
        '
        'TextEdit4
        '
        Me.TextEdit4.EditValue = "0"
        Me.TextEdit4.Location = New System.Drawing.Point(922, 224)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit4.Properties.DisplayFormat.FormatString = "n2"
        Me.TextEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit4.Size = New System.Drawing.Size(127, 22)
        Me.TextEdit4.TabIndex = 158
        '
        'txt_GrandTotal
        '
        Me.txt_GrandTotal.EditValue = "0"
        Me.txt_GrandTotal.Location = New System.Drawing.Point(922, 182)
        Me.txt_GrandTotal.Name = "txt_GrandTotal"
        Me.txt_GrandTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_GrandTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_GrandTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_GrandTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_GrandTotal.Size = New System.Drawing.Size(127, 22)
        Me.txt_GrandTotal.TabIndex = 157
        '
        'txt_UnitPriceTotal
        '
        Me.txt_UnitPriceTotal.EditValue = "0"
        Me.txt_UnitPriceTotal.Location = New System.Drawing.Point(922, 203)
        Me.txt_UnitPriceTotal.Name = "txt_UnitPriceTotal"
        Me.txt_UnitPriceTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_UnitPriceTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_UnitPriceTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_UnitPriceTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_UnitPriceTotal.Size = New System.Drawing.Size(127, 22)
        Me.txt_UnitPriceTotal.TabIndex = 156
        '
        'txt_VatTotal
        '
        Me.txt_VatTotal.EditValue = "0"
        Me.txt_VatTotal.Location = New System.Drawing.Point(922, 161)
        Me.txt_VatTotal.Name = "txt_VatTotal"
        Me.txt_VatTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_VatTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_VatTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_VatTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_VatTotal.Size = New System.Drawing.Size(127, 22)
        Me.txt_VatTotal.TabIndex = 155
        '
        'txt_Count
        '
        Me.txt_Count.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Count.Enabled = False
        Me.txt_Count.Location = New System.Drawing.Point(701, 208)
        Me.txt_Count.Name = "txt_Count"
        Me.txt_Count.Size = New System.Drawing.Size(161, 20)
        Me.txt_Count.TabIndex = 153
        Me.txt_Count.Text = "TXT_COUNT"
        '
        'txt_PoNo
        '
        Me.txt_PoNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PoNo.Enabled = False
        Me.txt_PoNo.Location = New System.Drawing.Point(922, 120)
        Me.txt_PoNo.Name = "txt_PoNo"
        Me.txt_PoNo.Size = New System.Drawing.Size(127, 20)
        Me.txt_PoNo.TabIndex = 152
        Me.txt_PoNo.Text = "TXT_PONO"
        '
        'txt_RefNo
        '
        Me.txt_RefNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_RefNo.Enabled = False
        Me.txt_RefNo.Location = New System.Drawing.Point(922, 98)
        Me.txt_RefNo.Name = "txt_RefNo"
        Me.txt_RefNo.Size = New System.Drawing.Size(127, 20)
        Me.txt_RefNo.TabIndex = 151
        Me.txt_RefNo.Text = "TXT_REFNO"
        '
        'txt_Warehouse
        '
        Me.txt_Warehouse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Warehouse.Enabled = False
        Me.txt_Warehouse.Location = New System.Drawing.Point(701, 141)
        Me.txt_Warehouse.Name = "txt_Warehouse"
        Me.txt_Warehouse.Size = New System.Drawing.Size(161, 20)
        Me.txt_Warehouse.TabIndex = 150
        Me.txt_Warehouse.Text = "TXT_WAREHOUSE"
        '
        'txt_Date
        '
        Me.txt_Date.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Date.Enabled = False
        Me.txt_Date.Location = New System.Drawing.Point(701, 120)
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.Size = New System.Drawing.Size(161, 20)
        Me.txt_Date.TabIndex = 149
        Me.txt_Date.Text = "TXT_DATE"
        '
        'txt_vendor
        '
        Me.txt_vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_vendor.Enabled = False
        Me.txt_vendor.Location = New System.Drawing.Point(701, 98)
        Me.txt_vendor.Name = "txt_vendor"
        Me.txt_vendor.Size = New System.Drawing.Size(161, 20)
        Me.txt_vendor.TabIndex = 148
        Me.txt_vendor.Text = "TXT_VENDOR"
        '
        'txt_phoneNo
        '
        Me.txt_phoneNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_phoneNo.Enabled = False
        Me.txt_phoneNo.Location = New System.Drawing.Point(922, 69)
        Me.txt_phoneNo.Name = "txt_phoneNo"
        Me.txt_phoneNo.Size = New System.Drawing.Size(127, 20)
        Me.txt_phoneNo.TabIndex = 147
        Me.txt_phoneNo.Text = "TXT_PHONENO"
        '
        'txt_BranchAddress
        '
        Me.txt_BranchAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_BranchAddress.Enabled = False
        Me.txt_BranchAddress.Location = New System.Drawing.Point(922, 48)
        Me.txt_BranchAddress.Name = "txt_BranchAddress"
        Me.txt_BranchAddress.Size = New System.Drawing.Size(127, 20)
        Me.txt_BranchAddress.TabIndex = 146
        Me.txt_BranchAddress.Text = "TXT_BRANCHADDRESS"
        '
        'txt_BranchCode
        '
        Me.txt_BranchCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_BranchCode.Enabled = False
        Me.txt_BranchCode.Location = New System.Drawing.Point(922, 26)
        Me.txt_BranchCode.Name = "txt_BranchCode"
        Me.txt_BranchCode.Size = New System.Drawing.Size(127, 20)
        Me.txt_BranchCode.TabIndex = 145
        Me.txt_BranchCode.Text = "TXT_BRANCHCODE"
        '
        'txt_UnitCostTot
        '
        Me.txt_UnitCostTot.EditValue = "0"
        Me.txt_UnitCostTot.Location = New System.Drawing.Point(922, 142)
        Me.txt_UnitCostTot.Name = "txt_UnitCostTot"
        Me.txt_UnitCostTot.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_UnitCostTot.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_UnitCostTot.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_UnitCostTot.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_UnitCostTot.Size = New System.Drawing.Size(127, 22)
        Me.txt_UnitCostTot.TabIndex = 154
        '
        'txt_OriginatingMaker
        '
        Me.txt_OriginatingMaker.EditValue = "txt_OriginatingMaker"
        Me.txt_OriginatingMaker.Location = New System.Drawing.Point(721, 372)
        Me.txt_OriginatingMaker.Name = "txt_OriginatingMaker"
        Me.txt_OriginatingMaker.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_OriginatingMaker.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_OriginatingMaker.Size = New System.Drawing.Size(144, 22)
        Me.txt_OriginatingMaker.TabIndex = 166
        '
        'IS_Inventory_TransactionReports_ApprovedTransfers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(695, 348)
        Me.Controls.Add(Me.txt_OriginatingMaker)
        Me.Controls.Add(Me.txt_WhCode)
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
        Me.Controls.Add(Me.txt_PoNo)
        Me.Controls.Add(Me.txt_RefNo)
        Me.Controls.Add(Me.txt_Warehouse)
        Me.Controls.Add(Me.txt_Date)
        Me.Controls.Add(Me.txt_vendor)
        Me.Controls.Add(Me.txt_phoneNo)
        Me.Controls.Add(Me.txt_BranchAddress)
        Me.Controls.Add(Me.txt_BranchCode)
        Me.Controls.Add(Me.txt_UnitCostTot)
        Me.Controls.Add(Me.GCInTransitMC)
        Me.Controls.Add(Me.LViewList)
        Me.Controls.Add(Me.txt_rptTitle)
        Me.Controls.Add(Me.txt_trans)
        Me.Controls.Add(Me.cmd_showInvent)
        Me.Controls.Add(Me.trans_date)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Inventory_TransactionReports_ApprovedTransfers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACCEPTED TRANSFERS"
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
        CType(Me.txt_OriginatingMaker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents invstats As System.Windows.Forms.ColumnHeader
    Friend WithEvents whCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_rptTitle As System.Windows.Forms.TextBox
    Friend WithEvents source As System.Windows.Forms.ColumnHeader
    Friend WithEvents pono As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_trans As System.Windows.Forms.TextBox
    Friend WithEvents refno As System.Windows.Forms.ColumnHeader
    Friend WithEvents LViewList As System.Windows.Forms.ListView
    Friend WithEvents cmd_showInvent As System.Windows.Forms.Button
    Friend WithEvents trans_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents daatee As System.Windows.Forms.ColumnHeader
    Friend WithEvents GCInTransitMC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GViewMCIntransit As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents engineno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chassisno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents unitcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents vatamt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents totalcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents unitprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_WhCode As TextBox
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
    Friend WithEvents txt_PoNo As TextBox
    Friend WithEvents txt_RefNo As TextBox
    Friend WithEvents txt_Warehouse As TextBox
    Friend WithEvents txt_Date As TextBox
    Friend WithEvents txt_vendor As TextBox
    Friend WithEvents txt_phoneNo As TextBox
    Friend WithEvents txt_BranchAddress As TextBox
    Friend WithEvents txt_BranchCode As TextBox
    Friend WithEvents txt_UnitCostTot As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_OriginatingMaker As DevExpress.XtraEditors.TextEdit
End Class
