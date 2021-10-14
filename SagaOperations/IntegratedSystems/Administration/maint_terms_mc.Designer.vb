<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maint_terms_mc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(maint_terms_mc))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.newtool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolpostpayment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.informationtool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.LViewShowModel = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.terms = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_model = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_rate = New System.Windows.Forms.TextBox()
        Me.txt_terms = New System.Windows.Forms.TextBox()
        Me.Label_id = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Teal
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newtool, Me.ToolStripSeparator2, Me.toolpostpayment, Me.ToolStripSeparator3, Me.informationtool, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(453, 29)
        Me.ToolStrip1.TabIndex = 215
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'newtool
        '
        Me.newtool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newtool.Image = CType(resources.GetObject("newtool.Image"), System.Drawing.Image)
        Me.newtool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newtool.Name = "newtool"
        Me.newtool.Size = New System.Drawing.Size(23, 26)
        Me.newtool.Text = "ToolStripButton2"
        Me.newtool.ToolTipText = "NEW"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'toolpostpayment
        '
        Me.toolpostpayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolpostpayment.Image = CType(resources.GetObject("toolpostpayment.Image"), System.Drawing.Image)
        Me.toolpostpayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolpostpayment.Name = "toolpostpayment"
        Me.toolpostpayment.Size = New System.Drawing.Size(23, 26)
        Me.toolpostpayment.Text = "ToolStripButton1"
        Me.toolpostpayment.ToolTipText = "POST"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 29)
        '
        'informationtool
        '
        Me.informationtool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.informationtool.Image = CType(resources.GetObject("informationtool.Image"), System.Drawing.Image)
        Me.informationtool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.informationtool.Name = "informationtool"
        Me.informationtool.Size = New System.Drawing.Size(23, 26)
        Me.informationtool.Text = "ToolStripButton3"
        Me.informationtool.ToolTipText = "Account Information"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 26)
        Me.ToolStripButton1.Text = "OR"
        Me.ToolStripButton1.ToolTipText = "Print"
        '
        'LViewShowModel
        '
        Me.LViewShowModel.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.LViewShowModel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LViewShowModel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.terms, Me.rate})
        Me.LViewShowModel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewShowModel.ForeColor = System.Drawing.Color.Teal
        Me.LViewShowModel.FullRowSelect = True
        Me.LViewShowModel.GridLines = True
        Me.LViewShowModel.Location = New System.Drawing.Point(12, 74)
        Me.LViewShowModel.Name = "LViewShowModel"
        Me.LViewShowModel.Size = New System.Drawing.Size(429, 157)
        Me.LViewShowModel.TabIndex = 216
        Me.LViewShowModel.UseCompatibleStateImageBehavior = False
        Me.LViewShowModel.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 110
        '
        'terms
        '
        Me.terms.Text = "TERMS"
        Me.terms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.terms.Width = 157
        '
        'rate
        '
        Me.rate.Text = "RATE"
        Me.rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.rate.Width = 158
        '
        'lbl_id
        '
        Me.lbl_id.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.Teal
        Me.lbl_id.Location = New System.Drawing.Point(14, 44)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(65, 22)
        Me.lbl_id.TabIndex = 217
        Me.lbl_id.Text = "MODEL"
        Me.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_model
        '
        Me.txt_model.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_model.FormattingEnabled = True
        Me.txt_model.Location = New System.Drawing.Point(85, 45)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(286, 23)
        Me.txt_model.TabIndex = 219
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(241, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 22)
        Me.Label1.TabIndex = 220
        Me.Label1.Text = "RATE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(15, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 22)
        Me.Label2.TabIndex = 222
        Me.Label2.Text = "TERM"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_rate
        '
        Me.txt_rate.Location = New System.Drawing.Point(294, 259)
        Me.txt_rate.Name = "txt_rate"
        Me.txt_rate.Size = New System.Drawing.Size(147, 23)
        Me.txt_rate.TabIndex = 223
        '
        'txt_terms
        '
        Me.txt_terms.Location = New System.Drawing.Point(75, 258)
        Me.txt_terms.Name = "txt_terms"
        Me.txt_terms.Size = New System.Drawing.Size(147, 23)
        Me.txt_terms.TabIndex = 224
        '
        'Label_id
        '
        Me.Label_id.BackColor = System.Drawing.Color.White
        Me.Label_id.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_id.ForeColor = System.Drawing.Color.Teal
        Me.Label_id.Location = New System.Drawing.Point(377, 46)
        Me.Label_id.Name = "Label_id"
        Me.Label_id.Size = New System.Drawing.Size(64, 22)
        Me.Label_id.TabIndex = 225
        Me.Label_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(12, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(429, 22)
        Me.Label3.TabIndex = 226
        Me.Label3.Text = "To delete terms and rate please double click data on the table and click DELETE T" & _
            "oolbar"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'maint_terms_mc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(453, 316)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_id)
        Me.Controls.Add(Me.txt_terms)
        Me.Controls.Add(Me.txt_rate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_model)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.LViewShowModel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "maint_terms_mc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TERMS and RATES"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents newtool As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolpostpayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents informationtool As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents LViewShowModel As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents terms As System.Windows.Forms.ColumnHeader
    Friend WithEvents rate As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents txt_model As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_rate As System.Windows.Forms.TextBox
    Friend WithEvents txt_terms As System.Windows.Forms.TextBox
    Friend WithEvents Label_id As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
