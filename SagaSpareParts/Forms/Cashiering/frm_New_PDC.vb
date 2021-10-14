Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class frm_New_PDC
    Private Sub frm_PDC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton

        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        BarEditItem_Date_Start.EditValue = CStr(Date.Now())
        BarEditItem_Date_End.EditValue = CStr(Date.Now())
        class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, Xuc_Settings)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager, xuc_Settings)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub Form_Close()
        class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
    End Sub

    Private Sub frm_PDC_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Close()
    End Sub
    Private Sub frm_PDC_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Xuc_Settings.Toggle_Auto_Initialize.IsOn Then Xuc_PDC.Control_Initialize()
        If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD_PDC")
    End Sub
    Private Sub Data_Load(ByVal sActionType As String)
        Dim dtStart, dtEnd As Date

        Try
            If class_Saga_Variables.sBranchCode.Equals("000") Then
                dtStart = CDate(BarEditItem_Date_Start.EditValue)
                dtEnd = CDate(BarEditItem_Date_End.EditValue)
            Else
                dtStart = CDate(BarEditItem_Date_Start.EditValue)
                dtEnd = CDate(BarEditItem_Date_End.EditValue)
            End If
        Catch ex As Exception
            class_Procedures.Show_Error(Ex)
        End Try

        Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Date_Start", dtStart),
                New SqlParameter("@Date_End", dtEnd),
                New SqlParameter("@Action_Type", sActionType)
            }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, gridControl, gridView, "spa_Transaction_Sales", "Post Dated Check")

        gridView.ClearSorting()
        colCustomer_Name.SortIndex = 0
        colCustomer_Name.SortOrder = DevExpress.Data.ColumnSortOrder.Descending

    End Sub
    Private Sub Data_Show()
        With Xuc_PDC
            .Customer_Name.Text = gridView.GetFocusedRowCellDisplayText(colCustomer_Name)
            .Customer_Address.Text = CStr(gridView.GetFocusedRowCellValue(colCustomer_Address))
            .SBD_Amount_Due.EditValue = gridView.GetFocusedRowCellValue(colGrand_Total)
            .SBD_Mat_Date.EditValue = gridView.GetFocusedRowCellValue(colMaturity_Date)
            .PDC_Id.EditValue = "0"
        End With
    End Sub

    Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
        If e.Clicks.Equals(2) AndAlso gridView.DataRowCount > 0 Then
            Select Case e.Column.FieldName
                Case "custName"
                Case Else
                    class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                    Data_Show()
            End Select
        End If
    End Sub
    Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        Data_Load("LOAD_PDC")
    End Sub
    Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
        xuc_PDC.Control_Initialize()
    End Sub
    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        If Me.xuc_PDC.Control_Save() Then
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then

            Else
                'Update_Data_Row()
            End If
        End If
    End Sub

    Private Sub btn_Unit_Order_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        If class_Procedures.isEmpty(xuc_PDC.Check_No) Then Return

        Dim xRpt As New SagaSpareParts.xrpt_SPA_PDC_Report()
        class_Database.Bind_Report(class_Database.SPAConnection, xRpt, $"SELECT * FROM SPA_PDC ", "SPA_PDC")

        Try
            With xRpt
                .PaperKind = System.Drawing.Printing.PaperKind.Custom
                .PageWidth = 1300
                .PageHeight = 850

                '.XrTableCell_Brand.Text = Xuc_SPA_Purchase_Orders.Brand.Text
                '.XrTableCell_Dealer.Text = Xuc_SPA_Purchase_Orders.Supplier_Name.Text
                '.XrTableCell_Address.Text = CStr(Xuc_SPA_Purchase_Orders.Brand.GetColumnValue("Account_Address"))

                '.XrTableCell_Purchase_Order_Code.Text = Xuc_SPA_Purchase_Orders.Order_C0de.EditValue.ToString
                '.XrTableCell_Order_Date.Text = Xuc_SPA_Purchase_Orders.Order_Date.Text

                .Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
            End With
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        End Try
    End Sub
End Class