﻿Namespace Forms.Persons
    Partial Class frm_Account_Executive
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.BarManager = New DevExpress.XtraBars.BarManager()
            Me.Bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.xuc_Account_Executive = New Controls.Persons.xuc_Account_Executive
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
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Save, Me.btn_Save_Close, Me.btn_Close})
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
            Me.btn_Save_Close.Id = 1
            Me.btn_Save_Close.Name = "btn_Save_Close"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 2
            Me.btn_Close.Name = "btn_Close"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(284, 29)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 161)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(284, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 132)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(284, 29)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 132)
            '
            'xuc_Account_Executive
            '
            Me.xuc_Account_Executive.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Account_Executive.Location = New System.Drawing.Point(0, 29)
            Me.xuc_Account_Executive.Name = "xuc_Account_Executive"
            Me.xuc_Account_Executive.Size = New System.Drawing.Size(284, 132)
            Me.xuc_Account_Executive.TabIndex = 1
            '
            'frm_Account_Executive
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 161)
            Me.Controls.Add(Me.xuc_Account_Executive)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)

            Me.Name = "frm_Account_Executive"
            Me.Text = "Account Executive"
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend xuc_Account_Executive As Controls.Persons.xuc_Account_Executive
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    End Class
End Namespace