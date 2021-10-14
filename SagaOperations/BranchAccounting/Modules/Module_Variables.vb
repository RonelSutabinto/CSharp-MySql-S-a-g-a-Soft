Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports wSClassLib.myModules

Namespace Modules
    Module Module_Variables
        Friend isAdmin As Boolean
        'Public sUserName As String
        Friend sError As String

        Friend iBranchCount As Integer = 0

        Friend bSplash As Boolean
        Friend bLoopStop As Boolean
        Friend bNotifications As Boolean

        Friend LUE_Branches As LookUpEdit = New LookUpEdit()
        Public coaAll As LookUpEdit = New LookUpEdit()
        Public coaSummary As LookUpEdit = New LookUpEdit()
        Public coaDetail As LookUpEdit = New LookUpEdit()

        Public MySQLConnection As SqlConnection = New SqlConnection()
        Public myDataAdapter As SqlDataAdapter = New SqlDataAdapter()

        'Friend connectSP As String
        'Friend connectSPareparts As String

        Friend Sub Initialize_Branch()
           Modules.BindData(connectSP, LUE_Branches, "SELECT BranchCode, Pre_Code, Branch FROM BranchParameters ORDER BY BranchCode", "BranchParameters")
            iBranchCount = RecordCount("SELECT BranchCode FROM BranchParameters")
        End Sub

        Friend Sub Initialize_COA_Summary()
           Modules.BindData(connectSP, coaSummary, "SELECT ID, COA_Code, Corporation, COA_Statement, COA_Level, COA_Type, COA_Summary_Name, COA_Name, COA_Desc, COA_Normal FROM view_Chart_Of_Accounts WHERE COA_Type LIKE 'SUMMARY' ORDER BY COA_Name", "view_Chart_Of_Accounts")
        End Sub

        Public Sub Initialize_Branch(ByVal barItem As DevExpress.XtraBars.BarEditItem, ByVal bRanch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
            barItem.EditWidth = 200

            With bRanch
                Try
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchCode", "Code"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pre_Code", "Pre-Code"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch", "Branch Name")})

                    .DataSource = LUE_Branches.Properties.DataSource
                    .DisplayMember = "Branch"
                    .ValueMember = "BranchCode"
                Catch Ex As InvalidOperationException
                Catch Ex As ArgumentException
                End Try

                bRanch.DropDownRows = iBranchCount
                bRanch.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                bRanch.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            End With
        End Sub

        Public Sub Initialize_COA(ByVal cOA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, Optional ByVal sMode As String = "ALL")
            Try
                With cOA
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Type", "Type"),
                            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Level", "Level"),
                            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Code", "Code"),
                            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Name", "Name"),
                            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Summary_Name", "Summary"),
                            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Desc", "Description"),
                            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Statement", "Statement")})

                    .ValueMember = "COA_Code"
                    .DisplayMember = "COA_Name"
                    .NullText = "SELECT Account..."

                    Select Case sMode
                        Case "ALL"
                            .DataSource = coaAll.Properties.DataSource
                        Case "SUMMARY"
                            .DataSource = coaSummary.Properties.DataSource
                        Case "DETAIL"
                            .DataSource = coaDetail.Properties.DataSource
                    End Select

                    .PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
                    .TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
                    .BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                    .DropDownRows = 20
                End With
            Catch Ex As ArgumentException
                Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.ParamName}{Environment.NewLine}{Ex.Message}")
            End Try
        End Sub

    End Module
End Namespace