Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Namespace myModules

    Public Module InitializeData
        Public LUE_Brand As LookUpEdit = New LookUpEdit()
        Public LUE_Model As LookUpEdit = New LookUpEdit()
        Public LUE_Supplier As LookUpEdit = New LookUpEdit()
        Public LUE_IntransitBranch As LookUpEdit = New LookUpEdit()

        Public LUE_Color As LookUpEdit = New LookUpEdit()
        Public LUE_Vendor As LookUpEdit = New LookUpEdit()
        Public LUE_whCode As LookUpEdit = New LookUpEdit()
        Public LUE_Users As LookUpEdit = New LookUpEdit()
        Public LUE_Receivers As LookUpEdit = New LookUpEdit()
        Public LUE_WHOutgoing As LookUpEdit = New LookUpEdit()
        Public LUE_InvRemarks As LookUpEdit = New LookUpEdit()
        Public LUE_MCAccountStatus As LookUpEdit = New LookUpEdit()

        Friend iCount As Integer = 0

        Public Sub Initialize_Brand()
            mBindData(LUE_Brand, "SELECT id,branddesc from maint_brand order by id asc", "maint_brand")
            '  iCount = RecordCount("SELECT branddesc FROM maint_brand")
        End Sub

        Public Sub Initialize_Brand(ByVal barItem As DevExpress.XtraBars.BarEditItem, ByVal brand As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
            barItem.EditWidth = 200
            ' barItem.EditValue = sBranchCode

            With brand
                Try
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("branddesc", "Brand")})
                    'New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch", "Branch Name"),
                    'New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DatabaseDate", "Posting Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far)})

                    .DataSource = LUE_Brand.Properties.DataSource
                    .DisplayMember = "branddesc"
                    .ValueMember = "branddesc"
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try

                brand.DropDownRows = class_Database.Get_Data(class_Database.ICSConnection, "SELECT COUNT(*) AS COUNT FROM maint_brand", "COUNT")
                brand.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                brand.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                ' barItem.EditValue = sBranchCode
            End With
        End Sub

        Public Sub Initialize_Model(ByVal sBrand As String)
            mBindData(LUE_Model, $"SELECT * FROM maint_model where branddesc LIKE '{sBrand}' order by modeldesc asc", "maint_model")
            'iBranchCount = RecordCount("SELECT branddesc FROM maint_brand")
        End Sub

        Public Sub Initialize_Model(ByVal barItem As DevExpress.XtraEditors.LookUpEdit, ByVal sBrand As String)

            With barItem
                Try
                    .Properties.Columns.Clear()
                    .Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("branddesc", "Brand"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modeldesc", "Model")})
                    'New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch", "Branch Name"),
                    'New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DatabaseDate", "Posting Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far)})
                    .Width = 200
                    .Properties.DataSource = LUE_Model.Properties.DataSource
                    .Properties.DisplayMember = "modeldesc"
                    .Properties.ValueMember = "id"
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try

                .Properties.DropDownRows = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT from maint_model where branddesc LIKE '{sBrand}'", "COUNT")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                ' barItem.EditValue = sBranchCode
            End With
        End Sub

        Public Sub Initialize_Model(ByVal barItem As DevExpress.XtraBars.BarEditItem, ByVal model As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal sBrand As String)
            barItem.EditWidth = 500
            ' barItem.EditValue = sBranchCode

            With model
                Try
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("branddesc", "Brand"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modeldesc", "Model")})

                    .DataSource = LUE_Model.Properties.DataSource
                    .DisplayMember = "modeldesc"
                    .ValueMember = "id"
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try

                model.DropDownRows = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT from maint_model where branddesc LIKE '{sBrand}'", "COUNT")
                model.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                model.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                ' barItem.EditValue = sBranchCode
            End With
        End Sub

        Public Function mBindData(ByVal lookUpEdit As LookUpEdit, ByVal sQuery As String, ByVal sTable As String) As Boolean
            Try
                Using ds As DataSet = New DataSet()
                    lookUpEdit.Properties.DataSource = class_Database.BindSource(class_Database.ICSConnection, ds, sQuery, sTable)
                    lookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                End Using
                Return True
            Catch ex As Exception
                Return class_Procedures.Show_Error(ex)
            Finally
                lookUpEdit.Select()
            End Try
        End Function

        Public Sub Initialize_ToolBars(ByVal mBar As BarEditItem)
            Initialize_ToolBars(mBar)
            'barManager.RestoreLayoutFromRegistry(xForm.Name)
        End Sub

        Public Sub Initialize_Supplier()
            mBindData(LUE_Supplier, $"SELECT * FROM maint_vendor where branchCode LIKE '{class_Saga_Variables.sBranchCode}'", "maint_vendor")
            '  iCount = RecordCount("SELECT branddesc FROM maint_brand")
        End Sub

        Public Sub Initialize_Supplier(ByVal barItem As DevExpress.XtraEditors.LookUpEdit)

            With barItem
                Try
                    .Properties.Columns.Clear()
                    .Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("vendordesc", "Supplier"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Branch Name"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("contactno", "ContactNo")}
                    )

                    .Width = 200
                    .Properties.DataSource = LUE_Supplier.Properties.DataSource
                    .Properties.DisplayMember = "vendordesc"
                    .Properties.ValueMember = "id"
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try

                .Properties.DropDownRows = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT FROM maint_vendor where branchCode LIKE '{class_Saga_Variables.sBranchCode}'", "COUNT")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            End With
        End Sub

        Public Sub Initialize_IntransitBranch()
            mBindData(LUE_IntransitBranch, $"SELECT * FROM maint_vendor where type LIKE 'branch' order by branchcode asc", "maint_vendor")
            '  iCount = RecordCount("SELECT branddesc FROM maint_brand")
        End Sub

        Public Sub Initialize_IntransitBranch(ByVal barItem As DevExpress.XtraEditors.LookUpEdit)

            With barItem
                Try
                    .Properties.Columns.Clear()
                    .Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("branchCode", "BranchCode"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("vendordesc", "Branch"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("address", "Address")}
                    )

                    .Width = 200
                    .Properties.DataSource = LUE_IntransitBranch.Properties.DataSource
                    .Properties.DisplayMember = "vendordesc"
                    .Properties.ValueMember = "branchCode"
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try

                .Properties.DropDownRows = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT from maint_vendor where type LIKE 'branch' order by branchcode asc", "COUNT")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            End With
        End Sub

        Public Sub Initialize_Color()
            mBindData(LUE_Color, $"SELECT * FROM maint_itemcolor order by colordesc asc", "maint_itemcolor")
            '  iCount = RecordCount("SELECT branddesc FROM maint_brand")
        End Sub

        Public Sub Initialize_Color(ByVal barItem As DevExpress.XtraEditors.LookUpEdit)
            With barItem
                Try
                    .Properties.Columns.Clear()
                    .Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("colordesc", "COLOR")}
                    )

                    .Width = 200
                    .Properties.DataSource = LUE_Color.Properties.DataSource
                    .Properties.DisplayMember = "colordesc"
                    .Properties.ValueMember = "id"
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try

                .Properties.DropDownRows = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT from maint_itemcolor order by colordesc asc", "COUNT")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            End With
        End Sub

        Public Sub Initialize_whcode()
            mBindData(LUE_whCode, $"SELECT whid,whcategorycode,whcategorydesc from vw_maint_whcategory_Limited where BranchCode LIKE '{class_Saga_Variables.sBranchCode}'", "vw_maint_whcategory_Limited")
            ' mgProcedure_BindData(LUE_whCode, sProcedureName, parameters, sTable)
        End Sub

        Public Sub Initialize_whcode(ByVal barItem As DevExpress.XtraEditors.LookUpEdit)

            With barItem
                Try
                    .Properties.Columns.Clear()
                    .Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("whid", "ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("whcategorycode", "whcode"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("whcategorydesc", "Description")})

                    .Properties.DataSource = LUE_whCode.Properties.DataSource
                    .Properties.DisplayMember = "whcategorydesc"
                    .Properties.ValueMember = "whcategorycode"
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
                .Width = 200
                .Properties.DropDownRows = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT from vw_maint_whcategory_Limited where BranchCode LIKE '{class_Saga_Variables.sBranchCode}'", "COUNT")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                ' barItem.EditValue = sBranchCode
            End With
        End Sub

        Public Sub Initialize_InvOutReceiver()
            mBindData(LUE_Receivers, $"SELECT * FROM Users where branchcode LIKE '{mVendorCode}' AND IsReceptionist LIKE '1'", "Users")
        End Sub

        Public Sub Initialize_InvOutReceiver(ByVal barItem As DevExpress.XtraEditors.LookUpEdit)
            With barItem
                Try
                    .Properties.Columns.Clear()
                    .Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("username", "Username"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fullname", "NAME"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("designation", "Designation"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("branchcode", "BranchCode")})

                    .Properties.DataSource = LUE_Receivers.Properties.DataSource
                    .Properties.DisplayMember = "fullname"
                    .Properties.ValueMember = "username"
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
                .Width = 200
                .Properties.DropDownRows = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT from Users where branchcode LIKE '{mVendorCode}' AND IsReceptionist LIKE '1'", "COUNT")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                ' barItem.EditValue = sBranchCode
            End With
        End Sub

        Public Sub Initialize_whcodeOutgoing()
            mBindData(LUE_WHOutgoing, $"SELECT * FROM maint_whcategory", "maint_whcategory")
            ' mgProcedure_BindData(LUE_whCode, sProcedureName, parameters, sTable)
        End Sub

        Public Sub Initialize_whcodeOutgoing(ByVal barItem As DevExpress.XtraBars.BarEditItem, ByVal Bwarehouse As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
            barItem.EditWidth = 150
            With Bwarehouse
                Try
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("whcategorycode", "whcode"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("whcategorydesc", "Description")})

                    .DataSource = LUE_WHOutgoing.Properties.DataSource
                    .DisplayMember = "whcategorydesc"
                    .ValueMember = "whcategorycode"
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
                .DropDownRows = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT from maint_whcategory", "COUNT")
                .PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                barItem.EditValue = sBranchCode
            End With
        End Sub

        Public Sub Initialize_whcodeOutgoing(ByVal barItem As DevExpress.XtraEditors.LookUpEdit)

            With barItem
                Try
                    .Properties.Columns.Clear()
                    .Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("whcategorycode", "whcode"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("whcategorydesc", "Description")})

                    .Properties.DataSource = LUE_WHOutgoing.Properties.DataSource
                    .Properties.DisplayMember = "whcategorydesc"
                    .Properties.ValueMember = "whcategorycode"
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
                .Width = 200
                .Properties.DropDownRows = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT from maint_whcategory", "COUNT")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                ' barItem.EditValue = sBranchCode
            End With
        End Sub

        Public Sub Initialize_InvRemarks(ByVal mType As String)
            mBindData(LUE_InvRemarks, $"SELECT * FROM maint_detailremarks where drCategory LIKE '{mType}'", "maint_detailremarks")
            ' mgProcedure_BindData(LUE_whCode, sProcedureName, parameters, sTable)
        End Sub

        Public Sub Initialize_InvRemarks(ByVal mType As String, ByVal barItem As DevExpress.XtraEditors.LookUpEdit)
            With barItem
                Try
                    .Properties.Columns.Clear()
                    .Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("drId", "ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("drDescription", "Description")})

                    .Properties.DataSource = LUE_InvRemarks.Properties.DataSource
                    .Properties.DisplayMember = "drDescription"
                    .Properties.ValueMember = "drId"
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
                .Properties.DropDownRows = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT from maint_detailremarks where drCategory LIKE '{mType}'", "COUNT")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                barItem.EditValue = sBranchCode
            End With
        End Sub

        Public Sub Initialize_AcctStatus()
            mBindData(LUE_MCAccountStatus, $"SELECT * FROM maint_AccountStatus", "maint_AccountStatus")
            ' mgProcedure_BindData(LUE_whCode, sProcedureName, parameters, sTable)
        End Sub

        Public Sub Initialize_AcctStatus(ByVal barItem As DevExpress.XtraBars.BarEditItem, ByVal Bwarehouse As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
            barItem.EditWidth = 150
            With Bwarehouse
                Try
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AcctStatus", "AccountStatus")})

                    .DataSource = LUE_MCAccountStatus.Properties.DataSource
                    .DisplayMember = "AcctStatus"
                    .ValueMember = "id"
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
                .DropDownRows = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT from maint_AccountStatus", "COUNT")
                .PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                barItem.EditValue = sBranchCode
            End With
        End Sub
    End Module
End Namespace