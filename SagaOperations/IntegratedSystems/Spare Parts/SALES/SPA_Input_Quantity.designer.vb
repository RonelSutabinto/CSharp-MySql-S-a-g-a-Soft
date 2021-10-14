<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPA_InputQuantity
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
        Me.txt_Quantity1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_PartsName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Price = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_PartsNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Unit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Quantity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_BrCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_SubTotal = New DevExpress.XtraEditors.CalcEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_Percent = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_TotalPercent = New System.Windows.Forms.TextBox()
        Me.txt_TotalAmount = New System.Windows.Forms.TextBox()
        Me.txt_Discount = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lbl_Exist = New System.Windows.Forms.Label()
        Me.txt_LessAmount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_TotalLess = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_GrossTotal = New DevExpress.XtraEditors.CalcEdit()
        CType(Me.txt_Quantity1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GrossTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Quantity1
        '
        Me.txt_Quantity1.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Quantity1.Location = New System.Drawing.Point(12, 49)
        Me.txt_Quantity1.Name = "txt_Quantity1"
        Me.txt_Quantity1.Size = New System.Drawing.Size(448, 66)
        Me.txt_Quantity1.TabIndex = 0
        Me.txt_Quantity1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(139, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INPUT QUANTITY"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(489, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 18)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "PartsName"
        '
        'txt_PartsName
        '
        Me.txt_PartsName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsName.Location = New System.Drawing.Point(492, 276)
        Me.txt_PartsName.Name = "txt_PartsName"
        Me.txt_PartsName.Size = New System.Drawing.Size(232, 27)
        Me.txt_PartsName.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(489, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "SubTotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(489, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 18)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Unit Price"
        '
        'txt_Price
        '
        Me.txt_Price.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Price.Location = New System.Drawing.Point(492, 327)
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(232, 27)
        Me.txt_Price.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(489, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "PartsNumber"
        '
        'txt_PartsNumber
        '
        Me.txt_PartsNumber.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsNumber.Location = New System.Drawing.Point(492, 224)
        Me.txt_PartsNumber.Name = "txt_PartsNumber"
        Me.txt_PartsNumber.Size = New System.Drawing.Size(232, 27)
        Me.txt_PartsNumber.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(489, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 18)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Unit"
        '
        'txt_Unit
        '
        Me.txt_Unit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Unit.Location = New System.Drawing.Point(492, 171)
        Me.txt_Unit.Name = "txt_Unit"
        Me.txt_Unit.Size = New System.Drawing.Size(232, 27)
        Me.txt_Unit.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(489, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Quantity"
        '
        'txt_Quantity
        '
        Me.txt_Quantity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Quantity.Location = New System.Drawing.Point(492, 118)
        Me.txt_Quantity.Name = "txt_Quantity"
        Me.txt_Quantity.Size = New System.Drawing.Size(232, 27)
        Me.txt_Quantity.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(489, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "BranchCode"
        '
        'txt_BrCode
        '
        Me.txt_BrCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BrCode.Location = New System.Drawing.Point(492, 65)
        Me.txt_BrCode.Name = "txt_BrCode"
        Me.txt_BrCode.Size = New System.Drawing.Size(232, 27)
        Me.txt_BrCode.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(754, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 18)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "ID"
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(757, 63)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(205, 27)
        Me.txt_ID.TabIndex = 36
        '
        'txt_SubTotal
        '
        Me.txt_SubTotal.Enabled = False
        Me.txt_SubTotal.Location = New System.Drawing.Point(492, 381)
        Me.txt_SubTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_SubTotal.Name = "txt_SubTotal"
        Me.txt_SubTotal.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txt_SubTotal.Properties.Appearance.Options.UseFont = True
        Me.txt_SubTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txt_SubTotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_SubTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_SubTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_SubTotal.Properties.Mask.EditMask = "n2"
        Me.txt_SubTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_SubTotal.Size = New System.Drawing.Size(232, 26)
        Me.txt_SubTotal.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(67, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 23)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "DISCOUNT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(306, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 23)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "SELLING PRICE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(754, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 18)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Percentage"
        '
        'txt_Percent
        '
        Me.txt_Percent.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Percent.Location = New System.Drawing.Point(757, 118)
        Me.txt_Percent.Name = "txt_Percent"
        Me.txt_Percent.Size = New System.Drawing.Size(205, 27)
        Me.txt_Percent.TabIndex = 43
        Me.txt_Percent.Text = "100"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(754, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 18)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Total Percentage"
        '
        'txt_TotalPercent
        '
        Me.txt_TotalPercent.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalPercent.Location = New System.Drawing.Point(757, 173)
        Me.txt_TotalPercent.Name = "txt_TotalPercent"
        Me.txt_TotalPercent.Size = New System.Drawing.Size(205, 27)
        Me.txt_TotalPercent.TabIndex = 45
        Me.txt_TotalPercent.Text = "0"
        '
        'txt_TotalAmount
        '
        Me.txt_TotalAmount.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalAmount.Location = New System.Drawing.Point(268, 158)
        Me.txt_TotalAmount.Name = "txt_TotalAmount"
        Me.txt_TotalAmount.Size = New System.Drawing.Size(192, 40)
        Me.txt_TotalAmount.TabIndex = 48
        Me.txt_TotalAmount.Text = "0"
        '
        'txt_Discount
        '
        Me.txt_Discount.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Discount.Location = New System.Drawing.Point(14, 158)
        Me.txt_Discount.MaxLength = 3
        Me.txt_Discount.Name = "txt_Discount"
        Me.txt_Discount.Size = New System.Drawing.Size(69, 40)
        Me.txt_Discount.TabIndex = 47
        Me.txt_Discount.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(57, 166)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 23)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "%"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(429, 3)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(46, 26)
        Me.btnClose.TabIndex = 52
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lbl_Exist
        '
        Me.lbl_Exist.AutoSize = True
        Me.lbl_Exist.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Exist.ForeColor = System.Drawing.Color.White
        Me.lbl_Exist.Location = New System.Drawing.Point(575, 9)
        Me.lbl_Exist.Name = "lbl_Exist"
        Me.lbl_Exist.Size = New System.Drawing.Size(15, 18)
        Me.lbl_Exist.TabIndex = 53
        Me.lbl_Exist.Text = "0"
        '
        'txt_LessAmount
        '
        Me.txt_LessAmount.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LessAmount.Location = New System.Drawing.Point(89, 158)
        Me.txt_LessAmount.MaxLength = 99999999
        Me.txt_LessAmount.Name = "txt_LessAmount"
        Me.txt_LessAmount.Size = New System.Drawing.Size(109, 40)
        Me.txt_LessAmount.TabIndex = 56
        Me.txt_LessAmount.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(754, 306)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 18)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Total Less"
        '
        'txt_TotalLess
        '
        Me.txt_TotalLess.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalLess.Location = New System.Drawing.Point(757, 327)
        Me.txt_TotalLess.Name = "txt_TotalLess"
        Me.txt_TotalLess.Size = New System.Drawing.Size(205, 27)
        Me.txt_TotalLess.TabIndex = 57
        Me.txt_TotalLess.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(754, 255)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 18)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Gross Total"
        '
        'txt_GrossTotal
        '
        Me.txt_GrossTotal.Enabled = False
        Me.txt_GrossTotal.Location = New System.Drawing.Point(757, 277)
        Me.txt_GrossTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_GrossTotal.Name = "txt_GrossTotal"
        Me.txt_GrossTotal.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GrossTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txt_GrossTotal.Properties.Appearance.Options.UseFont = True
        Me.txt_GrossTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txt_GrossTotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_GrossTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_GrossTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_GrossTotal.Properties.Mask.EditMask = "n2"
        Me.txt_GrossTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_GrossTotal.Size = New System.Drawing.Size(205, 26)
        Me.txt_GrossTotal.TabIndex = 38
        '
        'SPA_InputQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1054, 457)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_TotalLess)
        Me.Controls.Add(Me.txt_LessAmount)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lbl_Exist)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txt_Discount)
        Me.Controls.Add(Me.txt_TotalAmount)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_TotalPercent)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_Percent)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_GrossTotal)
        Me.Controls.Add(Me.txt_SubTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_PartsName)
        Me.Controls.Add(Me.Label7)
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
        Me.Controls.Add(Me.txt_Quantity1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(484, 225)
        Me.Name = "SPA_InputQuantity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPA_Input_Quantity"
        CType(Me.txt_Quantity1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GrossTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Quantity1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_PartsName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Price As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_PartsNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Unit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Quantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_BrCode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents txt_SubTotal As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_Percent As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_TotalPercent As TextBox
    Friend WithEvents txt_TotalAmount As TextBox
    Friend WithEvents txt_Discount As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lbl_Exist As Label
    Friend WithEvents txt_LessAmount As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_TotalLess As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_GrossTotal As DevExpress.XtraEditors.CalcEdit
End Class
