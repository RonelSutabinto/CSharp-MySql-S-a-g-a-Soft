Imports System.Windows.Forms
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Namespace Forms.Accounting
    Public Class wzFrm_Cash_Check_Voucher
        Private sAccountCode As String = String.Empty
        Private sVoucherType As class_Saga_Variables.eVoucherType

        Public Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, xuc_Voucher.layoutControl, BtnCancel)
        End Sub

        Private Function Form_Close() As Boolean
            class_Tools.RegKeySet(Me.Name, Voucher_Type.Name, Voucher_Type.Text)
            class_Tools.RegKeySet(Me.Name, Branch_Code.Name, Branch_Code.EditValue)
            class_Tools.RegKeySet(Me.Name, Voucher_Approver.Name, Voucher_Approver.Text.Trim)
            class_Tools.RegKeySet(Me.Name, Journal_Profile.Name, Journal_Profile.Text.Trim)
            class_Tools.RegKeySet(Me.Name, Voucher_Description.Name, Voucher_Description.Text.Trim)

            Return class_Procedures.Form_Close(Me, True)
        End Function

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub WizardControl_CancelClick(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WizardControl.CancelClick
            Form_Close()
        End Sub

        Private Sub WizardControl_FinishClick(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WizardControl.FinishClick
            Form_Close()
        End Sub

        Private Sub frm_Purchase_Orders_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub wzFrm_Cash_Check_Voucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub wzFrm_Cash_Check_Voucher_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            Xuc_Voucher.Control_Initialize()

            Posting_Date.EditValue = Date.Today

            class_Saga_Procedures.Initialize_Voucher_Type(Voucher_Type)
            class_Saga_Procedures.Initialize_Branch(Branch_Code)

            class_Database.Fill_Edit(class_Database.ICSConnection, Voucher_Approver, "acc_Vouchers", "Voucher_Approver")
            class_Database.Fill_Edit(class_Database.ICSConnection, Journal_Profile, "acc_Vouchers", "Voucher_Profile")

            class_Saga_Procedures.Initialize_COA(COA_Code, eCOA_Type.COA_Bank)

            Voucher_Type.Text = class_Tools.RegKeyGet(Me.Name, Voucher_Type.Name, String.Empty)
            Branch_Code.EditValue = class_Tools.RegKeyGet(Me.Name, Branch_Code.Name, "000")
            Voucher_Approver.Text = class_Tools.RegKeyGet(Me.Name, Voucher_Approver.Name, String.Empty)
            Journal_Profile.Text = class_Tools.RegKeyGet(Me.Name, Journal_Profile.Name, String.Empty)
            Voucher_Description.Text = class_Tools.RegKeyGet(Me.Name, Voucher_Description.Name, String.Empty)

            Toggle_LTO.ReadOnly = True
        End Sub

        Private Sub WizardPage_Voucher_Type_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Voucher_Type.PageValidating
            e.Valid = Not class_Procedures.isEmpty(Voucher_Type)

            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please select Voucher Type to continue."
            Else
                Select Case Voucher_Type.Text
                    Case "CASH_CHECK"
                        sVoucherType = eVoucherType.Check

                    Case "JOURNAL"
                        sVoucherType = eVoucherType.Journal
                End Select
            End If
        End Sub

        Private Sub WizardPage_Branch_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Branch.PageValidating
            e.Valid = Not class_Procedures.isEmpty(Branch_Code)

            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please select Branch to continue."
            Else
                With Xuc_Voucher
                    .Voucher_Branch.EditValue = Branch_Code.EditValue
                    .Control_New(False, sVoucherType, Branch_Code.EditValue)
                End With
            End If
        End Sub

        Private Sub WizardPage_Posting_Date_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Posting_Date.PageValidating
            e.Valid = Not class_Procedures.isEmpty(Posting_Date)

            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please input Posting Date to continue."
            Else
                Xuc_Voucher.Voucher_Date_Posted.EditValue = Posting_Date.EditValue
            End If
        End Sub

        Private Sub Get_Searched_Name()
            sAccountCode = xuc_Account_Search.Code
            Account_Name.Text = xuc_Account_Search.AccountName
            Account_Name.Select()
        End Sub

        Private Sub Voucher_Name_BeforePopup(sender As Object, e As EventArgs) Handles Account_Name.BeforePopup
            PopupContainerControl.Width = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl}_Width", 500)
            PopupContainerControl.Height = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl}_Height", 400)
        End Sub

        Private Sub Account_Name_Popup(sender As Object, e As EventArgs) Handles Account_Name.Popup
            xuc_Account_Search.searchMode = SagaClassLibrary.Controls.Information.Account.xuc_Account_Search.Search_Mode.searchAccounts
            xuc_Account_Search.Load_Search(Account_Name.Text.Trim)
        End Sub

        Private Sub Account_Name_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles Account_Name.Closed
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Width", PopupContainerControl.Width)
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Height", PopupContainerControl.Height)

            Get_Searched_Name()
        End Sub

        Private Sub WizardPage_Account_Name_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Account_Name.PageValidating
            e.Valid = Not class_Procedures.isEmpty(Account_Name)

            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please input Account Name to continue."
            Else
                With Xuc_Voucher
                    .Account_Code.Text = sAccountCode
                    .Account_Name.Text = Account_Name.Text
                End With
            End If
        End Sub

        Private Sub WizardPage_Approver_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Approver.PageValidating
            e.Valid = Not class_Procedures.isEmpty(Voucher_Approver)

            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please input Approver to continue."
            Else
                Xuc_Voucher.Voucher_Approver.Text = Voucher_Approver.Text.Trim()
            End If
        End Sub

        Private Sub WizardPage_Profile_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Profile.PageValidating
            e.Valid = Not class_Procedures.isEmpty(Journal_Profile)

            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please input Voucher Profile to continue."
            Else
                Xuc_Voucher.Voucher_Profile.Text = Journal_Profile.Text.Trim()
            End If
        End Sub

        Private Sub WizardPage_Description_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Description.PageValidating
            e.Valid = Not class_Procedures.isEmpty(Voucher_Description)

            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please input Voucher Description to continue."
            Else
                Xuc_Voucher.Voucher_Description.Text = Voucher_Description.Text.Trim()
            End If
        End Sub

        Private Sub COA_Code_Validated(sender As Object, e As EventArgs) Handles COA_Code.Validated
            Xuc_Voucher.Load_Checks(Voucher_Check, COA_Code.EditValue, "NOT_ISSUED")
        End Sub

        Private Sub WizardPage_Bank_Check_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Bank_Check.PageValidating
            Xuc_Voucher.COA_Code.EditValue = COA_Code.EditValue
            Xuc_Voucher.Set_Check_Token(Voucher_Check.EditValue)
        End Sub

        Private Sub Toggle_Cash_Advance_Toggled(sender As Object, e As EventArgs) Handles Toggle_Cash_Advance.Toggled
            Toggle_LTO.ReadOnly = Not Toggle_Cash_Advance.IsOn
        End Sub

        Private Sub WizardPage_Cash_Advance_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Cash_Advance.PageValidating
            With Xuc_Voucher
                .IsForLiquidation.IsOn = Toggle_Cash_Advance.IsOn
                .IsLTO.IsOn = Toggle_LTO.IsOn
            End With
        End Sub

        Private Sub WizardPage_Voucher_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Voucher.PageValidating
            With Xuc_Voucher
                If .control_Save(sVoucherType) Then
                    Dim iTableID As Integer = Convert.ToInt32(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT ID, Voucher_Reference FROM acc_Vouchers WHERE Voucher_Reference LIKE '{ .Voucher_Reference.EditValue}'", "ID"))
                    Dim sReference As String = .Voucher_Reference.Text
                    Dim sBrCode As String = .Voucher_Branch.EditValue
                    Dim sProfile As String = .Voucher_Profile.Text
                    Dim sAccountCode As String = xuc_Account_Search.Code
                    Dim sAccountName As String = .Account_Name.Text.Trim
                    Dim dtPosted As Date = .Voucher_Date_Posted.EditValue
                    Dim sApprover As String = .Voucher_Approver.Text.Trim
                    Dim sDescription As String = .Voucher_Description.Text.Trim
                    Dim bCashAdvance As Boolean = .IsForLiquidation.IsOn
                    Dim bLTO As Boolean = .IsLTO.IsOn

                    Dim sCOACode As String = String.Empty
                    Try
                        sCOACode = .COA_Code.EditValue
                    Catch ex As Exception

                    End Try

                    Dim sCheck As String = String.Empty
                    Try
                        sCheck = .Voucher_Check.EditValue
                    Catch ex As Exception

                    End Try
                    class_Saga_Procedures.Show_Journal_Entries_Reference(0, iTableID, sReference, sBrCode, "CASH_CHECK", sProfile, sAccountCode, sAccountName, dtPosted, sApprover, sCOACode, sCheck, sDescription, bCashAdvance, bLTO)

                    e.Valid = True
                Else
                    e.Valid = False
                End If

                If Not e.Valid Then
                    e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                    e.ErrorText = "Please input valid Voucher Information to continue."
                End If
            End With
        End Sub
    End Class
End Namespace