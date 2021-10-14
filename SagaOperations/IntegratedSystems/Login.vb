Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class Login
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(class_Tools.RegKeyGet("Application", "Skin", "The Bezier"))
        If class_Tools.RegKeyGet("Application", "Skin", String.Empty) = "The Bezier" Or class_Tools.RegKeyGet("Application", "Skin", String.Empty) = "Basic" Then
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(class_Tools.RegKeyGet("Application", "Skin", "The Bezier"), class_Tools.RegKeyGet("Application", "Pallete", "Default"))
        End If

        User_Name.Text = class_Tools.Decrypt(class_Tools.RegKeyGet(Me.Name, User_Name.Name, String.Empty))
        Application_Version.Text = Application.ProductVersion
    End Sub

    Private Sub Login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If User_Name.Text = Nothing Then
            User_Name.Focus()
        Else
            Pass_Word.Focus()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        class_Database.Initialize_Connection()

        Dim Parameters As SqlParameter() = {New SqlParameter("@Corporation", "SMC"),
                                            New SqlParameter("@Username", User_Name.Text),
                                            New SqlParameter("@Password", class_Tools.Encrypt(Pass_Word.Text)),
                                            New SqlParameter("@IP_Address", class_Connections.Get_IP_Internet),
                                            New SqlParameter("@IP_Local", class_Connections.Get_IP_Local),
                                            New SqlParameter("@MachineName", Environment.MachineName),
                                            New SqlParameter("@AppName", Application.ProductName),
                                            New SqlParameter("@AppVersion", Application.ProductVersion),
                                            New SqlParameter("@Action_Type", "LOGIN")}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "acc_User_Procedures")
            Try
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    class_Procedures.splash_Show("Loading Application, Please be patient!",, class_Procedures.xFormMode.xForm)

                    MainMenu.App_User_Name.Caption = User_Name.Text
                    class_Variables.sUserName = User_Name.Text

                    class_Tools.RegKeySet(Me.Name, User_Name.Name, class_Tools.Encrypt(User_Name.Text.Trim))

                    class_Saga_Procedures.Show_Update(False)

                    MainMenu.iDepoToRepoDays = CInt(class_Database.Get_Data(class_Database.ICSConnection, "SELECT NoofDays FROM ParametersDays WHERE Mnemonic like 'DEP2REP'", "NoofDays"))
                    MainMenu.iRepoToHODays = CInt(class_Database.Get_Data(class_Database.ICSConnection, "SELECT NoofDays FROM ParametersDays WHERE Mnemonic like 'REP2HO'", "NoofDays"))
                    MainMenu.iSPADepoDays = CInt(class_Database.Get_Data(class_Database.ICSConnection, "SELECT NoofDays FROM ParametersDays WHERE Mnemonic like 'SPACDDUE'", "NoofDays"))

                    AccessRights()

                    Me.Visible = False

                    MainMenu.Visible = True
                    CountAllTransactions()
                    frm_Summaries.ShowDialog()
                Else
                    class_Procedures.Set_Message(Me, class_Procedures.MsgMode.Errorr, "Wrong Username or Password. Please try again.", "Login Error", True)
                End If
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            Finally
                class_Procedures.splash_Close()
            End Try
        End Using
    End Sub

    Sub AccessRights()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamUsername", User_Name.Text),
                                            New SqlParameter("@ParamPass", Pass_Word.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_AccessRights")
            Try
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    myDataReader.Read()
                    MainMenu.Inventory_MC.Enabled = Convert.ToBoolean(myDataReader("IsInventory"))
                    MainMenu.Inventory_SPA.Enabled = Convert.ToBoolean(myDataReader("IsInventorySP"))
                    MainMenu.Inventory_Reprice.Enabled = Convert.ToBoolean(myDataReader("IsApprover"))

                    MainMenu.RibbonPageGroup_Expense.Enabled = Convert.ToBoolean(myDataReader("IsCashier"))
                    MainMenu.RibbonPageGroup_Journal.Enabled = Convert.ToBoolean(myDataReader("IsCashier"))

                    MainMenu.RibbonPageGroup_Maintenance.Enabled = Convert.ToBoolean(myDataReader("IsMaintenance"))

                    MainMenu.statusBrCode.Caption = myDataReader("branchcode").ToString()
                    class_Saga_Variables.sBranchCode = myDataReader("branchcode").ToString()

                    MainMenu.StatusLevel.Caption = myDataReader("branchname").ToString()
                    MainMenu.App_Full_Name.Caption = myDataReader("fullname").ToString
                    MainMenu.statusServer.Caption = ipaddress.Text

                    class_Saga_Variables.Initialize_Corporation()
                    class_Saga_Variables.Initialize_Corporation_All()
                    class_Saga_Variables.Initialize_Branch()
                    class_Saga_Variables.Initialize_Users()

                    class_Saga_Variables.Initialize_Unit_Status()
                End If
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            Finally
                class_Procedures.splash_Close()
            End Try
        End Using
    End Sub

    Private Sub Configuration_Settings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Configuration_Settings.Click
        Show_Server_Connection("SQL Configuration")
    End Sub

    Private Sub ipaddress_TextChanged(sender As Object, e As EventArgs) Handles ipaddress.TextChanged
        If ipaddress.Text = Nothing Then
            ipaddress.Text = "0.0.0.0"
        End If
    End Sub
End Class