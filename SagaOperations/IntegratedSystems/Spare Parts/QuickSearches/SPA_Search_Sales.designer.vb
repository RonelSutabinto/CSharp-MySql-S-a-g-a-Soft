<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SPA_Search_Sales
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
        Me.lv_Parts = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partsNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partsName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.srp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.priceWOVAT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.spCostWoVAT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.spCostWVAT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.modelCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.modelName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.receivingBranch = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SPA_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_BrCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Quantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Unit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_PartsNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Price = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_SubTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_PartsName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_prevID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Quantity1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lv_Parts
        '
        Me.lv_Parts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.partsNumber, Me.partsName, Me.quantity, Me.category, Me.srp, Me.priceWOVAT, Me.spCostWoVAT, Me.spCostWVAT, Me.modelCode, Me.modelName, Me.receivingBranch, Me.SPA_ID})
        Me.lv_Parts.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_Parts.FullRowSelect = True
        Me.lv_Parts.GridLines = True
        Me.lv_Parts.HoverSelection = True
        Me.lv_Parts.Location = New System.Drawing.Point(12, 68)
        Me.lv_Parts.Name = "lv_Parts"
        Me.lv_Parts.Size = New System.Drawing.Size(682, 288)
        Me.lv_Parts.TabIndex = 7
        Me.lv_Parts.UseCompatibleStateImageBehavior = False
        Me.lv_Parts.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 0
        '
        'partsNumber
        '
        Me.partsNumber.Text = "PARTS NUMBER"
        Me.partsNumber.Width = 130
        '
        'partsName
        '
        Me.partsName.Text = "PARTS NAME"
        Me.partsName.Width = 130
        '
        'quantity
        '
        Me.quantity.Text = "QUANTITY"
        Me.quantity.Width = 100
        '
        'category
        '
        Me.category.Text = "CATEGORY"
        Me.category.Width = 0
        '
        'srp
        '
        Me.srp.Text = "Price 1"
        Me.srp.Width = 80
        '
        'priceWOVAT
        '
        Me.priceWOVAT.Text = "Price 2"
        Me.priceWOVAT.Width = 80
        '
        'spCostWoVAT
        '
        Me.spCostWoVAT.Text = "Price 3"
        Me.spCostWoVAT.Width = 80
        '
        'spCostWVAT
        '
        Me.spCostWVAT.Text = "Price 4"
        Me.spCostWVAT.Width = 80
        '
        'modelCode
        '
        Me.modelCode.Text = "MODEL CODE"
        Me.modelCode.Width = 0
        '
        'modelName
        '
        Me.modelName.Text = "MODEL NAME"
        Me.modelName.Width = 0
        '
        'receivingBranch
        '
        Me.receivingBranch.Text = "receivingBranch"
        Me.receivingBranch.Width = 0
        '
        'SPA_ID
        '
        Me.SPA_ID.Text = "spa_ID"
        Me.SPA_ID.Width = 0
        '
        'txt_BrCode
        '
        Me.txt_BrCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BrCode.Location = New System.Drawing.Point(803, 24)
        Me.txt_BrCode.Name = "txt_BrCode"
        Me.txt_BrCode.Size = New System.Drawing.Size(232, 27)
        Me.txt_BrCode.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(800, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "BranchCode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(800, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Quantity"
        '
        'txt_Quantity
        '
        Me.txt_Quantity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Quantity.Location = New System.Drawing.Point(803, 77)
        Me.txt_Quantity.Name = "txt_Quantity"
        Me.txt_Quantity.Size = New System.Drawing.Size(232, 27)
        Me.txt_Quantity.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(800, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Unit"
        '
        'txt_Unit
        '
        Me.txt_Unit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Unit.Location = New System.Drawing.Point(803, 130)
        Me.txt_Unit.Name = "txt_Unit"
        Me.txt_Unit.Size = New System.Drawing.Size(232, 27)
        Me.txt_Unit.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(800, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "PartsNumber"
        '
        'txt_PartsNumber
        '
        Me.txt_PartsNumber.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsNumber.Location = New System.Drawing.Point(803, 183)
        Me.txt_PartsNumber.Name = "txt_PartsNumber"
        Me.txt_PartsNumber.Size = New System.Drawing.Size(232, 27)
        Me.txt_PartsNumber.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(800, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 18)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Unit Price"
        '
        'txt_Price
        '
        Me.txt_Price.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Price.Location = New System.Drawing.Point(803, 286)
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(232, 27)
        Me.txt_Price.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(800, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "SubTotal"
        '
        'txt_SubTotal
        '
        Me.txt_SubTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubTotal.Location = New System.Drawing.Point(803, 339)
        Me.txt_SubTotal.Name = "txt_SubTotal"
        Me.txt_SubTotal.Size = New System.Drawing.Size(232, 27)
        Me.txt_SubTotal.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(800, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 18)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "PartsName"
        '
        'txt_PartsName
        '
        Me.txt_PartsName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsName.Location = New System.Drawing.Point(803, 235)
        Me.txt_PartsName.Name = "txt_PartsName"
        Me.txt_PartsName.Size = New System.Drawing.Size(232, 27)
        Me.txt_PartsName.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1038, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 18)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "prev_ID"
        '
        'txt_prevID
        '
        Me.txt_prevID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prevID.Location = New System.Drawing.Point(1041, 24)
        Me.txt_prevID.Name = "txt_prevID"
        Me.txt_prevID.Size = New System.Drawing.Size(172, 27)
        Me.txt_prevID.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SEARCH SPARE PARTS NUMBER"
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(12, 35)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(682, 27)
        Me.txt_Search.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(1038, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 18)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "ID"
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(1041, 77)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(172, 27)
        Me.txt_ID.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(437, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 18)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Quantity"
        '
        'txt_Quantity1
        '
        Me.txt_Quantity1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Quantity1.Location = New System.Drawing.Point(440, 171)
        Me.txt_Quantity1.Name = "txt_Quantity1"
        Me.txt_Quantity1.Size = New System.Drawing.Size(232, 27)
        Me.txt_Quantity1.TabIndex = 26
        '
        'SPA_Search_Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(704, 365)
        Me.Controls.Add(Me.lv_Parts)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_Quantity1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_prevID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_PartsName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_SubTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Price)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_PartsNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Unit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Quantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_BrCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Search)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(720, 404)
        Me.Name = "SPA_Search_Sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEARCH SPARE PARTS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv_Parts As ListView
    Friend WithEvents partsNumber As ColumnHeader
    Friend WithEvents partsName As ColumnHeader
    Friend WithEvents quantity As ColumnHeader
    Friend WithEvents category As ColumnHeader
    Friend WithEvents srp As ColumnHeader
    Friend WithEvents spCostWoVAT As ColumnHeader
    Friend WithEvents spCostWVAT As ColumnHeader
    Friend WithEvents priceWOVAT As ColumnHeader
    Friend WithEvents modelCode As ColumnHeader
    Friend WithEvents modelName As ColumnHeader
    Friend WithEvents txt_BrCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Quantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Unit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_PartsNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Price As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_SubTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_PartsName As TextBox
    Friend WithEvents receivingBranch As ColumnHeader
    Friend WithEvents SPA_ID As ColumnHeader
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_prevID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents id As ColumnHeader
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_Quantity1 As TextBox
End Class
