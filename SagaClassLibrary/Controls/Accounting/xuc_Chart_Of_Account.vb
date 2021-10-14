Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Accounting

    Public Class xuc_Chart_Of_Account
        Inherits DevExpress.XtraEditors.XtraUserControl

        Friend sOldCOACode As String

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Saga_Variables.Initialize_COA()
            class_Saga_Variables.Initialize_COA_Summary()
            class_Saga_Variables.Initialize_COA_Detail()
            class_Saga_Procedures.Initialize_COA(COA_Summary, eCOA_Type.COA_Summary)
            class_Saga_Procedures.Initialize_Corporation(Corporation, True)

            class_Database.Fill_Edit(class_Database.ICSConnection, COA_Statement, "acc_Chart_Of_Accounts", "COA_Statement")

            COA_Code.ReadOnly = False
        End Sub

        Friend Function Control_Retrieve(ByVal sCode As String) As Boolean
            COA_Code.Text = sCode
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@COA_Code", sCode),
                New SqlParameter("@Action_Type", "GET")
            }
            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_COA_Procedures")
                Try
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        ID.EditValue = myDataReader("ID").ToString
                        Corporation.EditValue = myDataReader("Corporation").ToString
                        COA_Statement.Text = myDataReader("COA_Statement").ToString
                        COA_Level.Text = myDataReader("COA_Level").ToString
                        COA_Type.Text = myDataReader("COA_Type").ToString
                        COA_Name.Text = myDataReader("COA_Name").ToString
                        FS_Name.Text = myDataReader("FS_Name").ToString
                        COA_Summary.EditValue = myDataReader("COA_Summary").ToString
                        COA_Desc.Text = myDataReader("COA_Desc").ToString
                        COA_Normal.Text = myDataReader("COA_Normal").ToString
                        Notes.Text = myDataReader("Notes").ToString
                        IsFS.Checked = Convert.ToBoolean(myDataReader("IsFS"))
                        IsLedger.Checked = Convert.ToBoolean(myDataReader("IsLedger"))
                        Balance_Date.EditValue = Convert.ToDateTime(myDataReader("Balance_Date"))
                        Balance.Value = convert.todecimal(myDataReader("Balance"))
                        Balance_Limit.Value = convert.todecimal(myDataReader("Balance_Limit"))
                        Balance_Running.Value = convert.todecimal(myDataReader("Balance_Running"))
                    End If
                Catch ex As Exception
                    Return class_Procedures.Show_Error(ex)
                End Try
            End Using
            Return False
        End Function

        Friend Sub Control_New(ByVal bNew As Boolean)
            class_Procedures.Initialize_Controls(Me, bNew)
            COA_Code.Select()
        End Sub

        Friend Function Control_Another_Entry() As Boolean
            Try
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@COA_Summary", COA_Summary.EditValue),
                    New SqlParameter("@Action_Type", "GET_MAX_COA")
                }
                Dim iCOACodeNext As Integer = class_Database.Procedure_Get(class_Database.ICSConnection, sqlParameters, "acc_COA_Procedures", "COA_Code")
                COA_Code.EditValue = iCOACodeNext + 1

                Return Convert.ToBoolean(iCOACodeNext)
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
                Return COA_Code.EditValue + 1
            End Try
        End Function

        Friend Function Control_Save(ByVal sCode As String, Optional ByVal bSaveByID As Boolean = False) As Boolean
            Dim sActionType As String

            If class_Procedures.isEmpty(COA_Code) Then Return False
            If class_Procedures.isEmpty(Corporation) Then Return False
            If class_Procedures.isEmpty(COA_Statement) Then Return False
            If class_Procedures.isEmpty(COA_Level) Then Return False
            If class_Procedures.isEmpty(COA_Type) Then Return False
            If class_Procedures.isEmpty(COA_Name) Then Return False

            If class_Database.Data_Is_Locked(class_Database.ICSConnection, "Account Title", "acc_Chart_Of_Accounts", "COA_Code", sCode) Then Return False

            If COA_Summary.Text.Equals(String.Empty) Then COA_Summary.EditValue = "0"

            If bSaveByID Then
                sActionType = "SAVE_BY_ID"
            Else
                sActionType = "SAVE_BY_CODE"
            End If

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@COA_Code", COA_Code.Text.Trim),
                New SqlParameter("@Corporation", Corporation.EditValue.ToString),
                New SqlParameter("@COA_Statement", COA_Statement.Text.Trim),
                New SqlParameter("@COA_Level", COA_Level.Value),
                New SqlParameter("@COA_Type", COA_Type.Text.Trim),
                New SqlParameter("@COA_Summary", COA_Summary.EditValue),
                New SqlParameter("@COA_Name", COA_Name.Text.Trim),
                New SqlParameter("@FS_Name", FS_Name.Text.Trim),
                New SqlParameter("@COA_Desc", COA_Desc.Text.Trim),
                New SqlParameter("@COA_Normal", COA_Normal.Text.Trim),
                New SqlParameter("@IsFS", IsFS.Checked),
                New SqlParameter("@IsLedger", IsLedger.Checked),
                New SqlParameter("@Balance_Limit", Convert.ToDecimal(Balance_Limit.Value)),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", sActionType)
            }

            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_COA_Procedures", "Account Title", COA_Code.Text.Trim)

            class_Saga_Variables.Initialize_COA()
            class_Saga_Variables.Initialize_COA_Summary()
            class_Saga_Variables.Initialize_COA_Detail()

            Return True
        End Function

        Friend Function control_Lock(ByVal sCOACode As String, ByVal bLock As Boolean, Optional ByVal bAsk As Boolean = True) As Integer
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@COA_Code", sCOACode),
                New SqlParameter("@IsLocked", bLock),
                New SqlParameter("@Locked_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "LOCK")
            }

            Return class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_COA_Procedures", "Account Lock/Unlock", bAsk)
        End Function

        Friend Function control_FS(ByVal sCOACode As String, ByVal bFS As Boolean, Optional ByVal bAsk As Boolean = True) As Integer
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@COA_Code", sCOACode),
                New SqlParameter("@IsFS", bFS),
                New SqlParameter("@Action_Type", "FS")
            }

            Return class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_COA_Procedures", "Show/Unshow Account Title", bAsk)
        End Function

        Friend Function control_Delete() As Boolean
            If class_Database.Data_Is_Locked(class_Database.ICSConnection, "Account Title", "acc_Chart_Of_Accounts", "COA_Code", COA_Code.Text.Trim) Then Return False
            If Not class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT COA_Code FROM acc_Journal_Entries WHERE COA_Code LIKE '{COA_Code.Text}'") Then
                Return class_Database.Query_Execute(class_Database.ICSConnection, $"DELETE FROM acc_Chart_Of_Accounts WHERE COA_Code LIKE '{COA_Code.Text}'", True, "DELETE COA")
            Else
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Cannot delete this Account Title Profile because there is/are transactions under this code.", "Delete Error", True)
                Return False
            End If
        End Function

        Private Sub COA_Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles COA_Code.KeyDown
            If (Not class_Procedures.isEmpty(COA_Code)) AndAlso (e.KeyCode = System.Windows.Forms.Keys.Enter) AndAlso check_Auto_Level.IsOn Then
                COA_Level.Value = COA_Code.Text.Length
            End If
        End Sub

        Friend Sub COA_Summary_Load()
            Dim sLevel As String = (COA_Level.Value - 1).ToString

            If COA_Level.Value > 0 Then
                class_Database.Bind_Data(class_Database.ICSConnection, COA_Summary, $"SELECT * FROM acc_Chart_Of_Accounts WHERE COA_Type LIKE 'SUMMARY' AND COA_Level LIKE '{sLevel}' ORDER BY COA_Name ASC", "acc_Chart_Of_Accounts")
            End If
        End Sub

        Private Sub COA_Level_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles COA_Level.KeyDown
            If e.KeyCode = System.Windows.Forms.Keys.Enter Then
                'COA_Summary_Load()
            End If
        End Sub

        Private Sub COA_Summary_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles COA_Summary.ButtonClick
            If e.Button.Index.Equals(1) Then COA_Summary.EditValue = 0
        End Sub

        Private Sub COA_Name_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles COA_Name.ButtonClick
            If class_Functions.IsUpperCase(COA_Name.Text) Then
                COA_Name.Text = StrConv(COA_Name.Text, VbStrConv.ProperCase)
            Else
                COA_Name.Text = COA_Name.Text.ToUpper()
            End If

        End Sub

        Private Sub COA_Code_EditValueChanged(sender As Object, e As EventArgs) Handles COA_Code.EditValueChanged
            If check_Auto_Level.IsOn Then COA_Level.Value = Convert.ToInt32(COA_Code.Text.Length / 2)
        End Sub

    End Class

End Namespace