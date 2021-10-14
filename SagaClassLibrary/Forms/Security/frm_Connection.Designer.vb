Namespace Forms.Security
    Partial Class frm_Connection
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Connection))
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Test = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Connect_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.xuc_SQL_Connection = New MyClassLibrary.Controls.Security.xuc_SQL_Connection()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'BarManager
            '
            Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Test, Me.btn_Connect_Close, Me.btn_Close})
            Me.BarManager.MaxItemId = 3
            '
            'Bar1
            '
            Me.Bar1.BarName = "Tools"
            Me.Bar1.DockCol = 0
            Me.Bar1.DockRow = 0
            Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Test), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Connect_Close), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close)})
            Me.Bar1.Text = "Tools"
            '
            'btn_Test
            '
            Me.btn_Test.Caption = "&Test"
            Me.btn_Test.Id = 0
            Me.btn_Test.ImageOptions.Image = CType(resources.GetObject("btn_Test.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Test.ImageOptions.LargeImage = CType(resources.GetObject("btn_Test.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Test.Name = "btn_Test"
            '
            'btn_Connect_Close
            '
            Me.btn_Connect_Close.Caption = "Co&nnect and Close"
            Me.btn_Connect_Close.Id = 1
            Me.btn_Connect_Close.ImageOptions.Image = CType(resources.GetObject("btn_Connect_Close.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Connect_Close.ImageOptions.LargeImage = CType(resources.GetObject("btn_Connect_Close.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Connect_Close.Name = "btn_Connect_Close"
            '
            'btn_Close
            '
            Me.btn_Close.Id = 2
            Me.btn_Close.ImageOptions.Image = CType(resources.GetObject("btn_Close.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Close.ImageOptions.LargeImage = CType(resources.GetObject("btn_Close.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Close.Name = "btn_Close"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(348, 24)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 468)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(348, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 444)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(348, 24)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 444)
            '
            'xuc_SQL_Connection
            '
            Me.xuc_SQL_Connection.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_SQL_Connection.Location = New System.Drawing.Point(0, 24)
            Me.xuc_SQL_Connection.Name = "xuc_SQL_Connection"
            Me.xuc_SQL_Connection.Size = New System.Drawing.Size(348, 444)
            Me.xuc_SQL_Connection.TabIndex = 4
            '
            'frm_Connection
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(348, 468)
            Me.Controls.Add(Me.xuc_SQL_Connection)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.IconOptions.ShowIcon = False
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frm_Connection"
            Me.Text = "SQL Connection"
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Public WithEvents xuc_SQL_Connection As MyClassLibrary.Controls.Security.xuc_SQL_Connection
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Test As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Connect_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    End Class
End Namespace
