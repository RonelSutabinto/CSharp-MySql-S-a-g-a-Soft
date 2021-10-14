<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_errorcorrectcashiering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_errorcorrectcashiering))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.newtool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolpostpayment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.informationtool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.infoTool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.txt_refno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cifkey = New System.Windows.Forms.Label()
        Me.releasedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_cust = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newtool, Me.ToolStripSeparator2, Me.toolpostpayment, Me.ToolStripSeparator3, Me.informationtool, Me.ToolStripSeparator1, Me.infoTool, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(444, 37)
        Me.ToolStrip1.TabIndex = 223
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'newtool
        '
        Me.newtool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newtool.Image = CType(resources.GetObject("newtool.Image"), System.Drawing.Image)
        Me.newtool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newtool.Name = "newtool"
        Me.newtool.Size = New System.Drawing.Size(23, 34)
        Me.newtool.Text = "ToolStripButton2"
        Me.newtool.ToolTipText = "NEW"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'toolpostpayment
        '
        Me.toolpostpayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolpostpayment.Image = CType(resources.GetObject("toolpostpayment.Image"), System.Drawing.Image)
        Me.toolpostpayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolpostpayment.Name = "toolpostpayment"
        Me.toolpostpayment.Size = New System.Drawing.Size(23, 34)
        Me.toolpostpayment.Text = "ToolStripButton1"
        Me.toolpostpayment.ToolTipText = "UPDATE"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
        '
        'informationtool
        '
        Me.informationtool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.informationtool.Image = CType(resources.GetObject("informationtool.Image"), System.Drawing.Image)
        Me.informationtool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.informationtool.Name = "informationtool"
        Me.informationtool.Size = New System.Drawing.Size(23, 34)
        Me.informationtool.Text = "ToolStripButton3"
        Me.informationtool.ToolTipText = "FIND ACCOUNT"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'infoTool
        '
        Me.infoTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.infoTool.Image = CType(resources.GetObject("infoTool.Image"), System.Drawing.Image)
        Me.infoTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.infoTool.Name = "infoTool"
        Me.infoTool.Size = New System.Drawing.Size(23, 34)
        Me.infoTool.Text = "infoTool"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 34)
        Me.ToolStripButton1.Text = "OR"
        Me.ToolStripButton1.ToolTipText = "Print"
        '
        'txt_refno
        '
        Me.txt_refno.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_refno.Location = New System.Drawing.Point(125, 194)
        Me.txt_refno.Name = "txt_refno"
        Me.txt_refno.Size = New System.Drawing.Size(164, 23)
        Me.txt_refno.TabIndex = 233
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 28)
        Me.Label2.TabIndex = 232
        Me.Label2.Text = "REF No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_cifkey
        '
        Me.txt_cifkey.BackColor = System.Drawing.Color.White
        Me.txt_cifkey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cifkey.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cifkey.ForeColor = System.Drawing.Color.Red
        Me.txt_cifkey.Location = New System.Drawing.Point(125, 90)
        Me.txt_cifkey.Name = "txt_cifkey"
        Me.txt_cifkey.Size = New System.Drawing.Size(86, 33)
        Me.txt_cifkey.TabIndex = 229
        Me.txt_cifkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'releasedDate
        '
        Me.releasedDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.releasedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.releasedDate.Location = New System.Drawing.Point(125, 164)
        Me.releasedDate.Name = "releasedDate"
        Me.releasedDate.Size = New System.Drawing.Size(307, 23)
        Me.releasedDate.TabIndex = 230
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(10, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 28)
        Me.Label13.TabIndex = 231
        Me.Label13.Text = "POSTING DATE"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_cust
        '
        Me.txt_cust.BackColor = System.Drawing.Color.White
        Me.txt_cust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cust.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cust.ForeColor = System.Drawing.Color.Red
        Me.txt_cust.Location = New System.Drawing.Point(125, 51)
        Me.txt_cust.Name = "txt_cust"
        Me.txt_cust.Size = New System.Drawing.Size(307, 33)
        Me.txt_cust.TabIndex = 227
        Me.txt_cust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 33)
        Me.Label1.TabIndex = 226
        Me.Label1.Text = "CUSTOMER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 32)
        Me.Label3.TabIndex = 225
        Me.Label3.Text = "CIF No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_address
        '
        Me.txt_address.BackColor = System.Drawing.Color.White
        Me.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_address.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.ForeColor = System.Drawing.Color.Red
        Me.txt_address.Location = New System.Drawing.Point(125, 127)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(307, 33)
        Me.txt_address.TabIndex = 235
        Me.txt_address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 32)
        Me.Label5.TabIndex = 234
        Me.Label5.Text = "ADDRESS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'admin_errorcorrectcashiering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(444, 238)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_refno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cifkey)
        Me.Controls.Add(Me.releasedDate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_cust)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "admin_errorcorrectcashiering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERROR CORRECT-CASHIERING"
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
    Friend WithEvents infoTool As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt_refno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cifkey As System.Windows.Forms.Label
    Friend WithEvents releasedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_cust As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
