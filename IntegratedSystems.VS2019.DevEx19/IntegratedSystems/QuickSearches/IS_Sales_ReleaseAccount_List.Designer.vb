<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Sales_ReleaseAccount_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Sales_ReleaseAccount_List))
        Me.LViewList = New System.Windows.Forms.ListView()
        Me.brcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.acctno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ledset = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.acctname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dategrant = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.orno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.financedamount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EngineNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChassisNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ModelCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColorCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CifKey = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AECode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_acctno = New System.Windows.Forms.Label()
        Me.txt_dategranted = New System.Windows.Forms.Label()
        Me.txt_branchcode = New System.Windows.Forms.Label()
        Me.txt_ledset = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.quickSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.acctStatON = New System.Windows.Forms.CheckBox()
        Me.txt_AccountStatus = New System.Windows.Forms.Label()
        Me.txt_orno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SearchByEC = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateGranted = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LViewList
        '
        Me.LViewList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.brcode, Me.acctno, Me.ledset, Me.acctname, Me.dategrant, Me.orno, Me.financedamount, Me.EngineNo, Me.ChassisNo, Me.ModelCol, Me.ColorCol, Me.CifKey, Me.AECode, Me.Address})
        Me.LViewList.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewList.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewList.FullRowSelect = True
        Me.LViewList.GridLines = True
        Me.LViewList.HideSelection = False
        Me.LViewList.Location = New System.Drawing.Point(5, 131)
        Me.LViewList.Name = "LViewList"
        Me.LViewList.Size = New System.Drawing.Size(668, 238)
        Me.LViewList.TabIndex = 17
        Me.LViewList.UseCompatibleStateImageBehavior = False
        Me.LViewList.View = System.Windows.Forms.View.Details
        '
        'brcode
        '
        Me.brcode.Text = "BRANCH"
        Me.brcode.Width = 74
        '
        'acctno
        '
        Me.acctno.Text = "ACCOUNTNUMBER"
        Me.acctno.Width = 172
        '
        'ledset
        '
        Me.ledset.Text = "LEDGERSET"
        Me.ledset.Width = 75
        '
        'acctname
        '
        Me.acctname.Text = "ACCOUNT NAME"
        Me.acctname.Width = 236
        '
        'dategrant
        '
        Me.dategrant.Text = "DATE GRANTED"
        Me.dategrant.Width = 109
        '
        'orno
        '
        Me.orno.Text = "OR"
        Me.orno.Width = 94
        '
        'financedamount
        '
        Me.financedamount.Text = "FINANCEDAMT"
        Me.financedamount.Width = 127
        '
        'EngineNo
        '
        Me.EngineNo.Text = "ENGINE"
        Me.EngineNo.Width = 120
        '
        'ChassisNo
        '
        Me.ChassisNo.Text = "CHASSIS"
        Me.ChassisNo.Width = 120
        '
        'ModelCol
        '
        Me.ModelCol.Text = "MODEL"
        Me.ModelCol.Width = 220
        '
        'ColorCol
        '
        Me.ColorCol.Text = "COLOR"
        Me.ColorCol.Width = 166
        '
        'CifKey
        '
        Me.CifKey.Text = "CIFKEY"
        '
        'AECode
        '
        Me.AECode.Text = "AE"
        '
        'Address
        '
        Me.Address.Text = "ADDRESS"
        '
        'txt_acctno
        '
        Me.txt_acctno.Location = New System.Drawing.Point(776, 52)
        Me.txt_acctno.Name = "txt_acctno"
        Me.txt_acctno.Size = New System.Drawing.Size(203, 23)
        Me.txt_acctno.TabIndex = 18
        Me.txt_acctno.Text = "accountno"
        '
        'txt_dategranted
        '
        Me.txt_dategranted.Location = New System.Drawing.Point(776, 75)
        Me.txt_dategranted.Name = "txt_dategranted"
        Me.txt_dategranted.Size = New System.Drawing.Size(203, 23)
        Me.txt_dategranted.TabIndex = 19
        Me.txt_dategranted.Text = "dategranted"
        '
        'txt_branchcode
        '
        Me.txt_branchcode.Location = New System.Drawing.Point(776, 98)
        Me.txt_branchcode.Name = "txt_branchcode"
        Me.txt_branchcode.Size = New System.Drawing.Size(203, 23)
        Me.txt_branchcode.TabIndex = 20
        Me.txt_branchcode.Text = "branchcode"
        '
        'txt_ledset
        '
        Me.txt_ledset.Location = New System.Drawing.Point(776, 121)
        Me.txt_ledset.Name = "txt_ledset"
        Me.txt_ledset.Size = New System.Drawing.Size(203, 23)
        Me.txt_ledset.TabIndex = 21
        Me.txt_ledset.Text = "ledgerset"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "NAME"
        '
        'quickSearch
        '
        Me.quickSearch.ForeColor = System.Drawing.Color.Teal
        Me.quickSearch.Location = New System.Drawing.Point(86, 24)
        Me.quickSearch.Name = "quickSearch"
        Me.quickSearch.Size = New System.Drawing.Size(258, 27)
        Me.quickSearch.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(714, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Account Status"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'acctStatON
        '
        Me.acctStatON.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acctStatON.ForeColor = System.Drawing.Color.White
        Me.acctStatON.Location = New System.Drawing.Point(812, 15)
        Me.acctStatON.Name = "acctStatON"
        Me.acctStatON.Size = New System.Drawing.Size(46, 24)
        Me.acctStatON.TabIndex = 28
        Me.acctStatON.Text = "ALL"
        Me.acctStatON.UseVisualStyleBackColor = True
        Me.acctStatON.Visible = False
        '
        'txt_AccountStatus
        '
        Me.txt_AccountStatus.Location = New System.Drawing.Point(779, 144)
        Me.txt_AccountStatus.Name = "txt_AccountStatus"
        Me.txt_AccountStatus.Size = New System.Drawing.Size(126, 23)
        Me.txt_AccountStatus.TabIndex = 29
        Me.txt_AccountStatus.Text = "accountno"
        '
        'txt_orno
        '
        Me.txt_orno.Location = New System.Drawing.Point(779, 167)
        Me.txt_orno.Name = "txt_orno"
        Me.txt_orno.Size = New System.Drawing.Size(126, 23)
        Me.txt_orno.TabIndex = 30
        Me.txt_orno.Text = "accountno"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 40)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "ENGINE / CHASSIS"
        '
        'SearchByEC
        '
        Me.SearchByEC.ForeColor = System.Drawing.Color.Teal
        Me.SearchByEC.Location = New System.Drawing.Point(86, 56)
        Me.SearchByEC.Name = "SearchByEC"
        Me.SearchByEC.Size = New System.Drawing.Size(258, 27)
        Me.SearchByEC.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateGranted)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.SearchByEC)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.quickSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(5, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(668, 95)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEARCH CATEGORY"
        '
        'DateGranted
        '
        Me.DateGranted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateGranted.Location = New System.Drawing.Point(492, 26)
        Me.DateGranted.Name = "DateGranted"
        Me.DateGranted.Size = New System.Drawing.Size(169, 27)
        Me.DateGranted.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(364, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 28)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "RELEASED DATE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(1, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(672, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "SEARCH CUSTOMER SALES ACCOUNT"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IS_Sales_ReleaseAccount_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(679, 376)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LViewList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_orno)
        Me.Controls.Add(Me.txt_AccountStatus)
        Me.Controls.Add(Me.acctStatON)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_ledset)
        Me.Controls.Add(Me.txt_branchcode)
        Me.Controls.Add(Me.txt_dategranted)
        Me.Controls.Add(Me.txt_acctno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Sales_ReleaseAccount_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACCOUNT LIST"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LViewList As System.Windows.Forms.ListView
    Friend WithEvents acctno As System.Windows.Forms.ColumnHeader
    Friend WithEvents acctname As System.Windows.Forms.ColumnHeader
    Friend WithEvents dategrant As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_acctno As System.Windows.Forms.Label
    Friend WithEvents txt_dategranted As System.Windows.Forms.Label
    Friend WithEvents brcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_branchcode As System.Windows.Forms.Label
    Friend WithEvents ledset As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_ledset As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents quickSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents acctStatON As System.Windows.Forms.CheckBox
    Friend WithEvents txt_AccountStatus As System.Windows.Forms.Label
    Friend WithEvents orno As System.Windows.Forms.ColumnHeader
    Friend WithEvents financedamount As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_orno As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SearchByEC As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateGranted As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EngineNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChassisNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ModelCol As ColumnHeader
    Friend WithEvents ColorCol As ColumnHeader
    Friend WithEvents CifKey As ColumnHeader
    Friend WithEvents AECode As ColumnHeader
    Friend WithEvents Address As ColumnHeader
    Friend WithEvents Label5 As Label
End Class
