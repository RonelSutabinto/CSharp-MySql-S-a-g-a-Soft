<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_acctCancel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_acctCancel))
        Me.txt_acctno = New System.Windows.Forms.Label()
        Me.txt_LedSet = New System.Windows.Forms.Label()
        Me.txt_branchcode = New System.Windows.Forms.Label()
        Me.releasedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_cust = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolpost = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.informationtool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.toolCALC = New System.Windows.Forms.ToolStripButton()
        Me.toolexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_acctno
        '
        Me.txt_acctno.BackColor = System.Drawing.Color.White
        Me.txt_acctno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_acctno.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acctno.ForeColor = System.Drawing.Color.Red
        Me.txt_acctno.Location = New System.Drawing.Point(181, 77)
        Me.txt_acctno.Name = "txt_acctno"
        Me.txt_acctno.Size = New System.Drawing.Size(167, 25)
        Me.txt_acctno.TabIndex = 205
        Me.txt_acctno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_LedSet
        '
        Me.txt_LedSet.BackColor = System.Drawing.Color.White
        Me.txt_LedSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_LedSet.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LedSet.ForeColor = System.Drawing.Color.Red
        Me.txt_LedSet.Location = New System.Drawing.Point(345, 77)
        Me.txt_LedSet.Name = "txt_LedSet"
        Me.txt_LedSet.Size = New System.Drawing.Size(34, 25)
        Me.txt_LedSet.TabIndex = 209
        Me.txt_LedSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_branchcode
        '
        Me.txt_branchcode.BackColor = System.Drawing.Color.White
        Me.txt_branchcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_branchcode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_branchcode.ForeColor = System.Drawing.Color.Red
        Me.txt_branchcode.Location = New System.Drawing.Point(122, 77)
        Me.txt_branchcode.Name = "txt_branchcode"
        Me.txt_branchcode.Size = New System.Drawing.Size(64, 25)
        Me.txt_branchcode.TabIndex = 206
        Me.txt_branchcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'releasedDate
        '
        Me.releasedDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.releasedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.releasedDate.Location = New System.Drawing.Point(122, 125)
        Me.releasedDate.Name = "releasedDate"
        Me.releasedDate.Size = New System.Drawing.Size(257, 23)
        Me.releasedDate.TabIndex = 207
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(14, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 21)
        Me.Label13.TabIndex = 208
        Me.Label13.Text = "RELEASE DATE"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_cust
        '
        Me.txt_cust.BackColor = System.Drawing.Color.White
        Me.txt_cust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cust.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cust.ForeColor = System.Drawing.Color.Red
        Me.txt_cust.Location = New System.Drawing.Point(122, 101)
        Me.txt_cust.Name = "txt_cust"
        Me.txt_cust.Size = New System.Drawing.Size(257, 25)
        Me.txt_cust.TabIndex = 204
        Me.txt_cust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 25)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "CUSTOMER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "ACCT No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.Color.Teal
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.toolpost, Me.ToolStripSeparator4, Me.informationtool, Me.ToolStripSeparator5, Me.ToolStripButton2, Me.toolCALC, Me.toolexit})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(498, 28)
        Me.ToolStrip2.TabIndex = 212
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripButton1.Text = "ToolStripButton2"
        Me.ToolStripButton1.ToolTipText = "NEW"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'toolpost
        '
        Me.toolpost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolpost.Image = CType(resources.GetObject("toolpost.Image"), System.Drawing.Image)
        Me.toolpost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolpost.Name = "toolpost"
        Me.toolpost.Size = New System.Drawing.Size(23, 25)
        Me.toolpost.Text = "ToolStripButton1"
        Me.toolpost.ToolTipText = "UPDATE"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 28)
        '
        'informationtool
        '
        Me.informationtool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.informationtool.Image = CType(resources.GetObject("informationtool.Image"), System.Drawing.Image)
        Me.informationtool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.informationtool.Name = "informationtool"
        Me.informationtool.Size = New System.Drawing.Size(23, 25)
        Me.informationtool.Text = "ToolStripButton3"
        Me.informationtool.ToolTipText = "FIND ACCOUNT"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripButton2.Text = "OR"
        Me.ToolStripButton2.ToolTipText = "Print"
        '
        'toolCALC
        '
        Me.toolCALC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolCALC.Image = CType(resources.GetObject("toolCALC.Image"), System.Drawing.Image)
        Me.toolCALC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolCALC.Name = "toolCALC"
        Me.toolCALC.Size = New System.Drawing.Size(23, 25)
        Me.toolCALC.Text = "ToolStripButton2"
        Me.toolCALC.ToolTipText = "CALCULATOR"
        '
        'toolexit
        '
        Me.toolexit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.toolexit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolexit.Image = CType(resources.GetObject("toolexit.Image"), System.Drawing.Image)
        Me.toolexit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolexit.Name = "toolexit"
        Me.toolexit.Size = New System.Drawing.Size(23, 25)
        Me.toolexit.Text = "ToolStripButton3"
        '
        'admin_acctCancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(498, 238)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.txt_acctno)
        Me.Controls.Add(Me.txt_LedSet)
        Me.Controls.Add(Me.txt_branchcode)
        Me.Controls.Add(Me.releasedDate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_cust)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "admin_acctCancel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RELEASE CANCEL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_acctno As System.Windows.Forms.Label
    Friend WithEvents txt_LedSet As System.Windows.Forms.Label
    Friend WithEvents txt_branchcode As System.Windows.Forms.Label
    Friend WithEvents releasedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_cust As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolpost As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents informationtool As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolCALC As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolexit As System.Windows.Forms.ToolStripButton
End Class
