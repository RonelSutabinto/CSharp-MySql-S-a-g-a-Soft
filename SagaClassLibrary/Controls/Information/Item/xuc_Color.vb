Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Namespace Controls.Information.Item

    Public Class xuc_Color
        Inherits DevExpress.XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Database.Fill_Edit(class_Database.ICSConnection, Color, "maint_itemcolor", "Color")
            class_Database.Fill_Edit(class_Database.ICSConnection, Color_Index, "maint_itemcolor", "Color_Index")
            class_Database.Fill_Edit(class_Database.ICSConnection, PNP_LTO_Input, "maint_itemcolor", "PNP_LTO_Input")
            Color.Select()
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = false)
            If bAsk AndAlso Not class_Procedures.actionAsk("New Item Color", "Initialize new Item Color", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bask)
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Color_Code, "maint_itemcolor", "Color_Code", "COLOR-", "id")
            Color.Select()
        End Sub

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", id.EditValue),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_Color_Procedures")
                ID.EditValue = sID
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        Color_Code.Text = myDataReader("Color_Code").ToString
                        Color_Index.Text = myDataReader("Color_Index").ToString
                        Color.Text = myDataReader("Color").ToString
                        ColorDesc.Text = myDataReader("colordesc").ToString
                        PNP_LTO_Input.Text = myDataReader("PNP_LTO_Input").ToString
                        Color_Description.Text = myDataReader("Color_Description").ToString
                        Notes.Text = myDataReader("Notes").ToString
                        Return True
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Control_Save() As Boolean
            If class_Procedures.isEmpty(Color) Then Return False
            If class_Procedures.isEmpty(ColorDesc) Then Return False

            If id.EditValue.Equals(0) Then
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Color_Code, "maint_itemcolor", "Color_Code", "COLOR-", "id")
            End If

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", id.EditValue),
                New SqlParameter("@Color_Code", Color_Code.Text),
                New SqlParameter("@Color_Index", Color_Index.Text.Trim.ToUpper),
                New SqlParameter("@Color", Color.Text.Trim.ToUpper),
                New SqlParameter("@ColorDesc", ColorDesc.Text.Trim.ToUpper),
                New SqlParameter("@PNP_LTO_Input", PNP_LTO_Input.Text.Trim),
                New SqlParameter("@Color_Description", Color_Description.Text.Trim),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE")
            }

            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Color_Procedures", "Color Description", ColorDesc.Text.Trim)
        End Function

        Friend Function Control_Delete() As Boolean

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", id.EditValue),
                New SqlParameter("@Action_Type", "DELETE")
            }

            Return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Color_Procedures", "Delete Color Description", True))
        End Function

        Private Sub LayoutControlItem_Description_DoubleClick(sender As Object, e As EventArgs) Handles LayoutControlItem_Description.DoubleClick
            'Color_Description.Text = $"{model.Text.Trim} - {ColorDesc.Text.Trim}"
        End Sub

    End Class

End Namespace