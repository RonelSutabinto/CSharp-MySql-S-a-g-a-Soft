Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports wSClassLib.myModules

Public Class IS_Inventory_MC_FromSuppler
    Private dt As DataTable

    private sub IS_Inventory_MC_FromSuppler_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txt_InvoiceDate.EditValue = Now
        txt_PostingDate.EditValue = Now

        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)

        Initialize_Supplier()
        Initialize_Supplier(LkUp_Supplier)

        Initialize_Color()
        Initialize_Color(LkUp_Color)

        Initialize_GridList()
    End Sub

    private sub Initialize_GridList()
        dt = New DataTable
        dt.Columns.Add("Code")
        dt.Columns.Add("Supplier")
        dt.Columns.Add("Model")
        dt.Columns.Add("Description")
        dt.Columns.Add("Color")
        dt.Columns.Add("Brand")
        dt.Columns.Add("EngineNo")
        dt.Columns.Add("ChassisNo")
        dt.Columns.Add("KeyNo")
        dt.Columns.Add("UnitCost")
        dt.Columns.Add("VATAmt")
        dt.Columns.Add("TotalCost")
        dt.Columns.Add("UnitPrice")
        dt.Columns.Add("Terms")
        dt.Columns.Add("Courier")
        dt.Columns.Add("SINo")
        dt.Columns.Add("PONo")
        dt.Columns.Add("Remarks")
        dt.Columns.Add("InvoiceDate")
        dt.Columns.Add("PostingDate")
        dt.Columns.Add("SupplierID")
        dt.Columns.Add("ModelID")
        dt.Columns.Add("ColorID")
        GCList.DataSource = dt
    End Sub

    private sub LkUp_Brand_EditValueChanged(sender As Object, e As EventArgs) Handles LkUp_Brand.EditValueChanged
        Initialize_Model(LkUp_Brand.EditValue)
        Initialize_Model(LkUp_Model, LkUp_Brand.EditValue)
    End Sub

    private sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Insert.ItemClick
        If LkUp_Supplier.Text = String.Empty Then
            MsgBox("Supplier not found!", vbCritical, Application.CompanyName)
            Return
        End If
        If LkUp_Brand.Text = String.Empty Then
            MsgBox("Brand not found!", vbCritical, Application.CompanyName)
            Return
        End If
        If LkUp_Model.Text = String.Empty Then
            MsgBox("Model not found!", vbCritical, Application.CompanyName)
            Return
        End If
        If LkUp_Color.Text = String.Empty Then
            MsgBox("Color not found!", vbCritical, Application.CompanyName)
            Return
        End If

        Dim dr As DataRow = dt.NewRow
        dr(0) = LkUp_Model.EditValue
        dr(1) = LkUp_Supplier.Text
        dr(2) = LkUp_Model.Text
        dr(3) = LkUp_Model.Text & " - " & LkUp_Color.Text
        dr(4) = LkUp_Color.Text
        dr(5) = LkUp_Brand.Text
        dr(6) = txt_EngineNo.EditValue
        dr(7) = txt_ChassisNo.EditValue
        dr(8) = txt_KeyNo.EditValue
        dr(9) = txt_UnitCost.EditValue
        dr(10) = txt_VATAmt.EditValue
        dr(11) = txt_TotCost.EditValue
        dr(12) = txt_UnitPrice.EditValue
        dr(13) = txt_Terms.EditValue
        dr(14) = txt_Courier.EditValue
        dr(15) = txt_SINo.EditValue
        dr(16) = txt_PONo.EditValue
        dr(17) = txt_Remarks.EditValue
        dr(18) = txt_InvoiceDate.EditValue
        dr(19) = txt_PostingDate.EditValue
        dr(20) = LkUp_Supplier.EditValue
        dr(21) = LkUp_Model.EditValue
        dr(22) = LkUp_Color.EditValue
        dt.Rows.Add(dr)
        GCList.DataSource = dt
    End Sub

    private sub GView_MouseDown(sender As Object, e As MouseEventArgs) Handles GView.MouseDown
        If e.Button = MouseButtons.Right Then
            PopupMenu1.ShowPopup(MousePosition)
        End If

    End Sub

    private sub btn_Delete_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
        If MsgBox("Delete Highlighted Row??", vbYesNo, Application.CompanyName) = vbYes Then
            GView.DeleteRow(GView.FocusedRowHandle)
        End If
    End Sub

    private sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick

        Try
            LkUp_Supplier.Text = GView.Columns.View.GetFocusedRowCellValue("Code")
            txt_SINo.Text = GView.Columns.View.GetFocusedRowCellValue("SINo")
            txt_PONo.Text = GView.Columns.View.GetFocusedRowCellValue("PONo")
            txt_InvoiceDate.Text = GView.Columns.View.GetFocusedRowCellValue("InvoiceDate")
            txt_PostingDate.Text = GView.Columns.View.GetFocusedRowCellValue("PostingDate")
            txt_Terms.Text = GView.Columns.View.GetFocusedRowCellValue("Terms")
            txt_Courier.Text = GView.Columns.View.GetFocusedRowCellValue("Courier")
            LkUp_Brand.Text = GView.Columns.View.GetFocusedRowCellValue("Brand")
            LkUp_Model.Text = GView.Columns.View.GetFocusedRowCellValue("Model")
            LkUp_Color.Text = GView.Columns.View.GetFocusedRowCellValue("Color")
            txt_EngineNo.Text = GView.Columns.View.GetFocusedRowCellValue("EngineNo")
            txt_ChassisNo.Text = GView.Columns.View.GetFocusedRowCellValue("ChassisNo")
            txt_KeyNo.Text = GView.Columns.View.GetFocusedRowCellValue("KeyNo")
            txt_UnitCost.Text = GView.Columns.View.GetFocusedRowCellValue("UnitCost")
            txt_VATAmt.Text = GView.Columns.View.GetFocusedRowCellValue("VATAmt")
            txt_TotCost.Text = GView.Columns.View.GetFocusedRowCellValue("TotalCost")
            txt_UnitPrice.Text = GView.Columns.View.GetFocusedRowCellValue("UnitPrice")
            txt_Remarks.Text = GView.Columns.View.GetFocusedRowCellValue("Remarks")
            LkUp_Supplier.EditValue = txt_Remarks.Text = GView.Columns.View.GetFocusedRowCellValue("SupplierID")
            LkUp_Model.EditValue = txt_Remarks.Text = GView.Columns.View.GetFocusedRowCellValue("ModelID")
            LkUp_Color.EditValue = txt_Remarks.Text = GView.Columns.View.GetFocusedRowCellValue("ColorID")
        Catch ex As Exception

        End Try
    End Sub

    private sub btn_Save_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        Dim i As Integer
        For i = 0 To GView.DataRowCount - 1
            MsgBox(GView.GetRowCellValue(i, "Code"))
        Next
    End Sub

    private sub searchInventoryHoPerWHCode()
        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_showitemwh")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                MsgBox(myDataReader.Item("Message").ToString())
            End If
        End Using
    End Sub

    private sub ComputeTotalCost()

        txt_VATAmt.Text = Format((Val(txt_UnitCost.Text) * Val(VATPctg.Value)) / 100, "####.##")
        txt_TotCost.Text = Format(Val(txt_UnitCost.Text) + txt_VATAmt.Text, "####.##")
    End Sub

    private sub txt_UnitCost_EditValueChanged(sender As Object, e As EventArgs) Handles txt_UnitCost.EditValueChanged
        ComputeTotalCost()
    End Sub

    private sub VATPctg_EditValueChanged(sender As Object, e As EventArgs) Handles VATPctg.EditValueChanged
        ComputeTotalCost()
    End Sub
End Class