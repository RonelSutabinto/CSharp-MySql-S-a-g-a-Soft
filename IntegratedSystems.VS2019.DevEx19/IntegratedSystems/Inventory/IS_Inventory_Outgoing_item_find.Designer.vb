<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Inventory_Outgoing_item_find
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
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.quickSearch = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.LViewItemsOutgoing = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PrevID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PostingDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IfExist = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.whcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.branc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.model = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.color = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EngineNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chasisno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.keyno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BranchCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AccountNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LedgerSetNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SpecNotes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AccountName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ComboBox2
        '
        Me.ComboBox2.ForeColor = System.Drawing.Color.Teal
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(149, 58)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(274, 23)
        Me.ComboBox2.TabIndex = 26
        Me.ComboBox2.Text = "Select Maker"
        '
        'ComboBox1
        '
        Me.ComboBox1.ForeColor = System.Drawing.Color.Teal
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(2, 58)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(132, 23)
        Me.ComboBox1.TabIndex = 25
        Me.ComboBox1.Text = "Select Model"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Quicksearch"
        '
        'quickSearch
        '
        Me.quickSearch.ForeColor = System.Drawing.Color.Teal
        Me.quickSearch.Location = New System.Drawing.Point(80, 32)
        Me.quickSearch.Name = "quickSearch"
        Me.quickSearch.Size = New System.Drawing.Size(759, 22)
        Me.quickSearch.TabIndex = 23
        '
        'ComboBox3
        '
        Me.ComboBox3.ForeColor = System.Drawing.Color.Teal
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(429, 58)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(410, 23)
        Me.ComboBox3.TabIndex = 27
        Me.ComboBox3.Text = "Select Brand"
        '
        'LViewItemsOutgoing
        '
        Me.LViewItemsOutgoing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LViewItemsOutgoing.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.PrevID, Me.PostingDate, Me.IfExist, Me.whcode, Me.branc, Me.model, Me.color, Me.brand, Me.EngineNo, Me.chasisno, Me.unitcost, Me.vat, Me.totalcost, Me.unitPrice, Me.keyno, Me.desc, Me.code, Me.BranchCode, Me.AccountNumber, Me.LedgerSetNumber, Me.SpecNotes, Me.AccountName})
        Me.LViewItemsOutgoing.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItemsOutgoing.ForeColor = System.Drawing.Color.Black
        Me.LViewItemsOutgoing.FullRowSelect = True
        Me.LViewItemsOutgoing.GridLines = True
        Me.LViewItemsOutgoing.HideSelection = False
        Me.LViewItemsOutgoing.Location = New System.Drawing.Point(4, 87)
        Me.LViewItemsOutgoing.Name = "LViewItemsOutgoing"
        Me.LViewItemsOutgoing.Size = New System.Drawing.Size(835, 290)
        Me.LViewItemsOutgoing.TabIndex = 28
        Me.LViewItemsOutgoing.UseCompatibleStateImageBehavior = False
        Me.LViewItemsOutgoing.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.ID.text = "ID"
        '
        'PrevID
        '
        Me.PrevID.text = "PREVID"
        '
        'PostingDate
        '
        Me.PostingDate.Text = "POSTINGDATE"
        Me.PostingDate.Width = 100
        '
        'IfExist
        '
        Me.IfExist.Text = "IFEXIST"
        '
        'whcode
        '
        Me.whcode.Text = "WHCode"
        '
        'branc
        '
        Me.branc.Text = "BRANCH"
        '
        'model
        '
        Me.model.Text = "MODEL"
        Me.model.Width = 90
        '
        'color
        '
        Me.color.Text = "COLOR"
        Me.color.Width = 88
        '
        'brand
        '
        Me.brand.Text = "BRAND"
        Me.brand.Width = 95
        '
        'EngineNo
        '
        Me.EngineNo.Text = "ENGINE No"
        Me.EngineNo.Width = 105
        '
        'chasisno
        '
        Me.chasisno.Text = "CHASSIS  No"
        Me.chasisno.Width = 105
        '
        'unitcost
        '
        Me.unitcost.Text = "UNIT COST"
        Me.unitcost.Width = 107
        '
        'vat
        '
        Me.vat.Text = "VAT"
        Me.vat.Width = 71
        '
        'totalcost
        '
        Me.totalcost.Text = "TOTAL COST"
        Me.totalcost.Width = 95
        '
        'unitPrice
        '
        Me.unitPrice.Text = "UNIT PRICE"
        Me.unitPrice.Width = 72
        '
        'keyno
        '
        Me.keyno.Text = "KEY No"
        '
        'desc
        '
        Me.desc.Text = "DESCRIPTION"
        Me.desc.Width = 149
        '
        'code
        '
        Me.code.Text = "CODE"
        Me.code.Width = 77
        '
        'BranchCode
        '
        Me.BranchCode.Text = "BrCode"
        '
        'AccountNumber
        '
        Me.AccountNumber.Text = "AccountNumber"
        '
        'LedgerSetNumber
        '
        Me.LedgerSetNumber.Text = "LedgerSetNumber"
        '
        'SpecNotes
        '
        Me.SpecNotes.Text = "SpecificNotes"
        '
        'AccountName
        '
        Me.AccountName.Text = "AccountName"
        '
        'IS_Inventory_Outgoing_item_find
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(845, 383)
        Me.Controls.Add(Me.LViewItemsOutgoing)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.quickSearch)
        Me.Controls.Add(Me.ComboBox3)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Inventory_Outgoing_item_find"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IS_Inventory_Outgoing_item_find"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents quickSearch As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents LViewItemsOutgoing As System.Windows.Forms.ListView
    Friend WithEvents code As System.Windows.Forms.ColumnHeader
    Friend WithEvents model As System.Windows.Forms.ColumnHeader
    Friend WithEvents desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents color As System.Windows.Forms.ColumnHeader
    Friend WithEvents brand As System.Windows.Forms.ColumnHeader
    Friend WithEvents chasisno As System.Windows.Forms.ColumnHeader
    Friend WithEvents EngineNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents vat As System.Windows.Forms.ColumnHeader
    Friend WithEvents totalcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents keyno As System.Windows.Forms.ColumnHeader
    Friend WithEvents IfExist As System.Windows.Forms.ColumnHeader
    Friend WithEvents branc As System.Windows.Forms.ColumnHeader
    Friend WithEvents whcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents PrevID As ColumnHeader
    Friend WithEvents PostingDate As ColumnHeader
    Friend WithEvents BranchCode As ColumnHeader
    Friend WithEvents AccountNumber As ColumnHeader
    Friend WithEvents LedgerSetNumber As ColumnHeader
    Friend WithEvents SpecNotes As ColumnHeader
    Friend WithEvents AccountName As ColumnHeader
End Class
