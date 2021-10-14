<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Sales_SP_temp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Sales_SP_temp))
        Me.quickSearch = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_PartsNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_PartsName = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.newtool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolpostpayment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.informationtool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.toolCALC = New System.Windows.Forms.ToolStripButton()
        Me.txt_rows = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LViewItems = New System.Windows.Forms.ListView()
        Me.partsno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PartsName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.srp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.txt_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'quickSearch
        '
        Me.quickSearch.ForeColor = System.Drawing.Color.Teal
        Me.quickSearch.Location = New System.Drawing.Point(118, 55)
        Me.quickSearch.Name = "quickSearch"
        Me.quickSearch.Size = New System.Drawing.Size(774, 23)
        Me.quickSearch.TabIndex = 199
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(12, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 23)
        Me.Label15.TabIndex = 200
        Me.Label15.Text = "Quicksearch"
        '
        'txt_ID
        '
        Me.txt_ID.Enabled = False
        Me.txt_ID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.ForeColor = System.Drawing.Color.Teal
        Me.txt_ID.Location = New System.Drawing.Point(132, 28)
        Me.txt_ID.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(186, 26)
        Me.txt_ID.TabIndex = 116
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Teal
        Me.Label16.Location = New System.Drawing.Point(9, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 23)
        Me.Label16.TabIndex = 115
        Me.Label16.Text = "ID #"
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(132, 175)
        Me.txt_quantity.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(186, 40)
        Me.txt_quantity.TabIndex = 114
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Teal
        Me.Label9.Location = New System.Drawing.Point(9, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 23)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = " SOLD QTY"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(9, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "PARTS #"
        '
        'txt_PartsNumber
        '
        Me.txt_PartsNumber.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsNumber.ForeColor = System.Drawing.Color.Teal
        Me.txt_PartsNumber.Location = New System.Drawing.Point(132, 65)
        Me.txt_PartsNumber.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_PartsNumber.Name = "txt_PartsNumber"
        Me.txt_PartsNumber.Size = New System.Drawing.Size(186, 26)
        Me.txt_PartsNumber.TabIndex = 107
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_remarks)
        Me.GroupBox1.Controls.Add(Me.txt_ID)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_quantity)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_PartsNumber)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_PartsName)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(538, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 264)
        Me.GroupBox1.TabIndex = 195
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DESCRIPTION"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(9, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 23)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "REMARKS"
        '
        'txt_remarks
        '
        Me.txt_remarks.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remarks.ForeColor = System.Drawing.Color.Teal
        Me.txt_remarks.Location = New System.Drawing.Point(132, 223)
        Me.txt_remarks.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(186, 26)
        Me.txt_remarks.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(9, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 23)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "PARTS NAME"
        '
        'txt_PartsName
        '
        Me.txt_PartsName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PartsName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsName.ForeColor = System.Drawing.Color.Teal
        Me.txt_PartsName.Location = New System.Drawing.Point(132, 104)
        Me.txt_PartsName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_PartsName.Name = "txt_PartsName"
        Me.txt_PartsName.Size = New System.Drawing.Size(186, 26)
        Me.txt_PartsName.TabIndex = 109
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newtool, Me.ToolStripSeparator2, Me.toolpostpayment, Me.ToolStripSeparator3, Me.informationtool, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.toolCALC})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(904, 34)
        Me.ToolStrip1.TabIndex = 201
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'newtool
        '
        Me.newtool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newtool.Image = CType(resources.GetObject("newtool.Image"), System.Drawing.Image)
        Me.newtool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newtool.Name = "newtool"
        Me.newtool.Size = New System.Drawing.Size(23, 31)
        Me.newtool.Text = "ToolStripButton2"
        Me.newtool.ToolTipText = "NEW"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'toolpostpayment
        '
        Me.toolpostpayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolpostpayment.Image = CType(resources.GetObject("toolpostpayment.Image"), System.Drawing.Image)
        Me.toolpostpayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolpostpayment.Name = "toolpostpayment"
        Me.toolpostpayment.Size = New System.Drawing.Size(23, 31)
        Me.toolpostpayment.Text = "ToolStripButton1"
        Me.toolpostpayment.ToolTipText = "POST"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 34)
        '
        'informationtool
        '
        Me.informationtool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.informationtool.Image = CType(resources.GetObject("informationtool.Image"), System.Drawing.Image)
        Me.informationtool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.informationtool.Name = "informationtool"
        Me.informationtool.Size = New System.Drawing.Size(23, 31)
        Me.informationtool.Text = "ToolStripButton3"
        Me.informationtool.ToolTipText = "Account Information"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 31)
        Me.ToolStripButton1.Text = "OR"
        Me.ToolStripButton1.ToolTipText = "Print"
        '
        'toolCALC
        '
        Me.toolCALC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolCALC.Image = CType(resources.GetObject("toolCALC.Image"), System.Drawing.Image)
        Me.toolCALC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolCALC.Name = "toolCALC"
        Me.toolCALC.Size = New System.Drawing.Size(23, 31)
        Me.toolCALC.Text = "ToolStripButton2"
        Me.toolCALC.ToolTipText = "CALCULATOR"
        '
        'txt_rows
        '
        Me.txt_rows.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rows.ForeColor = System.Drawing.Color.White
        Me.txt_rows.Location = New System.Drawing.Point(69, 353)
        Me.txt_rows.Name = "txt_rows"
        Me.txt_rows.Size = New System.Drawing.Size(100, 20)
        Me.txt_rows.TabIndex = 203
        Me.txt_rows.Text = "0"
        Me.txt_rows.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(1, 353)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 20)
        Me.Label17.TabIndex = 202
        Me.Label17.Text = "ROW/S:"
        '
        'LViewItems
        '
        Me.LViewItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LViewItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.partsno, Me.PartsName, Me.srp, Me.qty, Me.id})
        Me.LViewItems.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItems.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewItems.FullRowSelect = True
        Me.LViewItems.GridLines = True
        Me.LViewItems.HideSelection = False
        Me.LViewItems.Location = New System.Drawing.Point(4, 82)
        Me.LViewItems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LViewItems.Name = "LViewItems"
        Me.LViewItems.Size = New System.Drawing.Size(528, 266)
        Me.LViewItems.TabIndex = 204
        Me.LViewItems.UseCompatibleStateImageBehavior = False
        Me.LViewItems.View = System.Windows.Forms.View.Details
        '
        'partsno
        '
        Me.partsno.Text = "PARTS #"
        Me.partsno.Width = 126
        '
        'PartsName
        '
        Me.PartsName.Text = "PARTS NAME"
        Me.PartsName.Width = 148
        '
        'srp
        '
        Me.srp.Text = "SRP"
        Me.srp.Width = 109
        '
        'qty
        '
        Me.qty.Text = "QTY"
        Me.qty.Width = 81
        '
        'id
        '
        Me.id.Text = "ID"
        '
        'IS_Sales_SP_temp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(904, 379)
        Me.Controls.Add(Me.LViewItems)
        Me.Controls.Add(Me.txt_rows)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.quickSearch)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Sales_SP_temp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPARE PARTS INVENTORY SALES"
        CType(Me.txt_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents quickSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_quantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_PartsNumber As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_PartsName As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents newtool As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolpostpayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents informationtool As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolCALC As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents txt_rows As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LViewItems As System.Windows.Forms.ListView
    Friend WithEvents partsno As System.Windows.Forms.ColumnHeader
    Friend WithEvents PartsName As System.Windows.Forms.ColumnHeader
    Friend WithEvents srp As System.Windows.Forms.ColumnHeader
    Friend WithEvents qty As System.Windows.Forms.ColumnHeader
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
End Class
