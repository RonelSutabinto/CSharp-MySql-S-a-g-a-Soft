Imports DevExpress
Imports DevExpress.Skins
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Models
Imports System.Windows.Forms


Namespace Classes
    Public Module class_Saga_Procedures

        Public Sub Initialize_BarManager(ByVal xForm As XtraForm, ByVal barManager As BarManager)
            Initialize_BarManager(barManager)
            Try
                barManager.RestoreLayoutFromRegistry(xForm.Name)
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Public Sub Initialize_BarManager(ByVal xForm As XtraForm, ByVal barManager As BarManager, ByVal xucSettings As MyClassLibrary.Controls.Settings.xuc_Settings)
            Initialize_BarManager(barManager)

            If xucSettings.Check_Save_Restore_Layout.Checked Then
                barManager.RestoreLayoutFromRegistry(xForm.Name)
            End If
        End Sub

        Public Sub Initialize_BarManager(ByVal xControl As XtraUserControl, ByVal barManager As BarManager)
            Initialize_BarManager(barManager)
            barManager.RestoreLayoutFromRegistry(xControl.Name)
        End Sub

        Public Sub Initialize_BarManager(ByVal barManager As BarManager)
            Dim xIconForm As New SagaClassLibrary.Forms.XtraForm1
            For Each item In barManager.RepositoryItems
                If item.GetType = GetType(RepositoryItemDateEdit) Then
                    With CType(item, RepositoryItemDateEdit)
                        .Appearance.Options.UseTextOptions = True
                        .Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                        .DisplayFormat.FormatString = "MMMM dd, yyyy"
                        .DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                        .EditFormat.FormatString = "MMMM dd, yyyy"
                        .EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                        .Mask.EditMask = "MMMM dd, yyyy"
                        .Mask.UseMaskAsDisplayFormat = True
                    End With

                ElseIf item.GetType = GetType(RepositoryItemSearchControl) Then
                    With CType(item, RepositoryItemSearchControl)
                        '.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
                        .Sorted = True
                    End With

                ElseIf item.GetType = GetType(RepositoryItemLookUpEdit) Then
                    With CType(item, RepositoryItemLookUpEdit)
                        Select Case .Name
                            Case "RepositoryItemLookUpEdit_Corporation"
                                class_Saga_Procedures.Initialize_Corporation(CType(item, RepositoryItemLookUpEdit))

                            Case "RepositoryItemLookUpEdit_Branch"
                                class_Saga_Procedures.Initialize_Branch(CType(item, RepositoryItemLookUpEdit))
                        End Select

                    End With
                End If
            Next

            For Each item In barManager.Items
                If item.GetType = GetType(BarCheckItem) Then
                    With CType(item, BarCheckItem)
                        .PaintStyle = BarItemPaintStyle.CaptionGlyph
                        .Hint = "Click Button to set On/Off to affect data display/process"
                    End With

                ElseIf item.GetType = GetType(BarToggleSwitchItem) Then
                    With CType(item, BarToggleSwitchItem)
                        .PaintStyle = BarItemPaintStyle.CaptionGlyph
                        Select Case CType(item, BarToggleSwitchItem).Name
                            Case "BarToggleSwitchItem_Any_Date"
                                .Caption = "An&y Date"
                                .Hint = "Enable to Search at any date."
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.Y)
                                .ImageOptions.Image = xIconForm.BarToggleSwitchItem_Any_Date.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.BarToggleSwitchItem_Any_Date.ImageOptions.LargeImage
                        End Select
                    End With

                ElseIf item.GetType = GetType(BarButtonItem) Then
                    With CType(item, BarButtonItem)
                        .PaintStyle = BarItemPaintStyle.CaptionGlyph
                        Select Case .Name
                            Case "btn_Account"
                                .Caption = "&Account"
                                .Hint = "Show account information"
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.A)
                                .ImageOptions.Image = xIconForm.btn_Account.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Account.ImageOptions.LargeImage

                            Case "btn_Batch_Transactions"
                                .Caption = "Batch Transactions"
                                .Hint = "Show selected Batch Transactions"
                                .ItemShortcut = New BarShortcut(Keys.F7)
                                .ImageOptions.Image = xIconForm.btn_Batch_Transactions.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Batch_Transactions.ImageOptions.LargeImage

                        'SQL Server Connection
                            Case "btn_Refresh_Connection"
                                .Caption = "Re&fresh Connection"
                                .Hint = "Refresh/Check SQL Database connection"
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.F)
                                .ImageOptions.Image = xIconForm.btn_Refresh_Connection.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Refresh_Connection.ImageOptions.LargeImage

                            Case "btn_Test_Connection"
                                .Caption = "Test Connection"
                                .Hint = "Test/Check SQL Database connection using specified parameters"
                                .ItemShortcut = New BarShortcut(Keys.F5)
                                .ImageOptions.Image = xIconForm.btn_Refresh_Connection.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Refresh_Connection.ImageOptions.LargeImage

                            Case "btn_Connect_Close"
                                .Caption = "Connect and Close"
                                .Hint = "Connect SQL Database and close the form"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.F5)
                                .ImageOptions.Image = xIconForm.btn_OK.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_OK.ImageOptions.LargeImage

                            'Primary Actions
                            Case "btn_Import"
                                .Caption = "Import"
                                .Hint = "Import data into gridView"
                                .ImageOptions.Image = xIconForm.btn_Import.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Import.ImageOptions.LargeImage

                            Case "btn_Initialize"
                                .Caption = "Initiali&ze"
                                .Hint = "Initialize data on some text controls"
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.Z)
                                .ImageOptions.Image = xIconForm.btn_Initialize.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Initialize.ImageOptions.LargeImage

                            Case "btn_Reset"
                                .Caption = "Reset"
                                .Hint = "Reset controls (bar, dock, gridView etc.)"
                                .ImageOptions.Image = xIconForm.btn_Reset.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Reset.ImageOptions.LargeImage
                                .Visibility = BarItemVisibility.OnlyInCustomizing

                            Case "btn_Reload"
                                .Caption = "&Reload"
                                .Hint = "Load or refresh data on gridView Table"
                                .ItemShortcut = New BarShortcut(Keys.F5)
                                .ImageOptions.Image = xIconForm.btn_Reload.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Reload.ImageOptions.LargeImage

                            Case "btn_Load_All"
                                .Caption = "Load &All"
                                .Hint = "Load All or refresh data on gridView Table"
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.F5)
                                .ImageOptions.Image = xIconForm.btn_Reload.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Reload.ImageOptions.LargeImage

                            Case "btn_Print"
                                .Caption = "&Print"
                                .Hint = "Print Current Information"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.V)
                                .ImageOptions.Image = xIconForm.btn_Preview.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Preview.ImageOptions.LargeImage

                            Case "btn_Preview"
                                .Caption = "&Preview"
                                .Hint = "Display Data from gridView Table into Printable Form"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.V)
                                .ImageOptions.Image = xIconForm.btn_Preview.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Preview.ImageOptions.LargeImage

                            Case "btn_Print_Check"
                                .Caption = "Print Check"
                                .Hint = "Print check with Payee and Amount"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.H)
                                .ImageOptions.Image = xIconForm.btn_Print_Check.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Print_Check.ImageOptions.LargeImage

                            Case "btn_New"
                                .Caption = "&New"
                                .Hint = "Clear controls/input boxes to entry new data"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.N)
                                .ImageOptions.Image = xIconForm.btn_New.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_New.ImageOptions.LargeImage

                            Case "btn_New_Wizard"
                                .Caption = "&New Wizard"
                                .Hint = "Show wizard form to input data with step by step"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.W)
                                .ImageOptions.Image = xIconForm.btn_New_Wizard.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_New_Wizard.ImageOptions.LargeImage

                            Case "btn_New_Row"
                                .Caption = "New &Row"
                                .Hint = "Add New Row to Grid to input New Data"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.Insert)
                                .ImageOptions.Image = xIconForm.btn_New_Row.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_New_Row.ImageOptions.LargeImage

                            Case "btn_Edit"
                                .Caption = "&Edit"
                                .Hint = "Edit Information to change the current values"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.E)
                                .ImageOptions.Image = xIconForm.btn_Edit.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Edit.ImageOptions.LargeImage

                            Case "btn_Save"
                                .Caption = "&Save"
                                .Hint = "Save data with current values"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.S)
                                .ImageOptions.Image = xIconForm.btn_Save.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Save.ImageOptions.LargeImage

                            Case "btn_Save_New"
                                .Caption = "Save and New"
                                .Hint = "Save data and then prepare new entry"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.N)
                                .ImageOptions.Image = xIconForm.btn_Save_New.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Save_New.ImageOptions.LargeImage

                            Case "btn_Save_Journal_Entries"
                                .Caption = "Save and Show Journal Entries"
                                .Hint = "Save data then show Journal Entries then Closes the current Form"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.J)
                                .ImageOptions.Image = xIconForm.btn_Journal.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Journal.ImageOptions.LargeImage

                            Case "btn_Save_Close"
                                .Caption = "Save and Close"
                                .Hint = "Save data then Closes the current Form"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.S)
                                .ImageOptions.Image = xIconForm.btn_Save_Close.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Save_Close.ImageOptions.LargeImage

                            Case "btn_Update"
                                .Caption = "&Update"
                                .Hint = "Update or overwrite existing data with new values"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.U)
                                .ImageOptions.Image = xIconForm.btn_Update.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Update.ImageOptions.LargeImage

                            Case "btn_Delete"
                                .Caption = "&Delete"
                                .Hint = "Delete, Cancel or Remove selected data"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.D)
                                .ImageOptions.Image = xIconForm.btn_Delete.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Delete.ImageOptions.LargeImage

                            Case "btn_Delete"
                                .Caption = "&For Delete"
                                .Hint = "Send selected row(s) 'For Delete' to Admin"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.D)
                                .ImageOptions.Image = xIconForm.btn_Delete.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Delete.ImageOptions.LargeImage

                            Case "btn_Delete_Close"
                                .Caption = "&Delete and Close"
                                .Hint = "Delete, Cancel or Remove selected data and Close the form"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.D)
                                .ImageOptions.Image = xIconForm.btn_Delete.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Delete.ImageOptions.LargeImage

                            Case "btn_Close"
                                .Caption = "&Close"
                                .Hint = "Closes the Window Form"
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.C)
                                .ImageOptions.Image = xIconForm.btn_Close.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Close.ImageOptions.LargeImage

                            Case "btn_Cancel"
                                .Caption = "Cancel"
                                .Hint = "Cancel the current data record"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.C)
                                .ImageOptions.Image = xIconForm.btn_Cancel.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Cancel.ImageOptions.LargeImage

                            'Status
                            Case "btn_Pending"
                                .Caption = "&Pending"
                                .Hint = "Load pending transactions to gridView Table"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.F5)
                                .ImageOptions.Image = xIconForm.btn_Pending.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Pending.ImageOptions.LargeImage

                            Case "btn_Approval"
                                .Caption = "Approval"
                                .Hint = "Send selected row(s) 'For Approval' to Approver"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.A)
                                .ImageOptions.Image = xIconForm.btn_Approval.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Approval.ImageOptions.LargeImage

                            Case "btn_Approve"
                                .Caption = "Approve"
                                .Hint = "Approve 'For Approval' selected row(s)"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.P)
                                .ImageOptions.Image = xIconForm.btn_Approve.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Approve.ImageOptions.LargeImage

                            Case "btn_DisApprove"
                                .Caption = "Disapprove"
                                .Hint = "Disapprove 'For Approval' selected row(s)"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.I)
                                .ImageOptions.Image = xIconForm.btn_DisApprove.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_DisApprove.ImageOptions.LargeImage

                            Case "btn_Password_Reset"
                                .Caption = "Password Reset"
                                .Hint = "Reset user password"
                                .ImageOptions.Image = xIconForm.btn_Password_Reset.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Password_Reset.ImageOptions.LargeImage

                            Case "btn_Lock"
                                .Caption = "Lock/Unlock"
                                .Hint = "Lock data update permission"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.L)
                                .ImageOptions.Image = xIconForm.btn_Lock.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Lock.ImageOptions.LargeImage

                                'Custom Query
                            Case "btn_Generate"
                                .Caption = "&Generate"
                                .Hint = "Generate SQL Query or Transactions"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.G)
                                .ImageOptions.Image = xIconForm.btn_Generate.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Generate.ImageOptions.LargeImage

                            Case "btn_Execute"
                                .Caption = "Execute"
                                .Hint = "Execute command to process data"
                                .ItemShortcut = New BarShortcut(Keys.F5)
                                .ImageOptions.Image = xIconForm.btn_Execute.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Execute.ImageOptions.LargeImage

                            'Checks
                            Case "btn_Link"
                                .Caption = "Link"
                                .Hint = "Link selected transaction accross other transactions"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.L)
                                .ImageOptions.Image = xIconForm.btn_Link.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Link.ImageOptions.LargeImage

                            'Chart of Accounts
                            Case "btn_Convert_Summary"
                                .Caption = "Convert to Summary"
                                .Hint = "Convert selected Detail COA into Summary"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.T)
                                .ImageOptions.Image = xIconForm.btn_Convert_Summary.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Convert_Summary.ImageOptions.LargeImage

                            Case "btn_Insert"
                                .Caption = "Insert"
                                .Hint = "Insert New Entry (Auto-increment Code)"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.Insert)
                                .ImageOptions.Image = xIconForm.btn_Insert.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Insert.ImageOptions.LargeImage

                            Case "btn_Another_Entry"
                                .Caption = "Another Entr&y"
                                .Hint = "Input another entry (ID Code Auto-increment)"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.Y)
                                .ImageOptions.Image = xIconForm.btn_Another_Entry.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Another_Entry.ImageOptions.LargeImage

                            'Tree List view
                            Case "btn_Expand"
                                .Caption = "Expand"
                                .Hint = "Expand the Tree List view"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.Add)
                                .ImageOptions.Image = xIconForm.btn_Expand.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Expand.ImageOptions.LargeImage

                            Case "btn_Collapse"
                                .Caption = "Collapse"
                                .Hint = "Collapse the Tree List view"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.Subtract)
                                .ImageOptions.Image = xIconForm.btn_Collapse.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Collapse.ImageOptions.LargeImage

                            'Journal
                            Case "btn_Journal"
                                .Caption = "&Journal"
                                .Hint = "Convert selected transaction into Journal Entries"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.F6)
                                .ImageOptions.Image = xIconForm.btn_Journal.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Journal.ImageOptions.LargeImage

                            Case "btn_Journal2"
                                .Caption = "Re-&Journal"
                                .Hint = "Delete cancelled journal entries and Re-Entry new journal entries"
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.F6)
                                .ImageOptions.Image = xIconForm.btn_Journal.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Journal.ImageOptions.LargeImage

                            Case "btn_Journal_Entries"
                                .Caption = "Journal &Entries"
                                .Hint = "Show Journal Entries of the selected transaction"
                                .ItemShortcut = New BarShortcut(Keys.F6)
                                .ImageOptions.Image = xIconForm.btn_Journal_Entries.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Journal_Entries.ImageOptions.LargeImage

                            Case "btn_Journal_Entries2"
                                .Caption = "&Journal Entries 2"
                                .Hint = "Show Journal Entries of the selected Account"
                                .ItemShortcut = New BarShortcut(Keys.Shift Or Keys.F6)
                                .ImageOptions.Image = xIconForm.btn_Journal_Entries.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Journal_Entries.ImageOptions.LargeImage

                            Case "btn_COA_Ledger", "btn_Ledger", "btn_Payments"
                                .Caption = .Name.Substring(4)
                                .Hint = $"Show { .Name.Substring(4)}"
                                .ItemShortcut = New BarShortcut(Keys.F7)
                                .ImageOptions.Image = xIconForm.btn_COA_Ledger.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_COA_Ledger.ImageOptions.LargeImage

                            Case "btn_Validate"
                                .Caption = "&Validate"
                                .Hint = "Validate the data in gridView Table and check for errors"
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.V)
                                .ImageOptions.Image = xIconForm.btn_Validate.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Validate.ImageOptions.LargeImage

                            Case "btn_Verify"
                                .Caption = "Verify"
                                .Hint = "Verify transactions if IsJournal"
                                .ItemShortcut = New BarShortcut(Keys.F8)
                                .ImageOptions.Image = xIconForm.btn_Verify.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Verify.ImageOptions.LargeImage

                            Case "btn_Stop"
                                .Caption = "S&top"
                                .Hint = "Stop or Halt the current looping process"
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.S)
                                .ImageOptions.Image = xIconForm.btn_Stop.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Stop.ImageOptions.LargeImage

                            'Trial Balance
                            Case "btn_Trial_Balance"
                                .Caption = "Update Trial Balance"
                                .Hint = "Update Trial Balance of the selected row(s)"
                                .ImageOptions.Image = xIconForm.btn_Trial_Balance.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Trial_Balance.ImageOptions.LargeImage

                                'Case "btn_Generate"
                                '    .Caption = "&Generate"
                                '    .Hint = "Generate data in gridView Table"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.G)

                            Case "btn_Summary"
                                .Caption = "Su&mmary"
                                .Hint = "Update journal summary from gridView Table"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.M)
                                .ImageOptions.Image = xIconForm.btn_Summary.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Summary.ImageOptions.LargeImage

                            'Filter
                            Case "btn_Filter_Load"
                                .Caption = "Filter &Load"
                                .Hint = "Rearrange/Format gridView Table from the selected Filter Profile"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.L)
                                .ImageOptions.Image = xIconForm.btn_Filter_Load.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Filter_Load.ImageOptions.LargeImage

                            Case "btn_Filter_Save"
                                .Caption = "Filter &Save"
                                .Hint = "Save gridView Table arrangements/format to the selected Filter Profile"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.S)
                                .ImageOptions.Image = xIconForm.btn_Filter_Save.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Filter_Save.ImageOptions.LargeImage

                            Case "btn_Filter_Delete"
                                .Caption = "Filter &Delete"
                                .Hint = "Delete selected Filter Profile"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.D)
                                .ImageOptions.Image = xIconForm.btn_Filter_Delete.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Filter_Delete.ImageOptions.LargeImage

                            'Custom
                            Case "btn_Regenerate_Codes"
                                .Caption = "Regenerate Codes"
                                .Hint = "Regenerate/Repair Codes to avoid Primary Key Error"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.G)
                                .ImageOptions.Image = xIconForm.btn_Regenerate_Codes.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_Regenerate_Codes.ImageOptions.LargeImage

                            Case "btn_History"
                                .Caption = "History"
                                .Hint = "Check the Activity History of the selected item"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.H)
                                .ImageOptions.Image = xIconForm.btn_History.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_History.ImageOptions.LargeImage

                            Case "btn_SMS"
                                .Caption = "Send SMS"
                                .Hint = "Send SMS on selected COntact Numbers"
                                .ImageOptions.Image = xIconForm.btn_SMS.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.btn_SMS.ImageOptions.LargeImage
                        End Select
                    End With

                ElseIf item.GetType = GetType(BarEditItem) Then
                    With CType(item, BarEditItem)
                        .PaintStyle = BarItemPaintStyle.CaptionGlyph
                        Select Case .Name
                            Case "BarEditItem_Corporation", "Corporation"
                                .Caption = "Corporation"
                                .EditWidth = 80
                                .Hint = "SELECT Corporation"
                                .ImageOptions.Image = xIconForm.BarEditItem_Corporation.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.BarEditItem_Corporation.ImageOptions.LargeImage

                            Case "barEditItem_Branch"
                                .Caption = "Branch"
                                .EditWidth = 200
                                .Hint = "SELECT Branch"
                                .ImageOptions.Image = xIconForm.barEditItem_Branch.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.barEditItem_Branch.ImageOptions.LargeImage

                            Case "BarEditItem_Search"
                                .Caption = "Search"
                                .EditWidth = 150
                                .Hint = "Search any string and show results in gridView"
                                .ImageOptions.Image = xIconForm.BarEditItem_Search.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.BarEditItem_Search.ImageOptions.LargeImage

                            Case "BarEditItem_Posting_Date", "barEditItem_Date_Start", "barEditItem_Date_End", "BarEditItem_Date_Granted", "Date_Start", "Date_End"
                                Select Case .Name
                                    Case "BarEditItem_Posting_Date"
                                        .Caption = "Posting Date"
                                        .Hint = "Custom Posting Date for Journal Entry"

                                    Case "barEditItem_Date_Start", "Date_Start"
                                        .Caption = "Date Start"
                                        .Hint = "Set starting date"

                                    Case "barEditItem_Date_End", "Date_End"
                                        .Caption = "Date End"
                                        .Hint = "Set ending date"
                                End Select

                                .EditWidth = 140
                                .EditValue = Date.Now

                            Case "BarEditItem_Filter"
                                .Caption = "Filter"
                                .EditWidth = 150
                                .Hint = "SELECT and manage gridView Table query result filter"
                                .ImageOptions.Image = xIconForm.BarEditItem_Filter.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.BarEditItem_Filter.ImageOptions.LargeImage

                            Case "BarEditItem_Document_Title"
                                .Caption = "Document Title"
                                .Hint = "Document Title for Report Printing"

                            Case "BarEditItem_Remarks"
                                .Caption = "Remarks"
                                .Hint = "Remarks information for current transaction"
                        End Select
                    End With
                End If
            Next
        End Sub

        Private Sub Initialize_LookUpEdit(ByVal lookUpEdit As LookUpEdit, ByVal lookUpColumnInfo As LookUpColumnInfo(), ByVal bindingSource As BindingSource, ByVal sDisplay As String, ByVal sValue As String, Optional ByVal editStyle As DevExpress.XtraEditors.Controls.TextEditStyles = XtraEditors.Controls.TextEditStyles.Standard)
            With lookUpEdit.Properties
                .Columns.Clear()
                .Columns.AddRange(lookUpColumnInfo)
                .DataSource = bindingSource
                .DisplayMember = sDisplay
                .NullValuePrompt = $"Select {sDisplay}..."
                .ValueMember = sValue
            End With
            class_Procedures.Initialize_RepositoryItem(lookUpEdit.Properties, editStyle)
        End Sub

        Private Sub Initialize_LookUpEdit(ByVal lookUpEdit As RepositoryItemLookUpEdit, ByVal lookUpColumnInfo As LookUpColumnInfo(), ByVal bindingSource As BindingSource, ByVal sDisplay As String, ByVal sValue As String, Optional ByVal editStyle As DevExpress.XtraEditors.Controls.TextEditStyles = XtraEditors.Controls.TextEditStyles.Standard)
            With lookUpEdit
                .Columns.Clear()
                .Columns.AddRange(lookUpColumnInfo)
                .DataSource = bindingSource
                .DisplayMember = sDisplay
                .NullValuePrompt = $"Select {sDisplay}..."
                .ValueMember = sValue
            End With
            class_Procedures.Initialize_RepositoryItem(lookUpEdit, editStyle)
        End Sub

        Public Sub Initialize_Corporation(ByVal lookUpEdit As LookUpEdit, Optional ByVal bAll As Boolean = False)
            Try
                Dim corporations As New List(Of Corporation) From
                    {
                        New Corporation With {.ID = 1, .Code = "SFC", .Name = "FINANCE", .FullName = "SAGA FINANCE CORPORATION", .Address = "National Highway, Sta. Isabel, Dipolog City, Zamboanga del Norte"},
                        New Corporation With {.ID = 2, .Code = "SMC", .Name = "MOTORS", .FullName = "SAGA MOTORS CORPORATION", .Address = "National Highway, Sta. Isabel, Dipolog City, Zamboanga del Norte"}
                    }

                With lookUpEdit.Properties
                    .Columns.Clear()
                    .Columns.AddRange(New LookUpColumnInfo() {
                                      New LookUpColumnInfo("ID"),
                                      New LookUpColumnInfo("Code"),
                                      New LookUpColumnInfo("Name", "Corporation"),
                                      New LookUpColumnInfo("FullName", "Corporation Name")})

                    If bAll Then
                        corporations.Add(New Corporation With {.ID = 0, .Code = "ALL", .Name = "CUSTOM", .FullName = "ALL/ANY SAGA CORPORATIONS", .Address = "National Highway, Sta. Isabel, Dipolog City, Zamboanga del Norte"})
                        .DropDownRows = 3
                    Else
                        .DropDownRows = 2
                    End If

                    .DataSource = corporations
                    .DisplayMember = "Name"
                    .ValueMember = "Code"
                End With
                class_Procedures.Initialize_RepositoryItem(lookUpEdit.Properties, XtraEditors.Controls.TextEditStyles.DisableTextEditor)
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Public Sub Initialize_Corporation(ByVal barEditItem As BarEditItem, ByVal repositoryItemLookUpEdit As RepositoryItemLookUpEdit, Optional ByVal bAll As Boolean = False, Optional ByVal iDropDownRows As Integer = 2)
            barEditItem.EditWidth = 100
            Initialize_Corporation(repositoryItemLookUpEdit, bAll, iDropDownRows)
        End Sub

        Public Sub Initialize_Corporation(ByVal repositoryItemLookUpEdit As RepositoryItemLookUpEdit, Optional ByVal bAll As Boolean = False, Optional ByVal iDropDownRows As Integer = 2)
            Try
                Dim corporations As New List(Of Corporation) From
                    {
                        New Corporation With {.ID = 1, .Code = "SFC", .Name = "FINANCE", .FullName = "SAGA FINANCE CORPORATION", .Address = "National Highway, Sta. Isabel, Dipolog City, Zamboanga del Norte"},
                        New Corporation With {.ID = 2, .Code = "SMC", .Name = "MOTORS", .FullName = "SAGA MOTORS CORPORATION", .Address = "National Highway, Sta. Isabel, Dipolog City, Zamboanga del Norte"}
                    }

                With repositoryItemLookUpEdit
                    .Columns.Clear()
                    .Columns.AddRange(New LookUpColumnInfo() {
                                      New LookUpColumnInfo("ID"),
                                      New LookUpColumnInfo("Code", "Code"),
                                      New LookUpColumnInfo("Name", "Corporation"),
                                      New LookUpColumnInfo("FullName", "Corporation Name")})

                    If bAll Then
                        corporations.Add(New Corporation With {.ID = 0, .Code = "ALL", .Name = "CUSTOM", .FullName = "ALL/ANY SAGA CORPORATIONS", .Address = "National Highway, Sta. Isabel, Dipolog City, Zamboanga del Norte"})
                        .DropDownRows = 3
                    Else
                        .DropDownRows = 2
                    End If

                    .DataSource = corporations
                    .DisplayMember = "Name"
                    .DropDownRows = iDropDownRows
                    .NullText = String.Empty
                    .ValueMember = "Code"
                End With
                class_Procedures.Initialize_RepositoryItem(repositoryItemLookUpEdit, XtraEditors.Controls.TextEditStyles.DisableTextEditor)
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Public Sub Initialize_Voucher_Type(ByVal lookUpEdit As LookUpEdit)
            Dim vouchers As New List(Of Voucher) From
                {
                    New Voucher With {.ID = 1, .Type = "CASH_CHECK", .Description = "CASH/CHECK VOUCHER (CASH ADVANCES, DISBURSTMENTS ETC.)"},
                    New Voucher With {.ID = 2, .Type = "JOURNAL", .Description = "JOURNAL VOUCHER (LIQUIDATION, ADJUSTMENTS ETC.)"}
                }

            With lookUpEdit.Properties
                .Columns.Clear()
                .Columns.AddRange(New LookUpColumnInfo() {
                                  New LookUpColumnInfo("ID"),
                                  New LookUpColumnInfo("Type"),
                                  New LookUpColumnInfo("Description")})

                .DataSource = vouchers
                .DisplayMember = "Type"
                .ValueMember = "Type"
                .NullValuePrompt = "Select Voucher Type..."
            End With
            class_Procedures.Initialize_RepositoryItem(lookUpEdit.Properties, XtraEditors.Controls.TextEditStyles.DisableTextEditor)
        End Sub

        Public Sub Initialize_MC_Transaction_Type(ByVal lookUpEdit As LookUpEdit)
            Dim mctransactions As New List(Of MCTransaction) From
                {
                    New MCTransaction With {.ID = 1, .Transaction = "CONVERT", .Description = "CONVERT MC UNIT WAREHOUSE TO NEW MC UNIT STATUS(REPO->IREP->TEQ->EXEMPT etc.s)"},
                    New MCTransaction With {.ID = 2, .Transaction = "DEPOSIT", .Description = "DEPOSIT MC UNITS FROM OVERDUE CUSTOMERS"},
                    New MCTransaction With {.ID = 3, .Transaction = "RECEIVING", .Description = "RECEIVING MC UNITS DIRECTLY FROM DEALERS (HONDA, KAWASAKI, SUZUKI, YAMAHA etc.)"},
                    New MCTransaction With {.ID = 4, .Transaction = "TRANSFER", .Description = "TRANSFER MC UNITS FROM HEAD OFFICE TO BRANCHES OR FROM BRANCH TO BRANCH"}
                }

            With lookUpEdit.Properties
                .Columns.Clear()
                .Columns.AddRange(New LookUpColumnInfo() {
                                  New LookUpColumnInfo("ID"),
                                  New LookUpColumnInfo("Transaction"),
                                  New LookUpColumnInfo("Description")})

                .DataSource = mctransactions
                .DisplayMember = "Transaction"
                .ValueMember = "Transaction"
                .NullValuePrompt = "Select MC Transaction..."
            End With
            class_Procedures.Initialize_RepositoryItem(lookUpEdit.Properties, XtraEditors.Controls.TextEditStyles.DisableTextEditor)
        End Sub

        Public Sub Initialize_MC_Release_Type(ByVal lookUpEdit As LookUpEdit)
            Dim releaseTypes As New List(Of ReleaseType) From
                {
                    New ReleaseType With {.ID = 1, .Code = "COD", .Name = "CASH ON DELIVERY", .Description = "SPOT CASH ON DELIVERY"},
                    New ReleaseType With {.ID = 2, .Code = "ECOD", .Name = "EXTENDED COD", .Description = "EXTENDED CASH ON DELIVERY (TO BE PAID WITHIN A MONTH)"},
                    New ReleaseType With {.ID = 3, .Code = "TCOD", .Name = "TERM COD", .Description = "TERM CASH ON DELIVERY (TO BE PAID WITHIN 3 MONTHS - WITH 1% INTEREST)"},
                    New ReleaseType With {.ID = 4, .Code = "FIN", .Name = "FINANCED", .Description = "INSTALLMENT (6 TO 36 MONTHS)"}
                }

            With lookUpEdit.Properties
                .Columns.Clear()
                .Columns.AddRange(New LookUpColumnInfo() {
                                  New LookUpColumnInfo("ID"),
                                  New LookUpColumnInfo("Code"),
                                  New LookUpColumnInfo("Name"),
                                  New LookUpColumnInfo("Description")})

                .DataSource = releaseTypes
                .DisplayMember = "Name"
                .ValueMember = "Code"
                .NullValuePrompt = "Select Release Type..."
            End With
            class_Procedures.Initialize_RepositoryItem(lookUpEdit.Properties, XtraEditors.Controls.TextEditStyles.DisableTextEditor)
        End Sub

        Public Sub Initialize_Warehouse(ByVal lookUpEdit As LookUpEdit)
            Dim warehouses As New List(Of Warehouse) From
                {
                    New Warehouse With {.ID = 1, .Code = "NEW", .Category = "BRAND NEW", .Description = "BRAND NEW UNITS"},
                    New Warehouse With {.ID = 2, .Code = "DEP", .Category = "DEPOSITED", .Description = "DEPOSITED UNITS"},
                    New Warehouse With {.ID = 3, .Code = "TEQ", .Category = "TRANSPORTATION EQUIPMENT", .Description = "REPOSSESSED UNITS USED BY OPERATION PERSONNEL AS TRANSPORTATION"},
                    New Warehouse With {.ID = 4, .Code = "REP", .Category = "REPOSSESSED", .Description = "REPOSSESSED UNITS (CONVERTED FROM DEPOSITED)"},
                    New Warehouse With {.ID = 5, .Code = "IREP", .Category = "INACTIVE REPO", .Description = "REPOSSESSED UNITS (SEVERELY DAMAGED OR CANNIBALIZED)"},
                    New Warehouse With {.ID = 6, .Code = "EXEMPT", .Category = "EXEMPTED", .Description = "EXEMPTED UNITS (WITH PENDING CASES OR OTHER LEGAL ISSUES)"},
                    New Warehouse With {.ID = 7, .Code = "RETR", .Category = "RETURNED", .Description = "RETURNED MC UNITS (BRAND NEW MC UNITS RETURNED TO SUPPLIER DUE TO SEVERE DAMAGE)"}
                }

            With lookUpEdit.Properties
                .Columns.Clear()
                .Columns.AddRange(New LookUpColumnInfo() {
                                  New LookUpColumnInfo("ID"),
                                  New LookUpColumnInfo("Code"),
                                  New LookUpColumnInfo("Category"),
                                  New LookUpColumnInfo("Description")})

                .DataSource = warehouses 'class_Saga_Variables.unitStatus.Properties.DataSource
                .DisplayMember = "Category" '"whcategorydesc"
                .ValueMember = "Code" '"whcategorycode"
                .NullValuePrompt = "Select Warehouse..."
            End With
            class_Procedures.Initialize_RepositoryItem(lookUpEdit.Properties, XtraEditors.Controls.TextEditStyles.DisableTextEditor)
        End Sub

        Public Sub Initialize_Branch(ByVal barEditItem As BarEditItem, ByVal repositoryItemLookUpEdit As RepositoryItemLookUpEdit, Optional bWithPostingDate As Boolean = False)
            With barEditItem
                .EditWidth = 170
                .EditValue = class_Saga_Variables.sBranchCode
            End With

            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("BranchCode", "No."),
                New LookUpColumnInfo("Pre_Code", "Code"),
                New LookUpColumnInfo("Branch", "Branch Name"),
                New LookUpColumnInfo("DatabaseDate", "Posting Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", bWithPostingDate, DevExpress.Utils.HorzAlignment.Far),
                New LookUpColumnInfo("Cut_Off_Date", "Cut-Off Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", bWithPostingDate, DevExpress.Utils.HorzAlignment.Far),
                New LookUpColumnInfo("Back_Date_Status", "Status", -1, DevExpress.Utils.FormatType.None, "", bWithPostingDate, DevExpress.Utils.HorzAlignment.Default),
                New LookUpColumnInfo("Back_Date", "Back Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", bWithPostingDate, DevExpress.Utils.HorzAlignment.Far),
                New LookUpColumnInfo("Modified_By", "Req./Apprv. By", -1, DevExpress.Utils.FormatType.None, "", bWithPostingDate, DevExpress.Utils.HorzAlignment.Default),
                New LookUpColumnInfo("Modified_Date", "Req./Apprv. Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy hh:mm:ss", bWithPostingDate, DevExpress.Utils.HorzAlignment.Far),
                New LookUpColumnInfo("Request_Description", "Request Description", -1, DevExpress.Utils.FormatType.None, "", bWithPostingDate, DevExpress.Utils.HorzAlignment.Default)
            }
            Initialize_LookUpEdit(repositoryItemLookUpEdit, lookUpColumnInfo, class_Saga_Variables.branch.Properties.DataSource, "Branch", "BranchCode", TextEditStyles.DisableTextEditor)

            barEditItem.EditValue = class_Saga_Variables.sBranchCode
            repositoryItemLookUpEdit.DropDownRows = class_Saga_Variables.iBranchRowCount
        End Sub

        Public Sub Initialize_Branch(ByVal lookUpEdit As LookUpEdit)
            Dim sBrCode As String

            Try
                sBrCode = lookUpEdit.EditValue.ToString
            Catch ex As Exception
                sBrCode = class_Saga_Variables.sBranchCode
            End Try

            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("BranchCode", "Number"),
                New LookUpColumnInfo("Pre_Code", "Code"),
                New LookUpColumnInfo("Branch", "Branch Name")
            }
            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, class_Saga_Variables.branch.Properties.DataSource, "Branch", "BranchCode", TextEditStyles.DisableTextEditor)

            lookUpEdit.EditValue = sBrCode
            lookUpEdit.Properties.DropDownRows = class_Saga_Variables.iBranchRowCount
        End Sub

        Public Sub Initialize_Branch(ByVal repositoryItemLookUpEdit As RepositoryItemLookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("BranchCode", "Number"),
                New LookUpColumnInfo("Pre_Code", "Code"),
                New LookUpColumnInfo("Branch", "Branch Name")
            }
            Initialize_LookUpEdit(repositoryItemLookUpEdit, lookUpColumnInfo, class_Saga_Variables.branch.Properties.DataSource, "Branch", "BranchCode", TextEditStyles.DisableTextEditor)
        End Sub

        Public Sub Initialize_Agent(ByVal lookUpEdit As LookUpEdit)
            Try
                lookUpEdit.Properties.DataSource = class_Saga_Variables.agent.Properties.DataSource
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Public Sub Initialize_AE(ByVal barEditItem As BarEditItem, ByVal lookUpEdit As RepositoryItemLookUpEdit)
            barEditItem.EditWidth = 250
            Initialize_AE(lookUpEdit)
        End Sub

        Public Sub Initialize_AE(ByVal lookUpEdit As LookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("AccountExecutive", "Code"),
                New LookUpColumnInfo("OfficerName", "Name")
            }
            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, class_Saga_Variables.ae.Properties.DataSource, "OfficerName", "AccountExecutive")
        End Sub

        Public Sub Initialize_AE(ByVal repositoryItemLookUpEdit As RepositoryItemLookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("AccountExecutive", "Code"),
                New LookUpColumnInfo("OfficerName", "Name")
            }
            Initialize_LookUpEdit(repositoryItemLookUpEdit, lookUpColumnInfo, class_Saga_Variables.ae.Properties.DataSource, "OfficerName", "AccountExecutive", TextEditStyles.DisableTextEditor)
        End Sub

        Public Sub Initialize_COA(ByVal lookUpEdit As LookUpEdit, ByVal eCOAType As eCOA_Type)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("COA_Type", "Type"),
                New LookUpColumnInfo("COA_Summary_Name", "Summary"),
                New LookUpColumnInfo("COA_Code", "Code"),
                New LookUpColumnInfo("COA_Name", "Name"),
                New LookUpColumnInfo("Balance_Running", "Balance", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                New LookUpColumnInfo("Balance_Limit", "Limit", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                New LookUpColumnInfo("COA_Desc", "Description")
            }

            Select Case eCOAType
                Case eCOA_Type.COA_All
                    lookUpEdit.Properties.DataSource = class_Saga_Variables.coaAll.Properties.DataSource
                Case eCOA_Type.COA_Summary
                    lookUpEdit.Properties.DataSource = class_Saga_Variables.coaSummary.Properties.DataSource
                Case eCOA_Type.COA_Detail
                    lookUpEdit.Properties.DataSource = class_Saga_Variables.coaDetail.Properties.DataSource
                Case eCOA_Type.COA_Bank
                    lookUpEdit.Properties.DataSource = class_Saga_Variables.coaBank.Properties.DataSource
            End Select

            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, lookUpEdit.Properties.DataSource, "COA_Name", "COA_Code")
        End Sub

        Public Sub Initialize_COA(ByVal repositoryItemLookUpEdit As RepositoryItemLookUpEdit, ByVal eCOAType As eCOA_Type)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("COA_Type", "Type"),
                New LookUpColumnInfo("COA_Summary_Name", "Summary"),
                New LookUpColumnInfo("COA_Code", "Code"),
                New LookUpColumnInfo("COA_Name", "Name"),
                New LookUpColumnInfo("Balance_Running", "Balance", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                New LookUpColumnInfo("Balance_Limit", "Limit", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                New LookUpColumnInfo("COA_Desc", "Description")
            }

            Select Case eCOAType
                Case eCOA_Type.COA_All
                    repositoryItemLookUpEdit.DataSource = class_Saga_Variables.coaAll.Properties.DataSource
                Case eCOA_Type.COA_Summary
                    repositoryItemLookUpEdit.DataSource = class_Saga_Variables.coaSummary.Properties.DataSource
                Case eCOA_Type.COA_Detail
                    repositoryItemLookUpEdit.DataSource = class_Saga_Variables.coaDetail.Properties.DataSource
                Case eCOA_Type.COA_Bank
                    repositoryItemLookUpEdit.DataSource = class_Saga_Variables.coaBank.Properties.DataSource
            End Select

            Initialize_LookUpEdit(repositoryItemLookUpEdit, lookUpColumnInfo, repositoryItemLookUpEdit.DataSource, "COA_Name", "COA_Code")
        End Sub

        Public Sub Initialize_Bank(ByVal lookUpEdit As LookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("Bank_Code", "Code"),
                New LookUpColumnInfo("Bank_Account", "Bank Account"),
                New LookUpColumnInfo("Bank_Name", "Bank Name"),
                New LookUpColumnInfo("Account_Name", "Account Name")
            }
            class_Database.Bind_Data(class_Database.ICSConnection, lookUpEdit, "SELECT ID, Bank_Code, Bank_Account, Bank_Name, Account_Name FROM acc_Banks", "acc_Banks")

            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, lookUpEdit.Properties.DataSource, "Bank_Name", "Bank_Account", TextEditStyles.DisableTextEditor)
        End Sub

        Public Sub Initialize_Check(ByVal lookUpEdit As LookUpEdit, Optional ByVal sCOACode As String = "")
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("Check_Number", "Check Number"),
                New LookUpColumnInfo("Bank_Account", "Bank Account"),
                New LookUpColumnInfo("Reference", "Reference"),
                New LookUpColumnInfo("Check_Amount", "Check Amount", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                New LookUpColumnInfo("Check_Payee", "Check Payee")
            }

            If Not sCOACode.Equals("") AndAlso sCOACode.StartsWith("10101") Then
                class_Database.Bind_Data(class_Database.ICSConnection, lookUpEdit, $"SELECT ID, Check_Number, Bank_Account, Reference, Check_Amount, Check_Payee, COA_Code FROM view_Checks WHERE COA_Code LIKE '{sCOACode}' ORDER BY ID", "view_Checks")
            End If

            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, lookUpEdit.Properties.DataSource, "Check_Number", "Check_Number")
        End Sub

        Public Sub Initialize_Check(ByVal repositoryItemLookUpEdit As RepositoryItemLookUpEdit, Optional ByVal sCOACode As String = "")
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("Check_Number", "Check Number"),
                New LookUpColumnInfo("Bank_Account", "Bank Account"),
                New LookUpColumnInfo("Reference", "Reference"),
                New LookUpColumnInfo("Check_Amount", "Check Amount", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                New LookUpColumnInfo("Check_Payee", "Check Payee")
            }

            If Not sCOACode.Equals(Nothing) AndAlso sCOACode.StartsWith("10101") Then
                class_Database.Bind_Data(class_Database.ICSConnection, repositoryItemLookUpEdit, $"SELECT ID, Check_Number, Bank_Account, Reference, Check_Amount, Check_Payee, COA_Code FROM view_Checks WHERE COA_Code LIKE '{sCOACode}' ORDER BY ID", "view_Checks")
            End If

            Initialize_LookUpEdit(repositoryItemLookUpEdit, lookUpColumnInfo, repositoryItemLookUpEdit.DataSource, "Check_Number", "Check_Number")
        End Sub

        Public Sub Initialize_Budget(ByVal lookUpEdit As LookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("Budget_Code", "Code"),
                New LookUpColumnInfo("Budget_Name", "Name"),
                New LookUpColumnInfo("Budget_Amount", "Amount", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                New LookUpColumnInfo("Budget_Balance", "Balance", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                New LookUpColumnInfo("Budget_Description", "Description")
            }
            class_Database.Bind_Data(class_Database.ICSConnection, lookUpEdit, $"SELECT * FROM acc_Budgets ORDER BY ID", "acc_Budgets")

            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, lookUpEdit.Properties.DataSource, "Budget_Name", "Budget_Code")
        End Sub

        Public Sub Initialize_For_Liquidation(ByVal lookUpEdit As LookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("Voucher_Reference", "Reference"),
                New LookUpColumnInfo("Expense_Type", "Profile"),
                New LookUpColumnInfo("Voucher_Date_Posted", "Posted", -1, DevExpress.Utils.FormatType.DateTime, "MMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                New LookUpColumnInfo("Liquidation_Days", "Days"),
                New LookUpColumnInfo("Liquidation_Date_Expiry", "Expiry", -1, DevExpress.Utils.FormatType.DateTime, "MMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                New LookUpColumnInfo("Voucher_Credit", "Credit", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                New LookUpColumnInfo("Voucher_Description", "Description")
            }
            class_Database.Bind_Data(class_Database.ICSConnection, lookUpEdit, $"SELECT * FROM view_Vouchers WHERE IsForLiquidation = '1' ORDER BY ID", "view_Vouchers")

            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, lookUpEdit.Properties.DataSource, "Voucher_Reference", "Voucher_Reference")
        End Sub

        Public Sub Initialize_Journal_Profile(ByVal lookUpEdit As LookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("Profile_Code", "Code"),
                New LookUpColumnInfo("Journal_Type", "Category"),
                New LookUpColumnInfo("Friendly_Name", "Sub-Category"),
                New LookUpColumnInfo("Profile_Description", "Description")
            }
            class_Database.Bind_Data(class_Database.ICSConnection, lookUpEdit, "SELECT ID, Profile_Code, Journal_Type, Friendly_Name, Profile_Description, Profile_Type FROM acc_Journal_Profiles WHERE Profile_Type LIKE 'PETTY_CASH' ORDER BY Friendly_Name", "acc_Journal_Profiles")

            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, lookUpEdit.Properties.DataSource, "Friendly_Name", "Profile_Code")
        End Sub

        Public Sub Initialize_For_Liquidation(ByVal searchLookUpEdit As SearchLookUpEdit, ByVal gridView As GridView)
            With gridView
                .Columns.Clear()
                Dim colID As New GridColumn
                Dim colExpense_Type As New GridColumn
                Dim colVoucher_Reference As New GridColumn
                Dim colAccount_Name As New GridColumn
                Dim colVoucher_Debit As New GridColumn
                Dim colVoucher_Date_Posted As New GridColumn
                Dim colLiquidation_Days As New GridColumn
                Dim colLiquidation_Date_Expiry As New GridColumn
                Dim colVoucher_Description As New GridColumn

                With colID
                    .Caption = "ID"
                    .FieldName = "ID"
                    .Visible = True
                End With

                With colExpense_Type
                    .Caption = "Profile"
                    .FieldName = "Expense_Type"
                    .Visible = True
                End With

                With colVoucher_Reference
                    .Caption = "Reference"
                    .FieldName = "Voucher_Reference"
                    .Visible = True
                End With

                With colAccount_Name
                    .Caption = "Name"
                    .FieldName = "Account_Name"
                    .Visible = True
                End With

                With colVoucher_Debit
                    .Caption = "Debit"
                    .DisplayFormat.FormatString = "N2"
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .FieldName = "Voucher_Debit"
                    .Visible = True
                End With

                With colVoucher_Date_Posted
                    .AppearanceCell.Options.UseTextOptions = True
                    .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    .Caption = "Date Posted"
                    .DisplayFormat.FormatString = "MMM dd, yyyy"
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    .FieldName = "Voucher_Date_Posted"
                    .Visible = True
                End With

                With colLiquidation_Days
                    .Caption = "Days"
                    .FieldName = "Liquidation_Days"
                    .Visible = True
                End With

                With colLiquidation_Date_Expiry
                    .AppearanceCell.Options.UseTextOptions = True
                    .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    .Caption = "Expiry Date"
                    .DisplayFormat.FormatString = "MMM dd, yyyy"
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    .FieldName = "Liquidation_Date_Expiry"
                    .Visible = True
                End With

                With colVoucher_Description
                    .Caption = "Description"
                    .FieldName = "Voucher_Description"
                    .Visible = True
                End With

                .Columns.AddRange(New GridColumn() {colID, colExpense_Type, colVoucher_Reference, colAccount_Name, colVoucher_Debit, colVoucher_Date_Posted, colLiquidation_Days, colLiquidation_Date_Expiry, colVoucher_Description})

                .FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
                .OptionsSelection.EnableAppearanceFocusedCell = False
                .OptionsView.ShowGroupPanel = False
            End With

            With searchLookUpEdit.Properties
                .DataSource = class_Saga_Variables.forliquidation.Properties.DataSource
                .DisplayMember = "Voucher_Reference"
                .ValueMember = "Voucher_Reference"
                .NullValuePrompt = "Select Monitored Voucher..."

                .BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                .ImmediatePopup = True
                .PopupFilterMode = PopupFilterMode.Contains
                .PopupWidthMode = PopupWidthMode.ContentWidth
            End With
        End Sub

        'Public Sub Initialize_Liquidation(ByVal lookUpEdit As LookUpEdit)
        '    Dim lookUpColumnInfo As LookUpColumnInfo() = {
        '        New LookUpColumnInfo("Journal_Reference", "Reference"),
        '        New LookUpColumnInfo("Posting_Date", "Posted", -1, DevExpress.Utils.FormatType.DateTime, "MMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
        '        New LookUpColumnInfo("Account_Name", "Name"),
        '        New LookUpColumnInfo("Journal_Credit", "Credit", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
        '        New LookUpColumnInfo("Journal_Description", "Description")
        '    }
        '    class_Database.Bind_Data(class_Database.ICSConnection, lookUpEdit, $"SELECT DISTINCT Journal_Reference, MIN(ID) AS ID, MIN(Posting_Date) AS Posting_Date, MIN(Account_Name) AS Account_Name, SUM(Journal_Credit) AS Journal_Credit, MIN(Journal_Description) AS Journal_Description FROM acc_Journal_Entries WHERE Journal_Type LIKE 'JOURNAL_ENTRY' AND Journal_Profile LIKE '%LIQUID%' GROUP BY Journal_Reference ORDER BY ID", "acc_Journal_Entries")

        '    Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, lookUpEdit.Properties.DataSource, "Journal_Reference", "Journal_Reference")
        'End Sub

        Public Sub Initialize_Liquidation(ByVal searchLookUpEdit As SearchLookUpEdit, ByVal gridView As GridView)
            With gridView
                .Columns.Clear()
                Dim colID As New GridColumn
                Dim colJournal_Reference As New GridColumn
                Dim colPosting_Date As New GridColumn
                Dim colAccount_Name As New GridColumn
                Dim colJournal_Credit As New GridColumn
                Dim colJournal_Description As New GridColumn

                With colID
                    .Caption = "ID"
                    .FieldName = "ID"
                    .Visible = True
                End With

                With colJournal_Reference
                    .Caption = "Reference"
                    .FieldName = "Journal_Reference"
                    .Visible = True
                End With

                With colPosting_Date
                    .AppearanceCell.Options.UseTextOptions = True
                    .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    .Caption = "Date Posted"
                    .DisplayFormat.FormatString = "MMM dd, yyyy"
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    .FieldName = "Posting_Date"
                    .Visible = True
                End With

                With colAccount_Name
                    .Caption = "Name"
                    .FieldName = "Account_Name"
                    .Visible = True
                End With

                With colJournal_Credit
                    .Caption = "Credit"
                    .DisplayFormat.FormatString = "N2"
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .FieldName = "Journal_Credit"
                    .Visible = True
                End With

                With colJournal_Description
                    .Caption = "Description"
                    .FieldName = "Journal_Description"
                    .Visible = True
                End With

                .Columns.AddRange(New GridColumn() {colID, colJournal_Reference, colPosting_Date, colAccount_Name, colJournal_Credit, colJournal_Description})

                .FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
                .OptionsSelection.EnableAppearanceFocusedCell = False
                .OptionsView.ShowGroupPanel = False
            End With

            With searchLookUpEdit.Properties
                .DataSource = class_Saga_Variables.liquidation.Properties.DataSource
                .DisplayMember = "Journal_Reference"
                .ValueMember = "Journal_Reference"
                .NullValuePrompt = "Select Liquidation..."

                .BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                .ImmediatePopup = True
                .PopupFilterMode = PopupFilterMode.Contains
                .PopupWidthMode = PopupWidthMode.ContentWidth
            End With
        End Sub

        Public Sub Initialize_Engine_Chassis(ByVal lookUpEdit As LookUpEdit, Optional ByVal sWHCode As String = "TEQ")
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("EngineNo", "Engine"),
                New LookUpColumnInfo("ChassisNo", "Chassis"),
                New LookUpColumnInfo("Brand"),
                New LookUpColumnInfo("Description")
            }
            class_Database.Bind_Data(class_Database.ICSConnection, lookUpEdit, $"SELECT ID, IfExist, EngineNo, ChassisNo, Brand, Description FROM item_Details WHERE IfExist = 1 AND whCode LIKE '{sWHCode}'", "item_Details")

            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, lookUpEdit.Properties.DataSource, "EngineNo", "EngineNo")
        End Sub

        Public Sub Initialize_Engine_Received(ByVal lookUpEdit As LookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("EngineNo", "Engine"),
                New LookUpColumnInfo("ChassisNo", "Chassis"),
                New LookUpColumnInfo("Brand", "Brand"),
                New LookUpColumnInfo("Model", "Model"),
                New LookUpColumnInfo("Color", "Color")
            }
            class_Database.Bind_Data(class_Database.ICSConnection, lookUpEdit, "SELECT ID, EngineNo, ChassisNo, Brand, Model, Color FROM item_Details WHERE SourceEvent LIKE 'RECEIVING' AND inventoryStatus LIKE 'APPROVED' ORDER BY id", "item_Details")

            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, lookUpEdit.Properties.DataSource, "EngineNo", "EngineNo")
        End Sub

        Public Sub Initialize_Employee(ByVal lookUpEdit As LookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("Employee_Code", "Code"),
                New LookUpColumnInfo("Employee_Name", "Name", -1, DevExpress.Utils.FormatType.None, String.Empty, True, DevExpress.Utils.HorzAlignment.Default, Data.ColumnSortOrder.Ascending),
                New LookUpColumnInfo("Employee_Position", "Designation"),
                New LookUpColumnInfo("Engine", "Engine", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default, Data.ColumnSortOrder.None)
            }
            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, class_Saga_Variables.employee.Properties.DataSource, "Employee_Name", "Employee_Code")
        End Sub

        Public Sub Initialize_Employee(ByVal repositoryItemLookUpEdit As RepositoryItemLookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("Employee_Code", "Code"),
                New LookUpColumnInfo("Employee_Name", "Name", -1, DevExpress.Utils.FormatType.None, String.Empty, True, DevExpress.Utils.HorzAlignment.Default, Data.ColumnSortOrder.Ascending),
                New LookUpColumnInfo("Employee_Position", "Designation"),
                New LookUpColumnInfo("Engine", "Engine", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default, Data.ColumnSortOrder.None)
            }
            Initialize_LookUpEdit(repositoryItemLookUpEdit, lookUpColumnInfo, class_Saga_Variables.employee.Properties.DataSource, "Employee_Name", "Employee_Code")
        End Sub

        Public Sub Initialize_Adjustment(ByVal repositoryItemLookUpEdit As RepositoryItemLookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("Adjust_Category", "Category"),
                New LookUpColumnInfo("Adjust_Type", "Type"),
                New LookUpColumnInfo("Is_15th", "15th"),
                New LookUpColumnInfo("Is_30th", "30th"),
                New LookUpColumnInfo("Adjust_Name", "Name"),
                New LookUpColumnInfo("Adjust_Description", "Description")
            }
            class_Database.Bind_Data(class_Database.ICSConnection, repositoryItemLookUpEdit, "SELECT * FROM hr_Adjustments", "hr_Adjustments")

            Initialize_LookUpEdit(repositoryItemLookUpEdit, lookUpColumnInfo, repositoryItemLookUpEdit.DataSource, "Adjust_Name", "Adjust_Code")
        End Sub

        Public Sub Initialize_User(ByVal lookUpEdit As LookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("username", "User", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                New LookUpColumnInfo("fullname", "Name")
            }
            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, class_Saga_Variables.user.Properties.DataSource, "fullname", "username")
        End Sub

        Public Sub Initialize_Brand(ByVal lookUpEdit As LookUpEdit, Optional ByVal sValueMember As String = "Brand_Code", Optional ByVal sDisplayMember As String = "branddesc")
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("id", "ID", -1, DevExpress.Utils.FormatType.None, String.Empty, True, DevExpress.Utils.HorzAlignment.Default, Data.ColumnSortOrder.Ascending),
                New LookUpColumnInfo("Brand_Code", "Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                New LookUpColumnInfo("branddesc", "Brand"),
                New LookUpColumnInfo("Account_Code", "Account Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                New LookUpColumnInfo("Account_Name", "Supplier"),
                New LookUpColumnInfo("Account_Mobile", "Contact Number(s)", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                New LookUpColumnInfo("Account_Address", "Address"),
                New LookUpColumnInfo("Account_Description", "Description")
            }
            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, class_Saga_Variables.brand.Properties.DataSource, sDisplayMember, sValueMember, TextEditStyles.DisableTextEditor)
        End Sub

        Public Sub Initialize_Brand(ByVal repositoryItemLookUpEdit As RepositoryItemLookUpEdit, Optional ByVal sValueMember As String = "Brand_Code", Optional ByVal sDisplayMember As String = "branddesc")
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("id", "ID", -1, DevExpress.Utils.FormatType.None, String.Empty, True, DevExpress.Utils.HorzAlignment.Default, Data.ColumnSortOrder.Ascending),
                New LookUpColumnInfo("Brand_Code", "Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                New LookUpColumnInfo("branddesc", "Brand"),
                New LookUpColumnInfo("Account_Code", "Account Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                New LookUpColumnInfo("Account_Name", "Supplier"),
                New LookUpColumnInfo("Account_Mobile", "Contact Number(s)", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                New LookUpColumnInfo("Account_Address", "Address"),
                New LookUpColumnInfo("Account_Description", "Description")
            }
            Initialize_LookUpEdit(repositoryItemLookUpEdit, lookUpColumnInfo, class_Saga_Variables.brand.Properties.DataSource, sDisplayMember, sValueMember, TextEditStyles.DisableTextEditor)
        End Sub

        Public Sub Initialize_Purchase_Order(ByVal lookUpEdit As LookUpEdit, ByVal sBrand As String)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("Order_Code"),
                New LookUpColumnInfo("Brand_Name", "Brand"),
                New LookUpColumnInfo("Account_Name", "Supplier"),
                New LookUpColumnInfo("Purchase_Order_Code", "Supplier P.O."),
                New LookUpColumnInfo("Order_Date", "P. O. Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far),
                New LookUpColumnInfo("Total_Quantity", "Quantity"),
                New LookUpColumnInfo("Total_Received", "Received"),
                New LookUpColumnInfo("Total_Remaining", "Remaining"),
                New LookUpColumnInfo("Order_Description", "Description")
            }
            class_Database.Bind_Data(class_Database.ICSConnection, lookUpEdit, $"SELECT * FROM view_Purchase_Orders WHERE Brand_Name LIKE '{sBrand}' AND IsApproved = 1 ORDER BY ID DESC", "view_Purchase_Orders")

            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, lookUpEdit.Properties.DataSource, "Order_Code", "Order_Code")
        End Sub

        Public Sub Initialize_MC_Request(ByVal lookUpEdit As LookUpEdit, ByVal sBrFrom As String, ByVal sBrTo As String)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("Request_Code"),
                New LookUpColumnInfo("Branch"),
                New LookUpColumnInfo("WHCode", "Category"),
                New LookUpColumnInfo("Quantity", "Quantity"),
                New LookUpColumnInfo("Added_Date", "Request Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far),
                New LookUpColumnInfo("Request_Description", "Description"),
                New LookUpColumnInfo("Notes", "Notes")
            }

            Dim sql As String = "SELECT REQ.ID AS ID, " +
                                    "REQ.Request_Code As Request_Code, " +
                                    "BRN.Branch_Local AS Branch, " +
                                    "REQ.WHCode As WHCode, " +
                                    "REQ.Quantity AS Quantity, " +
                                    "REQ.Added_Date As Added_Date, " +
                                    "REQ.Request_Description AS Request_Description, " +
                                    "REQ.Notes AS Notes " +
                                "FROM inv_MC_Requests As REQ INNER Join BranchParameters As BRN " +
                                                            "ON REQ.Branch_Code = BRN.BranchCode " +
                                "WHERE Request_Status Like 'APPROVED'  " +
                                    $"AND Supplier_Code Like '{sBrFrom}'  " +
                                    $"AND Branch_Code Like '{sBrTo}'  " +
                                "ORDER BY ID DESC"

            class_Database.Bind_Data(class_Database.ICSConnection, lookUpEdit, sql, "inv_MC_Requests")

            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, lookUpEdit.Properties.DataSource, "Request_Code", "Request_Code")
        End Sub

        Public Sub Initialize_MC_Model(ByVal lookUpEdit As LookUpEdit, Optional ByVal sMember As String = "Model_Code")
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("id", "ID"),
                New LookUpColumnInfo("Model_Code", "Code"),
                New LookUpColumnInfo("branddesc", "Brand", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                New LookUpColumnInfo("Model", "Model"),
                New LookUpColumnInfo("modeldesc", "Sub-Model"),
                New LookUpColumnInfo("Color", "Color"),
                New LookUpColumnInfo("Custom_Color", "Custom"),
                New LookUpColumnInfo("Unit_Cost", "Cost", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                New LookUpColumnInfo("Description", "Description")
            }
            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, class_Saga_Variables.mcModel.Properties.DataSource, sMember, sMember)
        End Sub

        Public Sub Initialize_MC_Model(ByVal repositoryItemLookUpEdit As RepositoryItemLookUpEdit, Optional ByVal sMember As String = "Model_Code")
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("id", "ID"),
                New LookUpColumnInfo("Model_Code", "Code"),
                New LookUpColumnInfo("branddesc", "Brand", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                New LookUpColumnInfo("Model", "Model"),
                New LookUpColumnInfo("modeldesc", "Sub-Model"),
                New LookUpColumnInfo("Color", "Color"),
                New LookUpColumnInfo("Custom_Color", "Custom"),
                New LookUpColumnInfo("Unit_Cost", "Cost", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                New LookUpColumnInfo("Description", "Description")
            }
            Initialize_LookUpEdit(repositoryItemLookUpEdit, lookUpColumnInfo, class_Saga_Variables.mcModel.Properties.DataSource, sMember, sMember)
        End Sub

        'Public Sub Initialize_Model_Color(ByVal repositoryItemLookUpEdit As RepositoryItemLookUpEdit)
        '    With repositoryItemLookUpEdit
        '        .Columns.Clear()
        '        .Columns.AddRange(New LookUpColumnInfo() {
        '                          New LookUpColumnInfo("ID"),
        '                          New LookUpColumnInfo("Color_Code", String.Empty, -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
        '                          New LookUpColumnInfo("Color_Index", "Index"),
        '                          New LookUpColumnInfo("Color", "Dominant"),
        '                          New LookUpColumnInfo("colordesc", "Color"),
        '                          New LookUpColumnInfo("PNP_LTO_Input", "LTO Input"),
        '                          New LookUpColumnInfo("Color_Description", "Description")})

        '        .DataSource = class_Saga_Variables.mcColor.Properties.DataSource
        '        .DisplayMember = "colordesc"
        '        .ValueMember = "colordesc"
        '        .NullValuePrompt = "Select Color..."
        '    End With
        '    class_Procedures.Initialize_RepositoryItem(repositoryItemLookUpEdit)
        'End Sub

        Public Sub Initialize_MC_Units(ByVal lookUpEdit As LookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("WHCode", "Status"),
                New LookUpColumnInfo("Model_Code", "Code"),
                New LookUpColumnInfo("EngineNo", "Engine"),
                New LookUpColumnInfo("ChassisNo", "Chassis"),
                New LookUpColumnInfo("Brand"),
                New LookUpColumnInfo("Model", "Model", -1, DevExpress.Utils.FormatType.None, String.Empty, True, DevExpress.Utils.HorzAlignment.Default, Data.ColumnSortOrder.Ascending),
                New LookUpColumnInfo("Color"),
                New LookUpColumnInfo("Note", "Notes")
            }
            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, class_Saga_Variables.mcUnit.Properties.DataSource, "EngineNo", "EngineNo")
        End Sub

        Public Sub Initialize_MC_Units(ByVal repositoryItemLookUpEdit As RepositoryItemLookUpEdit, ByVal sDisplayValue As String)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("WHCode", "Status"),
                New LookUpColumnInfo("Model_Code", "Code"),
                New LookUpColumnInfo("EngineNo", "Engine"),
                New LookUpColumnInfo("ChassisNo", "Chassis"),
                New LookUpColumnInfo("Brand"),
                New LookUpColumnInfo("Model", "Model", -1, DevExpress.Utils.FormatType.None, String.Empty, True, DevExpress.Utils.HorzAlignment.Default, Data.ColumnSortOrder.Ascending),
                New LookUpColumnInfo("Color"),
                New LookUpColumnInfo("Note", "Notes")
            }
            Initialize_LookUpEdit(repositoryItemLookUpEdit, lookUpColumnInfo, class_Saga_Variables.mcUnit.Properties.DataSource, sDisplayValue, sDisplayValue)
        End Sub

        Public Sub Initialize_Inclusions(ByVal lookUpEdit As LookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("Inclusion_Code", "Code"),
                New LookUpColumnInfo("Inclusion_Type", "Type"),
                New LookUpColumnInfo("Inclusion_Name", "Name"),
                New LookUpColumnInfo("Description"),
                New LookUpColumnInfo("Notes")
            }
            class_Database.Bind_Data(class_Database.ICSConnection, lookUpEdit, $"SELECT * FROM inv_Inclusions", "inv_Inclusions")

            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, lookUpEdit.Properties.DataSource, "Inclusion_Name", "Inclusion_Code")
        End Sub

        Public Sub Initialize_Asset_Items(ByVal lookUpEdit As LookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("Inclusion_Code", "Code"),
                New LookUpColumnInfo("Inclusion_Type", "Type"),
                New LookUpColumnInfo("Inclusion_Name", "Name"),
                New LookUpColumnInfo("Description"),
                New LookUpColumnInfo("Notes")
            }
            class_Database.Bind_Data(class_Database.ICSConnection, lookUpEdit, $"SELECT * FROM inv_Asset_Items", "inv_Asset_Items")

            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, lookUpEdit.Properties.DataSource, "Asset_Name", "Asset_Code")
        End Sub

        Public Sub Initialize_Asset_Items(ByVal repositoryItemLookUpEdit As RepositoryItemLookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("Inclusion_Code", "Code"),
                New LookUpColumnInfo("Inclusion_Type", "Type"),
                New LookUpColumnInfo("Inclusion_Name", "Name"),
                New LookUpColumnInfo("Description"),
                New LookUpColumnInfo("Notes")
            }
            class_Database.Bind_Data(class_Database.ICSConnection, repositoryItemLookUpEdit, $"SELECT * FROM inv_Asset_Items", "inv_Asset_Items")

            Initialize_LookUpEdit(repositoryItemLookUpEdit, lookUpColumnInfo, repositoryItemLookUpEdit.DataSource, "Asset_Name", "Asset_Code")
        End Sub

        Public Sub Initialize_MC_Promotions(ByVal lookUpEdit As LookUpEdit)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("Promo_Code", "Code"),
                New LookUpColumnInfo("Promo_Type", "Type"),
                New LookUpColumnInfo("Brand", "Brand"),
                New LookUpColumnInfo("Promo_Start", "Start", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far),
                New LookUpColumnInfo("Promo_End", "End", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far),
                New LookUpColumnInfo("Discount", "Discount", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                New LookUpColumnInfo("Promo_Name", "Name"),
                New LookUpColumnInfo("Promo_Description", "Description"),
                New LookUpColumnInfo("Notes")
            }
            class_Database.Bind_Data(class_Database.ICSConnection, lookUpEdit, $"SELECT * FROM acc_MC_Promotions", "acc_MC_Promotions")

            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, lookUpEdit.Properties.DataSource, "Promo_Name", "Promo_Code")
        End Sub

        Public Sub Initialize_MC_Freebies(ByVal repositoryItemLookUpEdit As RepositoryItemLookUpEdit, ByVal sBrCode As String)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("Brand"),
                New LookUpColumnInfo("PartsNumber", "SKU / Code"),
                New LookUpColumnInfo("PartsName", "Name"),
                New LookUpColumnInfo("SRP", "Price", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                New LookUpColumnInfo("Quantity"),
                New LookUpColumnInfo("Category")
            }
            If class_Database.OpenDB(class_Database.SPAConnection) Then
                class_Database.Bind_Data(class_Database.SPAConnection, repositoryItemLookUpEdit, $"SELECT DISTINCT (PartsNumber), ID, Brand, Category, PartsName, Quantity, SRP FROM Spare_Parts.dbo.SPA_Inventory WHERE Category LIKE 'FREE%' AND ReceivingBranch LIKE '{sBrCode}'", "Spare_Parts.dbo.SPA_Inventory")
            End If

            Initialize_LookUpEdit(repositoryItemLookUpEdit, lookUpColumnInfo, repositoryItemLookUpEdit.DataSource, "PartsNumber", "PartsNumber")
        End Sub

        Public Sub Initialize_IBP_Transactions(ByVal lookUpEdit As LookUpEdit, ByVal sBrCode As String)
            Dim lookUpColumnInfo As LookUpColumnInfo() = {
                New LookUpColumnInfo("ID"),
                New LookUpColumnInfo("ORNumber", "Reference"),
                New LookUpColumnInfo("AmountDue", "Received", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                New LookUpColumnInfo("PostingDate", "Posting Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far),
                New LookUpColumnInfo("TransactionDate", "Transaction Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far),
                New LookUpColumnInfo("BranchAccountNumberCust", "Account"),
                New LookUpColumnInfo("LedgerSetnumberCust", "Ledger"),
                New LookUpColumnInfo("AccountName", "Name"),
                New LookUpColumnInfo("Description", "Description")
            }
            class_Database.Bind_Data(class_Database.ICSConnection, lookUpEdit, $"SELECT * FROM TransactionOtherCash WHERE PostingDate >= CONVERT(VARCHAR(10), '{class_Saga_Variables.dtStart}', 23) AND PostingDate <= CONVERT(VARCHAR(10), '{class_Saga_Variables.dtEnd}', 23) AND BranchCodeCust LIKE '{sBrCode}' AND Mnemonic LIKE 'INTPAY'", "TransactionOtherCash")

            Initialize_LookUpEdit(lookUpEdit, lookUpColumnInfo, lookUpEdit.Properties.DataSource, "ORNumber", "ORNumber")
        End Sub

        Public Function Show_Login(ByVal sTitle As String) As Boolean
            Dim frm As New Forms.Security.frm_Login With {
                .Text = $"Login - {sTitle}"
            }
            class_Procedures.show_SplashScreen("Application Login")
            frm.ShowDialog()
            class_Procedures.splash_Close()
            Return class_Saga_Variables.bIsLogged_In
        End Function

        Public Function Show_Password_Change(ByVal sCorporation As String, ByVal sUserName As String, ByVal bNeedOldPassword As Boolean) As Boolean
            If Not class_Saga_Variables.bIsLogged_In AndAlso bNeedOldPassword Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "You cannot change your password if you're not logged in.", "Change Password Error", True)
                Return False
            End If

            Dim frm As New Forms.Security.frm_Password_Change With {
                .TopMost = True,
                .Text = $"{ .Text} - {sUserName}",
                .sCorporation = sCorporation,
                .sUserName = sUserName,
                .bNeedOldPassword = bNeedOldPassword
            }
            Return frm.ShowDialog()

        End Function

        Public Function Show_Server_Connection(Optional ByVal sCaption As String = "SQL Connection") As Boolean
            Dim frm As New Forms.Security.frm_Connection() With {
            .TopMost = True
        }
            class_Procedures.splash_Show("showing SQL Server Connection Form", sCaption)
            frm.ShowDialog()
            If class_Database.DBError Then
                frm.Text = $"{sCaption} Error"
            Else
                frm.Text = sCaption
            End If
            frm.xuc_SQL_Connection.registry_Load()
            class_Procedures.splash_Close()

            Return class_Database.OpenDB(class_Database.ICSConnection)
        End Function

        Public Function Refresh_Connection() As Boolean
            If Not class_Connections.is_Network_Adapter_OK() Then Return False
            class_Procedures.splash_Show("re-establishing server connection")

            If class_Database.OpenDB(class_Database.ICSConnection) Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, class_Database.ICSConnectionTemp)
                class_Procedures.splash_Close()
                Return True
            Else
                class_Procedures.Set_Message(class_Procedures.MsgMode.Sql, "Server connection was not successful. Please check your internet connection or the connection parameters.")
                class_Procedures.splash_Close()
                Return False
            End If
        End Function

        Public Sub Verify_Journal_Entries(ByVal sTable As String, ByVal gridView As GridView, ByVal colBranchCode As GridColumn, ByVal branchCode As RepositoryItemLookUpEdit, ByVal colTableID As GridColumn, ByVal colReference As GridColumn, ByVal colNotes As GridColumn, ByVal bTotalDebitCredit As Boolean, ByVal colTotal As GridColumn, Optional ByVal iLoopActionMode As Integer = 0, Optional ByVal bAccountCodeAsReference As Boolean = False)
            With gridView
                If .SelectedRowsCount > 0 Then
                    class_Procedures.splash_Show($"updating IsJournal Transactions of the selected {sTable}")

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    class_Saga_Variables.bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        Try
                            Select Case iLoopActionMode
                                Case 1
                                    If Not Convert.ToBoolean(.GetRowCellValue(iRowHandle, "IsJournal")) Then Continue For
                                Case 2
                                    If Convert.ToBoolean(.GetRowCellValue(iRowHandle, "IsJournal")) Then Continue For
                            End Select
                        Catch ex As Exception

                        End Try

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal Entry Verification", "verified", class_Saga_Variables.bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim iTableID As Integer
                        Try
                            iTableID = Convert.ToInt32(.GetRowCellValue(iRowHandle, colTableID))
                        Catch ex As Exception
                            Continue For
                        End Try

                        Dim sReference As String = .GetRowCellDisplayText(iRowHandle, colReference).Trim()

                        Try
                            Dim sBrCode As String = branchCode.GetKeyValueByDisplayText(.GetRowCellDisplayText(iRowHandle, colBranchCode.FieldName))
                        Catch ex As Exception
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"{iTableID}{Environment.NewLine}{ex.Source}{Environment.NewLine}{ex.Message}")
                        End Try

                        Try
                            class_Saga_Database.Verify_Transaction(sTable, gridView, colNotes, iRowHandle, iTableID, sReference, Convert.ToDecimal(.GetRowCellValue(iRowHandle, colTotal)), colTableID.FieldName, bAccountCodeAsReference)
                        Catch ex As Exception
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Sql, $"{iTableID}{Environment.NewLine}{ex.Source}{Environment.NewLine}{ex.Message}")
                            class_Saga_Variables.bLoopStop = True
                        End Try
                    Next
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"IsJOurnal Transactions of the selected {sTable} were Updated.", "IsJournal Update")
                    class_Procedures.splash_Close()
                End If
            End With
        End Sub

        Public Sub Show_Account_Executive(ByVal sCode As String)
            class_Procedures.splash_Show("Account Executive")
            Dim frm As New Forms.Persons.frm_Account_Executive() With {
            .Text = $"{ .Text} - {sCode}"
        }

            With frm
                .Show()
                .xuc_Account_Executive.Control_Initialize()
                .xuc_Account_Executive.Control_Retrieve(sCode)
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Agent(ByVal sCode As String)
            class_Procedures.splash_Show("Agent Information")
            Dim frm As New Forms.Persons.frm_Agent() With {
            .Text = $"{ .Text} - {sCode}"
        }

            With frm
                .xuc_Agent.Control_Initialize()
                .xuc_Agent.Control_Retrieve(sCode)
                .Show()
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Unit_Model(ByVal sCode As String)
            class_Procedures.splash_Show("Unit Information")
            Dim frm As New Forms.Information.Item.frm_Unit_Model() With {
            .Text = $"{ .Text} - {sCode}"
        }

            With frm
                .xuc_Item.Control_Initialize()
                .xuc_Item.Control_Retrieve(sCode)
                .Show()
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_MC_Order_Units(ByVal sCode As String, ByVal sStatus As String, Optional ByVal bAllBrand As Boolean = True, Optional ByVal sBrand As String = "HONDA", Optional ByVal dFreightCost As Decimal = 0, Optional ByVal bPerUnit As Boolean = False)
            class_Procedures.splash_Show("MC Order Units")
            Dim frm As New Forms.Logistics.frm_MC_Orders() With {
            .Text = $"{ .Text} - {sCode}"
        }
            frm.Show()

            With frm.xuc_Purchase_Order_Units
                .OrderCode = sCode
                .Status = sStatus
                .AllBrand = bAllBrand
                .Brand = sBrand
                .FreightCost = dFreightCost
                .PerUnit = bPerUnit

                .Load_MC_Orders()
            End With
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_MC_Transfer_Units(ByVal sTransactionType As String, ByVal sTransactionCode As String, ByVal sOrderCode As String, ByVal sReference As String, ByVal sBranchFrom As String, ByVal sBranchFromName As String, ByVal sBranchTo As String, ByVal sWHCode As String, ByVal dtTransactionDate As Date, ByVal sStatus As String)
            class_Procedures.splash_Show("MC Receive/Transfer/Deposit Units")
            Dim frm As New Forms.Logistics.frm_MC_Transfers() With {
            .Text = $"{ .Text} - {sTransactionType} - {sTransactionCode} - {sReference}"
        }
            frm.Show()

            With frm.xuc_MC_Transaction_Units
                .Control_Initialize()
                .TransactionType = sTransactionType
                .TransactionCode = sTransactionCode
                .OrderCode = sOrderCode
                .Reference = sReference
                .BranchFrom = sBranchFrom
                .BranchFromName = sBranchFromName
                .BranchTo = sBranchTo
                .WHCode = sWHCode
                .TransactionDate = dtTransactionDate
                .Status = sStatus

                .Initialize_MC_Units(sBranchFrom)
                .Load_MC_Units()
            End With
            class_Procedures.splash_Close()
        End Sub

        'Public Sub Show_Unit_Inventory(ByVal sCode As String, Optional ByVal bUpdate As Boolean = False, Optional ByVal sTitle As String = "Unit Inventory")
        '    class_Procedures.splash_Show("Unit Inventory")
        '    Dim frm As Forms.Logistics.frm_Unit_Inventory = New Forms.Logistics.frm_Unit_Inventory With {.Text = $"{ .Text} {sTitle}"}
        '    frm.Show()

        '    frm.btn_Generate.Enabled = bUpdate
        '    frm.btn_Delete.Enabled = bUpdate

        '    frm.BarEditItem_Search.EditValue = sCode
        '    frm.Load_Search(sCode)
        '    class_Procedures.splash_Close()
        'End Sub

        Public Sub Show_Unit_Inventory(ByVal sCode As String, Optional ByVal bReference As Boolean = False, Optional ByVal bUpdate As Boolean = False, Optional ByVal sTitle As String = "Unit Inventory")
            class_Procedures.splash_Show("Unit Inventory")
            Dim frm As New Forms.Logistics.frm_Unit_Inventory With {.Text = $"{ .Text} {sTitle}"}
            frm.Show()

            frm.btn_Generate.Enabled = bUpdate
            frm.btn_Delete.Enabled = bUpdate

            frm.BarEditItem_Search.EditValue = sCode
            frm.Load_Search(sCode, bReference)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Unit_Inventory(ByVal sQuery As String, ByVal sTitle As String)
            class_Procedures.splash_Show("Unit Inventory")
            Dim frm As New Forms.Logistics.frm_Unit_Inventory With {.Text = sTitle}
            frm.Show()
            frm.btn_Generate.Enabled = False
            frm.Load_Query(sQuery)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Customer(ByVal sCode As String)
            class_Procedures.splash_Show("Customer Information")
            Dim frm As New Forms.Persons.frm_Customer() With {
            .TopMost = True
        }
            frm.Show()
            frm.xuc_Customer.Control_Retrieve(sCode)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Releases(ByVal sBrCode As String, Optional ByVal iID As Integer = 0, Optional ByVal sEngine As String = "", Optional ByVal sAccount As String = "")
            class_Procedures.splash_Show("Sales/Releases")
            Dim frm As New Forms.Accounting.frm_Releases() With {
            .Text = $"{ .Text} - {sAccount}"
        }
            frm.xuc_Settings.Toggle_Auto_Reload.IsOn = False
            frm.Show()
            frm.xuc_Accounts.Control_Data_Load(sBrCode, iID, sEngine)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Account(ByVal eLoadType As eLoad_Type, ByVal sCode As String, Optional ByVal sLedger As Integer = 1, Optional ByVal sName As String = "Account Information", Optional ByVal bEnableEdit As Boolean = False)
            class_Procedures.splash_Show("Account Information")
            Dim frm As New Forms.Information.Account.frm_Account() With {
                .Text = $"{sName} {sCode} {sLedger}"
            }

            With frm
                .Show()
                .btn_Post_Payment.Enabled = bEnableEdit
                .btn_Migrate.Enabled = bEnableEdit
                .btn_New.Enabled = bEnableEdit
                .btn_Save.Enabled = bEnableEdit
                .btn_Delete.Enabled = bEnableEdit

                If sCode.Equals("NEW") Then
                    .xuc_Account.Retrieved = False
                    .xuc_Account.Control_New()
                Else
                    .xuc_Account.Retrieved = True
                    .xuc_Account.Control_Initialize_Lookups()

                    Select Case eLoadType
                        Case class_Saga_Variables.eLoad_Type.ID
                            .xuc_Account.Control_Retrieve($"SELECT * FROM CustAccount WHERE sequenceNo LIKE '{sCode}'")
                        Case class_Saga_Variables.eLoad_Type.CIF
                            .xuc_Account.Control_Retrieve($"SELECT * FROM CustAccount WHERE CIFKey LIKE '{sCode}' AND LedgerSetNumber LIKE '{sLedger}'")
                        Case class_Saga_Variables.eLoad_Type.Ledger
                            .xuc_Account.Control_Retrieve($"SELECT * FROM CustAccount WHERE AccountNumber LIKE '{sCode}' AND LedgerSetNumber LIKE '{sLedger}'")
                        Case class_Saga_Variables.eLoad_Type.Engine
                            .xuc_Account.Control_Retrieve($"SELECT * FROM CustAccount WHERE EngineNo LIKE '{sCode}' OR ChassisNo LIKE '{sCode}' ORDER BY id DESC")
                    End Select
                    class_Database.Fill_Edit(class_Database.ICSConnection, .xuc_Account.Ledger, "CustAccount", "AccountNumber", "LedgerSetNumber", sCode)
                End If
                .xuc_Account.Customer_Code.ReadOnly = Not bEnableEdit
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Amortization(ByVal frmOwner As XtraForm, ByVal sBrCode As String, ByVal sAccount As String, ByVal iLedger As Integer)
            Dim frm As New Forms.Information.Account.frm_Amortization_Schedule() With {
            .Left = frmOwner.Left + frmOwner.Width
            }
            frm.Show()
            frm.Control_Load(sBrCode, sAccount, iLedger)
        End Sub

        Public Sub Show_Amortization(ByVal sBrCode As String, ByVal sAccount As String, ByVal iLedger As Integer)
            Dim frm As New Forms.Information.Account.frm_Amortization_Schedule()
            frm.Show()
            frm.Control_Load(sBrCode, sAccount, iLedger)
        End Sub

        Public Sub Show_Owners(ByVal sEngine As String)
            class_Procedures.splash_Show("Item Unit Owners")
            Dim frm As New Forms.Information.Account.frm_Accounts() With {
            .Text = $"Previous Owners of Engine#: {sEngine}"
        }
            frm.Show()
            frm.xuc_Accounts.Load_Search(sEngine)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Account_Ledgers(ByVal sBrCode As String, ByVal sAccount As String, ByVal sLedger As String, ByVal sName As String)
            class_Procedures.splash_Show("Account Ledger")
            Dim frm As New frm_Account_Ledgers() With {
            .Text = $"Account Ledger: {sName} {sAccount}-{sLedger}"
        }

            With frm
                .Show()
                .xuc_Grid_Ledger.sBrCode = sBrCode
                .xuc_Grid_Ledger.sAccount = sAccount
                .xuc_Grid_Ledger.sLedger = sLedger
                .xuc_Grid_Ledger.Control_Data_Load(sBrCode, sAccount, sLedger)
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Account_Ledger(ByVal sID As String)
            class_Procedures.splash_Show("Account Ledger Record")
            Dim frm As New Forms.Information.Account.frm_Account_Ledger_Record() With {
            .Text = $"Account Ledger: {sID}",
            .TopMost = True
        }
            frm.Show()
            frm.xuc_Account_Ledger.Control_Retrieve(sID)

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Account_Payments(ByVal sAccountNumber As String, ByVal iLedger As Integer, ByVal sAccountName As String) 'ByVal sBrCode As String,
            class_Procedures.splash_Show("Account Payments")
            Dim frm As New Forms.Information.Account.frm_Account_Payments() With {
            .Text = $"PAYMENTS: Name:{sAccountName} Account:{sAccountNumber} Ledger:{iLedger} "
        }

            With frm
                .Show()
                .xuc_Grid_Collection.eLoadType = class_Saga_Variables.eLoad_Type.Account
                '.xuc_Account_Payments.sBrCode = sBrCode
                .xuc_Grid_Collection.sAccountNumber = sAccountNumber
                .xuc_Grid_Collection.iLedger = iLedger
                .xuc_Grid_Collection.sAccountName = sAccountName
                .xuc_Grid_Collection.Control_Data_Load(sAccountNumber, iLedger)
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Account_Payment(ByVal isCashiering As Boolean, ByVal sID As String)
            class_Procedures.splash_Show("Account Payment")
            Dim frm As New frm_Account_Payment With {
            .isCashiering = isCashiering
        }

            With frm
                .Show()
                If isCashiering Then
                    .Text = $"Inter-Branch Payment ID: {sID}"
                Else
                    .Text = $"Local Branch Payment ID: {sID}"
                End If
                .xuc_Account_Payment.TransactionDate.Enabled = False
                .xuc_Account_Payment.Control_Retrieve(isCashiering, sID)
                .xuc_Account_Payment.Control_Initialize()
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Branch_Collections(ByVal sBrCode As String, ByVal dtPosting As Date, ByVal iTableID As Integer, ByVal sReference As String, Optional ByVal sAccountName As String = "")
            class_Procedures.splash_Show("Branch Collections")
            Dim frm As New Forms.Accounting.frm_Collection() With {
            .Text = $"{sAccountName} {dtPosting.ToLongDateString}"
        }
            frm.Show()

            With frm.xuc_Grid_Collection
                .eLoadType = class_Saga_Variables.eLoad_Type.Batch
                .sBrCode = sBrCode
                .dtPosting = dtPosting
                .iTableID = iTableID
                .sORNumber = sReference
                .Control_Data_Load(sBrCode, dtPosting, iTableID, sReference)
            End With
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Branch_Cashiering(ByVal sBrCode As String, ByVal dtPosting As Date, ByVal iTableID As Integer, ByVal sORNumber As String, Optional ByVal sAccountName As String = "")
            class_Procedures.splash_Show("Branch Cashiering")
            Dim frm As New Forms.Accounting.frm_Cashiering() With {
            .Text = $"{sAccountName} {dtPosting.ToLongDateString}"
        }
            frm.Show()
            With frm.xuc_Grid_Cashiering
                .eLoadType = class_Saga_Variables.eLoad_Type.Batch
                .sBrCode = sBrCode
                .dtPosting = dtPosting
                .iTableID = iTableID
                .sORNumber = sORNumber
                .Control_Data_Load(sBrCode, dtPosting, iTableID, sORNumber)
            End With
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_SPA_Sales(ByVal sBrCode As String, ByVal dtStart As Date, ByVal iTableID As Integer, ByVal sORNumber As String, Optional ByVal sAccountName As String = "")
            class_Procedures.splash_Show("SPA Sales")
            Dim frm = New Forms.SPA.frm_SPA_Sales_Accounting() With {
            .Text = $"{sAccountName} {dtStart.ToLongDateString} - {dtEnd.ToLongDateString}"
        }
            With frm
                .Show()
                .Data_Load(sBrCode, dtStart, iTableID, sORNumber)
            End With
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Credit_Memo(ByVal dtStart As Date, ByVal iTableID As Integer, ByVal sEngine As String, Optional ByVal sAccountName As String = "")
            class_Procedures.splash_Show("Credit Memo")
            Dim frm As New Forms.Accounting.frm_Credit_Memo() With {
            .Text = $"{sAccountName} {dtStart.ToLongDateString} - {dtEnd.ToLongDateString}"
        }
            With frm
                .Show()
                .dtPosting = dtStart
                .iTableID = iTableID
                .Data_Load(iTableID, sEngine)
            End With
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Post_Payment(ByVal sCode As String, ByVal sLedger As String)
            Dim frm As New Forms.Transactions.frm_Payment_Collection() With {
            .TopMost = True
        }
            frm.Show()
            frm.Account_Code.Text = sCode
            frm.Ledger.Text = sLedger
        End Sub

        Public Sub Show_COA(ByVal sCode As String, Optional ByVal bNew As Boolean = False)
            class_Procedures.splash_Show("Chart of Account")
            Dim frm As New frm_Chart_Of_Account() With {
            .TopMost = True
        }
            frm.Show()

            With frm.xuc_Chart_Of_Account
                .Control_Initialize()

                If bNew Then
                    .Control_New(bNew)
                Else
                    .Control_Retrieve(sCode)
                End If
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Account_Name_New(ByVal sName As String)
            Dim frm As New frm_Account_Name() With {
            .TopMost = True
        }

            With frm
                .Show()
                .xuc_Account_Name.Control_Initialize()
                .xuc_Account_Name.Control_New(True)
                .xuc_Account_Name.Account_Name.Text = sName
            End With
        End Sub

        Public Sub Show_Account_Name(ByVal sCode As String, Optional ByVal bNew As Boolean = False)
            Dim frm As New frm_Account_Name() With {
            .TopMost = True
        }
            frm.Show()
            With frm.xuc_Account_Name
                .Control_Initialize()

                If bNew Then
                    .Control_New(bNew)
                Else
                    .Control_Retrieve(sCode)
                End If
            End With
        End Sub

        Public Sub Show_Payment_Request(ByVal sCode As String)
            class_Procedures.splash_Show("Payment Request")
            Dim frm As New Forms.Accounting.frm_Payment_Request() With {
            .Text = $"{ .Text} - {sCode}"
        }

            With frm
                .xuc_Payment_Request.Control_Initialize()
                .xuc_Payment_Request.Control_Retrieve(sCode)
                .Show()
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Account_Searched_Names(ByVal sSearch As String)
            Dim frm As New frm_Accounts_Searched() With {
            .TopMost = True
        }
            frm.Show()
            frm.BarEditItem_Search.EditValue = sSearch
            frm.xuc_Accounts.Load_Search(sSearch)
        End Sub

        Public Sub Show_User_Activity(ByVal sCode As String)
            Dim frm As New Forms.Persons.frm_User_Activities()
            frm.Show()
            frm.Data_Load(sCode)
        End Sub

        Public Sub Show_Journal_Entry(ByVal sID As String, Optional ByVal bNew As Boolean = False)
            class_Procedures.splash_Show("Journal Entry")
            Dim frm As New frm_Journal_Entry() With {
            .TopMost = True
        }
            frm.Show()

            With frm.xuc_Journal_Entry
                If bNew Then
                    .Control_New(class_Saga_Variables.sBranchCode)
                Else
                    .Control_Retrieve(sID)
                End If
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Voucher(ByVal sReference As String, Optional ByVal bNew As Boolean = False, Optional ByVal voucherType As eVoucherType = eVoucherType.Check, Optional ByVal sBrCode As String = "000", Optional ByVal sDescription As String = "")
            class_Procedures.splash_Show("Voucher Entry")
            Dim frm As New frm_Voucher() With {
                .Top = True,
                .Text = $" { .Text} - Reference: {sReference}"
            }
            frm.Show()
            frm.voucherType = voucherType

            With frm.xuc_Voucher
                .Control_Initialize()
                If bNew Then
                    .Control_New(bNew, voucherType, sBrCode, sDescription)
                Else
                    .Control_Retrieve(sReference)
                End If
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Bank(ByVal sBankAccount As String)
            class_Procedures.splash_Show("Check Number")
            Dim frm As New Forms.Accounting.frm_Bank_Account() With {
            .Text = $" { .Text}: {sBankAccount}"
        }
            frm.Show()
            frm.xuc_Bank.Control_Initialize()
            frm.xuc_Bank.Control_Retrieve(sBankAccount)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Check(ByVal sCheckNumber As String, Optional ByVal bNew As Boolean = False)
            class_Procedures.splash_Show("Check Number")
            Dim frm As New frm_Check_Number() With {
            .Text = $" { .Text}: {sCheckNumber}"
        }
            frm.Show()

            With frm.xuc_Check
                .Control_Initialize()

                If bNew Then
                    .Control_New(bNew)
                Else
                    .Control_Retrieve(sCheckNumber)
                End If
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Journal_Profile(ByVal sProfileCode As String)
            class_Procedures.splash_Show("Journal Profile Form")
            Dim frm As New frm_Journal_Profile() With {
            .Text = $" { .Text}: {sProfileCode}"
        }
            frm.Show()
            frm.xuc_Journal_Profile.Control_Initialize()
            frm.xuc_Journal_Profile.Control_Retrieve(sProfileCode)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_COA_Ledger(ByVal sCOACode As String, Optional sAccountTitle As String = "")
            class_Procedures.splash_Show("Journal Entry [Group]")
            Dim frm As New frm_COA_Ledger() With {
           .Text = $" { .Text} - Account Title: {sAccountTitle}",
           .sCOACode = sCOACode
        }
            frm.Show()
            frm.Data_Load()
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_COA_Balances(ByVal sCOACode As String, Optional ByVal bPreCOACode As Boolean = False)
            class_Procedures.splash_Show("Account Balances")
            Dim frm As New frm_COA_Balances() With {
           .Text = $" { .Text} - Account Title: {class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COA_Code, COA_Name FROM acc_Chart_Of_Accounts WHERE COA_Code LIKE '{sCOACode}'", "COA_Name")}"
        }
            frm.Show()
            class_Saga_Procedures.Initialize_COA(frm.RepositoryItemLookUpEditCOA, eCOA_Type.COA_All)
            If bPreCOACode Then sCOACode = $"{sCOACode}%"
            frm.Data_Load(sCOACode)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Journal_Entries(ByVal eLoadTYpe As eLoad_Type, ByVal sAccountNumber As String, Optional ByVal sAccountName As String = "", Optional ByVal sEngine As String = "", Optional ByVal bDateFilter As Boolean = True, Optional ByVal sBrCode As String = "000", Optional ByVal sQueryAdd As String = "")
            class_Procedures.splash_Show($"Journal Entries {sAccountNumber}")
            Dim frm As New Forms.Accounting.frm_Journal_Entries() With {
                .bInitialize = False,
                .eLoadType = eLoadTYpe,
                .sAccountCode = sAccountNumber,
                .sEngine = sEngine
            }

            With frm
                .Show()

                .Text = $"{ .Text} Account: {sAccountNumber} - {sAccountName}"
                .barEditItem_Branch.EditValue = sBrCode
                .bAccountLoad = True
                .gridView.ClearGrouping()
                .gridView.ClearColumnsFilter()

                Select Case eLoadTYpe
                    Case class_Saga_Variables.eLoad_Type.CIF
                        .Data_Load(sAccountNumber, sEngine)

                    Case Else
                        .Data_Load(sAccountNumber, sBrCode, bDateFilter, sQueryAdd)
                End Select
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Journal_Entries_Reference(ByVal sReference As String, Optional ByVal iID As Integer = 0, Optional ByVal sAccountCode As String = "", Optional ByVal sName As String = "", Optional ByVal sDescription As String = "", Optional ByVal sCheck As String = "0", Optional ByVal bAccountCodeAsReference As Boolean = False)
            class_Procedures.splash_Show($"Journal Entry [{sReference}]")
            Dim frm As New Forms.Accounting.frm_Journal_Entries_Reference() With {
            .sReference = sReference,
            .sDescription = sDescription,
            .sName = sName}

            With frm
                .Show()
                .btn_Initialize.Enabled = False
                .btn_New.Enabled = False
                .btn_Save.Enabled = False
                .btn_Update.Enabled = False
                .btn_Validate.Enabled = False

                If sReference.Contains("VOUCHER") Then
                    .BarEditItem_Document_Title.EditValue = "CASH/CHECK VOUCHER"
                    .xuc_Journal_Entries.voucherType = class_Saga_Variables.eVoucherType.Check
                Else
                    .BarEditItem_Document_Title.EditValue = "JOURNAL ENTRIES"
                    .xuc_Journal_Entries.voucherType = class_Saga_Variables.eVoucherType.Journal
                End If

                If bAccountCodeAsReference Then
                    frm.Text = $"JOURNAL ENTRIES: Account Number-{sReference}"
                Else
                    frm.Text = $"JOURNAL ENTRIES: Reference-{sReference} Check#: {sCheck}"
                End If

                .BarEditItem_Remarks.EditValue = sDescription
            End With

            With frm.xuc_Journal_Entries
                .sCheck = sCheck
                .Reference = sReference
                .AccountName = sName
                .sApprover = class_Saga_Functions.Approver
                .sDescription = sDescription

                .gridView.OptionsBehavior.Editable = False
                .Data_Load(sReference, iID,, bAccountCodeAsReference, sAccountCode)
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Journal_Entries_Reference(ByVal iID As Integer, ByVal iIDTable As Integer, ByVal sReference As String, ByVal sBrCode As String, ByVal sType As String, ByVal sProfile As String, ByVal sCode As String, ByVal sName As String, ByVal dtPostingDate As Date, ByVal sApprover As String, Optional ByVal sCOACode As String = "", Optional ByVal sCheck As String = "0", Optional ByVal sDescription As String = "", Optional ByVal bForLiquidation As Boolean = False, Optional ByVal bLTO As Boolean = False)
            Dim frm As New Forms.Accounting.frm_Journal_Entries_Reference() With {
                .Text = $"JOURNAL ENTRIES: Reference:{sReference} Check#:{sCheck}",
                .sCOACode = sCOACode,
                .sReference = sReference,
                .sCode = sCode,
                .sName = sName,
                .sCheck = sCheck
            }

            With frm
                .Show()

                If sReference.Contains("VOUCHER") Then
                    .BarEditItem_Document_Title.EditValue = "CASH/CHECK VOUCHER"
                    .xuc_Journal_Entries.voucherType = class_Saga_Variables.eVoucherType.Check
                    .xuc_Journal_Entries.sApprover = sApprover
                Else
                    .BarEditItem_Document_Title.EditValue = "JOURNAL ENTRIES"
                    .xuc_Journal_Entries.voucherType = class_Saga_Variables.eVoucherType.Journal
                    .xuc_Journal_Entries.sApprover = class_Saga_Functions.Approver
                End If

                class_Saga_Procedures.Initialize_Check(.xuc_Journal_Entries.RepositoryItemLookUpEdit_Check_Numbers, sCOACode)

                .BarEditItem_Remarks.EditValue = sDescription
                .xuc_Journal_Entries.IDTable = iIDTable
                .xuc_Journal_Entries.Reference = sReference
                .xuc_Journal_Entries.JournalType = sType
                .xuc_Journal_Entries.JournalProfile = sProfile
                .xuc_Journal_Entries.AccountCode = sCode
                .xuc_Journal_Entries.AccountName = sName
                .xuc_Journal_Entries.sCheck = sCheck
                .xuc_Journal_Entries.sBrCode = sBrCode
                .xuc_Journal_Entries.PostingDate = dtPostingDate
                .xuc_Journal_Entries.sDescription = sDescription
                .xuc_Journal_Entries.bForLiquidation = bForLiquidation
                .xuc_Journal_Entries.bLTO = bLTO

                .xuc_Journal_Entries.Data_Load(sReference, iID)
            End With
        End Sub

        Public Sub Show_Batch_Transactions(ByVal gridView As GridView, ByVal branchLUE As RepositoryItemLookUpEdit, ByVal sReference As String)
            Dim sJournalType As String = gridView.GetFocusedRowCellDisplayText("Journal_Type")
            Dim sBrCode As String = branchLUE.GetKeyValueByDisplayText(gridView.GetFocusedRowCellDisplayText("Branch_Code")).ToString
            Dim dtPostingDate As Date = Convert.ToDateTime(gridView.GetFocusedRowCellValue("Posting_Date"))
            Dim iTableID As Integer = Convert.ToInt32(gridView.GetFocusedRowCellValue("Table_ID"))
            Dim sAccountCode As String = gridView.GetFocusedRowCellDisplayText("Account_Code")
            Dim sAccount As String = $"{gridView.GetFocusedRowCellDisplayText("Account_Code")} {gridView.GetFocusedRowCellDisplayText("Account_Name")}"

            If sJournalType.Contains("COLLECTION") Then
                class_Saga_Procedures.Show_Branch_Collections(sBrCode, dtPostingDate, iTableID, sReference, sAccount)

            ElseIf sJournalType.Contains("CASHIERING") Then
                If sJournalType.Contains("_SPA") Then
                    class_Saga_Procedures.Show_SPA_Sales(sBrCode, dtPostingDate, iTableID, sReference, sAccount)
                ElseIf sJournalType.Contains("_CM") Then
                    'class_Saga_Procedures.Show_Credit_Memo(sBrCode, dtPostingDate, iTableID, sReference, sAccount)
                Else
                    class_Saga_Procedures.Show_Branch_Cashiering(sBrCode, dtPostingDate, iTableID, sReference, sAccount)
                End If

            ElseIf sJournalType.Equals("SPA_INVENTORY") Then
                class_Saga_Procedures.Show_SPA_Sales(sBrCode, dtPostingDate, iTableID, sReference, sAccount)

            ElseIf sJournalType.Contains("TRANSFER") Or sJournalType.Contains("RECEIVING") Then
                class_Saga_Procedures.Show_Unit_Inventory(sAccountCode)

            ElseIf sJournalType.Contains("RELEASE") Or sJournalType.Contains("ASSUME") Then
                class_Saga_Procedures.Show_Releases(sBrCode, iTableID, sReference, sAccount)
            End If
        End Sub

        Public Sub Print_Check(ByVal sBank As String, ByVal sCheckNumber As String, ByVal sName As String, ByVal dAmount As Decimal, ByVal dtPostingDate As Date, Optional ByVal sDescription As String = "", Optional ByVal sNotes As String = "")
            Dim xRpt = New Reports.Accounting.xrpt_Check()
            Dim rpTool As New ReportPrintTool(xRpt)

            xRpt.PaperKind = System.Drawing.Printing.PaperKind.Custom
            xRpt.PageWidth = 850
            xRpt.PageHeight = 300

            Try
                xRpt.XrL_Name.Text = sName
                xRpt.XrL_Amount_Numbers.Text = dAmount.ToString("N2")
                xRpt.XrL_Date.Text = dtPostingDate.ToString("MMMM dd, yyyy")

                'xRpt.XrL_Amount_Words.Text = class_Functions.AmountToWords(dAmount.ToString)
                'xRpt.XrL_Amount_Words.Text = class_Functions.AmountToWords(xRpt.XrL_Amount_Numbers.Text)

                Dim sAmount As String = Format(dAmount, "Fixed")

                'MsgBox(sAmount)

                xRpt.XrL_Amount_Words.Text = Get_Number_To_Words(sAmount)

                Using xuc_Check As New Controls.Accounting.xuc_Check
                    xuc_Check.Control_Check_Issue(sCheckNumber, sName, dAmount, True, dtPostingDate, sDescription, sNotes)
                End Using

                rpTool.ShowRibbonPreview()

                class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"Please verify parameters before Check Printing!{Environment.NewLine}Bank Account: {sBank}{Environment.NewLine}Check Number: {sCheckNumber}{Environment.NewLine}Print Date: {dtPostingDate:MMMM dd, yyyy}{Environment.NewLine}Check Amount: {xRpt.XrL_Amount_Numbers.Text}{Environment.NewLine}Payee Name: {xRpt.XrL_Name.Text}", "Check Printing Verification", True)
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Function Get_Number_To_Words(ByVal sAmount As String) As String
            Dim sqlParameters As SqlClient.SqlParameter() = {
                       New SqlClient.SqlParameter("@input", sAmount)
                   }
            Using myDataReader As SqlClient.SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "NumberToWords")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    myDataReader.Read()
                    Return myDataReader("AmountInWords").ToString
                End If
            End Using
            Return Nothing
        End Function

        Public Sub Show_Expense(ByVal sBrCode As String, ByVal iID As Integer)
            class_Procedures.splash_Show("Expense Transaction")
            Dim frm = New Forms.Petty_Cash.frm_Expense_Entry()
            With frm
                .Show()
                .xuc_Expense.Control_Initialize()
                .xuc_Expense.Branch_Code.EditValue = sBrCode

                If iID > 0 Then
                    .btn_Initialize.Enabled = False
                    .btn_Save.Enabled = False
                    .xuc_Expense.ID.EditValue = iID
                    .xuc_Expense.Control_Retrieve(iID)
                End If

                .xuc_Expense.Branch_Code.ReadOnly = Convert.ToBoolean(iID)

            End With
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Expense_Summary(ByVal sBrCode As String, ByVal sQuery As String, ByVal sTitle As String, Optional ByVal sReference As String = "")
            Dim xRpt As New Reports.Petty_Cash.xrpt_Expense_Summary()
            class_Database.Bind_Report(class_Database.ICSConnection, xRpt, sQuery, "TransactionPettyCash")

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1300

                    .label_Document_Title.Text = sTitle
                    .XrTableCell_Branch.Text = class_Saga_Database.get_Branch_Name(sBrCode)

                    .XrTableCell_Request_Date.Text = Date.Today.ToString("MMMM dd, yyyy")

                    Dim dtStart As Date
                    Dim dtEnd As Date

                    If sReference.Length > 0 Then
                        dtStart = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND Reference LIKE '{sReference}' ORDER BY PostingDate ASC", "PostingDate"))
                        dtEnd = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND Reference LIKE '{sReference}' ORDER BY PostingDate DESC", "PostingDate"))
                    Else
                        dtStart = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND IsDeleted <> 1 AND TransStatus NOT LIKE 'LIQUIDATED' ORDER BY PostingDate ASC", "PostingDate"))
                        dtEnd = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND IsDeleted <> 1 AND TransStatus NOT LIKE 'LIQUIDATED' ORDER BY PostingDate DESC", "PostingDate"))
                    End If

                    .XrTableCell_Period_Covered.Text = $"{dtStart:MMM dd, yyyy} - {dtEnd:MMM dd, yyyy}"

                    .XrTableCell_Admin_Cashier1.Text = class_Saga_Database.get_Admin_Cashier(sBrCode)
                    .XrTableCell_Admin_Cashier2.Text = .XrTableCell_Admin_Cashier1.Text

                    .XrTableCell_Manager.Text = class_Saga_Database.get_Branch_Manager(sBrCode)

                    If sBrCode.Equals("000") Then
                        .XrTableCell_Admin_Position.Text = "Accounting Assistant"
                        .XrTableCell_Manager_Position.Text = "Comptroller"
                    End If
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Public Sub Show_Payment_Request(ByVal sBrCode As String, ByVal sQuery As String, ByVal sTitle As String, Optional ByVal sReference As String = "")
            Dim xRpt As New Reports.Petty_Cash.xrpt_Expense_Request()
            class_Database.Bind_Report(class_Database.ICSConnection, xRpt, sQuery, "TransactionPettyCash")

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1300

                    .label_Document_Title.Text = sTitle
                    .XrTableCell_Branch.Text = class_Saga_Database.get_Branch_Name(sBrCode)

                    .XrTableCell_Cashier.Text = class_Saga_Database.get_Admin_Cashier(sBrCode)

                    .XrTableCell_Request_Date.Text = Date.Today.ToString("MMMM dd, yyyy")

                    Dim dtStart As Date
                    Dim dtEnd As Date

                    If sReference.Length > 0 Then
                        dtStart = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND Reference LIKE '{sReference}' ORDER BY PostingDate ASC", "PostingDate"))
                        dtEnd = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND Reference LIKE '{sReference}' ORDER BY PostingDate DESC", "PostingDate"))
                    Else
                        dtStart = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND IsDeleted <> 1 AND TransStatus NOT LIKE 'LIQUIDATED' ORDER BY PostingDate ASC", "PostingDate"))
                        dtEnd = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND IsDeleted <> 1 AND TransStatus NOT LIKE 'LIQUIDATED' ORDER BY PostingDate DESC", "PostingDate"))
                    End If

                    .XrTableCell_Period_Covered.Text = $"{dtStart:MMM dd, yyyy} - {dtEnd:MMM dd, yyyy}"
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

    End Module
End Namespace