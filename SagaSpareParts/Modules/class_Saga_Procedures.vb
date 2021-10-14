Imports AutoUpdaterDotNET
Imports DevExpress
Imports DevExpress.Compression
Imports DevExpress.Skins
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports Ionic.Zip
Imports MyClassLibrary.Classes
Imports System.IO
Imports System.Windows.Forms

Namespace Modules
    Public Module class_Saga_Procedures

        Public bLoopStop As Boolean

        Public Enum eLoad_Type
            ID
            Account
            Ledger
            CIF
            Engine
            Balance
            Batch
            Range
            Daily
            Monthly
        End Enum

        Public loadType As eLoad_Type

        Public Enum eCOA_Type
            COA_All
            COA_Summary
            COA_Detail
            COA_Bank
        End Enum

        Public Enum eVoucherType
            Check
            Expense
            Journal
        End Enum

        Public Sub Show_Update(ByVal bMandatory As Boolean, Optional ByVal bErrorReport As Boolean = False, Optional ByVal bBackup As Boolean = False)
            If class_Database.bIsLocal Then Return
            If bBackup Then
                Using zip As ZipFile = New ZipFile()
                    zip.AddFile($"{Application.ProductName}.exe")
                    zip.Save($"{Application.ProductName}-{Application.ProductVersion}.zip")
                End Using
            End If

            Dim sUpdatePath As String = $"{class_Database.sUpdateLink}{Application.ProductName}.xml"
            AutoUpdater.Start(sUpdatePath, Reflection.Assembly.GetEntryAssembly)
            AutoUpdater.AppTitle = Application.ProductName
            AutoUpdater.Mandatory = bMandatory
            AutoUpdater.ReportErrors = bErrorReport
        End Sub

        Public Sub Create_XML_Update(ByVal xForm As XtraForm, Optional ByVal bMandatory As Boolean = False)
            class_Procedures.splash_Show(xForm, "Creating XML file for Update Package", "Creating XML", True)

            Dim file As IO.StreamWriter = Nothing
            Dim sAppName As String = Application.ProductName
            Try
                'If bSaveLocal Then
                file = My.Computer.FileSystem.OpenTextFileWriter($"{sAppName}.xml", False)
                'Else
                '    file = My.Computer.FileSystem.OpenTextFileWriter($"{class_Database.sUpdateLink}\{sAppName}.xml", False)
                'End If
            Catch Ex As Exception
                file = My.Computer.FileSystem.OpenTextFileWriter($"{sAppName}.xml", False)
            End Try

            With file
                .WriteLine($"<?xml version='1.0' encoding='UTF-8'?>")
                .WriteLine("<item>")
                .WriteLine($"<version>{Application.ProductVersion}</version>")
                .WriteLine($"<url>{class_Database.sUpdateLink}{sAppName}.zip</url>")
                .WriteLine($"<changelog>{class_Database.sUpdateLink}Releases.txt</changelog>")
                .WriteLine($"<mandatory>{bMandatory.ToString.ToLower}</mandatory>")
                .WriteLine("</item>")
                .Close()
            End With

            class_Procedures.splash_Close(True)
        End Sub

        Public Sub Create_App_Backup(ByVal frm As XtraForm, Optional ByVal bDevExComponents As Boolean = False, Optional bSaveLocal As Boolean = False, Optional ByVal bOpenDirectory As Boolean = False)
            Dim sAppName As String = Application.ProductName

            class_Procedures.splash_Show(frm, "compressing files for update package", "Creating Update File", True)

            Using myZippedStream As Stream = New FileStream($"{sAppName}.zip", FileMode.Create)
                Using zipArchive As New ZipArchive()
                    With zipArchive
                        .AddFile($"{Application.ProductName}.exe")
                        .AddFile("SagaSupport.exe")

                        If bDevExComponents Then
                            Dim path As New IO.DirectoryInfo(Application.StartupPath)
                            Dim files As IO.FileInfo() = path.GetFiles("*.dll")

                            For Each file As IO.FileInfo In files
                                .AddFile(file.Name)
                            Next
                        Else
                            .AddFile("AutoUpdater.NET.dll")
                            Try
                                .AddFile("wSClassLib.dll")
                                .AddFile("BranchAccounting.dll")
                            Catch Ex As Exception
                            End Try
                            .AddFile("SagaInventory.dll")
                            .AddFile("MyClassLibrary.dll")
                            .AddFile("SagaClassLibrary.dll")
                        End If

                        .Save($"{sAppName}.zip")
                        .Save(myZippedStream)
                    End With
                End Using
            End Using

            class_Procedures.splash_Close(True)

            If bSaveLocal Then
                Try
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "The files has been successfully compressed and saved to the Local Directory Folder.")
                    If bOpenDirectory Then Process.Start("explorer.exe", $"{Application.StartupPath}")
                Catch Ex As System.IO.FileNotFoundException
                    class_Procedures.Show_Error(Ex)
                End Try
            Else
                If class_Connections.Upload_Update_File(sAppName, "xml") AndAlso class_Connections.Upload_Update_File(sAppName, "zip") Then
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "The Update Package files has been successfully uploaded to the FTP Server.", "FTP Update Package", True)
                End If
            End If
        End Sub

        Public Sub Initialize_BarManager(ByVal xForm As XtraForm, ByVal barManager As BarManager)
            Initialize_BarManager(barManager)
            Try
                barManager.RestoreLayoutFromRegistry(xForm.Name)
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
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
                            Case "Btn_Account"
                                .Caption = "&Account"
                                .Hint = "Show account information"
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.A)
                                .ImageOptions.Image = xIconForm.Btn_Account.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Account.ImageOptions.LargeImage

                            Case "Btn_Batch_Transactions"
                                .Caption = "Batch Transactions"
                                .Hint = "Show selected Batch Transactions"
                                .ItemShortcut = New BarShortcut(Keys.F7)
                                .ImageOptions.Image = xIconForm.Btn_Batch_Transactions.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Batch_Transactions.ImageOptions.LargeImage

                        'SQL Server Connection
                            Case "Btn_Refresh_Connection"
                                .Caption = "Re&fresh Connection"
                                .Hint = "Refresh/Check SQL Database connection"
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.F)
                                .ImageOptions.Image = xIconForm.Btn_Refresh_Connection.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Refresh_Connection.ImageOptions.LargeImage

                            Case "Btn_Test_Connection"
                                .Caption = "Test Connection"
                                .Hint = "Test/Check SQL Database connection using specified parameters"
                                .ItemShortcut = New BarShortcut(Keys.F5)
                                .ImageOptions.Image = xIconForm.Btn_Refresh_Connection.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Refresh_Connection.ImageOptions.LargeImage

                            Case "Btn_Connect_Close"
                                .Caption = "Connect and Close"
                                .Hint = "Connect SQL Database and close the form"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.F5)
                                .ImageOptions.Image = xIconForm.Btn_OK.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_OK.ImageOptions.LargeImage

                            'Primary Actions
                            Case "Btn_Import"
                                .Caption = "Import"
                                .Hint = "Import data into GridView"
                                .ImageOptions.Image = xIconForm.Btn_Import.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Import.ImageOptions.LargeImage

                            Case "Btn_Initialize"
                                .Caption = "Initiali&ze"
                                .Hint = "Initialize data on some text controls"
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.Z)
                                .ImageOptions.Image = xIconForm.Btn_Initialize.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Initialize.ImageOptions.LargeImage

                            Case "Btn_Reset"
                                .Caption = "Reset"
                                .Hint = "Reset controls (bar, dock, gridview etc.)"
                                .ImageOptions.Image = xIconForm.Btn_Reset.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Reset.ImageOptions.LargeImage
                                .Visibility = BarItemVisibility.OnlyInCustomizing

                            Case "Btn_Reload"
                                .Caption = "&Reload"
                                .Hint = "Load or refresh data on Gridview Table"
                                .ItemShortcut = New BarShortcut(Keys.F5)
                                .ImageOptions.Image = xIconForm.Btn_Reload.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Reload.ImageOptions.LargeImage

                            Case "Btn_Preview"
                                .Caption = "&Preview"
                                .Hint = "Display Data from Gridview Table into Printable Form"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.V)
                                .ImageOptions.Image = xIconForm.Btn_Preview.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Preview.ImageOptions.LargeImage

                            Case "Btn_Print_Check"
                                .Caption = "Print Check"
                                .Hint = "Print check with Payee and Amount"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.H)
                                .ImageOptions.Image = xIconForm.Btn_Print_Check.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Print_Check.ImageOptions.LargeImage

                            Case "Btn_New"
                                .Caption = "&New"
                                .Hint = "Clear controls/input boxes to entry new data"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.N)
                                .ImageOptions.Image = xIconForm.Btn_New.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_New.ImageOptions.LargeImage

                            Case "Btn_Save"
                                .Caption = "&Save"
                                .Hint = "Save data with current values"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.S)
                                .ImageOptions.Image = xIconForm.Btn_Save.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Save.ImageOptions.LargeImage

                            Case "Btn_Save_New"
                                .Caption = "Save and Create New"
                                .Hint = "Save Data prepare the form to Create New"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.T)
                                .ImageOptions.Image = xIconForm.Btn_Save_Template.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Save_Template.ImageOptions.LargeImage

                            Case "Btn_Save_New"
                                .Caption = "Save and New"
                                .Hint = "Save data and then prepare new entry"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.N)
                                .ImageOptions.Image = xIconForm.Btn_Save_New.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Save_New.ImageOptions.LargeImage

                            Case "Btn_Save_Journal_Entries"
                                .Caption = "Save and Show Journal Entries"
                                .Hint = "Save data then show Journal Entries then Closes the current Form"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.J)
                                .ImageOptions.Image = xIconForm.Btn_Journal.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Journal.ImageOptions.LargeImage

                            Case "Btn_Save_Close"
                                .Caption = "Save and Close"
                                .Hint = "Save data then Closes the current Form"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.S)
                                .ImageOptions.Image = xIconForm.Btn_Save_Close.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Save_Close.ImageOptions.LargeImage

                            Case "Btn_Update"
                                .Caption = "&Update"
                                .Hint = "Update or overwrite existing data with new values"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.U)
                                .ImageOptions.Image = xIconForm.Btn_Update.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Update.ImageOptions.LargeImage

                            Case "Btn_Delete"
                                .Caption = "&Delete"
                                .Hint = "Delete, Cancel or Remove selected data"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.D)
                                .ImageOptions.Image = xIconForm.Btn_Delete.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Delete.ImageOptions.LargeImage

                            Case "Btn_Delete"
                                .Caption = "&For Delete"
                                .Hint = "Send selected row(s) 'For Delete' to Admin"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.D)
                                .ImageOptions.Image = xIconForm.Btn_Delete.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Delete.ImageOptions.LargeImage

                            Case "Btn_Delete_Close"
                                .Caption = "&Delete and Close"
                                .Hint = "Delete, Cancel or Remove selected data and Close the form"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.D)
                                .ImageOptions.Image = xIconForm.Btn_Delete.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Delete.ImageOptions.LargeImage

                            Case "Btn_Close"
                                .Caption = "&Close"
                                .Hint = "Closes the Window Form"
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.C)
                                .ImageOptions.Image = xIconForm.Btn_Close.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Close.ImageOptions.LargeImage

                            Case "Btn_Cancel"
                                .Caption = "Cancel"
                                .Hint = "Cancel the current data record"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.C)
                                .ImageOptions.Image = xIconForm.Btn_Cancel.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Cancel.ImageOptions.LargeImage

                            'Status
                            Case "Btn_Pending"
                                .Caption = "&Pending"
                                .Hint = "Load pending transactions to Gridview Table"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.F5)
                                .ImageOptions.Image = xIconForm.Btn_Pending.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Pending.ImageOptions.LargeImage

                            Case "Btn_Approval"
                                .Caption = "Approval"
                                .Hint = "Send selected row(s) 'For Approval' to Approver"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.A)
                                .ImageOptions.Image = xIconForm.Btn_Approval.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Approval.ImageOptions.LargeImage

                            Case "Btn_Approve"
                                .Caption = "Approve"
                                .Hint = "Approve 'For Approval' selected row(s)"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.P)
                                .ImageOptions.Image = xIconForm.Btn_Approve.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Approve.ImageOptions.LargeImage

                            Case "Btn_DisApprove"
                                .Caption = "Disapprove"
                                .Hint = "Disapprove 'For Approval' selected row(s)"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.I)
                                .ImageOptions.Image = xIconForm.Btn_DisApprove.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_DisApprove.ImageOptions.LargeImage

                            Case "Btn_Password_Reset"
                                .Caption = "Password Reset"
                                .Hint = "Reset user password"
                                .ImageOptions.Image = xIconForm.Btn_Password_Reset.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Password_Reset.ImageOptions.LargeImage

                            Case "Btn_Lock"
                                .Caption = "Lock/Unlock"
                                .Hint = "Lock data update permission"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.L)
                                .ImageOptions.Image = xIconForm.Btn_Lock.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Lock.ImageOptions.LargeImage

                            'Custom Query
                            Case "Btn_Generate"
                                .Caption = "&Generate"
                                .Hint = "Generate SQL Query for execution"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.F5)
                                .ImageOptions.Image = xIconForm.Btn_Generate.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Generate.ImageOptions.LargeImage

                            Case "Btn_Execute"
                                .Caption = "Execute"
                                .Hint = "Execute command to process data"
                                .ItemShortcut = New BarShortcut(Keys.F5)
                                .ImageOptions.Image = xIconForm.Btn_Execute.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Execute.ImageOptions.LargeImage

                            'Checks
                            Case "Btn_Link"
                                .Caption = "Link"
                                .Hint = "Link selected transaction accross other transactions"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.L)
                                .ImageOptions.Image = xIconForm.Btn_Link.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Link.ImageOptions.LargeImage

                            'Chart of Accounts
                            Case "Btn_Convert_Summary"
                                .Caption = "Convert to Summary"
                                .Hint = "Convert selected Detail COA into Summary"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.T)
                                .ImageOptions.Image = xIconForm.Btn_Convert_Summary.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Convert_Summary.ImageOptions.LargeImage

                            Case "Btn_Insert"
                                .Caption = "Insert"
                                .Hint = "Insert New Entry (Auto-increment Code)"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.Insert)
                                .ImageOptions.Image = xIconForm.Btn_Insert.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Insert.ImageOptions.LargeImage

                            Case "Btn_Another_Entry"
                                .Caption = "Another Entr&y"
                                .Hint = "Input another entry (ID Code Auto-increment)"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.Y)
                                .ImageOptions.Image = xIconForm.Btn_Another_Entry.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Another_Entry.ImageOptions.LargeImage

                            'Tree List view
                            Case "Btn_Expand"
                                .Caption = "Expand"
                                .Hint = "Expand the Tree List view"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.Add)
                                .ImageOptions.Image = xIconForm.Btn_Expand.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Expand.ImageOptions.LargeImage

                            Case "Btn_Collapse"
                                .Caption = "Collapse"
                                .Hint = "Collapse the Tree List view"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.Subtract)
                                .ImageOptions.Image = xIconForm.Btn_Collapse.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Collapse.ImageOptions.LargeImage

                            'Journal
                            Case "Btn_Journal"
                                .Caption = "&Journal"
                                .Hint = "Convert selected transaction into Journal Entries"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.F6)
                                .ImageOptions.Image = xIconForm.Btn_Journal.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Journal.ImageOptions.LargeImage

                            Case "Btn_Journal2"
                                .Caption = "Re-&Journal"
                                .Hint = "Delete cancelled journal entries and Re-Entry new journal entries"
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.F6)
                                .ImageOptions.Image = xIconForm.Btn_Journal.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Journal.ImageOptions.LargeImage

                            Case "Btn_Journal_Entries"
                                .Caption = "Journal &Entries"
                                .Hint = "Show Journal Entries of the selected transaction"
                                .ItemShortcut = New BarShortcut(Keys.F6)
                                .ImageOptions.Image = xIconForm.Btn_Journal_Entries.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Journal_Entries.ImageOptions.LargeImage

                            Case "Btn_Journal_Entries2"
                                .Caption = "&Journal Entries 2"
                                .Hint = "Show Journal Entries of the selected Account"
                                .ItemShortcut = New BarShortcut(Keys.Shift Or Keys.F6)
                                .ImageOptions.Image = xIconForm.Btn_Journal_Entries.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Journal_Entries.ImageOptions.LargeImage

                            Case "Btn_COA_Ledger", "Btn_Ledger", "Btn_Payments"
                                .Caption = .Name.Substring(4)
                                .Hint = $"Show { .Name.Substring(4)}"
                                .ItemShortcut = New BarShortcut(Keys.F7)
                                .ImageOptions.Image = xIconForm.Btn_COA_Ledger.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_COA_Ledger.ImageOptions.LargeImage

                            Case "Btn_Validate"
                                .Caption = "&Validate"
                                .Hint = "Validate the data in Gridview Table and check for errors"
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.V)
                                .ImageOptions.Image = xIconForm.Btn_Validate.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Validate.ImageOptions.LargeImage

                            Case "Btn_Verify"
                                .Caption = "Verify"
                                .Hint = "Verify transactions if IsJournal"
                                .ItemShortcut = New BarShortcut(Keys.F8)
                                .ImageOptions.Image = xIconForm.Btn_Verify.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Verify.ImageOptions.LargeImage

                            Case "Btn_Stop"
                                .Caption = "S&top"
                                .Hint = "Stop or Halt the current looping process"
                                .ItemShortcut = New BarShortcut(Keys.Alt Or Keys.S)
                                .ImageOptions.Image = xIconForm.Btn_Stop.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Stop.ImageOptions.LargeImage

                            'Trial Balance
                            Case "Btn_Trial_Balance"
                                .Caption = "Update Trial Balance"
                                .Hint = "Update Trial Balance of the selected row(s)"
                                .ImageOptions.Image = xIconForm.Btn_Trial_Balance.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Trial_Balance.ImageOptions.LargeImage

                            Case "Btn_Generate"
                                .Caption = "&Generate"
                                .Hint = "Generate data in Gridview Table"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.G)

                            Case "Btn_Summary"
                                .Caption = "Su&mmary"
                                .Hint = "Update journal summary from Gridview Table"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.M)
                                .ImageOptions.Image = xIconForm.Btn_Summary.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Summary.ImageOptions.LargeImage

                            'Filter
                            Case "Btn_Filter_Load"
                                .Caption = "Filter &Load"
                                .Hint = "Rearrange/Format Gridview Table from the selected Filter Profile"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.L)
                                .ImageOptions.Image = xIconForm.Btn_Filter_Load.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Filter_Load.ImageOptions.LargeImage

                            Case "Btn_Filter_Save"
                                .Caption = "Filter &Save"
                                .Hint = "Save Gridview Table arrangements/format to the selected Filter Profile"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.S)
                                .ImageOptions.Image = xIconForm.Btn_Filter_Save.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Filter_Save.ImageOptions.LargeImage

                            Case "Btn_Filter_Delete"
                                .Caption = "Filter &Delete"
                                .Hint = "Delete selected Filter Profile"
                                .ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.D)
                                .ImageOptions.Image = xIconForm.Btn_Filter_Delete.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Filter_Delete.ImageOptions.LargeImage

                            'Custom
                            Case "Btn_Regenerate_Codes"
                                .Caption = "Regenerate Codes"
                                .Hint = "Regenerate/Repair Codes to avoid Primary Key Error"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.G)
                                .ImageOptions.Image = xIconForm.Btn_Regenerate_Codes.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_Regenerate_Codes.ImageOptions.LargeImage

                            Case "Btn_History"
                                .Caption = "History"
                                .Hint = "Check the Activity History of the selected item"
                                .ItemShortcut = New BarShortcut(Keys.Control Or Keys.H)
                                .ImageOptions.Image = xIconForm.Btn_History.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_History.ImageOptions.LargeImage

                            Case "Btn_SMS"
                                .Caption = "Send SMS"
                                .Hint = "Send SMS on selected COntact Numbers"
                                .ImageOptions.Image = xIconForm.Btn_SMS.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.Btn_SMS.ImageOptions.LargeImage
                        End Select
                    End With

                ElseIf item.GetType = GetType(BarEditItem) Then
                    With CType(item, BarEditItem)
                        .PaintStyle = BarItemPaintStyle.CaptionGlyph
                        Select Case .Name
                            Case "BarEditItem_Corporation"
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
                                .Hint = "Search any string and show results in GridView"
                                .ImageOptions.Image = xIconForm.BarEditItem_Search.ImageOptions.Image
                                .ImageOptions.LargeImage = xIconForm.BarEditItem_Search.ImageOptions.LargeImage

                            Case "BarEditItem_Posting_Date", "barEditItem_Date_Start", "barEditItem_Date_End", "BarEditItem_Date_Granted"
                                Select Case .Name
                                    Case "BarEditItem_Posting_Date"
                                        .Caption = "Posting Date"
                                        .Hint = "Custom Posting Date for Journal Entry"

                                    Case "barEditItem_Date_Start"
                                        .Caption = "Date Start"
                                        .Hint = "Set starting date"

                                    Case "barEditItem_Date_End"
                                        .Caption = "Date End"
                                        .Hint = "Set ending date"
                                End Select

                                .EditWidth = 140
                                .EditValue = Date.Now

                            Case "BarEditItem_Filter"
                                .Caption = "Filter"
                                .EditWidth = 150
                                .Hint = "SELECT and manage Gridview Table query result filter"
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

        Public Sub Initialize_Corporation(ByVal lue_Corporation As LookUpEdit, Optional ByVal bAll As Boolean = False, Optional ByVal iDropDownRows As Integer = 2)
            Try
                With lue_Corporation.Properties
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code"),
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Full_Name", "Full Name")})

                    If bAll Then
                        .DataSource = class_Saga_Variables.corporation_All.Properties.DataSource
                    Else
                        .DataSource = class_Saga_Variables.corporation.Properties.DataSource
                    End If
                    .DisplayMember = "Name"
                    .DropDownRows = iDropDownRows
                    .TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor
                    .ValueMember = "Code"
                End With
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

        Public Sub Initialize_Corporation(ByVal barItem As BarEditItem, ByVal lue_Corporation As RepositoryItemLookUpEdit, Optional ByVal bAll As Boolean = False, Optional ByVal iDropDownRows As Integer = 2)
            barItem.EditWidth = 100
            Initialize_Corporation(lue_Corporation, bAll, iDropDownRows)
        End Sub

        Public Sub Initialize_Corporation(ByVal lue_Corporation As RepositoryItemLookUpEdit, Optional ByVal bAll As Boolean = False, Optional ByVal iDropDownRows As Integer = 2)
            Try
                With lue_Corporation
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code"),
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Full_Name", "Full Name")})

                    If bAll Then
                        .DataSource = class_Saga_Variables.corporation_All.Properties.DataSource
                    Else
                        .DataSource = class_Saga_Variables.corporation.Properties.DataSource
                    End If
                    .DisplayMember = "Name"
                    .DropDownRows = iDropDownRows
                    .NullText = "Select Corporation..."
                    .ValueMember = "Code"
                End With
                class_Procedures.Initialize_RepositoryItem(lue_Corporation, XtraEditors.Controls.TextEditStyles.DisableTextEditor)
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

        Public Sub Initialize_Branch(ByVal lue_Branch As LookUpEdit)
            Dim sBrCode As String

            Try
                If lue_Branch.EditValue Is Nothing Then
                    sBrCode = class_Saga_Variables.sBranchCode
                Else
                    sBrCode = lue_Branch.EditValue
                End If
            Catch Ex As Exception
                sBrCode = class_Saga_Variables.sBranchCode
                class_Procedures.Show_Error(Ex)
            End Try

            Try

                With lue_Branch.Properties
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchCode", "Code"),
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pre_Code", "Pre-Code"),
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch", "Branch Name"),
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Address")})

                    .DataSource = class_Saga_Variables.branch.Properties.DataSource
                    .DropDownRows = class_Saga_Variables.iBranchRowCount
                    .DisplayMember = "Branch"
                    .ValueMember = "BranchCode"
                    .TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor
                End With
                lue_Branch.EditValue = sBrCode
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

        Public Sub Initialize_Branch(ByVal barItem As BarEditItem, ByVal bRanch As RepositoryItemLookUpEdit, Optional bWithPostingDate As Boolean = False)
            With barItem
                .EditWidth = 170
                .EditValue = class_Saga_Variables.sBranchCode
            End With

            With bRanch
                Try
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                        New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchCode", "Code"),
                        New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pre_Code", "Pre-Code"),
                        New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch", "Branch Name"),
                        New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DatabaseDate", "Posting Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", bWithPostingDate, DevExpress.Utils.HorzAlignment.Far)})

                    .DataSource = class_Saga_Variables.branch.Properties.DataSource
                    .DisplayMember = "Branch"
                    .DropDownRows = class_Saga_Variables.iBranchRowCount
                    .ValueMember = "BranchCode"

                    class_Procedures.Initialize_RepositoryItem(bRanch, XtraEditors.Controls.TextEditStyles.DisableTextEditor)
                Catch Ex As Exception
                    class_Procedures.Show_Error(Ex)
                Finally
                    barItem.EditValue = class_Saga_Variables.sBranchCode
                End Try
            End With
        End Sub

        Public Sub Initialize_Branch(ByVal lue_Branch As RepositoryItemLookUpEdit)
            Try
                With lue_Branch
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchCode", "Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pre_Code", "Pre-Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch", "Branch Name")})

                    .DataSource = class_Saga_Variables.branch.Properties.DataSource
                    .DisplayMember = "Branch"
                    .DropDownRows = class_Saga_Variables.iBranchRowCount
                    .ValueMember = "BranchCode"
                    .NullText = Nothing

                    class_Procedures.Initialize_RepositoryItem(lue_Branch, XtraEditors.Controls.TextEditStyles.DisableTextEditor)
                End With
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

        Public Sub Initialize_Agent(ByVal aGents As LookUpEdit)
            Try
                aGents.Properties.DataSource = class_Saga_Variables.agent.Properties.DataSource
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

        Public Sub Initialize_AE(ByVal aE As LookUpEdit)
            Try
                aE.Properties.DataSource = class_Saga_Variables.ae.Properties.DataSource
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

        Public Sub Initialize_AE(ByVal barItem As BarEditItem, ByVal aE As RepositoryItemLookUpEdit)
            barItem.EditWidth = 200
            Initialize_AE(aE)
        End Sub

        Public Sub Initialize_AE(ByVal aE As RepositoryItemLookUpEdit)
            Try
                With aE
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountExecutive", "Code"),
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OfficerName", "Name")})

                    .DataSource = class_Saga_Variables.ae.Properties.DataSource
                    .DisplayMember = "OfficerName"
                    .ValueMember = "AccountExecutive"
                    .NullText = "Select Branch..."

                    class_Procedures.Initialize_RepositoryItem(aE, XtraEditors.Controls.TextEditStyles.DisableTextEditor)
                End With
                aE.DataSource = class_Saga_Variables.ae.Properties.DataSource
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

        Public Sub Initialize_Models(ByVal moDels As LookUpEdit)
            Try
                moDels.Properties.DataSource = class_Saga_Variables.mc.Properties.DataSource
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

        Public Sub Initialize_COA(ByVal lue_COA As RepositoryItemLookUpEdit, ByVal eCOAType As eCOA_Type)
            Try
                With lue_COA
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Type", "Type"),
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Summary_Name", "Summary"),
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Code", "Code"),
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Name", "Name"),
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Balance_Running", "Balance", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Balance_Limit", "Limit", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Desc", "Description")})

                    .DisplayMember = "COA_Name"
                    .NullText = "SELECT Account..."
                    .ValueMember = "COA_Code"

                    Select Case eCOAType
                        Case eCOA_Type.COA_All
                            .DataSource = class_Saga_Variables.coaAll.Properties.DataSource
                        Case eCOA_Type.COA_Summary
                            .DataSource = class_Saga_Variables.coaSummary.Properties.DataSource
                        Case eCOA_Type.COA_Detail
                            .DataSource = class_Saga_Variables.coaDetail.Properties.DataSource
                        Case eCOA_Type.COA_Bank
                            .DataSource = class_Saga_Variables.coaBank.Properties.DataSource
                    End Select

                    class_Procedures.Initialize_RepositoryItem(lue_COA, XtraEditors.Controls.TextEditStyles.Standard)

                End With
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

        Public Sub Initialize_COA(ByVal lue_COA As LookUpEdit, ByVal eCOAType As eCOA_Type)
            Try
                With lue_COA.Properties
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Type", "Type"),
                                            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Summary_Name", "Summary"),
                                            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Code", "Code"),
                                            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Name", "Name"),
                                            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Balance_Running", "Balance", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                                            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Balance_Limit", "Limit", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                                            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Desc", "Description")})

                    .DisplayMember = "COA_Name"
                    .NullText = "SELECT Account..."
                    .ValueMember = "COA_Code"

                    Select Case eCOAType
                        Case eCOA_Type.COA_All
                            .DataSource = class_Saga_Variables.coaAll.Properties.DataSource
                        Case eCOA_Type.COA_Summary
                            .DataSource = class_Saga_Variables.coaSummary.Properties.DataSource
                        Case eCOA_Type.COA_Detail
                            .DataSource = class_Saga_Variables.coaDetail.Properties.DataSource
                        Case eCOA_Type.COA_Bank
                            .DataSource = class_Saga_Variables.coaBank.Properties.DataSource
                    End Select
                End With
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

        Public Sub Initialize_Bank(ByVal lue_Bank As LookUpEdit)
            With lue_Bank.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Bank_Code", "Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Bank_Account", "Bank Account"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Bank_Name", "Bank Name"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Name", "Account Name")})

                .DataSource = class_Saga_Variables.bank.Properties.DataSource
                .DisplayMember = "Bank_Name"
                .ValueMember = "Bank_Account"
                .NullValuePrompt = "Select Bank..."
            End With
        End Sub

        Public Sub Initialize_Bank(ByVal lue_Bank As RepositoryItemLookUpEdit)
            Try
                With lue_Bank
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Bank_Account", "Bank Account"),
                                      New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Bank_Name", "Bank Name")})

                    .DataSource = class_Saga_Variables.bank.Properties.DataSource
                    .DisplayMember = "Bank_Name"
                    .ValueMember = "Bank_Account"
                    .NullText = Nothing

                    class_Procedures.Initialize_RepositoryItem(lue_Bank, XtraEditors.Controls.TextEditStyles.DisableTextEditor)

                End With
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

        Public Sub Initialize_Check(ByVal lue_Check As LookUpEdit)
            With lue_Check.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Check_Number", "Check Number"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Bank_Account", "Bank Account"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Reference", "Reference"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Check_Amount", "Check Amount", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Check_Payee", "Check Payee")})

                .DataSource = class_Saga_Variables.check.Properties.DataSource
                .DisplayMember = "Check_Number"
                .ValueMember = "Check_Number"
                .NullValuePrompt = "Select Check..."
            End With
        End Sub

        Public Sub Initialize_Check(ByVal lue_Check As RepositoryItemLookUpEdit)
            With lue_Check
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Check_Number", "Check Number"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Bank_Account", "Bank Account"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Reference", "Reference"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Check_Amount", "Check Amount", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Check_Payee", "Check Payee")})

                .DataSource = class_Saga_Variables.check.Properties.DataSource
                .DisplayMember = "Check_Number"
                .ValueMember = "Check_Number"
                .NullValuePrompt = "Select Check..."
            End With
            class_Procedures.Initialize_RepositoryItem(lue_Check, XtraEditors.Controls.TextEditStyles.Standard)
        End Sub

        Public Sub Initialize_Budget(ByVal lue_Budget As LookUpEdit)
            With lue_Budget.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Budget_Code", "Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Budget_Name", "Name"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Budget_Amount", "Amount", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Budget_Balance", "Balance", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Budget_Description", "Description")})

                .DataSource = class_Saga_Variables.budget.Properties.DataSource
                .DisplayMember = "Budget_Name"
                .ValueMember = "Budget_Code"
                .NullValuePrompt = "Select Budget..."
            End With
        End Sub

        Public Sub Initialize_For_Liquidation(ByVal monitored As LookUpEdit)
            With monitored.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Voucher_Reference", "Reference"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Expense_Type", "Profile"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Voucher_Date_Posted", "Posted", -1, DevExpress.Utils.FormatType.DateTime, "MMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Liquidation_Days", "Days"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Liquidation_Date_Expiry", "Expiry", -1, DevExpress.Utils.FormatType.DateTime, "MMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Voucher_Credit", "Credit", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Voucher_Description", "Description")})

                .DataSource = class_Saga_Variables.forliquidation.Properties.DataSource
                .DisplayMember = "Voucher_Reference"
                .ValueMember = "Voucher_Reference"
                .NullValuePrompt = "Select Liquidation..."
            End With
        End Sub

        Public Sub Initialize_Journal_Profile(ByVal lue_Profile As LookUpEdit)
            With lue_Profile.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Profile_Code", "Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Journal_Type", "Category"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Friendly_Name", "Sub-Category"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Profile_Description", "Description")})

                .DataSource = class_Saga_Variables.journal_Profile.Properties.DataSource
                .DisplayMember = "Friendly_Name"
                .ValueMember = "Profile_Code"
                .NullValuePrompt = "Select Profile..."
            End With
        End Sub

        Public Sub Initialize_For_Liquidation(ByVal monitoredSearchLookUpEdit As SearchLookUpEdit, ByVal monitoredView As GridView)
            With monitoredView
                .Columns.Clear()
                Dim colID As GridColumn = New GridColumn
                Dim colExpense_Type As GridColumn = New GridColumn
                Dim colVoucher_Reference As GridColumn = New GridColumn
                Dim colAccount_Name As GridColumn = New GridColumn
                Dim colVoucher_Debit As GridColumn = New GridColumn
                Dim colVoucher_Date_Posted As GridColumn = New GridColumn
                Dim colLiquidation_Days As GridColumn = New GridColumn
                Dim colLiquidation_Date_Expiry As GridColumn = New GridColumn
                Dim colVoucher_Description As GridColumn = New GridColumn

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

            With monitoredSearchLookUpEdit.Properties
                .DataSource = class_Saga_Variables.forliquidation.Properties.DataSource
                .DisplayMember = "Voucher_Reference"
                .ValueMember = "Voucher_Reference"
                .NullValuePrompt = "Select Monitored Voucher..."
            End With
        End Sub

        Public Sub Initialize_Liquidation(ByVal liquidation As LookUpEdit)
            With liquidation.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Journal_Reference", "Reference"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Posting_Date", "Posted", -1, DevExpress.Utils.FormatType.DateTime, "MMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Name", "Name"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Journal_Credit", "Credit", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Journal_Description", "Description")})

                .DataSource = class_Saga_Variables.liquidation.Properties.DataSource
                .DisplayMember = "Journal_Reference"
                .ValueMember = "Journal_Reference"
                .NullValuePrompt = "Select Liquidation..."
            End With
        End Sub

        Public Sub Initialize_Liquidation(ByVal liquidationSearchLookUpEdit As SearchLookUpEdit, ByVal liquidationView As GridView)
            With liquidationView
                .Columns.Clear()
                Dim colID As GridColumn = New GridColumn
                Dim colJournal_Reference As GridColumn = New GridColumn
                Dim colPosting_Date As GridColumn = New GridColumn
                Dim colAccount_Name As GridColumn = New GridColumn
                Dim colJournal_Credit As GridColumn = New GridColumn
                Dim colJournal_Description As GridColumn = New GridColumn

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

            With liquidationSearchLookUpEdit.Properties
                .DataSource = class_Saga_Variables.liquidation.Properties.DataSource
                .DisplayMember = "Journal_Reference"
                .ValueMember = "Journal_Reference"
                .NullValuePrompt = "Select Liquidation..."
            End With
        End Sub

        Public Sub Initialize_Engine_Chassis(ByVal engine As LookUpEdit)
            With engine.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("engineno", "Engine"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("chassisno", "Chassis"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("brand", "Brand"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Description")})

                .DataSource = class_Saga_Variables.engine.Properties.DataSource
                .DisplayMember = "engineno"
                .ValueMember = "engineno"
                .NullValuePrompt = "Select Engine..."
            End With
        End Sub

        Public Sub Initialize_Engine_Received(ByVal engineReceived As LookUpEdit)
            With engineReceived.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("engineno", "Engine"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("chassisno", "Chassis"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("brand", "Brand"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("model", "Model"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "Color")})

                .DataSource = class_Saga_Variables.engineReceived.Properties.DataSource
                .DisplayMember = "engineno"
                .ValueMember = "engineno"
                .NullValuePrompt = "Select Engine..."
            End With
        End Sub

        Public Sub Initialize_Employee(ByVal employee As LookUpEdit)
            With employee.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee_Code", "Code"), '-1, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Default, Data.ColumnSortOrder.None),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Engine", "Engine", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default, Data.ColumnSortOrder.None),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee_Position", "Designation"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee_Name", "Name", -1, DevExpress.Utils.FormatType.None, String.Empty, True, DevExpress.Utils.HorzAlignment.Default, Data.ColumnSortOrder.Ascending)})

                .DataSource = class_Saga_Variables.employee.Properties.DataSource
                .DisplayMember = "Employee_Name"
                .ValueMember = "Employee_Code"
                .NullValuePrompt = "Select Employee..."
            End With
        End Sub

        Public Sub Initialize_Employee(ByVal employee As RepositoryItemLookUpEdit)
            With employee
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee_Code", "Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee_Name", "Name")})

                .DataSource = class_Saga_Variables.employee.Properties.DataSource
                .DisplayMember = "Employee_Name"
                .ValueMember = "Employee_Code"
                .NullValuePrompt = "Select Employee..."

                class_Procedures.Initialize_RepositoryItem(employee, XtraEditors.Controls.TextEditStyles.Standard)
            End With
        End Sub

        Public Sub Initialize_User(ByVal user As LookUpEdit)
            With user.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("username", "User"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fullname", "Name")})

                .DataSource = class_Saga_Variables.user.Properties.DataSource
                .DisplayMember = "fullname"
                .ValueMember = "username"
                .NullValuePrompt = "Select User..."
            End With
        End Sub

        Public Sub Initialize_Unit_Status(ByVal unitStatus As LookUpEdit)
            With unitStatus.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("whcategorycode", "Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("whcategorydesc", "Category")})

                .DataSource = class_Saga_Variables.unitStatus.Properties.DataSource
                .DisplayMember = "whcategorydesc"
                .ValueMember = "whcategorycode"
                .NullValuePrompt = "Select Category..."
            End With
        End Sub

        Public Sub Initialize_Brand(ByVal brand As LookUpEdit)
            With brand.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand_Code", "Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("branddesc", "Brand"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Code", "Account Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Name", "Supplier"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Mobile", "Contact Number(s)"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Address", "Address"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Description", "Description")})

                .DataSource = class_Saga_Variables.brand.Properties.DataSource
                .DisplayMember = "branddesc"
                .ValueMember = "Brand_Code"
                .NullValuePrompt = "Select Brand..."
            End With
        End Sub

        Public Sub Initialize_Brand(ByVal brand As RepositoryItemLookUpEdit)
            With brand
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand_Code", "Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("branddesc", "Brand"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Code", "Account Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Name", "Supplier"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Mobile", "Contact Number(s)"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Address", "Address"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Description", "Description")})

                .DataSource = class_Saga_Variables.brand.Properties.DataSource
                .DisplayMember = "branddesc"
                .ValueMember = "Brand_Code"
                .NullValuePrompt = "Select Brand..."
            End With
        End Sub

        Public Sub Initialize_Brand_Supplier(ByVal supplier As RepositoryItemLookUpEdit)
            With supplier
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Code", "Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Name", "Supplier Name"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Mobile", "Contact Number(s)"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Address", "Address"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Description", "Description")})

                .DataSource = class_Saga_Variables.brandSupplier.Properties.DataSource
                .DisplayMember = "Account_Name"
                .ValueMember = "Account_Code"
                .NullValuePrompt = "Select Supplier..."
            End With
        End Sub

        Public Sub Initialize_Brand_Supplier(ByVal brand As LookUpEdit)
            With brand.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Code", "Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Name", "Supplier Name"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Mobile", "Contact Number(s)"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Address", "Address"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Description", "Description")})

                .DataSource = class_Saga_Variables.brandSupplier.Properties.DataSource
                .DisplayMember = "Account_Name"
                .ValueMember = "Account_Code"
                .NullValuePrompt = "Select Supplier..."
            End With
        End Sub

        Public Sub Initialize_MC_Model(ByVal model As LookUpEdit, Optional ByVal sMember As String = "Model_Code")
            With model.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Model_Code", "Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("branddesc", "Brand", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Model", "Model"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modeldesc", "Sub-Model"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Color", "Color"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custom_Color", "Custom"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Unit_Cost", "Cost", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description")})

                .DataSource = class_Saga_Variables.mcModel.Properties.DataSource
                .DisplayMember = sMember
                .DropDownRows = 100
                .ValueMember = sMember
                .NullValuePrompt = "Select Model..."
            End With
        End Sub

        Public Sub Initialize_MC_Model(ByVal model As RepositoryItemLookUpEdit, Optional ByVal sMember As String = "Model_Code")
            With model
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Model_Code", "Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("branddesc", "Brand", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Model", "Model"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modeldesc", "Sub-Model"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Color", "Color"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custom_Color", "Custom"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Unit_Cost", "Cost", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description")})

                .DataSource = class_Saga_Variables.mcModel.Properties.DataSource
                .DisplayMember = sMember
                .ValueMember = sMember
                .NullValuePrompt = "Select Model..."
            End With
        End Sub

        'Public Sub Initialize_Category(ByVal category As RepositoryItemLookUpEdit)
        '    With category
        '        .Columns.Clear()
        '        .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
        '                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
        '                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category_Description", "Category")})

        '        .DataSource = class_Saga_Variables.category.Properties.DataSource
        '        .DisplayMember = "Category_Description"
        '        .ValueMember = "Category_Description"
        '        .NullValuePrompt = "Select Category..."
        '    End With
        'End Sub

        Public Sub Initialize_Parts_Number(ByVal partsnumber As RepositoryItemLookUpEdit)
            With partsnumber
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsNumber", "Part Number"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PriceWOVAT", "Cost", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category", "Category", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRP", "SRP", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsName", "Parts Name")})

                .DataSource = class_Saga_Variables.partsnumber.Properties.DataSource
                .DisplayMember = "PartsNumber"
                .ValueMember = "PartsNumber"
                .NullValuePrompt = "Select Part Number..."
            End With
        End Sub

        Public Sub Initialize_Trans_Category(ByVal trans_Category As RepositoryItemLookUpEdit)
            With trans_Category
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransactionID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Transactions", "Categories"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mnemonic", "Mnemonic")})

                .DataSource = class_Saga_Variables.trans_Category.Properties.DataSource
                .DisplayMember = "Transactions"
                .ValueMember = "Transactions"
                .NullValuePrompt = "Select Transaction Category..."
            End With
        End Sub

        Public Sub Initialize_Parts_Numbers(ByVal partsnumbers As RepositoryItemLookUpEdit)
            With partsnumbers
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsNumber", "Part Number"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Quantity", "Quantity", -1, DevExpress.Utils.FormatType.Numeric, "d", True, DevExpress.Utils.HorzAlignment.Far),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SPCostWOVAT", "Cost", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category", "Category", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand", "Brand", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRP", "SRP", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsName", "Part Name")})

                .DataSource = class_Saga_Variables.partsnumbers.Properties.DataSource
                .DisplayMember = "PartsNumber"
                .ValueMember = "PartsNumber"
                .NullValuePrompt = "Select Part Number..."
            End With
        End Sub

        Public Sub Initialize_Parts_Numbers1(ByVal partsnumbers As RepositoryItemLookUpEdit)
            With partsnumbers
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsNumber", "Part Number"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Quantity", "Quantity", -1, DevExpress.Utils.FormatType.Numeric, "d", True, DevExpress.Utils.HorzAlignment.Far),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SPCostWOVAT", "Cost", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category", "Category", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand", "Brand", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRP", "SRP", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsName", "Part Name")})

                .DataSource = class_Saga_Variables.partsnumbers.Properties.DataSource
                .DisplayMember = "id"
                .ValueMember = "id"
                .NullValuePrompt = "Select Part Number..."
            End With
        End Sub

        Public Sub Initialize_Model_Color(ByVal color As RepositoryItemLookUpEdit)
            With color
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Color_Code", String.Empty, -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Color_Index", "Index"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Color", "Dominant"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("colordesc", "Color"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PNP_LTO_Input", "LTO Input"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Color_Description", "Description")})

                .DataSource = class_Saga_Variables.mcColor.Properties.DataSource
                .DisplayMember = "colordesc"
                .ValueMember = "colordesc"
                .NullValuePrompt = "Select Color..."
            End With
        End Sub

        Public Sub Initialize_Tran_Category(ByVal trans_Category As LookUpEdit)
            With trans_Category.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransactionID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Transactions", "Categories"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mnemonic", "Mnemonic")})

                .DataSource = class_Saga_Variables.trans_Category.Properties.DataSource
                .DisplayMember = "Transactions"
                .ValueMember = "Transactions"
                .NullValuePrompt = "Select Transaction Category..."
            End With
        End Sub

        Public Sub Initialize_Invoices(ByVal invoices As LookUpEdit)
            With invoices.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Invoices", "Invoices"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mnemonic", "Mnemonic")})

                .DataSource = class_Saga_Variables.invoices.Properties.DataSource
                .DisplayMember = "Invoices"
                .ValueMember = "Invoices"
                .NullValuePrompt = "Select Invoices..."
            End With
        End Sub

        Public Sub Initialize_Purchase_Order(ByVal purchaseOrder As LookUpEdit)
            With purchaseOrder.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order_Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand_Name", "Brand"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Name", "Supplier"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order_Date", "P. O. Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Total_Quantity", "Quantity"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Total_Received", "Received"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Total_Remaining", "Remaining"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order_Description", "Description")})

                .DataSource = class_Saga_Variables.purchaseOrder.Properties.DataSource
                .DisplayMember = "Order_Code"
                .ValueMember = "Order_Code"
                .NullValuePrompt = "Select P. O. Number..."
            End With
        End Sub
        Public Sub Initialize_SPA_Request(ByVal SPA_Request As LookUpEdit)
            With SPA_Request.Properties

                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRF", "SRF Number"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Reference", "Reference"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch_From", "Branch From"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Transaction_Date", "P. O. Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far)})

                .DataSource = class_Saga_Variables.SPA_Request.Properties.DataSource
                .DisplayMember = "Reference"
                .ValueMember = "Reference"
                .NullValuePrompt = "Select SFR..."
            End With
        End Sub
        Public Sub Initialize_SPA_Purchase_Order(ByVal SPA_purchaseOrder As LookUpEdit)
            With SPA_purchaseOrder.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order_Code", ""),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand", "Brand"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Supplier_Name", "Supplier"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order_Date", "P. O. Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("QTY_Total", "Quantity"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order_Description", "Description")})

                .DataSource = class_Saga_Variables.SPA_purchaseOrder.Properties.DataSource
                .DisplayMember = "Order_Code"
                .ValueMember = "Order_Code"
                .NullValuePrompt = "Select P. O. Number..."
            End With
        End Sub

        Public Sub Initialize_MC_Units(ByVal mcUnit As RepositoryItemLookUpEdit)
            With mcUnit
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("whCode", "Status"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Model_Code", "Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("engineno", "Engine"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("chassisno", "Chassis"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("brand", "Brand"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("model", "Model"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "Color"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Description"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("note", "Notes")})

                .DataSource = class_Saga_Variables.mcUnit.Properties.DataSource
                .DisplayMember = "engineno"
                .ValueMember = "engineno"
                .NullValuePrompt = "Select Engine..."
            End With
            class_Procedures.Initialize_RepositoryItem(mcUnit, XtraEditors.Controls.TextEditStyles.Standard)
        End Sub

        Public Sub Initialize_Inclusions(ByVal inclusion As LookUpEdit)
            With inclusion.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Inclusion_Code", "Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Inclusion_Type", "Type"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Inclusion_Name", "Name"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Notes")})

                .DataSource = class_Saga_Variables.inclusion.Properties.DataSource
                .DisplayMember = "Inclusion_Name"
                .ValueMember = "Inclusion_Code"
                .NullValuePrompt = "Select Inclusion..."
            End With
        End Sub

        Public Sub Initialize_Asset_Items(ByVal assetItem As LookUpEdit)
            With assetItem.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Asset_Code", "Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Department", "Department"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category", "Category"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sub_Category", "Sub-Category"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Asset_Name", "Name"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Asset_Description", "Description"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Notes")})

                .DataSource = class_Saga_Variables.assetItem.Properties.DataSource
                .DisplayMember = "Asset_Name"
                .ValueMember = "Asset_Code"
                .NullValuePrompt = "Select Asset Item..."
            End With
        End Sub

        Public Sub Initialize_Asset_Items(ByVal assetItem As RepositoryItemLookUpEdit)
            With assetItem
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Asset_Code", "Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Department", "Department"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category", "Category"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sub_Category", "Sub-Category"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Asset_Name", "Name"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Asset_Description", "Description"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Notes")})

                .DataSource = class_Saga_Variables.assetItem.Properties.DataSource
                .DisplayMember = "Asset_Name"
                .ValueMember = "Asset_Code"
                .NullValuePrompt = "Select Asset Item..."
            End With
        End Sub

        Public Function Show_Login(ByVal sTitle As String) As Boolean
            Dim frm As Forms.Security.frm_Login = New Forms.Security.frm_Login With {
                .Text = $"Login - {sTitle}"
            }
            frm.ShowDialog()
            Return class_Saga_Variables.bIsLogged_In
        End Function

        Public Function Show_Password_Change(ByVal sCorporation As String, ByVal sUserName As String, ByVal bNeedOldPassword As Boolean) As Boolean
            If Not class_Saga_Variables.bIsLogged_In AndAlso bNeedOldPassword Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "You cannot change your password if you're not logged in.", "Change Password Error", True)
                Return False
            End If

            Dim frm As Forms.Security.frm_Password_Change = New Forms.Security.frm_Password_Change With {
                .TopMost = True,
                .Text = $"{ .Text} - {sUserName}",
                .sCorporation = sCorporation,
                .sUserName = sUserName,
                .bNeedOldPassword = bNeedOldPassword
            }
            Return frm.ShowDialog()

        End Function

        Public Sub Show_Server_Connection(Optional ByVal sCaption As String = "SQL Connection")
            class_Procedures.splash_Show("showing SQL Server Connection Form", sCaption)
            Dim frm As Forms.Security.frm_Connection = New Forms.Security.frm_Connection() With {
            .TopMost = True
        }
            frm.Show()
            If class_Database.DBError Then
                frm.Text = $"{sCaption} Error"
            Else
                frm.Text = sCaption
            End If
            frm.Xuc_SQL_Connection.registry_Load()
            class_Procedures.splash_Close()
        End Sub

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
                    class_Procedures.splash_Show($"pdating IsJournal Transactions of the selected {sTable}")

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()


                    bLoopStop = False
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
                        Catch Ex As Exception

                        End Try

                        If class_Functions.GridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal Entry Verification", "verified", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim iTableID As Integer
                        Try
                            iTableID = CInt(.GetRowCellValue(iRowHandle, colTableID))
                        Catch Ex As Exception
                            Continue For
                        End Try

                        Dim sReference As String = .GetRowCellDisplayText(iRowHandle, colReference).Trim()
                        Dim sBrCode As String = String.Empty

                        Try
                            sBrCode = branchCode.GetKeyValueByDisplayText(.GetRowCellDisplayText(iRowHandle, colBranchCode.FieldName))
                        Catch Ex As Exception
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"{iTableID}{Environment.NewLine}{Ex.Source}{Environment.NewLine}{Ex.Message}")
                        End Try

                        Try
                            class_Saga_Database.Verify_Transaction(sTable, gridView, colNotes, iRowHandle, iTableID, sReference, CDec(.GetRowCellValue(iRowHandle, colTotal)), colTableID.FieldName, bAccountCodeAsReference)
                        Catch Ex As Exception
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Sql, $"{iTableID}{Environment.NewLine}{Ex.Source}{Environment.NewLine}{Ex.Message}")
                            bLoopStop = True
                        End Try
                    Next
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"IsJOurnal Transactions of the selected {sTable} were Updated.", "IsJournal Update")
                    class_Procedures.splash_Close()
                End If
            End With
        End Sub

        Public Sub Show_Account_Executive(ByVal sCode As String)
            class_Procedures.splash_Show("Account Executive")
            Dim frm As Forms.Persons.frm_Account_Executive = New Forms.Persons.frm_Account_Executive() With {
            .Text = $"{ .Text} - {sCode}"
        }

            With frm
                .Show()
                .Xuc_Account_Executive.Control_Initialize()
                .Xuc_Account_Executive.Control_Retrieve(sCode)
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Agent(ByVal sCode As String)
            class_Procedures.splash_Show("Agent Information")
            Dim frm As frm_Agent = New frm_Agent() With {
            .Text = $"{ .Text} - {sCode}"
        }

            With frm
                .Xuc_Agent.Control_Initialize()
                .Xuc_Agent.Control_Retrieve(sCode)
                .Show()
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Unit_Model(ByVal sCode As String)
            class_Procedures.splash_Show("Unit Information")
            Dim frm As Forms.Information.Item.frm_Unit_Model = New Forms.Information.Item.frm_Unit_Model() With {
            .Text = $"{ .Text} - {sCode}"
        }

            With frm
                .Xuc_Item.Control_Initialize()
                .Xuc_Item.Control_Retrieve(sCode)
                .Show()
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Unit_Cost(ByVal sID As String)
            class_Procedures.splash_Show("Item Cost")
            Dim frm As frm_Unit_Costing = New frm_Unit_Costing()

            frm.load_Unit_Cost(sID)
            frm.Show()
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Transport(ByVal sCode As String)
            class_Procedures.splash_Show("Logistic Transport")
            Dim frm As frm_Logistic_Transport = New frm_Logistic_Transport()
            frm.Show()
            class_Saga_Procedures.Initialize_Branch(frm.Xuc_Transport.Branch_From)
            class_Saga_Procedures.Initialize_Branch(frm.Xuc_Transport.Branch_To)
            frm.Xuc_Transport.Control_Retrieve(sCode)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Unit_Inventory(ByVal sCode As String, Optional ByVal bUpdate As Boolean = False, Optional ByVal sTitle As String = "Unit Inventory")
            class_Procedures.splash_Show("Unit Inventory")
            Dim frm As Forms.Logistics.frm_Unit_Inventory = New Forms.Logistics.frm_Unit_Inventory With {.Text = $"{ .Text} {sTitle}"}
            frm.Show()

            frm.Btn_Generate.Enabled = bUpdate
            frm.Btn_Save.Enabled = bUpdate
            frm.Btn_Delete.Enabled = bUpdate

            frm.BarEditItem_Search.EditValue = sCode
            frm.Load_Search(sCode)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Unit_Inventory(ByVal sQuery As String, ByVal sTitle As String)
            class_Procedures.splash_Show("Unit Inventory")
            Dim frm As Forms.Logistics.frm_Unit_Inventory = New Forms.Logistics.frm_Unit_Inventory With {.Text = sTitle}
            frm.Show()
            frm.Btn_Generate.Enabled = False
            frm.Load_Query(sQuery)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Logistics_Transports(ByVal sCode As String)
            class_Procedures.splash_Show("Unit Item history")
            Dim frm As Forms.Logistics.frm_Logistic_Transports = New Forms.Logistics.frm_Logistic_Transports
            frm.Show()
            frm.BarEditItem_Search.EditValue = sCode
            frm.Load_Search(sCode)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Customer(ByVal sCode As String)
            class_Procedures.splash_Show("Customer Information")
            Dim frm As frm_Customer = New frm_Customer() With {
            .TopMost = True
        }
            frm.Show()
            frm.Xuc_Customer.Control_Retrieve(sCode)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Releases(ByVal sBrCode As String, ByVal dtGranted As Date, Optional ByVal iID As Integer = 0, Optional ByVal sEngine As String = "", Optional ByVal sAccount As String = "")
            class_Procedures.splash_Show("Sales/Releases")
            Dim frm As Forms.Accounting.frm_Releases = New Forms.Accounting.frm_Releases() With {
            .Text = $"{ .Text} - {sAccount}"
        }
            frm.Xuc_Settings.Check_Auto_Reload.Checked = False
            frm.Show()
            frm.Xuc_Accounts.Control_Data_Load(sBrCode, class_Functions.FirstDayOfMonth(dtGranted), class_Functions.LastDayOfMonth(dtGranted), iID, sEngine)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Account(ByVal eLoadType As eLoad_Type, ByVal sCode As String, Optional ByVal sLedger As Integer = 1, Optional ByVal sName As String = "Account Information", Optional ByVal bEnableEdit As Boolean = False)
            class_Procedures.splash_Show("Account Information")
            Dim frm As Forms.Information.Account.frm_Account = New Forms.Information.Account.frm_Account() With {
                .TopMost = True,
            .Text = $"{sName} {sCode} {sLedger}"
        }

            With frm
                .Show()

                .Btn_Post_Payment.Enabled = bEnableEdit
                .Btn_Migrate.Enabled = bEnableEdit
                .Btn_New.Enabled = bEnableEdit
                .Btn_Save.Enabled = bEnableEdit
                .Btn_Delete.Enabled = bEnableEdit

                .Xuc_Account.Control_Initialize_Lookups()

                class_Database.Fill_Edit(class_Database.ICSConnection, .Xuc_Account.Account_Ledger, "CustAccount", "AccountNumber", "LedgerSetNumber", sCode)

                Select Case eLoadType
                    Case eLoad_Type.ID
                        .Xuc_Account.Control_Retrieve($"SELECT * FROM CustAccount WHERE sequenceNo LIKE '{sCode}'")
                    Case eLoad_Type.CIF
                        .Xuc_Account.Control_Retrieve($"SELECT * FROM CustAccount WHERE CIFKey LIKE '{sCode}' AND LedgerSetNumber LIKE '{sLedger}'")
                    Case eLoad_Type.Ledger
                        .Xuc_Account.Control_Retrieve($"SELECT * FROM CustAccount WHERE AccountNumber LIKE '{sCode}' AND LedgerSetNumber LIKE '{sLedger}'")
                    Case eLoad_Type.Engine
                        .Xuc_Account.Control_Retrieve($"SELECT * FROM CustAccount WHERE engineno LIKE '{sCode}' OR chassisno LIKE '{sCode}' ORDER BY id DESC")
                End Select
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Ammortization(ByVal frmOwner As XtraForm, ByVal sBrCode As String, ByVal sAccount As String, ByVal iLedger As Integer)
            Dim frm As Forms.Information.Account.frm_Amortization_Schedule = New Forms.Information.Account.frm_Amortization_Schedule() With {
            .Left = frmOwner.Left + frmOwner.Width
            }
            frm.Show()
            frm.Control_Load(sBrCode, sAccount, iLedger)
        End Sub

        Public Sub Show_Ammortization(ByVal sBrCode As String, ByVal sAccount As String, ByVal iLedger As Integer)
            Dim frm As Forms.Information.Account.frm_Amortization_Schedule = New Forms.Information.Account.frm_Amortization_Schedule()
            frm.Show()
            frm.Control_Load(sBrCode, sAccount, iLedger)
        End Sub

        Public Sub Show_Owners(ByVal sEngine As String)
            class_Procedures.splash_Show("Item Unit Owners")
            Dim frm As Forms.Information.Account.frm_Accounts = New Forms.Information.Account.frm_Accounts() With {
            .Text = $"Previous Owners of Engine#: {sEngine}"
        }
            frm.Show()
            frm.Xuc_Accounts.Load_Search(sEngine)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Account_Ledgers(ByVal sBrCode As String, ByVal sAccount As String, ByVal sLedger As String, ByVal sName As String)
            class_Procedures.splash_Show("Account Ledger")
            Dim frm As frm_Account_Ledgers = New frm_Account_Ledgers() With {
            .Text = $"Account Ledger: {sName} {sAccount}-{sLedger}"
        }

            With frm
                .Show()
                .Xuc_Grid_Ledger.sBrCode = sBrCode
                .Xuc_Grid_Ledger.sAccount = sAccount
                .Xuc_Grid_Ledger.sLedger = sLedger
                .Xuc_Grid_Ledger.Control_Data_Load(sBrCode, sAccount, sLedger)
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Account_Ledger(ByVal sID As String)
            class_Procedures.splash_Show("Account Ledger Record")
            Dim frm As Forms.Information.Account.frm_Account_Ledger_Record = New Forms.Information.Account.frm_Account_Ledger_Record() With {
            .Text = $"Account Ledger: {sID}",
            .TopMost = True
        }
            frm.Show()
            frm.Xuc_Account_Ledger.Control_Retrieve(sID)

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Account_Payments(ByVal sAccountNumber As String, ByVal iLedger As Integer, ByVal sAccountName As String) 'ByVal sBrCode As String,
            class_Procedures.splash_Show("Account Payments")
            Dim frm As Forms.Information.Account.frm_Account_Payments = New Forms.Information.Account.frm_Account_Payments() With {
            .Text = $"PAYMENTS: Name:{sAccountName} Account:{sAccountNumber} Ledger:{iLedger} "
        }

            With frm
                .Show()
                .Xuc_Account_Payments.eLoadType = eLoad_Type.Account
                '.Xuc_Account_Payments.sBrCode = sBrCode
                .Xuc_Account_Payments.sAccountNumber = sAccountNumber
                .Xuc_Account_Payments.iLedger = iLedger
                .Xuc_Account_Payments.sAccountName = sAccountName
                .Xuc_Account_Payments.Control_Data_Load(sAccountNumber, iLedger)
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Account_Payment(ByVal isCashiering As Boolean, ByVal sID As String)
            class_Procedures.splash_Show("Account Payment")
            Dim frm As frm_Account_Payment = New frm_Account_Payment With {
            .isCashiering = isCashiering
        }

            With frm
                .Show()
                If isCashiering Then
                    .Text = $"Inter-Branch Payment ID: {sID}"
                Else
                    .Text = $"Local Branch Payment ID: {sID}"
                End If
                .Xuc_Account_Payment.TransactionDate.Enabled = False
                .Xuc_Account_Payment.Control_Retrieve(isCashiering, sID)
                .Xuc_Account_Payment.Control_Initialize()
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Branch_Collections(ByVal sBrCode As String, ByVal dtPosting As Date, ByVal iTableID As Integer, ByVal sReference As String, Optional ByVal sAccountName As String = "")
            class_Procedures.splash_Show("Branch Collections")
            Dim frm As Forms.Accounting.frm_Collection = New Forms.Accounting.frm_Collection() With {
            .Text = $"{sAccountName} {dtPosting.ToLongDateString}"
        }
            frm.Show()

            With frm.Xuc_Grid_Collection
                .eLoadType = eLoad_Type.Batch
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
            Dim frm As Forms.Accounting.frm_Cashiering = New Forms.Accounting.frm_Cashiering() With {
            .Text = $"{sAccountName} {dtPosting.ToLongDateString}"
        }
            frm.Show()
            With frm.Xuc_Grid_Cashiering
                .eLoadType = eLoad_Type.Batch
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
            Dim frm As Forms.Spare_Parts.frm_SPA_Sales_Accounting = New Forms.Spare_Parts.frm_SPA_Sales_Accounting() With {
            .Text = $"{sAccountName} {dtStart.ToLongDateString} - {dtEnd.ToLongDateString}"
        }
            With frm
                .Show()
                .Data_Load(sBrCode, dtStart, iTableID, sORNumber)
            End With
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Credit_Memo(ByVal sBrCode As String, ByVal dtStart As Date, ByVal iTableID As Integer, ByVal sEngine As String, Optional ByVal sAccountName As String = "")
            class_Procedures.splash_Show("Branch Collections")
            Dim frm As Forms.Accounting.frm_Credit_Memo = New Forms.Accounting.frm_Credit_Memo() With {
            .Text = $"{sAccountName} {dtStart.ToLongDateString} - {dtEnd.ToLongDateString}"
        }
            With frm
                .Show()
                .barEditItem_Branch.EditValue = sBrCode
                .dtPosting = dtStart
                .iTableID = iTableID
                .Data_Load(iTableID, sEngine)
            End With
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Post_Payment(ByVal sCode As String, ByVal sLedger As String)
            Dim frm As frm_Post_Payment = New frm_Post_Payment() With {
            .TopMost = True
        }
            frm.Show()
            frm.Account_Number.Text = sCode
            frm.Account_Ledger.Text = sLedger
        End Sub

        Public Sub Show_COA(ByVal sCode As String, Optional ByVal bNew As Boolean = False)
            class_Procedures.splash_Show("Chart of Account")
            Dim frm As frm_Chart_Of_Account = New frm_Chart_Of_Account() With {
            .TopMost = True
        }
            frm.Show()

            With frm.Xuc_Chart_Of_Account
                .Control_Initialize()

                If bNew Then
                    .Control_New(bNew)
                Else
                    .Control_Retrieve(sCode)
                End If
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Account_Name_New(ByVal sCode As String, ByVal sName As String)
            Dim frm As frm_Account_Name = New frm_Account_Name() With {
            .TopMost = True
        }

            With frm
                .Show()
                .Xuc_Account_Name.Control_Initialize()
                .Xuc_Account_Name.Control_New(False)
                .Xuc_Account_Name.Account_Name.Text = sName
            End With
        End Sub

        Public Sub Show_Account_Name(ByVal sCode As String, Optional ByVal bNew As Boolean = False)
            Dim frm As frm_Account_Name = New frm_Account_Name() With {
            .TopMost = True
        }
            frm.Show()
            With frm.Xuc_Account_Name
                .Control_Initialize()

                If bNew Then
                    .Control_New(bNew)
                Else
                    .Control_Retrieve(sCode)
                End If
            End With
        End Sub

        Public Sub Show_Account_Searched_Names(ByVal sSearch As String)
            Dim frm As frm_Accounts_Searched = New frm_Accounts_Searched() With {
            .TopMost = True
        }
            frm.Show()
            frm.BarEditItem_Search.EditValue = sSearch
            frm.Xuc_Accounts.Load_Search(sSearch)
        End Sub

        Public Sub Show_User_Activity(ByVal sCode As String)
            Dim frm As Forms.Persons.frm_User_Activities = New Forms.Persons.frm_User_Activities()
            frm.Show()
            frm.Data_Load(sCode)
        End Sub

        Public Sub Show_Journal_Entry(ByVal sID As String, Optional ByVal bNew As Boolean = False)
            class_Procedures.splash_Show("Journal Entry")
            Dim frm As frm_Journal_Entry = New frm_Journal_Entry() With {
            .TopMost = True
        }
            frm.Show()

            With frm.Xuc_Journal_Entry
                If bNew Then
                    '.Control_Initialize()
                    .Control_New(class_Saga_Variables.sBranchCode)
                Else
                    '.Control_Initialize(False)
                    .Control_Retrieve(sID)
                End If
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Voucher(ByVal sReference As String, Optional ByVal bNew As Boolean = False, Optional ByVal voucherType As eVoucherType = eVoucherType.Check, Optional ByVal sBrCode As String = "000", Optional ByVal sDescription As String = "")
            class_Procedures.splash_Show("Voucher Entry")
            Dim frm As frm_Voucher = New frm_Voucher() With {
                .Top = True,
                .Text = $" { .Text} - Reference: {sReference}"
            }
            frm.Show()
            frm.voucherType = voucherType

            With frm.Xuc_Voucher
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
            Dim frm As Forms.Accounting.frm_Bank_Account = New Forms.Accounting.frm_Bank_Account() With {
            .Text = $" { .Text}: {sBankAccount}"
        }
            frm.Show()
            frm.Xuc_Bank.Control_Initialize()
            frm.Xuc_Bank.Control_Retrieve(sBankAccount)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Check(ByVal sCheckNumber As String, Optional ByVal bNew As Boolean = False)
            class_Procedures.splash_Show("Check Number")
            Dim frm As frm_Check_Number = New frm_Check_Number() With {
            .Text = $" { .Text}: {sCheckNumber}"
        }
            frm.Show()

            With frm.Xuc_Check
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
            Dim frm As frm_Journal_Profile = New frm_Journal_Profile() With {
            .Text = $" { .Text}: {sProfileCode}"
        }
            frm.Show()
            'frm.Xuc_Journal_Profile.COA_Code.EditValue = sCOACode
            frm.Xuc_Journal_Profile.Control_Initialize()
            frm.Xuc_Journal_Profile.Control_Retrieve(sProfileCode)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_COA_Ledger(ByVal sCOACode As String, Optional sAccountTitle As String = "")
            class_Procedures.splash_Show("Journal Entry [Group]")
            Dim frm As frm_COA_Ledger = New frm_COA_Ledger() With {
           .Text = $" { .Text} - Account Title: {sAccountTitle}",
           .sCOACode = sCOACode
        }
            frm.Show()
            frm.Data_Load()
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_COA_Balances(ByVal sCOACode As String, Optional ByVal bPreCOACode As Boolean = False)
            class_Procedures.splash_Show("Account Balances")
            Dim frm As frm_COA_Balances = New frm_COA_Balances() With {
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
            Dim frm As Forms.Accounting.frm_Journal_Entries = New Forms.Accounting.frm_Journal_Entries() With {
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
                .GridView.ClearGrouping()
                .GridView.ClearColumnsFilter()

                Select Case eLoadTYpe
                    Case eLoad_Type.CIF
                        .Data_Load(sAccountNumber, sEngine)

                    Case Else
                        .Data_Load(sAccountNumber, sBrCode, bDateFilter, sQueryAdd)
                End Select
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Journal_Entries_Reference(ByVal sReference As String, Optional ByVal iID As Integer = 0, Optional ByVal sAccountCode As String = "", Optional ByVal sName As String = "", Optional ByVal sDescription As String = "", Optional ByVal sCheck As String = "0", Optional ByVal bAccountCodeAsReference As Boolean = False)
            class_Procedures.splash_Show($"Journal Entry [{sReference}]")
            Dim frm As Forms.Accounting.frm_Journal_Entries_Reference = New Forms.Accounting.frm_Journal_Entries_Reference() With {
            .sReference = sReference,
            .sDescription = sDescription,
            .sName = sName}

            With frm
                .Show()
                .Btn_Initialize.Enabled = False
                .Btn_New.Enabled = False
                .Btn_Save.Enabled = False
                .Btn_Update.Enabled = False
                .Btn_Validate.Enabled = False

                If sReference.Contains("VOUCHER") Then
                    .BarEditItem_Document_Title.EditValue = "CASH/CHECK VOUCHER"
                    .Xuc_Journal_Entries.voucherType = eVoucherType.Check
                Else
                    .BarEditItem_Document_Title.EditValue = "JOURNAL ENTRIES"
                    .Xuc_Journal_Entries.voucherType = eVoucherType.Journal
                End If

                If bAccountCodeAsReference Then
                    frm.Text = $"JOURNAL ENTRIES: Account Number-{sReference}"
                Else
                    frm.Text = $"JOURNAL ENTRIES: Reference-{sReference} Check#: {sCheck}"
                End If

                .BarEditItem_Remarks.EditValue = sDescription
            End With

            With frm.Xuc_Journal_Entries
                .sCheck = sCheck
                .sReference = sReference
                .sName = sName
                .sApprover = class_Saga_Functions.Approver
                .sDescription = sDescription

                .GridView.OptionsBehavior.Editable = False
                .Data_Load(sReference, iID,, bAccountCodeAsReference, sAccountCode)
            End With

            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Journal_Entries_Reference(ByVal iID As Integer, ByVal iIDTable As Integer, ByVal sReference As String, ByVal sBrCode As String, ByVal sType As String, ByVal sProfile As String, ByVal sCode As String, ByVal sName As String, ByVal dtPostingDate As Date, ByVal sApprover As String, Optional ByVal sCOACode As String = "", Optional ByVal sCheck As String = "0", Optional ByVal sDescription As String = "", Optional ByVal bForLiquidation As Boolean = False, Optional ByVal bLTO As Boolean = False)
            Dim frm As Forms.Accounting.frm_Journal_Entries_Reference = New Forms.Accounting.frm_Journal_Entries_Reference() With {
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
                    .Xuc_Journal_Entries.voucherType = eVoucherType.Check
                    .Xuc_Journal_Entries.sApprover = sApprover
                Else
                    .BarEditItem_Document_Title.EditValue = "JOURNAL ENTRIES"
                    .Xuc_Journal_Entries.voucherType = eVoucherType.Journal
                    .Xuc_Journal_Entries.sApprover = class_Saga_Functions.Approver
                End If

                class_Saga_Variables.Initialize_Check(sCOACode)
                class_Saga_Procedures.Initialize_Check(.Xuc_Journal_Entries.RepositoryItemLookUpEdit_Check_Numbers)

                .BarEditItem_Remarks.EditValue = sDescription
                .Xuc_Journal_Entries.iIDTable = iIDTable
                .Xuc_Journal_Entries.sReference = sReference
                .Xuc_Journal_Entries.sType = sType
                .Xuc_Journal_Entries.sProfile = sProfile
                .Xuc_Journal_Entries.sCode = sCode
                .Xuc_Journal_Entries.sName = sName
                .Xuc_Journal_Entries.sCheck = sCheck
                .Xuc_Journal_Entries.sBrCode = sBrCode
                .Xuc_Journal_Entries.dPostingDate = dtPostingDate
                .Xuc_Journal_Entries.sDescription = sDescription
                .Xuc_Journal_Entries.bForLiquidation = bForLiquidation
                .Xuc_Journal_Entries.bLTO = bLTO

                .Xuc_Journal_Entries.Data_Load(sReference, iID)
            End With
        End Sub

        Public Sub Show_Batch_Transactions(ByVal gridView As GridView, ByVal branchLUE As RepositoryItemLookUpEdit, ByVal sReference As String)
            Dim sJournalType As String = gridView.GetFocusedRowCellDisplayText("Journal_Type")
            Dim sBrCode As String = branchLUE.GetKeyValueByDisplayText(gridView.GetFocusedRowCellDisplayText("Branch_Code")).ToString
            Dim dtPostingDate As Date = CDate(gridView.GetFocusedRowCellValue("Posting_Date"))
            Dim iTableID As Integer = CInt(gridView.GetFocusedRowCellValue("Table_ID"))
            Dim sAccountCode As String = gridView.GetFocusedRowCellDisplayText("Account_Code")
            Dim sAccount As String = $"{gridView.GetFocusedRowCellDisplayText("Account_Code")} {gridView.GetFocusedRowCellDisplayText("Account_Name")}"

            If sJournalType.Contains("COLLECTION") Then
                class_Saga_Procedures.Show_Branch_Collections(sBrCode, dtPostingDate, iTableID, sReference, sAccount)

            ElseIf sJournalType.Contains("CASHIERING") Then
                If sJournalType.Contains("_SPA") Then
                    class_Saga_Procedures.Show_SPA_Sales(sBrCode, dtPostingDate, iTableID, sReference, sAccount)
                ElseIf sJournalType.Contains("_CM") Then
                    class_Saga_Procedures.Show_Credit_Memo(sBrCode, dtPostingDate, iTableID, sReference, sAccount)
                Else
                    class_Saga_Procedures.Show_Branch_Cashiering(sBrCode, dtPostingDate, iTableID, sReference, sAccount)
                End If

            ElseIf sJournalType.Equals("SPA_INVENTORY") Then
                class_Saga_Procedures.Show_SPA_Sales(sBrCode, dtPostingDate, iTableID, sReference, sAccount)

            ElseIf sJournalType.Contains("TRANSFER") Or sJournalType.Contains("RECEIVING") Then
                class_Saga_Procedures.Show_Unit_Inventory(sAccountCode, False)

            ElseIf sJournalType.Contains("RELEASE") Or sJournalType.Contains("ASSUME") Then
                class_Saga_Procedures.Show_Releases(sBrCode, dtPostingDate, iTableID, sReference, sAccount)
            End If
        End Sub

        Public Sub Print_Check(ByVal sBank As String, ByVal sCheckNumber As String, ByVal sName As String, ByVal dAmount As Decimal, ByVal dtPostingDate As Date, Optional ByVal sDescription As String = "", Optional ByVal sNotes As String = "")
            Dim xRpt As Reports.Accounting.xrpt_Check = New Reports.Accounting.xrpt_Check()
            Dim rpTool As ReportPrintTool = New ReportPrintTool(xRpt)

            xRpt.PaperKind = System.Drawing.Printing.PaperKind.Custom
            xRpt.PageWidth = 850
            xRpt.PageHeight = 300

            Try
                xRpt.XrL_Name.Text = sName
                xRpt.XrL_Amount_Numbers.Text = dAmount.ToString("N2")
                xRpt.XrL_Amount_Words.Text = class_Functions.AmountToWords(dAmount.ToString)
                xRpt.XrL_Date.Text = dtPostingDate.ToString("MMMM dd, yyyy")

                Using xuc_Check As New Controls.Accounting.xuc_Check
                    xuc_Check.Control_Check_Issue(sCheckNumber, sName, dAmount, True, dtPostingDate, sDescription, sNotes)
                End Using

                rpTool.ShowRibbonPreview()

                class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"Please verify parameters before Check Printing!{Environment.NewLine}Bank Account: {sBank}{Environment.NewLine}Check Number: {sCheckNumber}{Environment.NewLine}Print Date: {dtPostingDate:MMMM dd, yyyy}{Environment.NewLine}Check Amount: {xRpt.XrL_Amount_Numbers.Text}{Environment.NewLine}Payee Name: {xRpt.XrL_Name.Text}", "Check Printing Verification", True)
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

        Friend Sub Show_Employee(ByVal sCode As String)
            class_Procedures.splash_Show("Employee Profile")
            Dim frm As Forms.HR.frm_Employee = New Forms.HR.frm_Employee() With {
            .TopMost = True
        }
            frm.Show()
            class_Saga_Procedures.Initialize_Branch(frm.Xuc_Employee.Employee_Branch)
            frm.Xuc_Employee.Control_Retrieve(sCode)
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Expense(ByVal sBrCode As String, Optional ByVal iID As Integer = 0)
            class_Procedures.splash_Show("Expense Transaction")
            Dim frm As Forms.Petty_Cash.frm_Expense_Entry = New Forms.Petty_Cash.frm_Expense_Entry()
            With frm
                .Show()

                .Xuc_Expense.Branch_Code.EditValue = sBrCode
                .Xuc_Expense.Control_Initialize()

                If iID > 0 Then
                    .Btn_Initialize.Enabled = False
                    .Btn_Save.Enabled = False

                    .Xuc_Expense.Control_Retrieve(iID)
                End If
            End With
            class_Procedures.splash_Close()
        End Sub

        Public Sub Show_Expense_Summary(ByVal sBrCode As String, ByVal sQuery As String, ByVal sTitle As String, Optional ByVal sReference As String = "")
            Dim xRpt As New Reports.Petty_Cash.xrpt_Expense_Summary()
            class_Database.BindData(class_Database.ICSConnection, xRpt, sQuery, "TransactionPettyCash")

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
                        dtStart = CDate(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND Reference LIKE '{sReference}' ORDER BY PostingDate ASC", "PostingDate"))
                        dtEnd = CDate(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND Reference LIKE '{sReference}' ORDER BY PostingDate DESC", "PostingDate"))
                    Else
                        dtStart = CDate(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND IsDeleted <> 1 AND TransStatus NOT LIKE 'LIQUIDATED' ORDER BY PostingDate ASC", "PostingDate"))
                        dtEnd = CDate(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND IsDeleted <> 1 AND TransStatus NOT LIKE 'LIQUIDATED' ORDER BY PostingDate DESC", "PostingDate"))
                    End If

                    .XrTableCell_Period_Covered.Text = $"{dtStart:MMM dd, yyyy} - {dtEnd:MMM dd, yyyy}"

                    .XrTableCell_Admin_Cashier1.Text = class_Saga_Database.get_Admin_Cashier(sBrCode)
                    .XrTableCell_Admin_Cashier2.Text = .XrTableCell_Admin_Cashier1.Text

                    .XrTableCell_Manager.Text = class_Saga_Database.get_Branch_Manager(sBrCode)

                    If sBrCode.Equals("000") Then
                        .XrTableCell_Admin_Position.Text = "Accounting Assistant"
                        .XrTableCell_Manager_Position.Text = "Comptroller"
                    End If

                    .XrL_Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
                End With
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

        Public Sub Show_Payment_Request(ByVal sBrCode As String, ByVal sQuery As String, ByVal sTitle As String, Optional ByVal sReference As String = "")
            Dim xRpt As New Reports.Petty_Cash.xrpt_Payment_Request()
            class_Database.BindData(class_Database.ICSConnection, xRpt, sQuery, "TransactionPettyCash")

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1300

                    .label_Document_Title.Text = sTitle
                    .XrTableCell_Branch.Text = class_Saga_Database.get_Branch_Name(sBrCode)

                    .XrTableCell_Cashier.Text = class_Saga_Database.get_Admin_Cashier(sBrCode)
                    .XrL_Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"

                    .XrTableCell_Request_Date.Text = Date.Today.ToString("MMMM dd, yyyy")

                    Dim dtStart As Date
                    Dim dtEnd As Date

                    If sReference.Length > 0 Then
                        dtStart = CDate(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND Reference LIKE '{sReference}' ORDER BY PostingDate ASC", "PostingDate"))
                        dtEnd = CDate(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND Reference LIKE '{sReference}' ORDER BY PostingDate DESC", "PostingDate"))
                    Else
                        dtStart = CDate(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND IsDeleted <> 1 AND TransStatus NOT LIKE 'LIQUIDATED' ORDER BY PostingDate ASC", "PostingDate"))
                        dtEnd = CDate(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, PostingDate, TransStatus FROM TransactionPettyCash WHERE IsDeleted <> 1 AND BranchCode LIKE '{sBrCode}' AND IsDeleted <> 1 AND TransStatus NOT LIKE 'LIQUIDATED' ORDER BY PostingDate DESC", "PostingDate"))
                    End If

                    .XrTableCell_Period_Covered.Text = $"{dtStart:MMM dd, yyyy} - {dtEnd:MMM dd, yyyy}"
                End With
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

    End Module
End Namespace