Imports MyClassLibrary.Classes

Namespace Forms.Persons

    Public Class frm_User_Activities

        Public Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, gridView, BtnCancel)

        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_User_Activities_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load

        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, gridView)
        End Function

        Private Sub frm_User_Activities_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Friend Sub Data_Load(ByVal sUserName As String)
            Dim sQuery, sQueryLogin, sQueryInventory, sQueryApplications, sQueryReleases, sQueryPayments, sQueryInterBranch As String

            sQueryLogin = $"SELECT 0 as ID, 'User Login' as TransactionType, username as TransactedBy, Last_Login as TransactionDate, 'IP: ' + IP_Address as Code, 'System user logged-in using IP: ' + IP_Address as Note FROM users WHERE username LIKE '{sUserName}'"
            sQueryInventory = $"SELECT ID, 'Item Inventory' as TransactionType, transactedby as TransactedBy, transactiondate as TransactionDate, EngineNo as Code, CONVERT(nvarchar(4), whCode) + ' Chassis:' + CONVERT(nvarchar(20), ChassisNo) + ' Model: ' + CONVERT(nvarchar(max), description) as Note FROM item_Details WHERE TransactedBy LIKE '{sUserName}'"
            sQueryApplications = $"SELECT ID, 'Customer Application' as TransactionType, TransactedBy, DateOutApprover as TransactionDate, CONVERT(nvarchar(20), AccountNumber) + '-' + CONVERT(nvarchar(1), LedgerSetNumber) as Code, AccountName + ' was applying for ' + ' Engine: ' + EngineNo + ' Chassis: ' + ChassisNo + ' Model: ' + Model as Note FROM CustAccountApplications WHERE TransactedBy LIKE '{sUserName}'"
            sQueryReleases = $"SELECT ID, 'Customer Releases' as TransactionType, transactedby as TransactedBy, TransactionDate, CONVERT(nvarchar(20), AccountNumber) + '-' + CONVERT(nvarchar(1), LedgerSetNumber) as Code, 'Engine:' + CONVERT(nvarchar(20), EngineNo) + ' Chassis:' + CONVERT(nvarchar(20), ChassisNo) + ' Model:' + CONVERT(nvarchar(40), model) as Note FROM TransactionReleases WHERE TransactedBy LIKE '{sUserName}'"
            sQueryPayments = $"SELECT ID, 'Customer Payment' as TransactionType, TransactedBy, TransactionDate, CONVERT(nvarchar(20), AccountNumber) + '-' + CONVERT(nvarchar(1), LedgerSetNumber) as Code, 'OR Code: ' + CONVERT(nvarchar(10), ORNumber) + ' Amount Paid: Php ' + CONVERT(nvarchar(10), AmountPaid) + ' ' + Note as Note From TransactionPayments WHERE TransactedBy LIKE '{sUserName}'"
            sQueryInterBranch = $"SELECT ID, 'Inter-Branch Payment' as TransactionType, TransactedBy, TransactionDate, 'CIF: ' + CIFNo as Code, 'OR Code: ' + CONVERT(nvarchar(10), ORNumber) + ' ' + 'Customer Name: ' + AccountName + ' Amount Paid: Php ' + CONVERT(nvarchar(10), AmountDue) + ' ' + Description as Note FROM TransactionOtherCash WHERE TransactedBy LIKE '{sUserName}'"

            sQuery = $"SELECT TOP 200 * FROM ({sQueryLogin} UNION ALL {sQueryInventory} UNION ALL {sQueryApplications} UNION ALL {sQueryReleases} UNION ALL {sQueryPayments} UNION ALL {sQueryInterBranch}) AS Query ORDER BY Query.TransactionDate DESC"

            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, sQuery)

            Try
                With gridView
                    .Columns("ID").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                    .Columns("TransactionDate").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
                    .Columns("TransactionDate").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    .Columns("TransactionDate").DisplayFormat.FormatString = "MMM dd, yyyy hh:mm:ss"
                End With
            Catch ex As Exception
            Finally
                gridView.BestFitColumns()
            End Try
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If gridView.DataRowCount > 0 AndAlso e.Clicks.Equals(2) Then
                If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)
            End If
        End Sub

    End Class

End Namespace