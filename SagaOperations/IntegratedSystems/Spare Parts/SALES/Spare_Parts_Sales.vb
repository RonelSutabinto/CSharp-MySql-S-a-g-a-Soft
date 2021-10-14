Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports SagaOperations.Classes

Public Class Spare_Parts_Sales
    Public dt As DataTable

    Sub Initialize_GridList()
        dt = New DataTable
        dt.Columns.Add("BranchCode")
        dt.Columns.Add("Quantity")
        dt.Columns.Add("Unit")
        dt.Columns.Add("Description")
        dt.Columns.Add("UnitPrice")
        dt.Columns.Add("GrossTotal")
        dt.Columns.Add("Discount")
        dt.Columns.Add("Discount_PCT")
        dt.Columns.Add("DiscountSRP")
        dt.Columns.Add("subTotal")
        dt.Columns.Add("PrevID")
        dt.Columns.Add("PartsNumber")
        dt.Columns.Add("PartsName")

        GridList.DataSource = dt
    End Sub

    Sub Inventory_ItemAdd()
        Dim dr As DataRow = dt.NewRow

        dr(0) = class_Saga_Variables.sBranchCode
        dr(1) = Xuc_Spare_Parts_Details.Input_Quantity.EditValue
        dr(2) = Xuc_Spare_Parts_Details.Unit.EditValue
        dr(3) = Xuc_Spare_Parts_Details.Parts_Number.EditValue + " (" + Xuc_Spare_Parts_Details.Parts_Name.EditValue +")"
        dr(4) = Xuc_Spare_Parts_Details.Unit_Price.EditValue
        dr(5) = Xuc_Spare_Parts_Details.Gross_Total.EditValue
        dr(6) = Xuc_Spare_Parts_Details.Discount_Amount.EditValue
        dr(7) = Xuc_Spare_Parts_Details.Discount_Percentage.EditValue
        dr(8) = Xuc_Spare_Parts_Details.Selling_Price.EditValue
        dr(9) = Xuc_Spare_Parts_Details.ID.EditValue
        dr(10) = Xuc_Spare_Parts_Details.Net_Total.EditValue
        dr(11) = Xuc_Spare_Parts_Details.Parts_Number.EditValue
        dr(12) = Xuc_Spare_Parts_Details.Parts_Name.EditValue

        dt.Rows.Add(dr)
        GridList.DataSource = dt

        If MsgBox("Item added to table. " & vbCrLf & "Do you want to create another? ", vbYesNo, "SagaSoft") = MsgBoxResult.No Then
            'MC_For_Reprice.DockPanel1.Visible = False
            Return
        End If
    End Sub

    Private Sub Spare_Parts_Sales_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, GridView, BtnCancel)
        Initialize_BarManager(Me, BarManager)
    End Sub

    Private Sub Spare_Parts_Sales_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Initialize_GridList()
        Xuc_Spare_Parts_Details.Initialize_Parts()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub MC_For_Reprice_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Close()
    End Sub

    Private Sub Form_Close()
        class_Procedures.Form_Close(Me, BarManager, DockManager, GridView, True)
    End Sub

    Private Sub Btn_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Add.ItemClick
        Inventory_ItemAdd()
    End Sub

End Class