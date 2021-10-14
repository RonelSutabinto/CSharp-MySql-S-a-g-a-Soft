Namespace Forms.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Budget
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
            Me.xuc_Budget = New SagaClassLibrary.Controls.Accounting.xuc_Budget()
            Me.ToolbarFormManager = New DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
            Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
            Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
            Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
            CType(Me.ToolbarFormManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xuc_Budget
            '
            Me.xuc_Budget.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Budget.Location = New System.Drawing.Point(0, 20)
            Me.xuc_Budget.Name = "xuc_Budget"
            Me.xuc_Budget.Size = New System.Drawing.Size(276, 320)
            Me.xuc_Budget.TabIndex = 0
            '
            'ToolbarFormManager
            '
            Me.ToolbarFormManager.DockControls.Add(Me.barDockControlTop)
            Me.ToolbarFormManager.DockControls.Add(Me.barDockControlBottom)
            Me.ToolbarFormManager.DockControls.Add(Me.barDockControlLeft)
            Me.ToolbarFormManager.DockControls.Add(Me.barDockControlRight)
            Me.ToolbarFormManager.Form = Me
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 20)
            Me.barDockControlTop.Manager = Me.ToolbarFormManager
            Me.barDockControlTop.Size = New System.Drawing.Size(276, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 340)
            Me.barDockControlBottom.Manager = Me.ToolbarFormManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(276, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
            Me.barDockControlLeft.Manager = Me.ToolbarFormManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 320)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(276, 20)
            Me.barDockControlRight.Manager = Me.ToolbarFormManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 320)
            '
            'BarManager
            '
            Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
            Me.BarManager.DockControls.Add(Me.BarDockControl1)
            Me.BarManager.DockControls.Add(Me.BarDockControl2)
            Me.BarManager.DockControls.Add(Me.BarDockControl3)
            Me.BarManager.DockControls.Add(Me.BarDockControl4)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Save, Me.btn_Close, Me.btn_Save_Close})
            Me.BarManager.MaxItemId = 3
            '
            'Bar1
            '
            Me.Bar1.BarName = "Tools"
            Me.Bar1.DockCol = 0
            Me.Bar1.DockRow = 0
            Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_Close), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close)})
            Me.Bar1.Text = "Tools"
            '
            'btn_Save
            '
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.Id = 0
            Me.btn_Save.Name = "btn_Save"
            '
            'btn_Save_Close
            '
            Me.btn_Save_Close.Caption = "Save and Close"
            Me.btn_Save_Close.Id = 2
            Me.btn_Save_Close.Name = "btn_Save_Close"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 1
            Me.btn_Close.Name = "btn_Close"
            '
            'BarDockControl1
            '
            Me.BarDockControl1.CausesValidation = False
            Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
            Me.BarDockControl1.Manager = Me.BarManager
            Me.BarDockControl1.Size = New System.Drawing.Size(276, 20)
            '
            'BarDockControl2
            '
            Me.BarDockControl2.CausesValidation = False
            Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.BarDockControl2.Location = New System.Drawing.Point(0, 340)
            Me.BarDockControl2.Manager = Me.BarManager
            Me.BarDockControl2.Size = New System.Drawing.Size(276, 0)
            '
            'BarDockControl3
            '
            Me.BarDockControl3.CausesValidation = False
            Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
            Me.BarDockControl3.Location = New System.Drawing.Point(0, 20)
            Me.BarDockControl3.Manager = Me.BarManager
            Me.BarDockControl3.Size = New System.Drawing.Size(0, 320)
            '
            'BarDockControl4
            '
            Me.BarDockControl4.CausesValidation = False
            Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
            Me.BarDockControl4.Location = New System.Drawing.Point(276, 20)
            Me.BarDockControl4.Manager = Me.BarManager
            Me.BarDockControl4.Size = New System.Drawing.Size(0, 320)
            '
            'frm_Budget
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(276, 340)
            Me.Controls.Add(Me.xuc_Budget)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Controls.Add(Me.BarDockControl3)
            Me.Controls.Add(Me.BarDockControl4)
            Me.Controls.Add(Me.BarDockControl2)
            Me.Controls.Add(Me.BarDockControl1)
            Me.Name = "frm_Budget"
            Me.Text = "Budget"
            CType(Me.ToolbarFormManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents xuc_Budget As Controls.Accounting.xuc_Budget
        Friend WithEvents ToolbarFormManager As DevExpress.XtraBars.ToolbarForm.ToolbarFormManager
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
        Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
        Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    End Class
End Namespace