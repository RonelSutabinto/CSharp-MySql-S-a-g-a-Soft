Imports System.Data.SqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports MyClassLibrary.Classes.class_Procedures
Imports SagaClassLibrary.Classes

Namespace Forms.Cashiering
    Public Class frm_PDC
        Private Sub Show_Form(ByVal xFrm As XtraForm, ByVal sTitle As String, Optional ByVal bChild As Boolean = True)
            class_Procedures.splash_Show(sTitle, , True, xFormMode.xForm)
            Try
                xFrm.Icon = Me.Icon
                xFrm.Text = sTitle
                If bChild Then xFrm.MdiParent = Me
                xFrm.Show()
            Catch ex As Exception

            End Try
            class_Procedures.splash_Close(True)
        End Sub
        Private Sub frm_PDC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton

            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            BarEditItem_Date_Start.EditValue = CStr(Date.Now())
            BarEditItem_Date_End.EditValue = CStr(Date.Now())
            class_Procedures.Initialize_Form(Me, DockManager, gridView_List, BtnCancel, xuc_Settings)
            class_Saga_Procedures.Initialize_BarManager(Me, BarManager, xuc_Settings)
        End Sub
        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub Form_Close()
            class_Procedures.Form_Close(Me, BarManager, DockManager, gridView_List, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Sub
        Private Sub frm_PDC_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            Form_Close()
        End Sub
        Private Sub frm_PDC_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_PDC.Control_Initialize()
        End Sub

        Private Sub Data_Load_PDC(ByVal sActionType As String)
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
                class_Procedures.Show_Error(ex)
            End Try

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Date_Start", dtStart),
                New SqlParameter("@Date_End", dtEnd),
                New SqlParameter("@Action_Type", sActionType)
            }

            class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, gridControl_List, gridView_List, "spa_Post_Dated_Check_Procedures", "Post Dated Check")

            gridView_List.ClearSorting()
            colPDC_Name.SortIndex = 0
            colPDC_Name.SortOrder = DevExpress.Data.ColumnSortOrder.Descending

        End Sub

        Private Sub Data_Show_PDC()
            With xuc_PDC
                .PDC_Id.EditValue = gridView_List.GetFocusedRowCellDisplayText(col_PDC_Id)
                .Bank_Name.Text = gridView_List.GetFocusedRowCellDisplayText(colBank_Name)
                .Customer_Name.Text = gridView_List.GetFocusedRowCellDisplayText(colPDC_Name)
                .Customer_Address.Text = CStr(gridView_List.GetFocusedRowCellValue(colPDC_Address))
                .Check_No.EditValue = gridView_List.GetFocusedRowCellValue(colPDC_No)
                .Amount.EditValue = gridView_List.GetFocusedRowCellValue(colPDC_Amount)
                .Due_Date.EditValue = gridView_List.GetFocusedRowCellValue(colPDC_Date)
                .SBD_Amount_Due.EditValue = gridView_List.GetFocusedRowCellValue(colSBD_Amount_Due)
                .SBD_Mat_Date.EditValue = gridView_List.GetFocusedRowCellValue(colSBD_Maturity_Date)
                .PDC_Description.EditValue = gridView_List.GetFocusedRowCellValue(colSBD_Description)
            End With
        End Sub
        Private Sub gridView_List_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView_List.RowCellClick
            If e.Clicks.Equals(2) AndAlso gridView_List.DataRowCount > 0 Then
                Select Case e.Column.FieldName
                    Case "custName"
                    Case Else
                        class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                        Data_Show_PDC()
                End Select
            End If
        End Sub
        Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load_PDC("LOAD")
        End Sub
        Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_PDC.Control_Initialize()
        End Sub
        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If Me.xuc_PDC.Control_Save() Then
                If xuc_Settings.Toggle_Auto_Reload.IsOn Then
                    Data_Load_PDC("LOAD")
                Else
                    'Update_Data_Row()
                End If
            End If
        End Sub

        Private Sub btn_Unit_Order_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            If class_Procedures.isEmpty(xuc_PDC.Check_No) Then Return

            Dim xRpt As New SagaSpareParts.xrpt_SPA_PDC_Report()

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 1300
                    .PageHeight = 850

                    .xrpt_Date.Text = CStr(BarEditItem_Date_End.EditValue)
                    .XrLabel_Branch.Text = get_Branch_Name(class_Saga_Variables.sBranchCode)
                    '.XrTableCell_Address.Text = CStr(Xuc_SPA_Purchase_Orders.Brand.GetColumnValue("Account_Address"))

                    '.XrTableCell_Order_Date.Text = Xuc_SPA_Purchase_Orders.Order_Date.Text
                End With

                Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Date_End", BarEditItem_Date_End.EditValue),
                New SqlParameter("@Action_Type", "PREVIEW")
            }

                class_Database.Procedure_Bind_Report(class_Database.SPAConnection, sqlParameters, xRpt, "spa_Post_Dated_Check_Procedures", "Post Dated Check")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            Dim xxfrm As frm_New_PDC = New frm_New_PDC()
            Show_Form(xxfrm, "New Post Dated Check", False)
        End Sub
    End Class
End Namespace