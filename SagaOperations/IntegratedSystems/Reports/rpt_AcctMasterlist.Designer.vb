<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rpt_AcctMasterlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_AcctMasterlist))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_BrCode = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_PostingDate = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_AeCode = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GCAcctList = New DevExpress.XtraGrid.GridControl()
        Me.GViewAcctList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BranchAddress = New System.Windows.Forms.Label()
        Me.BranchName = New System.Windows.Forms.Label()
        Me.CheckedBy = New System.Windows.Forms.Label()
        Me.PreparedBy = New System.Windows.Forms.Label()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCAcctList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GViewAcctList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem2, Me.BarButtonItem3, Me.BarStaticItem1, Me.BarEditItem1, Me.BarStaticItem2, Me.txt_BrCode, Me.BarStaticItem3, Me.txt_PostingDate, Me.BarStaticItem4, Me.txt_AeCode, Me.Btn_Reload, Me.Btn_Preview})
        Me.BarManager1.MaxItemId = 14
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemDateEdit1, Me.RepositoryItemTextEdit4})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 1"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.txt_BrCode, "", False, True, True, 76), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem3), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.txt_PostingDate, "", False, True, True, 113), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem4), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.txt_AeCode, "", False, True, True, 77), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.Caption Or DevExpress.XtraBars.BarLinkUserDefines.PaintStyle), DevExpress.XtraBars.BarLinkUserDefines), Me.Btn_Reload, "FIND", False, False, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.Btn_Preview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Text = "Custom 1"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "BranchCode"
        Me.BarStaticItem2.Id = 6
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'txt_BrCode
        '
        Me.txt_BrCode.Edit = Me.RepositoryItemTextEdit3
        Me.txt_BrCode.Id = 7
        Me.txt_BrCode.Name = "txt_BrCode"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "CutOffDate"
        Me.BarStaticItem3.Id = 8
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'txt_PostingDate
        '
        Me.txt_PostingDate.Edit = Me.RepositoryItemDateEdit1
        Me.txt_PostingDate.Id = 9
        Me.txt_PostingDate.Name = "txt_PostingDate"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'BarStaticItem4
        '
        Me.BarStaticItem4.Caption = "AECode"
        Me.BarStaticItem4.Id = 10
        Me.BarStaticItem4.Name = "BarStaticItem4"
        '
        'txt_AeCode
        '
        Me.txt_AeCode.Caption = " "
        Me.txt_AeCode.Edit = Me.RepositoryItemTextEdit4
        Me.txt_AeCode.EditValue = " "
        Me.txt_AeCode.Id = 11
        Me.txt_AeCode.Name = "txt_AeCode"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'Btn_Reload
        '
        Me.Btn_Reload.Id = 12
        Me.Btn_Reload.Name = "Btn_Reload"
        '
        'Btn_Preview
        '
        Me.Btn_Preview.Caption = "PrintPreview"
        Me.Btn_Preview.Id = 13
        Me.Btn_Preview.Name = "Btn_Preview"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1123, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 394)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1123, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 365)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1123, 29)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 365)
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "BranchCode"
        Me.BarStaticItem1.Id = 3
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemTextEdit2
        Me.BarEditItem1.Id = 5
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GCAcctList
        '
        Me.GCAcctList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCAcctList.Location = New System.Drawing.Point(0, 29)
        Me.GCAcctList.MainView = Me.GViewAcctList
        Me.GCAcctList.MenuManager = Me.BarManager1
        Me.GCAcctList.Name = "GCAcctList"
        Me.GCAcctList.Size = New System.Drawing.Size(1123, 365)
        Me.GCAcctList.TabIndex = 4
        Me.GCAcctList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GViewAcctList})
        '
        'GViewAcctList
        '
        Me.GViewAcctList.DetailHeight = 404
        Me.GViewAcctList.GridControl = Me.GCAcctList
        Me.GViewAcctList.Name = "GViewAcctList"
        Me.GViewAcctList.OptionsView.ColumnAutoWidth = False
        Me.GViewAcctList.OptionsView.ShowFooter = True
        '
        'BranchAddress
        '
        Me.BranchAddress.Location = New System.Drawing.Point(267, 113)
        Me.BranchAddress.Name = "BranchAddress"
        Me.BranchAddress.Size = New System.Drawing.Size(94, 30)
        Me.BranchAddress.TabIndex = 129
        Me.BranchAddress.Text = "BranchAddress"
        '
        'BranchName
        '
        Me.BranchName.Location = New System.Drawing.Point(175, 156)
        Me.BranchName.Name = "BranchName"
        Me.BranchName.Size = New System.Drawing.Size(94, 22)
        Me.BranchName.TabIndex = 132
        Me.BranchName.Text = "BranchName"
        '
        'CheckedBy
        '
        Me.CheckedBy.Location = New System.Drawing.Point(240, 121)
        Me.CheckedBy.Name = "CheckedBy"
        Me.CheckedBy.Size = New System.Drawing.Size(94, 22)
        Me.CheckedBy.TabIndex = 131
        Me.CheckedBy.Text = "CheckedBy"
        '
        'PreparedBy
        '
        Me.PreparedBy.Location = New System.Drawing.Point(150, 121)
        Me.PreparedBy.Name = "PreparedBy"
        Me.PreparedBy.Size = New System.Drawing.Size(94, 22)
        Me.PreparedBy.TabIndex = 130
        Me.PreparedBy.Text = "PreparedBy:"
        '
        'rpt_AcctMasterlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 394)
        Me.Controls.Add(Me.GCAcctList)
        Me.Controls.Add(Me.BranchName)
        Me.Controls.Add(Me.CheckedBy)
        Me.Controls.Add(Me.PreparedBy)
        Me.Controls.Add(Me.BranchAddress)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("rpt_AcctMasterlist.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "rpt_AcctMasterlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACCOUNT MASTERLIST"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCAcctList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GViewAcctList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GCAcctList As DevExpress.XtraGrid.GridControl
    Friend WithEvents GViewAcctList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_BrCode As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_PostingDate As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_AeCode As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BranchAddress As Label
    Friend WithEvents BranchName As Label
    Friend WithEvents CheckedBy As Label
    Friend WithEvents PreparedBy As Label
End Class
