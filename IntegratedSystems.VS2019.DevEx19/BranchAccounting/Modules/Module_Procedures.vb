Imports DevExpress
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraPrinting

Namespace Modules
    Module Module_Procedures

        Public Enum MsgMode
            Sql
            Info
            Warning
            Errorr
            Save
            Update
            Delete
        End Enum

        Public frm As New Forms.XtraForm_Main

        Public Sub Set_Message(ByVal msgMode As MsgMode, ByVal sTransaction As String, Optional ByVal sTitle As String = "", Optional ByVal bMessageBox As Boolean = False)
            Set_Message(frm, msgMode, sTransaction, sTitle, bMessageBox)
        End Sub

        Public Sub Set_Message(ByVal frm As XtraForm, ByVal msgMode As MsgMode, ByVal sTransaction As String, Optional ByVal sTitle As String = "", Optional ByVal bMessageBox As Boolean = False)
            Select Case msgMode
                Case MsgMode.Sql
                    Modules.sError = sTitle
                    If bMessageBox Then
                        MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Else
                        Modules.frm.AlertControl.Show(frm, $"SQL Error {sTitle}", sTransaction, Modules.frm.ImageCollection16.Images(0))
                    End If
                Case MsgMode.Info
                    If bMessageBox Then
                        MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Modules.frm.AlertControl.Show(frm, $"Information {sTitle}", sTransaction, "Information", Modules.frm.ImageCollection16.Images(1))
                    End If
                Case MsgMode.Warning
                    If bMessageBox Then
                        MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Modules.frm.AlertControl.Show(frm, $"Warning {sTitle}", sTransaction, Modules.frm.ImageCollection16.Images(2))
                    End If
                Case MsgMode.Errorr
                    Modules.sError = sTitle
                    If bMessageBox Then
                        MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Modules.frm.AlertControl.Show(frm, $"Error {sTitle}", sTransaction, Modules.frm.ImageCollection16.Images(3))
                    End If
                Case MsgMode.Update
                    If bMessageBox Then
                        MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Modules.frm.AlertControl.Show(frm, $"Modified/Updated {sTitle}", $"{sTransaction} has been successfully modified/updated.", Modules.frm.ImageCollection16.Images(4))
                    End If
                Case MsgMode.Save
                    If bMessageBox Then
                        MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Modules.frm.AlertControl.Show(frm, $"Saved/Added {sTitle}", $"{sTransaction} has been successfully saved/added.", Modules.frm.ImageCollection16.Images(5))
                    End If
                Case MsgMode.Delete
                    If bMessageBox Then
                        MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Modules.frm.AlertControl.Show(frm, $"Deleted/Removed {sTitle}", $"{sTransaction} has been successfully deleted/removed.", Modules.frm.ImageCollection16.Images(6))
                    End If
            End Select
            Application.DoEvents()
        End Sub

        Public Sub Loop_Stop_Message(ByVal sTransaction As String, ByVal sEvent As String, Optional ByRef sTitle As String = "")
            Set_Message(Modules.MsgMode.Warning, $"Some if the selected {sTransaction} has been unsuccessfully {sEvent} due to Network/Database Error or the user stopped the process.", sTitle)
        End Sub

        Public Sub Copy_Clipboard(ByVal sValue As String)
            Try
                Clipboard.SetDataObject(sValue, True)
                Set_Message(Modules.MsgMode.Info, $"{sValue} was copied into clipboard memory.")
            Catch Ex As ArgumentNullException
                Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.HResult}{Environment.NewLine}{Ex.Message}")
            Catch Ex As System.Runtime.InteropServices.ExternalException
                Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.HResult}{Environment.NewLine}{Ex.Message}")
            End Try
        End Sub

        Public Sub Initialize_Form(ByVal xForm As XtraForm, gridView As XtraGrid.Views.Grid.GridView, ByVal BtnCancel As SimpleButton)
            Initialize_Form(xForm, BtnCancel)

            Initialize_GridView(xForm, gridView)
        End Sub

        Public Sub Initialize_Form(ByVal xForm As XtraForm, ByVal BtnCancel As SimpleButton, Optional ByVal bCustomFormName As Boolean = False, Optional ByVal sCustomFormName As String = "")
            Dim iDefaultWidth As Integer
            Dim iDefaultHeight As Integer

            BtnCancel.DialogResult = DialogResult.Cancel
            BtnCancel.Location = New Point(0, 0)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New System.Drawing.Size(0, 0)

            xForm.StartPosition = FormStartPosition.Manual
            xForm.CancelButton = BtnCancel
            xForm.Controls.Add(BtnCancel)

            Select Case xForm.FormBorderStyle
                Case FormBorderStyle.Sizable
                    iDefaultWidth = 800
                    iDefaultHeight = 600

                Case Else
                    iDefaultWidth = 300
                    iDefaultHeight = 400
            End Select

            If bCustomFormName Then
                xForm.Top = Module_Tools.RegKeyGet($"{xForm.Name}-{sCustomFormName}", "Top", 100)
                xForm.Left = Module_Tools.RegKeyGet($"{xForm.Name}-{sCustomFormName}", "Left", 100)
                xForm.Width = Module_Tools.RegKeyGet($"{xForm.Name}-{sCustomFormName}", "Width", iDefaultWidth)
                xForm.Height = Module_Tools.RegKeyGet($"{xForm.Name}-{sCustomFormName}", "Height", iDefaultHeight)
            Else
                xForm.Top = Module_Tools.RegKeyGet(xForm.Name, "Top", 100)
                xForm.Left = Module_Tools.RegKeyGet(xForm.Name, "Left", 100)
                xForm.Width = Module_Tools.RegKeyGet(xForm.Name, "Width", iDefaultWidth)
                xForm.Height = Module_Tools.RegKeyGet(xForm.Name, "Height", iDefaultHeight)
            End If

            Modules.Initialize_Controls(xForm)

        End Sub

        Public Sub Initialize_Controls(ByVal control As System.Windows.Forms.Control, Optional ByVal bClear As Boolean = False)
            For Each item In control.Controls
                If item.GetType = GetType(TextEdit) Then
                    CType(item, TextEdit).EnterMoveNextControl = True
                    CType(item, TextEdit).Properties.NullValuePrompt = "Input value..."
                    CType(item, TextEdit).Properties.NullValuePromptShowForEmptyValue = True
                    CType(item, TextEdit).EnterMoveNextControl = True
                    If bClear Then CType(item, TextEdit).Text = Nothing

                    If CType(item, TextEdit).Name.Equals("ID") Or CType(item, TextEdit).Name.Equals("id") Then CType(item, TextEdit).Enabled = False
                    'If CType(item, TextEdit).Name.Contains("Code") Then CType(item, TextEdit).Enabled = False

                    If CType(item, TextEdit).Name.Contains("Code") Or CType(item, TextEdit).Name.Contains("Type") Or CType(item, TextEdit).Name.Contains("Name") Or CType(item, TextEdit).Name.Contains("Profile") Or CType(item, TextEdit).Name.Contains("Engine") Or CType(item, TextEdit).Name.Contains("Chassis") Then
                        CType(item, TextEdit).Properties.CharacterCasing = CharacterCasing.Upper
                    End If

                ElseIf item.GetType = GetType(ButtonEdit) Then
                    CType(item, ButtonEdit).EnterMoveNextControl = True
                    CType(item, ButtonEdit).Properties.NullValuePrompt = "Input value..."
                    CType(item, ButtonEdit).Properties.NullValuePromptShowForEmptyValue = True
                    CType(item, ButtonEdit).EnterMoveNextControl = True
                    If bClear Then CType(item, ButtonEdit).Text = Nothing

                    If CType(item, ButtonEdit).Name.Contains("Code") Or CType(item, ButtonEdit).Name.Contains("Name") Or CType(item, ButtonEdit).Name.Contains("Profile") Or CType(item, ButtonEdit).Name.Contains("Engine") Or CType(item, ButtonEdit).Name.Contains("Chassis") Then
                        CType(item, TextEdit).Properties.CharacterCasing = CharacterCasing.Upper
                    End If

                ElseIf item.GetType = GetType(ComboBoxEdit) Then
                    CType(item, ComboBoxEdit).EnterMoveNextControl = True
                    CType(item, ComboBoxEdit).Properties.PopupSizeable = True
                    CType(item, ComboBoxEdit).Properties.NullValuePrompt = "SELECT or input value..."
                    CType(item, ComboBoxEdit).Properties.NullValuePromptShowForEmptyValue = True
                    CType(item, ComboBoxEdit).EnterMoveNextControl = True
                    If bClear Then CType(item, ComboBoxEdit).Text = Nothing

                    If CType(item, ComboBoxEdit).Name.Contains("Type") Or CType(item, TextEdit).Name.Contains("Brand") Then
                        CType(item, ComboBoxEdit).Properties.CharacterCasing = CharacterCasing.Upper
                    End If

                ElseIf item.GetType = GetType(PopupContainerEdit) Then
                    CType(item, PopupContainerEdit).EnterMoveNextControl = True
                    If bClear Then CType(item, PopupContainerEdit).Text = Nothing

                ElseIf item.GetType = GetType(CheckEdit) Then
                    CType(item, CheckEdit).EnterMoveNextControl = True
                    CType(item, CheckEdit).Checked = False

                ElseIf item.GetType = GetType(ToggleSwitch) Then
                    CType(item, ToggleSwitch).EnterMoveNextControl = True
                    CType(item, ToggleSwitch).EditValue = False

                ElseIf item.GetType = GetType(MemoEdit) Then
                    'Disabling EnterMoveNextControl makes
                    'MemoEdits should make newline by pressing Enter Key
                    CType(item, MemoEdit).EnterMoveNextControl = True
                    CType(item, MemoEdit).Properties.NullValuePrompt = "Input value..."
                    CType(item, MemoEdit).Properties.NullValuePromptShowForEmptyValue = True
                    If bClear Then CType(item, MemoEdit).Text = Nothing

                ElseIf item.GetType = GetType(TokenEdit) Then
                    CType(item, TokenEdit).EnterMoveNextControl = True
                    CType(item, TokenEdit).Properties.NullText = "Input value..."
                    If bClear Then CType(item, TokenEdit).EditValue = Nothing

                ElseIf item.GetType = GetType(SpinEdit) Then
                    CType(item, SpinEdit).EnterMoveNextControl = True
                    CType(item, SpinEdit).Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
                    CType(item, SpinEdit).Properties.IsFloatValue = False
                    CType(item, SpinEdit).Properties.Mask.BeepOnError = True
                    CType(item, SpinEdit).Properties.Mask.EditMask = "n0"
                    CType(item, SpinEdit).Properties.Mask.MaskType = Mask.MaskType.Numeric
                    CType(item, SpinEdit).Properties.Mask.UseMaskAsDisplayFormat = True
                    CType(item, SpinEdit).Properties.NullValuePrompt = "0"
                    CType(item, SpinEdit).Properties.NullValuePromptShowForEmptyValue = True
                    If bClear Then CType(item, SpinEdit).Value = 0

                ElseIf item.GetType = GetType(CalcEdit) Then
                    CType(item, CalcEdit).EnterMoveNextControl = True
                    CType(item, CalcEdit).Properties.Appearance.Options.UseTextOptions = True
                    CType(item, CalcEdit).Properties.DisplayFormat.FormatString = "{0:N2}"
                    CType(item, CalcEdit).Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    CType(item, CalcEdit).Properties.EditFormat.FormatString = "{0:N2}"
                    CType(item, CalcEdit).Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    CType(item, CalcEdit).Properties.Mask.BeepOnError = True
                    CType(item, CalcEdit).Properties.Mask.EditMask = "N2"
                    CType(item, CalcEdit).Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                    CType(item, CalcEdit).Properties.Mask.UseMaskAsDisplayFormat = True
                    CType(item, CalcEdit).Properties.NullValuePrompt = "0.00"
                    CType(item, CalcEdit).Properties.NullValuePromptShowForEmptyValue = True
                    CType(item, CalcEdit).Properties.ShowNullValuePromptWhenFocused = True
                    CType(item, CalcEdit).Properties.NullText = "0.00"
                    If bClear Then CType(item, CalcEdit).Value = 0

                ElseIf item.GetType = GetType(LookUpEdit) Then
                    CType(item, LookUpEdit).EnterMoveNextControl = True
                    CType(item, LookUpEdit).Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                    CType(item, LookUpEdit).Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                    CType(item, LookUpEdit).Properties.NullValuePromptShowForEmptyValue = True
                    CType(item, LookUpEdit).Properties.ShowNullValuePromptWhenFocused = True
                    CType(item, LookUpEdit).Properties.NullText = "Select..."
                    'Some Lookupedits will show nothing if reset is activated
                    'If bReset Then CType(item, LookUpEdit).Text = Nothing

                ElseIf item.GetType = GetType(DateEdit) Then
                    CType(item, DateEdit).EnterMoveNextControl = True
                    CType(item, DateEdit).Properties.Appearance.Options.UseTextOptions = True
                    CType(item, DateEdit).Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    CType(item, DateEdit).Properties.DisplayFormat.FormatString = "MMMM dd, yyyy"
                    CType(item, DateEdit).Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    CType(item, DateEdit).Properties.EditFormat.FormatString = "MMMM dd, yyyy"
                    CType(item, DateEdit).Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    CType(item, DateEdit).Properties.Mask.BeepOnError = True
                    CType(item, DateEdit).Properties.Mask.EditMask = "MMMM dd, yyyy"
                    CType(item, DateEdit).Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
                    CType(item, DateEdit).Properties.Mask.UseMaskAsDisplayFormat = True
                    If bClear Then CType(item, DateEdit).EditValue = Date.Today
                End If
            Next

            For Each subControls As System.Windows.Forms.Control In control.Controls
                Initialize_Controls(subControls, bClear)
            Next
        End Sub

        Public Sub Initialize_BarManager(ByVal xForm As XtraForm, ByVal barManager As BarManager)
            Initialize_BarManager(barManager)
            barManager.RestoreLayoutFromRegistry(xForm.Name)
        End Sub

        Public Sub Initialize_BarManager(ByVal barManager As BarManager)
            Dim xIconForm As New Forms.XtraForm_Main
            For Each item In barManager.RepositoryItems
                If item.GetType = GetType(RepositoryItemDateEdit) Then
                    CType(item, RepositoryItemDateEdit).Appearance.Options.UseTextOptions = True
                    CType(item, RepositoryItemDateEdit).Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    'CType(item, RepositoryItemDateEdit).CalendarView = CalendarView.Default
                    CType(item, RepositoryItemDateEdit).DisplayFormat.FormatString = "MMMM dd, yyyy"
                    CType(item, RepositoryItemDateEdit).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    CType(item, RepositoryItemDateEdit).EditFormat.FormatString = "MMMM dd, yyyy"
                    CType(item, RepositoryItemDateEdit).EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    CType(item, RepositoryItemDateEdit).Mask.EditMask = "MMMM dd, yyyy"
                    CType(item, RepositoryItemDateEdit).Mask.UseMaskAsDisplayFormat = True
                End If
            Next

            For Each item In barManager.Items
                If item.GetType = GetType(BarCheckItem) Then
                    CType(item, BarCheckItem).PaintStyle = BarItemPaintStyle.CaptionGlyph
                    CType(item, BarCheckItem).Hint = "Click Button to set On/Off to affect data display/process"

                ElseIf item.GetType = GetType(BarToggleSwitchItem) Then
                    CType(item, BarToggleSwitchItem).PaintStyle = BarItemPaintStyle.CaptionGlyph
                    Select Case CType(item, BarToggleSwitchItem).Name
                        Case "BarToggleSwitchItem_Any_Date"
                            CType(item, BarToggleSwitchItem).Caption = "An&y Date"
                            CType(item, BarToggleSwitchItem).Hint = "Enable to Search at any date."
                            CType(item, BarToggleSwitchItem).ItemShortcut = New BarShortcut(Keys.Alt Or Keys.Y)
                            CType(item, BarToggleSwitchItem).ImageOptions.Image = xIconForm.BarToggleSwitchItem_Any_Date.ImageOptions.Image
                            CType(item, BarToggleSwitchItem).ImageOptions.LargeImage = xIconForm.BarToggleSwitchItem_Any_Date.ImageOptions.LargeImage
                    End Select

                ElseIf item.GetType = GetType(BarButtonItem) Then
                    CType(item, BarButtonItem).PaintStyle = BarItemPaintStyle.CaptionGlyph
                    Select Case CType(item, BarButtonItem).Name
                        Case "Btn_Account"
                            CType(item, BarButtonItem).Caption = "&Account"
                            CType(item, BarButtonItem).Hint = "Show account information"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Alt Or Keys.A)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Account.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Account.ImageOptions.LargeImage

                        Case "Btn_Batch_Transactions"
                            CType(item, BarButtonItem).Caption = "Batch Transactions"
                            CType(item, BarButtonItem).Hint = "Show Collections"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Batch_Transactions.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Batch_Transactions.ImageOptions.LargeImage

                        'SQL Server Connection
                        Case "Btn_Refresh_Connection"
                            CType(item, BarButtonItem).Caption = "Re&fresh Connection"
                            CType(item, BarButtonItem).Hint = "Refresh/Check SQL Database connection"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Alt Or Keys.F)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Refresh_Connection.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Refresh_Connection.ImageOptions.LargeImage

                        Case "Btn_Test_Connection"
                            CType(item, BarButtonItem).Caption = "Test Connection"
                            CType(item, BarButtonItem).Hint = "Test/Check SQL Database connection using specified parameters"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.F5)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Refresh_Connection.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Refresh_Connection.ImageOptions.LargeImage

                        Case "Btn_Connect_Close"
                            CType(item, BarButtonItem).Caption = "Connect and Close"
                            CType(item, BarButtonItem).Hint = "Connect SQL Database and close the form"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.F5)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_OK.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_OK.ImageOptions.LargeImage

                            'Primary Actions
                        Case "Btn_Import"
                            CType(item, BarButtonItem).Caption = "Import"
                            CType(item, BarButtonItem).Hint = "Import data into GridView"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Import.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Import.ImageOptions.LargeImage

                        Case "Btn_Initialize"
                            CType(item, BarButtonItem).Caption = "Initiali&ze"
                            CType(item, BarButtonItem).Hint = "Initialize data on some text controls"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Alt Or Keys.Z)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Initialize.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Initialize.ImageOptions.LargeImage

                        Case "Btn_Reset"
                            CType(item, BarButtonItem).Caption = "Reset"
                            CType(item, BarButtonItem).Hint = "Reset controls (bar, dock, gridview etc.)"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Reset.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Reset.ImageOptions.LargeImage
                            CType(item, BarButtonItem).Visibility = BarItemVisibility.OnlyInCustomizing

                        Case "Btn_Reload"
                            CType(item, BarButtonItem).Caption = "&Reload"
                            CType(item, BarButtonItem).Hint = "Load or refresh data on Gridview Table"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.F5)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Reload.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Reload.ImageOptions.LargeImage

                        Case "Btn_Preview"
                            CType(item, BarButtonItem).Caption = "&Preview"
                            CType(item, BarButtonItem).Hint = "Display data from Gridview Table to Print Preview"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.V)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Preview.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Preview.ImageOptions.LargeImage

                        Case "Btn_Print_Check"
                            CType(item, BarButtonItem).Caption = "Print Check"
                            CType(item, BarButtonItem).Hint = "Print check with Payee and Amount"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.H)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Print_Check.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Print_Check.ImageOptions.LargeImage

                        Case "Btn_New"
                            CType(item, BarButtonItem).Caption = "&New"
                            CType(item, BarButtonItem).Hint = "Prepare controls to input new data"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.N)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_New.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_New.ImageOptions.LargeImage

                        Case "Btn_Save"
                            CType(item, BarButtonItem).Caption = "&Save"
                            CType(item, BarButtonItem).Hint = "Save data with input values"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.S)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Save.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Save.ImageOptions.LargeImage

                        Case "Btn_Save_New"
                            CType(item, BarButtonItem).Caption = "Save and New"
                            CType(item, BarButtonItem).Hint = "Save data and then prepare new entry"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.N)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Save_New.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Save_New.ImageOptions.LargeImage

                        Case "Btn_Save_Close"
                            CType(item, BarButtonItem).Caption = "Save and Close"
                            CType(item, BarButtonItem).Hint = "Save data then Closes the current Window Form"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.S)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Save_Close.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Save_Close.ImageOptions.LargeImage

                        Case "Btn_Update"
                            CType(item, BarButtonItem).Caption = "&Update"
                            CType(item, BarButtonItem).Hint = "Update or overwrite existing data with new values"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.U)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Update.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Update.ImageOptions.LargeImage

                        Case "Btn_Delete"
                            CType(item, BarButtonItem).Caption = "&Delete"
                            CType(item, BarButtonItem).Hint = "Delete, Cancel or Remove selected data"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.D)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Delete.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Delete.ImageOptions.LargeImage

                        Case "Btn_Delete_For"
                            CType(item, BarButtonItem).Caption = "&For Delete"
                            CType(item, BarButtonItem).Hint = "Send selected row(s) 'For Delete' to Admin"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.D)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Delete_For.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Delete_For.ImageOptions.LargeImage

                        Case "Btn_Delete_Close"
                            CType(item, BarButtonItem).Caption = "&Delete and Close"
                            CType(item, BarButtonItem).Hint = "Delete, Cancel or Remove selected data and Close the form"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.D)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Delete.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Delete.ImageOptions.LargeImage

                        Case "Btn_Close"
                            CType(item, BarButtonItem).Caption = "&Close"
                            CType(item, BarButtonItem).Hint = "Closes the Window Form"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Alt Or Keys.C)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Close.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Close.ImageOptions.LargeImage

                        Case "Btn_Cancel"
                            CType(item, BarButtonItem).Caption = "Cancel"
                            CType(item, BarButtonItem).Hint = "Cancel the current data record"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.C)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Cancel.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Cancel.ImageOptions.LargeImage

                            'Status
                        Case "Btn_Pending"
                            CType(item, BarButtonItem).Caption = "&Pending"
                            CType(item, BarButtonItem).Hint = "Load pending transactions to Gridview Table"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.F5)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Pending.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Pending.ImageOptions.LargeImage

                        Case "Btn_Approval"
                            CType(item, BarButtonItem).Caption = "Approval"
                            CType(item, BarButtonItem).Hint = "Send selected row(s) 'For Approval' to Approver"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.P)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Approval.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Approval.ImageOptions.LargeImage

                        Case "Btn_Approve"
                            CType(item, BarButtonItem).Caption = "Approve"
                            CType(item, BarButtonItem).Hint = "Approve 'For Approval' selected row(s)"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Approve.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Approve.ImageOptions.LargeImage

                        Case "Btn_DisApprove"
                            CType(item, BarButtonItem).Caption = "Disapprove"
                            CType(item, BarButtonItem).Hint = "Disapprove 'For Approval' selected row(s)"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_DisApprove.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_DisApprove.ImageOptions.LargeImage

                        Case "Btn_Password_Reset"
                            CType(item, BarButtonItem).Caption = "Password Reset"
                            CType(item, BarButtonItem).Hint = "Reset user password"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Password_Reset.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Password_Reset.ImageOptions.LargeImage

                        Case "Btn_Lock"
                            CType(item, BarButtonItem).Caption = "Lock/Unlock"
                            CType(item, BarButtonItem).Hint = "Lock data update permission"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Lock.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Lock.ImageOptions.LargeImage

                            'Custom Query
                        Case "Btn_Generate"
                            CType(item, BarButtonItem).Caption = "&Generate"
                            CType(item, BarButtonItem).Hint = "Generate SQL Query for execution"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.F5)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Generate.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Generate.ImageOptions.LargeImage

                        Case "Btn_Execute"
                            CType(item, BarButtonItem).Caption = "Execute"
                            CType(item, BarButtonItem).Hint = "Execute command to process data"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.F5)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Execute.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Execute.ImageOptions.LargeImage

                            'Checks
                        Case "Btn_Link"
                            CType(item, BarButtonItem).Caption = "Link"
                            CType(item, BarButtonItem).Hint = "Link selected transaction accross other transactions"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.L)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Link.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Link.ImageOptions.LargeImage

                            'Chart of Accounts
                        Case "Btn_Convert_Summary"
                            CType(item, BarButtonItem).Caption = "Convert to Summary"
                            CType(item, BarButtonItem).Hint = "Convert selected Detail COA into Summary"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.T)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Convert_Summary.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Convert_Summary.ImageOptions.LargeImage

                        Case "Btn_Insert"
                            CType(item, BarButtonItem).Caption = "Insert"
                            CType(item, BarButtonItem).Hint = "Insert New Entry (Auto-increment Code)"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.Insert)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Insert.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Insert.ImageOptions.LargeImage

                        Case "Btn_Another_Entry"
                            CType(item, BarButtonItem).Caption = "Another Entr&y"
                            CType(item, BarButtonItem).Hint = "Input another entry (ID Code Auto-increment)"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.Y)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Another_Entry.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Another_Entry.ImageOptions.LargeImage

                            'Tree List view
                        Case "Btn_Expand"
                            CType(item, BarButtonItem).Caption = "Expand"
                            CType(item, BarButtonItem).Hint = "Expand the Tree List view"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.Add)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Expand.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Expand.ImageOptions.LargeImage

                        Case "Btn_Collapse"
                            CType(item, BarButtonItem).Caption = "Collapse"
                            CType(item, BarButtonItem).Hint = "Collapse the Tree List view"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.Subtract)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Collapse.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Collapse.ImageOptions.LargeImage

                            'Journal
                        Case "Btn_Journal"
                            CType(item, BarButtonItem).Caption = "&Journal"
                            CType(item, BarButtonItem).Hint = "Convert selected transaction into Journal Entries"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.F6)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Journal.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Journal.ImageOptions.LargeImage

                        Case "Btn_Journal_Entries"
                            CType(item, BarButtonItem).Caption = "&Journal Entries"
                            CType(item, BarButtonItem).Hint = "Show Journal Entries of the selected trasaction"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.F6)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Journal_Entries.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Journal_Entries.ImageOptions.LargeImage

                        Case "Btn_COA_Ledger", "Btn_Ledger", "Btn_Payments"
                            CType(item, BarButtonItem).Caption = CType(item, BarButtonItem).Name.Substring(4)
                            CType(item, BarButtonItem).Hint = $"Show {CType(item, BarButtonItem).Name.Substring(4)}"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.F7)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_COA_Ledger.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_COA_Ledger.ImageOptions.LargeImage

                        Case "Btn_Validate"
                            CType(item, BarButtonItem).Caption = "&Validate"
                            CType(item, BarButtonItem).Hint = "Validate the data in Gridview Table and check for errors"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Alt Or Keys.V)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Validate.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Validate.ImageOptions.LargeImage

                        Case "Btn_Verify"
                            CType(item, BarButtonItem).Caption = "Verify"
                            CType(item, BarButtonItem).Hint = "Verify transactions if IsJournal"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.F8)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Verify.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Verify.ImageOptions.LargeImage

                        Case "Btn_Stop"
                            CType(item, BarButtonItem).Caption = "S&top"
                            CType(item, BarButtonItem).Hint = "Stop or Halt the current looping process"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Alt Or Keys.S)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Stop.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Stop.ImageOptions.LargeImage

                            'Trial Balance
                        Case "Btn_Trial_Balance"
                            CType(item, BarButtonItem).Caption = "Update Trial Balance"
                            CType(item, BarButtonItem).Hint = "Update Trial Balance of the selected row(s)"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Trial_Balance.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Trial_Balance.ImageOptions.LargeImage

                        Case "Btn_Generate"
                            CType(item, BarButtonItem).Caption = "&Generate"
                            CType(item, BarButtonItem).Hint = "Generate data in Gridview Table"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.G)

                        Case "Btn_Summary"
                            CType(item, BarButtonItem).Caption = "Su&mmary"
                            CType(item, BarButtonItem).Hint = "Update journal summary from Gridview Table"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.M)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Summary.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Summary.ImageOptions.LargeImage

                            'Filter
                        Case "Btn_Filter_Load"
                            CType(item, BarButtonItem).Caption = "Filter &Load"
                            CType(item, BarButtonItem).Hint = "Rearrange/Format Gridview Table from the selected Filter Profile"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.L)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Filter_Load.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Filter_Load.ImageOptions.LargeImage

                        Case "Btn_Filter_Save"
                            CType(item, BarButtonItem).Caption = "Filter &Save"
                            CType(item, BarButtonItem).Hint = "Save Gridview Table arrangements/format to the selected Filter Profile"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.S)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Filter_Save.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Filter_Save.ImageOptions.LargeImage

                        Case "Btn_Filter_Delete"
                            CType(item, BarButtonItem).Caption = "Filter &Delete"
                            CType(item, BarButtonItem).Hint = "Delete selected Filter Profile"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.D)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Filter_Delete.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Filter_Delete.ImageOptions.LargeImage

                            'Custom
                        Case "Btn_Regenerate_Codes"
                            CType(item, BarButtonItem).Caption = "Regenerate Codes"
                            CType(item, BarButtonItem).Hint = "Regenerate/Repair Codes to avoid Primary Key Error"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.G)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Regenerate_Codes.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Regenerate_Codes.ImageOptions.LargeImage

                        Case "Btn_History"
                            CType(item, BarButtonItem).Caption = "History"
                            CType(item, BarButtonItem).Hint = "Check the Activity History of the selected item"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.H)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_History.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_History.ImageOptions.LargeImage

                    End Select

                ElseIf item.GetType = GetType(BarEditItem) Then
                    CType(item, BarEditItem).PaintStyle = BarItemPaintStyle.CaptionGlyph
                    Select Case CType(item, BarEditItem).Name
                        Case "BarEditItem_Branch"
                            CType(item, BarEditItem).Caption = "Branch"
                            CType(item, BarEditItem).Hint = "SELECT Branch"
                            CType(item, BarEditItem).ImageOptions.Image = xIconForm.BarEditItem_Branch.ImageOptions.Image
                            CType(item, BarEditItem).ImageOptions.LargeImage = xIconForm.BarEditItem_Branch.ImageOptions.LargeImage

                        Case "BarEditItem_Search"
                            CType(item, BarEditItem).Caption = "Search"
                            CType(item, BarEditItem).EditWidth = 150
                            CType(item, BarEditItem).Hint = "Search any string and show results in GridView"
                            CType(item, BarEditItem).ImageOptions.Image = xIconForm.BarEditItem_Search.ImageOptions.Image
                            CType(item, BarEditItem).ImageOptions.LargeImage = xIconForm.BarEditItem_Search.ImageOptions.LargeImage

                        Case "BarEditItem_Posting_Date", "BarEditItem_Start", "BarEditItem_End"
                            Select Case CType(item, BarEditItem).Name
                                Case "BarEditItem_Posting_Date"
                                    CType(item, BarEditItem).Caption = "Posting Date"
                                    CType(item, BarEditItem).Hint = "Custom Posting Date for Journal Entry"

                                Case "BarEditItem_Start"
                                    CType(item, BarEditItem).Caption = "Date Start"
                                    CType(item, BarEditItem).Hint = "Set starting date"

                                Case "BarEditItem_End"
                                    CType(item, BarEditItem).Caption = "Date End"
                                    CType(item, BarEditItem).Hint = "Set ending date"
                            End Select

                            CType(item, BarEditItem).EditWidth = 120
                            CType(item, BarEditItem).EditValue = Date.Today

                        Case "BarEditItem_Filter"
                            CType(item, BarEditItem).Caption = "Filter"
                            CType(item, BarEditItem).EditWidth = 150
                            CType(item, BarEditItem).Hint = "SELECT and manage Gridview Table query result filter"
                            CType(item, BarEditItem).ImageOptions.Image = xIconForm.BarEditItem_Filter.ImageOptions.Image
                            CType(item, BarEditItem).ImageOptions.LargeImage = xIconForm.BarEditItem_Filter.ImageOptions.LargeImage

                        Case "BarEditItem_Document_Title"
                            CType(item, BarEditItem).Caption = "Document Title"
                            CType(item, BarEditItem).Hint = "Document Title for Report Printing"

                        Case "BarEditItem_Remarks"
                            CType(item, BarEditItem).Caption = "Remarks"
                            CType(item, BarEditItem).Hint = "Remarks information for current transaction"

                    End Select

                End If
            Next
        End Sub

        Public Sub Initialize_GridView(ByVal xForm As XtraForm, ByVal gridView As XtraGrid.Views.Grid.GridView, Optional ByVal bRestoreLayout As Boolean = True, Optional bEditable As Boolean = False, Optional ByVal bNewRow As Boolean = False)
            Initialize_GridView(gridView, bEditable, bNewRow)

            If bRestoreLayout Then
                gridView.RestoreLayoutFromRegistry(xForm.Name)
            End If
        End Sub

        Public Sub Initialize_GridView(ByVal gridView As XtraGrid.Views.Grid.GridView, Optional bEditable As Boolean = False, Optional ByVal bNewRow As Boolean = False)
            gridView.OptionsBehavior.Editable = bEditable
            gridView.OptionsBehavior.AutoExpandAllGroups = True
            gridView.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True

            gridView.OptionsCustomization.CustomizationFormSearchBoxVisible = True

            gridView.OptionsNavigation.AutoFocusNewRow = True
            gridView.OptionsSelection.MultiSelect = True

            gridView.OptionsView.ColumnAutoWidth = False
            gridView.OptionsView.ShowAutoFilterRow = True
            gridView.OptionsView.ShowChildrenInGroupPanel = True
            gridView.OptionsView.ShowFooter = True
            gridView.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full

            gridView.OptionsMenu.ShowConditionalFormattingItem = True
            gridView.OptionsMenu.ShowGroupSummaryEditorItem = True
            gridView.OptionsMenu.EnableFooterMenu = True
            gridView.OptionsMenu.ShowFooterItem = True

            gridView.OptionsLayout.StoreFormatRules = True

            If bNewRow Then
                gridView.OptionsNavigation.AutoFocusNewRow = True
                gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            End If

            For Each col In gridView.Columns
                If col.GetType = GetType(GridColumn) Then
                    CType(col, GridColumn).Visible = True
                    CType(col, GridColumn).AppearanceCell.Options.UseTextOptions = True

                    If CType(col, GridColumn).FieldName.Equals("ID") Or CType(col, GridColumn).FieldName.Equals("id") Or CType(col, GridColumn).FieldName.Equals("sequenceno") Then
                        CType(col, GridColumn).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                        CType(col, GridColumn).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                        'CType(col, GridColumn).SummaryItem.DisplayFormat = "N2"
                    End If

                    If CType(col, GridColumn).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric Then
                        CType(col, GridColumn).DisplayFormat.FormatString = "{0:N2}"
                        CType(col, GridColumn).GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        CType(col, GridColumn).GroupFormat.FormatString = "{0:N2}"

                    ElseIf (CType(col, GridColumn).FieldName.Contains("Date") Or CType(col, GridColumn).FieldName.Contains("date") Or CType(col, GridColumn).FieldName.Contains("Day") Or CType(col, GridColumn).FieldName.Contains("day")) And Not CType(col, GridColumn).FieldName.Contains("Days") And Not CType(col, GridColumn).FieldName.Contains("BackDate") Then
                        CType(col, GridColumn).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                        CType(col, GridColumn).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                        CType(col, GridColumn).DisplayFormat.FormatString = "MMMM dd, yyyy"
                        CType(col, GridColumn).GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                        CType(col, GridColumn).GroupFormat.FormatString = "MMMM dd, yyyy"

                        If CType(col, GridColumn).Name.Contains("Birth") Then
                            CType(col, GridColumn).Caption = "Birth Date"
                            CType(col, GridColumn).DisplayFormat.FormatString = "MMMM dd, yyyy"

                        ElseIf CType(col, GridColumn).Name.Contains("Transaction") Then
                            CType(col, GridColumn).Caption = "Transaction Date"
                            CType(col, GridColumn).DisplayFormat.FormatString = "MMMM dd, yyyy HH:mm:ss"

                        ElseIf CType(col, GridColumn).Name.Contains("Added_Date") Then
                            CType(col, GridColumn).Caption = "Added Date"
                            CType(col, GridColumn).DisplayFormat.FormatString = "MMMM dd, yyyy HH:mm:ss"

                        ElseIf CType(col, GridColumn).Name.Contains("Modified_Date") Then
                            CType(col, GridColumn).Caption = "Modified Date"
                            CType(col, GridColumn).DisplayFormat.FormatString = "MMMM dd, yyyy HH:mm:ss"

                        ElseIf CType(col, GridColumn).Name.Contains("Approved_Date") Then
                            CType(col, GridColumn).Caption = "Approved Date"
                            CType(col, GridColumn).DisplayFormat.FormatString = "MMMM dd, yyyy HH:mm:ss"
                        End If
                    End If
                End If
            Next
        End Sub

        Public Function Form_Close(ByVal frm As XtraForm, ByVal barManager As BarManager, ByVal gridview As XtraGrid.Views.Grid.GridView, Optional ByVal bAsk As Boolean = False) As Boolean
            Try
                barManager.SaveLayoutToRegistry(frm.Name)
            Catch ex As NullReferenceException

            End Try
            gridview.SaveLayoutToRegistry(frm.Name)
            Return Form_Close(frm, bAsk)
        End Function

        Private Sub form_Dispose(ByVal xForm As XtraForm, Optional ByVal bCustomFormName As Boolean = False, Optional ByVal sCustomFormName As String = "")
            If xForm.WindowState.Equals(FormWindowState.Normal) Then
                If bCustomFormName Then
                    Module_Tools.RegKeySet($"{xForm.Name}-{sCustomFormName}", "Top", xForm.Top)
                    Module_Tools.RegKeySet($"{xForm.Name}-{sCustomFormName}", "Left", xForm.Left)
                    Module_Tools.RegKeySet($"{xForm.Name}-{sCustomFormName}", "Width", xForm.Width)
                    Module_Tools.RegKeySet($"{xForm.Name}-{sCustomFormName}", "Height", xForm.Height)
                Else
                    Module_Tools.RegKeySet(xForm.Name, "Top", xForm.Top)
                    Module_Tools.RegKeySet(xForm.Name, "Left", xForm.Left)
                    Module_Tools.RegKeySet(xForm.Name, "Width", xForm.Width)
                    Module_Tools.RegKeySet(xForm.Name, "Height", xForm.Height)
                End If
            End If

            xForm.Dispose()
            xForm.Close()
        End Sub

        Public Function DataSaveAsk(ByVal sTransaction As String) As Boolean
            Dim myResult As DialogResult = XtraMessageBox.Show($"Do you want to save/update this {sTransaction}?{Environment.NewLine}{Environment.NewLine}Note: This might overwrite the existing data.{Environment.NewLine}{Environment.NewLine}Reminder: Please verify and update your transactions.", $"Save / Update {sTransaction}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If myResult = DialogResult.Yes Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function actionAsk(ByVal sTitle As String, ByVal sTransaction As String, Optional ByVal sNote As String = "This might take more than a while.", Optional ByVal sWarning As String = "You can't UNDO this Operation.", Optional ByVal sReminder As String = "Please review or verify before you proceed.") As Boolean
            Dim myResult As DialogResult = XtraMessageBox.Show($"Do you want to {sTransaction}?{Environment.NewLine}
        Note: {sNote}.{Environment.NewLine}
        Warning: {sWarning}.{Environment.NewLine}
        Reminder: {sReminder}.{Environment.NewLine}
        Then click 'YES' to continue or 'NO' to cancel.
        ", $"Action Command: {sTitle}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If myResult = DialogResult.Yes Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function Form_Close(ByVal xForm As XtraForm, Optional ByVal bAsk As Boolean = False, Optional ByVal bCustomFormName As Boolean = False, Optional ByVal sCustomFormName As String = "") As Boolean
            If bAsk Then
                If Environment.OSVersion.Version.Major.Equals(10) Then
                    Dim action As New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() With {.Caption = "Confirm", .Description = $"Close {xForm.Name}-[{xForm.Text}]?"}
                    Dim command1 As New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() With {.Text = "Close", .Result = System.Windows.Forms.DialogResult.Yes}
                    Dim command2 As New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() With {.Text = "Cancel", .Result = System.Windows.Forms.DialogResult.No}
                    action.Commands.Add(command1)
                    action.Commands.Add(command2)
                    Dim properties As New FlyoutProperties() With {.ButtonSize = New Size(100, 40), .Style = FlyoutStyle.MessageBox}
                    If FlyoutDialog.Show(xForm, action, properties) = System.Windows.Forms.DialogResult.Yes Then
                        form_Dispose(xForm)
                        Return True
                    Else
                        Return False
                    End If
                Else
                    If actionAsk("Close Form", $"Close {xForm.Name}-[{xForm.Text}]", "You might lose unsaved data.") Then
                        form_Dispose(xForm, bCustomFormName, sCustomFormName)
                        Return True
                    Else
                        Return False
                    End If
                End If
            Else
                form_Dispose(xForm, bCustomFormName, sCustomFormName)
            End If
            Return False
        End Function

        Public Sub Initialize_Printing(ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs)
            Dim printingSystem As PrintingSystemBase = TryCast(e.PrintingSystem, PrintingSystemBase)
            printingSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Legal
            printingSystem.PageSettings.Landscape = True
            printingSystem.PageSettings.LeftMargin = 20
            printingSystem.PageSettings.RightMargin = 120
            printingSystem.PageSettings.TopMargin = 20
            printingSystem.PageSettings.BottomMargin = 20
        End Sub

    End Module
End Namespace