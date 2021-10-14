<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Sales_item_find
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Sales_item_find))
        Me.chasisno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.quickSearch = New System.Windows.Forms.TextBox()
        Me.engineno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.color = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.model = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LViewItemsOutgoing = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.keyno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lcp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chasisno
        '
        Me.chasisno.Text = "CHASSIS  No"
        Me.chasisno.Width = 105
        '
        'quickSearch
        '
        Me.quickSearch.ForeColor = System.Drawing.Color.Teal
        Me.quickSearch.Location = New System.Drawing.Point(140, 8)
        Me.quickSearch.Name = "quickSearch"
        Me.quickSearch.Size = New System.Drawing.Size(707, 22)
        Me.quickSearch.TabIndex = 29
        '
        'engineno
        '
        Me.engineno.Text = "ENGINE No"
        Me.engineno.Width = 105
        '
        'brand
        '
        Me.brand.Text = "BRAND"
        Me.brand.Width = 95
        '
        'unitcost
        '
        Me.unitcost.Text = "UNIT COST"
        Me.unitcost.Width = 107
        '
        'unitPrice
        '
        Me.unitPrice.Text = "UNIT PRICE"
        Me.unitPrice.Width = 72
        '
        'vat
        '
        Me.vat.Text = "VAT"
        Me.vat.Width = 71
        '
        'color
        '
        Me.color.Text = "COLOR"
        Me.color.Width = 88
        '
        'totalcost
        '
        Me.totalcost.Text = "TOTAL COST"
        Me.totalcost.Width = 95
        '
        'desc
        '
        Me.desc.Text = "DESCRIPTION"
        Me.desc.Width = 149
        '
        'model
        '
        Me.model.Text = "MODEL"
        Me.model.Width = 90
        '
        'LViewItemsOutgoing
        '
        Me.LViewItemsOutgoing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LViewItemsOutgoing.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.code, Me.model, Me.desc, Me.color, Me.brand, Me.engineno, Me.chasisno, Me.unitcost, Me.vat, Me.totalcost, Me.unitPrice, Me.keyno, Me.cod, Me.lcp, Me.dp})
        Me.LViewItemsOutgoing.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItemsOutgoing.ForeColor = System.Drawing.Color.Teal
        Me.LViewItemsOutgoing.FullRowSelect = True
        Me.LViewItemsOutgoing.GridLines = True
        Me.LViewItemsOutgoing.HideSelection = False
        Me.LViewItemsOutgoing.Location = New System.Drawing.Point(12, 63)
        Me.LViewItemsOutgoing.Name = "LViewItemsOutgoing"
        Me.LViewItemsOutgoing.Size = New System.Drawing.Size(835, 290)
        Me.LViewItemsOutgoing.TabIndex = 34
        Me.LViewItemsOutgoing.UseCompatibleStateImageBehavior = False
        Me.LViewItemsOutgoing.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        '
        'code
        '
        Me.code.Text = "CODE"
        Me.code.Width = 77
        '
        'keyno
        '
        Me.keyno.Text = "KEY No"
        '
        'cod
        '
        Me.cod.Text = "COD"
        '
        'lcp
        '
        Me.lcp.Text = "LCP"
        '
        'dp
        '
        Me.dp.Text = "DP"
        '
        'ComboBox2
        '
        Me.ComboBox2.ForeColor = System.Drawing.Color.Teal
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(157, 34)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(274, 24)
        Me.ComboBox2.TabIndex = 32
        Me.ComboBox2.Text = "Select Maker"
        '
        'ComboBox1
        '
        Me.ComboBox1.ForeColor = System.Drawing.Color.Teal
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(10, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(132, 24)
        Me.ComboBox1.TabIndex = 31
        Me.ComboBox1.Text = "Select Model"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Quicksearch"
        '
        'ComboBox3
        '
        Me.ComboBox3.ForeColor = System.Drawing.Color.Teal
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(437, 34)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(410, 24)
        Me.ComboBox3.TabIndex = 33
        Me.ComboBox3.Text = "Select Brand"
        '
        'lbl_id
        '
        Me.lbl_id.Location = New System.Drawing.Point(403, 389)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(141, 23)
        Me.lbl_id.TabIndex = 35
        Me.lbl_id.Text = "Label2"
        '
        'IS_Sales_item_find
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(851, 356)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.quickSearch)
        Me.Controls.Add(Me.LViewItemsOutgoing)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Sales_item_find"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IS_Sales_item_find"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chasisno As System.Windows.Forms.ColumnHeader
    Friend WithEvents quickSearch As System.Windows.Forms.TextBox
    Friend WithEvents engineno As System.Windows.Forms.ColumnHeader
    Friend WithEvents brand As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents vat As System.Windows.Forms.ColumnHeader
    Friend WithEvents color As System.Windows.Forms.ColumnHeader
    Friend WithEvents totalcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents model As System.Windows.Forms.ColumnHeader
    Friend WithEvents LViewItemsOutgoing As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents code As System.Windows.Forms.ColumnHeader
    Friend WithEvents keyno As System.Windows.Forms.ColumnHeader
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents cod As System.Windows.Forms.ColumnHeader
    Friend WithEvents lcp As System.Windows.Forms.ColumnHeader
    Friend WithEvents dp As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_id As System.Windows.Forms.Label
End Class
