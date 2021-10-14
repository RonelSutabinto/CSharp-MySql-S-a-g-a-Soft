Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class IS_Inventory_item_add
    Private Sub IS_Inventory_item_add_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        IS_Inventory_List.LViewEvent()
    End Sub

    Sub ComputeTotalCost()
        txt_vatamount.Text = Format((Val(txt_unitcost.Text) * Val(num_vat.Value)) / 100, "####.##")
        txt_totcost.Text = Format(Val(txt_unitcost.Text) + txt_vatamount.Text, "####.##")
    End Sub

    Private Sub txt_unitcost_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_unitcost.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = ControlChars.Back)
    End Sub

    Private Sub txt_unitcost_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_unitcost.TextChanged

        If txt_unitcost.Text = String.Empty Then
        Else
            txt_vatamount.Text = Format((Val(txt_unitcost.Text) * Val(num_vat.Value)) / 100, "####.##")
            txt_totcost.Text = Format(Val(txt_unitcost.Text) + txt_vatamount.Text, "####.##")
        End If
    End Sub

    Private Sub txt_vatamount_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_vatamount.TextChanged
        If txt_vatamount.Text = String.Empty Then
            txt_vatamount.Text = "0"
        End If
    End Sub

    Private Sub txt_totcost_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_totcost.TextChanged
        If txt_totcost.Text = String.Empty Then
            txt_totcost.Text = "0"
        End If
    End Sub

    Public dt As DataTable

    Sub Inventory_ItemAdd()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamEngineNo", txt_engineNo.Text),
            New SqlParameter("@ParamChassisNo", txt_chassisNo.Text),
            New SqlParameter("@ParamWHCode", IS_Inventory_Receiving.txt_whcode.Text),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamBranchCodeAcct", txt_BrCode.Text),
            New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamAccountName", txt_note.Text),
            New SqlParameter("@ParamSpecNotes", txt_SpecNotes.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_Inventory_ItemAdd")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                MsgBox(myDataReader.Item("Message").ToString())
            Else
                If MsgBox("Item added to table. " & vbCrLf & "Do you want to create another? ", vbYesNo, "webMharjun") = MsgBoxResult.Yes Then
                    Try
                        Dim dr As DataRow = dt.NewRow
                        dr(0) = txt_code.EditValue
                        dr(1) = txt_model.EditValue
                        dt.Rows.Add(dr)
                        IS_Inventory_Receiving.GridList.DataSource = dt
                    Catch Ex As Exception

                    End Try
                Else
                    Try
                        Dim dr As DataRow = dt.NewRow
                        dr(0) = txt_code.EditValue
                        dr(1) = txt_model.EditValue
                        dt.Rows.Add(dr)
                        IS_Inventory_Receiving.GridList.DataSource = dt
                    Catch Ex As Exception

                    End Try
                    Me.Close()
                End If
            End If
        End Using
    End Sub

    Private Sub txt_unitcost_EditValueChanged(sender As Object, e As EventArgs) Handles txt_unitcost.EditValueChanged
        ComputeTotalCost()
    End Sub

    Private Sub num_vat_EditValueChanged(sender As Object, e As EventArgs) Handles num_vat.EditValueChanged
        ComputeTotalCost()
    End Sub

    Private Sub IS_Inventory_item_add_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)
    End Sub

    Private Sub Btn_Account_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Account.ItemClick
        IS_Sales_ReleaseAccount_List.Text = "ACCTDEP"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    Private Sub txt_SpecNotes_DoubleClick(sender As Object, e As EventArgs) Handles txt_SpecNotes.DoubleClick
        txt_SpecNotes.Text = "No particular Notes"
    End Sub

    Private Sub Btn_Import_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Import.ItemClick
        Inventory_ItemAdd()
    End Sub

End Class