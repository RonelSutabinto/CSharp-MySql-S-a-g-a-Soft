using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using MyClassLibrary.Forms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MyClassLibrary.Classes
{
    public static class class_Procedures
    {
        private static RepositoryItemHyperLinkEdit repoItemHyperLinkEdit;

        public enum xFormMode
        {
            xForm,
            xWait
        }

        public enum MsgMode
        {
            Sql,
            Info,
            Warning,
            Errorr,
            Save,
            Update,
            Delete
        }

        public static DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dx = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
        public static XtraForm1 frm = new XtraForm1();

        public static void splash_Show(string sDescription, string sTitle = "Please wait", bool bForceShow = false, xFormMode xMode = xFormMode.xWait)
        {
            splash_Close();
            if (class_Variables.bSplash | bForceShow)
            {
                try
                {
                    switch (xMode)
                    {
                        case xFormMode.xForm:
                            {
                                SplashScreenManager.ShowForm(frm, typeof(SplashScreen1));
                                SplashScreenManager.ShowDefaultSplashScreen(class_Functions.Product_Name_Version(), sDescription);
                                break;
                            }

                        case xFormMode.xWait:
                            {
                                SplashScreenManager.ShowForm(frm, typeof(WaitForm1));
                                SplashScreenManager.ShowDefaultWaitForm(sTitle, $"Currently {sDescription}");
                                break;
                            }
                    }
                }
                catch (Exception)
                {
                }
                // Do not display Error because it will popup everytime when showing Splash and Wait forms
                // Show_Error(Ex)
                finally
                {
                    Application.DoEvents();
                }
            }
        }

        public static void splash_Show(XtraForm xfrm, string sDescription, string sTitle = "Please wait", bool bForceShow = false, xFormMode xMode = xFormMode.xWait)
        {
            splash_Close();
            if (class_Variables.bSplash | bForceShow)
            {
                try
                {
                    switch (xMode)
                    {
                        case xFormMode.xForm:
                            {
                                SplashScreenManager.ShowForm(typeof(SplashScreen1));
                                SplashScreenManager.ShowDefaultSplashScreen(xfrm, true, true, class_Functions.Product_Name_Version(), sDescription);
                                SplashScreenManager.ActivateParentOnSplashFormClosing = true;
                                break;
                            }

                        case xFormMode.xWait:
                            {
                                SplashScreenManager.ShowForm(typeof(WaitForm1));
                                SplashScreenManager.ShowDefaultWaitForm(xfrm, false, false, sTitle, $"Currently {sDescription}");
                                SplashScreenManager.ActivateParentOnWaitFormClosing = true;
                                break;
                            }
                    }
                }
                catch (Exception)
                {
                }
                // Do not display Error because it will popup everytime when showing Splash and Wait forms
                // Show_Error(Ex)
                finally
                {
                    Application.DoEvents();
                }
            }
        }

        public static void splash_Close(bool bForceClose = false)
        {
            if (class_Variables.bSplash | bForceClose)
            {
                try
                {
                    SplashScreenManager.CloseForm(true);
                    Application.DoEvents();
                }
                catch (Exception)
                {
                    // show_error(ex)
                }
            }
        }

        public static int Create_Badge(DevExpress.Utils.VisualEffects.AdornerUIManager adornerManager, BarButtonItem targetButton, DevExpress.Utils.VisualEffects.BadgePaintStyle paintStyle, int iCount)
        {
            var badge = new DevExpress.Utils.VisualEffects.Badge();
            adornerManager.Elements.Add(badge);
            badge.Visible = false;
            badge.TargetElement = targetButton;
            badge.Properties.PaintStyle = paintStyle;
            badge.Properties.Text = iCount.ToString();
            if (iCount > 0)
                badge.Visible = true;
            return iCount;
        }

        public static void Create_Badge(DevExpress.Utils.VisualEffects.AdornerUIManager adornerManager, DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageGroup, DevExpress.Utils.VisualEffects.BadgePaintStyle paintStyle, int iCount)
        {
            var badge = new DevExpress.Utils.VisualEffects.Badge();
            adornerManager.Elements.Add(badge);
            badge.Visible = false;
            badge.TargetElement = ribbonPageGroup;
            badge.Properties.PaintStyle = paintStyle;
            badge.Properties.Text = iCount.ToString();
            if (iCount > 0)
                badge.Visible = true;
        }

        public static void Initialize_Controls(Control control, bool bClear = false)
        {
            foreach (Control item in control.Controls)
            {
                var idList = new string[] { "ID", "id" };
                var nameToUpperList = new string[] { "Code", "Type", "Brand", "Name", "Profile", "Engine", "Chassis", "Department", "Category", "Status" };

                if (item is LookUpEdit lookUpEdit)
                {
                    lookUpEdit.EnterMoveNextControl = true;
                    lookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                    lookUpEdit.Properties.HotTrackItems = true;
                    lookUpEdit.Properties.ImmediatePopup = true;
                    lookUpEdit.Properties.NullValuePrompt = $"SELECT {lookUpEdit.Name}...";
                    lookUpEdit.Properties.PopupFilterMode = PopupFilterMode.Contains;
                    lookUpEdit.Properties.PopupSizeable = true;
                    lookUpEdit.Properties.PopupWidthMode = PopupWidthMode.ContentWidth;
                    lookUpEdit.Properties.ShowHeader = true;
                    lookUpEdit.Properties.ShowFooter = true;
                    lookUpEdit.Properties.ShowLines = true;
                    lookUpEdit.Properties.ShowPopupShadow = true;
                    lookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                }

                else if (item is SearchLookUpEdit searchLookUpEdit)
                {
                    searchLookUpEdit.EnterMoveNextControl = true;
                    searchLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                    searchLookUpEdit.Properties.ImmediatePopup = true;
                    searchLookUpEdit.Properties.NullValuePrompt = $"SELECT {searchLookUpEdit.Name}...";
                    searchLookUpEdit.Properties.PopupFilterMode = PopupFilterMode.Contains;
                    searchLookUpEdit.Properties.PopupSizeable = true;
                    searchLookUpEdit.Properties.PopupWidthMode = PopupWidthMode.ContentWidth;
                    searchLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                }

                else if (item is TreeListLookUpEdit treeListLookUpEdit)
                {
                    treeListLookUpEdit.EnterMoveNextControl = true;
                    treeListLookUpEdit.Properties.AutoComplete = false;
                    treeListLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                    treeListLookUpEdit.Properties.ImmediatePopup = true;
                    treeListLookUpEdit.Properties.NullValuePrompt = $"SELECT {treeListLookUpEdit.Name}...";
                    treeListLookUpEdit.Properties.PopupFilterMode = PopupFilterMode.Contains;
                    treeListLookUpEdit.Properties.PopupSizeable = true;
                    treeListLookUpEdit.Properties.PopupWidthMode = PopupWidthMode.ContentWidth;
                    treeListLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                }

                else if (item is DateEdit dateEdit)
                {
                    dateEdit.EnterMoveNextControl = true;
                    dateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
                    dateEdit.Properties.Appearance.Options.UseTextOptions = true;
                    dateEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                    dateEdit.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
                    dateEdit.Properties.DisplayFormat.FormatString = "MMMM dd, yyyy";
                    dateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    dateEdit.Properties.EditFormat.FormatString = "MMMM dd, yyyy";
                    dateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    dateEdit.Properties.Mask.BeepOnError = true;
                    dateEdit.Properties.Mask.EditMask = "MMMM dd, yyyy";
                    dateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                    dateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
                    dateEdit.Properties.ShowWeekNumbers = true;
                    if (bClear)
                        dateEdit.EditValue = DateTime.Today;
                }

                else if (item is CalcEdit calcEdit)
                {
                    calcEdit.EnterMoveNextControl = true;
                    calcEdit.Properties.Appearance.Options.UseTextOptions = true;
                    calcEdit.Properties.DisplayFormat.FormatString = "{0:N2}";
                    calcEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    calcEdit.Properties.EditFormat.FormatString = "{0:N2}";
                    calcEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    calcEdit.Properties.Mask.BeepOnError = true;
                    calcEdit.Properties.Mask.EditMask = "N2";
                    calcEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    calcEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
                    calcEdit.Properties.NullValuePrompt = "0.00";
                    calcEdit.Properties.NullValuePromptShowForEmptyValue = true;
                    calcEdit.Properties.NullText = "0.00";
                    calcEdit.Properties.ShowCloseButton = true;
                    calcEdit.Properties.ShowNullValuePromptWhenFocused = true;
                    if (bClear)
                        calcEdit.Value = 0;
                }

                else if (item is MemoEdit memoEdit)
                {
                    // MemoEdits should make newline by pressing Enter Key
                    // .EnterMoveNextControl = True
                    memoEdit.Properties.AcceptsReturn = true;
                    memoEdit.Properties.NullValuePrompt = $"Input {memoEdit.Name}...";
                    memoEdit.Properties.NullValuePromptShowForEmptyValue = true;
                    if (bClear)
                        memoEdit.Text = null;
                }

                else if (item is TextEdit textEdit)
                {
                    textEdit.EnterMoveNextControl = true;
                    textEdit.Properties.NullValuePrompt = $"Input {textEdit.Name}...";
                    textEdit.Properties.NullValuePromptShowForEmptyValue = true;
                    textEdit.EnterMoveNextControl = true;
                    if (bClear)
                        textEdit.Text = null;

                    foreach (var name in idList)
                    {
                        if (textEdit.Name.Equals(name))
                        {
                            textEdit.Text = "0";
                            textEdit.Properties.ReadOnly = true;
                        }
                        continue;
                    }

                    foreach (var name in nameToUpperList)
                    {
                        if (textEdit.Name.Contains(name))
                        {
                            textEdit.Properties.CharacterCasing = CharacterCasing.Upper;
                        }
                        if (textEdit.Name.Contains("Code"))
                        {
                            //textEdit.ReadOnly = true;
                        }
                        continue;
                    }
                }

                else if (item is ButtonEdit buttonEdit)
                {
                    buttonEdit.EnterMoveNextControl = true;
                    buttonEdit.Properties.NullValuePrompt = $"Input {buttonEdit.Name}...";
                    buttonEdit.Properties.NullValuePromptShowForEmptyValue = true;
                    if (bClear)
                        buttonEdit.Text = null;

                    foreach (var name in nameToUpperList)
                    {
                        if (buttonEdit.Name.Contains(name))
                        {
                            buttonEdit.Properties.CharacterCasing = CharacterCasing.Upper;
                        }
                        continue;
                    }
                }

                else if (item is ComboBoxEdit comboBoxEdit)
                {
                    comboBoxEdit.EnterMoveNextControl = true;
                    comboBoxEdit.Properties.AutoComplete = true;
                    comboBoxEdit.Properties.HotTrackItems = true;
                    comboBoxEdit.Properties.ImmediatePopup = true;
                    comboBoxEdit.Properties.UseCtrlScroll = true;
                    comboBoxEdit.Properties.PopupSizeable = true;
                    comboBoxEdit.Properties.NullValuePrompt = $"SELECT {comboBoxEdit.Name}...";
                    comboBoxEdit.Properties.NullValuePromptShowForEmptyValue = true;
                    comboBoxEdit.Properties.Sorted = true;
                    if (bClear)
                        comboBoxEdit.Text = null;

                    foreach (var name in nameToUpperList)
                    {
                        if (comboBoxEdit.Name.Contains(name))
                        {
                            comboBoxEdit.Properties.CharacterCasing = CharacterCasing.Upper;
                        }
                        continue;
                    }
                }

                else if (item is PopupContainerEdit popupContainerEdit)
                {
                    popupContainerEdit.Properties.CloseOnOuterMouseClick = false;
                    popupContainerEdit.Properties.PopupSizeable = true;
                    popupContainerEdit.Properties.ShowPopupShadow = true;
                    popupContainerEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    if (bClear)
                        popupContainerEdit.Text = null;
                }

                else if (item is CheckEdit checkEdit)
                {
                    checkEdit.EnterMoveNextControl = true;
                    checkEdit.Checked = false;
                }

                else if (item is ToggleSwitch toggleSwitch)
                {
                    toggleSwitch.EnterMoveNextControl = true;
                    toggleSwitch.EditValue = false;
                }

                else if (item is TokenEdit tokenEdit)
                {
                    tokenEdit.EnterMoveNextControl = true;
                    tokenEdit.Properties.PopupFilterMode = TokenEditPopupFilterMode.Contains;
                    if (bClear)
                        tokenEdit.EditValue = null;
                }

                else if (item is SpinEdit spinEdit)
                {
                    spinEdit.EnterMoveNextControl = true;
                    spinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
                    spinEdit.Properties.IsFloatValue = false;
                    spinEdit.Properties.Mask.BeepOnError = true;
                    spinEdit.Properties.Mask.EditMask = "n0";
                    spinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    spinEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
                    spinEdit.Properties.NullValuePrompt = "0";
                    spinEdit.Properties.NullValuePromptShowForEmptyValue = true;
                    if (bClear)
                        spinEdit.Value = 0;
                }

                foreach (Control subControl in control.Controls)
                    Initialize_Controls(subControl, bClear);
            }
        }

        public static void Control_SetBackColor(Control control)
        {
            if (control.GetType() == typeof(TextEdit))
                control.BackColor = SystemColors.Control;
            if (control.GetType() == typeof(SpinEdit))
                control.BackColor = SystemColors.Control;
            if (control.GetType() == typeof(CalcEdit))
                control.BackColor = SystemColors.Control;
            if (control.GetType() == typeof(DateEdit))
                control.BackColor = SystemColors.Control;
            if (control.GetType() == typeof(MemoEdit))
                control.BackColor = SystemColors.Control;
            if (control.GetType() == typeof(ComboBoxEdit))
                control.BackColor = SystemColors.Control;
            foreach (Control subControls in control.Controls)
                Control_SetBackColor(subControls);
        }

        public static void Initialize_LookUpEdit(LookUpEdit lookUpEdit, DevExpress.XtraEditors.Controls.TextEditStyles textEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard)
        {
            var withBlock = lookUpEdit.Properties;
            withBlock.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            withBlock.ImmediatePopup = true;
            withBlock.PopupFilterMode = PopupFilterMode.Contains;
            withBlock.PopupWidthMode = PopupWidthMode.ContentWidth;
            withBlock.TextEditStyle = textEditStyle;
        }

        public static void Initialize_RepositoryItem(RepositoryItem repositoryItem, DevExpress.XtraEditors.Controls.TextEditStyles textEditStyle)
        {
            if (repositoryItem is RepositoryItemLookUpEdit repositoryItemLookUpEdit)
            {
                var withBlock = repositoryItemLookUpEdit;
                withBlock.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                withBlock.ImmediatePopup = true;
                withBlock.PopupFilterMode = PopupFilterMode.Contains;
                withBlock.PopupWidthMode = PopupWidthMode.ContentWidth;
                withBlock.TextEditStyle = textEditStyle;
            }
            else if (repositoryItem is RepositoryItemTreeListLookUpEdit repositoryItemTreeListLookUpEdit)
            {
                var withBlock1 = repositoryItemTreeListLookUpEdit;
                withBlock1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                withBlock1.ImmediatePopup = true;
                withBlock1.PopupFilterMode = PopupFilterMode.Contains;
                withBlock1.PopupWidthMode = PopupWidthMode.ContentWidth;
                withBlock1.TextEditStyle = textEditStyle;
            }
        }

        public static void Initialize_Edit_Code(string sConnection, TextEdit textEdit, string sTable, string sCodeField, string sPreCode, string sID = "ID")
        {
            textEdit.Text = class_Database.Get_Last_ID(sConnection, sTable, sID, sCodeField, $"{sPreCode}-");
            textEdit.ReadOnly = true;
        }

        public static void Show_Data_Error(BaseEdit baseEdit, string sError, bool bShowError = true)
        {
            SystemSounds.Hand.Play();
            dx.SetError(baseEdit, sError, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
            if (bShowError)
                Set_Message(MsgMode.Errorr, sError);
            baseEdit.ForeColor = SystemColors.InfoText;
            baseEdit.BackColor = SystemColors.Info;
            baseEdit.Select();
        }

        public static bool isEmpty(BaseEdit baseEdit, bool bShowError = true)
        {
            string sError = $"{baseEdit.Name} is required but looks empty or input is not valid.{Environment.NewLine}Please input valid data to continue.";
            if (baseEdit.GetType() == typeof(TextEdit) || baseEdit.GetType() == typeof(ButtonEdit) || baseEdit.GetType() == typeof(ComboBoxEdit) || baseEdit.GetType() == typeof(MemoEdit) || baseEdit.GetType() == typeof(LookUpEdit) || baseEdit.GetType() == typeof(CalcEdit) || baseEdit.GetType() == typeof(PopupContainerEdit))
            {
                if (baseEdit.Text.Equals(null) || baseEdit.Text.Equals(string.Empty) || baseEdit.Text.Equals(0) || baseEdit.Text.Contains("Select"))
                {
                    Show_Data_Error(baseEdit, sError, bShowError);
                    return true;
                }
                else
                {
                    dx.SetError(baseEdit, string.Empty, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
                    return false;
                }
            }
            else if (baseEdit.GetType() == typeof(DateEdit))
            {
                if ((DateTime)baseEdit.EditValue > DateTime.Today)
                {
                    Show_Data_Error(baseEdit, sError, bShowError);
                    return true;
                }
                else
                {
                    dx.SetError(baseEdit, string.Empty, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
                    return false;
                }
            }

            return false;
        }

        public static bool isLength(BaseEdit baseEdit, int iMinimum)
        {
            string sError = $"{baseEdit.Name} looks valid but must be equal or more than {iMinimum} characters.{Environment.NewLine}Please input required data to continue.";
            if (baseEdit.GetType() == typeof(TextEdit) || baseEdit.GetType() == typeof(ComboBoxEdit) || baseEdit.GetType() == typeof(MemoEdit) || baseEdit.GetType() == typeof(LookUpEdit))
            {
                if (baseEdit.Text.Length < iMinimum)
                {
                    dx.SetError(baseEdit, sError, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                    Set_Message(MsgMode.Errorr, sError);
                    baseEdit.ForeColor = SystemColors.InfoText;
                    baseEdit.BackColor = SystemColors.Info;
                    baseEdit.Select();
                    return true;
                }
            }

            return false;
        }

        public static bool Show_Error(Exception ExError, string sPreMessage = "", string sPostMessage = "", string sTitle = "", bool bMessageBox = false)
        {
            if (sPreMessage.Length > 0)
                sPreMessage += Environment.NewLine;
            if (sPostMessage.Length > 0)
                sPostMessage = $"{Environment.NewLine}{sPostMessage}";
            if (ExError is System.Data.SqlClient.SqlException Ex)
            {
                class_Database.DBError = true;
                Set_Message(MsgMode.Sql, $"{sPreMessage}{Ex.ErrorCode}{Environment.NewLine}{Ex.Server}{Environment.NewLine}{Ex.Source}-{Ex.Procedure}-{Ex.LineNumber}{Environment.NewLine}{Ex.Message}{sPostMessage}", sTitle, bMessageBox);
            }
            else if (class_Variables.bStackError)
            {
                Copy_Clipboard(ExError.StackTrace, false);
                Set_Message(MsgMode.Errorr, $"{sPreMessage}{ExError.HResult}{ExError.Source}{Environment.NewLine}{ExError.Message}{Environment.NewLine}{ExError.StackTrace}{sPostMessage}", sTitle, bMessageBox);
            }
            else
            {
                Set_Message(MsgMode.Errorr, $"{sPreMessage}{ExError.HResult}{ExError.Source}{Environment.NewLine}{ExError.Message}{sPostMessage}", sTitle, bMessageBox);
            }

            return false;
        }

        public static void Set_Message(MsgMode msgMode, string sTransaction, string sTitle = "", bool bMessageBox = false)
        {
            Set_Message(frm, msgMode, sTransaction, sTitle, bMessageBox);
        }

        public static void Set_Message(XtraForm frm, MsgMode msgMode, string sTransaction, string sTitle = "", bool bMessageBox = false)
        {
            switch (msgMode)
            {
                case MsgMode.Sql:
                    {
                        class_Database.sError = sTitle;
                        if (bMessageBox)
                        {
                            MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            class_Procedures.frm.AlertControl.Show(frm, $"SQL Error {sTitle}", sTransaction, class_Procedures.frm.ImageCollection16.Images[0]);
                        }

                        break;
                    }

                case MsgMode.Info:
                    {
                        if (bMessageBox)
                        {
                            MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            class_Procedures.frm.AlertControl.Show(frm, $"Information {sTitle}", sTransaction, "Information", class_Procedures.frm.ImageCollection16.Images[1]);
                        }

                        break;
                    }

                case MsgMode.Warning:
                    {
                        if (bMessageBox)
                        {
                            MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            class_Procedures.frm.AlertControl.Show(frm, $"Warning {sTitle}", sTransaction, class_Procedures.frm.ImageCollection16.Images[2]);
                        }

                        break;
                    }

                case MsgMode.Errorr:
                    {
                        class_Database.sError = sTitle;
                        if (bMessageBox)
                        {
                            MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            class_Procedures.frm.AlertControl.Show(frm, $"Error {sTitle}", sTransaction, class_Procedures.frm.ImageCollection16.Images[3]);
                        }

                        break;
                    }

                case MsgMode.Update:
                    {
                        if (bMessageBox)
                        {
                            MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            class_Procedures.frm.AlertControl.Show(frm, $"Modified/Updated {sTitle}", $"{sTransaction} has been successfully modified/updated.", class_Procedures.frm.ImageCollection16.Images[4]);
                        }

                        break;
                    }

                case MsgMode.Save:
                    {
                        if (bMessageBox)
                        {
                            MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            class_Procedures.frm.AlertControl.Show(frm, $"Saved/Added {sTitle}", $"{sTransaction} has been successfully saved/added.", class_Procedures.frm.ImageCollection16.Images[5]);
                        }

                        break;
                    }

                case MsgMode.Delete:
                    {
                        if (bMessageBox)
                        {
                            MessageBox.Show(frm, sTransaction, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            class_Procedures.frm.AlertControl.Show(frm, $"Deleted/Removed {sTitle}", $"{sTransaction} has been successfully deleted/removed.", class_Procedures.frm.ImageCollection16.Images[6]);
                        }

                        break;
                    }
            }
        }

        public static void Loop_Stop_Message(string sTransaction, string sEvent, [Optional, DefaultParameterValue("")] ref string sTitle)
        {
            Set_Message(MsgMode.Warning, $"Some of the selected {sTransaction} has been unsuccessfully {sEvent} due to Network/Database Error or the user stopped the process.", sTitle);
        }

        public static void Copy_Clipboard(string sValue, bool bShowMessage = true)
        {
            try
            {
                Clipboard.SetDataObject(sValue, true);
            }
            catch (Exception ex)
            {
                Show_Error(ex);
            }

            if (bShowMessage)
                Set_Message(MsgMode.Info, $"{sValue} was copied into clipboard memory.");
        }

        public static void process_Command(string sCommand, string sDirectory, bool bDOS)
        {
            var process1 = new Process() { EnableRaisingEvents = false };
            if (bDOS)
            {
                Process.Start("cmd.exe", sCommand);
            }
            else
            {
                Process.Start(sCommand, sDirectory);
            }

            process1.Close();
        }

        public static void play_Sound(string sWavPath)
        {
            var sp = new SoundPlayer();
            try
            {
                sp.SoundLocation = sWavPath;
                sp.Play();
            }
            catch
            {
            }
            finally
            {
                sp.Dispose();
            }
        }

        public static void Initialize_Printing(DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            PrintingSystemBase printingSystem = (PrintingSystemBase)e.PrintingSystem;
            printingSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Legal;
            printingSystem.PageSettings.Landscape = true;
            printingSystem.PageSettings.LeftMargin = 20;
            printingSystem.PageSettings.RightMargin = 120;
            printingSystem.PageSettings.TopMargin = 20;
            printingSystem.PageSettings.BottomMargin = 20;
        }

        public static void Show_Report(XtraReport rpt, string sQuery)
        {
            rpt.DataSource = class_Database.BindToData(sQuery);
            rpt.DataMember = "customQuery";
            var reportPrintTool = new ReportPrintTool(rpt);
            reportPrintTool.ShowRibbonPreview();
        }

        public static bool actionAsk(string sTitle, string sTransaction, string sNote = "This might take more than a while", string sWarning = "You can't UNDO this Operation", string sReminder = "Please review or verify before you proceed")
        {
            var myResult = XtraMessageBox.Show($"Do you want to {sTransaction}?{Environment.NewLine}Note: {sNote}.{Environment.NewLine}Warning: {sWarning}.{Environment.NewLine}Reminder: {sReminder}.{Environment.NewLine}Then click 'YES' to continue or 'NO' to cancel.", $"Action Command: {sTitle}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Restore_Controls(BaseControl baseControl)
        {
            foreach (var item in baseControl.Controls)
            {
                if (baseControl.GetType() == typeof(BarManager))
                {
                    ((BarManager)item).RestoreLayoutFromRegistry(baseControl.Name);
                }
                else if (baseControl.GetType() == typeof(DockManager))
                {
                    ((DockManager)item).RestoreLayoutFromRegistry(baseControl.Name);
                }
            }

            foreach (BaseControl subControls in baseControl.Controls)
                Restore_Controls(subControls);
        }

        public static void Save_Controls(BaseControl control)
        {
            foreach (var item in control.Controls)
            {
                if (control.GetType() == typeof(BarManager))
                {
                    ((BarManager)item).RestoreLayoutFromRegistry(control.Name);
                }
                else if (control.GetType() == typeof(DockManager))
                {
                    ((DockManager)item).RestoreLayoutFromRegistry(control.Name);
                }
            }

            foreach (BaseControl subControls in control.Controls)
                Save_Controls(subControls);
        }

        public static void Initialize_Form(XtraForm frm, DockManager dockManager, SimpleButton BtnCancel)
        {
            Initialize_Form(frm, BtnCancel);
            dockManager.DockingOptions.ShowCloseButton = false;
            dockManager.RestoreLayoutFromRegistry(frm.Name);
        }

        public static void Initialize_Form(XtraForm frm, SimpleButton BtnCancel, Controls.Settings.xuc_Settings xucSettings)
        {
            Initialize_Form(frm, BtnCancel);
            Initialize_Xuc_Settings(frm, xucSettings);
        }

        public static void Initialize_Form(XtraForm frm, DockManager dockManager, GridView gridView, SimpleButton BtnCancel)
        {
            Initialize_Form(frm, BtnCancel);
            dockManager.DockingOptions.ShowCloseButton = false;
            dockManager.RestoreLayoutFromRegistry(frm.Name);
            Initialize_GridView(frm, gridView);
        }

        public static void Initialize_Form(XtraForm frm, BarManager barManager, GridView gridView, SimpleButton BtnCancel)
        {
            Initialize_Form(frm, BtnCancel);
            barManager.RestoreLayoutFromRegistry(frm.Name);
            Initialize_GridView(frm, gridView);
        }

        public static void Initialize_Form(XtraForm frm, DockManager dockManager, SimpleButton BtnCancel, Controls.Settings.xuc_Settings xucSettings)
        {
            Initialize_Form(frm, BtnCancel);
            Initialize_Xuc_Settings(frm, xucSettings);
            dockManager.DockingOptions.ShowCloseButton = false;
            if (xucSettings.Check_Save_Restore_Layout.Checked)
            {
                dockManager.RestoreLayoutFromRegistry(frm.Name);
            }
        }

        public static void Initialize_Form(XtraForm frm, DockManager dockManager, GridView gridView, SimpleButton BtnCancel, Controls.Settings.xuc_Settings xucSettings)
        {
            Initialize_Form(frm, BtnCancel);
            Initialize_Xuc_Settings(frm, xucSettings);
            dockManager.DockingOptions.ShowCloseButton = false;
            if (xucSettings.Check_Save_Restore_Layout.Checked)
            {
                dockManager.RestoreLayoutFromRegistry(frm.Name);
            }

            Initialize_GridView(frm, gridView, xucSettings.Check_Save_Restore_Layout.Checked);
        }

        public static void Initialize_Form(XtraForm frm, DockManager dockManager, GridView gridView, SimpleButton BtnCancel, DevExpress.XtraLayout.LayoutControl layoutControl, Controls.Settings.xuc_Settings xucSettings)
        {
            Initialize_Form(frm, BtnCancel);
            Initialize_Xuc_Settings(frm, xucSettings);
            dockManager.DockingOptions.ShowCloseButton = false;
            
            if (xucSettings.Check_Save_Restore_Layout.Checked)
            {
                dockManager.RestoreLayoutFromRegistry(frm.Name);
                layoutControl.RestoreLayoutFromRegistry(frm.Name);
            }

            Initialize_GridView(frm, gridView, xucSettings.Check_Save_Restore_Layout.Checked);
        }

        public static void Initialize_Form(XtraForm frm, DockManager dockManager, TreeList treeList, SimpleButton BtnCancel, Controls.Settings.xuc_Settings xucSettings)
        {
            Initialize_Form(frm, BtnCancel);
            Initialize_Xuc_Settings(frm, xucSettings);
            dockManager.DockingOptions.ShowCloseButton = false;
            if (xucSettings.Check_Save_Restore_Layout.Checked)
            {
                dockManager.RestoreLayoutFromRegistry(frm.Name);
            }

            Initialize_TreeList(frm, treeList, xucSettings.Check_Save_Restore_Layout.Checked);
        }

        public static void Initialize_Form(XtraForm frm, GridView gridView, SimpleButton BtnCancel)
        {
            Initialize_Form(frm, BtnCancel);
            Initialize_GridView(frm, gridView);
        }

        public static void Initialize_Form(XtraForm frm, SimpleButton BtnCancel, bool bCustomFormName = false, string sCustomFormName = "")
        {
            int iDefaultWidth;
            int iDefaultHeight;
            BtnCancel.DialogResult = DialogResult.Cancel;
            BtnCancel.Location = new Point(0, 0);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(0, 0);
            frm.StartPosition = FormStartPosition.Manual;
            frm.CancelButton = BtnCancel;
            frm.Controls.Add(BtnCancel);
            frm.Icon = class_Procedures.frm.Icon;
            switch (frm.FormBorderStyle)
            {
                case FormBorderStyle.Sizable:
                    {
                        iDefaultWidth = 800;
                        iDefaultHeight = 600;
                        break;
                    }

                default:
                    {
                        iDefaultWidth = 300;
                        iDefaultHeight = 400;
                        break;
                    }
            }

            if (bCustomFormName)
            {
                frm.Top = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_{sCustomFormName}_Top", 100);
                frm.Left = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_{sCustomFormName}_Left", 100);
                frm.Width = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_{sCustomFormName}_Width", iDefaultWidth);
                frm.Height = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_{sCustomFormName}_Height", iDefaultHeight);
            }
            else
            {
                frm.Top = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_Top", 100);
                frm.Left = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_Left", 100);
                frm.Width = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_Width", iDefaultWidth);
                frm.Height = class_Tools.RegKeyGet(frm.Name, $"{frm.Name}_Height", iDefaultHeight);
            }

            Initialize_Controls(frm);
        }

        public static void Initialize_GridView(XtraForm frm, GridView gridView, bool bRestoreLayout = true, bool bEditable = false, bool bNewRow = false)
        {
            Initialize_GridView(gridView, bEditable, bNewRow);
            if (bRestoreLayout)
            {
                gridView.RestoreLayoutFromRegistry(frm.Name);
            }
        }

        public static void Initialize_GridView(XtraUserControl xUserControl, GridView gridView, bool bEditable = false, bool bNewRow = false)
        {
            Initialize_GridView(gridView, bEditable, bNewRow);
            gridView.RestoreLayoutFromRegistry(xUserControl.Name);
        }

        public static void Initialize_GridView(GridView gridView, bool bEditable = false, bool bNewRow = false)
        {
            string[] dateList = new string[] { "Transaction", "transaction", "Added", "Modified", "Verified", "Approved", "Locked", "Deleted", "Opened", "Closed" };

            gridView.OptionsBehavior.Editable = bEditable;
            gridView.OptionsBehavior.AutoExpandAllGroups = true;
            gridView.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True;

            gridView.OptionsCustomization.CustomizationFormSearchBoxVisible = true;

            gridView.OptionsNavigation.AutoFocusNewRow = true;

            gridView.OptionsSelection.MultiSelect = true;

            gridView.OptionsView.ColumnAutoWidth = false;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.OptionsView.ShowChildrenInGroupPanel = true;
            gridView.OptionsView.ShowFooter = true;
            gridView.OptionsView.ShowGroupPanel = true;

            gridView.OptionsMenu.ShowConditionalFormattingItem = true;
            gridView.OptionsMenu.ShowGroupSummaryEditorItem = true;
            gridView.OptionsMenu.EnableFooterMenu = true;
            gridView.OptionsMenu.ShowFooterItem = true;
            gridView.OptionsLayout.StoreFormatRules = true;

            repoItemHyperLinkEdit = new RepositoryItemHyperLinkEdit();
            if (bNewRow)
            {
                gridView.OptionsNavigation.AutoFocusNewRow = true;
                gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            }

            foreach (var col in gridView.Columns)
            {
                if (col is GridColumn gridColumn)
                {
                    gridColumn.Visible = true;
                    gridColumn.AppearanceCell.Options.UseTextOptions = true;

                    if (gridColumn.DisplayFormat.FormatType.Equals(DevExpress.Utils.FormatType.Numeric))
                    {
                        gridColumn.DisplayFormat.FormatString = "{0:N2}";
                        gridColumn.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        gridColumn.GroupFormat.FormatString = "{0:N2}";
                        continue;
                    }

                    else if (gridColumn.Name.Contains("Date") | gridColumn.Name.Contains("date") | gridColumn.Name.Contains("Day") | gridColumn.Name.Contains("day"))
                    {
                        if (gridColumn.Name.Contains("Days"))
                            continue;
                        else
                        {
                            foreach (var name in dateList)
                            {
                                if (gridColumn.Name.Contains(name))
                                {
                                    gridColumn.DisplayFormat.FormatString = "MMMM dd, yyyy HH:mm:ss";
                                    break;
                                }
                                else
                                {
                                    gridColumn.OptionsColumn.AllowEdit = false;
                                    gridColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                                    gridColumn.DisplayFormat.FormatString = "MMMM dd, yyyy";
                                    gridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                                    gridColumn.GroupFormat.FormatString = "MMMM dd, yyyy";
                                    gridColumn.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                                }
                                continue;
                            }
                        }
                    }

                    else if (gridColumn.FieldName.EndsWith("ID") | gridColumn.FieldName.Contains("Code") | gridColumn.FieldName.Contains("Reference") | gridColumn.FieldName.Contains("Number") | gridColumn.FieldName.Contains("Engine") | gridColumn.FieldName.Contains("Chassis") | gridColumn.FieldName.Contains("Mobile") | gridColumn.FieldName.Contains("Debit") | gridColumn.FieldName.Contains("Credit") | gridColumn.FieldName.EndsWith("Approver") | gridColumn.FieldName.EndsWith("By"))
                    {
                        if (gridColumn.OptionsColumn.AllowEdit)
                            continue;

                        if (gridColumn.FieldName.Contains("Branch"))
                            continue;

                        else if (gridColumn.ColumnEdit is null)
                        {
                            gridColumn.ColumnEdit = repoItemHyperLinkEdit;
                            continue;
                        }
                    }
                }
            }
        }

        public static void Initialize_TreeList(XtraForm frm, TreeList treeList, bool bRestoreLayout = true)
        {
            if (bRestoreLayout)
            {
                treeList.RestoreLayoutFromRegistry(frm.Name);
            }
        }

        public static void Initialize_TreeList(TreeList treeList, string sParentFieldName, string sKeyFieldName)
        {
            treeList.KeyFieldName = sKeyFieldName;
            treeList.OptionsBehavior.AllowExpandOnDblClick = true;
            treeList.OptionsBehavior.Editable = false;
            treeList.OptionsMenu.ShowConditionalFormattingItem = true;
            treeList.OptionsMenu.ShowExpandCollapseItems = false;
            treeList.OptionsMenu.ShowFooterItem = true;
            treeList.OptionsPrint.PrintRowFooterSummary = true;
            treeList.OptionsSelection.MultiSelect = true;
            treeList.OptionsView.AutoWidth = false;
            treeList.OptionsView.ShowIndentAsRowStyle = true;
            treeList.OptionsView.ShowRowFooterSummary = true;
            treeList.OptionsView.ShowSummaryFooter = true;
            treeList.ParentFieldName = sParentFieldName;
            foreach (var col in treeList.Columns)
            {
                if (col.GetType() == typeof(TreeListColumn))
                {
                    if (col.FieldName.EndsWith("Code") | col.FieldName.EndsWith("Debit") | col.FieldName.EndsWith("Credit") | col.FieldName.EndsWith("By"))
                    {
                        if (col.ColumnEdit is null)
                        {
                            col.ColumnEdit = repoItemHyperLinkEdit;
                            continue;
                        }
                    }
                    else if (col.Format.FormatType == DevExpress.Utils.FormatType.Numeric)
                    {
                        col.AllNodesSummary = true;
                        col.Format.FormatString = "{0:N2}";
                        col.RowFooterSummary = SummaryItemType.Sum;
                        col.RowFooterSummaryStrFormat = "Sub-Total {0:N2}";
                        col.SummaryFooter = SummaryItemType.Sum;
                        col.SummaryFooterStrFormat = "Total {0:N2}";
                    }
                    else if (col.FieldName.Contains("Date"))
                    {
                        col.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                        col.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
                        col.Format.FormatString = "MMMM dd, yyyy";
                    }
                }
            }
        }

        public static void Initialize_Xuc_Settings(XtraForm frm, Controls.Settings.xuc_Settings xucSettings)
        {
            xucSettings.Check_Load_All.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Load_All.Name, false);
            xucSettings.Check_Auto_Show.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Auto_Show.Name, true);
            xucSettings.Check_Auto_Reload.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Auto_Reload.Name, false);
            xucSettings.Check_Live_Looping.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Live_Looping.Name, true);
            xucSettings.Check_Clear_Selection.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Clear_Selection.Name, false);
            xucSettings.Check_Auto_Initialize.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Auto_Initialize.Name, true);
            xucSettings.Check_Clear_New.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Clear_New.Name, false);
            xucSettings.Check_Clear_Save_Delete.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Clear_Save_Delete.Name, false);
            xucSettings.Check_Save_Restore_Layout.Checked = class_Tools.RegKeyGet(frm.Name, xucSettings.Check_Save_Restore_Layout.Name, true);
            xucSettings.MemoEdit_Notes.Text = class_Tools.RegKeyGet(frm.Name, xucSettings.MemoEdit_Notes.Name, string.Empty);
        }

        public static void Save_Xuc_Settings(XtraForm frm, Controls.Settings.xuc_Settings xucSettings)
        {
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Load_All.Name, xucSettings.Check_Load_All.Checked);
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Auto_Show.Name, xucSettings.Check_Auto_Show.Checked);
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Auto_Reload.Name, xucSettings.Check_Auto_Reload.Checked);
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Live_Looping.Name, xucSettings.Check_Live_Looping.Checked);
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Clear_Selection.Name, xucSettings.Check_Clear_Selection.Checked);
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Auto_Initialize.Name, xucSettings.Check_Auto_Initialize.Checked);
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Clear_New.Name, xucSettings.Check_Clear_New.Checked);
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Clear_Save_Delete.Name, xucSettings.Check_Clear_Save_Delete.Checked);
            class_Tools.RegKeySet(frm.Name, xucSettings.Check_Save_Restore_Layout.Name, xucSettings.Check_Save_Restore_Layout.Checked);
            class_Tools.RegKeySet(frm.Name, xucSettings.MemoEdit_Notes.Name, xucSettings.MemoEdit_Notes.Text);
        }

        public static void Get_Skin()
        {
            try
            {
                string sDefaultSkin = class_Tools.RegKeyGet(class_Database.SqlServer, "Skin", "Basic");
                switch (sDefaultSkin ?? string.Empty)
                {
                    case "Basic":
                    case "The Bezier":
                    case "Office 2019 Colorful":
                        {
                            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(sDefaultSkin, class_Tools.RegKeyGet(class_Database.SqlServer, "Palette", "Default"));
                            break;
                        }

                    default:
                        {
                            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(sDefaultSkin);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Show_Error(ex);
            }
        }

        public static void Set_Skin()
        {
            try
            {
                class_Tools.RegKeySet(class_Database.SqlServer, "Skin", DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName);
                switch (DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName ?? string.Empty)
                {
                    case "Basic":
                    case "The Bezier":
                    case "Office 2019 Colorful":
                        {
                            class_Tools.RegKeySet(class_Database.SqlServer, "Palette", DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSvgPaletteName);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Show_Error(ex);
            }
        }

        public static void Show_Form(XtraForm frm, string sDescription)
        {
            splash_Show(frm, sDescription, bForceShow: true, xMode: xFormMode.xForm);
            try
            {
                frm.Text = sDescription;
                frm.Icon = frm.Icon;
                frm.Show();
            }
            catch (Exception ex)
            {
                Show_Error(ex);
            }

            splash_Close(true);
        }

        public static void Show_Form(DevExpress.XtraBars.Ribbon.RibbonForm mdiForm, XtraForm frm, string sDescription, bool bChild = true)
        {
            splash_Show(sDescription, bForceShow: true, xMode: xFormMode.xForm);
            try
            {
                if (bChild)
                    frm.MdiParent = mdiForm;
                frm.Text = sDescription;
                frm.Icon = mdiForm.Icon;
                frm.Show();
            }
            catch (Exception ex)
            {
                Show_Error(ex);
            }

            splash_Close(true);
        }

        public static void Show_Form(DevExpress.XtraBars.Ribbon.RibbonForm mdiForm, Form frm, string sDescription, bool bChild = true)
        {
            splash_Show(sDescription, bForceShow: true, xMode: xFormMode.xForm);
            try
            {
                if (bChild)
                    frm.MdiParent = mdiForm;
                frm.Text = sDescription;
                frm.Icon = mdiForm.Icon;
                frm.Show();
            }
            catch (Exception ex)
            {
                Show_Error(ex);
            }

            splash_Close(true);
        }

        private static void Form_Dispose(XtraForm frm, bool bCustomFormName = false, string sCustomFormName = "")
        {
            splash_Show($"closing {frm.Name}", "Closing Form");
            if (frm.WindowState.Equals(FormWindowState.Normal))
            {
                if (bCustomFormName)
                {
                    class_Tools.RegKeySet($"{frm.Name}_{sCustomFormName}", "Top", frm.Top);
                    class_Tools.RegKeySet($"{frm.Name}_{sCustomFormName}", "Left", frm.Left);
                    class_Tools.RegKeySet($"{frm.Name}_{sCustomFormName}", "Width", frm.Width);
                    class_Tools.RegKeySet($"{frm.Name}_{sCustomFormName}", "Height", frm.Height);
                }
                else
                {
                    class_Tools.RegKeySet(frm.Name, $"{frm.Name}_Top", frm.Top);
                    class_Tools.RegKeySet(frm.Name, $"{frm.Name}_Left", frm.Left);
                    class_Tools.RegKeySet(frm.Name, $"{frm.Name}_Width", frm.Width);
                    class_Tools.RegKeySet(frm.Name, $"{frm.Name}_Height", frm.Height);
                }
            }

            frm.Dispose();
            frm.Close();
            splash_Close();
        }

        public static bool Form_Close(XtraForm frm, BarManager barManager, DockManager dockManager, bool bAsk = false)
        {
            barManager.SaveLayoutToRegistry(frm.Name);
            dockManager.SaveLayoutToRegistry(frm.Name);
            return Form_Close(frm, bAsk);
        }

        public static bool Form_Close(XtraForm frm, BarManager barManager, GridView gridview, bool bAsk = false)
        {
            barManager.SaveLayoutToRegistry(frm.Name);
            gridview.SaveLayoutToRegistry(frm.Name);
            return Form_Close(frm, bAsk);
        }

        public static bool Form_Close(XtraForm frm, GridView gridview, bool bAsk = false)
        {
            gridview.SaveLayoutToRegistry(frm.Name);
            return Form_Close(frm, bAsk);
        }

        public static bool Form_Close(XtraForm frm, BarManager barManager, DockManager dockManager, GridView gridview, bool bAsk = false)
        {
            barManager.SaveLayoutToRegistry(frm.Name);
            dockManager.SaveLayoutToRegistry(frm.Name);
            gridview.SaveLayoutToRegistry(frm.Name);
            return Form_Close(frm, bAsk);
        }

        public static bool Form_Close(XtraForm frm, BarManager barManager, DockManager dockManager, Controls.Settings.xuc_Settings xucSettings, bool bAsk = false)
        {
            if (xucSettings.Check_Save_Restore_Layout.Checked)
            {
                barManager.SaveLayoutToRegistry(frm.Name);
                dockManager.SaveLayoutToRegistry(frm.Name);
            }

            Save_Xuc_Settings(frm, xucSettings);
            return Form_Close(frm, bAsk);
        }

        public static bool Form_Close(XtraForm frm, BarManager barManager, bool bAsk = false, bool bCustomFormName = false, string sCustomFormName = "")
        {
            try
            {
                barManager.SaveLayoutToRegistry(frm.Name);
            }
            catch (Exception ex)
            {
                Show_Error(ex);
            }

            return Form_Close(frm, bAsk, bCustomFormName, sCustomFormName);
        }

        public static bool Form_Close(XtraForm frm, BarManager barManager, DockManager dockManager, GridView gridview, Controls.Settings.xuc_Settings xucSettings, bool bAsk = false)
        {
            if (xucSettings.Check_Save_Restore_Layout.Checked)
            {
                barManager.SaveLayoutToRegistry(frm.Name);
                dockManager.SaveLayoutToRegistry(frm.Name);
                gridview.SaveLayoutToRegistry(frm.Name);
            }

            Save_Xuc_Settings(frm, xucSettings);
            return Form_Close(frm, bAsk);
        }

        public static bool Form_Close(XtraForm frm, BarManager barManager, DockManager dockManager, GridView gridview, DevExpress.XtraLayout.LayoutControl layoutControl, Controls.Settings.xuc_Settings xucSettings, bool bAsk = false)
        {
            if (xucSettings.Check_Save_Restore_Layout.Checked)
            {
                barManager.SaveLayoutToRegistry(frm.Name);
                dockManager.SaveLayoutToRegistry(frm.Name);
                gridview.SaveLayoutToRegistry(frm.Name);
                layoutControl.SaveLayoutToRegistry(frm.Name);
            }

            Save_Xuc_Settings(frm, xucSettings);
            return Form_Close(frm, bAsk);
        }

        public static bool Form_Close(XtraForm frm, BarManager barManager, DockManager dockManager, TreeList treeList, Controls.Settings.xuc_Settings xucSettings, bool bAsk = false)
        {
            if (xucSettings.Check_Save_Restore_Layout.Checked)
            {
                barManager.SaveLayoutToRegistry(frm.Name);
                dockManager.SaveLayoutToRegistry(frm.Name);
                treeList.SaveLayoutToRegistry(frm.Name);
            }

            Save_Xuc_Settings(frm, xucSettings);
            return Form_Close(frm, bAsk);
        }

        public static bool Form_Close(XtraForm frm, bool bAsk = false, bool bCustomFormName = false, string sCustomFormName = "")
        {
            if (bAsk)
            {
                if (Environment.OSVersion.Version.Major.Equals(10))
                {
                    var action = new FlyoutAction() { Caption = "Confirm", Description = $"Close {frm.Name}-[{frm.Text}]?" };
                    var command1 = new FlyoutCommand() { Text = "Close", Result = DialogResult.Yes };
                    var command2 = new FlyoutCommand() { Text = "Cancel", Result = DialogResult.No };
                    action.Commands.Add(command1);
                    action.Commands.Add(command2);
                    var properties = new FlyoutProperties() { ButtonSize = new Size(100, 40), Style = FlyoutStyle.MessageBox };
                    if (FlyoutDialog.Show(frm, action, properties) == DialogResult.Yes)
                    {
                        Form_Dispose(frm);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (actionAsk($"Close {frm.Name}", $"Close this {frm.Text}", "You might lose unsaved data."))
                {
                    Form_Dispose(frm, bCustomFormName, sCustomFormName);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Form_Dispose(frm, bCustomFormName, sCustomFormName);
            }

            return false;
        }
    }
}