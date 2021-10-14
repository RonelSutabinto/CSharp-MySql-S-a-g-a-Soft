<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debit_Memo
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txt_remarks = New DevExpress.XtraEditors.TextEdit()
        Me.Label15 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_acctno = New DevExpress.XtraEditors.LabelControl()
        Me.txt_LedSet = New DevExpress.XtraEditors.LabelControl()
        Me.txt_branchcode = New DevExpress.XtraEditors.LabelControl()
        Me.postingDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_refno = New DevExpress.XtraEditors.TextEdit()
        Me.Label12 = New DevExpress.XtraEditors.LabelControl()
        Me.Label31 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_TotAmtPaid = New DevExpress.XtraEditors.TextEdit()
        Me.Label29 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cust = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.reboverride = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New DevExpress.XtraEditors.LabelControl()
        Me.penoverride = New DevExpress.XtraEditors.TextEdit()
        Me.Label27 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.aocoverride = New DevExpress.XtraEditors.TextEdit()
        Me.intoverride = New DevExpress.XtraEditors.TextEdit()
        Me.prinoverride = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Btn_Account = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Update = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txt_remarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.postingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.postingDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_refno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TotAmtPaid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reboverride.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.penoverride.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aocoverride.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.intoverride.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prinoverride.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_remarks
        '
        Me.txt_remarks.Location = New System.Drawing.Point(122, 147)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remarks.Properties.Appearance.Options.UseFont = True
        Me.txt_remarks.Size = New System.Drawing.Size(570, 26)
        Me.txt_remarks.TabIndex = 273
        '
        'Label15
        '
        Me.Label15.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Appearance.Options.UseFont = True
        Me.Label15.Appearance.Options.UseForeColor = True
        Me.Label15.Location = New System.Drawing.Point(12, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 19)
        Me.Label15.TabIndex = 272
        Me.Label15.Text = "REMARKS"
        '
        'txt_acctno
        '
        Me.txt_acctno.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acctno.Appearance.Options.UseFont = True
        Me.txt_acctno.Appearance.Options.UseForeColor = True
        Me.txt_acctno.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_acctno.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_acctno.Location = New System.Drawing.Point(253, 30)
        Me.txt_acctno.Name = "txt_acctno"
        Me.txt_acctno.Size = New System.Drawing.Size(262, 28)
        Me.txt_acctno.TabIndex = 262
        Me.txt_acctno.Text = "111"
        '
        'txt_LedSet
        '
        Me.txt_LedSet.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LedSet.Appearance.Options.UseFont = True
        Me.txt_LedSet.Appearance.Options.UseForeColor = True
        Me.txt_LedSet.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_LedSet.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_LedSet.Location = New System.Drawing.Point(536, 29)
        Me.txt_LedSet.Name = "txt_LedSet"
        Me.txt_LedSet.Size = New System.Drawing.Size(156, 28)
        Me.txt_LedSet.TabIndex = 271
        '
        'txt_branchcode
        '
        Me.txt_branchcode.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_branchcode.Appearance.Options.UseFont = True
        Me.txt_branchcode.Appearance.Options.UseForeColor = True
        Me.txt_branchcode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_branchcode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_branchcode.Location = New System.Drawing.Point(179, 29)
        Me.txt_branchcode.Name = "txt_branchcode"
        Me.txt_branchcode.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.txt_branchcode.Size = New System.Drawing.Size(51, 28)
        Me.txt_branchcode.TabIndex = 265
        Me.txt_branchcode.Text = "000"
        '
        'postingDate
        '
        Me.postingDate.EditValue = New Date(2020, 4, 29, 0, 0, 0, 0)
        Me.postingDate.Location = New System.Drawing.Point(577, 65)
        Me.postingDate.Name = "postingDate"
        Me.postingDate.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postingDate.Properties.Appearance.Options.UseFont = True
        Me.postingDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.postingDate.Size = New System.Drawing.Size(115, 26)
        Me.postingDate.TabIndex = 269
        '
        'Label13
        '
        Me.Label13.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Appearance.Options.UseFont = True
        Me.Label13.Appearance.Options.UseForeColor = True
        Me.Label13.Location = New System.Drawing.Point(456, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 19)
        Me.Label13.TabIndex = 270
        Me.Label13.Text = "POSTING DATE"
        '
        'txt_refno
        '
        Me.txt_refno.Location = New System.Drawing.Point(122, 109)
        Me.txt_refno.Name = "txt_refno"
        Me.txt_refno.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_refno.Properties.Appearance.Options.UseFont = True
        Me.txt_refno.Size = New System.Drawing.Size(570, 26)
        Me.txt_refno.TabIndex = 268
        '
        'Label12
        '
        Me.Label12.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Appearance.Options.UseFont = True
        Me.Label12.Appearance.Options.UseForeColor = True
        Me.Label12.Location = New System.Drawing.Point(11, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 19)
        Me.Label12.TabIndex = 267
        Me.Label12.Text = "REFERENCE No"
        '
        'Label31
        '
        Me.Label31.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Appearance.Options.UseFont = True
        Me.Label31.Appearance.Options.UseForeColor = True
        Me.Label31.Location = New System.Drawing.Point(235, 33)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(13, 19)
        Me.Label31.TabIndex = 266
        Me.Label31.Text = " - "
        '
        'txt_TotAmtPaid
        '
        Me.txt_TotAmtPaid.Location = New System.Drawing.Point(122, 284)
        Me.txt_TotAmtPaid.Name = "txt_TotAmtPaid"
        Me.txt_TotAmtPaid.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotAmtPaid.Properties.Appearance.Options.UseFont = True
        Me.txt_TotAmtPaid.Size = New System.Drawing.Size(570, 26)
        Me.txt_TotAmtPaid.TabIndex = 264
        '
        'Label29
        '
        Me.Label29.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label29.Appearance.Options.UseFont = True
        Me.Label29.Appearance.Options.UseForeColor = True
        Me.Label29.Location = New System.Drawing.Point(12, 287)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(101, 19)
        Me.Label29.TabIndex = 263
        Me.Label29.Text = "AMOUNT PAID"
        '
        'txt_cust
        '
        Me.txt_cust.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cust.Appearance.Options.UseFont = True
        Me.txt_cust.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_cust.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cust.Location = New System.Drawing.Point(122, 68)
        Me.txt_cust.Name = "txt_cust"
        Me.txt_cust.Size = New System.Drawing.Size(328, 23)
        Me.txt_cust.TabIndex = 261
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Appearance.Options.UseFont = True
        Me.Label1.Appearance.Options.UseForeColor = True
        Me.Label1.Location = New System.Drawing.Point(30, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 260
        Me.Label1.Text = "CUSTOMER"
        '
        'Label3
        '
        Me.Label3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Appearance.Options.UseFont = True
        Me.Label3.Appearance.Options.UseForeColor = True
        Me.Label3.Location = New System.Drawing.Point(31, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 19)
        Me.Label3.TabIndex = 259
        Me.Label3.Text = "ACCOUNT NUMBER"
        '
        'reboverride
        '
        Me.reboverride.EditValue = "0"
        Me.reboverride.Location = New System.Drawing.Point(214, 234)
        Me.reboverride.Name = "reboverride"
        Me.reboverride.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reboverride.Properties.Appearance.Options.UseFont = True
        Me.reboverride.Size = New System.Drawing.Size(91, 26)
        Me.reboverride.TabIndex = 257
        '
        'Label14
        '
        Me.Label14.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Appearance.Options.UseFont = True
        Me.Label14.Appearance.Options.UseForeColor = True
        Me.Label14.Location = New System.Drawing.Point(131, 237)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 19)
        Me.Label14.TabIndex = 256
        Me.Label14.Text = "REBATES"
        '
        'penoverride
        '
        Me.penoverride.EditValue = "0"
        Me.penoverride.Location = New System.Drawing.Point(408, 238)
        Me.penoverride.Name = "penoverride"
        Me.penoverride.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.penoverride.Properties.Appearance.Options.UseFont = True
        Me.penoverride.Size = New System.Drawing.Size(91, 26)
        Me.penoverride.TabIndex = 255
        '
        'Label27
        '
        Me.Label27.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Appearance.Options.UseFont = True
        Me.Label27.Appearance.Options.UseForeColor = True
        Me.Label27.Location = New System.Drawing.Point(326, 241)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(61, 19)
        Me.Label27.TabIndex = 254
        Me.Label27.Text = "PENALTY"
        '
        'Label2
        '
        Me.Label2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Appearance.Options.UseFont = True
        Me.Label2.Appearance.Options.UseForeColor = True
        Me.Label2.Location = New System.Drawing.Point(131, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 236
        Me.Label2.Text = "PRINCIPAL"
        '
        'Label4
        '
        Me.Label4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Appearance.Options.UseFont = True
        Me.Label4.Appearance.Options.UseForeColor = True
        Me.Label4.Location = New System.Drawing.Point(482, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 237
        Me.Label4.Text = "INTEREST"
        '
        'Label6
        '
        Me.Label6.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Appearance.Options.UseFont = True
        Me.Label6.Appearance.Options.UseForeColor = True
        Me.Label6.Location = New System.Drawing.Point(511, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 19)
        Me.Label6.TabIndex = 238
        Me.Label6.Text = "AOC"
        '
        'aocoverride
        '
        Me.aocoverride.EditValue = "0"
        Me.aocoverride.Location = New System.Drawing.Point(564, 238)
        Me.aocoverride.Name = "aocoverride"
        Me.aocoverride.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aocoverride.Properties.Appearance.Options.UseFont = True
        Me.aocoverride.Size = New System.Drawing.Size(91, 26)
        Me.aocoverride.TabIndex = 244
        '
        'intoverride
        '
        Me.intoverride.EditValue = "0"
        Me.intoverride.Location = New System.Drawing.Point(564, 191)
        Me.intoverride.Name = "intoverride"
        Me.intoverride.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intoverride.Properties.Appearance.Options.UseFont = True
        Me.intoverride.Size = New System.Drawing.Size(91, 26)
        Me.intoverride.TabIndex = 243
        '
        'prinoverride
        '
        Me.prinoverride.EditValue = "0"
        Me.prinoverride.Location = New System.Drawing.Point(214, 192)
        Me.prinoverride.Name = "prinoverride"
        Me.prinoverride.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prinoverride.Properties.Appearance.Options.UseFont = True
        Me.prinoverride.Size = New System.Drawing.Size(85, 26)
        Me.prinoverride.TabIndex = 242
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Btn_Account, Me.Btn_Update})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Account), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Update)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'Btn_Account
        '
        Me.Btn_Account.Caption = "Account"
        Me.Btn_Account.Id = 0
        Me.Btn_Account.Name = "Btn_Account"
        '
        'Btn_Update
        '
        Me.Btn_Update.Caption = "Update"
        Me.Btn_Update.Id = 1
        Me.Btn_Update.Name = "Btn_Update"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(782, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 442)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(782, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 418)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(782, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 418)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(519, 33)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(13, 19)
        Me.LabelControl1.TabIndex = 278
        Me.LabelControl1.Text = " - "
        '
        'Debit_Memo
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 442)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_acctno)
        Me.Controls.Add(Me.txt_LedSet)
        Me.Controls.Add(Me.txt_branchcode)
        Me.Controls.Add(Me.postingDate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_refno)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txt_TotAmtPaid)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txt_cust)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.reboverride)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.penoverride)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.aocoverride)
        Me.Controls.Add(Me.intoverride)
        Me.Controls.Add(Me.prinoverride)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Debit_Memo"
        Me.Text = "Debit_Memo"
        CType(Me.txt_remarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.postingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.postingDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_refno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TotAmtPaid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reboverride.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.penoverride.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aocoverride.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.intoverride.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prinoverride.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_remarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_acctno As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_LedSet As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_branchcode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents postingDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_refno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_TotAmtPaid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cust As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents reboverride As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents penoverride As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents aocoverride As DevExpress.XtraEditors.TextEdit
    Friend WithEvents intoverride As DevExpress.XtraEditors.TextEdit
    Friend WithEvents prinoverride As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Btn_Account As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Update As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
