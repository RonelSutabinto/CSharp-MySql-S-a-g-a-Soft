
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

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

        Public Sub Initialize_Brand(ByVal barItem As DevExpress.XtraEditors.LookUpEdit)

            With barItem
                Try
                    .Properties.Columns.Clear()
                    .Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("branddesc", "Brand")})
                    'New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch", "Branch Name"),
                    'New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DatabaseDate", "Posting Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far)})

                    .Properties.DataSource = LUE_Brand.Properties.DataSource
                    .Properties.DisplayMember = "branddesc"
                    .Properties.ValueMember = "branddesc"
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException

                End Try
                .Width = 200
                .Properties.DropDownRows = class_Database.RecordCount(CentralModule.connectSP, "SELECT branddesc FROM maint_brand")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                ' barItem.EditValue = sBranchCode
            End With
        End Sub
        Public Sub Initialize_Brand(ByVal barItem As DevExpress.XtraBars.BarEditItem, ByVal brand As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
            barItem.EditWidth = 200
            ' barItem.EditValue = sBranchCode

            With brand
                Try
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("branddesc", "Brand")})
                    'New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch", "Branch Name"),
                    'New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DatabaseDate", "Posting Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far)})

                    .DataSource = LUE_Brand.Properties.DataSource
                    .DisplayMember = "branddesc"
                    .ValueMember = "branddesc"
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException

                End Try

                brand.DropDownRows = class_Database.RecordCount(CentralModule.connectSP, "SELECT branddesc FROM maint_brand")
                brand.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                brand.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                ' barItem.EditValue = sBranchCode
            End With
        End Sub

        Public Sub Initialize_Model()
            mBindData(LUE_Model, $"SELECT * from maint_model order by modeldesc asc", "maint_model")
            'iBranchCount = RecordCount("SELECT branddesc FROM maint_brand")
        End Sub
        Public Sub Initialize_Model(ByVal sBrand As String)
            mBindData(LUE_Model, $"SELECT * from maint_model where branddesc like '{sBrand}' order by modeldesc asc", "maint_model")
            'iBranchCount = RecordCount("SELECT branddesc FROM maint_brand")
        End Sub

        Public Sub Initialize_Model(ByVal barItem As DevExpress.XtraEditors.LookUpEdit, ByVal sBrand As String)

            With barItem
                Try
                    .Properties.Columns.Clear()
                    .Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("branddesc", "Brand"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modeldesc", "Model")})
                    'New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch", "Branch Name"),
                    'New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DatabaseDate", "Posting Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far)})
                    .Width = 200
                    .Properties.DataSource = LUE_Model.Properties.DataSource
                    .Properties.DisplayMember = "modeldesc"
                    .Properties.ValueMember = "id"
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException

                End Try

                .Properties.DropDownRows = class_Database.RecordCount(CentralModule.connectSP, $"SELECT * from maint_model where branddesc like '{sBrand}'")
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
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("branddesc", "Brand"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modeldesc", "Model")})

                    .DataSource = LUE_Model.Properties.DataSource
                    .DisplayMember = "modeldesc"
                    .ValueMember = "id"
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException

                End Try

                model.DropDownRows = class_Database.RecordCount(CentralModule.connectSP, $"SELECT * from maint_model where branddesc like '{sBrand}'")
                model.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                model.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                ' barItem.EditValue = sBranchCode
            End With
        End Sub

        Public Function mBindData(ByVal lookUpEdit As LookUpEdit, ByVal sQuery As String, ByVal sTable As String) As Boolean
            Try
                Using ds As DataSet = New DataSet()
                    lookUpEdit.Properties.DataSource = class_Database.BindSource(CentralModule.connectSP, ds, sQuery, sTable)
                    lookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                End Using
                Return True
            Catch Ex As ArgumentException
                class_Procedures.Set_Message(class_Procedures.frm, class_Procedures.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.ParamName}{Environment.NewLine}{Ex.Message}")
                Return False
            Finally
                lookUpEdit.Select()
            End Try
        End Function
        Public Sub Initialize_ToolBars(ByVal xForm As XtraForm, ByVal barManager As BarManager)
            Initialize_ToolBars(barManager)
            'barManager.RestoreLayoutFromRegistry(xForm.Name)
        End Sub
        Public Sub Initialize_ToolBars(ByVal mBar As BarEditItem)
            Initialize_ToolBars(mBar)
            'barManager.RestoreLayoutFromRegistry(xForm.Name)
        End Sub
        Public Sub Initialize_Supplier()
            mBindData(LUE_Supplier, $"SELECT * from maint_vendor where branchCode like '{mBrCode}'", "maint_vendor")
            '  iCount = RecordCount("SELECT branddesc FROM maint_brand")
        End Sub

        Public Sub Initialize_Supplier(ByVal barItem As DevExpress.XtraEditors.LookUpEdit)

            With barItem
                Try
                    .Properties.Columns.Clear()
                    .Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("vendordesc", "Supplier"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Branch Name"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("contactno", "ContactNo")}
                    )

                    .Width = 200
                    .Properties.DataSource = LUE_Supplier.Properties.DataSource
                    .Properties.DisplayMember = "vendordesc"
                    .Properties.ValueMember = "id"
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException

                End Try

                .Properties.DropDownRows = class_Database.RecordCount(CentralModule.connectSP, $"SELECT vendordesc FROM maint_vendor where branchCode like '{mBrCode}'")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            End With
        End Sub
        Public Sub Initialize_Supplier(ByVal barItem As DevExpress.XtraBars.BarEditItem, ByVal Supplier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
            barItem.EditWidth = 200
            With Supplier
                Try
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("vendordesc", "Supplier"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Branch Name"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("contactno", "ContactNo")}
                    )

                    'New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DatabaseDate", "Posting Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far)})

                    .DataSource = LUE_Supplier.Properties.DataSource
                    .DisplayMember = "vendordesc"
                    .ValueMember = "id"
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException

                End Try

                Supplier.DropDownRows = class_Database.RecordCount(CentralModule.connectSP, $"SELECT vendordesc FROM maint_vendor where branchCode like '{mBrCode}'")
                Supplier.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                Supplier.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                ' barItem.EditValue = sBranchCode
            End With
        End Sub
        Public Sub Initialize_IntransitBranch()
            mBindData(LUE_IntransitBranch, $"SELECT * from maint_vendor where type like 'branch' order by branchcode asc", "maint_vendor")
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
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException

                End Try

                .Properties.DropDownRows = class_Database.RecordCount(CentralModule.connectSP, $"SELECT * from maint_vendor where type like 'branch' order by branchcode asc")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            End With
        End Sub
        Public Sub Initialize_Color()
            mBindData(LUE_Color, $"SELECT * from maint_itemcolor order by colordesc asc", "maint_itemcolor")
            '  iCount = RecordCount("SELECT branddesc FROM maint_brand")
        End Sub

        Public Sub Initialize_Color(ByVal barItem As DevExpress.XtraEditors.LookUpEdit)

            With barItem
                Try
                    .Properties.Columns.Clear()
                    .Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("colordesc", "COLOR")}
                    )

                    .Width = 200
                    .Properties.DataSource = LUE_Color.Properties.DataSource
                    .Properties.DisplayMember = "colordesc"
                    .Properties.ValueMember = "id"
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException

                End Try

                .Properties.DropDownRows = class_Database.RecordCount(CentralModule.connectSP, $"SELECT * from maint_itemcolor  order by colordesc asc")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            End With
        End Sub

        ' Public Function Procedure_BindData(ByVal mLookupEdit As DevExpress.XtraEditors.LookUpEdit) As Boolean
        Public Function mgProcedure_BindData(ByVal mLookupEdit As DevExpress.XtraEditors.LookUpEdit,
                                             ByVal sProcedureName As String,
                                             ByVal Parameters As SqlParameter(),
                                             ByVal sTable As String) As Boolean
            'Dim mySQLConnection = New SqlConnection(CentralModule.connectSP)
            'Using MyCommand As SqlCommand = New SqlCommand(sProcedureName, mySQLConnection) With {.CommandType = CommandType.StoredProcedure}
            '    MyCommand.Parameters.AddRange(Parameters)
            '    Try
            '        Dim da As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            '        Dim ds As DataSet = New DataSet()
            '        mySQLConnection.Open()
            '        ds.Clear()
            '        da.Fill(ds)
            '        mLookupEdit.Properties.DataSource = ds
            '    Catch Ex As ArgumentException

            '        class_procedures.Set_Message(class_procedures.frm, class_procedures.MsgMode.Sql, $"{Environment.NewLine}{Ex.Source}{Environment.NewLine}{Ex.Message}")
            '    Catch Ex As InvalidOperationException

            '        class_procedures.Set_Message(class_procedures.frm, class_procedures.MsgMode.Sql, $"{Environment.NewLine}{Ex.Source}{Environment.NewLine}{Ex.Message}")
            '    Catch Ex As SqlException

            '        class_procedures.Set_Message(class_procedures.frm, class_procedures.MsgMode.Sql, $"{Environment.NewLine}{Ex.ErrorCode}{Environment.NewLine}{Ex.Server}{Environment.NewLine}{Ex.Source}-{Ex.Procedure}-{Ex.LineNumber}{Environment.NewLine}{Ex.Message}")
            '    Finally

            '    End Try
            'End Using
            'Return False

            On Error GoTo out
            Dim cmd As New SqlCommand
            Dim rs As SqlDataReader

            cmd.CommandText = sProcedureName
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = SPConnect

            'cmd.Parameters.AddWithValue("@ParamBranchCode", mBrCode)
            cmd.Parameters.AddRange(Parameters)
            SPConnect.Open()

            rs = cmd.ExecuteReader()

            Do While rs.Read
                'cmb_warehouse.Items.Add(rs.Item("WHDesc").ToString())
                'mLookupEdit.Properties.DataSource = rs
                'mLookupEdit.Properties.Columns(rs.Item("WHDesc").ToString())

                ' MsgBox(rs.Item("WHDesc").ToString())

                'mLookupEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                '                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo(rs.Item("WHDesc").ToString()),
                '                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo(rs.Item("WHId").ToString())})
                'mLookupEdit.Properties.DataSource = rs
                mLookupEdit.DataBindings.Add(New Binding("WHId", rs.Item("WHId").ToString(), "WHId"))
                mLookupEdit.DataBindings.Add(New Binding("WHDesc", rs.Item("WHDesc").ToString(), "WHDesc"))
            Loop

            rs.Close()
            SPConnect.Close()

            GoTo outs

out:        MsgBox(Err.Description)

            SPConnect.Close()
            GoTo outs1

outs:
outs1:

        End Function

        Public Sub Initialize_whcode()
            mBindData(LUE_whCode, $"SELECT whid,whcategorycode,whcategorydesc from vw_maint_whcategory_Limited where BranchCode like '{mBrCode}'", "vw_maint_whcategory_Limited")
            ' mgProcedure_BindData(LUE_whCode, sProcedureName, Parameters, sTable)
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
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException

                End Try
                .Width = 200
                .Properties.DropDownRows = class_Database.RecordCount(CentralModule.connectSP, $"SELECT whid,whcategorycode,whcategorydesc from vw_maint_whcategory_Limited where BranchCode like '{mBrCode}'")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                ' barItem.EditValue = sBranchCode
            End With
        End Sub

        Public Function Initialize_AE(txt_Repository As RepositoryItemLookUpEdit, txt_BrCode As String) As Integer
            class_Saga_Variables.Initialize_AE(txt_BrCode)
            'class_Database.BindData(txt_Repository, $"SELECT AccountExecutive,OfficerName FROM AccountExecutives where BranchCode like '{txt_BrCode}' order by AccountExecutive asc", "AccountExecutives")
            Return class_Database.RecordCount(CentralModule.connectSP, "SELECT AccountExecutive,OfficerName FROM AccountExecutives where BranchCode like '" & txt_BrCode & "' ")
        End Function

        Public Sub Initialize_Users()
            mBindData(LUE_Users, "SELECT * FROM Users order by fullname asc", "Users")
        End Sub

        Public Sub Initialize_Users(ByVal barItem As DevExpress.XtraEditors.LookUpEdit)
            With barItem
                Try
                    .Properties.Columns.Clear()
                    .Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("username", "Username"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fullname", "NAME"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("designation", "Designation"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("branchcode", "BranchCode")})

                    .Properties.DataSource = LUE_Users.Properties.DataSource
                    .Properties.DisplayMember = "fullname"
                    .Properties.ValueMember = "username"
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException

                End Try
                .Width = 200
                .Properties.DropDownRows = class_Database.RecordCount(CentralModule.connectSP, $"SELECT * FROM Users order by fullname asc")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                ' barItem.EditValue = sBranchCode
            End With
        End Sub

        Public Sub Initialize_InvOutReceiver()
            mBindData(LUE_Receivers, $"SELECT * from Users where branchcode like '{mVendorCode}' and IsReceptionist like '1'", "Users")
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
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException

                End Try
                .Width = 200
                .Properties.DropDownRows = class_Database.RecordCount(CentralModule.connectSP, $"SELECT * from Users where branchcode like '{mVendorCode}' and IsReceptionist like '1'")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                ' barItem.EditValue = sBranchCode
            End With
        End Sub

        Public Sub Initialize_whcodeOutgoing()
            mBindData(LUE_WHOutgoing, $"SELECT * from maint_whcategory", "maint_whcategory")
            ' mgProcedure_BindData(LUE_whCode, sProcedureName, Parameters, sTable)
        End Sub

        Public Sub Initialize_whcodeOutgoing(ByVal barItem As DevExpress.XtraBars.BarEditItem, ByVal Bwarehouse As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
            barItem.EditWidth = 150
            With Bwarehouse
                Try
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("whcategorycode", "whcode"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("whcategorydesc", "Description")})

                    .DataSource = LUE_WHOutgoing.Properties.DataSource
                    .DisplayMember = "whcategorydesc"
                    .ValueMember = "whcategorycode"
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException

                End Try
                .DropDownRows = class_Database.RecordCount(CentralModule.connectSP, $"SELECT * from maint_whcategory")
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
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("whcategorycode", "whcode"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("whcategorydesc", "Description")})

                    .Properties.DataSource = LUE_WHOutgoing.Properties.DataSource
                    .Properties.DisplayMember = "whcategorydesc"
                    .Properties.ValueMember = "whcategorycode"
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException

                End Try
                .Width = 200
                .Properties.DropDownRows = class_Database.RecordCount(CentralModule.connectSP, $"SELECT * from maint_whcategory")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                ' barItem.EditValue = sBranchCode
            End With
        End Sub

        Public Sub Initialize_InvRemarks(ByVal mType As String)
            mBindData(LUE_InvRemarks, $"SELECT * from maint_detailremarks where drCategory like '{mType}'", "maint_detailremarks")
            ' mgProcedure_BindData(LUE_whCode, sProcedureName, Parameters, sTable)
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
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException

                End Try
                .Properties.DropDownRows = class_Database.RecordCount(CentralModule.connectSP, $"SELECT * from maint_detailremarks where drCategory like '{mType}'")
                .Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                barItem.EditValue = sBranchCode
            End With
        End Sub

        Public Sub Initialize_AcctStatus()
            mBindData(LUE_MCAccountStatus, $"SELECT * from maint_AccountStatus", "maint_AccountStatus")
            ' mgProcedure_BindData(LUE_whCode, sProcedureName, Parameters, sTable)
        End Sub
        Public Sub Initialize_AcctStatus(ByVal barItem As DevExpress.XtraBars.BarEditItem, ByVal Bwarehouse As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
            barItem.EditWidth = 150
            With Bwarehouse
                Try
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AcctStatus", "AccountStatus")})

                    .DataSource = LUE_MCAccountStatus.Properties.DataSource
                    .DisplayMember = "AcctStatus"
                    .ValueMember = "id"
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException

                End Try
                .DropDownRows = class_Database.RecordCount(CentralModule.connectSP, $"SELECT * from maint_AccountStatus")
                .PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                .BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                barItem.EditValue = sBranchCode
            End With
        End Sub
        Public Sub Initialize_ToolBars(ByVal barManager As BarManager)
            Dim xIconForm As New XtraForm1

            'For Each item In barManager.RepositoryItems
            '    If item.GetType = GetType(RepositoryItemDateEdit) Then
            '        CType(item, RepositoryItemDateEdit).Appearance.Options.UseTextOptions = True
            '        CType(item, RepositoryItemDateEdit).Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            '        'CType(item, RepositoryItemDateEdit).CalendarView = CalendarView.Default
            '        CType(item, RepositoryItemDateEdit).DisplayFormat.FormatString = "MMMM dd, yyyy"
            '        CType(item, RepositoryItemDateEdit).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            '        CType(item, RepositoryItemDateEdit).EditFormat.FormatString = "MMMM dd, yyyy"
            '        CType(item, RepositoryItemDateEdit).EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            '        CType(item, RepositoryItemDateEdit).Mask.EditMask = "MMMM dd, yyyy"
            '        CType(item, RepositoryItemDateEdit).Mask.UseMaskAsDisplayFormat = True
            '    End If
            'Next

            For Each item In barManager.Items
                If item.GetType = GetType(BarCheckItem) Then
                    CType(item, BarCheckItem).PaintStyle = BarItemPaintStyle.CaptionGlyph
                    CType(item, BarCheckItem).Hint = "Click Button To Set On/Off To affect data display/process"

                ElseIf item.GetType = GetType(BarToggleSwitchItem) Then
                    CType(item, BarToggleSwitchItem).PaintStyle = BarItemPaintStyle.CaptionGlyph
                    Select Case CType(item, BarToggleSwitchItem).Name
                        Case "BarToggleSwitchItem_Any_Date"
                            CType(item, BarToggleSwitchItem).Caption = "An&y Date"
                            CType(item, BarToggleSwitchItem).Hint = "Enable To Search at any Date."
                            CType(item, BarToggleSwitchItem).ItemShortcut = New BarShortcut(Keys.Alt Or Keys.Y)
                            CType(item, BarToggleSwitchItem).ImageOptions.Image = xIconForm.BarToggleSwitchItem_Any_Date.ImageOptions.Image
                            CType(item, BarToggleSwitchItem).ImageOptions.LargeImage = xIconForm.BarToggleSwitchItem_Any_Date.ImageOptions.LargeImage
                    End Select

                ElseIf item.GetType = GetType(BarButtonItem) Then
                    CType(item, BarButtonItem).PaintStyle = BarItemPaintStyle.CaptionGlyph
                    Select Case CType(item, BarButtonItem).Name
                        Case "Btn_Account"
                            CType(item, BarButtonItem).Caption = "&Account"
                            CType(item, BarButtonItem).Hint = "Show account information"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Alt Or Keys.A)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Account.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Account.ImageOptions.LargeImage

                        Case "Btn_Collections"
                            CType(item, BarButtonItem).Caption = "Collections"
                            CType(item, BarButtonItem).Hint = "Show Collections"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Collections.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Collections.ImageOptions.LargeImage

                        'SQL Server Connection
                        Case "Btn_Refresh_Connection"
                            CType(item, BarButtonItem).Caption = "Re&fresh Connection"
                            CType(item, BarButtonItem).Hint = "Refresh/Check SQL Database connection"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Alt Or Keys.F)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Refresh_Connection.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Refresh_Connection.ImageOptions.LargeImage

                        Case "Btn_Test_Connection"
                            CType(item, BarButtonItem).Caption = "Test Connection"
                            CType(item, BarButtonItem).Hint = "Test/Check SQL Database connection Using specified parameters"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.F5)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Refresh_Connection.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Refresh_Connection.ImageOptions.LargeImage

                        Case "Btn_Connect_Close"
                            CType(item, BarButtonItem).Caption = "Connect And Close"
                            CType(item, BarButtonItem).Hint = "Connect SQL Database And close the form"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.F5)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_OK.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_OK.ImageOptions.LargeImage

                            'Primary Actions
                        Case "Btn_Import"
                            CType(item, BarButtonItem).Caption = "Import"
                            CType(item, BarButtonItem).Hint = "Import data into GridView"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Import.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Import.ImageOptions.LargeImage

                        Case "Btn_Initialize"
                            CType(item, BarButtonItem).Caption = "Initiali&ze"
                            CType(item, BarButtonItem).Hint = "Initialize data On some text controls"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Alt Or Keys.Z)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Initialize.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Initialize.ImageOptions.LargeImage

                        Case "Btn_Reset"
                            CType(item, BarButtonItem).Caption = "Reset"
                            CType(item, BarButtonItem).Hint = "Reset controls (bar, dock, gridview etc.)"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Reset.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Reset.ImageOptions.LargeImage
                            CType(item, BarButtonItem).Visibility = BarItemVisibility.OnlyInCustomizing

                        Case "Btn_Reload"
                            CType(item, BarButtonItem).Caption = "&Reload"
                            CType(item, BarButtonItem).Hint = "Load Or refresh data On Gridview Table"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.F5)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Reload.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Reload.ImageOptions.LargeImage

                        Case "Btn_Preview"
                            CType(item, BarButtonItem).Caption = "&Preview"
                            CType(item, BarButtonItem).Hint = "Display data from Gridview Table To Print Preview"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.V)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Preview.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Preview.ImageOptions.LargeImage

                        Case "Btn_Print_Check"
                            CType(item, BarButtonItem).Caption = "Print Check"
                            CType(item, BarButtonItem).Hint = "Print check With Payee And Amount"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.H)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Print_Check.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Print_Check.ImageOptions.LargeImage

                        Case "Btn_New"
                            CType(item, BarButtonItem).Caption = "&New"
                            CType(item, BarButtonItem).Hint = "Prepare controls To input New data"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.N)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_New.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_New.ImageOptions.LargeImage

                        Case "Btn_Save"
                            CType(item, BarButtonItem).Caption = "&Save"
                            CType(item, BarButtonItem).Hint = "Save data With input values"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.S)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Save.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Save.ImageOptions.LargeImage

                        Case "Btn_Save_New"
                            CType(item, BarButtonItem).Caption = "Save And New"
                            CType(item, BarButtonItem).Hint = "Save data And Then prepare New entry"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.N)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Save_New.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Save_New.ImageOptions.LargeImage

                        Case "Btn_Save_Close"
                            CType(item, BarButtonItem).Caption = "Save And Close"
                            CType(item, BarButtonItem).Hint = "Save data Then Closes the current Window Form"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.S)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Save_Close.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Save_Close.ImageOptions.LargeImage

                        Case "Btn_Update"
                            CType(item, BarButtonItem).Caption = "&Update"
                            CType(item, BarButtonItem).Hint = "Update Or overwrite existing data With New values"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.U)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Update.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Update.ImageOptions.LargeImage

                        Case "Btn_Delete"
                            CType(item, BarButtonItem).Caption = "&Delete"
                            CType(item, BarButtonItem).Hint = "Delete, Cancel Or Remove selected data"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.D)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Delete.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Delete.ImageOptions.LargeImage

                        Case "Btn_Delete_For"
                            CType(item, BarButtonItem).Caption = "&For Delete"
                            CType(item, BarButtonItem).Hint = "Send selected row(s) 'For Delete' to Admin"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.D)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Delete_For.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Delete_For.ImageOptions.LargeImage

                        Case "Btn_Delete_Close"
                            CType(item, BarButtonItem).Caption = "&Delete and Close"
                            CType(item, BarButtonItem).Hint = "Delete, Cancel or Remove selected data and Close the form"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.D)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Delete.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Delete.ImageOptions.LargeImage

                        Case "Btn_Close"
                            CType(item, BarButtonItem).Caption = "&Close"
                            CType(item, BarButtonItem).Hint = "Closes the Window Form"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Alt Or Keys.C)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Close.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Close.ImageOptions.LargeImage

                        Case "Btn_Cancel"
                            CType(item, BarButtonItem).Caption = "Cancel"
                            CType(item, BarButtonItem).Hint = "Cancel the current data record"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.C)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Cancel.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Cancel.ImageOptions.LargeImage

                            'Status
                        Case "Btn_Pending"
                            CType(item, BarButtonItem).Caption = "&Pending"
                            CType(item, BarButtonItem).Hint = "Load pending transactions to Gridview Table"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.F5)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Pending.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Pending.ImageOptions.LargeImage

                        Case "Btn_Approval"
                            CType(item, BarButtonItem).Caption = "Approval"
                            CType(item, BarButtonItem).Hint = "Send selected row(s) 'For Approval' to Approver"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.P)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Approval.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Approval.ImageOptions.LargeImage

                        Case "Btn_Approve"
                            CType(item, BarButtonItem).Caption = "Approve"
                            CType(item, BarButtonItem).Hint = "Approve 'For Approval' selected row(s)"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Approve.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Approve.ImageOptions.LargeImage

                        Case "Btn_DisApprove"
                            CType(item, BarButtonItem).Caption = "Disapprove"
                            CType(item, BarButtonItem).Hint = "Disapprove 'For Approval' selected row(s)"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_DisApprove.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_DisApprove.ImageOptions.LargeImage

                        Case "Btn_Password_Reset"
                            CType(item, BarButtonItem).Caption = "Password Reset"
                            CType(item, BarButtonItem).Hint = "Reset user password"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Password_Reset.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Password_Reset.ImageOptions.LargeImage

                        Case "Btn_Lock"
                            CType(item, BarButtonItem).Caption = "Lock/Unlock"
                            CType(item, BarButtonItem).Hint = "Lock data update permission"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Lock.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Lock.ImageOptions.LargeImage

                            'Custom Query
                        Case "Btn_Generate"
                            CType(item, BarButtonItem).Caption = "&Generate"
                            CType(item, BarButtonItem).Hint = "Generate SQL Query for execution"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.F5)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Generate.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Generate.ImageOptions.LargeImage

                        Case "Btn_Execute"
                            CType(item, BarButtonItem).Caption = "Execute"
                            CType(item, BarButtonItem).Hint = "Execute command to process data"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.F5)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Execute.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Execute.ImageOptions.LargeImage

                            'Checks
                        Case "Btn_Link"
                            CType(item, BarButtonItem).Caption = "Link"
                            CType(item, BarButtonItem).Hint = "Link selected transaction accross other transactions"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.Shift) Or Keys.L)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Link.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Link.ImageOptions.LargeImage

                            'Chart of Accounts
                        Case "Btn_Convert_Summary"
                            CType(item, BarButtonItem).Caption = "Convert to Summary"
                            CType(item, BarButtonItem).Hint = "Convert selected Detail COA into Summary"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.T)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Convert_Summary.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Convert_Summary.ImageOptions.LargeImage

                        Case "Btn_Insert"
                            CType(item, BarButtonItem).Caption = "Insert"
                            CType(item, BarButtonItem).Hint = "Insert New Entry (Auto-increment Code)"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.Insert)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Insert.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Insert.ImageOptions.LargeImage

                        Case "Btn_Another_Entry"
                            CType(item, BarButtonItem).Caption = "Another Entr&y"
                            CType(item, BarButtonItem).Hint = "Input another entry (ID Code Auto-increment)"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.Y)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Another_Entry.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Another_Entry.ImageOptions.LargeImage

                            'Tree List view
                        Case "Btn_Expand"
                            CType(item, BarButtonItem).Caption = "Expand"
                            CType(item, BarButtonItem).Hint = "Expand the Tree List view"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.Add)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Expand.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Expand.ImageOptions.LargeImage

                        Case "Btn_Collapse"
                            CType(item, BarButtonItem).Caption = "Collapse"
                            CType(item, BarButtonItem).Hint = "Collapse the Tree List view"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.Subtract)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Collapse.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Collapse.ImageOptions.LargeImage

                            'Journal
                        Case "Btn_Journal"
                            CType(item, BarButtonItem).Caption = "&Journal"
                            CType(item, BarButtonItem).Hint = "Convert selected transaction into Journal Entries"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.F6)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Journal.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Journal.ImageOptions.LargeImage

                        Case "Btn_Journal_Entries"
                            CType(item, BarButtonItem).Caption = "&Journal Entries"
                            CType(item, BarButtonItem).Hint = "Show Journal Entries of the selected trasaction"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.F6)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Journal_Entries.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Journal_Entries.ImageOptions.LargeImage

                        Case "Btn_COA_Ledger", "Btn_Ledger", "Btn_Payments"
                            CType(item, BarButtonItem).Caption = CType(item, BarButtonItem).Name.Substring(4)
                            CType(item, BarButtonItem).Hint = $"Show {CType(item, BarButtonItem).Name.Substring(4)}"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.F7)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_COA_Ledger.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_COA_Ledger.ImageOptions.LargeImage

                        Case "Btn_Validate"
                            CType(item, BarButtonItem).Caption = "&Validate"
                            CType(item, BarButtonItem).Hint = "Validate the data in Gridview Table and check for errors"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Alt Or Keys.V)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Validate.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Validate.ImageOptions.LargeImage

                        Case "Btn_Verify"
                            CType(item, BarButtonItem).Caption = "Verify"
                            CType(item, BarButtonItem).Hint = "Verify transactions if IsJournal"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.F8)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Verify.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Verify.ImageOptions.LargeImage

                        Case "Btn_Stop"
                            CType(item, BarButtonItem).Caption = "S&top"
                            CType(item, BarButtonItem).Hint = "Stop or Halt the current looping process"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Alt Or Keys.S)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Stop.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Stop.ImageOptions.LargeImage

                            'Trial Balance
                        Case "Btn_Trial_Balance"
                            CType(item, BarButtonItem).Caption = "Update Trial Balance"
                            CType(item, BarButtonItem).Hint = "Update Trial Balance of the selected row(s)"
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Trial_Balance.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Trial_Balance.ImageOptions.LargeImage

                        Case "Btn_Generate"
                            CType(item, BarButtonItem).Caption = "&Generate"
                            CType(item, BarButtonItem).Hint = "Generate data in Gridview Table"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.G)

                        Case "Btn_Summary"
                            CType(item, BarButtonItem).Caption = "Su&mmary"
                            CType(item, BarButtonItem).Hint = "Update journal summary from Gridview Table"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.M)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Summary.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Summary.ImageOptions.LargeImage

                            'Filter
                        Case "Btn_Filter_Load"
                            CType(item, BarButtonItem).Caption = "Filter &Load"
                            CType(item, BarButtonItem).Hint = "Rearrange/Format Gridview Table from the selected Filter Profile"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.L)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Filter_Load.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Filter_Load.ImageOptions.LargeImage

                        Case "Btn_Filter_Save"
                            CType(item, BarButtonItem).Caption = "Filter &Save"
                            CType(item, BarButtonItem).Hint = "Save Gridview Table arrangements/format to the selected Filter Profile"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.S)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Filter_Save.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Filter_Save.ImageOptions.LargeImage

                        Case "Btn_Filter_Delete"
                            CType(item, BarButtonItem).Caption = "Filter &Delete"
                            CType(item, BarButtonItem).Hint = "Delete selected Filter Profile"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut((Keys.Control Or Keys.F) Or Keys.D)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Filter_Delete.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Filter_Delete.ImageOptions.LargeImage

                            'Custom
                        Case "Btn_Regenerate_Codes"
                            CType(item, BarButtonItem).Caption = "Regenerate Codes"
                            CType(item, BarButtonItem).Hint = "Regenerate/Repair Codes to avoid Primary Key Error"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.G)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Regenerate_Codes.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Regenerate_Codes.ImageOptions.LargeImage

                        Case "Btn_History"
                            CType(item, BarButtonItem).Caption = "History"
                            CType(item, BarButtonItem).Hint = "Check the Activity History of the selected item"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.H)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_History.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_History.ImageOptions.LargeImage
                        Case "Btn_Send"
                            CType(item, BarButtonItem).Caption = "Approval"
                            CType(item, BarButtonItem).Hint = "Send Application for Approval"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.R)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_Send.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_Send.ImageOptions.LargeImage
                        Case "Btn_BatchImport"
                            CType(item, BarButtonItem).Caption = "Import"
                            CType(item, BarButtonItem).Hint = "Batch Import to Grid"
                            CType(item, BarButtonItem).ItemShortcut = New BarShortcut(Keys.Control Or Keys.R)
                            CType(item, BarButtonItem).ImageOptions.Image = xIconForm.Btn_BatchImport.ImageOptions.Image
                            CType(item, BarButtonItem).ImageOptions.LargeImage = xIconForm.Btn_BatchImport.ImageOptions.LargeImage


                    End Select

                ElseIf item.GetType = GetType(BarEditItem) Then
                    CType(item, BarEditItem).PaintStyle = BarItemPaintStyle.CaptionGlyph
                    Select Case CType(item, BarEditItem).Name
                        Case "BarEditItem_Branch"
                            CType(item, BarEditItem).Caption = "Branch"
                            CType(item, BarEditItem).Hint = "Select Branch"
                            CType(item, BarEditItem).ImageOptions.Image = xIconForm.BarEditItem_Branch.ImageOptions.Image
                            CType(item, BarEditItem).ImageOptions.LargeImage = xIconForm.BarEditItem_Branch.ImageOptions.LargeImage

                        Case "BarEditItem_Search"
                            CType(item, BarEditItem).Caption = "Search"
                            CType(item, BarEditItem).EditWidth = 150
                            CType(item, BarEditItem).Hint = "Search any string and show results in GridView"
                            CType(item, BarEditItem).ImageOptions.Image = xIconForm.BarEditItem_Search.ImageOptions.Image
                            CType(item, BarEditItem).ImageOptions.LargeImage = xIconForm.BarEditItem_Search.ImageOptions.LargeImage
                        Case "BarEditItem_Warehouse"
                            CType(item, BarEditItem).Caption = "Warehouse"
                            CType(item, BarEditItem).EditWidth = 150
                            CType(item, BarEditItem).Hint = "Select warehouse category"
                            CType(item, BarEditItem).ImageOptions.Image = xIconForm.BarEditItem_Warehouse.ImageOptions.Image
                            CType(item, BarEditItem).ImageOptions.LargeImage = xIconForm.BarEditItem_Warehouse.ImageOptions.LargeImage
                        Case "BarEditItem_AccountStatus"
                            CType(item, BarEditItem).Caption = "AccountStatus"
                            CType(item, BarEditItem).EditWidth = 150
                            CType(item, BarEditItem).Hint = "Select Account Status"
                            CType(item, BarEditItem).ImageOptions.Image = xIconForm.BarEditItem_AccountStatus.ImageOptions.Image
                            CType(item, BarEditItem).ImageOptions.LargeImage = xIconForm.BarEditItem_AccountStatus.ImageOptions.LargeImage

                        Case "BarEditItem_Posting_Date", "BarEditItem_Start", "BarEditItem_End", "BarEditItem_CutOff"
                            Select Case CType(item, BarEditItem).Name
                                Case "BarEditItem_Posting_Date"
                                    CType(item, BarEditItem).Caption = "Posting Date"
                                    CType(item, BarEditItem).Hint = "Custom Posting Date for Journal Entry"

                                Case "BarEditItem_Start"
                                    CType(item, BarEditItem).Caption = "Date Start"
                                    CType(item, BarEditItem).Hint = "Set starting date"

                                Case "BarEditItem_End"
                                    CType(item, BarEditItem).Caption = "Date End"
                                    CType(item, BarEditItem).Hint = "Set ending date"
                                Case "BarEditItem_CutOff"
                                    CType(item, BarEditItem).Caption = "CutOffDate"
                                    CType(item, BarEditItem).Hint = "Select CutOffDate"
                            End Select

                            CType(item, BarEditItem).EditWidth = 120
                            CType(item, BarEditItem).EditValue = Date.Today

                        Case "BarEditItem_Filter"
                            CType(item, BarEditItem).Caption = "Filter"
                            CType(item, BarEditItem).EditWidth = 150
                            CType(item, BarEditItem).Hint = "Select and manage Gridview Table query result filter"
                            CType(item, BarEditItem).ImageOptions.Image = xIconForm.BarEditItem_Filter.ImageOptions.Image
                            CType(item, BarEditItem).ImageOptions.LargeImage = xIconForm.BarEditItem_Filter.ImageOptions.LargeImage

                        Case "BarEditItem_Document_Title"
                            CType(item, BarEditItem).Caption = "Document Title"
                            CType(item, BarEditItem).Hint = "Document Title for Report Printing"

                        Case "BarEditItem_Remarks"
                            CType(item, BarEditItem).Caption = "Remarks"
                            CType(item, BarEditItem).Hint = "Remarks information for current transaction"

                    End Select

                End If
            Next
        End Sub

        'Public Sub Initialize_Button(ByVal mButton As SimpleButton)
        '    Initialize_ToolBars(mBar)
        '    'barManager.RestoreLayoutFromRegistry(xForm.Name)
        'End Sub
        Public Sub Initialize_Button(ByVal mButton As SimpleButton)
            Dim mIconForm As New XtraForm1

            Select Case mButton.Name
                Case "FrmBtn_Export_to_Grid"
                    mButton.Text = "&Export to Grid"
                    mButton.ToolTip = "Export data to Grid"
                    mButton.ImageOptions.Image = mIconForm.FrmBtn_Export_to_Grid.ImageOptions.Image
                    mButton.ImageOptions.ImageToTextAlignment = ImageAlignToText.RightCenter
            End Select
        End Sub
        Public Sub Initialize_Button(ByVal mLayout As Control)
            Dim mIconForm As New XtraForm1
            For Each miTem In mLayout.Controls
                If miTem.GetType = GetType(SimpleButton) Then
                    Select Case CType(miTem, SimpleButton).Name
                        Case "FrmBtn_Export_to_Grid"
                            miTem.Text = "&Export to Grid"
                            miTem.ToolTip = "Export data to Grid"
                            miTem.ImageOptions.Image = mIconForm.FrmBtn_Export_to_Grid.ImageOptions.Image
                            miTem.ImageOptions.ImageToTextAlignment = ImageAlignToText.RightCenter
                        Case "FrmBtn_Find_Account"
                            miTem.Text = "&Find"
                            miTem.ToolTip = "Find Account"
                            miTem.ImageOptions.Image = mIconForm.Btn_Account.ImageOptions.Image
                            miTem.ImageOptions.ImageToTextAlignment = ImageAlignToText.RightCenter
                        Case "FrmBtn_Update"
                            miTem.Text = "&Update"
                            miTem.ToolTip = "Update Data"
                            miTem.ImageOptions.Image = mIconForm.Btn_Update.ImageOptions.Image
                            miTem.ImageOptions.ImageToTextAlignment = ImageAlignToText.RightCenter
                    End Select

                End If

                For Each subControls As Control In miTem.Controls
                    Initialize_Button(subControls)
                Next
            Next



        End Sub
    End Module
End Namespace