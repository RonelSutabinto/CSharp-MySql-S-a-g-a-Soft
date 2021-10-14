<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
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
        Me.LViewItems = New System.Windows.Forms.ListView()
        Me.code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.model = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.color = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chasisno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.engineno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitCost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalcost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.keyno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.note = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmd_import = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LViewItems
        '
        Me.LViewItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LViewItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.code, Me.model, Me.desc, Me.color, Me.brand, Me.chasisno, Me.engineno, Me.unitCost, Me.vat, Me.totalcost, Me.unitPrice, Me.keyno, Me.note})
        Me.LViewItems.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItems.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewItems.FullRowSelect = True
        Me.LViewItems.GridLines = True
        Me.LViewItems.HideSelection = False
        Me.LViewItems.Location = New System.Drawing.Point(12, 69)
        Me.LViewItems.Name = "LViewItems"
        Me.LViewItems.Size = New System.Drawing.Size(637, 147)
        Me.LViewItems.TabIndex = 16
        Me.LViewItems.UseCompatibleStateImageBehavior = False
        Me.LViewItems.View = System.Windows.Forms.View.Details
        '
        'code
        '
        Me.code.Text = "CODE"
        Me.code.Width = 77
        '
        'model
        '
        Me.model.Text = "MODEL"
        Me.model.Width = 67
        '
        'desc
        '
        Me.desc.Text = "DESCRIPTION"
        Me.desc.Width = 92
        '
        'color
        '
        Me.color.Text = "COLOR"
        Me.color.Width = 66
        '
        'brand
        '
        Me.brand.Text = "BRAND"
        Me.brand.Width = 75
        '
        'chasisno
        '
        Me.chasisno.Text = "CHASSIS  No"
        Me.chasisno.Width = 86
        '
        'engineno
        '
        Me.engineno.Text = "ENGINE No"
        Me.engineno.Width = 91
        '
        'unitCost
        '
        Me.unitCost.Text = "UNIT COST"
        Me.unitCost.Width = 75
        '
        'vat
        '
        Me.vat.Text = "VAT"
        Me.vat.Width = 51
        '
        'totalcost
        '
        Me.totalcost.Text = "TOTAL COST"
        Me.totalcost.Width = 69
        '
        'unitPrice
        '
        Me.unitPrice.Text = "UNIT PRICE"
        Me.unitPrice.Width = 56
        '
        'keyno
        '
        Me.keyno.Text = "KEY #"
        '
        'note
        '
        Me.note.Text = "NOTE"
        '
        'cmd_import
        '
        Me.cmd_import.AutoSize = True
        Me.cmd_import.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmd_import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_import.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_import.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_import.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_import.Location = New System.Drawing.Point(582, 41)
        Me.cmd_import.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd_import.Name = "cmd_import"
        Me.cmd_import.Size = New System.Drawing.Size(35, 23)
        Me.cmd_import.TabIndex = 87
        Me.cmd_import.Text = "..."
        Me.cmd_import.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_import.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_import.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(68, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(508, 20)
        Me.TextBox1.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "PATH"
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 400)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmd_import)
        Me.Controls.Add(Me.LViewItems)
        Me.Name = "TestForm"
        Me.Text = "TestForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LViewItems As System.Windows.Forms.ListView
    Friend WithEvents code As System.Windows.Forms.ColumnHeader
    Friend WithEvents model As System.Windows.Forms.ColumnHeader
    Friend WithEvents desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents color As System.Windows.Forms.ColumnHeader
    Friend WithEvents brand As System.Windows.Forms.ColumnHeader
    Friend WithEvents chasisno As System.Windows.Forms.ColumnHeader
    Friend WithEvents engineno As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitCost As System.Windows.Forms.ColumnHeader
    Friend WithEvents vat As System.Windows.Forms.ColumnHeader
    Friend WithEvents totalcost As System.Windows.Forms.ColumnHeader
    Friend WithEvents unitPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents keyno As System.Windows.Forms.ColumnHeader
    Friend WithEvents note As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmd_import As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
