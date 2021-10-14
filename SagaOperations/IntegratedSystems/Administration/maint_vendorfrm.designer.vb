<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maint_vendorfrm
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
        Me.components = New System.ComponentModel.Container()
        Me.vendor_txtbx = New System.Windows.Forms.TextBox()
        Me.LViewItemsBrand = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vendor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.contactno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateregistered = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.branchcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Save = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dellete = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.address_txtbx = New System.Windows.Forms.TextBox()
        Me.contact_txtbx = New System.Windows.Forms.TextBox()
        Me.branch_txtbx = New System.Windows.Forms.TextBox()
        Me.newbtn = New System.Windows.Forms.Button()
        Me.date_txtbx = New System.Windows.Forms.DateTimePicker()
        Me.type_txtbx = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'vendor_txtbx
        '
        Me.vendor_txtbx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vendor_txtbx.Location = New System.Drawing.Point(126, 11)
        Me.vendor_txtbx.Name = "vendor_txtbx"
        Me.vendor_txtbx.Size = New System.Drawing.Size(218, 22)
        Me.vendor_txtbx.TabIndex = 2
        '
        'LViewItemsBrand
        '
        Me.LViewItemsBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LViewItemsBrand.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.vendor, Me.address, Me.contactno, Me.dateregistered, Me.type, Me.branchcode})
        Me.LViewItemsBrand.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LViewItemsBrand.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItemsBrand.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewItemsBrand.FullRowSelect = True
        Me.LViewItemsBrand.GridLines = True
        Me.LViewItemsBrand.HideSelection = False
        Me.LViewItemsBrand.Location = New System.Drawing.Point(11, 103)
        Me.LViewItemsBrand.Name = "LViewItemsBrand"
        Me.LViewItemsBrand.Size = New System.Drawing.Size(948, 323)
        Me.LViewItemsBrand.TabIndex = 29
        Me.LViewItemsBrand.UseCompatibleStateImageBehavior = False
        Me.LViewItemsBrand.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 80
        '
        'vendor
        '
        Me.vendor.Text = "VENDOR"
        Me.vendor.Width = 180
        '
        'address
        '
        Me.address.Text = "ADDRESS"
        Me.address.Width = 220
        '
        'contactno
        '
        Me.contactno.Text = "CONTACT NO."
        Me.contactno.Width = 140
        '
        'dateregistered
        '
        Me.dateregistered.Text = "DATE REGISTERED"
        Me.dateregistered.Width = 124
        '
        'type
        '
        Me.type.Text = "TYPE"
        Me.type.Width = 100
        '
        'branchcode
        '
        Me.branchcode.Text = "BRANCH CODE"
        Me.branchcode.Width = 100
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DelleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(111, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DelleteToolStripMenuItem
        '
        Me.DelleteToolStripMenuItem.Name = "DelleteToolStripMenuItem"
        Me.DelleteToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.DelleteToolStripMenuItem.Text = "Dellete"
        '
        'Save
        '
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Save.Location = New System.Drawing.Point(11, 444)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(109, 29)
        Me.Save.TabIndex = 30
        Me.Save.Text = "&ADD"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Vendors Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Dellete
        '
        Me.Dellete.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Dellete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dellete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dellete.Location = New System.Drawing.Point(126, 444)
        Me.Dellete.Name = "Dellete"
        Me.Dellete.Size = New System.Drawing.Size(109, 29)
        Me.Dellete.TabIndex = 32
        Me.Dellete.Text = "&DELETE"
        Me.Dellete.UseVisualStyleBackColor = False
        '
        'CloseBtn
        '
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CloseBtn.Location = New System.Drawing.Point(356, 444)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(109, 29)
        Me.CloseBtn.TabIndex = 33
        Me.CloseBtn.Text = "&CLOSE"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(44, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Address:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(562, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Date Registered:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 20)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Contact No.:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(630, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Type:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(572, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Branch Code:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'address_txtbx
        '
        Me.address_txtbx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_txtbx.Location = New System.Drawing.Point(126, 43)
        Me.address_txtbx.Name = "address_txtbx"
        Me.address_txtbx.Size = New System.Drawing.Size(394, 22)
        Me.address_txtbx.TabIndex = 77
        '
        'contact_txtbx
        '
        Me.contact_txtbx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact_txtbx.Location = New System.Drawing.Point(126, 74)
        Me.contact_txtbx.Name = "contact_txtbx"
        Me.contact_txtbx.Size = New System.Drawing.Size(218, 22)
        Me.contact_txtbx.TabIndex = 78
        '
        'branch_txtbx
        '
        Me.branch_txtbx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.branch_txtbx.Location = New System.Drawing.Point(696, 75)
        Me.branch_txtbx.Name = "branch_txtbx"
        Me.branch_txtbx.Size = New System.Drawing.Size(160, 22)
        Me.branch_txtbx.TabIndex = 81
        '
        'newbtn
        '
        Me.newbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.newbtn.Location = New System.Drawing.Point(241, 444)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(109, 29)
        Me.newbtn.TabIndex = 82
        Me.newbtn.Text = "&NEW"
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'date_txtbx
        '
        Me.date_txtbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_txtbx.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_txtbx.Location = New System.Drawing.Point(696, 11)
        Me.date_txtbx.Name = "date_txtbx"
        Me.date_txtbx.Size = New System.Drawing.Size(160, 22)
        Me.date_txtbx.TabIndex = 83
        '
        'type_txtbx
        '
        Me.type_txtbx.FormattingEnabled = True
        Me.type_txtbx.Items.AddRange(New Object() {"vendor", "branch"})
        Me.type_txtbx.Location = New System.Drawing.Point(696, 43)
        Me.type_txtbx.Name = "type_txtbx"
        Me.type_txtbx.Size = New System.Drawing.Size(160, 21)
        Me.type_txtbx.TabIndex = 84
        '
        'maint_vendorfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(965, 481)
        Me.Controls.Add(Me.type_txtbx)
        Me.Controls.Add(Me.date_txtbx)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.branch_txtbx)
        Me.Controls.Add(Me.contact_txtbx)
        Me.Controls.Add(Me.address_txtbx)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.vendor_txtbx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.Dellete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.LViewItemsBrand)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "maint_vendorfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " maint_vendorfrm"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vendor_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents LViewItemsBrand As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Private WithEvents vendor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dellete As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents address As System.Windows.Forms.ColumnHeader
    Friend WithEvents contactno As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents address_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents contact_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents branch_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents dateregistered As System.Windows.Forms.ColumnHeader
    Friend WithEvents type As System.Windows.Forms.ColumnHeader
    Friend WithEvents branchcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents newbtn As System.Windows.Forms.Button
    Friend WithEvents date_txtbx As System.Windows.Forms.DateTimePicker
    Friend WithEvents type_txtbx As System.Windows.Forms.ComboBox
End Class
