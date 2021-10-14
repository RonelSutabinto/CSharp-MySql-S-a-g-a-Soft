<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Journal_Entry
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
    'It can be Modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_Save = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Save_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Save_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar_Journal = New DevExpress.XtraBars.Bar()
        Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.xuc_Journal_Entry = New SagaClassLibrary.Controls.Accounting.xuc_Journal_Entry()
        Me.PopupMenu_Initialize = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarEditItem_Auto_Initialize = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemcheckEdit_Auto_Initialize = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Initialize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemcheckEdit_Auto_Initialize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar_Journal})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Save, Me.btn_Save_Close, Me.btn_Close, Me.btn_Journal_Entries, Me.btn_Initialize, Me.btn_Save_Journal_Entries, Me.BarEditItem_Auto_Initialize})
        Me.BarManager.MaxItemId = 7
        Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemcheckEdit_Auto_Initialize})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 1
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close)})
        Me.Bar1.Text = "Tools"
        '
        'btn_Initialize
        '
        Me.btn_Initialize.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Initialize.Caption = "Initialize"
        Me.btn_Initialize.DropDownControl = Me.PopupMenu_Initialize
        Me.btn_Initialize.Id = 4
        Me.btn_Initialize.Name = "btn_Initialize"
        '
        'btn_Save
        '
        Me.btn_Save.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Save.Caption = "Save"
        Me.btn_Save.DropDownControl = Me.PopupMenu_Save
        Me.btn_Save.Id = 0
        Me.btn_Save.Name = "btn_Save"
        '
        'PopupMenu_Save
        '
        Me.PopupMenu_Save.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_Close), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_Journal_Entries)})
        Me.PopupMenu_Save.Manager = Me.BarManager
        Me.PopupMenu_Save.Name = "PopupMenu_Save"
        '
        'btn_Save_Close
        '
        Me.btn_Save_Close.Caption = "Save and Close"
        Me.btn_Save_Close.Id = 1
        Me.btn_Save_Close.Name = "btn_Save_Close"
        '
        'btn_Save_Journal_Entries
        '
        Me.btn_Save_Journal_Entries.Caption = "Save and Show Journal Entries"
        Me.btn_Save_Journal_Entries.Id = 5
        Me.btn_Save_Journal_Entries.Name = "btn_Save_Journal_Entries"
        '
        'btn_Close
        '
        Me.btn_Close.Caption = "Close"
        Me.btn_Close.Id = 2
        Me.btn_Close.Name = "btn_Close"
        '
        'Bar_Journal
        '
        Me.Bar_Journal.BarName = "Journal"
        Me.Bar_Journal.DockCol = 0
        Me.Bar_Journal.DockRow = 0
        Me.Bar_Journal.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar_Journal.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries)})
        Me.Bar_Journal.Text = "Journal"
        '
        'btn_Journal_Entries
        '
        Me.btn_Journal_Entries.Caption = "Journal Entries"
        Me.btn_Journal_Entries.Id = 3
        Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(440, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 487)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(440, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 467)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(440, 20)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 467)
        '
        'xuc_Journal_Entry
        '
        Me.xuc_Journal_Entry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xuc_Journal_Entry.Location = New System.Drawing.Point(0, 20)
        Me.xuc_Journal_Entry.Name = "xuc_Journal_Entry"
        Me.xuc_Journal_Entry.Size = New System.Drawing.Size(440, 467)
        Me.xuc_Journal_Entry.TabIndex = 0
        '
        'PopupMenu_Initialize
        '
        Me.PopupMenu_Initialize.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Auto_Initialize)})
        Me.PopupMenu_Initialize.Manager = Me.BarManager
        Me.PopupMenu_Initialize.Name = "PopupMenu_Initialize"
        '
        'BarEditItem_Auto_Initialize
        '
        Me.BarEditItem_Auto_Initialize.Caption = "Auto Initialize"
        Me.BarEditItem_Auto_Initialize.Edit = Me.RepositoryItemcheckEdit_Auto_Initialize
        Me.BarEditItem_Auto_Initialize.Id = 6
        Me.BarEditItem_Auto_Initialize.Name = "BarEditItem_Auto_Initialize"
        '
        'RepositoryItemcheckEdit_Auto_Initialize
        '
        Me.RepositoryItemcheckEdit_Auto_Initialize.AutoHeight = False
        Me.RepositoryItemcheckEdit_Auto_Initialize.Name = "RepositoryItemcheckEdit_Auto_Initialize"
        '
        'frm_Journal_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 487)
        Me.Controls.Add(Me.xuc_Journal_Entry)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(400, 500)
        Me.Name = "frm_Journal_Entry"
        Me.Text = "Journal Entry"
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Initialize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemcheckEdit_Auto_Initialize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents xuc_Journal_Entry As Controls.Accounting.xuc_Journal_Entry
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Save_Close As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar_Journal As DevExpress.XtraBars.Bar
    Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu_Save As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_Save_Journal_Entries As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu_Initialize As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarEditItem_Auto_Initialize As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemcheckEdit_Auto_Initialize As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
