Imports DevExpress
Imports DevExpress.Skins
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules

Namespace Classes
    Module class_Saga_Procedures

        Public bStop As Boolean

        Public Sub Initialize_PartsNumber(ByVal model As RepositoryItemLookUpEdit)
            With model
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsName", String.Empty, -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsNumber", "Parts Number"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category", "Category", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default)})

                .DataSource = class_Operation_Variables.partsNumber.Properties.DataSource
                .DisplayMember = "PartsNumber"
                .ValueMember = "PartsNumber"
                .NullValuePrompt = "Select Parts Number..."
            End With
        End Sub

        Public Sub Initialize_Spare_Parts(ByVal Spare_Parts As LookUpEdit)
            Try
                With Spare_Parts.Properties
                    .Columns.Clear()
                    .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                    New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ReceivingBranch", "BranchCode", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                    New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Unit", "Unit", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                    New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsNumber", "Parts Number"),
                                    New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Quantity", "Quantity"),
                                    New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsName", "Parts Name", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                    New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitPrice", "Unit Price", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                    New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRP", "SRP", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                    New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SPCostWoVAT", "SPCostWoVAT", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                                    New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default)})

                    .DataSource = class_Operation_Variables.Spare_Parts.Properties.DataSource
                    .DisplayMember = "PartsNumber"
                    .ValueMember = "PartsNumber"
                    .NullValuePrompt = "Input Parts Number..."
                End With
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub
    End Module
End Namespace