Namespace Forms.Petty_Cash
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Expense_Entry
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
            Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Bar_Actions = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Save = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Save_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar_Approval = New DevExpress.XtraBars.Bar()
            Me.btn_Approve = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_DisApprove = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.xuc_Expense = New SagaClassLibrary.Controls.Petty_Cash.xuc_Expense()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Save, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'RepositoryItemLookUpEdit_Branch
            '
            Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
            '
            'RepositoryItemLookUpEdit1
            '
            Me.RepositoryItemLookUpEdit1.AutoHeight = False
            Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
            '
            'BarManager
            '
            Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar_Actions, Me.Bar_Approval})
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Save, Me.btn_Close, Me.btn_Initialize, Me.btn_Approve, Me.btn_DisApprove, Me.btn_Save_Close, Me.btn_Save_New})
            Me.BarManager.MainMenu = Me.Bar_Actions
            Me.BarManager.MaxItemId = 8
            '
            'Bar_Actions
            '
            Me.Bar_Actions.BarName = "Actions"
            Me.Bar_Actions.DockCol = 1
            Me.Bar_Actions.DockRow = 0
            Me.Bar_Actions.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Actions.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.Bar_Actions.Offset = 1
            Me.Bar_Actions.Text = "Main menu"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 3
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
            Me.PopupMenu_Save.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_New), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_Close)})
            Me.PopupMenu_Save.Manager = Me.BarManager
            Me.PopupMenu_Save.Name = "PopupMenu_Save"
            '
            'btn_Save_New
            '
            Me.btn_Save_New.Caption = "Save and New"
            Me.btn_Save_New.Id = 7
            Me.btn_Save_New.Name = "btn_Save_New"
            '
            'btn_Save_Close
            '
            Me.btn_Save_Close.Caption = "Save and Close"
            Me.btn_Save_Close.Id = 6
            Me.btn_Save_Close.Name = "btn_Save_Close"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 2
            Me.btn_Close.Name = "btn_Close"
            '
            'Bar_Approval
            '
            Me.Bar_Approval.BarName = "Approval"
            Me.Bar_Approval.DockCol = 0
            Me.Bar_Approval.DockRow = 0
            Me.Bar_Approval.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Approval.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approve), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_DisApprove)})
            Me.Bar_Approval.Offset = 1
            Me.Bar_Approval.Text = "Approval"
            '
            'btn_Approve
            '
            Me.btn_Approve.Caption = "Approve"
            Me.btn_Approve.Id = 4
            Me.btn_Approve.Name = "btn_Approve"
            '
            'btn_DisApprove
            '
            Me.btn_DisApprove.Caption = "Disapprove"
            Me.btn_DisApprove.Id = 5
            Me.btn_DisApprove.Name = "btn_DisApprove"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.barDockControlTop.Size = New System.Drawing.Size(448, 20)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 468)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.barDockControlBottom.Size = New System.Drawing.Size(448, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 448)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(448, 20)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 448)
            '
            'xuc_Expense
            '
            Me.xuc_Expense.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.xuc_Expense.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.xuc_Expense.Appearance.Options.UseBackColor = True
            Me.xuc_Expense.Appearance.Options.UseFont = True
            Me.xuc_Expense.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Expense.Location = New System.Drawing.Point(0, 20)
            Me.xuc_Expense.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.xuc_Expense.Name = "xuc_Expense"
            Me.xuc_Expense.Size = New System.Drawing.Size(448, 448)
            Me.xuc_Expense.TabIndex = 4
            '
            'frm_Expense_Entry
            '
            Me.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.Appearance.Options.UseBackColor = True
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(448, 468)
            Me.Controls.Add(Me.xuc_Expense)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "frm_Expense_Entry"
            Me.Text = "Petty Cash Expense"
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Save, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents Bar_Actions As DevExpress.XtraBars.Bar
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Public WithEvents xuc_Expense As Controls.Petty_Cash.xuc_Expense
        Friend WithEvents btn_Approve As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_DisApprove As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar_Approval As DevExpress.XtraBars.Bar
        Friend WithEvents PopupMenu_Save As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Save_New As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace