Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Public Class Xuc_Sales_Entries
    Dim sBrCode, sBrand, sCategory, sPartNumber, sPartName, sType As String
    Dim iQuantity, iCartons, iBatch_Id, iId_Initial As Integer
    Dim dSRP, dRebates As Decimal
    Dim dUnitCost As Decimal = 0
    Public Sub New()
        InitializeComponent()
    End Sub
    Friend Sub Control_Initialize()
        Initialize_Tran_Category("SALES")
        Initialize_Tran_Category(Transaction_Category)
        Transaction_Category.Select()
        Posting_Date.EditValue = Date.Now()
        SI_Number.Properties.MaskSettings.Set("mask", $"{get_Branch_Pre_Code(class_Saga_Variables.sBranchCode)}-SI0000")
        class_Procedures.Initialize_gridView(gridView_List, True, True)
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
    Private Sub Toggle_PDCs()
        If Toggle_PDC.IsOn Then
            PDC_Amount.ReadOnly.Equals(False)
            PDC_Code.ReadOnly.Equals(False)
            PDC_Name.ReadOnly.Equals(False)
            PDC_Date.ReadOnly.Equals(False)

        End If
    End Sub
    Private Sub Toggle_PDC_Toggled(sender As Object, e As EventArgs) Handles Toggle_PDC.Toggled
        Toggle_PDCs()
    End Sub

    Private Sub Toggle_PDC_Properties_EditValueChanged(sender As Object, e As EventArgs) Handles Toggle_PDC.Properties.EditValueChanged
        If Toggle_PDC.Properties.OnText.Equals("With PDC") Then
            PDC_Amount.ReadOnly.Equals(False)
            PDC_Code.ReadOnly.Equals(False)
            PDC_Name.ReadOnly.Equals(False)
            PDC_Date.ReadOnly.Equals(False)
        Else
            PDC_Amount.ReadOnly.Equals(True)
            PDC_Code.ReadOnly.Equals(True)
            PDC_Name.ReadOnly.Equals(True)
            PDC_Date.ReadOnly.Equals(True)
        End If
    End Sub

    Private Sub Customer_Name_Popup(sender As Object, e As EventArgs) Handles Customer_Name.Popup
        Xuc_Account_Search.Load_Search(Customer_Name.Text.Trim)
    End Sub

    Private Sub RepositoryItemLookUpEdit_Parts_Number_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit_PartNumber.Validating
        Try
            Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)


            sPartNumber = editor.GetColumnValue("PartsNumber").ToString()
            gridView_List.SetFocusedRowCellValue(colPartsNumber, sPartNumber)

            sPartName = editor.GetColumnValue("PartsName").ToString()
            gridView_List.SetFocusedRowCellValue(colPartsName, sPartName)

            sCategory = editor.GetColumnValue("Category").ToString()
            gridView_List.SetFocusedRowCellValue(colCategory, sCategory)

            sBrand = editor.GetColumnValue("Brand").ToString()
            gridView_List.SetFocusedRowCellValue(colBrand, sBrand)

            dSRP = CDec(editor.GetColumnValue("SRP"))
            gridView_List.SetFocusedRowCellValue(colSRP, dSRP)

            dUnitCost = CDec(editor.GetColumnValue("SPCostWOVAT"))
            gridView_List.SetFocusedRowCellValue(colCost, dUnitCost)

            iQuantity = 0
            gridView_List.SetFocusedRowCellValue(colQuantity, iQuantity)

            iId_Initial = 0
            gridView_List.SetFocusedRowCellValue(colID_List, iId_Initial)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RepositoryItemSpinEdit_Quantity_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemSpinEdit_Quantity.EditValueChanged
        Try
            iQuantity = Convert.ToInt32(CType(sender, BaseEdit).EditValue)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub gridView_List_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView_List.CellValueChanged
        Try
            With gridView_List
            End With
        Catch ex As Exception
            class_Procedures.Show_Error(Ex)
        End Try
    End Sub

    Private Sub gridView_Items_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        gridView_List.BestFitColumns()
    End Sub
    Private Sub Transaction_Category_EditValueChanged(sender As Object, e As EventArgs) Handles Transaction_Category.EditValueChanged
        Invoices.EditValue = String.Empty
        If Transaction_Category.EditValue.Equals("CHARGE INVOICE") Then
            Toggle_PDC.ReadOnly = False
            Toggle_PDC.IsOn.Equals(False)
            Terms.ReadOnly = False

        Else
            Toggle_PDC.ReadOnly = True
            Terms.ReadOnly = True
            Terms.EditValue = String.Empty
        End If
        Initialize_Invoice(CStr(Transaction_Category.GetColumnValue("TransactionID")))
        Initialize_Invoices(Invoices)
    End Sub
    Friend Sub Control_New(Optional ByVal bClear As Boolean = False, Optional ByVal bOrderModify As Boolean = False)

        If bClear AndAlso Not class_Procedures.actionAsk("New Sales Transaction", "Initialize new Sales Transaction", "You might lose unsaved data") Then Return
        class_Procedures.Initialize_Controls(Me, bClear)
        SI_Number.EditValue = String.Empty
        class_Procedures.Initialize_gridView(gridView_List, True, True)
        SI_Number.Properties.MaskSettings.Set("mask", $"{get_Branch_Pre_Code(class_Saga_Variables.sBranchCode)}-SI0000")
        'If Not class_Procedures.isEmpty(brand) Then
        '    If bOrderModify Then
        '        Dim sOrderCode() As String = Order_Code.Text.Split("-")
        '        Order_Code.EditValue = class_Database.Get_Last_ID(class_Database.SPAConnection, "Spare_Parts_Purchase_Order", "ID", "Order_Code", $"{sOrderCode(0)}-{sOrderCode(1)}-{sOrderCode(2)}-")
        '    Else
        '        Order_Code.EditValue = class_Database.Get_Last_ID(class_Database.SPAConnection, "Spare_Parts_Purchase_Order", "ID", "Order_Code", $"{"PO"}-{brand.Text.Trim}-", 2)
        '    End If
        '    Order_Date.Select()
        'Else
        '    brand.Select()
        'End If
    End Sub
    Friend Function Control_Save() As Boolean
        If class_Procedures.isEmpty(Transaction_Category) Then Return False
        If class_Procedures.isEmpty(brand) Then Return False

        Dim sCategory() As String = Transaction_Category.Text.Split("-")
        Dim sNotes As String = String.Empty
        If sCategory.Length > 3 Then
            'If class_Procedures.isEmpty(Notes) Then Return False
            sNotes = class_Functions.Show_Input_Box("Input reason for modifying this Purchase Order", "Modify Purchase Order", String.Empty)

        End If

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ID", "0"),
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
    Public Sub Save_Item_List()
        With gridView_List
            If .DataRowCount > 0 Then
                For i As Integer = 0 To .DataRowCount - 1
                    Dim iID As Integer
                    Try
                        If .GetRowCellValue(i, colID_List).Equals(Nothing) Then Return
                        Try
                            iID = Convert.ToInt32(.GetRowCellValue(i, colID_List))
                        Catch ex As Exception
                            iID = 0
                        End Try
                        Dim UnitParameters As SqlParameter() = {
                            New SqlParameter("@ID", colID_List),
                            New SqlParameter("@Transaction_Category", Transaction_Category.EditValue),
                            New SqlParameter("@Trans_Code", Transaction_Category.GetColumnValue("Mnemonic")),
                            New SqlParameter("@PostingDate", Posting_Date.EditValue),
                            New SqlParameter("@Customer_Name", Customer_Name.EditValue),
                            New SqlParameter("@Address", Address.EditValue),
                            New SqlParameter("@SI_Number", SI_Number.EditValue),
                            New SqlParameter("@Invoices", Invoices.EditValue),
                            New SqlParameter("@PartsNumber", .GetRowCellValue(i, colPartsNumber)),
                            New SqlParameter("@PartsName", .GetRowCellValue(i, colPartsName)),
                            New SqlParameter("@Notes", Notes.EditValue),
                            New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                            New SqlParameter("@Quantity", .GetRowCellValue(i, colQuantity)),
                            New SqlParameter("@SRP", .GetRowCellValue(i, colSRP)),
                            New SqlParameter("@Batch_ID", .GetRowCellDisplayText(i, colBatch_Id)),
                            New SqlParameter("@Added_By", class_Saga_Variables.user),
                            New SqlParameter("@Terms", Terms.EditValue),
                            New SqlParameter("@Pricing", Pricing.EditValue),
                            New SqlParameter("@GrandTotal", .GetRowCellValue(i, colNet_Total)),
                            New SqlParameter("@Discounted_SRP", .GetRowCellValue(i, colDiscount_SRP)),
                            New SqlParameter("@Unit_Cost", .GetRowCellValue(i, colCost)),
                            New SqlParameter("@Brand", .GetRowCellValue(i, colBrand)),
                            New SqlParameter("@Category", .GetRowCellValue(i, colCategory))
                        }
                        class_Database.Procedure_Save(class_Database.SPAConnection, UnitParameters, "spa_Transaction_Sales", "Sales Transactions")
                    Catch ex As Exception
                    End Try
                Next
            End If
        End With
    End Sub

End Class
