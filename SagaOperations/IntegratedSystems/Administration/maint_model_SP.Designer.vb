<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maint_model_SP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(maint_model_SP))
        Me.LViewItems = New System.Windows.Forms.ListView()
        Me.partsno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PartsName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.srp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_PartsNumber = New System.Windows.Forms.TextBox()
        Me.txt_PartsName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Category = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_PriceWOVAT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_PriceWVat = New System.Windows.Forms.TextBox()
        Me.txt_SRP = New System.Windows.Forms.TextBox()
        Me.txt_DiscAmt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_DiscPct = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PostingDate = New System.Windows.Forms.DateTimePicker()
        Me.txt_Remarks = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_ModelCode = New System.Windows.Forms.TextBox()
        Me.txt_Note = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_ModelName = New System.Windows.Forms.TextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolClear = New System.Windows.Forms.ToolStripButton()
        Me.ToolReg = New System.Windows.Forms.ToolStripButton()
        Me.ToolDELETE = New System.Windows.Forms.ToolStripButton()
        Me.quickSearch = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_CostWVAT = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_rows = New System.Windows.Forms.Label()
        Me.txt_CostWoVAT = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        CType(Me.txt_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LViewItems.Location = New System.Drawing.Point(6, 64)
        Me.LViewItems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LViewItems.Name = "LViewItems"
        Me.LViewItems.Size = New System.Drawing.Size(805, 125)
        Me.LViewItems.TabIndex = 105
        Me.LViewItems.UseCompatibleStateImageBehavior = False
        Me.LViewItems.View = System.Windows.Forms.View.Details
        '
        'partsno
        '
        Me.partsno.Text = "PARTS #"
        Me.partsno.Width = 146
        '
        'PartsName
        '
        Me.PartsName.Text = "PARTS NAME"
        Me.PartsName.Width = 232
        '
        'srp
        '
        Me.srp.Text = "SRP"
        Me.srp.Width = 115
        '
        'qty
        '
        Me.qty.Text = "QTY"
        Me.qty.Width = 91
        '
        'id
        '
        Me.id.Text = "ID"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(14, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "PARTS #"
        '
        'txt_PartsNumber
        '
        Me.txt_PartsNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PartsNumber.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsNumber.ForeColor = System.Drawing.Color.Teal
        Me.txt_PartsNumber.Location = New System.Drawing.Point(119, 51)
        Me.txt_PartsNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PartsNumber.Name = "txt_PartsNumber"
        Me.txt_PartsNumber.Size = New System.Drawing.Size(252, 27)
        Me.txt_PartsNumber.TabIndex = 107
        '
        'txt_PartsName
        '
        Me.txt_PartsName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PartsName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsName.ForeColor = System.Drawing.Color.Teal
        Me.txt_PartsName.Location = New System.Drawing.Point(119, 82)
        Me.txt_PartsName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PartsName.Name = "txt_PartsName"
        Me.txt_PartsName.Size = New System.Drawing.Size(252, 27)
        Me.txt_PartsName.TabIndex = 109
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(14, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "PARTS NAME"
        '
        'txt_Category
        '
        Me.txt_Category.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Category.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Category.ForeColor = System.Drawing.Color.Teal
        Me.txt_Category.Location = New System.Drawing.Point(119, 113)
        Me.txt_Category.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Category.Name = "txt_Category"
        Me.txt_Category.Size = New System.Drawing.Size(252, 27)
        Me.txt_Category.TabIndex = 111
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(14, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "CATEGORY"
        '
        'txt_ID
        '
        Me.txt_ID.Enabled = False
        Me.txt_ID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.ForeColor = System.Drawing.Color.Teal
        Me.txt_ID.Location = New System.Drawing.Point(119, 20)
        Me.txt_ID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(252, 27)
        Me.txt_ID.TabIndex = 116
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Teal
        Me.Label16.Location = New System.Drawing.Point(14, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 20)
        Me.Label16.TabIndex = 115
        Me.Label16.Text = "ID #"
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(528, 62)
        Me.txt_quantity.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(235, 43)
        Me.txt_quantity.TabIndex = 114
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Teal
        Me.Label9.Location = New System.Drawing.Point(377, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 37)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "QUANTITY"
        '
        'txt_PriceWOVAT
        '
        Me.txt_PriceWOVAT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PriceWOVAT.ForeColor = System.Drawing.Color.Teal
        Me.txt_PriceWOVAT.Location = New System.Drawing.Point(537, 51)
        Me.txt_PriceWOVAT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PriceWOVAT.Name = "txt_PriceWOVAT"
        Me.txt_PriceWOVAT.Size = New System.Drawing.Size(179, 27)
        Me.txt_PriceWOVAT.TabIndex = 115
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(405, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 20)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "PRICE WoVAT"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(405, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 20)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "PRICE WVAT"
        '
        'txt_PriceWVat
        '
        Me.txt_PriceWVat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PriceWVat.ForeColor = System.Drawing.Color.Teal
        Me.txt_PriceWVat.Location = New System.Drawing.Point(537, 17)
        Me.txt_PriceWVat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PriceWVat.Name = "txt_PriceWVat"
        Me.txt_PriceWVat.Size = New System.Drawing.Size(179, 27)
        Me.txt_PriceWVat.TabIndex = 113
        '
        'txt_SRP
        '
        Me.txt_SRP.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SRP.ForeColor = System.Drawing.Color.Teal
        Me.txt_SRP.Location = New System.Drawing.Point(180, 18)
        Me.txt_SRP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_SRP.Name = "txt_SRP"
        Me.txt_SRP.Size = New System.Drawing.Size(193, 27)
        Me.txt_SRP.TabIndex = 107
        '
        'txt_DiscAmt
        '
        Me.txt_DiscAmt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DiscAmt.ForeColor = System.Drawing.Color.Teal
        Me.txt_DiscAmt.Location = New System.Drawing.Point(180, 86)
        Me.txt_DiscAmt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_DiscAmt.Name = "txt_DiscAmt"
        Me.txt_DiscAmt.Size = New System.Drawing.Size(193, 27)
        Me.txt_DiscAmt.TabIndex = 111
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(14, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "SRP"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(14, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 20)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "DISCOUNT AMT"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(14, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "DISCOUNT PCT"
        '
        'txt_DiscPct
        '
        Me.txt_DiscPct.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DiscPct.ForeColor = System.Drawing.Color.Teal
        Me.txt_DiscPct.Location = New System.Drawing.Point(180, 52)
        Me.txt_DiscPct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_DiscPct.Name = "txt_DiscPct"
        Me.txt_DiscPct.Size = New System.Drawing.Size(193, 27)
        Me.txt_DiscPct.TabIndex = 109
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Teal
        Me.Label14.Location = New System.Drawing.Point(16, 123)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 20)
        Me.Label14.TabIndex = 115
        Me.Label14.Text = "POSTING DATE"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PostingDate
        '
        Me.PostingDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PostingDate.Location = New System.Drawing.Point(131, 118)
        Me.PostingDate.Name = "PostingDate"
        Me.PostingDate.Size = New System.Drawing.Size(236, 27)
        Me.PostingDate.TabIndex = 114
        '
        'txt_Remarks
        '
        Me.txt_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Remarks.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.ForeColor = System.Drawing.Color.Teal
        Me.txt_Remarks.Location = New System.Drawing.Point(532, 84)
        Me.txt_Remarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(262, 27)
        Me.txt_Remarks.TabIndex = 113
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(407, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 20)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "REMARKS"
        '
        'txt_ModelCode
        '
        Me.txt_ModelCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ModelCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ModelCode.ForeColor = System.Drawing.Color.Teal
        Me.txt_ModelCode.Location = New System.Drawing.Point(131, 16)
        Me.txt_ModelCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ModelCode.Name = "txt_ModelCode"
        Me.txt_ModelCode.Size = New System.Drawing.Size(663, 27)
        Me.txt_ModelCode.TabIndex = 107
        '
        'txt_Note
        '
        Me.txt_Note.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Note.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Note.ForeColor = System.Drawing.Color.Teal
        Me.txt_Note.Location = New System.Drawing.Point(131, 84)
        Me.txt_Note.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Note.Name = "txt_Note"
        Me.txt_Note.Size = New System.Drawing.Size(236, 27)
        Me.txt_Note.TabIndex = 111
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(16, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 20)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "MODEL CODE"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(16, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 20)
        Me.Label12.TabIndex = 110
        Me.Label12.Text = "NOTE"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Teal
        Me.Label13.Location = New System.Drawing.Point(16, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 20)
        Me.Label13.TabIndex = 108
        Me.Label13.Text = "MODEL NAME"
        '
        'txt_ModelName
        '
        Me.txt_ModelName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ModelName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ModelName.ForeColor = System.Drawing.Color.Teal
        Me.txt_ModelName.Location = New System.Drawing.Point(131, 50)
        Me.txt_ModelName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ModelName.Name = "txt_ModelName"
        Me.txt_ModelName.Size = New System.Drawing.Size(663, 27)
        Me.txt_ModelName.TabIndex = 109
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.Color.White
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolClear, Me.ToolReg, Me.ToolDELETE})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(818, 28)
        Me.ToolStrip2.TabIndex = 191
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolClear
        '
        Me.ToolClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolClear.Image = CType(resources.GetObject("ToolClear.Image"), System.Drawing.Image)
        Me.ToolClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolClear.Name = "ToolClear"
        Me.ToolClear.Size = New System.Drawing.Size(23, 25)
        Me.ToolClear.Text = "ToolStripButton2"
        Me.ToolClear.ToolTipText = "CLEAR"
        '
        'ToolReg
        '
        Me.ToolReg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolReg.Image = CType(resources.GetObject("ToolReg.Image"), System.Drawing.Image)
        Me.ToolReg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolReg.Name = "ToolReg"
        Me.ToolReg.Size = New System.Drawing.Size(23, 25)
        Me.ToolReg.Text = "ToolStripButton1"
        Me.ToolReg.ToolTipText = "POST"
        '
        'ToolDELETE
        '
        Me.ToolDELETE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolDELETE.Image = CType(resources.GetObject("ToolDELETE.Image"), System.Drawing.Image)
        Me.ToolDELETE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolDELETE.Name = "ToolDELETE"
        Me.ToolDELETE.Size = New System.Drawing.Size(23, 25)
        Me.ToolDELETE.Text = "DELETE"
        '
        'quickSearch
        '
        Me.quickSearch.ForeColor = System.Drawing.Color.Teal
        Me.quickSearch.Location = New System.Drawing.Point(96, 34)
        Me.quickSearch.Name = "quickSearch"
        Me.quickSearch.Size = New System.Drawing.Size(715, 26)
        Me.quickSearch.TabIndex = 192
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(7, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 20)
        Me.Label15.TabIndex = 193
        Me.Label15.Text = "Quicksearch"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(4, 196)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(805, 279)
        Me.TabControl1.TabIndex = 117
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_ID)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.txt_quantity)
        Me.TabPage1.Controls.Add(Me.txt_PartsName)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_PartsNumber)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_Category)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(797, 248)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DESCRIPTION"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txt_CostWoVAT)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.txt_CostWVAT)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.txt_PriceWOVAT)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txt_SRP)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txt_DiscPct)
        Me.TabPage2.Controls.Add(Me.txt_PriceWVat)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txt_DiscAmt)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(797, 248)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "COST AND AMOUNTS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Teal
        Me.Label19.Location = New System.Drawing.Point(479, 224)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(312, 20)
        Me.Label19.TabIndex = 118
        Me.Label19.Text = "On amounts please do not include comma (,) sign."
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_CostWVAT
        '
        Me.txt_CostWVAT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CostWVAT.ForeColor = System.Drawing.Color.Teal
        Me.txt_CostWVAT.Location = New System.Drawing.Point(537, 85)
        Me.txt_CostWVAT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CostWVAT.Name = "txt_CostWVAT"
        Me.txt_CostWVAT.Size = New System.Drawing.Size(179, 27)
        Me.txt_CostWVAT.TabIndex = 117
        Me.txt_CostWVAT.Text = "0.00"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Teal
        Me.Label18.Location = New System.Drawing.Point(405, 93)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 20)
        Me.Label18.TabIndex = 116
        Me.Label18.Text = "COSTWVAT"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.PostingDate)
        Me.TabPage3.Controls.Add(Me.txt_ModelCode)
        Me.TabPage3.Controls.Add(Me.txt_Remarks)
        Me.TabPage3.Controls.Add(Me.txt_ModelName)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.txt_Note)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(797, 248)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "OTHER DETAILS"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(638, 195)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 20)
        Me.Label17.TabIndex = 194
        Me.Label17.Text = "ROW/S:"
        '
        'txt_rows
        '
        Me.txt_rows.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rows.ForeColor = System.Drawing.Color.White
        Me.txt_rows.Location = New System.Drawing.Point(723, 195)
        Me.txt_rows.Name = "txt_rows"
        Me.txt_rows.Size = New System.Drawing.Size(83, 20)
        Me.txt_rows.TabIndex = 195
        Me.txt_rows.Text = "0"
        Me.txt_rows.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_CostWoVAT
        '
        Me.txt_CostWoVAT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CostWoVAT.ForeColor = System.Drawing.Color.Teal
        Me.txt_CostWoVAT.Location = New System.Drawing.Point(537, 120)
        Me.txt_CostWoVAT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CostWoVAT.Name = "txt_CostWoVAT"
        Me.txt_CostWoVAT.Size = New System.Drawing.Size(179, 27)
        Me.txt_CostWoVAT.TabIndex = 120
        Me.txt_CostWoVAT.Text = "0.00"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Teal
        Me.Label20.Location = New System.Drawing.Point(404, 122)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 20)
        Me.Label20.TabIndex = 119
        Me.Label20.Text = "COSTWoVAT"
        '
        'maint_model_SP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(818, 480)
        Me.Controls.Add(Me.txt_rows)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.quickSearch)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.LViewItems)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "maint_model_SP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PARTS MAINTENANCE"
        CType(Me.txt_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LViewItems As System.Windows.Forms.ListView
    Friend WithEvents partsno As System.Windows.Forms.ColumnHeader
    Friend WithEvents PartsName As System.Windows.Forms.ColumnHeader
    Friend WithEvents srp As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_PartsNumber As System.Windows.Forms.TextBox
    Friend WithEvents txt_PartsName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Category As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_PriceWOVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_PriceWVat As System.Windows.Forms.TextBox
    Friend WithEvents txt_SRP As System.Windows.Forms.TextBox
    Friend WithEvents txt_DiscAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_DiscPct As System.Windows.Forms.TextBox
    Friend WithEvents txt_ModelCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_Note As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_ModelName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolReg As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolDELETE As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PostingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_quantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents quickSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents qty As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_rows As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_CostWVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_CostWoVAT As TextBox
    Friend WithEvents Label20 As Label
End Class
