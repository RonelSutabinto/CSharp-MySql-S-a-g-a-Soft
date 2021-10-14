<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Inquiry_Refno
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Reference = New System.Windows.Forms.TextBox()
        Me.lvDetails = New System.Windows.Forms.ListView()
        Me.Did = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.refno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vendor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.transcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateReceived = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.POno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.whcategory = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.whCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.inventoryStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IfExist = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.model = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.color = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EngineNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChassisNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.keyno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vatamt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitprice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.transactedby = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.transactiondate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.branchcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.note = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_grp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.prevID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.temp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Remarks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvMaster = New System.Windows.Forms.ListView()
        Me.Mid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mrefno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mvendor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mtranscode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MinventoryStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MdateReceived = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MPOno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mwhcategory = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MwhCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mtransactedby = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mtransactiondate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mdateapproved = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalUnitCost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalVATAmt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GrandTotalUnitCost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalUnitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.itemcnt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mbranchcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.approver = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OriginatingBranch = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OriginatingMaker = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MVendorCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SourceEvent = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mremarks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mnote = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_ItemDetailsCount = New System.Windows.Forms.GroupBox()
        Me.lblItemMasterCount = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.lbl_ItemDetailsCount.SuspendLayout()
        Me.lblItemMasterCount.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_Reference)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 38)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Reference No./Chassis No./Engine No. :"
        '
        'txt_Reference
        '
        Me.txt_Reference.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Reference.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Reference.Location = New System.Drawing.Point(342, 8)
        Me.txt_Reference.Name = "txt_Reference"
        Me.txt_Reference.Size = New System.Drawing.Size(538, 27)
        Me.txt_Reference.TabIndex = 0
        '
        'lvDetails
        '
        Me.lvDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Did, Me.refno, Me.vendor, Me.transcode, Me.dateReceived, Me.POno, Me.whcategory, Me.whCode, Me.inventoryStatus, Me.IfExist, Me.Code, Me.model, Me.color, Me.description, Me.brand, Me.EngineNo, Me.ChassisNo, Me.keyno, Me.unitcost, Me.vatamt, Me.totalcost, Me.unitprice, Me.transactedby, Me.transactiondate, Me.branchcode, Me.note, Me.item_grp, Me.prevID, Me.temp, Me.Remarks})
        Me.lvDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvDetails.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDetails.FullRowSelect = True
        Me.lvDetails.GridLines = True
        Me.lvDetails.Location = New System.Drawing.Point(3, 19)
        Me.lvDetails.Name = "lvDetails"
        Me.lvDetails.Size = New System.Drawing.Size(884, 212)
        Me.lvDetails.TabIndex = 0
        Me.lvDetails.UseCompatibleStateImageBehavior = False
        Me.lvDetails.View = System.Windows.Forms.View.Details
        '
        'Did
        '
        Me.DID.text = "ID"
        '
        'refno
        '
        Me.refno.Text = "RefNo"
        '
        'vendor
        '
        Me.vendor.Text = "Vendor"
        '
        'transcode
        '
        Me.transcode.Text = "TransCode"
        '
        'dateReceived
        '
        Me.dateReceived.Text = "DateReceived"
        '
        'POno
        '
        Me.POno.Text = "PONo"
        '
        'whcategory
        '
        Me.whcategory.Text = "WhCategory"
        '
        'whCode
        '
        Me.whCode.Text = "WhCode"
        '
        'inventoryStatus
        '
        Me.inventoryStatus.Text = "InventoryStatus"
        '
        'IfExist
        '
        Me.IfExist.Text = "IfExist"
        '
        'Code
        '
        Me.Code.Text = "Code"
        '
        'model
        '
        Me.model.Text = "Model"
        '
        'color
        '
        Me.color.Text = "Color"
        '
        'description
        '
        Me.description.Text = "Description"
        '
        'brand
        '
        Me.brand.Text = "Brand"
        '
        'EngineNo
        '
        Me.EngineNo.Text = "EngineNo"
        '
        'ChassisNo
        '
        Me.ChassisNo.Text = "ChassisNo"
        '
        'keyno
        '
        Me.keyno.Text = "KeyNo"
        '
        'unitcost
        '
        Me.unitcost.Text = "UnitCost"
        '
        'vatamt
        '
        Me.vatamt.Text = "VatAmt"
        '
        'totalcost
        '
        Me.totalcost.Text = "TotalCost"
        '
        'unitprice
        '
        Me.unitprice.Text = "UnitPrice"
        '
        'transactedby
        '
        Me.transactedby.Text = "TransactedBy"
        '
        'transactiondate
        '
        Me.transactiondate.Text = "TransactionDate"
        '
        'branchcode
        '
        Me.branchcode.Text = "BranchCode"
        '
        'note
        '
        Me.note.Text = "Note"
        '
        'item_grp
        '
        Me.item_grp.Text = "item_grp"
        '
        'prevID
        '
        Me.prevID.text = "prevID"
        '
        'temp
        '
        Me.temp.Text = "Temp"
        '
        'Remarks
        '
        Me.Remarks.Text = "Remarks"
        '
        'lvMaster
        '
        Me.lvMaster.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Mid, Me.Mrefno, Me.Mvendor, Me.Mtranscode, Me.MinventoryStatus, Me.MdateReceived, Me.MPOno, Me.Mwhcategory, Me.MwhCode, Me.Mtransactedby, Me.Mtransactiondate, Me.Mdateapproved, Me.totalUnitCost, Me.totalVATAmt, Me.GrandTotalUnitCost, Me.TotalUnitPrice, Me.itemcnt, Me.Mbranchcode, Me.approver, Me.OriginatingBranch, Me.OriginatingMaker, Me.MVendorCode, Me.SourceEvent, Me.Mremarks, Me.Mnote})
        Me.lvMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvMaster.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMaster.FullRowSelect = True
        Me.lvMaster.GridLines = True
        Me.lvMaster.Location = New System.Drawing.Point(3, 19)
        Me.lvMaster.Name = "lvMaster"
        Me.lvMaster.Size = New System.Drawing.Size(881, 175)
        Me.lvMaster.TabIndex = 1
        Me.lvMaster.UseCompatibleStateImageBehavior = False
        Me.lvMaster.View = System.Windows.Forms.View.Details
        '
        'Mid
        '
        Me.MID.text = "ID"
        '
        'Mrefno
        '
        Me.Mrefno.Text = "RefNo"
        '
        'Mvendor
        '
        Me.Mvendor.Text = "Vendor"
        '
        'Mtranscode
        '
        Me.Mtranscode.Text = "TransCode"
        '
        'MinventoryStatus
        '
        Me.MinventoryStatus.Text = "InventoryStatus"
        '
        'MdateReceived
        '
        Me.MdateReceived.Text = "DateReceived"
        '
        'MPOno
        '
        Me.MPOno.Text = "PONo"
        '
        'Mwhcategory
        '
        Me.Mwhcategory.Text = "WhCategory"
        '
        'MwhCode
        '
        Me.MwhCode.Text = "WhCode"
        '
        'Mtransactedby
        '
        Me.Mtransactedby.Text = "TransactedBy"
        '
        'Mtransactiondate
        '
        Me.Mtransactiondate.Text = "TransactionDate"
        '
        'Mdateapproved
        '
        Me.Mdateapproved.Text = "DateApproved"
        '
        'totalUnitCost
        '
        Me.totalUnitCost.Text = "totalUnitCost"
        '
        'totalVATAmt
        '
        Me.totalVATAmt.Text = "totalVATAmt"
        '
        'GrandTotalUnitCost
        '
        Me.GrandTotalUnitCost.Text = "GrandTotalUnitCost"
        '
        'TotalUnitPrice
        '
        Me.TotalUnitPrice.Text = "TotalUnitPrice"
        '
        'itemcnt
        '
        Me.itemcnt.Text = "itemcnt"
        '
        'Mbranchcode
        '
        Me.Mbranchcode.Text = "branchcode"
        '
        'approver
        '
        Me.approver.Text = "Approver"
        '
        'OriginatingBranch
        '
        Me.OriginatingBranch.Text = "OriginatingBranch"
        '
        'OriginatingMaker
        '
        Me.OriginatingMaker.Text = "OriginatingMaker"
        '
        'MVendorCode
        '
        Me.MVendorCode.Text = "VendorCode"
        '
        'SourceEvent
        '
        Me.SourceEvent.Text = "SourceEvent"
        '
        'Mremarks
        '
        Me.Mremarks.Text = "Remarks"
        '
        'Mnote
        '
        Me.Mnote.Text = "Note"
        '
        'lbl_ItemDetailsCount
        '
        Me.lbl_ItemDetailsCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ItemDetailsCount.Controls.Add(Me.lvMaster)
        Me.lbl_ItemDetailsCount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ItemDetailsCount.Location = New System.Drawing.Point(2, 39)
        Me.lbl_ItemDetailsCount.Name = "lbl_ItemDetailsCount"
        Me.lbl_ItemDetailsCount.Size = New System.Drawing.Size(887, 197)
        Me.lbl_ItemDetailsCount.TabIndex = 5
        Me.lbl_ItemDetailsCount.TabStop = False
        '
        'lblItemMasterCount
        '
        Me.lblItemMasterCount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemMasterCount.Controls.Add(Me.lvDetails)
        Me.lblItemMasterCount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemMasterCount.Location = New System.Drawing.Point(2, 236)
        Me.lblItemMasterCount.Name = "lblItemMasterCount"
        Me.lblItemMasterCount.Size = New System.Drawing.Size(890, 234)
        Me.lblItemMasterCount.TabIndex = 6
        Me.lblItemMasterCount.TabStop = False
        '
        'IS_Inquiry_Refno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(896, 479)
        Me.Controls.Add(Me.lblItemMasterCount)
        Me.Controls.Add(Me.lbl_ItemDetailsCount)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Inquiry_Refno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVENTORY TRANSACTION MONITORING"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.lbl_ItemDetailsCount.ResumeLayout(False)
        Me.lblItemMasterCount.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Reference As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lvDetails As System.Windows.Forms.ListView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lvMaster As System.Windows.Forms.ListView
    Friend WithEvents Did As System.Windows.Forms.ColumnHeader
    Friend WithEvents refno As System.Windows.Forms.ColumnHeader
    Friend WithEvents vendor As System.Windows.Forms.ColumnHeader
    Friend WithEvents transcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents dateReceived As System.Windows.Forms.ColumnHeader
    Friend WithEvents POno As System.Windows.Forms.ColumnHeader
    Friend WithEvents whcategory As System.Windows.Forms.ColumnHeader
    Friend WithEvents whCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents inventoryStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents IfExist As System.Windows.Forms.ColumnHeader
    Friend WithEvents Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents model As System.Windows.Forms.ColumnHeader
    Friend WithEvents color As System.Windows.Forms.ColumnHeader
    Friend WithEvents description As System.Windows.Forms.ColumnHeader
    Friend WithEvents brand As System.Windows.Forms.ColumnHeader
    Friend WithEvents EngineNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChassisNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents keyno As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents vatamt As System.Windows.Forms.ColumnHeader
    Friend WithEvents totalcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitprice As System.Windows.Forms.ColumnHeader
    Friend WithEvents transactedby As System.Windows.Forms.ColumnHeader
    Friend WithEvents transactiondate As System.Windows.Forms.ColumnHeader
    Friend WithEvents branchcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents note As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_grp As System.Windows.Forms.ColumnHeader
    Friend WithEvents prevID As System.Windows.Forms.ColumnHeader
    Friend WithEvents temp As System.Windows.Forms.ColumnHeader
    Friend WithEvents Remarks As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mid As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mrefno As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mvendor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mtranscode As System.Windows.Forms.ColumnHeader
    Friend WithEvents MinventoryStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents MdateReceived As System.Windows.Forms.ColumnHeader
    Friend WithEvents MPOno As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mwhcategory As System.Windows.Forms.ColumnHeader
    Friend WithEvents MwhCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mtransactedby As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mtransactiondate As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mdateapproved As System.Windows.Forms.ColumnHeader
    Friend WithEvents totalUnitCost As System.Windows.Forms.ColumnHeader
    Friend WithEvents totalVATAmt As System.Windows.Forms.ColumnHeader
    Friend WithEvents GrandTotalUnitCost As System.Windows.Forms.ColumnHeader
    Friend WithEvents TotalUnitPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents itemcnt As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mbranchcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents approver As System.Windows.Forms.ColumnHeader
    Friend WithEvents OriginatingBranch As System.Windows.Forms.ColumnHeader
    Friend WithEvents OriginatingMaker As System.Windows.Forms.ColumnHeader
    Friend WithEvents MVendorCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents SourceEvent As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mremarks As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mnote As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_ItemDetailsCount As GroupBox
    Friend WithEvents lblItemMasterCount As GroupBox
End Class
