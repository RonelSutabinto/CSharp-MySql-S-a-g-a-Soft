Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class XtraForm1
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraForm1))
            Me.ImageCollection16 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.AlertControl = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.ToastNotificationsManager = New DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(Me.components)
            CType(Me.ImageCollection16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ToastNotificationsManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ImageCollection16
            '
            Me.ImageCollection16.ImageStream = CType(resources.GetObject("ImageCollection16.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            Me.ImageCollection16.Images.SetKeyName(0, "managedatasource_16x16.png")
            Me.ImageCollection16.Images.SetKeyName(1, "info_16x16.png")
            Me.ImageCollection16.Images.SetKeyName(2, "warning_16x16.png")
            Me.ImageCollection16.Images.SetKeyName(3, "cancel_16x16.png")
            Me.ImageCollection16.Images.SetKeyName(4, "add_16x16.png")
            Me.ImageCollection16.Images.SetKeyName(5, "apply_16x16.png")
            Me.ImageCollection16.Images.SetKeyName(6, "remove_16x16.png")
            '
            'AlertControl
            '
            Me.AlertControl.AllowHotTrack = False
            Me.AlertControl.AutoHeight = True
            Me.AlertControl.Images = Me.ImageCollection16
            Me.AlertControl.PopupMenu = Me.PopupMenu
            '
            'PopupMenu
            '
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'BarManager
            '
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(290, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 268)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(290, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 268)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(290, 0)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 268)
            '
            'ToastNotificationsManager
            '
            Me.ToastNotificationsManager.ApplicationId = "53af1649-0266-4746-9ade-de5681f823dc"
            Me.ToastNotificationsManager.ApplicationName = "SagaAccounting"
            Me.ToastNotificationsManager.Notifications.AddRange(New DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties() {New DevExpress.XtraBars.ToastNotifications.ToastNotification("7cb9ef5b-6ed8-4a1f-8f07-b1f6d3c94ca8", Nothing, "Header", "Body", "Body2", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text02)})
            '
            'XtraForm1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(290, 268)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "XtraForm1"
            Me.Text = "XtraForm1"
            Me.TopMost = True
            CType(Me.ImageCollection16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ToastNotificationsManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Public WithEvents AlertControl As DevExpress.XtraBars.Alerter.AlertControl
        Public WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Public WithEvents ToastNotificationsManager As DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager
        Public WithEvents ImageCollection16 As DevExpress.Utils.ImageCollection
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    End Class
End Namespace