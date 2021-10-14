<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommandButtons
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CommandButtons))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btn_NewTrans = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Search = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Del = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_ModifyTrans = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SendMail = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_NewTrans, Me.btn_Search, Me.btn_Del, Me.btn_ModifyTrans, Me.btn_Close, Me.btn_SendMail, Me.BarButtonItem1})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 7
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_NewTrans, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Search), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Del), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_ModifyTrans), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SendMail), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(529, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 261)
        Me.barDockControlBottom.Size = New System.Drawing.Size(529, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 237)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(529, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 237)
        '
        'btn_NewTrans
        '
        Me.btn_NewTrans.Glyph = CType(resources.GetObject("btn_NewTrans.Glyph"), System.Drawing.Image)
        Me.btn_NewTrans.Id = 0
        Me.btn_NewTrans.LargeGlyph = CType(resources.GetObject("btn_NewTrans.LargeGlyph"), System.Drawing.Image)
        Me.btn_NewTrans.Name = "btn_NewTrans"
        '
        'btn_Search
        '
        Me.btn_Search.Glyph = CType(resources.GetObject("btn_Search.Glyph"), System.Drawing.Image)
        Me.btn_Search.Id = 1
        Me.btn_Search.LargeGlyph = CType(resources.GetObject("btn_Search.LargeGlyph"), System.Drawing.Image)
        Me.btn_Search.Name = "btn_Search"
        '
        'btn_Del
        '
        Me.btn_Del.Glyph = CType(resources.GetObject("btn_Del.Glyph"), System.Drawing.Image)
        Me.btn_Del.Id = 2
        Me.btn_Del.LargeGlyph = CType(resources.GetObject("btn_Del.LargeGlyph"), System.Drawing.Image)
        Me.btn_Del.Name = "btn_Del"
        '
        'btn_ModifyTrans
        '
        Me.btn_ModifyTrans.Glyph = CType(resources.GetObject("btn_ModifyTrans.Glyph"), System.Drawing.Image)
        Me.btn_ModifyTrans.Id = 3
        Me.btn_ModifyTrans.LargeGlyph = CType(resources.GetObject("btn_ModifyTrans.LargeGlyph"), System.Drawing.Image)
        Me.btn_ModifyTrans.Name = "btn_ModifyTrans"
        '
        'btn_Close
        '
        Me.btn_Close.Glyph = CType(resources.GetObject("btn_Close.Glyph"), System.Drawing.Image)
        Me.btn_Close.Id = 4
        Me.btn_Close.LargeGlyph = CType(resources.GetObject("btn_Close.LargeGlyph"), System.Drawing.Image)
        Me.btn_Close.Name = "btn_Close"
        '
        'btn_SendMail
        '
        Me.btn_SendMail.Glyph = CType(resources.GetObject("btn_SendMail.Glyph"), System.Drawing.Image)
        Me.btn_SendMail.Id = 5
        Me.btn_SendMail.LargeGlyph = CType(resources.GetObject("btn_SendMail.LargeGlyph"), System.Drawing.Image)
        Me.btn_SendMail.Name = "btn_SendMail"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 6
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'CommandButtons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 261)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "CommandButtons"
        Me.Text = "CommandButtons"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_NewTrans As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Search As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Del As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_ModifyTrans As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SendMail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
