<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bar_Master_List = New DevExpress.XtraBars.BarButtonItem()
        Me.bar_Master_List_SPA = New DevExpress.XtraBars.BarButtonItem()
        Me.MCDepUnits = New DevExpress.XtraBars.BarButtonItem()
        Me.BarReprice = New DevExpress.XtraBars.BarButtonItem()
        Me.BarRepPriceList = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar_iRepUnits = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar_iREPforREPRICE = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem_Username = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem_Position = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem_Server_IP = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem_Local_IP = New DevExpress.XtraBars.BarStaticItem()
        Me.BarEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BarButtonItem_REPtoiREP = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Orange
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.RibbonControl.SearchEditItem, Me.bar_Master_List, Me.bar_Master_List_SPA, Me.MCDepUnits, Me.BarReprice, Me.BarRepPriceList, Me.Bar_iRepUnits, Me.Bar_iREPforREPRICE, Me.BarStaticItem_Username, Me.BarStaticItem_Position, Me.BarStaticItem_Server_IP, Me.BarStaticItem_Local_IP, Me.BarEditItem_Branch, Me.BarButtonItem_REPtoiREP})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 14
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage3, Me.RibbonPage1, Me.RibbonPage2})
        Me.RibbonControl.QuickToolbarItemLinks.Add(Me.BarEditItem_Branch)
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Branch})
        Me.RibbonControl.Size = New System.Drawing.Size(850, 158)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'bar_Master_List
        '
        Me.bar_Master_List.Caption = "MASTER LIST"
        Me.bar_Master_List.Id = 1
        Me.bar_Master_List.ImageOptions.Image = CType(resources.GetObject("bar_Master_List.ImageOptions.Image"), System.Drawing.Image)
        Me.bar_Master_List.ImageOptions.LargeImage = CType(resources.GetObject("bar_Master_List.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bar_Master_List.Name = "bar_Master_List"
        '
        'bar_Master_List_SPA
        '
        Me.bar_Master_List_SPA.Caption = "MASTER LIST"
        Me.bar_Master_List_SPA.Id = 2
        Me.bar_Master_List_SPA.ImageOptions.Image = CType(resources.GetObject("bar_Master_List_SPA.ImageOptions.Image"), System.Drawing.Image)
        Me.bar_Master_List_SPA.ImageOptions.LargeImage = CType(resources.GetObject("bar_Master_List_SPA.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bar_Master_List_SPA.Name = "bar_Master_List_SPA"
        '
        'MCDepUnits
        '
        Me.MCDepUnits.Caption = "MC DEP UNITS"
        Me.MCDepUnits.Id = 3
        Me.MCDepUnits.ImageOptions.Image = CType(resources.GetObject("MCDepUnits.ImageOptions.Image"), System.Drawing.Image)
        Me.MCDepUnits.ImageOptions.LargeImage = CType(resources.GetObject("MCDepUnits.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.MCDepUnits.Name = "MCDepUnits"
        '
        'BarReprice
        '
        Me.BarReprice.Caption = "DEPO for REPRICE"
        Me.BarReprice.Id = 4
        Me.BarReprice.ImageOptions.Image = CType(resources.GetObject("BarReprice.ImageOptions.Image"), System.Drawing.Image)
        Me.BarReprice.ImageOptions.LargeImage = CType(resources.GetObject("BarReprice.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarReprice.Name = "BarReprice"
        '
        'BarRepPriceList
        '
        Me.BarRepPriceList.Caption = "REPO PriceList"
        Me.BarRepPriceList.Id = 5
        Me.BarRepPriceList.ImageOptions.Image = CType(resources.GetObject("BarRepPriceList.ImageOptions.Image"), System.Drawing.Image)
        Me.BarRepPriceList.ImageOptions.LargeImage = CType(resources.GetObject("BarRepPriceList.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarRepPriceList.Name = "BarRepPriceList"
        '
        'Bar_iRepUnits
        '
        Me.Bar_iRepUnits.Caption = "iREP UNITS"
        Me.Bar_iRepUnits.Id = 6
        Me.Bar_iRepUnits.ImageOptions.Image = CType(resources.GetObject("Bar_iRepUnits.ImageOptions.Image"), System.Drawing.Image)
        Me.Bar_iRepUnits.ImageOptions.LargeImage = CType(resources.GetObject("Bar_iRepUnits.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Bar_iRepUnits.Name = "Bar_iRepUnits"
        '
        'Bar_iREPforREPRICE
        '
        Me.Bar_iREPforREPRICE.Caption = "iREP for REPRICE"
        Me.Bar_iREPforREPRICE.Id = 7
        Me.Bar_iREPforREPRICE.ImageOptions.Image = CType(resources.GetObject("Bar_iREPforREPRICE.ImageOptions.Image"), System.Drawing.Image)
        Me.Bar_iREPforREPRICE.ImageOptions.LargeImage = CType(resources.GetObject("Bar_iREPforREPRICE.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Bar_iREPforREPRICE.Name = "Bar_iREPforREPRICE"
        '
        'BarStaticItem_Username
        '
        Me.BarStaticItem_Username.Caption = "Username"
        Me.BarStaticItem_Username.Id = 8
        Me.BarStaticItem_Username.Name = "BarStaticItem_Username"
        '
        'BarStaticItem_Position
        '
        Me.BarStaticItem_Position.Caption = "Position"
        Me.BarStaticItem_Position.Id = 9
        Me.BarStaticItem_Position.Name = "BarStaticItem_Position"
        '
        'BarStaticItem_Server_IP
        '
        Me.BarStaticItem_Server_IP.Caption = "Server IP"
        Me.BarStaticItem_Server_IP.Id = 10
        Me.BarStaticItem_Server_IP.Name = "BarStaticItem_Server_IP"
        '
        'BarStaticItem_Local_IP
        '
        Me.BarStaticItem_Local_IP.Caption = "Local IP"
        Me.BarStaticItem_Local_IP.Id = 11
        Me.BarStaticItem_Local_IP.Name = "BarStaticItem_Local_IP"
        '
        'BarEditItem_Branch
        '
        Me.BarEditItem_Branch.Caption = "Branch"
        Me.BarEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit_Branch
        Me.BarEditItem_Branch.Id = 12
        Me.BarEditItem_Branch.ImageOptions.Image = CType(resources.GetObject("BarEditItem_Branch.ImageOptions.Image"), System.Drawing.Image)
        Me.BarEditItem_Branch.ImageOptions.LargeImage = CType(resources.GetObject("BarEditItem_Branch.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarEditItem_Branch.Name = "BarEditItem_Branch"
        '
        'RepositoryItemLookUpEdit_Branch
        '
        Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
        '
        'BarButtonItem_REPtoiREP
        '
        Me.BarButtonItem_REPtoiREP.Caption = "REPO to INACTIVE REPO"
        Me.BarButtonItem_REPtoiREP.Id = 13
        Me.BarButtonItem_REPtoiREP.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem_REPtoiREP.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem_REPtoiREP.Name = "BarButtonItem_REPtoiREP"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.RibbonPageGroup4, Me.RibbonPageGroup5})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Motorcylce"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.MCDepUnits)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarReprice)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarRepPriceList)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.Bar_iRepUnits)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.Bar_iREPforREPRICE)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "iREP To REP"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem_REPtoiREP)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "REPO to iREPO"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "INVENTORY"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bar_Master_List)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Spare Parts"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bar_Master_List_SPA)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Transactions"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem_Username)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem_Position)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem_Server_IP)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem_Local_IP)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 425)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(850, 24)
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 449)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.Name = "MainMenu"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "MainMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents bar_Master_List As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents bar_Master_List_SPA As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents MCDepUnits As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarReprice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarRepPriceList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Bar_iRepUnits As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar_iREPforREPRICE As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarStaticItem_Username As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem_Position As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem_Server_IP As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem_Local_IP As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarEditItem_Branch As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarButtonItem_REPtoiREP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
