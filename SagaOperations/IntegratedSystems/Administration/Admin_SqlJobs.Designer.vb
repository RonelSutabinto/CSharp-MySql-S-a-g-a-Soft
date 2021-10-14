<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_SqlJobs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_SqlJobs))
        Me.GCSQLJobList = New DevExpress.XtraGrid.GridControl()
        Me.GView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.JobStartPopUp = New DevExpress.XtraBars.BarButtonItem()
        Me.ViewHistJob = New DevExpress.XtraBars.BarButtonItem()
        Me.RightClickPopUp = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.GCSQLJobList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightClickPopUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCSQLJobList
        '
        Me.GCSQLJobList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSQLJobList.Location = New System.Drawing.Point(0, 24)
        Me.GCSQLJobList.MainView = Me.GView
        Me.GCSQLJobList.Name = "GCSQLJobList"
        Me.GCSQLJobList.Size = New System.Drawing.Size(721, 340)
        Me.GCSQLJobList.TabIndex = 0
        Me.GCSQLJobList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GView})
        '
        'GView
        '
        Me.GView.GridControl = Me.GCSQLJobList
        Me.GView.Name = "GView"
        Me.GView.OptionsBehavior.Editable = False
        Me.GView.OptionsView.ColumnAutoWidth = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Btn_Reload, Me.JobStartPopUp, Me.ViewHistJob})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'Btn_Reload
        '
        Me.Btn_Reload.Caption = "Find"
        Me.Btn_Reload.Id = 0
        Me.Btn_Reload.Name = "Btn_Reload"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(721, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 364)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(721, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 340)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(721, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 340)
        '
        'JobStartPopUp
        '
        Me.JobStartPopUp.Caption = "Start Job"
        Me.JobStartPopUp.Id = 1
        Me.JobStartPopUp.ImageOptions.Image = CType(resources.GetObject("JobStartPopUp.ImageOptions.Image"), System.Drawing.Image)
        Me.JobStartPopUp.ImageOptions.LargeImage = CType(resources.GetObject("JobStartPopUp.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.JobStartPopUp.Name = "JobStartPopUp"
        '
        'ViewHistJob
        '
        Me.ViewHistJob.Caption = "View History"
        Me.ViewHistJob.Id = 2
        Me.ViewHistJob.ImageOptions.Image = CType(resources.GetObject("ViewHistJob.ImageOptions.Image"), System.Drawing.Image)
        Me.ViewHistJob.ImageOptions.LargeImage = CType(resources.GetObject("ViewHistJob.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.ViewHistJob.Name = "ViewHistJob"
        '
        'RightClickPopUp
        '
        Me.RightClickPopUp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.JobStartPopUp), New DevExpress.XtraBars.LinkPersistInfo(Me.ViewHistJob)})
        Me.RightClickPopUp.Manager = Me.BarManager1
        Me.RightClickPopUp.Name = "RightClickPopUp"
        '
        'Admin_SqlJobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 364)
        Me.Controls.Add(Me.GCSQLJobList)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "Admin_SqlJobs"
        Me.Text = "Database Jobs Processes"
        CType(Me.GCSQLJobList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightClickPopUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GCSQLJobList As DevExpress.XtraGrid.GridControl
    Friend WithEvents GView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents JobStartPopUp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ViewHistJob As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RightClickPopUp As DevExpress.XtraBars.PopupMenu
End Class
