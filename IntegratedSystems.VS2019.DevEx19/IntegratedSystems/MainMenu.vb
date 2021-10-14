Imports AutoUpdaterDotNET
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports SagaClassLibrary.Forms
Imports SagaInventory
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Sockets

Public Class MainMenu
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Public mainForm As Ribbon.RibbonForm

    Friend iDepoToRepoDays, iRepoToHODays, iSPADepoDays As Integer

    Private ReadOnly client As TcpClient

    Dim clientB As TcpClient

    Dim sWriter As StreamWriter

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Top = class_Tools.RegKeyGet(Me.Name, $"{Me.Name}_Top", 50)
        Left = class_Tools.RegKeyGet(Me.Name, $"{Me.Name}_Left", 50)
        Width = class_Tools.RegKeyGet(Me.Name, $"{Me.Name}_Width", 800)
        Height = class_Tools.RegKeyGet(Me.Name, $"{Me.Name}_Height", 600)

        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(BarEditItem_Branch, RepositoryItemLookUpEdit_Branch, True)
        BarEditItem_Branch.EditValue = class_Saga_Variables.sBranchCode
        Me.Text = class_Functions.Product_Name_Version

        BarEditItem_Date_Start.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Date_Start.Name, Date.Today.ToString("MMMM dd, yyyy"))
        BarEditItem_Date_End.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Date_End.Name, Date.Today.ToString("MMMM dd, yyyy"))

        PopupControlContainer_Printing_Detail.Width = class_Tools.RegKeyGet(Me.Name, $"{PopupControlContainer_Printing_Detail.Name}_Width", 300)
        PopupControlContainer_Printing_Detail.Height = class_Tools.RegKeyGet(Me.Name, $"{PopupControlContainer_Printing_Detail.Name}_Height", 400)
    End Sub

    Private Sub MainMenu_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        mainForm = Me
        'ReadBulletin()
        'ConnectServerChat()

        MarqueeTimer.Enabled = True

        ApplicationAssemblyVersion.Caption = Application.ProductVersion

        Refresh_Connection()

        Dim timer = New System.Timers.Timer With {
            .Interval = 2 * 60 * 1000
        }
        timer.Start()

        AddHandler timer.Elapsed, AddressOf OnTimedEvent
    End Sub

    Private Function main_Close(Optional ByVal bAsk As Boolean = True) As Boolean
        class_Saga_Database.bLoopStop = True

        class_Procedures.Set_Skin()

        If WindowState.Equals(FormWindowState.Normal) Then
            class_Tools.RegKeySet(Me.Name, $"{Me.Name}_Top", Top)
            class_Tools.RegKeySet(Me.Name, $"{Me.Name}_Left", Left)
            class_Tools.RegKeySet(Me.Name, $"{Me.Name}_Width", Width)
            class_Tools.RegKeySet(Me.Name, $"{Me.Name}_Height", Height)
        End If

        class_Tools.RegKeySet(Me.Name, BarEditItem_Date_Start.Name, BarEditItem_Date_Start.EditValue.ToString)
        class_Tools.RegKeySet(Me.Name, BarEditItem_Date_End.Name, BarEditItem_Date_End.EditValue.ToString)

        class_Tools.RegKeySet(Me.Name, $"{PopupControlContainer_Printing_Detail.Name}_Width", PopupControlContainer_Printing_Detail.Width)
        class_Tools.RegKeySet(Me.Name, $"{PopupControlContainer_Printing_Detail.Name}_Height", PopupControlContainer_Printing_Detail.Height)

        If class_Procedures.Form_Close(Me, bAsk) Then
            If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE Users Set IsOnline = '0' WHERE username LIKE '{class_Variables.sUserName}'") Then Application.Exit()
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub MainMenu_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not main_Close() Then
            e.Cancel = True
        Else
            mg_losignout()
        End If
    End Sub

    Private Sub OnTimedEvent(source As Object, e As System.Timers.ElapsedEventArgs)
        class_connections.Show_Update(False)
    End Sub

    Private Sub send(ByVal str As String)
        Try
            sWriter = New StreamWriter(client.GetStream)
            sWriter.WriteLine(str)
            sWriter.Flush()
        Catch ex As Exception
            xUpdate("You're not connected to Broadcast Server")
        End Try
    End Sub

    Delegate Sub _xUpdate(ByVal str As String)

    Private Sub xUpdate(ByVal str As String)
        If InvokeRequired Then
            Invoke(New _xUpdate(AddressOf xUpdate), str)
        Else
            GroupMsg.AppendText(str & vbNewLine)
        End If
    End Sub

    Private Sub ReadBulletin()
        Try
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create($"http://{class_Database.SqlServer}/Autoupdate/AutoUpdate/Bulletins.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            txt_Bulletin.Text = newestversion
        Catch ex As Exception
            xUpdateB("Can't connect to the Broadcast Server!")
            class_Procedures.Show_Error(ex)
        End Try
    End Sub

    Friend Sub ConnectServerChat()
        'Try
        '    clientB = New TcpClient(class_Database.SqlServer, Convert.ToInt32("3819"))
        '    clientB.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf readB), Nothing)
        '    BroadcastServ.Caption = "BROADCAST"
        '    BroadcastServ.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White
        '    BroadcastServ.ItemAppearance.Normal.BackColor = System.Drawing.Color.Green
        'Catch ex As Exception
        '    xUpdateB("Can't connect to the Broadcast Server!")
        '    class_Procedures.Show_Error(ex)
        'End Try
    End Sub

    Private Sub Refresh_Connection()
        Server_Type.Caption = class_Database.SqlServerType

        Dim dtDatabaseDate As Date = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT BranchCode, DatabaseDate FROM BranchParameters WHERE BranchCode LIKE '{class_Saga_Variables.sBranchCode}'", "DatabaseDate"))
        Database_Date.Caption = $"Branch Date: {dtDatabaseDate:MMMM dd, yyyy}"
    End Sub

    Private Sub btn_Refresh_Connection_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Refresh_Connection.ItemClick, Database_Date.ItemClick
        If class_Saga_Procedures.Refresh_Connection() Then
            Refresh_Connection()
        End If
    End Sub

    Private Sub Server_Type_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles Server_Type.ItemDoubleClick
        Show_Server_Connection("SQL Configuration")
    End Sub

    Private Sub barEditItem_Date_Start_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles BarEditItem_Date_Start.EditValueChanged
        Try
            class_Saga_Variables.dtStart = Convert.ToDateTime(BarEditItem_Date_Start.EditValue)
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        End Try
    End Sub

    Private Sub barEditItem_Date_End_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles BarEditItem_Date_End.EditValueChanged
        Try
            class_Saga_Variables.dtEnd = Convert.ToDateTime(BarEditItem_Date_End.EditValue)
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        End Try
    End Sub

    Private Sub barEditItem_Date_Start_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarEditItem_Date_Start.ItemClick
        BarEditItem_Date_End.EditValue = class_Functions.Next_Working_Date(Convert.ToDateTime(BarEditItem_Date_Start.EditValue))
    End Sub

    Private Sub barEditItem_Date_Start_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles BarEditItem_Date_Start.ItemDoubleClick
        Dim dtStart As Date
        Dim iDays As Integer = 1

        If My.Computer.Keyboard.ShiftKeyDown Then iDays = -1

        dtStart = Convert.ToDateTime(BarEditItem_Date_Start.EditValue).AddDays(iDays)
        If dtStart.DayOfWeek = DayOfWeek.Sunday Then dtStart = dtStart.AddDays(iDays)

        BarEditItem_Date_Start.EditValue = dtStart
        BarEditItem_Date_End.EditValue = class_Functions.Next_Working_Date(dtStart)
    End Sub

    Private Sub barEditItem_Date_End_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles BarEditItem_Date_End.ItemDoubleClick
        BarEditItem_Date_End.EditValue = class_Functions.Next_Working_Date(Convert.ToDateTime(BarEditItem_Date_Start.EditValue))
    End Sub

    Private Sub btn_Today_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Today.ItemClick
        BarEditItem_Date_Start.EditValue = Date.Today
        BarEditItem_Date_End.EditValue = Date.Today
    End Sub

    Private Sub set_Month()
        BarEditItem_Date_Start.EditValue = class_Functions.FirstDayOfMonth(Convert.ToDateTime(BarEditItem_Date_Start.EditValue))
        BarEditItem_Date_End.EditValue = class_Functions.LastDayOfMonth(Convert.ToDateTime(BarEditItem_Date_Start.EditValue))
    End Sub

    Private Sub btn_Day_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Day.ItemClick
        BarEditItem_Date_End.EditValue = BarEditItem_Date_Start.EditValue
    End Sub

    Private Sub btn_Month_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Month.ItemClick
        set_Month()
    End Sub

    Private Sub btn_Day_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles btn_Day.ItemDoubleClick
        BarEditItem_Date_Start.EditValue = class_Functions.Next_Working_Date(Convert.ToDateTime(BarEditItem_Date_Start.EditValue), My.Computer.Keyboard.ShiftKeyDown)
        BarEditItem_Date_End.EditValue = BarEditItem_Date_Start.EditValue
    End Sub

    Private Sub btn_Month_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles btn_Month.ItemDoubleClick
        Dim iMonths As Int16 = 1

        If My.Computer.Keyboard.ShiftKeyDown Then iMonths = -1

        BarEditItem_Date_Start.EditValue = Convert.ToDateTime(BarEditItem_Date_Start.EditValue).AddMonths(iMonths)
        set_Month()
    End Sub

    Private Sub btn_Date_Request_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Date_Request.ItemClick
        Dim sRequestDescription = class_Functions.Show_Input_Box("Input reason for Date Request", "Date Request", String.Empty)
        If sRequestDescription.Length > 1 AndAlso class_Procedures.actionAsk("Date Request", $"send Date Request {class_Saga_Variables.dtStart:MMMM dd, yyyy}", "Please inform IT Personnel about your Date Request.") Then
            If class_Database.Data_Update(class_Database.ICSConnection,
                                        "UPDATE BranchParameters " +
                                        $"SET Back_Date_Status = 'BACK_DATE_REQUEST', " +
                                        $"Back_Date = '{class_Saga_Variables.dtStart}', " +
                                        $"Modified_By = '{class_Variables.sUserName}', " +
                                        $"Modified_Date = '{DateTime.Now}', " +
                                        $"Request_Description = '{sRequestDescription}' " +
                                        $"WHERE BranchCode LIKE '{class_Saga_Variables.sBranchCode}'") Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Date Request has been sent to IT Personnel.{Environment.NewLine}Please inform them to approve your Date Request.", "Date Request", True)
            End If
        End If
    End Sub

    Private Sub btn_New_Customer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New_Customer.ItemClick
        Dim frm As Persons.frm_Customer = New Persons.frm_Customer()
        class_Procedures.Show_Form(Me, frm, "Customer Information", False)
        With frm.xuc_Customer
            .Branch_Code.ReadOnly = Not class_Saga_Variables.sBranchCode.Equals("000")
            .Control_Initialize()
            .Control_New()
        End With
    End Sub

    Private Sub btn_CIF_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_CIF.ItemClick
        Customers_Information.Show()
        Customers_Information.Focus()
    End Sub

    Private Sub btn_Customers_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Customers.ItemClick
        Dim frm As SagaClassLibrary.Forms.Persons.frm_Customers = New SagaClassLibrary.Forms.Persons.frm_Customers()
        class_Procedures.Show_Form(Me, frm, "Customer Management")
    End Sub

    Private Sub btn_Account_Executives_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Account_Executives.ItemClick
        Dim frm As New Persons.frm_Account_Executives()
        class_Procedures.Show_Form(Me, frm, "Account Executives")
    End Sub
    Private Sub btn_MC_Release1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MC_Release1.ItemClick
        Me.IsMdiContainer = True
        'IS_SALES_Release.MdiParent = Me
        IS_SALES_Release.Show()
        IS_SALES_Release.Focus()
    End Sub

    Private Sub btn_MC_Release_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MC_Release.ItemClick
        class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.CIF, "NEW",, "New MC Sale", True)
    End Sub

    Private Sub btn_Releases_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Releases.ItemClick
        Dim frm As Accounting.frm_Releases = New Accounting.frm_Releases()
        class_Procedures.Show_Form(Me, frm, "Releases")
    End Sub

    Private Sub BarButtonItem1_ItemClick_2(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RECEIVINGToolStripMenuItem1.ItemClick
        'IS_Inventory_Receiving_Cost.ShowDialog()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MOTORCYCLEToolStripMenuItem.ItemClick
        'main_mc_price.ShowDialog()
    End Sub

    Private Sub BarButtonItem3_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MOTORCYCLEToolStripMenuItem1.ItemClick
        'maint_terms_mc.ShowDialog()
    End Sub

    Private Sub BarButtonItem3_ItemClick_4(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CORPToolStripMenuItem.ItemClick
        'admin_UpdateCorp.ShowDialog()
    End Sub

    Private Sub BarButtonItem6_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RECLASSIFICATIONToolStripMenuItem.ItemClick
        'Admin_ReclassINVTY.ShowDialog()
    End Sub

    Private Sub btn_Password_Change_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Password_Change.ItemClick
        class_Saga_Procedures.Show_Password_Change(class_Saga_Variables.sCorporation, class_Variables.sUserName, True)
    End Sub

    Private Sub CHANGEAPPROVERToolStripMenuItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CHANGEAPPROVERToolStripMenuItem.ItemClick
        maint_ChangeApprover_Sales.ShowDialog()
    End Sub

    Private Sub MIGRATEACCOUNTToolStripMenuItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MIGRATEACCOUNTToolStripMenuItem.ItemClick
        'Me.IsMdiContainer = True
        'Dim formVariable = New admin_MigrateAccount With {
        '    .MdiParent = Me
        '}
        'formVariable.Show()
        'formVariable.Focus()
    End Sub

    Private Sub statusBrCode_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarStaticItem_Branch_Code.ItemClick
        mg_CountTotalAccount()
        ShowTotalCount.ShowDialog()
    End Sub

    Private Sub mg_CountTotalAccount()
        ShowTotalCount.LviewTotalCnt.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", BarStaticItem_Branch_Code.Caption)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_CountTotalAccount")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = ShowTotalCount.LviewTotalCnt.Items.Add(myDataReader("BranchCode").ToString())
                    li.SubItems.Add(myDataReader("AccountStatus").ToString())
                    li.SubItems.Add(myDataReader("TotCnt").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub mg_losignout()
        ShowTotalCount.LviewTotalCnt.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamUsername", App_User_Name.Caption)
        }
        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_losignout", "User Logout")
    End Sub

    Private Sub btn_Report_Cashiering_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Report_Cashiering.ItemClick
        Dim frm = New rpt_Cashiering()
        class_Procedures.Show_Form(Me, frm, "Cashiering")
    End Sub

    Private Sub btn_Report_Credit_Memo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Report_Credit_Memo.ItemClick
        Dim frm = New rpt_Credit_Memo()
        class_Procedures.Show_Form(Me, frm, "Credit Memo")
    End Sub

    Private Sub btn_Report_IBP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Report_IBP.ItemClick
        Dim frm = New rpt_ShowIBT()
        class_Procedures.Show_Form(Me, frm, "Inter-Branch Transactions")
    End Sub

    Private Sub btn_Release_Monitoring_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Release_Monitoring.ItemClick
        Dim frm = New rpt_Actual_Releases()
        class_Procedures.Show_Form(Me, frm, "Actual Releases")
    End Sub

    Private Sub btn_Report_Collection_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Report_Collection.ItemClick
        Dim frm = New rpt_ActualCollections()
        class_Procedures.Show_Form(Me, frm, "Actual collection")
    End Sub

    Private Sub btn_Closed_Account_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Closed_Account.ItemClick
        Dim frm = New rpt_ClosedAcct()
        class_Procedures.Show_Form(Me, frm, "Closed Accounts")
    End Sub

    Private Sub btn_Account_Master_List_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Account_Master_List.ItemClick
        Dim frm = New rpt_AcctMasterlist()
        class_Procedures.Show_Form(Me, frm, "Accounts Master List")
    End Sub

    Private Sub btn_LTO_Registration_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_LTO_Registration.ItemClick
        Dim frm = New rpt_InsuranceRpt()
        class_Procedures.Show_Form(Me, frm, "LTO Registration List")
    End Sub

    Private Sub btn_Ageing_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Ageing.ItemClick
        Dim frm = New rpt_CollectionAging()
        class_Procedures.Show_Form(Me, frm, "Collection Ageing")
    End Sub

    Private Sub btn_Freebies_List_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Freebies_List.ItemClick
        Dim frm = New rpt_MCFreebieListing()
        class_Procedures.Show_Form(Me, frm, "Freebies List")
    End Sub

    Private Sub btn_MC_Promo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_MC_Promo.ItemClick
        Dim frm = New rpt_MCAccountPromo()
        class_Procedures.Show_Form(Me, frm, "MC Promo Discounts")
    End Sub

    Private Sub btn_Inquiries_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Inquiries.ItemClick
        Dim frm = New IS_InquiryORNo()
        class_Procedures.Show_Form(Me, frm, "Transaction Inquiries")
    End Sub

    Private Sub spaSales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles spaSales.ItemClick
        'Me.IsMdiContainer = True
        'SPA_Sales_Summary.MdiParent = Me
        'SPA_Sales_Summary.Show()
        'SPA_Sales_Summary.Focus()
    End Sub

    Private Sub NewUpdate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Check_Update.ItemClick
        class_Connections.Show_Update(False, True, True)
    End Sub

    Private Sub btn_Account_Cancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Account_Cancel.ItemClick
        Me.IsMdiContainer = True
        admin_acctCancel.MdiParent = Me
        admin_acctCancel.Show()
        admin_acctCancel.Focus()
    End Sub

    Private Sub RetagAE_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles RetagAE.ItemClick
        'admin_UpdateAE.ShowDialog()
    End Sub

    Private Sub BranchParams_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BranchParams.ItemClick
        'Admin_BranchParameter.ShowDialog()
    End Sub

    Private Sub IPRegister_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles IPRegister.ItemClick
        'Admin_IPReg.ShowDialog()
    End Sub

    Private Sub DisapprovedList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DisapprovedList.ItemClick
        Admin_DisapprovedTransactions.ShowDialog()
    End Sub

    Private Sub AccountMgmt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles AccountMgmt.ItemClick
        'Me.IsMdiContainer = True
        'Admin_UpdateAccount.MdiParent = Me
        'Admin_UpdateAccount.Show()
        'Admin_UpdateAccount.Focus()
    End Sub

    Private Sub CIFMgmt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CIFMgmt.ItemClick
        'Me.IsMdiContainer = True
        'Dim formVariable = New Admin_CIFAcct With {
        '    .MdiParent = Me
        '}
        'formVariable.Show()
        'formVariable.Focus()
    End Sub

    Private Sub SPAInventMgmt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SPAInventMgmt.ItemClick
        'Me.IsMdiContainer = True
        'SPA_Branch.MdiParent = Me
        'SPA_Branch.Show()
        'SPA_Branch.Focus()
    End Sub

    Private Sub cmd_SendMsg_Click(sender As Object, e As EventArgs) Handles cmd_SendMsg.Click
        send(user.Text & " : " & MyMsg.Text)
        MyMsg.Clear()
    End Sub

    Private Sub MyMsg_TextChanged(sender As Object, e As EventArgs) Handles MyMsg.TextChanged

    End Sub

    Private Sub MyMsg_KeyDown(sender As Object, e As KeyEventArgs) Handles MyMsg.KeyDown
        If e.KeyCode = Keys.Enter Then
            send($"{App_User_Name.Caption} : {MyMsg.Text}")
            MyMsg.Clear()
        End If
    End Sub

    Private Sub readB(ByVal ar As IAsyncResult)
        Try
            xUpdateB(New StreamReader(clientB.GetStream).ReadLine)
            clientB.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf readB, Nothing)
        Catch ex As Exception
            xUpdateB("You are disconnected from Broadcast Server")
            Exit Sub
        End Try
    End Sub

    Delegate Sub _xUpdateB(ByVal str As String)

    Private Sub xUpdateB(ByVal str As String)
        If InvokeRequired Then
            Invoke(New _xUpdateB(AddressOf xUpdateB), str)
        Else
            MyMessagebox.lbl_message.Text = str
            MyMessagebox.ShowDialog()
        End If
    End Sub

    Private Sub cmd_broadcast_Click(sender As Object, e As EventArgs) Handles cmd_broadcast.Click
        sendB($"{App_User_Name.Caption} : {txt_BroadCast.Text}")
        txt_BroadCast.Clear()
        BroadcastPanel.Visible = False
    End Sub

    Friend Sub sendB(ByVal str As String)
        Try
            sWriter = New StreamWriter(clientB.GetStream)
            sWriter.WriteLine(str)
            sWriter.Flush()
        Catch ex As Exception
            xUpdate("You're not connected to Broadcast Server")
        End Try
    End Sub

    Private Sub clos_Click(sender As Object, e As EventArgs) Handles clos.Click
        BroadcastPanel.Visible = False
    End Sub

    Private Sub BroadcastServ_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        'If BroadCastServer.Caption = "ONLINE" Then
        '    Try
        '        'client = New TcpClient(Decrypt(class_Tools.RegKeyGet("HostServer", "HostServer", "")), Convert.ToInt32("3818"))
        '        clientB = New TcpClient("124.107.148.186", Convert.ToInt32("3819"))
        '        clientB.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf readB), Nothing)

        '        BroadcastServ.Caption = "OFFLINE"
        '        BroadcastServ.ItemAppearance.Normal.ForeColor = Color.White
        '        BroadcastServ.ItemAppearance.Normal.BackColor = Color.Green

        '        ' send(txt_FLName.Text & " is now online")
        '    Catch ex As Exception

        '        xUpdateB("Can't connect to the server!")
        '    End Try

        'Else

        'clientB.Close()

        'clientB = Nothing
        'BroadcastServ.Caption = "OFFLINE"
        'BroadcastServ.ItemAppearance.Normal.ForeColor = Color.White
        'BroadcastServ.ItemAppearance.Normal.BackColor = Color.Red
        'End If
    End Sub

    Private Sub BroadCastMSg_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BroadCastMSg.ItemClick
        'BroadcastPanel.Visible = True
        Admin_BroadcastMsg.ShowDialog()
    End Sub

    Private Sub MainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.M AndAlso e.Modifiers = Keys.Control Then
            MyMessagebox.ShowDialog()
        End If
        If e.KeyCode = Keys.B AndAlso e.Modifiers = Keys.Control Then
            Admin_BroadcastMsg.ShowDialog()
        End If
    End Sub

    Private Sub spa_CustDepSummary_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles spa_CustDepSummary.ItemClick

    End Sub

    Private Sub MarqueeTimer_Tick(sender As Object, e As EventArgs) Handles MarqueeTimer.Tick
        'txt_Bulletin.Location = New Point(txt_Bulletin.Location.X, txt_Bulletin.Location.Y - 1)
        'If txt_Bulletin.Location = New Point(18, -txt_Bulletin.Height) Then
        '    txt_Bulletin.Location = New Point(18, 400)
        'End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_Bulletin.TextChanged
        txt_Bulletin.Height =
        TextRenderer.MeasureText(
            txt_Bulletin.Text,
            txt_Bulletin.Font,
            New Size(txt_Bulletin.ClientSize.Width, 1500),
            TextFormatFlags.WordBreak
        ).Height
    End Sub

    Private Sub btn_Stop_Click(sender As Object, e As EventArgs) Handles btn_Stop.Click
        MarqueeTimer.Enabled = False
    End Sub

    Private Sub btn_play_Click(sender As Object, e As EventArgs) Handles btn_play.Click
        MarqueeTimer.Enabled = True
    End Sub

    Private Sub LoadBulletin_Click(sender As Object, e As EventArgs) Handles LoadBulletin.Click
        ReadBulletin()
    End Sub

    Private Sub BarButtonItem4_ItemClick_2(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles InventoryDropDown.ItemClick

    End Sub

    Private Sub IsSuperUser_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles IsSuperUser.ItemClick

    End Sub

    Private Sub deprep_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deprep.ItemClick
        'Me.IsMdiContainer = True

        'Dim formVariable = New rpt_DEPtoREP With {
        '    .MdiParent = Me,
        '    .Text = "DEPOSITED TO REPOSSESSED REPORT"
        '}
        'formVariable.txt_NoofDays.EditValue = 45
        'formVariable.txt_whcode.EditValue = "DEP"
        'formVariable.Show()
        'formVariable.Focus()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles LOGOUTToolStripMenuItem.ItemClick
        'Login.ShowDialog()
        Dim frm As Login = New Login()
        class_Procedures.Show_Form(Me, frm, "Application Login", False)
    End Sub

    Private Sub mcForApprovalInv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mcForApprovalInv.ItemClick
        Dim frm As IS_Inventory_List = New IS_Inventory_List()
        class_Procedures.Show_Form(Me, frm, "For Approval", False)
    End Sub

    Private Sub mcInTransitInv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mcInTransitInv.ItemClick
        Dim frm As IS_Inventory_List = New IS_Inventory_List()
        class_Procedures.Show_Form(Me, frm, "For Transport", False)
    End Sub

    Private Sub mcPendingInv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mcPendingInv.ItemClick
        Dim frm As IS_Inventory_List = New IS_Inventory_List()
        class_Procedures.Show_Form(Me, frm, "PENDING", False)
    End Sub

    Private Sub mcDisapprovedInv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mcDisapprovedInv.ItemClick
        Dim frm As IS_Inventory_List = New IS_Inventory_List()
        class_Procedures.Show_Form(Me, frm, "Disapproved", False)
    End Sub

    Private Sub mcApprovedInv_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mcApprovedInv.ItemClick
        Dim frm As IS_Inventory_List = New IS_Inventory_List()
        class_Procedures.Show_Form(Me, frm, "Approved", False)
    End Sub

    Private Sub SPA_SubDealerMgmt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SPA_SubDealerMgmt.ItemClick
        'Frm_SubDealer.ShowDialog()
    End Sub

    Private Sub RepositoryItemSearchControl_KeyDown(sender As Object, e As KeyEventArgs) Handles RepositoryItemSearchControl.KeyDown
        If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
            Dim SearchText As String
            SearchText = (CType(sender, BaseEdit)).Text.Trim

            If SearchType.EditValue = "MC ACCOUNT" Then
                IS_Sales_ReleaseAccount_List.Text = "SEARCH CONTROL"
                IS_Sales_ReleaseAccount_List.quickSearch.Text = SearchText
                IS_Sales_ReleaseAccount_List.ShowDialog()

            ElseIf SearchType.EditValue = "IB-MC ACCOUNT" Then
                IS_Sales_ReleaseAccount_List.Text = "IB-MC ACCOUNT"
                IS_Sales_ReleaseAccount_List.quickSearch.Text = SearchText
                IS_Sales_ReleaseAccount_List.ShowDialog()

            ElseIf SearchType.EditValue = "MC INVENTORY" Then
                IS_Inventory_DetailedSummary.quickSearch.EditValue = SearchText
                IS_Inventory_DetailedSummary.searchInventoryLocalBranch()
                'IS_Inventory_DetailedSummary.ShowDialog()
                Me.IsMdiContainer = True
                IS_Inventory_DetailedSummary.MdiParent = Me
                IS_Inventory_DetailedSummary.Show()
                IS_Inventory_DetailedSummary.Focus()

            ElseIf SearchType.EditValue = "IB-MC INVENTORY" Then
                'IS_Inventory_DetailedSummary.Text = "IB-MC INVENTORY"
                'IS_Inventory_DetailedSummary.quickSearch.EditValue = SearchText
                'IS_Inventory_DetailedSummary.SearchWhat()
                'IS_Inventory_DetailedSummary.ShowDialog()

            ElseIf SearchType.EditValue = "SPA ACCOUNT" Then
                'SPA_Search_Sales_Inquiry.txt_Search.Text = SearchText
                'SPA_Search_Sales_Inquiry.SPA_Show_Sales_Inquiry()
                'SPA_Sales_Inquiry.toolPost.Enabled = False
                'SPA_Sales_Inquiry.btn_Payment.Enabled = False
                'SPA_Search_Sales_Inquiry.ShowDialog()
            ElseIf SearchType.EditValue = "IB-SPA ACCOUNT" Then
                'SPA_Search_Sales_Inquiry.txt_Search.Text = SearchText
                'SPA_Search_Sales_Inquiry.SPA_Show_Sales_Inquiry()
                'SPA_Sales_Inquiry.toolPost.Enabled = False
                'SPA_Sales_Inquiry.btn_Payment.Enabled = False
                'SPA_Search_Sales_Inquiry.ShowDialog()
            ElseIf SearchType.EditValue = "SPA INVENTORY" Then
                'SPA_BranchInventory.txt_Search.EditValue = SearchText

                'Me.IsMdiContainer = True
                'SPA_BranchInventory.MdiParent = Me

                'SPA_BranchInventory.Show()
                'SPA_BranchInventory.Focus()
            End If

        End If
    End Sub

    Private Sub SPMasterFile_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SPMasterFile.ItemClick
        'Me.IsMdiContainer = True
        'SPA_Master.MdiParent = Me
        'SPA_Master.Show()
        'SPA_Master.Focus()
    End Sub

    Private Sub RefreshSummaries_ItemClick(sender As Object, e As ItemClickEventArgs) Handles RefreshSummaries.ItemClick
        frm_Summaries.ShowDialog()
    End Sub

    Private Sub repMonitoring_ItemClick(sender As Object, e As ItemClickEventArgs) Handles repMonitoring.ItemClick
        Me.IsMdiContainer = True

        Dim frm = New rpt_DEPtoREP With {
            .MdiParent = Me,
            .Text = "REPOSSESSED TO HO REPORT"
        }
        frm.Unit_Status.EditValue = "REP"
        frm.Days.EditValue = 60

        frm.Show()
        frm.Focus()

    End Sub

    Private Sub InventorySummary_ItemClick(sender As Object, e As ItemClickEventArgs) Handles InventorySummaryPop.ItemClick
        Me.IsMdiContainer = True
        'SPA_BranchInventory.MdiParent = Me
        'SPA_BranchInventory.Show()
        'SPA_BranchInventory.Focus()
    End Sub

    Private Sub CustDepSummaryPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles CustDepSummaryPop.ItemClick
        'SPA_Sales_CustDep.ShowDialog()
    End Sub

    Private Sub SPA_TopMovingPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SPA_TopMovingPop.ItemClick
        Me.IsMdiContainer = True
        'SPA_TopMoving.MdiParent = Me
        'SPA_TopMoving.Show()
        'SPA_TopMoving.Focus()
    End Sub

    Private Sub SPA_TopSellingPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SPA_TopSellingPop.ItemClick
        Me.IsMdiContainer = True
        'SPA_TopSelling.MdiParent = Me
        'SPA_TopSelling.Show()
        'SPA_TopSelling.Focus()
    End Sub

    Private Sub SPA_MostExpensivePop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SPA_MostExpensivePop.ItemClick
        Me.IsMdiContainer = True
        'SPA_MostExpensive.MdiParent = Me
        'SPA_MostExpensive.Show()
        'SPA_MostExpensive.Focus()
    End Sub

    Private Sub AgingInventoryPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles AgingInventoryPop.ItemClick
        Me.IsMdiContainer = True
        'SPA_InventoryAging.MdiParent = Me
        'SPA_InventoryAging.Show()
        'SPA_InventoryAging.Focus()
    End Sub

    Private Sub SPA_PerSupplierPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SPA_PerSupplierPop.ItemClick
        Me.IsMdiContainer = True
        'SPA_PerSupplier.MdiParent = Me
        'SPA_PerSupplier.Show()
        'SPA_PerSupplier.Focus()
    End Sub

    Private Sub SPA_CustDepDuePop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SPA_CustDepDuePop.ItemClick
        Me.IsMdiContainer = True
        'SPA_ShowDueCustDep.MdiParent = Me
        'SPA_ShowDueCustDep.Show()
        'SPA_ShowDueCustDep.Focus()
    End Sub



    Private Sub MC_InvRefNoPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles MC_InvRefNoPop.ItemClick
        Me.IsMdiContainer = True
        IS_Inquiry_Refno.MdiParent = Me
        IS_Inquiry_Refno.Show()
        IS_Inquiry_Refno.Focus()
    End Sub

    Private Sub MCInventorySummaryPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles MCInventorySummaryPop.ItemClick
        Me.IsMdiContainer = True
        IS_Inventory_DetailedSummary.MdiParent = Me
        IS_Inventory_DetailedSummary.Show()
        IS_Inventory_DetailedSummary.Focus()
    End Sub



    Private Sub MCIntransitRptPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles MCIntransitRptPop.ItemClick
        'IS_Inventory_TransactionReports.ShowDialog()
    End Sub

    Private Sub MCAcceptedTransfersPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles MCAcceptedTransfersPop.ItemClick
        'IS_Inventory_TransactionReports_ApprovedTransfers.ShowDialog()
    End Sub

    Private Sub SPA_IntransitRptPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SPA_IntransitRptPop.ItemClick
        'SPA_IntransitReport.ShowDialog()
    End Sub

    Private Sub SPA_AcceptedTransPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SPA_AcceptedTransPop.ItemClick
        'SPA_AcceptedTransfers.ShowDialog()
    End Sub

    Private Sub spaSIORCRInq_ItemClick(sender As Object, e As ItemClickEventArgs) Handles spaSIORCRInq.ItemClick
        'Me.IsMdiContainer = True
        'SPA_SI_Inquiry.MdiParent = Me
        'SPA_SI_Inquiry.Show()
        'SPA_SI_Inquiry.Focus()
    End Sub

    Private Sub CashieringTrans_ItemClick(sender As Object, e As ItemClickEventArgs) Handles CashieringTrans.ItemClick
        'Me.IsMdiContainer = True
        'Admin_CashieringTransactionsMgmt.MdiParent = Me
        'Admin_CashieringTransactionsMgmt.Show()
        'Admin_CashieringTransactionsMgmt.Focus()
    End Sub

    Private Sub mcInterBranchInventory_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mcInterBranchInventory.ItemClick
        'Me.IsMdiContainer = True
        'IS_Inventory_DetailedSCategoryFindvb.MdiParent = Me
        'IS_Inventory_DetailedSCategoryFindvb.Show()
        'IS_Inventory_DetailedSCategoryFindvb.Focus()
    End Sub

    Private Sub MCInventHist_ItemClick(sender As Object, e As ItemClickEventArgs) Handles MCInventHist.ItemClick
        'Me.IsMdiContainer = True
        'IS_Inventory_Detailed_SHistory.MdiParent = Me
        'IS_Inventory_Detailed_SHistory.Show()
        'IS_Inventory_Detailed_SHistory.Focus()
    End Sub

    Private Sub SVerUpdate_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SVerUpdate.ItemClick
        'Me.IsMdiContainer = True
        'Dim frmVersionUpServ As New wSClassLib.Admin_BackupAppl With {
        '    .MdiParent = Me
        '}
        'frmVersionUpServ.Show()
        'frmVersionUpServ.Focus()
    End Sub

    Private Sub Timer_AutoUpdate_Tick(sender As Object, e As EventArgs) Handles Timer_AutoUpdate.Tick
        show_Update(False, False)
    End Sub

    Friend Sub show_Update(ByVal bMandatory As Boolean, ByVal mError As Boolean)
        If Not class_Database.SqlServer = "(local)" Then
            AutoUpdater.Start($"http://{class_Database.SqlServer}/AutoUpdate/SagaOperations/SagaOperations.xml", Reflection.Assembly.GetEntryAssembly)
            AutoUpdater.Mandatory = bMandatory
            AutoUpdater.ReportErrors = mError
            AutoUpdater.AppTitle = "SAGA Dealer Management System "
        End If
    End Sub

    Friend Sub show_Patch(ByVal bMandatory As Boolean, ByVal mError As Boolean)
        If Not class_Database.SqlServer = "(local)" Then
            AutoUpdater.Start($"http://{class_Database.SqlServer}/AutoUpdate/AutoPatch/IntegratedCoreSystems.xml", Reflection.Assembly.GetEntryAssembly)
            AutoUpdater.Mandatory = bMandatory
            AutoUpdater.ReportErrors = mError
            AutoUpdater.AppTitle = "SAGA Dealer Management System "
        End If
    End Sub

    Private Sub NewUpdate_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles Check_Update.ItemDoubleClick
        show_Update(False, False)
    End Sub

    Private Sub btn_ComputeAmort_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_ComputeAmort.ItemClick
        'Admin_MCPriceChecker.ShowDialog()
    End Sub

    Private Sub btn_AcctDueInq_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_AcctDueInq.ItemClick
        'Me.IsMdiContainer = True
        'IS_Sales_Payments.MdiParent = Me

        'IS_Sales_Payments.Panel2.Enabled = False
        'IS_Sales_Payments.txt_TotAmtPaid.Enabled = False
        'IS_Sales_Payments.txt_remarks.Enabled = False
        'IS_Sales_Payments.txt_refno.Enabled = False
        'IS_Sales_Payments.ToolStrip1.Enabled = False

        'IS_Sales_Payments.Show()
    End Sub

    Private Sub btn_DebitMemo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_DebitMemo.ItemClick
        'Me.IsMdiContainer = True
        'Debit_Memo.MdiParent = Me
        'Debit_Memo.Show()
        'Debit_Memo.Focus()
    End Sub



    Private Sub BarButtonItem1_ItemClick_5(sender As Object, e As ItemClickEventArgs) Handles ReclassStats.ItemClick
        'Admin_ReclassStatus.ShowDialog()
    End Sub

    Private Sub BarButtonItem1_ItemClick_7(sender As Object, e As ItemClickEventArgs) Handles UserManagement.ItemClick
        'Me.IsMdiContainer = True
        'Admin_UserManagement.MdiParent = Me
        'Admin_UserManagement.Show()
        'Admin_UserManagement.Focus()
    End Sub

    Private Sub ExecDatabaseJobs_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ExecDatabaseJobs.ItemClick
        'Me.IsMdiContainer = True
        'Admin_SqlJobs.MdiParent = Me
        'Admin_SqlJobs.Show()
        'Admin_SqlJobs.Focus()
    End Sub

    Private Sub LogoutTimer_Tick(sender As Object, e As EventArgs)
        'MsgBox("sdfsdfdsfd")
        'Application.Exit()
    End Sub

    Private Sub mcForDepo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mcForDepo.ItemClick
        'Dim frm As New rpt_MCForDepo With {
        '    .MdiParent = Me
        '}
        'frm.Show()
        'frm.Focus()
    End Sub

    Private Sub MCDetailedRemarks_ItemClick(sender As Object, e As ItemClickEventArgs) Handles MCDetailedRemarks.ItemClick
        'Me.IsMdiContainer = True
        'rpt_Inventory_DetailsRemarks.MdiParent = Me
        'rpt_Inventory_DetailsRemarks.Show()
        'rpt_Inventory_DetailsRemarks.Focus()
    End Sub

    Private Sub AcctRemarks_ItemClick(sender As Object, e As ItemClickEventArgs) Handles AcctRemarks.ItemClick
        'Me.IsMdiContainer = True
        'rpt_MCForDepo.MdiParent = Me
        'rpt_MCForDepo.Show()
        'rpt_MCForDepo.Focus()
    End Sub

    Private Sub btn_MC_Collection_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MC_Collection.ItemClick
        Me.IsMdiContainer = True
        MC_Collection.MdiParent = Me
        MC_Collection.Show()
        MC_Collection.Focus()
    End Sub

    Private Sub btn_MC_Collection2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MC_Collection2.ItemClick
        Dim frm As Transactions.frm_Payment_Collection = New Transactions.frm_Payment_Collection
        class_Procedures.Show_Form(Me, frm, "Payment Collection", False)
    End Sub

    Private Sub btn_Cashiering_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Cashiering_Transaction.ItemClick
        Me.IsMdiContainer = True
        Cashiering_Transaction.MdiParent = Me
        Cashiering_Transaction.Show()
        Cashiering_Transaction.Focus()
    End Sub

    Private Sub btn_Credit_Memo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Credit_Memo.ItemClick
        Me.IsMdiContainer = True
        Credit_Memo.MdiParent = Me
        Credit_Memo.Show()
        Credit_Memo.Focus()
    End Sub

    Private Sub btn_Error_Correct_Cashiering_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Error_Correct_Cashiering.ItemClick
        Me.IsMdiContainer = True
        Error_Correct_Cashiering.MdiParent = Me
        Error_Correct_Cashiering.Show()
        Error_Correct_Cashiering.Focus()
    End Sub

    Private Sub btn_Error_Correct_Collection_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Error_Correct_Collection.ItemClick
        Me.IsMdiContainer = True
        Error_Correct_Collection.MdiParent = Me
        Error_Correct_Collection.Show()
        Error_Correct_Collection.Focus()
    End Sub

    Private Sub btn_MC_Requests_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_MC_Requests.ItemClick
        Dim frm As New Logistics.frm_MC_Requests()
        class_Procedures.Show_Form(Me, frm, "MC Requests and Orders")
    End Sub

    Private Sub btn_Wizard_New_MC_Request_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Wizard_New_MC_Request.ItemClick
        Dim frm As New Logistics.wzFrm_MC_Request()
        class_Procedures.Show_Form(Me, frm, "MC Requests and Orders", False)
    End Sub

    Private Sub btn_Purchase_Orders_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Purchase_Orders.ItemClick
        Dim frm As New Logistics.frm_Purchase_Orders()
        class_Procedures.Show_Form(Me, frm, "Purchase Orders")
    End Sub


    'Private Sub btn_Wizard_New_Purchase_Order_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Wizard_New_Purchase_Order.ItemClick
    '    Dim frm As New Logistics.wzFrm_Purchase_Order()
    '    class_Procedures.Show_Form(Me, frm, "Purchase Orders", False)
    'End Sub

    Private Sub btn_MC_Transactions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_MC_Transactions.ItemClick
        Dim frm As New Logistics.frm_MC_Transactions()
        class_Procedures.Show_Form(Me, frm, "Receiving and Transfers")
    End Sub

    Private Sub btn_Wizard_New_MC_Transaction_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Wizard_New_MC_Transaction.ItemClick
        Dim frm As New Logistics.wzFrm_MC_Transaction()
        class_Procedures.Show_Form(Me, frm, "Receiving and Transfers", False)
    End Sub

    Private Sub btn_Inventory_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Inventory.ItemClick
        Dim frm As Logistics.frm_Unit_Inventory = New Logistics.frm_Unit_Inventory()
        class_Procedures.Show_Form(Me, frm, "Inventory Management")
    End Sub

    Private Sub MCDepUnits_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_MCDepUnits.ItemClick
        Dim frm As MC_For_Reprice = New MC_For_Reprice()
        class_Procedures.Show_Form(Me, frm, "Spare Parts Master List")
    End Sub

    Private Sub Depo_For_Reprice_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Depo_For_Reprice.ItemClick
        Dim frm As Repricing_List = New Repricing_List()
        class_Procedures.Show_Form(Me, frm, "For Repricing List")
    End Sub

    Private Sub REPO_Pricelist_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_REPO_Pricelist.ItemClick
        Dim frm As PriceList_Summary = New PriceList_Summary()
        class_Procedures.Show_Form(Me, frm, "PRICELIST SUMMARY")
    End Sub
    Private Sub btn_iREPO_Units_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_iREPO_Units.ItemClick
        Dim frm As frm_iREP_Units = New frm_iREP_Units()
        class_Procedures.Show_Form(Me, frm, "iREP Units")
    End Sub

    Private Sub btn_for_Reprice_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_for_Reprice.ItemClick
        Dim frm As frm_Repricing_List_iREP = New frm_Repricing_List_iREP()
        class_Procedures.Show_Form(Me, frm, "INACTIVE REPO FOR REPRICING LIST")
    End Sub

    Private Sub btn_Journal_Cashiering_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Journal_Cashiering.ItemClick
        Dim frm As New BranchAccounting.Forms.frm_Cashiering()
        class_Procedures.Show_Form(Me, frm, "Branch Cashiering")
    End Sub

    Private Sub btn_Journal_Collections_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Journal_Collections.ItemClick
        Dim frm As New BranchAccounting.Forms.frm_Collection()
        class_Procedures.Show_Form(Me, frm, "Branch Collections")
    End Sub

    Private Sub btn_Journal_Credit_Memo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Journal_Credit_Memo.ItemClick
        Dim frm As New Accounting.frm_Credit_Memo()
        class_Procedures.Show_Form(Me, frm, "Branch Credit Memo")
    End Sub

    Private Sub btn_Journal_MC_Sales_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Journal_MC_Sales.ItemClick
        Dim frm As New BranchAccounting.Forms.frm_MC_Sale()
        class_Procedures.Show_Form(Me, frm, "MC Sales")
    End Sub

    Private Sub btn_Journal_SPA_Sales_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Journal_SPA_Sales.ItemClick
        Dim frm As New BranchAccounting.Forms.frm_SPA_Sale()
        class_Procedures.Show_Form(Me, frm, "SPA Sales")
    End Sub

    Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
        Dim frm As New BranchAccounting.Forms.frm_Journal_Entries_Branch()
        class_Procedures.Show_Form(Me, frm, "Journal Entries")
    End Sub

    Private Sub Bar_PettyCash_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Bar_PettyCash.ItemClick
        If Not sBranchCode.Equals("000") Then
            class_Saga_Procedures.Show_Expense(class_Saga_Variables.sBranchCode, 0)
        Else
            class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "HO cannot create new Expense Transaction.", "Invalid Branch", True)
        End If
    End Sub

    Private Sub btn_Petty_Cash_Transactions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Petty_Cash_Transactions.ItemClick
        Dim frm As New Petty_Cash.frm_Petty_Cash_Transactions()
        class_Procedures.Show_Form(Me, frm, "Petty Cash Expense Summary")

    End Sub

    Private Sub btn_Ticket_New_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Ticket_New.ItemClick
        Dim frm As New SagaSupport.Forms.frm_Ticket()
        class_Procedures.Show_Form(Me, frm, "Create New Ticket", False)
        frm.xuc_Ticket.Control_Initialize()
        frm.xuc_Ticket.Control_New()
    End Sub

    Private Sub btn_Helps_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Helps.ItemClick
        Dim frm As New SagaSupport.Forms.frm_Helps()
        class_Procedures.Show_Form(Me, frm, "FAQs and Help")
    End Sub

    Private Sub btn_Ticket_List_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Ticket_List.ItemClick
        Dim frm As SagaSupport.Forms.frm_Tickets = New SagaSupport.Forms.frm_Tickets()
        class_Procedures.Show_Form(Me, frm, "Created Ticket List")
    End Sub

    Private Sub btn_System_Request_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_System_Request.ItemClick
        Dim frm As New SagaAssets.Forms.frm_Request()
        class_Procedures.Show_Form(Me, frm, "System Request", False)
        frm.xuc_Request.Control_Initialize()
        frm.xuc_Request.Control_New()
    End Sub

    Private Sub btn_System_Requests_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_System_Requests.ItemClick
        Dim frm As New SagaAssets.Forms.frm_Requests()
        class_Procedures.Show_Form(Me, frm, "System Requests")
    End Sub

    Private Sub btn_PDC1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_PDC1.ItemClick
        Dim xfrm As SagaSpareParts.Forms.Cashiering.frm_PDC = New SagaSpareParts.Forms.Cashiering.frm_PDC()
        class_Procedures.Show_Form(Me, xfrm, "Sub-Dealer Post Dated Check")
    End Sub

    Private Sub btn_Transmittals_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Transmittals.ItemClick
        Dim frm As New SagaAssets.Forms.frm_Transmittal()
        class_Procedures.Show_Form(Me, frm, "System Transmittals")
    End Sub

    Private Sub btn_Update_Package_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Update_Package.ItemClick
        class_Connections.Create_XML_Update(Me, Toggle_Mandatory.Checked)
        class_Connections.Create_App_Backup(Me, Toggle_DevExpress.Checked, class_Saga_Variables.sDLLFiles)
    End Sub

End Class