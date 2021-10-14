Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Public Class Xuc_Sales
    Public Sub New()
        InitializeComponent()
    End Sub
    Friend Sub Control_Initialize()
        Initialize_Tran_Category("SALES")
        Initialize_Tran_Category(Transaction_Category)
        Transaction_Category.Select()
        Posting_Date.EditValue = Date.Now()
    End Sub

    Private Sub Get_Searched_Name()
        Customer_Name.Text = Xuc_Account_Search.AccountName
        Address.Text = Xuc_Account_Search.Others
        Customer_Name.Select()
    End Sub
    Private Sub Customer_Name_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles Customer_Name.Closed
        class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Width", PopupContainerControl.Width)
        class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Height", PopupContainerControl.Height)
        Get_Searched_Name()
    End Sub
    Private Sub Customer_Name_Popup(sender As Object, e As EventArgs) Handles Customer_Name.Popup
        Xuc_Account_Search.Load_Search(Customer_Name.Text.Trim)
    End Sub

    Private Sub Transaction_Category_EditValueChanged(sender As Object, e As EventArgs) Handles Transaction_Category.EditValueChanged
        Invoices.EditValue = ""
        If Transaction_Category.EditValue Is "CHARGE INVOICE" Then
            Terms.ReadOnly = False

        Else
            Terms.ReadOnly = True
            Terms.EditValue = ""
        End If
        Initialize_Invoice(CStr(Transaction_Category.GetColumnValue("TransactionID")))
        Initialize_Invoices(Invoices)
    End Sub
    Friend Sub Control_New(Optional ByVal bClear As Boolean = False, Optional ByVal bOrderModify As Boolean = False)

        If bClear AndAlso Not class_Procedures.actionAsk("New Sales Transaction", "Initialize new Sales Transaction", "You might lose unsaved data") Then Return
        class_Procedures.Initialize_Controls(Me, bClear)
        ID.Text = "0"
        SI_Number.EditValue = ""
    End Sub
    Friend Function Control_Save() As Boolean
        If class_Procedures.isEmpty(Transaction_Category) Then Return False
        If class_Procedures.isEmpty(brand) Then Return False

        Dim sCategory() As String = Transaction_Category.Text.Split("-")
        Dim sNotes As String = String.Empty
        If sCategory.Length > 3 Then
            sNotes = class_Functions.Show_Input_Box("Input reason for modifying this Purchase Order", "Modify Purchase Order", String.Empty)

        End If

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ID", ID.EditValue),
            New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
            New SqlParameter("@Transaction_Category", Transaction_Category.EditValue),
            New SqlParameter("@Invoices", Invoices.EditValue),
            New SqlParameter("@Customer_Name", Customer_Name.EditValue),
            New SqlParameter("@Address", Address.EditValue),
            New SqlParameter("@SI_Number", SI_Number.EditValue),
            New SqlParameter("@Terms", Terms.EditValue),
            New SqlParameter("@PostingDate", Posting_Date.EditValue),
            New SqlParameter("@Pricing", Pricing.EditValue),
            New SqlParameter("@Notes", Notes.EditValue),
            New SqlParameter("@Added_By", class_Variables.sUserName),
            New SqlParameter("@Action_Type", "SAVE")
        }
        Return class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Transaction_Sales", "Sales Transactions", Transaction_Category.Text)
    End Function
End Class
