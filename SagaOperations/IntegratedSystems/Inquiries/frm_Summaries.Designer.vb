<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Summaries
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Summaries))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Btn_Refresh = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.mcForDep = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_DepAcct = New DevExpress.XtraEditors.LabelControl()
        Me.txt_TotOvCurAcct = New DevExpress.XtraEditors.LabelControl()
        Me.txt_MCOverdueAcct = New DevExpress.XtraEditors.LabelControl()
        Me.dInstallment = New DevExpress.XtraEditors.LabelControl()
        Me.dCollection_Efficiency = New DevExpress.XtraEditors.LabelControl()
        Me.dCash = New DevExpress.XtraEditors.LabelControl()
        Me.mSummary = New DevExpress.XtraEditors.LabelControl()
        Me.txt_CurMCAcct = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_SPA_CustDepDueLabel = New DevExpress.XtraEditors.LabelControl()
        Me.txt_REPHOLabel = New DevExpress.XtraEditors.LabelControl()
        Me.txt_DEPRepLabel = New DevExpress.XtraEditors.LabelControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Btn_Refresh})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 1
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.Btn_Refresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'Btn_Refresh
        '
        Me.Btn_Refresh.Caption = "Refresh"
        Me.Btn_Refresh.Id = 0
        Me.Btn_Refresh.ImageOptions.Image = CType(resources.GetObject("Btn_Refresh.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Refresh.ImageOptions.LargeImage = CType(resources.GetObject("Btn_Refresh.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Btn_Refresh.Name = "Btn_Refresh"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(976, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 318)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(976, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 294)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(976, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 294)
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Teal
        Me.Label15.Location = New System.Drawing.Point(4, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(223, 29)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "MOTORCYCLE"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Teal
        Me.Label16.Location = New System.Drawing.Point(662, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(204, 29)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "SPARE PARTS"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.GroupControl1.Controls.Add(Me.mcForDep)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txt_DepAcct)
        Me.GroupControl1.Controls.Add(Me.txt_TotOvCurAcct)
        Me.GroupControl1.Controls.Add(Me.txt_MCOverdueAcct)
        Me.GroupControl1.Controls.Add(Me.dInstallment)
        Me.GroupControl1.Controls.Add(Me.dCollection_Efficiency)
        Me.GroupControl1.Controls.Add(Me.dCash)
        Me.GroupControl1.Controls.Add(Me.mSummary)
        Me.GroupControl1.Controls.Add(Me.txt_CurMCAcct)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.LabelControl16)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_SPA_CustDepDueLabel)
        Me.GroupControl1.Controls.Add(Me.txt_REPHOLabel)
        Me.GroupControl1.Controls.Add(Me.txt_DEPRepLabel)
        Me.GroupControl1.Controls.Add(Me.Label16)
        Me.GroupControl1.Controls.Add(Me.Label15)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 24)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(976, 294)
        Me.GroupControl1.TabIndex = 36
        Me.GroupControl1.Text = "LayoutControlGroup1"
        '
        'mcForDep
        '
        Me.mcForDep.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcForDep.Appearance.Options.UseFont = True
        Me.mcForDep.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.mcForDep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcForDep.Location = New System.Drawing.Point(15, 187)
        Me.mcForDep.Name = "mcForDep"
        Me.mcForDep.Size = New System.Drawing.Size(177, 23)
        Me.mcForDep.TabIndex = 47
        Me.mcForDep.Text = "missedAmort>2"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Orange
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(14, 42)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(111, 19)
        Me.LabelControl7.TabIndex = 46
        Me.LabelControl7.Text = "ACCOUNTS"
        '
        'txt_DepAcct
        '
        Me.txt_DepAcct.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DepAcct.Appearance.Options.UseFont = True
        Me.txt_DepAcct.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_DepAcct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_DepAcct.Location = New System.Drawing.Point(188, 140)
        Me.txt_DepAcct.Name = "txt_DepAcct"
        Me.txt_DepAcct.Size = New System.Drawing.Size(87, 19)
        Me.txt_DepAcct.TabIndex = 45
        Me.txt_DepAcct.Text = "0"
        '
        'txt_TotOvCurAcct
        '
        Me.txt_TotOvCurAcct.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotOvCurAcct.Appearance.Options.UseFont = True
        Me.txt_TotOvCurAcct.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_TotOvCurAcct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_TotOvCurAcct.Location = New System.Drawing.Point(188, 115)
        Me.txt_TotOvCurAcct.Name = "txt_TotOvCurAcct"
        Me.txt_TotOvCurAcct.Size = New System.Drawing.Size(87, 19)
        Me.txt_TotOvCurAcct.TabIndex = 44
        Me.txt_TotOvCurAcct.Text = "0"
        '
        'txt_MCOverdueAcct
        '
        Me.txt_MCOverdueAcct.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MCOverdueAcct.Appearance.Options.UseFont = True
        Me.txt_MCOverdueAcct.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_MCOverdueAcct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_MCOverdueAcct.Location = New System.Drawing.Point(188, 91)
        Me.txt_MCOverdueAcct.Name = "txt_MCOverdueAcct"
        Me.txt_MCOverdueAcct.Size = New System.Drawing.Size(87, 19)
        Me.txt_MCOverdueAcct.TabIndex = 43
        Me.txt_MCOverdueAcct.Text = "0"
        '
        'dInstallment
        '
        Me.dInstallment.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dInstallment.Appearance.Options.UseFont = True
        Me.dInstallment.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.dInstallment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dInstallment.Location = New System.Drawing.Point(499, 141)
        Me.dInstallment.Name = "dInstallment"
        Me.dInstallment.Size = New System.Drawing.Size(162, 19)
        Me.dInstallment.TabIndex = 42
        Me.dInstallment.Text = "0"
        '
        'dCollection_Efficiency
        '
        Me.dCollection_Efficiency.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dCollection_Efficiency.Appearance.Options.UseFont = True
        Me.dCollection_Efficiency.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.dCollection_Efficiency.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dCollection_Efficiency.Location = New System.Drawing.Point(499, 213)
        Me.dCollection_Efficiency.Name = "dCollection_Efficiency"
        Me.dCollection_Efficiency.Size = New System.Drawing.Size(162, 19)
        Me.dCollection_Efficiency.TabIndex = 42
        Me.dCollection_Efficiency.Text = "0"
        '
        'dCash
        '
        Me.dCash.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dCash.Appearance.Options.UseFont = True
        Me.dCash.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.dCash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dCash.Location = New System.Drawing.Point(499, 116)
        Me.dCash.Name = "dCash"
        Me.dCash.Size = New System.Drawing.Size(162, 19)
        Me.dCash.TabIndex = 42
        Me.dCash.Text = "0"
        '
        'mSummary
        '
        Me.mSummary.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mSummary.Appearance.Options.UseFont = True
        Me.mSummary.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.mSummary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mSummary.Location = New System.Drawing.Point(499, 66)
        Me.mSummary.Name = "mSummary"
        Me.mSummary.Size = New System.Drawing.Size(162, 19)
        Me.mSummary.TabIndex = 42
        Me.mSummary.Text = "0"
        '
        'txt_CurMCAcct
        '
        Me.txt_CurMCAcct.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CurMCAcct.Appearance.Options.UseFont = True
        Me.txt_CurMCAcct.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_CurMCAcct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_CurMCAcct.Location = New System.Drawing.Point(188, 67)
        Me.txt_CurMCAcct.Name = "txt_CurMCAcct"
        Me.txt_CurMCAcct.Size = New System.Drawing.Size(87, 19)
        Me.txt_CurMCAcct.TabIndex = 42
        Me.txt_CurMCAcct.Text = "0"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl5.Location = New System.Drawing.Point(17, 140)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(136, 19)
        Me.LabelControl5.TabIndex = 41
        Me.LabelControl5.Text = "Deposited:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl6.Location = New System.Drawing.Point(17, 115)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(153, 19)
        Me.LabelControl6.TabIndex = 40
        Me.LabelControl6.Text = "Total Active Account:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl4.Location = New System.Drawing.Point(17, 91)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(136, 19)
        Me.LabelControl4.TabIndex = 39
        Me.LabelControl4.Text = "Overdue:"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl13.Location = New System.Drawing.Point(314, 140)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(104, 19)
        Me.LabelControl13.TabIndex = 38
        Me.LabelControl13.Text = "INSTALLMENT:"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl16.Location = New System.Drawing.Point(314, 213)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(179, 19)
        Me.LabelControl16.TabIndex = 38
        Me.LabelControl16.Text = "P50,000.00/P250,000.00"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl12.Location = New System.Drawing.Point(314, 115)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(89, 19)
        Me.LabelControl12.TabIndex = 38
        Me.LabelControl12.Text = "CASH:"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl15.Location = New System.Drawing.Point(281, 189)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(169, 19)
        Me.LabelControl15.TabIndex = 38
        Me.LabelControl15.Text = "COLLECTION EFFICIENCY:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl10.Location = New System.Drawing.Point(281, 91)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(169, 19)
        Me.LabelControl10.TabIndex = 38
        Me.LabelControl10.Text = "SALES:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl8.Location = New System.Drawing.Point(281, 67)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(190, 19)
        Me.LabelControl8.TabIndex = 38
        Me.LabelControl8.Text = "MONTHLY SUMMARY:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl2.Location = New System.Drawing.Point(17, 67)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(136, 19)
        Me.LabelControl2.TabIndex = 38
        Me.LabelControl2.Text = "Current:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Orange
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(679, 42)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(111, 19)
        Me.LabelControl3.TabIndex = 37
        Me.LabelControl3.Text = "ACCOUNTS"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Orange
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(15, 165)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(142, 19)
        Me.LabelControl1.TabIndex = 34
        Me.LabelControl1.Text = "INVENTORY"
        '
        'txt_SPA_CustDepDueLabel
        '
        Me.txt_SPA_CustDepDueLabel.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SPA_CustDepDueLabel.Appearance.Options.UseFont = True
        Me.txt_SPA_CustDepDueLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_SPA_CustDepDueLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_SPA_CustDepDueLabel.Location = New System.Drawing.Point(693, 64)
        Me.txt_SPA_CustDepDueLabel.Name = "txt_SPA_CustDepDueLabel"
        Me.txt_SPA_CustDepDueLabel.Size = New System.Drawing.Size(281, 19)
        Me.txt_SPA_CustDepDueLabel.TabIndex = 33
        Me.txt_SPA_CustDepDueLabel.Text = "mmhhaa"
        '
        'txt_REPHOLabel
        '
        Me.txt_REPHOLabel.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_REPHOLabel.Appearance.Options.UseFont = True
        Me.txt_REPHOLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_REPHOLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_REPHOLabel.Location = New System.Drawing.Point(15, 228)
        Me.txt_REPHOLabel.Name = "txt_REPHOLabel"
        Me.txt_REPHOLabel.Size = New System.Drawing.Size(177, 23)
        Me.txt_REPHOLabel.TabIndex = 32
        Me.txt_REPHOLabel.Text = "rep60"
        '
        'txt_DEPRepLabel
        '
        Me.txt_DEPRepLabel.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DEPRepLabel.Appearance.Options.UseFont = True
        Me.txt_DEPRepLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_DEPRepLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_DEPRepLabel.Location = New System.Drawing.Point(15, 207)
        Me.txt_DEPRepLabel.Name = "txt_DEPRepLabel"
        Me.txt_DEPRepLabel.Size = New System.Drawing.Size(177, 23)
        Me.txt_DEPRepLabel.TabIndex = 31
        Me.txt_DEPRepLabel.Text = "dep45"
        '
        'frm_Summaries
        '
        Me.Appearance.BackColor = System.Drawing.Color.Orange
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 318)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1021, 350)
        Me.Name = "frm_Summaries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACCOUNT SUMMARIES"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Btn_Refresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_DEPRepLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_SPA_CustDepDueLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_REPHOLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_DepAcct As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_TotOvCurAcct As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_MCOverdueAcct As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_CurMCAcct As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mcForDep As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dInstallment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dCollection_Efficiency As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dCash As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mSummary As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
End Class
