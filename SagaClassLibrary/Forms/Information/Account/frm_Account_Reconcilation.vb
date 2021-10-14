Imports MyClassLibrary.Classes

Public Class frm_Account_Reconciliation
    Friend sBrCode, sAccount, sLedger As String

    Public Sub New()
        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, BtnCancel)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_Account_Reconciliation_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        Posting_Date.EditValue = class_Tools.RegKeyGet(Me.Name, Posting_Date.Name, Date.Today.ToString("MMM dd, yyyy"))
    End Sub

    Private Function Form_Close() As Boolean
        class_Tools.RegKeySet(Me.Name, Posting_Date.Name, Posting_Date.EditValue.ToString)

        Return class_Procedures.Form_Close(Me)
    End Function

    Private Sub frm_Account_Reconciliation_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub Posting_Date_EditValueChanged(sender As Object, e As System.EventArgs) Handles Posting_Date.EditValueChanged
        Account_Reconcile(convert.todatetime(Posting_Date.EditValue))
    End Sub

    Friend Sub Account_Reconcile(ByVal dt As Date)
        Try
            Expected_Months.Text = $"{class_Functions.GetMonthDifference(convert.todatetime(First_Payment.Text), dt) + 1}" '/{Terms.Text}"

            Minus_Principal.Text = (convert.todecimal(Expected_Months.Text) * convert.todecimal(Principal.Text)).ToString("{0:N2}")
            Minus_Interest.Text = (convert.todecimal(Expected_Months.Text) * convert.todecimal(Interest.Text)).ToString("{0:N2}")
            Minus_Oustanding.Text = (convert.todecimal(Expected_Months.Text) * convert.todecimal(Amortization.Text)).ToString("{0:N2}")

            Sub_Principal.Text = (convert.todecimal(Release_Principal.Text) - convert.todecimal(Minus_Principal.Text)).ToString("{0:N2}")
            Sub_Interest.Text = (convert.todecimal(Release_Interest.Text) - convert.todecimal(Minus_Interest.Text)).ToString("{0:N2}")
            Sub_Outstanding.Text = (convert.todecimal(Release_Outstanding.Text) - convert.todecimal(Minus_Oustanding.Text)).ToString("{0:N2}")

            Paid_Months.Text = $"{class_Functions.GetMonthDifference(convert.todatetime(First_Payment.Text), dt) + 1}" '/{Terms.Text}"



            Dim dInitialPrincipal, dInitialInterest As Decimal

            dInitialPrincipal = convert.todecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT BranchCode, AccountNumber, LedgerSetNumber, LedgerType, Debit FROM CustLedger WHERE BranchCode LIKE '{sBrCode}' AND AccountNumber LIKE '{sAccount}' AND LedgerSetNumber LIKE '{sLedger}' AND LedgerType LIKE 'PRIN' AND Mnemonic LIKE 'FBAL'", "Debit"))
            dInitialInterest = convert.todecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT BranchCode, AccountNumber, LedgerSetNumber, LedgerType, Debit FROM CustLedger WHERE BranchCode LIKE '{sBrCode}' AND AccountNumber LIKE '{sAccount}' AND LedgerSetNumber LIKE '{sLedger}' AND LedgerType LIKE 'INT' AND Mnemonic LIKE 'FBAL'", "Debit"))

            Initial_Collection_Principal.Text = (convert.todecimal(Release_Principal.Text) - dInitialPrincipal).ToString("{0:N2}")
            Initial_Collection_Interest.Text = (convert.todecimal(Release_Interest.Text) - dInitialInterest).ToString("{0:N2}")
            Initial_Collection_Total.Text = (convert.todecimal(Initial_Collection_Principal.Text) + convert.todecimal(Initial_Collection_Interest.Text)).ToString("{0:N2}")

            Actual_Collection_Principal.Text = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT SUM(Credit) AS Credit FROM CustLedger WHERE BranchCode LIKE '{sBrCode}' AND AccountNumber LIKE '{sAccount}' AND LedgerSetNumber LIKE '{sLedger}' AND ErrorCorrectTag LIKE '0' AND LedgerType LIKE 'PRIN' AND PostingDate <= CONVERT(VARCHAR(10), '{dt}', 23) GROUP BY LedgerType", "Credit").ToString("{0:N2}")
            Actual_Collection_Interest.Text = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT SUM(Credit) AS Credit FROM CustLedger WHERE BranchCode LIKE '{sBrCode}' AND AccountNumber LIKE '{sAccount}' AND LedgerSetNumber LIKE '{sLedger}' AND ErrorCorrectTag LIKE '0' AND LedgerType LIKE 'INT' AND PostingDate <= CONVERT(VARCHAR(10), '{dt}', 23) GROUP BY LedgerType", "Credit").ToString("{0:N2}")
            Actual_Collection_Total.Text = (convert.todecimal(Actual_Collection_Principal.Text) + convert.todecimal(Actual_Collection_Interest.Text)).ToString("{0:N2}")

            Account_Principal.Text = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, AccountNumber, LedgerSetNumber, LedgerType, ErrorCorrectTag, EndingBalance FROM CustLedger WHERE BranchCode LIKE '{sBrCode}' AND AccountNumber LIKE '{sAccount}' AND LedgerSetNumber LIKE '{sLedger}' AND ErrorCorrectTag LIKE '0' AND LedgerType LIKE 'PRIN' AND PostingDate <= CONVERT(VARCHAR(10), '{dt}', 23) ORDER BY SequenceNumber DESC", "EndingBalance").ToString("{0:N2}")
            Account_Interest.Text = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT TOP 1 BranchCode, AccountNumber, LedgerSetNumber, LedgerType, ErrorCorrectTag, EndingBalance FROM CustLedger WHERE BranchCode LIKE '{sBrCode}' AND AccountNumber LIKE '{sAccount}' AND LedgerSetNumber LIKE '{sLedger}' AND ErrorCorrectTag LIKE '0' AND LedgerType LIKE 'INT' AND PostingDate <= CONVERT(VARCHAR(10), '{dt}', 23) ORDER BY SequenceNumber DESC", "EndingBalance").ToString("{0:N2}")
            Account_Outstanding.Text = (convert.todecimal(Account_Principal.Text) + convert.todecimal(Account_Interest.Text)).ToString("{0:N2}")

            Total_Collection_Principal.Text = (convert.todecimal(Initial_Collection_Principal.Text) + convert.todecimal(Actual_Collection_Principal.Text)).ToString("{0:N2}")
            Total_Collection_Interest.Text = (convert.todecimal(Initial_Collection_Interest.Text) + convert.todecimal(Actual_Collection_Interest.Text)).ToString("{0:N2}")

            If convert.todecimal(Total_Collection_Principal.Text) < 0 Then Total_Collection_Principal.Text = "0.00"
            If convert.todecimal(Total_Collection_Interest.Text) < 0 Then Total_Collection_Interest.Text = "0.00"
            Total_Collection.Text = (convert.todecimal(Total_Collection_Principal.Text) + convert.todecimal(Total_Collection_Interest.Text)).ToString("{0:N2}")

            Account_Overdue_Principal.Text = (convert.todecimal(Account_Principal.Text) - convert.todecimal(Sub_Principal.Text)).ToString("{0:N2}")
            Account_Overdue_Interest.Text = (convert.todecimal(Account_Interest.Text) - convert.todecimal(Sub_Interest.Text)).ToString("{0:N2}")
            If convert.todecimal(Account_Overdue_Principal.Text) < 0 Then Account_Overdue_Principal.Text = "0.00"
            If convert.todecimal(Account_Overdue_Interest.Text) < 0 Then Account_Overdue_Interest.Text = "0.00"
            Account_Overdue_Total.Text = (convert.todecimal(Account_Overdue_Principal.Text) + convert.todecimal(Account_Overdue_Interest.Text)).ToString("{0:N2}")

            Account_Advance_Principal.Text = (convert.todecimal(Sub_Principal.Text) - convert.todecimal(Account_Principal.Text)).ToString("{0:N2}")
            Account_Advance_Interest.Text = (convert.todecimal(Sub_Interest.Text) - convert.todecimal(Account_Interest.Text)).ToString("{0:N2}")
            If convert.todecimal(Account_Advance_Principal.Text) < 0 Then Account_Advance_Principal.Text = "0.00"
            If convert.todecimal(Account_Advance_Interest.Text) < 0 Then Account_Advance_Interest.Text = "0.00"
            Account_Advance_Total.Text = (convert.todecimal(Account_Advance_Principal.Text) + convert.todecimal(Account_Advance_Interest.Text)).ToString("{0:N2}")
        Catch ex As Exception

        End Try
    End Sub

End Class