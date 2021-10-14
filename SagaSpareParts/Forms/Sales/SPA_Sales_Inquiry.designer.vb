<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPA_Sales_Inquiry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPA_Sales_Inquiry))
        Me.TABPAGE = New System.Windows.Forms.TabControl()
        Me.tab_Details = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkNonVAT = New System.Windows.Forms.RadioButton()
        Me.chkVAT = New System.Windows.Forms.RadioButton()
        Me.lbl_Change = New System.Windows.Forms.Label()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Tendered = New System.Windows.Forms.Label()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_AmountPaid = New System.Windows.Forms.Label()
        Me.txt_CRNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_CustName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_custCode = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_Tamount = New System.Windows.Forms.Label()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_TotalLess1 = New System.Windows.Forms.Label()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_totalLess = New System.Windows.Forms.Label()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_totalVAT = New System.Windows.Forms.Label()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_AddVAT = New System.Windows.Forms.Label()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Due = New System.Windows.Forms.Label()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_PWD = New System.Windows.Forms.Label()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_NetVat = New System.Windows.Forms.Label()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_lessVAT = New System.Windows.Forms.Label()
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Total1 = New System.Windows.Forms.Label()
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_VAT2 = New System.Windows.Forms.Label()
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_VAT1 = New System.Windows.Forms.Label()
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_Payment = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_Status = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.lv_Parts = New System.Windows.Forms.ListView()
        Me.BranchCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Unit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grossTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Discount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Discount_PCT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.discountSRP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.subTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.prev_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partsNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partsName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_GTotal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Balance = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Credit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_AmountDue = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Note = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_SI_Code = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_TransCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_TransCategory = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_Terms = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_SINo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.dtp_Maturity = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.dtp_Date = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_BranchCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Address = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.tab_Ledger = New System.Windows.Forms.TabPage()
        Me.txt_CRNumber1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Status1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Balance1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Credit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_AmountDue1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Note1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_SI_Code1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_TransCode1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_TransCategory1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_Terms1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_SINo1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.dtp_Maturity1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.dtp_Date1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_BranchCode1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Address1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_CustName1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lv_Ledger = New System.Windows.Forms.ListView()
        Me.branchCode1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Credit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Balance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AmountDue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.saleStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.postingDate1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Print = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Error = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.TABPAGE.SuspendLayout()
        Me.tab_Details.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_CRNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CustName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_custCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Balance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Credit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AmountDue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_SI_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TransCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_TransCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Terms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SINo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Maturity.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Maturity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BranchCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_Ledger.SuspendLayout()
        CType(Me.txt_CRNumber1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Status1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Balance1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Credit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AmountDue1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Note1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_SI_Code1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TransCode1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_TransCategory1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Terms1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SINo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Maturity1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Maturity1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Date1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Date1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BranchCode1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Address1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CustName1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TABPAGE
        '
        Me.TABPAGE.Controls.Add(Me.tab_Details)
        Me.TABPAGE.Controls.Add(Me.tab_Ledger)
        Me.TABPAGE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TABPAGE.Location = New System.Drawing.Point(0, 24)
        Me.TABPAGE.Name = "TABPAGE"
        Me.TABPAGE.SelectedIndex = 0
        Me.TABPAGE.Size = New System.Drawing.Size(845, 519)
        Me.TABPAGE.TabIndex = 1
        '
        'tab_Details
        '
        Me.tab_Details.BackColor = System.Drawing.Color.Teal
        Me.tab_Details.Controls.Add(Me.Panel1)
        Me.tab_Details.Controls.Add(Me.txt_CRNumber)
        Me.tab_Details.Controls.Add(Me.LabelControl48)
        Me.tab_Details.Controls.Add(Me.txt_CustName)
        Me.tab_Details.Controls.Add(Me.txt_custCode)
        Me.tab_Details.Controls.Add(Me.lbl_Tamount)
        Me.tab_Details.Controls.Add(Me.LabelControl36)
        Me.tab_Details.Controls.Add(Me.lbl_TotalLess1)
        Me.tab_Details.Controls.Add(Me.LabelControl37)
        Me.tab_Details.Controls.Add(Me.lbl_totalLess)
        Me.tab_Details.Controls.Add(Me.LabelControl38)
        Me.tab_Details.Controls.Add(Me.lbl_totalVAT)
        Me.tab_Details.Controls.Add(Me.LabelControl39)
        Me.tab_Details.Controls.Add(Me.lbl_AddVAT)
        Me.tab_Details.Controls.Add(Me.LabelControl40)
        Me.tab_Details.Controls.Add(Me.lbl_Due)
        Me.tab_Details.Controls.Add(Me.LabelControl41)
        Me.tab_Details.Controls.Add(Me.lbl_PWD)
        Me.tab_Details.Controls.Add(Me.LabelControl42)
        Me.tab_Details.Controls.Add(Me.lbl_NetVat)
        Me.tab_Details.Controls.Add(Me.LabelControl43)
        Me.tab_Details.Controls.Add(Me.lbl_lessVAT)
        Me.tab_Details.Controls.Add(Me.LabelControl44)
        Me.tab_Details.Controls.Add(Me.lbl_Total1)
        Me.tab_Details.Controls.Add(Me.LabelControl45)
        Me.tab_Details.Controls.Add(Me.lbl_VAT2)
        Me.tab_Details.Controls.Add(Me.LabelControl46)
        Me.tab_Details.Controls.Add(Me.lbl_VAT1)
        Me.tab_Details.Controls.Add(Me.LabelControl47)
        Me.tab_Details.Controls.Add(Me.btn_Payment)
        Me.tab_Details.Controls.Add(Me.txt_Status)
        Me.tab_Details.Controls.Add(Me.LabelControl16)
        Me.tab_Details.Controls.Add(Me.lv_Parts)
        Me.tab_Details.Controls.Add(Me.txt_GTotal)
        Me.tab_Details.Controls.Add(Me.LabelControl15)
        Me.tab_Details.Controls.Add(Me.txt_Balance)
        Me.tab_Details.Controls.Add(Me.LabelControl14)
        Me.tab_Details.Controls.Add(Me.txt_Credit)
        Me.tab_Details.Controls.Add(Me.LabelControl13)
        Me.tab_Details.Controls.Add(Me.txt_AmountDue)
        Me.tab_Details.Controls.Add(Me.LabelControl12)
        Me.tab_Details.Controls.Add(Me.txt_Note)
        Me.tab_Details.Controls.Add(Me.LabelControl11)
        Me.tab_Details.Controls.Add(Me.LabelControl10)
        Me.tab_Details.Controls.Add(Me.cmb_SI_Code)
        Me.tab_Details.Controls.Add(Me.txt_TransCode)
        Me.tab_Details.Controls.Add(Me.LabelControl8)
        Me.tab_Details.Controls.Add(Me.cmb_TransCategory)
        Me.tab_Details.Controls.Add(Me.LabelControl7)
        Me.tab_Details.Controls.Add(Me.cmb_Terms)
        Me.tab_Details.Controls.Add(Me.txt_SINo)
        Me.tab_Details.Controls.Add(Me.LabelControl6)
        Me.tab_Details.Controls.Add(Me.dtp_Maturity)
        Me.tab_Details.Controls.Add(Me.LabelControl5)
        Me.tab_Details.Controls.Add(Me.dtp_Date)
        Me.tab_Details.Controls.Add(Me.LabelControl4)
        Me.tab_Details.Controls.Add(Me.txt_BranchCode)
        Me.tab_Details.Controls.Add(Me.LabelControl3)
        Me.tab_Details.Controls.Add(Me.txt_Address)
        Me.tab_Details.Controls.Add(Me.LabelControl2)
        Me.tab_Details.Controls.Add(Me.LabelControl1)
        Me.tab_Details.Controls.Add(Me.PictureBox1)
        Me.tab_Details.Controls.Add(Me.PictureBox2)
        Me.tab_Details.Controls.Add(Me.LabelControl9)
        Me.tab_Details.Location = New System.Drawing.Point(4, 22)
        Me.tab_Details.Name = "tab_Details"
        Me.tab_Details.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Details.Size = New System.Drawing.Size(837, 493)
        Me.tab_Details.TabIndex = 0
        Me.tab_Details.Text = "DETAILS"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lbl_Change)
        Me.Panel1.Controls.Add(Me.LabelControl32)
        Me.Panel1.Controls.Add(Me.LabelControl35)
        Me.Panel1.Controls.Add(Me.lbl_Tendered)
        Me.Panel1.Controls.Add(Me.lbl_Total)
        Me.Panel1.Controls.Add(Me.LabelControl33)
        Me.Panel1.Controls.Add(Me.LabelControl34)
        Me.Panel1.Controls.Add(Me.lbl_AmountPaid)
        Me.Panel1.Location = New System.Drawing.Point(161, 396)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(660, 90)
        Me.Panel1.TabIndex = 142
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkNonVAT)
        Me.Panel2.Controls.Add(Me.chkVAT)
        Me.Panel2.Location = New System.Drawing.Point(3, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 48)
        Me.Panel2.TabIndex = 122
        '
        'chkNonVAT
        '
        Me.chkNonVAT.AutoSize = True
        Me.chkNonVAT.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNonVAT.ForeColor = System.Drawing.Color.White
        Me.chkNonVAT.Location = New System.Drawing.Point(116, 10)
        Me.chkNonVAT.Name = "chkNonVAT"
        Me.chkNonVAT.Size = New System.Drawing.Size(75, 22)
        Me.chkNonVAT.TabIndex = 1
        Me.chkNonVAT.Text = "NonVAT"
        Me.chkNonVAT.UseVisualStyleBackColor = True
        '
        'chkVAT
        '
        Me.chkVAT.AutoSize = True
        Me.chkVAT.Checked = True
        Me.chkVAT.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVAT.ForeColor = System.Drawing.Color.White
        Me.chkVAT.Location = New System.Drawing.Point(14, 10)
        Me.chkVAT.Name = "chkVAT"
        Me.chkVAT.Size = New System.Drawing.Size(49, 22)
        Me.chkVAT.TabIndex = 0
        Me.chkVAT.TabStop = True
        Me.chkVAT.Text = "VAT"
        Me.chkVAT.UseVisualStyleBackColor = True
        '
        'lbl_Change
        '
        Me.lbl_Change.AutoSize = True
        Me.lbl_Change.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Change.ForeColor = System.Drawing.Color.White
        Me.lbl_Change.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Change.Location = New System.Drawing.Point(602, 66)
        Me.lbl_Change.Name = "lbl_Change"
        Me.lbl_Change.Size = New System.Drawing.Size(37, 19)
        Me.lbl_Change.TabIndex = 121
        Me.lbl_Change.Text = "0.00"
        Me.lbl_Change.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl32.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl32.Appearance.Options.UseFont = True
        Me.LabelControl32.Appearance.Options.UseForeColor = True
        Me.LabelControl32.Location = New System.Drawing.Point(354, 67)
        Me.LabelControl32.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(86, 19)
        Me.LabelControl32.TabIndex = 120
        Me.LabelControl32.Text = "Total Change"
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl35.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl35.Appearance.Options.UseFont = True
        Me.LabelControl35.Appearance.Options.UseForeColor = True
        Me.LabelControl35.Location = New System.Drawing.Point(354, 2)
        Me.LabelControl35.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(117, 19)
        Me.LabelControl35.TabIndex = 114
        Me.LabelControl35.Text = "Total Amount Due"
        '
        'lbl_Tendered
        '
        Me.lbl_Tendered.AutoSize = True
        Me.lbl_Tendered.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tendered.ForeColor = System.Drawing.Color.White
        Me.lbl_Tendered.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Tendered.Location = New System.Drawing.Point(602, 23)
        Me.lbl_Tendered.Name = "lbl_Tendered"
        Me.lbl_Tendered.Size = New System.Drawing.Size(37, 19)
        Me.lbl_Tendered.TabIndex = 119
        Me.lbl_Tendered.Text = "0.00"
        Me.lbl_Tendered.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.ForeColor = System.Drawing.Color.White
        Me.lbl_Total.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Total.Location = New System.Drawing.Point(602, 1)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(37, 19)
        Me.lbl_Total.TabIndex = 115
        Me.lbl_Total.Text = "0.00"
        Me.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl33
        '
        Me.LabelControl33.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl33.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl33.Appearance.Options.UseFont = True
        Me.LabelControl33.Appearance.Options.UseForeColor = True
        Me.LabelControl33.Location = New System.Drawing.Point(354, 24)
        Me.LabelControl33.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(115, 19)
        Me.LabelControl33.TabIndex = 118
        Me.LabelControl33.Text = "Amount Tendered"
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl34.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl34.Appearance.Options.UseFont = True
        Me.LabelControl34.Appearance.Options.UseForeColor = True
        Me.LabelControl34.Location = New System.Drawing.Point(354, 45)
        Me.LabelControl34.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(119, 19)
        Me.LabelControl34.TabIndex = 116
        Me.LabelControl34.Text = "Total Amount Paid"
        '
        'lbl_AmountPaid
        '
        Me.lbl_AmountPaid.AutoSize = True
        Me.lbl_AmountPaid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AmountPaid.ForeColor = System.Drawing.Color.White
        Me.lbl_AmountPaid.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_AmountPaid.Location = New System.Drawing.Point(602, 44)
        Me.lbl_AmountPaid.Name = "lbl_AmountPaid"
        Me.lbl_AmountPaid.Size = New System.Drawing.Size(37, 19)
        Me.lbl_AmountPaid.TabIndex = 117
        Me.lbl_AmountPaid.Text = "0.00"
        Me.lbl_AmountPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_CRNumber
        '
        Me.txt_CRNumber.Location = New System.Drawing.Point(406, 89)
        Me.txt_CRNumber.Name = "txt_CRNumber"
        Me.txt_CRNumber.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CRNumber.Properties.Appearance.Options.UseFont = True
        Me.txt_CRNumber.Size = New System.Drawing.Size(158, 26)
        Me.txt_CRNumber.TabIndex = 141
        '
        'LabelControl48
        '
        Me.LabelControl48.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl48.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl48.Appearance.Options.UseFont = True
        Me.LabelControl48.Appearance.Options.UseForeColor = True
        Me.LabelControl48.Location = New System.Drawing.Point(331, 92)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(82, 19)
        Me.LabelControl48.TabIndex = 140
        Me.LabelControl48.Text = "CR NUMBER"
        '
        'txt_CustName
        '
        Me.txt_CustName.Location = New System.Drawing.Point(210, 11)
        Me.txt_CustName.Name = "txt_CustName"
        Me.txt_CustName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CustName.Properties.Appearance.Options.UseFont = True
        Me.txt_CustName.Properties.ReadOnly = True
        Me.txt_CustName.Size = New System.Drawing.Size(354, 26)
        Me.txt_CustName.TabIndex = 39
        '
        'txt_custCode
        '
        Me.txt_custCode.Location = New System.Drawing.Point(283, 11)
        Me.txt_custCode.Name = "txt_custCode"
        Me.txt_custCode.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_custCode.Properties.Appearance.Options.UseFont = True
        Me.txt_custCode.Properties.ReadOnly = True
        Me.txt_custCode.Size = New System.Drawing.Size(250, 26)
        Me.txt_custCode.TabIndex = 138
        '
        'lbl_Tamount
        '
        Me.lbl_Tamount.AutoSize = True
        Me.lbl_Tamount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tamount.ForeColor = System.Drawing.Color.White
        Me.lbl_Tamount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Tamount.Location = New System.Drawing.Point(1214, 109)
        Me.lbl_Tamount.Name = "lbl_Tamount"
        Me.lbl_Tamount.Size = New System.Drawing.Size(15, 18)
        Me.lbl_Tamount.TabIndex = 137
        Me.lbl_Tamount.Text = "0"
        Me.lbl_Tamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl36.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl36.Appearance.Options.UseFont = True
        Me.LabelControl36.Appearance.Options.UseForeColor = True
        Me.LabelControl36.Location = New System.Drawing.Point(1072, 112)
        Me.LabelControl36.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(84, 18)
        Me.LabelControl36.TabIndex = 136
        Me.LabelControl36.Text = "Total Amount"
        '
        'lbl_TotalLess1
        '
        Me.lbl_TotalLess1.AutoSize = True
        Me.lbl_TotalLess1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalLess1.ForeColor = System.Drawing.Color.White
        Me.lbl_TotalLess1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_TotalLess1.Location = New System.Drawing.Point(1215, 219)
        Me.lbl_TotalLess1.Name = "lbl_TotalLess1"
        Me.lbl_TotalLess1.Size = New System.Drawing.Size(15, 18)
        Me.lbl_TotalLess1.TabIndex = 135
        Me.lbl_TotalLess1.Text = "0"
        Me.lbl_TotalLess1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl37
        '
        Me.LabelControl37.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl37.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl37.Appearance.Options.UseFont = True
        Me.LabelControl37.Appearance.Options.UseForeColor = True
        Me.LabelControl37.Location = New System.Drawing.Point(1073, 216)
        Me.LabelControl37.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(59, 18)
        Me.LabelControl37.TabIndex = 134
        Me.LabelControl37.Text = "Total VAT"
        '
        'lbl_totalLess
        '
        Me.lbl_totalLess.AutoSize = True
        Me.lbl_totalLess.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalLess.ForeColor = System.Drawing.Color.White
        Me.lbl_totalLess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_totalLess.Location = New System.Drawing.Point(1215, 166)
        Me.lbl_totalLess.Name = "lbl_totalLess"
        Me.lbl_totalLess.Size = New System.Drawing.Size(15, 18)
        Me.lbl_totalLess.TabIndex = 133
        Me.lbl_totalLess.Text = "0"
        Me.lbl_totalLess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl38
        '
        Me.LabelControl38.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl38.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl38.Appearance.Options.UseFont = True
        Me.LabelControl38.Appearance.Options.UseForeColor = True
        Me.LabelControl38.Location = New System.Drawing.Point(1073, 163)
        Me.LabelControl38.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(85, 18)
        Me.LabelControl38.TabIndex = 132
        Me.LabelControl38.Text = "Total Net VAT"
        '
        'lbl_totalVAT
        '
        Me.lbl_totalVAT.AutoSize = True
        Me.lbl_totalVAT.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalVAT.ForeColor = System.Drawing.Color.White
        Me.lbl_totalVAT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_totalVAT.Location = New System.Drawing.Point(1219, 456)
        Me.lbl_totalVAT.Name = "lbl_totalVAT"
        Me.lbl_totalVAT.Size = New System.Drawing.Size(33, 18)
        Me.lbl_totalVAT.TabIndex = 131
        Me.lbl_totalVAT.Text = "0.00"
        Me.lbl_totalVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl39
        '
        Me.LabelControl39.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl39.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl39.Appearance.Options.UseFont = True
        Me.LabelControl39.Appearance.Options.UseForeColor = True
        Me.LabelControl39.Location = New System.Drawing.Point(1072, 453)
        Me.LabelControl39.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(112, 18)
        Me.LabelControl39.TabIndex = 130
        Me.LabelControl39.Text = "Total Amount Due"
        '
        'lbl_AddVAT
        '
        Me.lbl_AddVAT.AutoSize = True
        Me.lbl_AddVAT.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AddVAT.ForeColor = System.Drawing.Color.White
        Me.lbl_AddVAT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_AddVAT.Location = New System.Drawing.Point(1219, 430)
        Me.lbl_AddVAT.Name = "lbl_AddVAT"
        Me.lbl_AddVAT.Size = New System.Drawing.Size(33, 18)
        Me.lbl_AddVAT.TabIndex = 129
        Me.lbl_AddVAT.Text = "0.00"
        Me.lbl_AddVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl40
        '
        Me.LabelControl40.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl40.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl40.Appearance.Options.UseFont = True
        Me.LabelControl40.Appearance.Options.UseForeColor = True
        Me.LabelControl40.Location = New System.Drawing.Point(1072, 427)
        Me.LabelControl40.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(53, 18)
        Me.LabelControl40.TabIndex = 128
        Me.LabelControl40.Text = "Add VAT"
        '
        'lbl_Due
        '
        Me.lbl_Due.AutoSize = True
        Me.lbl_Due.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Due.ForeColor = System.Drawing.Color.White
        Me.lbl_Due.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Due.Location = New System.Drawing.Point(1219, 404)
        Me.lbl_Due.Name = "lbl_Due"
        Me.lbl_Due.Size = New System.Drawing.Size(33, 18)
        Me.lbl_Due.TabIndex = 127
        Me.lbl_Due.Text = "0.00"
        Me.lbl_Due.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl41
        '
        Me.LabelControl41.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl41.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl41.Appearance.Options.UseFont = True
        Me.LabelControl41.Appearance.Options.UseForeColor = True
        Me.LabelControl41.Location = New System.Drawing.Point(1072, 401)
        Me.LabelControl41.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(78, 18)
        Me.LabelControl41.TabIndex = 126
        Me.LabelControl41.Text = "Amount Due"
        '
        'lbl_PWD
        '
        Me.lbl_PWD.AutoSize = True
        Me.lbl_PWD.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PWD.ForeColor = System.Drawing.Color.White
        Me.lbl_PWD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_PWD.Location = New System.Drawing.Point(1219, 378)
        Me.lbl_PWD.Name = "lbl_PWD"
        Me.lbl_PWD.Size = New System.Drawing.Size(33, 18)
        Me.lbl_PWD.TabIndex = 125
        Me.lbl_PWD.Text = "0.00"
        Me.lbl_PWD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl42
        '
        Me.LabelControl42.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl42.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl42.Appearance.Options.UseFont = True
        Me.LabelControl42.Appearance.Options.UseForeColor = True
        Me.LabelControl42.Location = New System.Drawing.Point(1072, 375)
        Me.LabelControl42.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(141, 18)
        Me.LabelControl42.TabIndex = 124
        Me.LabelControl42.Text = "Less: SC/PWD Discount"
        '
        'lbl_NetVat
        '
        Me.lbl_NetVat.AutoSize = True
        Me.lbl_NetVat.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NetVat.ForeColor = System.Drawing.Color.White
        Me.lbl_NetVat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_NetVat.Location = New System.Drawing.Point(1219, 353)
        Me.lbl_NetVat.Name = "lbl_NetVat"
        Me.lbl_NetVat.Size = New System.Drawing.Size(33, 18)
        Me.lbl_NetVat.TabIndex = 123
        Me.lbl_NetVat.Text = "0.00"
        Me.lbl_NetVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl43
        '
        Me.LabelControl43.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl43.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl43.Appearance.Options.UseFont = True
        Me.LabelControl43.Appearance.Options.UseForeColor = True
        Me.LabelControl43.Location = New System.Drawing.Point(1072, 350)
        Me.LabelControl43.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(103, 18)
        Me.LabelControl43.TabIndex = 122
        Me.LabelControl43.Text = "AMT NET OF VAT"
        '
        'lbl_lessVAT
        '
        Me.lbl_lessVAT.AutoSize = True
        Me.lbl_lessVAT.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lessVAT.ForeColor = System.Drawing.Color.White
        Me.lbl_lessVAT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_lessVAT.Location = New System.Drawing.Point(1219, 327)
        Me.lbl_lessVAT.Name = "lbl_lessVAT"
        Me.lbl_lessVAT.Size = New System.Drawing.Size(33, 18)
        Me.lbl_lessVAT.TabIndex = 121
        Me.lbl_lessVAT.Text = "0.00"
        Me.lbl_lessVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl44
        '
        Me.LabelControl44.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl44.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl44.Appearance.Options.UseFont = True
        Me.LabelControl44.Appearance.Options.UseForeColor = True
        Me.LabelControl44.Location = New System.Drawing.Point(1072, 324)
        Me.LabelControl44.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(54, 18)
        Me.LabelControl44.TabIndex = 120
        Me.LabelControl44.Text = "Less VAT"
        '
        'lbl_Total1
        '
        Me.lbl_Total1.AutoSize = True
        Me.lbl_Total1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total1.ForeColor = System.Drawing.Color.White
        Me.lbl_Total1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Total1.Location = New System.Drawing.Point(1215, 239)
        Me.lbl_Total1.Name = "lbl_Total1"
        Me.lbl_Total1.Size = New System.Drawing.Size(33, 18)
        Me.lbl_Total1.TabIndex = 119
        Me.lbl_Total1.Text = "1.00"
        Me.lbl_Total1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl45
        '
        Me.LabelControl45.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl45.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl45.Appearance.Options.UseFont = True
        Me.LabelControl45.Appearance.Options.UseForeColor = True
        Me.LabelControl45.Location = New System.Drawing.Point(1073, 242)
        Me.LabelControl45.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(59, 18)
        Me.LabelControl45.TabIndex = 118
        Me.LabelControl45.Text = "Total VAT"
        '
        'lbl_VAT2
        '
        Me.lbl_VAT2.AutoSize = True
        Me.lbl_VAT2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VAT2.ForeColor = System.Drawing.Color.White
        Me.lbl_VAT2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_VAT2.Location = New System.Drawing.Point(1215, 186)
        Me.lbl_VAT2.Name = "lbl_VAT2"
        Me.lbl_VAT2.Size = New System.Drawing.Size(33, 18)
        Me.lbl_VAT2.TabIndex = 117
        Me.lbl_VAT2.Text = "0.12"
        Me.lbl_VAT2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl46
        '
        Me.LabelControl46.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl46.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl46.Appearance.Options.UseFont = True
        Me.LabelControl46.Appearance.Options.UseForeColor = True
        Me.LabelControl46.Location = New System.Drawing.Point(1073, 189)
        Me.LabelControl46.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(53, 18)
        Me.LabelControl46.TabIndex = 116
        Me.LabelControl46.Text = "VAT 0.12"
        '
        'lbl_VAT1
        '
        Me.lbl_VAT1.AutoSize = True
        Me.lbl_VAT1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VAT1.ForeColor = System.Drawing.Color.White
        Me.lbl_VAT1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_VAT1.Location = New System.Drawing.Point(1215, 134)
        Me.lbl_VAT1.Name = "lbl_VAT1"
        Me.lbl_VAT1.Size = New System.Drawing.Size(33, 18)
        Me.lbl_VAT1.TabIndex = 115
        Me.lbl_VAT1.Text = "1.12"
        Me.lbl_VAT1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl47
        '
        Me.LabelControl47.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl47.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl47.Appearance.Options.UseFont = True
        Me.LabelControl47.Appearance.Options.UseForeColor = True
        Me.LabelControl47.Location = New System.Drawing.Point(1073, 137)
        Me.LabelControl47.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(53, 18)
        Me.LabelControl47.TabIndex = 114
        Me.LabelControl47.Text = "VAT 1.12"
        '
        'btn_Payment
        '
        Me.btn_Payment.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Payment.Appearance.Options.UseFont = True
        Me.btn_Payment.Location = New System.Drawing.Point(10, 401)
        Me.btn_Payment.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Payment.Name = "btn_Payment"
        Me.btn_Payment.Size = New System.Drawing.Size(145, 59)
        Me.btn_Payment.TabIndex = 105
        Me.btn_Payment.Text = "Input Payment"
        '
        'txt_Status
        '
        Me.txt_Status.Location = New System.Drawing.Point(697, 167)
        Me.txt_Status.Name = "txt_Status"
        Me.txt_Status.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Status.Properties.Appearance.Options.UseFont = True
        Me.txt_Status.Properties.ReadOnly = True
        Me.txt_Status.Size = New System.Drawing.Size(124, 26)
        Me.txt_Status.TabIndex = 70
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Appearance.Options.UseForeColor = True
        Me.LabelControl16.Location = New System.Drawing.Point(587, 170)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(97, 19)
        Me.LabelControl16.TabIndex = 69
        Me.LabelControl16.Text = "SALES STATUS"
        '
        'lv_Parts
        '
        Me.lv_Parts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BranchCode, Me.quantity, Me.Unit, Me.description, Me.unitPrice, Me.grossTotal, Me.Discount, Me.Discount_PCT, Me.discountSRP, Me.subTotal, Me.prev_ID, Me.partsNumber, Me.partsName})
        Me.lv_Parts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_Parts.ForeColor = System.Drawing.Color.Teal
        Me.lv_Parts.FullRowSelect = True
        Me.lv_Parts.GridLines = True
        Me.lv_Parts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lv_Parts.HideSelection = False
        Me.lv_Parts.Location = New System.Drawing.Point(10, 249)
        Me.lv_Parts.Margin = New System.Windows.Forms.Padding(4)
        Me.lv_Parts.Name = "lv_Parts"
        Me.lv_Parts.Size = New System.Drawing.Size(811, 143)
        Me.lv_Parts.TabIndex = 64
        Me.lv_Parts.UseCompatibleStateImageBehavior = False
        Me.lv_Parts.View = System.Windows.Forms.View.Details
        '
        'BranchCode
        '
        Me.BranchCode.Text = "Branch Code"
        Me.BranchCode.Width = 0
        '
        'quantity
        '
        Me.quantity.Text = "Quantity"
        Me.quantity.Width = 70
        '
        'Unit
        '
        Me.Unit.Text = "Unit"
        Me.Unit.Width = 0
        '
        'description
        '
        Me.description.Text = "Description"
        Me.description.Width = 270
        '
        'unitPrice
        '
        Me.unitPrice.Text = "Unit Price"
        Me.unitPrice.Width = 126
        '
        'grossTotal
        '
        Me.grossTotal.Text = "Gross Total"
        Me.grossTotal.Width = 111
        '
        'Discount
        '
        Me.Discount.Text = "Discount"
        Me.Discount.Width = 116
        '
        'Discount_PCT
        '
        Me.Discount_PCT.Text = "DisctPctg"
        Me.Discount_PCT.Width = 129
        '
        'discountSRP
        '
        Me.discountSRP.Text = "DisctdUPrice"
        Me.discountSRP.Width = 135
        '
        'subTotal
        '
        Me.subTotal.Text = "SubTotal"
        Me.subTotal.Width = 153
        '
        'prev_ID
        '
        Me.prev_ID.Text = "prev_ID"
        Me.prev_ID.Width = 0
        '
        'partsNumber
        '
        Me.partsNumber.Text = "PartsNumber"
        Me.partsNumber.Width = 1
        '
        'partsName
        '
        Me.partsName.Text = "PartsName"
        Me.partsName.Width = 0
        '
        'txt_GTotal
        '
        Me.txt_GTotal.Location = New System.Drawing.Point(616, 368)
        Me.txt_GTotal.Name = "txt_GTotal"
        Me.txt_GTotal.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GTotal.Properties.Appearance.Options.UseFont = True
        Me.txt_GTotal.Size = New System.Drawing.Size(205, 26)
        Me.txt_GTotal.TabIndex = 68
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Appearance.Options.UseForeColor = True
        Me.LabelControl15.Location = New System.Drawing.Point(512, 371)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(98, 19)
        Me.LabelControl15.TabIndex = 67
        Me.LabelControl15.Text = "GRAND TOTAL"
        '
        'txt_Balance
        '
        Me.txt_Balance.Location = New System.Drawing.Point(667, 206)
        Me.txt_Balance.Name = "txt_Balance"
        Me.txt_Balance.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Balance.Properties.Appearance.Options.UseFont = True
        Me.txt_Balance.Properties.ReadOnly = True
        Me.txt_Balance.Size = New System.Drawing.Size(154, 26)
        Me.txt_Balance.TabIndex = 66
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Appearance.Options.UseForeColor = True
        Me.LabelControl14.Location = New System.Drawing.Point(492, 209)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(168, 19)
        Me.LabelControl14.TabIndex = 65
        Me.LabelControl14.Text = "OUTSTANDING BALANCE"
        '
        'txt_Credit
        '
        Me.txt_Credit.Location = New System.Drawing.Point(325, 206)
        Me.txt_Credit.Name = "txt_Credit"
        Me.txt_Credit.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Credit.Properties.Appearance.Options.UseFont = True
        Me.txt_Credit.Properties.ReadOnly = True
        Me.txt_Credit.Size = New System.Drawing.Size(147, 26)
        Me.txt_Credit.TabIndex = 63
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(268, 209)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl13.TabIndex = 62
        Me.LabelControl13.Text = "CREDIT"
        '
        'txt_AmountDue
        '
        Me.txt_AmountDue.Location = New System.Drawing.Point(130, 206)
        Me.txt_AmountDue.Name = "txt_AmountDue"
        Me.txt_AmountDue.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AmountDue.Properties.Appearance.Options.UseFont = True
        Me.txt_AmountDue.Properties.ReadOnly = True
        Me.txt_AmountDue.Size = New System.Drawing.Size(123, 26)
        Me.txt_AmountDue.TabIndex = 61
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(13, 209)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(96, 19)
        Me.LabelControl12.TabIndex = 60
        Me.LabelControl12.Text = "AMOUNT DUE"
        '
        'txt_Note
        '
        Me.txt_Note.Location = New System.Drawing.Point(130, 167)
        Me.txt_Note.Name = "txt_Note"
        Me.txt_Note.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Note.Properties.Appearance.Options.UseFont = True
        Me.txt_Note.Properties.ReadOnly = True
        Me.txt_Note.Size = New System.Drawing.Size(434, 26)
        Me.txt_Note.TabIndex = 59
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(71, 170)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(38, 19)
        Me.LabelControl11.TabIndex = 58
        Me.LabelControl11.Text = "NOTE"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(621, 131)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl10.TabIndex = 57
        Me.LabelControl10.Text = "INVOICES"
        '
        'cmb_SI_Code
        '
        Me.cmb_SI_Code.Location = New System.Drawing.Point(697, 128)
        Me.cmb_SI_Code.Name = "cmb_SI_Code"
        Me.cmb_SI_Code.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_SI_Code.Properties.Appearance.Options.UseFont = True
        Me.cmb_SI_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_SI_Code.Properties.ReadOnly = True
        Me.cmb_SI_Code.Size = New System.Drawing.Size(124, 26)
        Me.cmb_SI_Code.TabIndex = 56
        '
        'txt_TransCode
        '
        Me.txt_TransCode.Location = New System.Drawing.Point(329, 128)
        Me.txt_TransCode.Name = "txt_TransCode"
        Me.txt_TransCode.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TransCode.Properties.Appearance.Options.UseFont = True
        Me.txt_TransCode.Properties.ReadOnly = True
        Me.txt_TransCode.Size = New System.Drawing.Size(99, 26)
        Me.txt_TransCode.TabIndex = 55
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(13, 123)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(98, 19)
        Me.LabelControl8.TabIndex = 53
        Me.LabelControl8.Text = "TRANSACTION"
        '
        'cmb_TransCategory
        '
        Me.cmb_TransCategory.Location = New System.Drawing.Point(130, 128)
        Me.cmb_TransCategory.Name = "cmb_TransCategory"
        Me.cmb_TransCategory.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TransCategory.Properties.Appearance.Options.UseFont = True
        Me.cmb_TransCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_TransCategory.Properties.ReadOnly = True
        Me.cmb_TransCategory.Size = New System.Drawing.Size(191, 26)
        Me.cmb_TransCategory.TabIndex = 52
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(637, 92)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl7.TabIndex = 51
        Me.LabelControl7.Text = "TERMS"
        '
        'cmb_Terms
        '
        Me.cmb_Terms.Location = New System.Drawing.Point(697, 89)
        Me.cmb_Terms.Name = "cmb_Terms"
        Me.cmb_Terms.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Terms.Properties.Appearance.Options.UseFont = True
        Me.cmb_Terms.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Terms.Properties.ReadOnly = True
        Me.cmb_Terms.Size = New System.Drawing.Size(124, 26)
        Me.cmb_Terms.TabIndex = 50
        '
        'txt_SINo
        '
        Me.txt_SINo.Location = New System.Drawing.Point(210, 89)
        Me.txt_SINo.Name = "txt_SINo"
        Me.txt_SINo.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SINo.Properties.Appearance.Options.UseFont = True
        Me.txt_SINo.Properties.ReadOnly = True
        Me.txt_SINo.Size = New System.Drawing.Size(111, 26)
        Me.txt_SINo.TabIndex = 49
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(129, 92)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(77, 19)
        Me.LabelControl6.TabIndex = 48
        Me.LabelControl6.Text = "SI NUMBER"
        '
        'dtp_Maturity
        '
        Me.dtp_Maturity.EditValue = Nothing
        Me.dtp_Maturity.Location = New System.Drawing.Point(697, 50)
        Me.dtp_Maturity.Name = "dtp_Maturity"
        Me.dtp_Maturity.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Maturity.Properties.Appearance.Options.UseFont = True
        Me.dtp_Maturity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_Maturity.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_Maturity.Properties.DisplayFormat.FormatString = "MM/dd/ yyyy"
        Me.dtp_Maturity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_Maturity.Properties.EditFormat.FormatString = "MM/dd/ yyyy"
        Me.dtp_Maturity.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_Maturity.Properties.Mask.EditMask = "MM/dd/ yyyy"
        Me.dtp_Maturity.Properties.ReadOnly = True
        Me.dtp_Maturity.Size = New System.Drawing.Size(124, 26)
        Me.dtp_Maturity.TabIndex = 47
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(573, 53)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(111, 19)
        Me.LabelControl5.TabIndex = 46
        Me.LabelControl5.Text = "MATURITY DATE"
        '
        'dtp_Date
        '
        Me.dtp_Date.EditValue = Nothing
        Me.dtp_Date.Location = New System.Drawing.Point(697, 11)
        Me.dtp_Date.Name = "dtp_Date"
        Me.dtp_Date.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date.Properties.Appearance.Options.UseFont = True
        Me.dtp_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_Date.Properties.DisplayFormat.FormatString = "MM/dd/ yyyy"
        Me.dtp_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_Date.Properties.EditFormat.FormatString = "MM/dd/ yyyy"
        Me.dtp_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_Date.Properties.Mask.EditMask = "MM/dd/ yyyy"
        Me.dtp_Date.Size = New System.Drawing.Size(124, 26)
        Me.dtp_Date.TabIndex = 45
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(573, 14)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(101, 19)
        Me.LabelControl4.TabIndex = 44
        Me.LabelControl4.Text = "POSTING DATE"
        '
        'txt_BranchCode
        '
        Me.txt_BranchCode.Location = New System.Drawing.Point(501, 128)
        Me.txt_BranchCode.Name = "txt_BranchCode"
        Me.txt_BranchCode.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BranchCode.Properties.Appearance.Options.UseFont = True
        Me.txt_BranchCode.Properties.ReadOnly = True
        Me.txt_BranchCode.Size = New System.Drawing.Size(63, 26)
        Me.txt_BranchCode.TabIndex = 43
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(438, 131)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 19)
        Me.LabelControl3.TabIndex = 42
        Me.LabelControl3.Text = "BRANCH"
        '
        'txt_Address
        '
        Me.txt_Address.Location = New System.Drawing.Point(210, 50)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address.Properties.Appearance.Options.UseFont = True
        Me.txt_Address.Properties.ReadOnly = True
        Me.txt_Address.Size = New System.Drawing.Size(354, 26)
        Me.txt_Address.TabIndex = 41
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(141, 53)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl2.TabIndex = 40
        Me.LabelControl2.Text = "ADDRESS"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(161, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl1.TabIndex = 38
        Me.LabelControl1.Text = "NAME"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(14, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 104)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(13, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(105, 108)
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(37, 143)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(72, 19)
        Me.LabelControl9.TabIndex = 54
        Me.LabelControl9.Text = "CATEGORY"
        '
        'tab_Ledger
        '
        Me.tab_Ledger.BackColor = System.Drawing.Color.Teal
        Me.tab_Ledger.Controls.Add(Me.txt_CRNumber1)
        Me.tab_Ledger.Controls.Add(Me.LabelControl49)
        Me.tab_Ledger.Controls.Add(Me.txt_Status1)
        Me.tab_Ledger.Controls.Add(Me.LabelControl17)
        Me.tab_Ledger.Controls.Add(Me.txt_Balance1)
        Me.tab_Ledger.Controls.Add(Me.LabelControl18)
        Me.tab_Ledger.Controls.Add(Me.txt_Credit1)
        Me.tab_Ledger.Controls.Add(Me.LabelControl19)
        Me.tab_Ledger.Controls.Add(Me.txt_AmountDue1)
        Me.tab_Ledger.Controls.Add(Me.LabelControl20)
        Me.tab_Ledger.Controls.Add(Me.txt_Note1)
        Me.tab_Ledger.Controls.Add(Me.LabelControl21)
        Me.tab_Ledger.Controls.Add(Me.LabelControl22)
        Me.tab_Ledger.Controls.Add(Me.cmb_SI_Code1)
        Me.tab_Ledger.Controls.Add(Me.txt_TransCode1)
        Me.tab_Ledger.Controls.Add(Me.LabelControl23)
        Me.tab_Ledger.Controls.Add(Me.cmb_TransCategory1)
        Me.tab_Ledger.Controls.Add(Me.LabelControl24)
        Me.tab_Ledger.Controls.Add(Me.cmb_Terms1)
        Me.tab_Ledger.Controls.Add(Me.txt_SINo1)
        Me.tab_Ledger.Controls.Add(Me.LabelControl25)
        Me.tab_Ledger.Controls.Add(Me.dtp_Maturity1)
        Me.tab_Ledger.Controls.Add(Me.LabelControl26)
        Me.tab_Ledger.Controls.Add(Me.dtp_Date1)
        Me.tab_Ledger.Controls.Add(Me.LabelControl27)
        Me.tab_Ledger.Controls.Add(Me.txt_BranchCode1)
        Me.tab_Ledger.Controls.Add(Me.LabelControl28)
        Me.tab_Ledger.Controls.Add(Me.txt_Address1)
        Me.tab_Ledger.Controls.Add(Me.LabelControl29)
        Me.tab_Ledger.Controls.Add(Me.txt_CustName1)
        Me.tab_Ledger.Controls.Add(Me.LabelControl30)
        Me.tab_Ledger.Controls.Add(Me.LabelControl31)
        Me.tab_Ledger.Controls.Add(Me.PictureBox3)
        Me.tab_Ledger.Controls.Add(Me.PictureBox4)
        Me.tab_Ledger.Controls.Add(Me.lv_Ledger)
        Me.tab_Ledger.Location = New System.Drawing.Point(4, 22)
        Me.tab_Ledger.Name = "tab_Ledger"
        Me.tab_Ledger.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Ledger.Size = New System.Drawing.Size(837, 493)
        Me.tab_Ledger.TabIndex = 1
        Me.tab_Ledger.Text = "LEDGER"
        '
        'txt_CRNumber1
        '
        Me.txt_CRNumber1.Location = New System.Drawing.Point(449, 89)
        Me.txt_CRNumber1.Name = "txt_CRNumber1"
        Me.txt_CRNumber1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CRNumber1.Properties.Appearance.Options.UseFont = True
        Me.txt_CRNumber1.Properties.ReadOnly = True
        Me.txt_CRNumber1.Size = New System.Drawing.Size(118, 26)
        Me.txt_CRNumber1.TabIndex = 105
        '
        'LabelControl49
        '
        Me.LabelControl49.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl49.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl49.Appearance.Options.UseFont = True
        Me.LabelControl49.Appearance.Options.UseForeColor = True
        Me.LabelControl49.Location = New System.Drawing.Point(355, 92)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(82, 19)
        Me.LabelControl49.TabIndex = 104
        Me.LabelControl49.Text = "CR NUMBER"
        '
        'txt_Status1
        '
        Me.txt_Status1.Location = New System.Drawing.Point(702, 167)
        Me.txt_Status1.Name = "txt_Status1"
        Me.txt_Status1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Status1.Properties.Appearance.Options.UseFont = True
        Me.txt_Status1.Properties.ReadOnly = True
        Me.txt_Status1.Size = New System.Drawing.Size(131, 26)
        Me.txt_Status1.TabIndex = 102
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Appearance.Options.UseForeColor = True
        Me.LabelControl17.Location = New System.Drawing.Point(592, 170)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(97, 19)
        Me.LabelControl17.TabIndex = 101
        Me.LabelControl17.Text = "SALES STATUS"
        '
        'txt_Balance1
        '
        Me.txt_Balance1.Location = New System.Drawing.Point(686, 206)
        Me.txt_Balance1.Name = "txt_Balance1"
        Me.txt_Balance1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Balance1.Properties.Appearance.Options.UseFont = True
        Me.txt_Balance1.Properties.ReadOnly = True
        Me.txt_Balance1.Size = New System.Drawing.Size(147, 26)
        Me.txt_Balance1.TabIndex = 100
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Appearance.Options.UseForeColor = True
        Me.LabelControl18.Location = New System.Drawing.Point(529, 209)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(168, 19)
        Me.LabelControl18.TabIndex = 99
        Me.LabelControl18.Text = "OUTSTANDING BALANCE"
        '
        'txt_Credit1
        '
        Me.txt_Credit1.Location = New System.Drawing.Point(345, 206)
        Me.txt_Credit1.Name = "txt_Credit1"
        Me.txt_Credit1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Credit1.Properties.Appearance.Options.UseFont = True
        Me.txt_Credit1.Properties.ReadOnly = True
        Me.txt_Credit1.Size = New System.Drawing.Size(160, 26)
        Me.txt_Credit1.TabIndex = 98
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Appearance.Options.UseForeColor = True
        Me.LabelControl19.Location = New System.Drawing.Point(286, 209)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl19.TabIndex = 97
        Me.LabelControl19.Text = "CREDIT"
        '
        'txt_AmountDue1
        '
        Me.txt_AmountDue1.Location = New System.Drawing.Point(130, 206)
        Me.txt_AmountDue1.Name = "txt_AmountDue1"
        Me.txt_AmountDue1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AmountDue1.Properties.Appearance.Options.UseFont = True
        Me.txt_AmountDue1.Properties.ReadOnly = True
        Me.txt_AmountDue1.Size = New System.Drawing.Size(136, 26)
        Me.txt_AmountDue1.TabIndex = 96
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Appearance.Options.UseForeColor = True
        Me.LabelControl20.Location = New System.Drawing.Point(13, 209)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(96, 19)
        Me.LabelControl20.TabIndex = 95
        Me.LabelControl20.Text = "AMOUNT DUE"
        '
        'txt_Note1
        '
        Me.txt_Note1.Location = New System.Drawing.Point(130, 167)
        Me.txt_Note1.Name = "txt_Note1"
        Me.txt_Note1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Note1.Properties.Appearance.Options.UseFont = True
        Me.txt_Note1.Properties.ReadOnly = True
        Me.txt_Note1.Size = New System.Drawing.Size(437, 26)
        Me.txt_Note1.TabIndex = 94
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Appearance.Options.UseForeColor = True
        Me.LabelControl21.Location = New System.Drawing.Point(71, 170)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(38, 19)
        Me.LabelControl21.TabIndex = 93
        Me.LabelControl21.Text = "NOTE"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Appearance.Options.UseForeColor = True
        Me.LabelControl22.Location = New System.Drawing.Point(626, 131)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl22.TabIndex = 92
        Me.LabelControl22.Text = "INVOICES"
        '
        'cmb_SI_Code1
        '
        Me.cmb_SI_Code1.Location = New System.Drawing.Point(702, 128)
        Me.cmb_SI_Code1.Name = "cmb_SI_Code1"
        Me.cmb_SI_Code1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_SI_Code1.Properties.Appearance.Options.UseFont = True
        Me.cmb_SI_Code1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_SI_Code1.Properties.ReadOnly = True
        Me.cmb_SI_Code1.Size = New System.Drawing.Size(131, 26)
        Me.cmb_SI_Code1.TabIndex = 91
        '
        'txt_TransCode1
        '
        Me.txt_TransCode1.Location = New System.Drawing.Point(345, 128)
        Me.txt_TransCode1.Name = "txt_TransCode1"
        Me.txt_TransCode1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TransCode1.Properties.Appearance.Options.UseFont = True
        Me.txt_TransCode1.Properties.ReadOnly = True
        Me.txt_TransCode1.Size = New System.Drawing.Size(86, 26)
        Me.txt_TransCode1.TabIndex = 90
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl23.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl23.Appearance.Options.UseFont = True
        Me.LabelControl23.Appearance.Options.UseForeColor = True
        Me.LabelControl23.Location = New System.Drawing.Point(13, 123)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(98, 19)
        Me.LabelControl23.TabIndex = 88
        Me.LabelControl23.Text = "TRANSACTION"
        '
        'cmb_TransCategory1
        '
        Me.cmb_TransCategory1.Location = New System.Drawing.Point(130, 128)
        Me.cmb_TransCategory1.Name = "cmb_TransCategory1"
        Me.cmb_TransCategory1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TransCategory1.Properties.Appearance.Options.UseFont = True
        Me.cmb_TransCategory1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_TransCategory1.Properties.ReadOnly = True
        Me.cmb_TransCategory1.Size = New System.Drawing.Size(210, 26)
        Me.cmb_TransCategory1.TabIndex = 87
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl24.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl24.Appearance.Options.UseFont = True
        Me.LabelControl24.Appearance.Options.UseForeColor = True
        Me.LabelControl24.Location = New System.Drawing.Point(642, 92)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl24.TabIndex = 86
        Me.LabelControl24.Text = "TERMS"
        '
        'cmb_Terms1
        '
        Me.cmb_Terms1.Location = New System.Drawing.Point(702, 89)
        Me.cmb_Terms1.Name = "cmb_Terms1"
        Me.cmb_Terms1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Terms1.Properties.Appearance.Options.UseFont = True
        Me.cmb_Terms1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Terms1.Properties.ReadOnly = True
        Me.cmb_Terms1.Size = New System.Drawing.Size(131, 26)
        Me.cmb_Terms1.TabIndex = 85
        '
        'txt_SINo1
        '
        Me.txt_SINo1.Location = New System.Drawing.Point(210, 89)
        Me.txt_SINo1.Name = "txt_SINo1"
        Me.txt_SINo1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SINo1.Properties.Appearance.Options.UseFont = True
        Me.txt_SINo1.Properties.ReadOnly = True
        Me.txt_SINo1.Size = New System.Drawing.Size(130, 26)
        Me.txt_SINo1.TabIndex = 84
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl25.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl25.Appearance.Options.UseFont = True
        Me.LabelControl25.Appearance.Options.UseForeColor = True
        Me.LabelControl25.Location = New System.Drawing.Point(129, 92)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(77, 19)
        Me.LabelControl25.TabIndex = 83
        Me.LabelControl25.Text = "SI NUMBER"
        '
        'dtp_Maturity1
        '
        Me.dtp_Maturity1.EditValue = Nothing
        Me.dtp_Maturity1.Location = New System.Drawing.Point(702, 50)
        Me.dtp_Maturity1.Name = "dtp_Maturity1"
        Me.dtp_Maturity1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Maturity1.Properties.Appearance.Options.UseFont = True
        Me.dtp_Maturity1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_Maturity1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_Maturity1.Properties.DisplayFormat.FormatString = "MM/dd/ yyyy"
        Me.dtp_Maturity1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_Maturity1.Properties.EditFormat.FormatString = "MM/dd/ yyyy"
        Me.dtp_Maturity1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_Maturity1.Properties.Mask.EditMask = "MM/dd/ yyyy"
        Me.dtp_Maturity1.Properties.ReadOnly = True
        Me.dtp_Maturity1.Size = New System.Drawing.Size(131, 26)
        Me.dtp_Maturity1.TabIndex = 82
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl26.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl26.Appearance.Options.UseFont = True
        Me.LabelControl26.Appearance.Options.UseForeColor = True
        Me.LabelControl26.Location = New System.Drawing.Point(578, 53)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(111, 19)
        Me.LabelControl26.TabIndex = 81
        Me.LabelControl26.Text = "MATURITY DATE"
        '
        'dtp_Date1
        '
        Me.dtp_Date1.EditValue = Nothing
        Me.dtp_Date1.Location = New System.Drawing.Point(702, 11)
        Me.dtp_Date1.Name = "dtp_Date1"
        Me.dtp_Date1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date1.Properties.Appearance.Options.UseFont = True
        Me.dtp_Date1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_Date1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_Date1.Properties.DisplayFormat.FormatString = "MM/dd/ yyyy"
        Me.dtp_Date1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_Date1.Properties.EditFormat.FormatString = "MM/dd/ yyyy"
        Me.dtp_Date1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_Date1.Properties.Mask.EditMask = "MM/dd/ yyyy"
        Me.dtp_Date1.Properties.ReadOnly = True
        Me.dtp_Date1.Size = New System.Drawing.Size(131, 26)
        Me.dtp_Date1.TabIndex = 80
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl27.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl27.Appearance.Options.UseFont = True
        Me.LabelControl27.Appearance.Options.UseForeColor = True
        Me.LabelControl27.Location = New System.Drawing.Point(578, 14)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(101, 19)
        Me.LabelControl27.TabIndex = 79
        Me.LabelControl27.Text = "POSTING DATE"
        '
        'txt_BranchCode1
        '
        Me.txt_BranchCode1.Location = New System.Drawing.Point(503, 128)
        Me.txt_BranchCode1.Name = "txt_BranchCode1"
        Me.txt_BranchCode1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BranchCode1.Properties.Appearance.Options.UseFont = True
        Me.txt_BranchCode1.Properties.ReadOnly = True
        Me.txt_BranchCode1.Size = New System.Drawing.Size(64, 26)
        Me.txt_BranchCode1.TabIndex = 78
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl28.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl28.Appearance.Options.UseFont = True
        Me.LabelControl28.Appearance.Options.UseForeColor = True
        Me.LabelControl28.Location = New System.Drawing.Point(449, 131)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(57, 19)
        Me.LabelControl28.TabIndex = 77
        Me.LabelControl28.Text = "BRANCH"
        '
        'txt_Address1
        '
        Me.txt_Address1.Location = New System.Drawing.Point(210, 50)
        Me.txt_Address1.Name = "txt_Address1"
        Me.txt_Address1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address1.Properties.Appearance.Options.UseFont = True
        Me.txt_Address1.Properties.ReadOnly = True
        Me.txt_Address1.Size = New System.Drawing.Size(357, 26)
        Me.txt_Address1.TabIndex = 76
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl29.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl29.Appearance.Options.UseFont = True
        Me.LabelControl29.Appearance.Options.UseForeColor = True
        Me.LabelControl29.Location = New System.Drawing.Point(141, 53)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl29.TabIndex = 75
        Me.LabelControl29.Text = "ADDRESS"
        '
        'txt_CustName1
        '
        Me.txt_CustName1.Location = New System.Drawing.Point(210, 11)
        Me.txt_CustName1.Name = "txt_CustName1"
        Me.txt_CustName1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CustName1.Properties.Appearance.Options.UseFont = True
        Me.txt_CustName1.Properties.ReadOnly = True
        Me.txt_CustName1.Size = New System.Drawing.Size(357, 26)
        Me.txt_CustName1.TabIndex = 74
        '
        'LabelControl30
        '
        Me.LabelControl30.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl30.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl30.Appearance.Options.UseFont = True
        Me.LabelControl30.Appearance.Options.UseForeColor = True
        Me.LabelControl30.Location = New System.Drawing.Point(161, 14)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl30.TabIndex = 73
        Me.LabelControl30.Text = "NAME"
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl31.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl31.Appearance.Options.UseFont = True
        Me.LabelControl31.Appearance.Options.UseForeColor = True
        Me.LabelControl31.Location = New System.Drawing.Point(37, 143)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(72, 19)
        Me.LabelControl31.TabIndex = 89
        Me.LabelControl31.Text = "CATEGORY"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(14, 11)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(103, 104)
        Me.PictureBox3.TabIndex = 71
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(13, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(105, 108)
        Me.PictureBox4.TabIndex = 72
        Me.PictureBox4.TabStop = False
        '
        'lv_Ledger
        '
        Me.lv_Ledger.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.branchCode1, Me.Credit, Me.Balance, Me.AmountDue, Me.saleStatus, Me.postingDate1})
        Me.lv_Ledger.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_Ledger.ForeColor = System.Drawing.Color.Teal
        Me.lv_Ledger.FullRowSelect = True
        Me.lv_Ledger.GridLines = True
        Me.lv_Ledger.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lv_Ledger.HideSelection = False
        Me.lv_Ledger.Location = New System.Drawing.Point(11, 250)
        Me.lv_Ledger.Margin = New System.Windows.Forms.Padding(4)
        Me.lv_Ledger.Name = "lv_Ledger"
        Me.lv_Ledger.Size = New System.Drawing.Size(823, 143)
        Me.lv_Ledger.TabIndex = 103
        Me.lv_Ledger.UseCompatibleStateImageBehavior = False
        Me.lv_Ledger.View = System.Windows.Forms.View.Details
        '
        'branchCode1
        '
        Me.branchCode1.Text = "BRANCH"
        Me.branchCode1.Width = 150
        '
        'Credit
        '
        Me.Credit.Text = "CREDIT"
        Me.Credit.Width = 200
        '
        'Balance
        '
        Me.Balance.Text = "BALANCE"
        Me.Balance.Width = 200
        '
        'AmountDue
        '
        Me.AmountDue.Text = "AMOUNT DUE"
        Me.AmountDue.Width = 0
        '
        'saleStatus
        '
        Me.saleStatus.Text = "SALES STATUS"
        Me.saleStatus.Width = 200
        '
        'postingDate1
        '
        Me.postingDate1.Text = "POSTING DATE"
        Me.postingDate1.Width = 150
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Save, Me.btn_Print, Me.btn_Error})
        Me.BarManager1.MaxItemId = 3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Print, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Error, True)})
        Me.Bar1.Text = "Tools"
        '
        'btn_Save
        '
        Me.btn_Save.Caption = "Save"
        Me.btn_Save.Id = 0
        Me.btn_Save.ImageOptions.Image = CType(resources.GetObject("btn_Save.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Save.ImageOptions.LargeImage = CType(resources.GetObject("btn_Save.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Save.Name = "btn_Save"
        '
        'btn_Print
        '
        Me.btn_Print.Caption = "Print"
        Me.btn_Print.Id = 1
        Me.btn_Print.ImageOptions.Image = CType(resources.GetObject("btn_Print.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Print.ImageOptions.LargeImage = CType(resources.GetObject("btn_Print.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Print.Name = "btn_Print"
        '
        'btn_Error
        '
        Me.btn_Error.Caption = "Error"
        Me.btn_Error.Id = 2
        Me.btn_Error.ImageOptions.Image = CType(resources.GetObject("btn_Error.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Error.ImageOptions.LargeImage = CType(resources.GetObject("btn_Error.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Error.Name = "btn_Error"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(845, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 543)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(845, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 519)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(845, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 519)
        '
        'SPA_Sales_Inquiry
        '
        Me.Appearance.BackColor = System.Drawing.Color.Teal
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 543)
        Me.Controls.Add(Me.TABPAGE)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(847, 575)
        Me.Name = "SPA_Sales_Inquiry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INQUIRY"
        Me.TABPAGE.ResumeLayout(False)
        Me.tab_Details.ResumeLayout(False)
        Me.tab_Details.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_CRNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CustName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_custCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Balance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Credit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AmountDue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_SI_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TransCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_TransCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Terms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SINo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Maturity.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Maturity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BranchCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_Ledger.ResumeLayout(False)
        Me.tab_Ledger.PerformLayout()
        CType(Me.txt_CRNumber1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Status1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Balance1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Credit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AmountDue1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Note1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_SI_Code1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TransCode1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_TransCategory1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Terms1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SINo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Maturity1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Maturity1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Date1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Date1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BranchCode1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Address1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CustName1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TABPAGE As TabControl
    Friend WithEvents tab_Details As TabPage
    Friend WithEvents txt_Status As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lv_Parts As ListView
    Friend WithEvents BranchCode As ColumnHeader
    Friend WithEvents quantity As ColumnHeader
    Friend WithEvents Unit As ColumnHeader
    Friend WithEvents description As ColumnHeader
    Friend WithEvents unitPrice As ColumnHeader
    Friend WithEvents subTotal As ColumnHeader
    Friend WithEvents prev_ID As ColumnHeader
    Friend WithEvents partsNumber As ColumnHeader
    Friend WithEvents partsName As ColumnHeader
    Friend WithEvents txt_GTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Balance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Credit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_AmountDue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Note As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_SI_Code As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_TransCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_TransCategory As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Terms As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_SINo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtp_Maturity As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtp_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_BranchCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Address As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_CustName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tab_Ledger As TabPage
    Friend WithEvents lv_Ledger As ListView
    Friend WithEvents txt_Status1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Balance1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Credit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_AmountDue1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Note1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_SI_Code1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_TransCode1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_TransCategory1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Terms1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_SINo1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtp_Maturity1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtp_Date1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_BranchCode1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Address1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_CustName1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents branchCode1 As ColumnHeader
    Friend WithEvents Credit As ColumnHeader
    Friend WithEvents Balance As ColumnHeader
    Friend WithEvents AmountDue As ColumnHeader
    Friend WithEvents saleStatus As ColumnHeader
    Friend WithEvents btn_Payment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents lbl_Tamount As Label
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_TotalLess1 As Label
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_totalLess As Label
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_totalVAT As Label
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_AddVAT As Label
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Due As Label
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_PWD As Label
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_NetVat As Label
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_lessVAT As Label
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Total1 As Label
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_VAT2 As Label
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_VAT1 As Label
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents postingDate1 As ColumnHeader
    Friend WithEvents txt_custCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_CRNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_CRNumber1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Change As Label
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Tendered As Label
    Friend WithEvents lbl_Total As Label
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_AmountPaid As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chkNonVAT As RadioButton
    Friend WithEvents chkVAT As RadioButton
    Friend WithEvents grossTotal As ColumnHeader
    Friend WithEvents Discount As ColumnHeader
    Friend WithEvents Discount_PCT As ColumnHeader
    Friend WithEvents discountSRP As ColumnHeader
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Print As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Error As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
