<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maint_whcategoryfrm
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
        Me.category_txbx = New System.Windows.Forms.TextBox()
        Me.LViewItemsBrand = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ctcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Save = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dellete = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ctcodetxbx = New System.Windows.Forms.TextBox()
        Me.newbbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'category_txbx
        '
        Me.category_txbx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_txbx.Location = New System.Drawing.Point(89, 12)
        Me.category_txbx.Name = "category_txbx"
        Me.category_txbx.Size = New System.Drawing.Size(212, 22)
        Me.category_txbx.TabIndex = 2
        '
        'LViewItemsBrand
        '
        Me.LViewItemsBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LViewItemsBrand.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.category, Me.ctcode})
        Me.LViewItemsBrand.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItemsBrand.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewItemsBrand.FullRowSelect = True
        Me.LViewItemsBrand.GridLines = True
        Me.LViewItemsBrand.HideSelection = False
        Me.LViewItemsBrand.Location = New System.Drawing.Point(22, 39)
        Me.LViewItemsBrand.Name = "LViewItemsBrand"
        Me.LViewItemsBrand.Size = New System.Drawing.Size(555, 284)
        Me.LViewItemsBrand.TabIndex = 29
        Me.LViewItemsBrand.UseCompatibleStateImageBehavior = False
        Me.LViewItemsBrand.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 100
        '
        'category
        '
        Me.category.Text = "CATEGORY"
        Me.category.Width = 250
        '
        'ctcode
        '
        Me.ctcode.Text = "CATEGORY CODE"
        Me.ctcode.Width = 200
        '
        'Save
        '
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Save.Location = New System.Drawing.Point(22, 329)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(109, 31)
        Me.Save.TabIndex = 30
        Me.Save.Text = "&ADD"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(-18, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Category:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Dellete
        '
        Me.Dellete.BackColor = System.Drawing.SystemColors.Control
        Me.Dellete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dellete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dellete.Location = New System.Drawing.Point(137, 329)
        Me.Dellete.Name = "Dellete"
        Me.Dellete.Size = New System.Drawing.Size(109, 31)
        Me.Dellete.TabIndex = 32
        Me.Dellete.Text = "&DELETE"
        Me.Dellete.UseVisualStyleBackColor = False
        '
        'CloseBtn
        '
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CloseBtn.Location = New System.Drawing.Point(367, 329)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(109, 31)
        Me.CloseBtn.TabIndex = 33
        Me.CloseBtn.Text = "&CLOSE"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(297, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 20)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Category Code:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ctcodetxbx
        '
        Me.ctcodetxbx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctcodetxbx.Location = New System.Drawing.Point(428, 11)
        Me.ctcodetxbx.Name = "ctcodetxbx"
        Me.ctcodetxbx.Size = New System.Drawing.Size(149, 22)
        Me.ctcodetxbx.TabIndex = 73
        '
        'newbbtn
        '
        Me.newbbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newbbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.newbbtn.Location = New System.Drawing.Point(252, 329)
        Me.newbbtn.Name = "newbbtn"
        Me.newbbtn.Size = New System.Drawing.Size(109, 31)
        Me.newbbtn.TabIndex = 74
        Me.newbbtn.Text = "&NEW"
        Me.newbbtn.UseVisualStyleBackColor = True
        '
        'maint_whcategoryfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(589, 366)
        Me.Controls.Add(Me.newbbtn)
        Me.Controls.Add(Me.ctcodetxbx)
        Me.Controls.Add(Me.category_txbx)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.Dellete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.LViewItemsBrand)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "maint_whcategoryfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " maint_whcategoryfrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents category_txbx As System.Windows.Forms.TextBox
    Friend WithEvents LViewItemsBrand As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Private WithEvents category As System.Windows.Forms.ColumnHeader
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dellete As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ctcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents ctcodetxbx As System.Windows.Forms.TextBox
    Friend WithEvents newbbtn As System.Windows.Forms.Button
End Class
