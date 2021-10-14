<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_mc_price
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_mc_price))
        Me.LViewShowModel = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.model = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lcp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.aoc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rebates = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.Label()
        Me.txt_brand = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_model = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_lcp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_rebates = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_aoc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.newtool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolpostpayment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.informationtool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LViewShowModel
        '
        Me.LViewShowModel.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.LViewShowModel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LViewShowModel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.brand, Me.model, Me.cod, Me.lcp, Me.aoc, Me.rebates})
        Me.LViewShowModel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewShowModel.ForeColor = System.Drawing.Color.Teal
        Me.LViewShowModel.FullRowSelect = True
        Me.LViewShowModel.GridLines = True
        Me.LViewShowModel.Location = New System.Drawing.Point(6, 37)
        Me.LViewShowModel.Name = "LViewShowModel"
        Me.LViewShowModel.Size = New System.Drawing.Size(667, 416)
        Me.LViewShowModel.TabIndex = 1
        Me.LViewShowModel.UseCompatibleStateImageBehavior = False
        Me.LViewShowModel.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 62
        '
        'brand
        '
        Me.brand.Text = "BRAND"
        Me.brand.Width = 109
        '
        'model
        '
        Me.model.Text = "MODEL"
        Me.model.Width = 104
        '
        'cod
        '
        Me.cod.Text = "COD"
        Me.cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cod.Width = 121
        '
        'lcp
        '
        Me.lcp.Text = "LCP"
        Me.lcp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lcp.Width = 122
        '
        'aoc
        '
        Me.aoc.Text = "AOC"
        Me.aoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.aoc.Width = 118
        '
        'rebates
        '
        Me.rebates.Text = "REBATES"
        Me.rebates.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.rebates.Width = 127
        '
        'txt_cod
        '
        Me.txt_cod.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod.ForeColor = System.Drawing.Color.Teal
        Me.txt_cod.Location = New System.Drawing.Point(753, 243)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(265, 31)
        Me.txt_cod.TabIndex = 200
        Me.txt_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_id
        '
        Me.lbl_id.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.Teal
        Me.lbl_id.Location = New System.Drawing.Point(679, 103)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(36, 24)
        Me.lbl_id.TabIndex = 199
        Me.lbl_id.Text = "ID"
        Me.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.White
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.ForeColor = System.Drawing.Color.Teal
        Me.txt_id.Location = New System.Drawing.Point(753, 102)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(266, 25)
        Me.txt_id.TabIndex = 201
        Me.txt_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_brand
        '
        Me.txt_brand.BackColor = System.Drawing.Color.White
        Me.txt_brand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_brand.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.ForeColor = System.Drawing.Color.Teal
        Me.txt_brand.Location = New System.Drawing.Point(753, 137)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(266, 25)
        Me.txt_brand.TabIndex = 203
        Me.txt_brand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(679, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 24)
        Me.Label2.TabIndex = 202
        Me.Label2.Text = "BRAND"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_model
        '
        Me.txt_model.BackColor = System.Drawing.Color.White
        Me.txt_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_model.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_model.ForeColor = System.Drawing.Color.Teal
        Me.txt_model.Location = New System.Drawing.Point(753, 171)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(266, 25)
        Me.txt_model.TabIndex = 205
        Me.txt_model.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(679, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 24)
        Me.Label4.TabIndex = 204
        Me.Label4.Text = "MODEL"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(679, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 25)
        Me.Label5.TabIndex = 206
        Me.Label5.Text = "COD"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_lcp
        '
        Me.txt_lcp.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lcp.ForeColor = System.Drawing.Color.Teal
        Me.txt_lcp.Location = New System.Drawing.Point(753, 338)
        Me.txt_lcp.Name = "txt_lcp"
        Me.txt_lcp.Size = New System.Drawing.Size(265, 31)
        Me.txt_lcp.TabIndex = 207
        Me.txt_lcp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(679, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 25)
        Me.Label6.TabIndex = 208
        Me.Label6.Text = "LCP"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_rebates
        '
        Me.txt_rebates.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rebates.ForeColor = System.Drawing.Color.Teal
        Me.txt_rebates.Location = New System.Drawing.Point(753, 384)
        Me.txt_rebates.Name = "txt_rebates"
        Me.txt_rebates.Size = New System.Drawing.Size(265, 31)
        Me.txt_rebates.TabIndex = 211
        Me.txt_rebates.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(678, 391)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 25)
        Me.Label7.TabIndex = 212
        Me.Label7.Text = "REBATES"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_aoc
        '
        Me.txt_aoc.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_aoc.ForeColor = System.Drawing.Color.Teal
        Me.txt_aoc.Location = New System.Drawing.Point(753, 291)
        Me.txt_aoc.Name = "txt_aoc"
        Me.txt_aoc.Size = New System.Drawing.Size(265, 31)
        Me.txt_aoc.TabIndex = 209
        Me.txt_aoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(679, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 25)
        Me.Label8.TabIndex = 210
        Me.Label8.Text = "AOC"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Orange
        Me.Label9.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(671, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(360, 41)
        Me.Label9.TabIndex = 213
        Me.Label9.Text = "PARAMETERS"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Teal
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newtool, Me.ToolStripSeparator2, Me.toolpostpayment, Me.ToolStripSeparator3, Me.informationtool, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1031, 34)
        Me.ToolStrip1.TabIndex = 214
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
        'main_mc_price
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1031, 465)
        Me.Controls.Add(Me.LViewShowModel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_rebates)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_aoc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_lcp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_cod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_model)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main_mc_price"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRICE MONITORING"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LViewShowModel As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents brand As System.Windows.Forms.ColumnHeader
    Friend WithEvents model As System.Windows.Forms.ColumnHeader
    Friend WithEvents cod As System.Windows.Forms.ColumnHeader
    Friend WithEvents lcp As System.Windows.Forms.ColumnHeader
    Friend WithEvents aoc As System.Windows.Forms.ColumnHeader
    Friend WithEvents rebates As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.Label
    Friend WithEvents txt_brand As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_model As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_lcp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_rebates As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_aoc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents newtool As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolpostpayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents informationtool As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
