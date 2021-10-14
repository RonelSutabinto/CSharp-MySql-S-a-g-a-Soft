Namespace Forms.Information.Account
    Partial Class frm_Account
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Account))
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New_Row = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.popupMenu_Save = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Release = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.Toggle_Skip_Covid = New DevExpress.XtraBars.BarToggleSwitchItem()
            Me.btn_Amortization_Schedule = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Migrate = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Migrate_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Repo = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Repo_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Print_Documents = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Documents = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Amortization_Schedule_Document = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Certification = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Chattel_Mortgage = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Computation = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Deed_Of_Reconveyance = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Deed_Of_Sale = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Disclosure_Statement = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Pullout_Receipt = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Waiver = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.popupMenu_Cancel = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Delete_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Amortization = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reconcile = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Ledger = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Payments = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Post_Payment = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar4 = New DevExpress.XtraBars.Bar()
            Me.btn_Journal = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar5 = New DevExpress.XtraBars.Bar()
            Me.btn_History = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Previous_Owners = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar3 = New DevExpress.XtraBars.Bar()
            Me.btn_Refresh_Connection = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.xuc_Account = New SagaClassLibrary.Controls.Information.Account.xuc_Account()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupMenu_Save, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Documents, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupMenu_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar2, Me.bar1, Me.Bar4, Me.Bar5, Me.Bar3})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Initialize, Me.btn_Close, Me.btn_Journal, Me.btn_Ledger, Me.btn_Payments, Me.btn_Amortization, Me.btn_Migrate, Me.btn_Save_Close, Me.btn_Delete_Close, Me.btn_Migrate_Close, Me.btn_Refresh_Connection, Me.btn_Repo, Me.btn_Repo_Close, Me.btn_Post_Payment, Me.btn_Reconcile, Me.btn_Journal_Entries, Me.btn_History, Me.btn_Previous_Owners, Me.btn_Amortization_Schedule, Me.BarCheckItem1, Me.Toggle_Skip_Covid, Me.btn_New_Row, Me.btn_Release, Me.btn_Print_Documents, Me.btn_Amortization_Schedule_Document, Me.btn_Certification, Me.btn_Chattel_Mortgage, Me.btn_Computation, Me.btn_Deed_Of_Reconveyance, Me.btn_Deed_Of_Sale, Me.btn_Disclosure_Statement, Me.btn_Pullout_Receipt, Me.btn_Waiver})
            Me.barManager.MaxItemId = 45
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit1})
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'bar2
            '
            Me.bar2.BarName = "Commands"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.FloatLocation = New System.Drawing.Point(56, 197)
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New_Row), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Print_Documents), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar2.Text = "Commands"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 5
            Me.btn_Initialize.ImageOptions.ImageIndex = 6
            Me.btn_Initialize.ImageOptions.LargeImageIndex = 6
            Me.btn_Initialize.Name = "btn_Initialize"
            '
            'btn_Reload
            '
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.Id = 0
            Me.btn_Reload.ImageOptions.ImageIndex = 0
            Me.btn_Reload.ImageOptions.LargeImageIndex = 0
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_New
            '
            Me.btn_New.Caption = "New"
            Me.btn_New.Id = 2
            Me.btn_New.ImageOptions.ImageIndex = 1
            Me.btn_New.ImageOptions.LargeImageIndex = 1
            Me.btn_New.Name = "btn_New"
            Me.btn_New.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
            '
            'btn_New_Row
            '
            Me.btn_New_Row.Caption = "New Freebie"
            Me.btn_New_Row.Id = 33
            Me.btn_New_Row.Name = "btn_New_Row"
            '
            'btn_Save
            '
            Me.btn_Save.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.DropDownControl = Me.popupMenu_Save
            Me.btn_Save.Id = 4
            Me.btn_Save.ImageOptions.ImageIndex = 2
            Me.btn_Save.ImageOptions.LargeImageIndex = 2
            Me.btn_Save.Name = "btn_Save"
            '
            'popupMenu_Save
            '
            Me.popupMenu_Save.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Release), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_Close), New DevExpress.XtraBars.LinkPersistInfo(Me.Toggle_Skip_Covid, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Amortization_Schedule), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Migrate, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Migrate_Close), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Repo, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Repo_Close)})
            Me.popupMenu_Save.Manager = Me.barManager
            Me.popupMenu_Save.Name = "popupMenu_Save"
            '
            'btn_Release
            '
            Me.btn_Release.Caption = "Release"
            Me.btn_Release.Id = 34
            Me.btn_Release.ImageOptions.Image = CType(resources.GetObject("btn_Release.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Release.ImageOptions.LargeImage = CType(resources.GetObject("btn_Release.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Release.Name = "btn_Release"
            '
            'btn_Save_Close
            '
            Me.btn_Save_Close.Caption = "Save and Close"
            Me.btn_Save_Close.Id = 18
            Me.btn_Save_Close.ImageOptions.ImageIndex = 2
            Me.btn_Save_Close.Name = "btn_Save_Close"
            '
            'Toggle_Skip_Covid
            '
            Me.Toggle_Skip_Covid.Caption = "Skip March, April and May"
            Me.Toggle_Skip_Covid.Id = 32
            Me.Toggle_Skip_Covid.ImageOptions.Image = CType(resources.GetObject("Toggle_Skip_Covid.ImageOptions.Image"), System.Drawing.Image)
            Me.Toggle_Skip_Covid.ImageOptions.LargeImage = CType(resources.GetObject("Toggle_Skip_Covid.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.Toggle_Skip_Covid.Name = "Toggle_Skip_Covid"
            '
            'btn_Amortization_Schedule
            '
            Me.btn_Amortization_Schedule.Caption = "Generate Amortization Schedule"
            Me.btn_Amortization_Schedule.Id = 30
            Me.btn_Amortization_Schedule.ImageOptions.Image = CType(resources.GetObject("btn_Amortization_Schedule.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Amortization_Schedule.ImageOptions.LargeImage = CType(resources.GetObject("btn_Amortization_Schedule.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Amortization_Schedule.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), (System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
            Me.btn_Amortization_Schedule.Name = "btn_Amortization_Schedule"
            '
            'btn_Migrate
            '
            Me.btn_Migrate.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Migrate.Caption = "&Migrate"
            Me.btn_Migrate.Id = 17
            Me.btn_Migrate.ImageOptions.ImageIndex = 11
            Me.btn_Migrate.ImageOptions.LargeImageIndex = 11
            Me.btn_Migrate.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M))
            Me.btn_Migrate.Name = "btn_Migrate"
            '
            'btn_Migrate_Close
            '
            Me.btn_Migrate_Close.Caption = "&Migrate and Close"
            Me.btn_Migrate_Close.Id = 20
            Me.btn_Migrate_Close.ImageOptions.ImageIndex = 11
            Me.btn_Migrate_Close.Name = "btn_Migrate_Close"
            '
            'btn_Repo
            '
            Me.btn_Repo.Caption = "Repo and Save"
            Me.btn_Repo.Id = 22
            Me.btn_Repo.ImageOptions.Image = CType(resources.GetObject("btn_Repo.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Repo.ImageOptions.ImageIndex = 2
            Me.btn_Repo.ImageOptions.LargeImage = CType(resources.GetObject("btn_Repo.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Repo.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), (System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
            Me.btn_Repo.Name = "btn_Repo"
            '
            'btn_Repo_Close
            '
            Me.btn_Repo_Close.Caption = "Repo, Save and Close"
            Me.btn_Repo_Close.Id = 23
            Me.btn_Repo_Close.ImageOptions.Image = CType(resources.GetObject("btn_Repo_Close.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Repo_Close.ImageOptions.ImageIndex = 2
            Me.btn_Repo_Close.ImageOptions.LargeImage = CType(resources.GetObject("btn_Repo_Close.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Repo_Close.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), (System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
            Me.btn_Repo_Close.Name = "btn_Repo_Close"
            '
            'btn_Print_Documents
            '
            Me.btn_Print_Documents.ActAsDropDown = True
            Me.btn_Print_Documents.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Print_Documents.Caption = "Print Documents"
            Me.btn_Print_Documents.DropDownControl = Me.PopupMenu_Documents
            Me.btn_Print_Documents.Id = 35
            Me.btn_Print_Documents.ImageOptions.Image = CType(resources.GetObject("btn_Print_Documents.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Print_Documents.ImageOptions.LargeImage = CType(resources.GetObject("btn_Print_Documents.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Print_Documents.Name = "btn_Print_Documents"
            '
            'PopupMenu_Documents
            '
            Me.PopupMenu_Documents.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Amortization_Schedule_Document), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Certification), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Chattel_Mortgage), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Computation), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Deed_Of_Reconveyance), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Deed_Of_Sale), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Disclosure_Statement), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Pullout_Receipt), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Waiver)})
            Me.PopupMenu_Documents.Manager = Me.barManager
            Me.PopupMenu_Documents.Name = "PopupMenu_Documents"
            '
            'btn_Amortization_Schedule_Document
            '
            Me.btn_Amortization_Schedule_Document.Caption = "Amortization Schedule"
            Me.btn_Amortization_Schedule_Document.Id = 36
            Me.btn_Amortization_Schedule_Document.ImageOptions.Image = CType(resources.GetObject("btn_Amortization_Schedule_Document.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Amortization_Schedule_Document.ImageOptions.LargeImage = CType(resources.GetObject("btn_Amortization_Schedule_Document.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Amortization_Schedule_Document.Name = "btn_Amortization_Schedule_Document"
            '
            'btn_Certification
            '
            Me.btn_Certification.Caption = "Certification"
            Me.btn_Certification.Id = 37
            Me.btn_Certification.ImageOptions.Image = CType(resources.GetObject("btn_Certification.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Certification.ImageOptions.LargeImage = CType(resources.GetObject("btn_Certification.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Certification.Name = "btn_Certification"
            '
            'btn_Chattel_Mortgage
            '
            Me.btn_Chattel_Mortgage.Caption = "Chattel Mortgage"
            Me.btn_Chattel_Mortgage.Id = 38
            Me.btn_Chattel_Mortgage.ImageOptions.Image = CType(resources.GetObject("btn_Chattel_Mortgage.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Chattel_Mortgage.ImageOptions.LargeImage = CType(resources.GetObject("btn_Chattel_Mortgage.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Chattel_Mortgage.Name = "btn_Chattel_Mortgage"
            '
            'btn_Computation
            '
            Me.btn_Computation.Caption = "Computation"
            Me.btn_Computation.Id = 39
            Me.btn_Computation.ImageOptions.Image = CType(resources.GetObject("btn_Computation.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Computation.ImageOptions.LargeImage = CType(resources.GetObject("btn_Computation.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Computation.Name = "btn_Computation"
            '
            'btn_Deed_Of_Reconveyance
            '
            Me.btn_Deed_Of_Reconveyance.Caption = "Deed of Reconveyance"
            Me.btn_Deed_Of_Reconveyance.Id = 40
            Me.btn_Deed_Of_Reconveyance.ImageOptions.Image = CType(resources.GetObject("btn_Deed_Of_Reconveyance.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Deed_Of_Reconveyance.ImageOptions.LargeImage = CType(resources.GetObject("btn_Deed_Of_Reconveyance.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Deed_Of_Reconveyance.Name = "btn_Deed_Of_Reconveyance"
            '
            'btn_Deed_Of_Sale
            '
            Me.btn_Deed_Of_Sale.Caption = "Deed of Sale"
            Me.btn_Deed_Of_Sale.Id = 41
            Me.btn_Deed_Of_Sale.ImageOptions.Image = CType(resources.GetObject("btn_Deed_Of_Sale.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Deed_Of_Sale.ImageOptions.LargeImage = CType(resources.GetObject("btn_Deed_Of_Sale.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Deed_Of_Sale.Name = "btn_Deed_Of_Sale"
            '
            'btn_Disclosure_Statement
            '
            Me.btn_Disclosure_Statement.Caption = "Disclosure Statement"
            Me.btn_Disclosure_Statement.Id = 42
            Me.btn_Disclosure_Statement.ImageOptions.Image = CType(resources.GetObject("btn_Disclosure_Statement.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Disclosure_Statement.ImageOptions.LargeImage = CType(resources.GetObject("btn_Disclosure_Statement.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Disclosure_Statement.Name = "btn_Disclosure_Statement"
            '
            'btn_Pullout_Receipt
            '
            Me.btn_Pullout_Receipt.Caption = "Pullout Receipt"
            Me.btn_Pullout_Receipt.Id = 43
            Me.btn_Pullout_Receipt.ImageOptions.Image = CType(resources.GetObject("btn_Pullout_Receipt.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Pullout_Receipt.ImageOptions.LargeImage = CType(resources.GetObject("btn_Pullout_Receipt.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Pullout_Receipt.Name = "btn_Pullout_Receipt"
            '
            'btn_Waiver
            '
            Me.btn_Waiver.Caption = "Waiver"
            Me.btn_Waiver.Id = 44
            Me.btn_Waiver.ImageOptions.Image = CType(resources.GetObject("btn_Waiver.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Waiver.ImageOptions.LargeImage = CType(resources.GetObject("btn_Waiver.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Waiver.Name = "btn_Waiver"
            '
            'btn_Delete
            '
            Me.btn_Delete.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Delete.Caption = "C&ancel"
            Me.btn_Delete.DropDownControl = Me.popupMenu_Cancel
            Me.btn_Delete.Id = 3
            Me.btn_Delete.ImageOptions.ImageIndex = 3
            Me.btn_Delete.ImageOptions.LargeImageIndex = 3
            Me.btn_Delete.Name = "btn_Delete"
            '
            'popupMenu_Cancel
            '
            Me.popupMenu_Cancel.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete_Close)})
            Me.popupMenu_Cancel.Manager = Me.barManager
            Me.popupMenu_Cancel.Name = "popupMenu_Cancel"
            '
            'btn_Delete_Close
            '
            Me.btn_Delete_Close.Caption = "Cancel and Close"
            Me.btn_Delete_Close.Id = 19
            Me.btn_Delete_Close.ImageOptions.ImageIndex = 3
            Me.btn_Delete_Close.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.D))
            Me.btn_Delete_Close.Name = "btn_Delete_Close"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 1
            Me.btn_Close.ImageOptions.ImageIndex = 5
            Me.btn_Close.ImageOptions.LargeImageIndex = 5
            Me.btn_Close.Name = "btn_Close"
            '
            'bar1
            '
            Me.bar1.BarName = "Sub-Forms"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 1
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(83, 192)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Amortization), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reconcile), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Ledger, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Payments), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Post_Payment, True)})
            Me.bar1.Text = "Sub-Forms"
            '
            'btn_Amortization
            '
            Me.btn_Amortization.Caption = "&Amortization"
            Me.btn_Amortization.Id = 16
            Me.btn_Amortization.ImageOptions.Image = CType(resources.GetObject("btn_Amortization.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Amortization.ImageOptions.ImageIndex = 9
            Me.btn_Amortization.ImageOptions.LargeImage = CType(resources.GetObject("btn_Amortization.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Amortization.ImageOptions.LargeImageIndex = 9
            Me.btn_Amortization.Name = "btn_Amortization"
            '
            'btn_Reconcile
            '
            Me.btn_Reconcile.Caption = "Rec&oncile"
            Me.btn_Reconcile.Id = 26
            Me.btn_Reconcile.ImageOptions.Image = CType(resources.GetObject("btn_Reconcile.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Reconcile.ImageOptions.ImageIndex = 14
            Me.btn_Reconcile.ImageOptions.LargeImage = CType(resources.GetObject("btn_Reconcile.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Reconcile.ImageOptions.LargeImageIndex = 14
            Me.btn_Reconcile.Name = "btn_Reconcile"
            '
            'btn_Ledger
            '
            Me.btn_Ledger.Caption = "Led&ger"
            Me.btn_Ledger.Id = 10
            Me.btn_Ledger.ImageOptions.ImageIndex = 8
            Me.btn_Ledger.ImageOptions.LargeImageIndex = 8
            Me.btn_Ledger.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G))
            Me.btn_Ledger.Name = "btn_Ledger"
            '
            'btn_Payments
            '
            Me.btn_Payments.Caption = "Pa&yments"
            Me.btn_Payments.Id = 11
            Me.btn_Payments.ImageOptions.ImageIndex = 8
            Me.btn_Payments.ImageOptions.LargeImageIndex = 8
            Me.btn_Payments.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
            Me.btn_Payments.Name = "btn_Payments"
            '
            'btn_Post_Payment
            '
            Me.btn_Post_Payment.Caption = "Post Payment"
            Me.btn_Post_Payment.Id = 24
            Me.btn_Post_Payment.ImageOptions.Image = CType(resources.GetObject("btn_Post_Payment.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Post_Payment.ImageOptions.ImageIndex = 13
            Me.btn_Post_Payment.ImageOptions.LargeImage = CType(resources.GetObject("btn_Post_Payment.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Post_Payment.Name = "btn_Post_Payment"
            '
            'Bar4
            '
            Me.Bar4.BarName = "Accounting"
            Me.Bar4.DockCol = 1
            Me.Bar4.DockRow = 1
            Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries)})
            Me.Bar4.Offset = 214
            Me.Bar4.Text = "Accounting"
            Me.Bar4.Visible = False
            '
            'btn_Journal
            '
            Me.btn_Journal.Caption = "Journal"
            Me.btn_Journal.Id = 9
            Me.btn_Journal.ImageOptions.ImageIndex = 7
            Me.btn_Journal.ImageOptions.LargeImageIndex = 7
            Me.btn_Journal.Name = "btn_Journal"
            '
            'btn_Journal_Entries
            '
            Me.btn_Journal_Entries.Caption = "Journal Entries"
            Me.btn_Journal_Entries.Id = 27
            Me.btn_Journal_Entries.ImageOptions.ImageIndex = 15
            Me.btn_Journal_Entries.ImageOptions.LargeImageIndex = 15
            Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
            '
            'Bar5
            '
            Me.Bar5.BarName = "Inventory"
            Me.Bar5.DockCol = 1
            Me.Bar5.DockRow = 2
            Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_History), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Previous_Owners)})
            Me.Bar5.Text = "Inventory"
            Me.Bar5.Visible = False
            '
            'btn_History
            '
            Me.btn_History.Caption = "History"
            Me.btn_History.Id = 28
            Me.btn_History.ImageOptions.Image = CType(resources.GetObject("btn_History.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_History.ImageOptions.ImageIndex = 16
            Me.btn_History.ImageOptions.LargeImage = CType(resources.GetObject("btn_History.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_History.ImageOptions.LargeImageIndex = 16
            Me.btn_History.Name = "btn_History"
            '
            'btn_Previous_Owners
            '
            Me.btn_Previous_Owners.Caption = "Previous Owners"
            Me.btn_Previous_Owners.Id = 29
            Me.btn_Previous_Owners.ImageOptions.Image = CType(resources.GetObject("btn_Previous_Owners.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Previous_Owners.ImageOptions.ImageIndex = 17
            Me.btn_Previous_Owners.ImageOptions.LargeImage = CType(resources.GetObject("btn_Previous_Owners.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Previous_Owners.ImageOptions.LargeImageIndex = 17
            Me.btn_Previous_Owners.Name = "btn_Previous_Owners"
            '
            'Bar3
            '
            Me.Bar3.BarName = "Connections"
            Me.Bar3.DockCol = 0
            Me.Bar3.DockRow = 2
            Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Refresh_Connection)})
            Me.Bar3.Text = "Connections"
            Me.Bar3.Visible = False
            '
            'btn_Refresh_Connection
            '
            Me.btn_Refresh_Connection.Caption = "Chec&k Connection"
            Me.btn_Refresh_Connection.Id = 21
            Me.btn_Refresh_Connection.ImageOptions.ImageIndex = 12
            Me.btn_Refresh_Connection.ImageOptions.LargeImageIndex = 12
            Me.btn_Refresh_Connection.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K))
            Me.btn_Refresh_Connection.Name = "btn_Refresh_Connection"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(517, 74)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 651)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(517, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 74)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 577)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(517, 74)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 577)
            '
            'BarCheckItem1
            '
            Me.BarCheckItem1.Caption = "BarCheckItem1"
            Me.BarCheckItem1.Id = 31
            Me.BarCheckItem1.Name = "BarCheckItem1"
            '
            'repositoryItemTextEdit1
            '
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            '
            'xuc_Account
            '
            Me.xuc_Account.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Account.Location = New System.Drawing.Point(0, 74)
            Me.xuc_Account.Name = "xuc_Account"
            Me.xuc_Account.Size = New System.Drawing.Size(517, 577)
            Me.xuc_Account.TabIndex = 15
            '
            'frm_Account
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(517, 651)
            Me.Controls.Add(Me.xuc_Account)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.HelpButton = True
            Me.IconOptions.ShowIcon = False
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.Name = "frm_Account"
            Me.Text = "Account Information"
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupMenu_Save, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Documents, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupMenu_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents btn_Journal As DevExpress.XtraBars.BarButtonItem
        Friend barManager As DevExpress.XtraBars.BarManager
        Friend bar2 As DevExpress.XtraBars.Bar
        Friend bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Ledger As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Payments As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Amortization As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Migrate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save_Close As DevExpress.XtraBars.BarButtonItem
        Private popupMenu_Save As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Delete_Close As DevExpress.XtraBars.BarButtonItem
        Private popupMenu_Cancel As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Migrate_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Refresh_Connection As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Repo As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Repo_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Post_Payment As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reconcile As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_History As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Previous_Owners As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents xuc_Account As Controls.Information.Account.xuc_Account
        Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Amortization_Schedule As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Toggle_Skip_Covid As DevExpress.XtraBars.BarToggleSwitchItem
        Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
        Friend WithEvents btn_New_Row As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Release As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Print_Documents As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_Documents As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Amortization_Schedule_Document As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Certification As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Chattel_Mortgage As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Computation As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Deed_Of_Reconveyance As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Deed_Of_Sale As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Disclosure_Statement As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Pullout_Receipt As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Waiver As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace
