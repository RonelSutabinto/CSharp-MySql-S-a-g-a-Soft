<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class maint_modelfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LViewItemsBrand = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.model = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Group = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Save = New System.Windows.Forms.Button()
        Me.Dellete = New System.Windows.Forms.Button()
        Me.ModifyBtn = New System.Windows.Forms.Button()
        Me.newbtn = New System.Windows.Forms.Button()
        Me.model_txtbx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Brand_cmb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Group_cmb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DP = New System.Windows.Forms.TextBox()
        Me.Notes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dateCreated = New System.Windows.Forms.DateTimePicker()
        Me.dateUpdated = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.AOC = New System.Windows.Forms.TextBox()
        Me.LCP = New System.Windows.Forms.TextBox()
        Me.COD = New System.Windows.Forms.TextBox()
        Me.Rebates = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LViewItemsBrand
        '
        Me.LViewItemsBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LViewItemsBrand.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.model, Me.Group, Me.brand})
        Me.LViewItemsBrand.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LViewItemsBrand.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItemsBrand.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewItemsBrand.FullRowSelect = True
        Me.LViewItemsBrand.GridLines = True
        Me.LViewItemsBrand.HideSelection = False
        Me.LViewItemsBrand.Location = New System.Drawing.Point(12, 12)
        Me.LViewItemsBrand.Name = "LViewItemsBrand"
        Me.LViewItemsBrand.Size = New System.Drawing.Size(335, 305)
        Me.LViewItemsBrand.TabIndex = 29
        Me.LViewItemsBrand.UseCompatibleStateImageBehavior = False
        Me.LViewItemsBrand.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 100
        '
        'model
        '
        Me.model.Text = "MODEL"
        Me.model.Width = 200
        '
        'Group
        '
        Me.Group.Text = "GROUP"
        Me.Group.Width = 180
        '
        'brand
        '
        Me.brand.Text = "BRAND"
        Me.brand.Width = 180
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
        Me.Save.BackColor = System.Drawing.Color.Red
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ForeColor = System.Drawing.Color.White
        Me.Save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Save.Location = New System.Drawing.Point(472, 281)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(81, 36)
        Me.Save.TabIndex = 30
        Me.Save.Text = "REGISTER"
        Me.Save.UseVisualStyleBackColor = False
        '
        'Dellete
        '
        Me.Dellete.BackColor = System.Drawing.Color.Red
        Me.Dellete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dellete.ForeColor = System.Drawing.Color.White
        Me.Dellete.Location = New System.Drawing.Point(578, 281)
        Me.Dellete.Name = "Dellete"
        Me.Dellete.Size = New System.Drawing.Size(86, 36)
        Me.Dellete.TabIndex = 32
        Me.Dellete.Text = "DELETE"
        Me.Dellete.UseVisualStyleBackColor = False
        '
        'ModifyBtn
        '
        Me.ModifyBtn.BackColor = System.Drawing.Color.Red
        Me.ModifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModifyBtn.ForeColor = System.Drawing.Color.White
        Me.ModifyBtn.Location = New System.Drawing.Point(688, 281)
        Me.ModifyBtn.Name = "ModifyBtn"
        Me.ModifyBtn.Size = New System.Drawing.Size(74, 36)
        Me.ModifyBtn.TabIndex = 33
        Me.ModifyBtn.Text = "MODIFY"
        Me.ModifyBtn.UseVisualStyleBackColor = False
        '
        'newbtn
        '
        Me.newbtn.BackColor = System.Drawing.Color.Red
        Me.newbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newbtn.ForeColor = System.Drawing.Color.White
        Me.newbtn.Location = New System.Drawing.Point(358, 281)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(87, 36)
        Me.newbtn.TabIndex = 75
        Me.newbtn.Text = "&NEW"
        Me.newbtn.UseVisualStyleBackColor = False
        '
        'model_txtbx
        '
        Me.model_txtbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.model_txtbx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.model_txtbx.Location = New System.Drawing.Point(428, 39)
        Me.model_txtbx.Name = "model_txtbx"
        Me.model_txtbx.Size = New System.Drawing.Size(330, 22)
        Me.model_txtbx.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(350, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 23)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Model:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Brand_cmb
        '
        Me.Brand_cmb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Brand_cmb.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Brand_cmb.Location = New System.Drawing.Point(428, 65)
        Me.Brand_cmb.Name = "Brand_cmb"
        Me.Brand_cmb.Size = New System.Drawing.Size(122, 22)
        Me.Brand_cmb.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(350, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 23)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Brand"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Group_cmb
        '
        Me.Group_cmb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Group_cmb.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_cmb.Location = New System.Drawing.Point(621, 65)
        Me.Group_cmb.Name = "Group_cmb"
        Me.Group_cmb.Size = New System.Drawing.Size(137, 22)
        Me.Group_cmb.TabIndex = 80
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(554, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 23)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Category"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DP
        '
        Me.DP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DP.Location = New System.Drawing.Point(428, 148)
        Me.DP.Name = "DP"
        Me.DP.Size = New System.Drawing.Size(122, 22)
        Me.DP.TabIndex = 84
        '
        'Notes
        '
        Me.Notes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Notes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notes.Location = New System.Drawing.Point(428, 253)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(330, 22)
        Me.Notes.TabIndex = 86
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(351, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 23)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Notes"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(351, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 23)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "DP"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(350, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Date Created"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(554, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 23)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Date Updated"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dateCreated
        '
        Me.dateCreated.Enabled = False
        Me.dateCreated.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateCreated.Location = New System.Drawing.Point(448, 106)
        Me.dateCreated.Name = "dateCreated"
        Me.dateCreated.Size = New System.Drawing.Size(102, 23)
        Me.dateCreated.TabIndex = 89
        '
        'dateUpdated
        '
        Me.dateUpdated.Enabled = False
        Me.dateUpdated.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateUpdated.Location = New System.Drawing.Point(655, 106)
        Me.dateUpdated.Name = "dateUpdated"
        Me.dateUpdated.Size = New System.Drawing.Size(103, 23)
        Me.dateUpdated.TabIndex = 90
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(554, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 23)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "AOC"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(350, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 23)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "COD"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(554, 180)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 23)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "LCP"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(351, 217)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 23)
        Me.Label14.TabIndex = 94
        Me.Label14.Text = "Rebates"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AOC
        '
        Me.AOC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AOC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AOC.Location = New System.Drawing.Point(621, 148)
        Me.AOC.Name = "AOC"
        Me.AOC.Size = New System.Drawing.Size(137, 22)
        Me.AOC.TabIndex = 95
        '
        'LCP
        '
        Me.LCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LCP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCP.Location = New System.Drawing.Point(621, 181)
        Me.LCP.Name = "LCP"
        Me.LCP.Size = New System.Drawing.Size(137, 22)
        Me.LCP.TabIndex = 97
        '
        'COD
        '
        Me.COD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.COD.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COD.Location = New System.Drawing.Point(428, 181)
        Me.COD.Name = "COD"
        Me.COD.Size = New System.Drawing.Size(122, 22)
        Me.COD.TabIndex = 96
        '
        'Rebates
        '
        Me.Rebates.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Rebates.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rebates.Location = New System.Drawing.Point(428, 217)
        Me.Rebates.Name = "Rebates"
        Me.Rebates.Size = New System.Drawing.Size(330, 22)
        Me.Rebates.TabIndex = 98
        '
        'txt_ID
        '
        Me.txt_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(428, 12)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(330, 22)
        Me.txt_ID.TabIndex = 99
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(351, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 23)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "ID"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'maint_modelfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(769, 328)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Rebates)
        Me.Controls.Add(Me.LCP)
        Me.Controls.Add(Me.COD)
        Me.Controls.Add(Me.AOC)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dateUpdated)
        Me.Controls.Add(Me.dateCreated)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DP)
        Me.Controls.Add(Me.Notes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Brand_cmb)
        Me.Controls.Add(Me.Group_cmb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.model_txtbx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.ModifyBtn)
        Me.Controls.Add(Me.Dellete)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.LViewItemsBrand)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "maint_modelfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " maint_modelfrm"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LViewItemsBrand As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Private WithEvents model As System.Windows.Forms.ColumnHeader
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Dellete As System.Windows.Forms.Button
    Friend WithEvents ModifyBtn As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Group As System.Windows.Forms.ColumnHeader
    Friend WithEvents brand As System.Windows.Forms.ColumnHeader
    Friend WithEvents newbtn As System.Windows.Forms.Button
    Friend WithEvents model_txtbx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Brand_cmb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Group_cmb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DP As TextBox
    Friend WithEvents Notes As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dateCreated As DateTimePicker
    Friend WithEvents dateUpdated As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents AOC As TextBox
    Friend WithEvents LCP As TextBox
    Friend WithEvents COD As TextBox
    Friend WithEvents Rebates As TextBox
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents Label15 As Label
End Class
