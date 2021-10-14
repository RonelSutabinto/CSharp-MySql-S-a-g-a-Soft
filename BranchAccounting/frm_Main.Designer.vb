Partial Public Class frm_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarHeaderItem_User = New DevExpress.XtraBars.BarHeaderItem()
        Me.btn_Collection = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Cashiering = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_MC_Sales = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SPA_Sales = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage_Accounting = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup_Collections = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.XtraTabbedMdiManager = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem_Connection = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RibbonPageGroup_Parameters = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarEditItem_Date_Start = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit_Date_Start = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarEditItem_Date_End = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit_Date_End = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.btn_Date = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Today = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Month = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Credit_Memo = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit_Date_Start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit_Date_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit_Date_End, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit_Date_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.CaptionBarItemLinks.Add(Me.BarHeaderItem_User)
        Me.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Purple
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarHeaderItem_User, Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.btn_Collection, Me.btn_Cashiering, Me.BarEditItem_Branch, Me.btn_Journal_Entries, Me.btn_MC_Sales, Me.btn_SPA_Sales, Me.BarEditItem_Date_Start, Me.BarEditItem_Date_End, Me.btn_Date, Me.btn_Today, Me.btn_Month, Me.btn_Credit_Memo})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 16
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage_Accounting})
        Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Branch, Me.RepositoryItemDateEdit_Date_Start, Me.RepositoryItemDateEdit_Date_End})
        Me.ribbonControl1.Size = New System.Drawing.Size(894, 158)
        '
        'BarHeaderItem_User
        '
        Me.BarHeaderItem_User.Caption = "User Name"
        Me.BarHeaderItem_User.Id = 8
        Me.BarHeaderItem_User.Name = "BarHeaderItem_User"
        '
        'btn_Collection
        '
        Me.btn_Collection.Caption = "Collection"
        Me.btn_Collection.Id = 1
        Me.btn_Collection.ImageOptions.Image = CType(resources.GetObject("btn_Collection.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Collection.ImageOptions.LargeImage = CType(resources.GetObject("btn_Collection.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Collection.Name = "btn_Collection"
        '
        'btn_Cashiering
        '
        Me.btn_Cashiering.Caption = "Cashiering"
        Me.btn_Cashiering.Id = 2
        Me.btn_Cashiering.ImageOptions.Image = CType(resources.GetObject("btn_Cashiering.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Cashiering.ImageOptions.LargeImage = CType(resources.GetObject("btn_Cashiering.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Cashiering.Name = "btn_Cashiering"
        '
        'BarEditItem_Branch
        '
        Me.BarEditItem_Branch.Caption = "Branch     "
        Me.BarEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit_Branch
        Me.BarEditItem_Branch.EditWidth = 150
        Me.BarEditItem_Branch.Id = 3
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
        'btn_Journal_Entries
        '
        Me.btn_Journal_Entries.Caption = "Journal Entries"
        Me.btn_Journal_Entries.Id = 4
        Me.btn_Journal_Entries.ImageOptions.Image = CType(resources.GetObject("btn_Journal_Entries.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Journal_Entries.ImageOptions.LargeImage = CType(resources.GetObject("btn_Journal_Entries.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
        '
        'btn_MC_Sales
        '
        Me.btn_MC_Sales.Caption = "Sales"
        Me.btn_MC_Sales.Id = 5
        Me.btn_MC_Sales.ImageOptions.Image = CType(resources.GetObject("btn_MC_Sales.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_MC_Sales.ImageOptions.LargeImage = CType(resources.GetObject("btn_MC_Sales.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_MC_Sales.Name = "btn_MC_Sales"
        '
        'btn_SPA_Sales
        '
        Me.btn_SPA_Sales.Caption = "Spare Parts"
        Me.btn_SPA_Sales.Id = 9
        Me.btn_SPA_Sales.ImageOptions.Image = CType(resources.GetObject("btn_SPA_Sales.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_SPA_Sales.ImageOptions.LargeImage = CType(resources.GetObject("btn_SPA_Sales.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_SPA_Sales.Name = "btn_SPA_Sales"
        '
        'ribbonPage_Accounting
        '
        Me.ribbonPage_Accounting.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup_Parameters, Me.ribbonPageGroup_Collections})
        Me.ribbonPage_Accounting.Name = "ribbonPage_Accounting"
        Me.ribbonPage_Accounting.Text = "Accounting"
        '
        'ribbonPageGroup_Collections
        '
        Me.ribbonPageGroup_Collections.ItemLinks.Add(Me.btn_MC_Sales)
        Me.ribbonPageGroup_Collections.ItemLinks.Add(Me.btn_Collection)
        Me.ribbonPageGroup_Collections.ItemLinks.Add(Me.btn_Cashiering)
        Me.ribbonPageGroup_Collections.ItemLinks.Add(Me.btn_Credit_Memo)
        Me.ribbonPageGroup_Collections.ItemLinks.Add(Me.btn_SPA_Sales)
        Me.ribbonPageGroup_Collections.ItemLinks.Add(Me.btn_Journal_Entries, True)
        Me.ribbonPageGroup_Collections.Name = "ribbonPageGroup_Collections"
        Me.ribbonPageGroup_Collections.Text = "Forms"
        '
        'XtraTabbedMdiManager
        '
        Me.XtraTabbedMdiManager.MdiParent = Me
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem_Connection})
        Me.BarManager.MaxItemId = 1
        Me.BarManager.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem_Connection)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarStaticItem_Connection
        '
        Me.BarStaticItem_Connection.Caption = "Connection"
        Me.BarStaticItem_Connection.Id = 0
        Me.BarStaticItem_Connection.Name = "BarStaticItem_Connection"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(894, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 430)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(894, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 430)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(894, 0)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 430)
        '
        'RibbonPageGroup_Parameters
        '
        Me.RibbonPageGroup_Parameters.ItemLinks.Add(Me.BarEditItem_Branch)
        Me.RibbonPageGroup_Parameters.ItemLinks.Add(Me.BarEditItem_Date_Start)
        Me.RibbonPageGroup_Parameters.ItemLinks.Add(Me.BarEditItem_Date_End)
        Me.RibbonPageGroup_Parameters.ItemLinks.Add(Me.btn_Date, True)
        Me.RibbonPageGroup_Parameters.ItemLinks.Add(Me.btn_Today)
        Me.RibbonPageGroup_Parameters.ItemLinks.Add(Me.btn_Month)
        Me.RibbonPageGroup_Parameters.Name = "RibbonPageGroup_Parameters"
        Me.RibbonPageGroup_Parameters.Text = "Parameters"
        '
        'BarEditItem_Date_Start
        '
        Me.BarEditItem_Date_Start.Caption = "Date Start"
        Me.BarEditItem_Date_Start.Edit = Me.RepositoryItemDateEdit_Date_Start
        Me.BarEditItem_Date_Start.EditWidth = 150
        Me.BarEditItem_Date_Start.Id = 10
        Me.BarEditItem_Date_Start.ImageOptions.Image = CType(resources.GetObject("BarEditItem_Date_Start.ImageOptions.Image"), System.Drawing.Image)
        Me.BarEditItem_Date_Start.ImageOptions.LargeImage = CType(resources.GetObject("BarEditItem_Date_Start.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarEditItem_Date_Start.Name = "BarEditItem_Date_Start"
        '
        'RepositoryItemDateEdit_Date_Start
        '
        Me.RepositoryItemDateEdit_Date_Start.AutoHeight = False
        Me.RepositoryItemDateEdit_Date_Start.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit_Date_Start.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit_Date_Start.Name = "RepositoryItemDateEdit_Date_Start"
        '
        'BarEditItem_Date_End
        '
        Me.BarEditItem_Date_End.Caption = "Date End "
        Me.BarEditItem_Date_End.Edit = Me.RepositoryItemDateEdit_Date_End
        Me.BarEditItem_Date_End.EditWidth = 150
        Me.BarEditItem_Date_End.Id = 11
        Me.BarEditItem_Date_End.ImageOptions.Image = CType(resources.GetObject("BarEditItem_Date_End.ImageOptions.Image"), System.Drawing.Image)
        Me.BarEditItem_Date_End.ImageOptions.LargeImage = CType(resources.GetObject("BarEditItem_Date_End.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarEditItem_Date_End.Name = "BarEditItem_Date_End"
        '
        'RepositoryItemDateEdit_Date_End
        '
        Me.RepositoryItemDateEdit_Date_End.AutoHeight = False
        Me.RepositoryItemDateEdit_Date_End.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit_Date_End.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit_Date_End.Name = "RepositoryItemDateEdit_Date_End"
        '
        'btn_Date
        '
        Me.btn_Date.Caption = "Date"
        Me.btn_Date.Id = 12
        Me.btn_Date.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Date.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Date.Name = "btn_Date"
        '
        'btn_Today
        '
        Me.btn_Today.Caption = "Today"
        Me.btn_Today.Id = 13
        Me.btn_Today.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Today.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Today.Name = "btn_Today"
        '
        'btn_Month
        '
        Me.btn_Month.Caption = "Month"
        Me.btn_Month.Id = 14
        Me.btn_Month.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Month.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Month.Name = "btn_Month"
        '
        'btn_Credit_Memo
        '
        Me.btn_Credit_Memo.Caption = "Credit Memo"
        Me.btn_Credit_Memo.Id = 15
        Me.btn_Credit_Memo.ImageOptions.Image = CType(resources.GetObject("btn_Credit_Memo.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Credit_Memo.ImageOptions.LargeImage = CType(resources.GetObject("btn_Credit_Memo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Credit_Memo.Name = "btn_Credit_Memo"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 453)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IsMdiContainer = True
        Me.Name = "frm_Main"
        Me.Ribbon = Me.ribbonControl1
        Me.Text = "Saga Accounting"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit_Date_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit_Date_Start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit_Date_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit_Date_End, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents ribbonPage_Accounting As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribbonPageGroup_Collections As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Collection As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Cashiering As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEditItem_Branch As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents btn_MC_Sales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarHeaderItem_User As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem_Connection As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_SPA_Sales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEditItem_Date_Start As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit_Date_Start As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarEditItem_Date_End As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit_Date_End As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btn_Date As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Today As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Month As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup_Parameters As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Credit_Memo As DevExpress.XtraBars.BarButtonItem
End Class
