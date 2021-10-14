Imports DevExpress
Imports DevExpress.Skins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraLayout
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports MyClassLibrary.Forms
Imports System.Media

Namespace Classes
    Public Module class_Procedures
        Dim repoItemHyperLinkEdit As RepositoryItemHyperLinkEdit

        Public Enum xFormMode
            xForm
            xWait
        End Enum

        Public Enum MsgMode
            Sql
            Info
            Warning
            Errorr
            Save
            Update
            Delete
        End Enum

        Public dx As DXErrorProvider.DXErrorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider()
        Public frm As New XtraForm1

        Public Sub splash_Show(ByVal sDescription As String, Optional ByVal sTitle As String = "Please wait", Optional ByVal bForceShow As Boolean = False, Optional ByVal xMode As xFormMode = xFormMode.xWait)
            splash_Close()
            If class_Variables.bSplash Or bForceShow Then
                Try
                    Select Case xMode
                        Case xFormMode.xForm
                            SplashScreenManager.ShowForm(frm, GetType(SplashScreen1))
                            SplashScreenManager.ShowDefaultSplashScreen(class_Functions.Product_Name_Version, sDescription)

                        Case xFormMode.xWait
                            SplashScreenManager.ShowForm(frm, GetType(WaitForm1))
                            SplashScreenManager.ShowDefaultWaitForm(sTitle, $"Currently {sDescription}")

                    End Select
                Catch Ex As Exception
                    'Do not display Error because it will popup everytime when showing Splash and Wait forms
                    'Show_Error(Ex)
                Finally
                    Application.DoEvents()
                End Try
            End If
        End Sub

        Public Sub splash_Show(ByVal xfrm As XtraForm, ByVal sDescription As String, Optional ByVal sTitle As String = "Please wait", Optional ByVal bForceShow As Boolean = False, Optional ByVal xMode As xFormMode = xFormMode.xWait)
            splash_Close()
            If class_Variables.bSplash Or bForceShow Then
                Try
                    Select Case xMode
                        Case xFormMode.xForm
                            SplashScreenManager.ShowForm(GetType(SplashScreen1))
                            SplashScreenManager.ShowDefaultSplashScreen(xfrm, True, True, class_Functions.Product_Name_Version, sDescription)
                            SplashScreenManager.ActivateParentOnSplashFormClosing = True

                        Case xFormMode.xWait
                            SplashScreenManager.ShowForm(GetType(WaitForm1))
                            SplashScreenManager.ShowDefaultWaitForm(xfrm, False, False, sTitle, $"Currently {sDescription}")
                            SplashScreenManager.ActivateParentOnWaitFormClosing = True

                    End Select
                Catch Ex As Exception
                    'Do not display Error because it will popup everytime when showing Splash and Wait forms
                    'Show_Error(Ex)
                Finally
                    Application.DoEvents()
                End Try
            End If
        End Sub

        Public Sub splash_Close(Optional ByVal bForceClose As Boolean = False)
            If class_Variables.bSplash Or bForceClose Then
                Try
                    SplashScreenManager.CloseForm(True)
                    Application.DoEvents()
                Catch Ex As Exception
                    'show_error(ex)
                End Try
            End If
        End Sub

        Public Function Create_Badge(ByVal adornerManager As DevExpress.Utils.VisualEffects.AdornerUIManager, ByVal targetButton As DevExpress.XtraBars.BarButtonItem, ByVal paintStyle As DevExpress.Utils.VisualEffects.BadgePaintStyle, ByVal iCount As Integer) As Integer
            Dim badge As Utils.VisualEffects.Badge = New DevExpress.Utils.VisualEffects.Badge
            adornerManager.Elements.Add(badge)

            With badge
                .Visible = False
                .TargetElement = targetButton
                .Properties.PaintStyle = paintStyle
                .Properties.Text = iCount.ToString
                If iCount > 0 Then .Visible = True
            End With
            Return iCount
        End Function

        Public Sub Create_Badge(ByVal adornerManager As DevExpress.Utils.VisualEffects.AdornerUIManager, ByVal ribbonPageGroup As Ribbon.RibbonPage, ByVal paintStyle As DevExpress.Utils.VisualEffects.BadgePaintStyle, ByVal iCount As Integer)
            Dim badge As Utils.VisualEffects.Badge = New DevExpress.Utils.VisualEffects.Badge
            adornerManager.Elements.Add(badge)

            With badge
                .Visible = False
                .TargetElement = ribbonPageGroup
                .Properties.PaintStyle = paintStyle
                .Properties.Text = iCount.ToString
                If iCount > 0 Then .Visible = True
            End With
        End Sub

        'Public Sub Initialize_Controls(ByVal control As Control, Optional ByVal bClear As Boolean = False)
        '    For Each item In control
        '        If item.GetType = GetType(XtraUserControl) Then
        '            Initialize_Controls(TryCast(item, BaseEdit), bClear)

        '        ElseIf item.GetType = GetType(RepositoryItem) Then
        '            If item.GetType = GetType(RepositoryItemLookUpEdit) Then
        '                With CType(item, RepositoryItemLookUpEdit)
        '                    .BestFitMode = XtraEditors.Controls.BestFitMode.BestFitResizePopup
        '                    .ImmediatePopup = True
        '                    .PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        '                    .PopupWidthMode = PopupWidthMode.ContentWidth
        '                    .TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '                End With

        '            ElseIf item.GetType = GetType(RepositoryItemTreeListLookUpEdit) Then
        '                With CType(item, RepositoryItemTreeListLookUpEdit)
        '                    .BestFitMode = XtraEditors.Controls.BestFitMode.BestFitResizePopup
        '                    .ImmediatePopup = True
        '                    .PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        '                    .PopupWidthMode = PopupWidthMode.ContentWidth
        '                    .TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '                End With
        '            End If
        '        End If
        '    Next
        'End Sub

        Public Sub Initialize_Controls(ByVal control As System.Windows.Forms.Control, Optional ByVal bClear As Boolean = False)
            For Each item As System.Windows.Forms.Control In control.Controls
                If item.GetType = GetType(TextEdit) Then
                    With CType(item, TextEdit)
                        .EnterMoveNextControl = True
                        .Properties.NullValuePrompt = $"Input { .Name}..."
                        .Properties.NullValuePromptShowForEmptyValue = True
                        .EnterMoveNextControl = True
                        If bClear Then .Text = Nothing

                        If .Name.Equals("ID") Or .Name.Equals("id") Then
                            .Properties.ReadOnly = True
                        End If

                        If .Name.Contains("Code") Or .Name.Contains("Type") Or .Name.Contains("Name") Or .Name.Contains("Profile") Or .Name.Contains("Engine") Or .Name.Contains("Chassis") Then
                            .Properties.CharacterCasing = CharacterCasing.Upper
                        End If
                    End With

                ElseIf item.GetType = GetType(ButtonEdit) Then
                    With CType(item, ButtonEdit)
                        .EnterMoveNextControl = True
                        .Properties.NullValuePrompt = $"Input { .Name}..."
                        .Properties.NullValuePromptShowForEmptyValue = True
                        If bClear Then .Text = Nothing

                        If .Name.Contains("Code") Or .Name.Contains("Name") Or .Name.Contains("Profile") Or .Name.Contains("Engine") Or .Name.Contains("Chassis") Then
                            .Properties.CharacterCasing = CharacterCasing.Upper
                        End If
                    End With

                ElseIf item.GetType = GetType(ComboBoxEdit) Then
                    With CType(item, ComboBoxEdit)
                        .EnterMoveNextControl = True
                        .Properties.PopupSizeable = True
                        .Properties.NullValuePrompt = $"SELECT { .Name}..."
                        .Properties.NullValuePromptShowForEmptyValue = True
                        .Properties.Sorted = True
                        If bClear Then .Text = Nothing

                        If .Name.Contains("Type") Or .Name.Contains("Brand") Then
                            .Properties.CharacterCasing = CharacterCasing.Upper
                        End If

                        If .Name.Contains("Corp") Then
                            .Properties.TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor
                        End If
                    End With

                ElseIf item.GetType = GetType(PopupContainerEdit) Then
                    With CType(item, PopupContainerEdit)
                        .EnterMoveNextControl = True
                        .Properties.TextEditStyle = XtraEditors.Controls.TextEditStyles.Standard
                        If bClear Then .Text = Nothing
                    End With

                ElseIf item.GetType = GetType(CheckEdit) Then
                    With CType(item, CheckEdit)
                        .EnterMoveNextControl = True
                        .Checked = False
                    End With

                ElseIf item.GetType = GetType(ToggleSwitch) Then
                    With CType(item, ToggleSwitch)
                        .EnterMoveNextControl = True
                        .EditValue = False
                    End With

                ElseIf item.GetType = GetType(MemoEdit) Then
                    'Disabling EnterMoveNextControl makes
                    'MemoEdits should make newline by pressing Enter Key
                    With CType(item, MemoEdit)
                        '.EnterMoveNextControl = True
                        .Properties.NullValuePrompt = $"Input { .Name}..."
                        .Properties.NullValuePromptShowForEmptyValue = True
                        If bClear Then .Text = Nothing
                    End With

                ElseIf item.GetType = GetType(TokenEdit) Then
                    With CType(item, TokenEdit)
                        .EnterMoveNextControl = True
                        .Properties.PopupFilterMode = TokenEditPopupFilterMode.Contains
                        If bClear Then .EditValue = Nothing
                    End With

                ElseIf item.GetType = GetType(SpinEdit) Then
                    With CType(item, SpinEdit)
                        .EnterMoveNextControl = True
                        .Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
                        .Properties.IsFloatValue = False
                        .Properties.Mask.BeepOnError = True
                        .Properties.Mask.EditMask = "n0"
                        .Properties.Mask.MaskType = Mask.MaskType.Numeric
                        .Properties.Mask.UseMaskAsDisplayFormat = True
                        .Properties.NullValuePrompt = "0"
                        .Properties.NullValuePromptShowForEmptyValue = True
                        If bClear Then .Value = 0
                    End With

                ElseIf item.GetType = GetType(CalcEdit) Then
                    With CType(item, CalcEdit)
                        .EnterMoveNextControl = True
                        .Properties.Appearance.Options.UseTextOptions = True
                        .Properties.DisplayFormat.FormatString = "{0:N2}"
                        .Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        .Properties.EditFormat.FormatString = "{0:N2}"
                        .Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        .Properties.Mask.BeepOnError = True
                        .Properties.Mask.EditMask = "N2"
                        .Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                        .Properties.Mask.UseMaskAsDisplayFormat = True
                        .Properties.NullValuePrompt = "0.00"
                        .Properties.NullValuePromptShowForEmptyValue = True
                        .Properties.NullText = "0.00"
                        .Properties.ShowCloseButton = True
                        .Properties.ShowNullValuePromptWhenFocused = True
                        If bClear Then .Value = 0
                    End With

                ElseIf item.GetType = GetType(DateEdit) Then
                    With CType(item, DateEdit)
                        .EnterMoveNextControl = True
                        .Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
                        .Properties.Appearance.Options.UseTextOptions = True
                        .Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                        .Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True
                        .Properties.DisplayFormat.FormatString = "MMMM dd, yyyy"
                        .Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                        .Properties.EditFormat.FormatString = "MMMM dd, yyyy"
                        .Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                        .Properties.Mask.BeepOnError = True
                        .Properties.Mask.EditMask = "MMMM dd, yyyy"
                        .Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
                        .Properties.Mask.UseMaskAsDisplayFormat = True
                        .Properties.ShowWeekNumbers = True
                        If bClear Then .EditValue = Date.Today
                    End With

                ElseIf item.GetType = GetType(PopupContainerEdit) Then
                    With CType(item, PopupContainerEdit)
                        .Properties.CloseOnOuterMouseClick = False
                        .Properties.PopupSizeable = True
                        .Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
                    End With

                ElseIf item.GetType = GetType(LookUpEdit) Then
                    With CType(item, LookUpEdit)
                        .EnterMoveNextControl = True
                        .Properties.BestFitMode = XtraEditors.Controls.BestFitMode.BestFitResizePopup
                        .Properties.ImmediatePopup = True
                        .Properties.NullValuePrompt = $"SELECT { .Name}..."
                        .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                        .Properties.PopupSizeable = True
                        .Properties.PopupWidthMode = PopupWidthMode.ContentWidth
                        .Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
                    End With

                ElseIf item.GetType = GetType(SearchLookUpEdit) Then
                    With CType(item, SearchLookUpEdit)
                        .EnterMoveNextControl = True
                        .Properties.BestFitMode = XtraEditors.Controls.BestFitMode.BestFitResizePopup
                        .Properties.ImmediatePopup = True
                        .Properties.NullValuePrompt = $"SELECT { .Name}..."
                        .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                        .Properties.PopupSizeable = True
                        .Properties.PopupWidthMode = PopupWidthMode.ContentWidth
                        .Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
                    End With

                ElseIf item.GetType = GetType(TreeListLookUpEdit) Then
                    With CType(item, TreeListLookUpEdit)
                        .EnterMoveNextControl = True
                        .Properties.AutoComplete = False
                        .Properties.BestFitMode = XtraEditors.Controls.BestFitMode.BestFitResizePopup
                        .Properties.ImmediatePopup = True
                        .Properties.NullValuePrompt = $"SELECT { .Name}..."
                        .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                        .Properties.PopupSizeable = True
                        .Properties.PopupWidthMode = PopupWidthMode.ContentWidth
                        .Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
                    End With
                End If

                For Each subControl As System.Windows.Forms.Control In control.Controls
                    Initialize_Controls(subControl, bClear)
                Next
            Next
        End Sub

        Public Sub Control_SetBackColor(ByVal control As System.Windows.Forms.Control)
            If control.GetType = GetType(TextEdit) Then control.BackColor = SystemColors.Control
            If control.GetType = GetType(SpinEdit) Then control.BackColor = SystemColors.Control
            If control.GetType = GetType(CalcEdit) Then control.BackColor = SystemColors.Control
            If control.GetType = GetType(DateEdit) Then control.BackColor = SystemColors.Control
            If control.GetType = GetType(MemoEdit) Then control.BackColor = SystemColors.Control
            If control.GetType = GetType(ComboBoxEdit) Then control.BackColor = SystemColors.Control

            For Each subControls As System.Windows.Forms.Control In control.Controls
                Control_SetBackColor(subControls)
            Next
        End Sub

        Public Sub Initialize_RepositoryItem(ByVal repositoryItem As RepositoryItem, ByVal textEditStyle As DevExpress.XtraEditors.Controls.TextEditStyles)
            If TypeOf repositoryItem Is RepositoryItemLookUpEdit Then
                With CType(repositoryItem, RepositoryItemLookUpEdit)
                    .BestFitMode = XtraEditors.Controls.BestFitMode.BestFitResizePopup
                    .ImmediatePopup = True
                    .PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                    .PopupWidthMode = PopupWidthMode.ContentWidth
                    .TextEditStyle = textEditStyle
                End With

            ElseIf TypeOf repositoryItem Is RepositoryItemTreeListLookUpEdit Then
                With CType(repositoryItem, RepositoryItemTreeListLookUpEdit)
                    .BestFitMode = XtraEditors.Controls.BestFitMode.BestFitResizePopup
                    .ImmediatePopup = True
                    .PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                    .PopupWidthMode = PopupWidthMode.ContentWidth
                    .TextEditStyle = textEditStyle
                End With
            End If

        End Sub

        Public Sub Show_Data_Error(ByVal baseEdit As BaseEdit, ByVal sError As String, Optional ByVal bShowError As Boolean = True)
            SystemSounds.Hand.Play()
            dx.SetError(baseEdit, sError, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            If bShowError Then Set_Message(MsgMode.Errorr, sError)
            baseEdit.ForeColor = System.Drawing.SystemColors.InfoText
            baseEdit.BackColor = System.Drawing.SystemColors.Info
            baseEdit.Select()
        End Sub

        Public Function isEmpty(ByVal baseEdit As BaseEdit, Optional ByVal bShowError As Boolean = True) As Boolean
            Dim sError As String = $"{baseEdit.Name} is required but looks empty or input is not valid.{Environment.NewLine}Please input valid data to continue."
            If (baseEdit.GetType = GetType(TextEdit)) OrElse (baseEdit.GetType = GetType(ComboBoxEdit)) OrElse (baseEdit.GetType = GetType(MemoEdit)) OrElse (baseEdit.GetType = GetType(LookUpEdit)) OrElse (baseEdit.GetType = GetType(CalcEdit)) Then
                If baseEdit.Text.Equals(Nothing) OrElse baseEdit.Text.Equals(String.Empty) OrElse baseEdit.Text.Equals(0.00) OrElse baseEdit.Text.Contains("Select") Then
                    Show_Data_Error(baseEdit, sError, bShowError)
                    Return True
                Else
                    dx.SetError(baseEdit, String.Empty, DXErrorProvider.ErrorType.Default)
                    Return False
                End If
            End If
            Return False
        End Function

        Public Function isLength(ByVal baseEdit As BaseEdit, ByVal iMinimum As Integer) As Boolean
            Dim sError As String = $"{baseEdit.Name} looks valid but must be equal or more than {iMinimum} characters.{Environment.NewLine}Please input required data to continue."
            If (baseEdit.GetType = GetType(TextEdit)) OrElse (baseEdit.GetType = GetType(ComboBoxEdit)) OrElse (baseEdit.GetType = GetType(MemoEdit)) OrElse (baseEdit.GetType = GetType(LookUpEdit)) Then
                If (baseEdit.Text.Length < iMinimum) Then
                    dx.SetError(baseEdit, sError, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    Set_Message(MsgMode.Errorr, sError)
                    baseEdit.ForeColor = System.Drawing.SystemColors.InfoText
                    baseEdit.BackColor = System.Drawing.SystemColors.Info
                    baseEdit.Select()
                    Return True
                End If
            End If
            Return False
        End Function

        Public Function Show_Error(ByVal ExError As Exception, Optional ByRef sPreMessage As String = "", Optional ByRef sPostMessage As String = "", Optional sTitle As String = "", Optional bMessageBox As Boolean = False) As Boolean
            If sPreMessage.Length > 0 Then sPreMessage += Environment.NewLine
            If sPostMessage.Length > 0 Then sPostMessage = $"{Environment.NewLine}{sPostMessage}"

            If TypeOf ExError Is SqlClient.SqlException Then
                class_Database.DBError = True
                class_Procedures.Set_Message(class_Procedures.MsgMode.Sql, $"{sPreMessage}{CType(ExError, SqlClient.SqlException).ErrorCode}{Environment.NewLine}{CType(ExError, SqlClient.SqlException).Server}{Environment.NewLine}{CType(ExError, SqlClient.SqlException).Source}-{CType(ExError, SqlClient.SqlException).Procedure}-{CType(ExError, SqlClient.SqlException).LineNumber}{Environment.NewLine}{CType(ExError, SqlClient.SqlException).Message}{sPostMessage}", sTitle, bMessageBox)
            Else
                If class_Variables.bStackError Then
                    class_Procedures.Copy_Clipboard(ExError.StackTrace, False)
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"{sPreMessage}{ExError.HResult}{ExError.Source}{Environment.NewLine}{ExError.Message}{Environment.NewLine}{ExError.StackTrace}{sPostMessage}", sTitle, bMessageBox)
                Else
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"{sPreMessage}{ExError.HResult}{ExError.Source}{Environment.NewLine}{ExError.Message}{sPostMessage}", sTitle, bMessageBox)
                End If
            End If
            Return False
        End Function

        Public Sub Set_Message(ByVal msgMode As MsgMode, ByVal sTransaction As String, Optional ByVal sTitle As String = "", Optional ByVal bMessageBox As Boolean = False)
            Set_Message(frm, msgMode, sTransaction, sTitle, bMessageBox)
        End Sub

        Public Sub Set_Message(ByVal frm As XtraForm, ByVal msgMode As MsgMode, ByVal sTransaction As String, Optional ByVal sTitle As String = "", Optional ByVal bMessageBox As Boolean = False)
            Select Case msgMode
                Case MsgMode.Sql
                    class_Database.sError = sTitle
                    If bMessageBox Then
                        MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Else
                        class_Procedures.frm.AlertControl.Show(frm, $"SQL Error {sTitle}", sTransaction, class_Procedures.frm.ImageCollection16.Images(0))
                    End If
                Case MsgMode.Info
                    If bMessageBox Then
                        MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        class_Procedures.frm.AlertControl.Show(frm, $"Information {sTitle}", sTransaction, "Information", class_Procedures.frm.ImageCollection16.Images(1))
                    End If
                Case MsgMode.Warning
                    If bMessageBox Then
                        MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        class_Procedures.frm.AlertControl.Show(frm, $"Warning {sTitle}", sTransaction, class_Procedures.frm.ImageCollection16.Images(2))
                    End If
                Case MsgMode.Errorr
                    class_Database.sError = sTitle
                    If bMessageBox Then
                        MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        class_Procedures.frm.AlertControl.Show(frm, $"Error {sTitle}", sTransaction, class_Procedures.frm.ImageCollection16.Images(3))
                    End If
                Case MsgMode.Update
                    If bMessageBox Then
                        MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        class_Procedures.frm.AlertControl.Show(frm, $"Modified/Updated {sTitle}", $"{sTransaction} has been successfully modified/updated.", class_Procedures.frm.ImageCollection16.Images(4))
                    End If
                Case MsgMode.Save
                    If bMessageBox Then
                        MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        class_Procedures.frm.AlertControl.Show(frm, $"Saved/Added {sTitle}", $"{sTransaction} has been successfully saved/added.", class_Procedures.frm.ImageCollection16.Images(5))
                    End If
                Case MsgMode.Delete
                    If bMessageBox Then
                        MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        class_Procedures.frm.AlertControl.Show(frm, $"Deleted/Removed {sTitle}", $"{sTransaction} has been successfully deleted/removed.", class_Procedures.frm.ImageCollection16.Images(6))
                    End If
            End Select
            'Application.DoEvents()
        End Sub

        Public Sub Loop_Stop_Message(ByVal sTransaction As String, ByVal sEvent As String, Optional ByRef sTitle As String = "")
            Set_Message(class_Procedures.MsgMode.Warning, $"Some of the selected {sTransaction} has been unsuccessfully {sEvent} due to Network/Database Error or the user stopped the process.", sTitle)
        End Sub

        Public Sub Copy_Clipboard(ByVal sValue As String, Optional ByVal bShowMessage As Boolean = True)
            Try
                Clipboard.SetDataObject(sValue, True)
            Catch Ex As Exception
                Show_Error(Ex)
            End Try
            If bShowMessage Then Set_Message(class_Procedures.MsgMode.Info, $"{sValue} was copied into clipboard memory.")
        End Sub

        Public Sub process_Command(ByVal sCommand As String, ByVal sDirectory As String, ByVal bDOS As Boolean)
            Dim process1 As System.Diagnostics.Process = New System.Diagnostics.Process With {
            .EnableRaisingEvents = False
        }

            If bDOS Then
                System.Diagnostics.Process.Start("cmd.exe", sCommand)
            Else
                System.Diagnostics.Process.Start(sCommand, sDirectory)
            End If

            process1.Close()
        End Sub

        Public Sub play_Sound(ByVal sWavPath As String)
            Dim sp As SoundPlayer = New SoundPlayer()
            Try
                sp.SoundLocation = sWavPath
                sp.Play()
            Catch
            Finally
                sp.Dispose()
            End Try
        End Sub

        Public Sub Initialize_Printing(ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs)
            Dim printingSystem As PrintingSystemBase = CType(e.PrintingSystem, PrintingSystemBase)
            printingSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Legal
            printingSystem.PageSettings.Landscape = True
            printingSystem.PageSettings.LeftMargin = 20
            printingSystem.PageSettings.RightMargin = 120
            printingSystem.PageSettings.TopMargin = 20
            printingSystem.PageSettings.BottomMargin = 20
        End Sub

        Public Sub Show_Report(ByVal rpt As XtraReport, ByVal sQuery As String)
            rpt.DataSource = class_Database.BindToData(sQuery)
            rpt.DataMember = "customQuery"
            Dim reportPrintTool As ReportPrintTool = New ReportPrintTool(rpt)
            reportPrintTool.ShowRibbonPreview()
        End Sub

        Public Function actionAsk(ByVal sTitle As String, ByVal sTransaction As String, Optional ByVal sNote As String = "This might take more than a while.", Optional ByVal sWarning As String = "You can't UNDO this Operation.", Optional ByVal sReminder As String = "Please review or verify before you proceed.") As Boolean
            Dim myResult As DialogResult = XtraMessageBox.Show($"Do you want to {sTransaction}?{Environment.NewLine}Note: {sNote}.{Environment.NewLine}Warning: {sWarning}.{Environment.NewLine}Reminder: {sReminder}.{Environment.NewLine}Then click 'YES' to continue or 'NO' to cancel.", $"Action Command: {sTitle}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If myResult = System.Windows.Forms.DialogResult.Yes Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Sub Restore_Controls(ByVal baseControl As BaseControl)
            For Each item In baseControl.Controls
                If baseControl.GetType = GetType(BarManager) Then
                    CType(item, BarManager).RestoreLayoutFromRegistry(baseControl.Name)

                ElseIf baseControl.GetType = GetType(DockManager) Then
                    CType(item, DockManager).RestoreLayoutFromRegistry(baseControl.Name)

                End If
            Next

            For Each subControls As BaseControl In baseControl.Controls
                Restore_Controls(subControls)
            Next
        End Sub

        Public Sub Save_Controls(ByVal control As BaseControl)
            For Each item In control.Controls
                If control.GetType = GetType(BarManager) Then
                    CType(item, BarManager).RestoreLayoutFromRegistry(control.Name)

                ElseIf control.GetType = GetType(DockManager) Then
                    CType(item, DockManager).RestoreLayoutFromRegistry(control.Name)

                End If
            Next

            For Each subControls As BaseControl In control.Controls
                Save_Controls(subControls)
            Next
        End Sub

        Public Sub Initialize_Form(ByVal frm As XtraForm, ByVal dockManager As DockManager, ByVal BtnCancel As SimpleButton)
            Initialize_Form(frm, BtnCancel)

            dockManager.DockingOptions.ShowCloseButton = False
            dockManager.RestoreLayoutFromRegistry(frm.Name)
        End Sub

        Public Sub Initialize_Form(ByVal frm As XtraForm, ByVal BtnCancel As SimpleButton, ByVal xucSettings As Controls.Settings.xuc_Settings)
            Initialize_Form(frm, BtnCancel)
            Initialize_Xuc_Settings(frm, xucSettings)
        End Sub

        Public Sub Initialize_Form(ByVal frm As XtraForm, ByVal dockManager As DockManager, gridView As GridView, ByVal BtnCancel As SimpleButton)
            Initialize_Form(frm, BtnCancel)

            dockManager.DockingOptions.ShowCloseButton = False
            dockManager.RestoreLayoutFromRegistry(frm.Name)

            Initialize_GridView(frm, gridView)
        End Sub

        Public Sub Initialize_Form(ByVal frm As XtraForm, ByVal barManager As BarManager, gridView As GridView, ByVal BtnCancel As SimpleButton)
            Initialize_Form(frm, BtnCancel)
            barManager.RestoreLayoutFromRegistry(frm.Name)
            Initialize_GridView(frm, gridView)
        End Sub

        Public Sub Initialize_Form(ByVal frm As XtraForm, ByVal dockManager As DockManager, ByVal BtnCancel As SimpleButton, ByVal xucSettings As Controls.Settings.xuc_Settings)
            Initialize_Form(frm, BtnCancel)
            Initialize_Xuc_Settings(frm, xucSettings)

            dockManager.DockingOptions.ShowCloseButton = False

            If xucSettings.Check_Save_Restore_Layout.Checked Then
                dockManager.RestoreLayoutFromRegistry(frm.Name)
            End If
        End Sub

        Public Sub Initialize_Form(ByVal frm As XtraForm, ByVal dockManager As DockManager, gridView As GridView, ByVal BtnCancel As SimpleButton, ByVal xucSettings As Controls.Settings.xuc_Settings)
            Initialize_Form(frm, BtnCancel)
            Initialize_Xuc_Settings(frm, xucSettings)

            dockManager.DockingOptions.ShowCloseButton = False

            If xucSettings.Check_Save_Restore_Layout.Checked Then
                dockManager.RestoreLayoutFromRegistry(frm.Name)
            End If

            Initialize_GridView(frm, gridView, xucSettings.Check_Save_Restore_Layout.Checked)
        End Sub

        Public Sub Initialize_Form(ByVal frm As XtraForm, ByVal dockManager As DockManager, treeList As TreeList, ByVal BtnCancel As SimpleButton, ByVal xucSettings As Controls.Settings.xuc_Settings)
            Initialize_Form(frm, BtnCancel)
            Initialize_Xuc_Settings(frm, xucSettings)

            dockManager.DockingOptions.ShowCloseButton = False

            If xucSettings.Check_Save_Restore_Layout.Checked Then
                dockManager.RestoreLayoutFromRegistry(frm.Name)
            End If

            Initialize_TreeList(frm, treeList, xucSettings.Check_Save_Restore_Layout.Checked)
        End Sub

        Public Sub Initialize_Form(ByVal frm As XtraForm, gridView As GridView, ByVal BtnCancel As SimpleButton)
            Initialize_Form(frm, BtnCancel)

            Initialize_GridView(frm, gridView)
        End Sub

        Public Sub Initialize_Form(ByVal frm As XtraForm, ByVal BtnCancel As SimpleButton, Optional ByVal bCustomFormName As Boolean = False, Optional ByVal sCustomFormName As String = "")
            Dim iDefaultWidth As Integer
            Dim iDefaultHeight As Integer

            BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            BtnCancel.Location = New Point(0, 0)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New System.Drawing.Size(0, 0)

            frm.StartPosition = FormStartPosition.Manual
            frm.CancelButton = BtnCancel
            frm.Controls.Add(BtnCancel)
            frm.Icon = class_Procedures.frm.Icon

            Select Case frm.FormBorderStyle
                Case System.Windows.Forms.FormBorderStyle.Sizable
                    iDefaultWidth = 800
                    iDefaultHeight = 600

                Case Else
                    iDefaultWidth = 300
                    iDefaultHeight = 400
            End Select

            If bCustomFormName Then
                frm.Top = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_{sCustomFormName}_Top", 100)
                frm.Left = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_{sCustomFormName}_Left", 100)
                frm.Width = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_{sCustomFormName}_Width", iDefaultWidth)
                frm.Height = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_{sCustomFormName}_Height", iDefaultHeight)
            Else
                frm.Top = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_Top", 100)
                frm.Left = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_Left", 100)
                frm.Width = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_Width", iDefaultWidth)
                frm.Height = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_Height", iDefaultHeight)
            End If

            class_Procedures.Initialize_Controls(frm)
        End Sub

        Public Sub Initialize_GridView(ByVal frm As XtraForm, ByVal gridView As GridView, Optional ByVal bRestoreLayout As Boolean = True, Optional bEditable As Boolean = False, Optional ByVal bNewRow As Boolean = False)
            Initialize_GridView(gridView, bEditable, bNewRow)

            If bRestoreLayout Then
                gridView.RestoreLayoutFromRegistry(frm.Name)
            End If
        End Sub

        Public Sub Initialize_GridView(ByVal xUserControl As XtraUserControl, ByVal gridView As GridView, Optional bEditable As Boolean = False, Optional ByVal bNewRow As Boolean = False)
            Initialize_GridView(gridView, bEditable, bNewRow)
            gridView.RestoreLayoutFromRegistry(xUserControl.Name)
        End Sub

        Public Sub Initialize_GridView(ByVal gridView As GridView, Optional bEditable As Boolean = False, Optional ByVal bNewRow As Boolean = False)
            With gridView
                .OptionsBehavior.Editable = bEditable
                .OptionsBehavior.AutoExpandAllGroups = True
                .OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True

                .OptionsCustomization.CustomizationFormSearchBoxVisible = True

                .OptionsNavigation.AutoFocusNewRow = True
                .OptionsSelection.MultiSelect = True

                .OptionsView.ColumnAutoWidth = False
                .OptionsView.ShowAutoFilterRow = True
                .OptionsView.ShowChildrenInGroupPanel = True
                .OptionsView.ShowFooter = True
                '.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full

                .OptionsMenu.ShowConditionalFormattingItem = True
                .OptionsMenu.ShowGroupSummaryEditorItem = True
                .OptionsMenu.EnableFooterMenu = True
                .OptionsMenu.ShowFooterItem = True

                .OptionsLayout.StoreFormatRules = True

                repoItemHyperLinkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()

                If bNewRow Then
                    .OptionsNavigation.AutoFocusNewRow = True
                    .OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                End If
            End With

            For Each col In gridView.Columns
                If col.GetType = GetType(GridColumn) Then
                    With CType(col, GridColumn)
                        .Visible = True
                        .AppearanceCell.Options.UseTextOptions = True

                        If .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric Then
                            .DisplayFormat.FormatString = "{0:N2}"
                            .GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                            .GroupFormat.FormatString = "{0:N2}"
                            Continue For

                        ElseIf .FieldName.EndsWith("ID") Or
                                .FieldName.Contains("Code") Or
                                .FieldName.Contains("Reference") Or
                                .FieldName.Contains("Number") Or
                                .FieldName.Contains("Engine") Or
                                .FieldName.Contains("Chassis") Or
                                .FieldName.Contains("Mobile") Or
                                .FieldName.Contains("Debit") Or
                                .FieldName.Contains("Credit") Or
                                .FieldName.EndsWith("Approver") Or
                                .FieldName.EndsWith("By") Then

                            If .FieldName.Contains("Branch") Then
                                Continue For
                            Else
                                If .ColumnEdit Is Nothing Then
                                    .ColumnEdit = repoItemHyperLinkEdit
                                    Continue For
                                End If

                            End If

                        ElseIf .FieldName.Equals("ID") Or .FieldName.Equals("id") Or .FieldName.Equals("sequenceno") Then
                            .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                            .SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                            Continue For

                        ElseIf (.FieldName.Contains("Date") Or .FieldName.Contains("date") Or .FieldName.Contains("Day") Or .FieldName.Contains("day")) Then
                            If (.FieldName.Contains("Days")) Then
                                Continue For
                            Else
                                .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                                .DisplayFormat.FormatString = "MMMM dd, yyyy"
                                .GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                                .GroupFormat.FormatString = "MMMM dd, yyyy"

                                If .Name.Contains("Transaction") Then
                                    .Caption = "Transaction Date"
                                    .DisplayFormat.FormatString = "MMMM dd, yyyy HH:mm:ss"
                                    Continue For

                                ElseIf .Name.Contains("Added") Then
                                    .Caption = "Added Date"
                                    .DisplayFormat.FormatString = "MMMM dd, yyyy HH:mm:ss"
                                    Continue For

                                ElseIf .Name.Contains("Modified") Then
                                    .Caption = "Modified Date"
                                    .DisplayFormat.FormatString = "MMMM dd, yyyy HH:mm:ss"
                                    Continue For

                                ElseIf .Name.Contains("Opened") Then
                                    .Caption = "Opened Date"
                                    .DisplayFormat.FormatString = "MMMM dd, yyyy HH:mm:ss"
                                    Continue For

                                ElseIf .Name.Contains("Closed") Then
                                    .Caption = "Closed Date"
                                    .DisplayFormat.FormatString = "MMMM dd, yyyy HH:mm:ss"
                                    Continue For

                                ElseIf .Name.Contains("Approved") Then
                                    .Caption = "Approved Date"
                                    .DisplayFormat.FormatString = "MMMM dd, yyyy HH:mm:ss"
                                    Continue For

                                ElseIf .Name.Contains("Verified") Then
                                    .Caption = "Verified Date"
                                    .DisplayFormat.FormatString = "MMMM dd, yyyy HH:mm:ss"
                                    Continue For

                                ElseIf .Name.Contains("Deleted") Then
                                    .Caption = "Deleted Date"
                                    .DisplayFormat.FormatString = "MMMM dd, yyyy HH:mm:ss"
                                    Continue For

                                ElseIf .Name.Contains("Locked") Then
                                    .Caption = "Locked Date"
                                    .DisplayFormat.FormatString = "MMMM dd, yyyy HH:mm:ss"
                                    Continue For
                                End If
                            End If
                        End If
                    End With
                End If
            Next
        End Sub

        Public Sub Initialize_TreeList(ByVal frm As XtraForm, ByVal treeList As TreeList, Optional ByVal bRestoreLayout As Boolean = True)
            If bRestoreLayout Then
                treeList.RestoreLayoutFromRegistry(frm.Name)
            End If
        End Sub

        Public Sub Initialize_TreeList(ByVal treeList As XtraTreeList.TreeList, ByVal sParentFieldName As String, ByVal sKeyFieldName As String)
            With treeList
                .KeyFieldName = sKeyFieldName
                .OptionsBehavior.AllowExpandOnDblClick = True
                .OptionsBehavior.Editable = False
                .OptionsMenu.ShowConditionalFormattingItem = True
                .OptionsMenu.ShowExpandCollapseItems = False
                .OptionsMenu.ShowFooterItem = True
                .OptionsPrint.PrintRowFooterSummary = True
                .OptionsSelection.MultiSelect = True
                .OptionsView.AutoWidth = False
                .OptionsView.ShowIndentAsRowStyle = True
                .OptionsView.ShowRowFooterSummary = True
                .OptionsView.ShowSummaryFooter = True
                .ParentFieldName = sParentFieldName

                For Each col In .Columns
                    If col.GetType = GetType(TreeListColumn) Then
                        With col
                            If .FieldName.EndsWith("Code") Or
                            .FieldName.EndsWith("Debit") Or
                            .FieldName.EndsWith("Credit") Or
                            .FieldName.EndsWith("By") Then

                                If .ColumnEdit Is Nothing Then
                                    .ColumnEdit = repoItemHyperLinkEdit
                                    Continue For
                                End If

                            ElseIf .Format.FormatType = DevExpress.Utils.FormatType.Numeric Then
                                .AllNodesSummary = True
                                .Format.FormatString = "{0:N2}"
                                .RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum
                                .RowFooterSummaryStrFormat = "Sub-Total {0:N2}"
                                .SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum
                                .SummaryFooterStrFormat = "Total {0:N2}"

                            ElseIf .FieldName.Contains("Date") Then
                                .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Format.FormatType = DevExpress.Utils.FormatType.DateTime
                                .Format.FormatString = "MMMM dd, yyyy"
                            End If
                        End With
                    End If
                Next
            End With
        End Sub

        Public Sub Initialize_Xuc_Settings(ByVal frm As XtraForm, ByVal xucSettings As Controls.Settings.xuc_Settings)
            xucSettings.Check_Load_All.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Load_All.Name, False)
            xucSettings.Check_Auto_Show.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Auto_Show.Name, True)
            xucSettings.Check_Auto_Reload.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Auto_Reload.Name, False)
            xucSettings.Check_Live_Looping.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Live_Looping.Name, True)
            xucSettings.Check_Clear_Selection.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Clear_Selection.Name, False)

            xucSettings.Check_Auto_Initialize.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Auto_Initialize.Name, True)
            xucSettings.Check_Clear_New.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Clear_New.Name, False)
            xucSettings.Check_Clear_Save_Delete.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Clear_Save_Delete.Name, False)

            xucSettings.Check_Save_Restore_Layout.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Save_Restore_Layout.Name, True)
            xucSettings.MemoEdit_Notes.Text = class_Tools.RegKeyGet(frm.Name, xucSettings.MemoEdit_Notes.Name, String.Empty)

        End Sub

        Public Sub Save_Xuc_Settings(ByVal frm As XtraForm, ByVal xucSettings As Controls.Settings.xuc_Settings)
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Load_All.Name, xucSettings.Check_Load_All.Checked)
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Auto_Show.Name, xucSettings.Check_Auto_Show.Checked)
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Auto_Reload.Name, xucSettings.Check_Auto_Reload.Checked)
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Live_Looping.Name, xucSettings.Check_Live_Looping.Checked)
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Clear_Selection.Name, xucSettings.Check_Clear_Selection.Checked)

            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Auto_Initialize.Name, xucSettings.Check_Auto_Initialize.Checked)
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Clear_New.Name, xucSettings.Check_Clear_New.Checked)
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Clear_Save_Delete.Name, xucSettings.Check_Clear_Save_Delete.Checked)

            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Save_Restore_Layout.Name, xucSettings.Check_Save_Restore_Layout.Checked)
            class_Tools.RegKeySet(frm.Name, xucSettings.MemoEdit_Notes.Name, xucSettings.MemoEdit_Notes.Text)
        End Sub

        Public Sub Get_Skin()
            Try
                Dim sDefaultSkin As String = class_Tools.RegKeyGet(class_Database.SqlServer, "Skin", "Basic")
                Select Case sDefaultSkin
                    Case "Basic", "The Bezier", "Office 2019 Colorful"
                        LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(sDefaultSkin, class_Tools.RegKeyGet(class_Database.SqlServer, "Palette", "Default"))
                    Case Else
                        LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(sDefaultSkin)
                End Select
            Catch Ex As Exception
                Show_Error(Ex)
            End Try
        End Sub

        Public Sub Set_Skin()
            Try
                class_Tools.RegKeySet(class_Database.SqlServer, "Skin", LookAndFeel.UserLookAndFeel.Default.SkinName)
                Select Case LookAndFeel.UserLookAndFeel.Default.SkinName
                    Case "Basic", "The Bezier", "Office 2019 Colorful"
                        class_Tools.RegKeySet(class_Database.SqlServer, "Palette", LookAndFeel.UserLookAndFeel.Default.ActiveSvgPaletteName)
                End Select
            Catch Ex As Exception
                Show_Error(Ex)
            End Try
        End Sub

        Public Sub Show_Form(ByVal frm As XtraForm, ByVal sDescription As String)
            class_Procedures.splash_Show(frm, sDescription,, True, xFormMode.xForm)
            Try
                With frm
                    .Text = sDescription
                    .Icon = frm.Icon
                    .Show()
                End With
            Catch Ex As Exception
                Show_Error(Ex)
            End Try
            class_Procedures.splash_Close(True)
        End Sub

        Public Sub Show_Form(ByVal mdiForm As Ribbon.RibbonForm, ByVal frm As XtraForm, ByVal sDescription As String, Optional ByVal bChild As Boolean = True)
            class_Procedures.splash_Show(sDescription, , True, xFormMode.xForm)
            Try
                With frm
                    If bChild Then .MdiParent = mdiForm
                    .Text = sDescription
                    .Icon = mdiForm.Icon
                    .Show()
                End With
            Catch Ex As Exception
                Show_Error(Ex)
            End Try
            class_Procedures.splash_Close(True)
        End Sub

        Public Sub Show_Form(ByVal mdiForm As Ribbon.RibbonForm, ByVal frm As Form, ByVal sDescription As String, Optional ByVal bChild As Boolean = True)
            class_Procedures.splash_Show(sDescription, , True, xFormMode.xForm)
            Try
                With frm
                    If bChild Then .MdiParent = mdiForm
                    .Text = sDescription
                    .Icon = mdiForm.Icon
                    .Show()
                End With
            Catch Ex As Exception
                Show_Error(Ex)
            End Try
            class_Procedures.splash_Close(True)
        End Sub

        Private Sub Form_Dispose(ByVal frm As XtraForm, Optional ByVal bCustomFormName As Boolean = False, Optional ByVal sCustomFormName As String = "")
            splash_Show($"closing {frm.Name}", "Closing Form")

            If frm.WindowState.Equals(FormWindowState.Normal) Then
                If bCustomFormName Then
                    class_Tools.RegKeySet($"{frm.Name}_{sCustomFormName}", "Top", frm.Top)
                    class_Tools.RegKeySet($"{frm.Name}_{sCustomFormName}", "Left", frm.Left)
                    class_Tools.RegKeySet($"{frm.Name}_{sCustomFormName}", "Width", frm.Width)
                    class_Tools.RegKeySet($"{frm.Name}_{sCustomFormName}", "Height", frm.Height)
                Else
                    class_Tools.RegKeySet(frm.Name, $"{frm.Name}_Top", frm.Top)
                    class_Tools.RegKeySet(frm.Name, $"{frm.Name}_Left", frm.Left)
                    class_Tools.RegKeySet(frm.Name, $"{frm.Name}_Width", frm.Width)
                    class_Tools.RegKeySet(frm.Name, $"{frm.Name}_Height", frm.Height)
                End If
            End If

            frm.Dispose()
            frm.Close()
            splash_Close()
        End Sub

        Public Function Form_Close(ByVal frm As XtraForm, ByVal barManager As BarManager, ByVal dockManager As DockManager, Optional ByVal bAsk As Boolean = False) As Boolean
            barManager.SaveLayoutToRegistry(frm.Name)
            dockManager.SaveLayoutToRegistry(frm.Name)
            Return Form_Close(frm, bAsk)
        End Function

        Public Function Form_Close(ByVal frm As XtraForm, ByVal barManager As BarManager, ByVal gridview As GridView, Optional ByVal bAsk As Boolean = False) As Boolean
            barManager.SaveLayoutToRegistry(frm.Name)
            gridview.SaveLayoutToRegistry(frm.Name)
            Return Form_Close(frm, bAsk)
        End Function

        Public Function Form_Close(ByVal frm As XtraForm, ByVal gridview As GridView, Optional ByVal bAsk As Boolean = False) As Boolean
            gridview.SaveLayoutToRegistry(frm.Name)
            Return Form_Close(frm, bAsk)
        End Function

        Public Function Form_Close(ByVal frm As XtraForm, ByVal barManager As BarManager, ByVal dockManager As DockManager, ByVal gridview As GridView, Optional ByVal bAsk As Boolean = False) As Boolean
            barManager.SaveLayoutToRegistry(frm.Name)
            dockManager.SaveLayoutToRegistry(frm.Name)
            gridview.SaveLayoutToRegistry(frm.Name)
            Return Form_Close(frm, bAsk)
        End Function

        Public Function Form_Close(ByVal frm As XtraForm, ByVal barManager As BarManager, ByVal dockManager As DockManager, ByVal xucSettings As Controls.Settings.xuc_Settings, Optional ByVal bAsk As Boolean = False) As Boolean
            If xucSettings.Check_Save_Restore_Layout.Checked Then
                barManager.SaveLayoutToRegistry(frm.Name)
                dockManager.SaveLayoutToRegistry(frm.Name)
            End If

            Save_Xuc_Settings(frm, xucSettings)

            Return Form_Close(frm, bAsk)
        End Function

        Public Function Form_Close(ByVal frm As XtraForm, ByVal barManager As BarManager, Optional ByVal bAsk As Boolean = False, Optional ByVal bCustomFormName As Boolean = False, Optional ByVal sCustomFormName As String = "") As Boolean
            Try
                barManager.SaveLayoutToRegistry(frm.Name)
            Catch Ex As Exception
                Show_Error(Ex)
            End Try
            Return Form_Close(frm, bAsk, bCustomFormName, sCustomFormName)
        End Function

        Public Function Form_Close(ByVal frm As XtraForm, ByVal barManager As BarManager, ByVal dockManager As DockManager, ByVal gridview As GridView, ByVal xucSettings As Controls.Settings.xuc_Settings, Optional ByVal bAsk As Boolean = False) As Boolean
            If xucSettings.Check_Save_Restore_Layout.Checked Then
                barManager.SaveLayoutToRegistry(frm.Name)
                dockManager.SaveLayoutToRegistry(frm.Name)
                gridview.SaveLayoutToRegistry(frm.Name)
            End If

            Save_Xuc_Settings(frm, xucSettings)

            Return Form_Close(frm, bAsk)
        End Function

        Public Function Form_Close(ByVal frm As XtraForm, ByVal barManager As BarManager, ByVal dockManager As DockManager, ByVal treeList As TreeList, ByVal xucSettings As Controls.Settings.xuc_Settings, Optional ByVal bAsk As Boolean = False) As Boolean
            If xucSettings.Check_Save_Restore_Layout.Checked Then
                barManager.SaveLayoutToRegistry(frm.Name)
                dockManager.SaveLayoutToRegistry(frm.Name)
                treeList.SaveLayoutToRegistry(frm.Name)
            End If

            Save_Xuc_Settings(frm, xucSettings)

            Return Form_Close(frm, bAsk)
        End Function

        Public Function Form_Close(ByVal frm As XtraForm, Optional ByVal bAsk As Boolean = False, Optional ByVal bCustomFormName As Boolean = False, Optional ByVal sCustomFormName As String = "") As Boolean
            If bAsk Then
                If Environment.OSVersion.Version.Major.Equals(10) Then
                    Dim action As New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() With {.Caption = "Confirm", .Description = $"Close {frm.Name}-[{frm.Text}]?"}
                    Dim command1 As New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() With {.Text = "Close", .Result = System.Windows.Forms.DialogResult.Yes}
                    Dim command2 As New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() With {.Text = "Cancel", .Result = System.Windows.Forms.DialogResult.No}
                    action.Commands.Add(command1)
                    action.Commands.Add(command2)
                    Dim properties As New FlyoutProperties() With {.ButtonSize = New Size(100, 40), .Style = FlyoutStyle.MessageBox}
                    If FlyoutDialog.Show(frm, action, properties) = System.Windows.Forms.DialogResult.Yes Then
                        Form_Dispose(frm)
                        Return True
                    Else
                        Return False
                    End If
                Else
                    If actionAsk($"Close {frm.Name}", $"Close this {frm.Text}", "You might lose unsaved data.") Then
                        Form_Dispose(frm, bCustomFormName, sCustomFormName)
                        Return True
                    Else
                        Return False
                    End If
                End If
            Else
                Form_Dispose(frm, bCustomFormName, sCustomFormName)
            End If
            Return False
        End Function

    End Module
End Namespace