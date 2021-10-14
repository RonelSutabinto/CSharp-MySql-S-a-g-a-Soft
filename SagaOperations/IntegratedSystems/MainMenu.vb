Imports AutoUpdaterDotNET
Imports DevExpress.Skins
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Forms
Imports SagaClassLibrary.Modules
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

    End Sub

    Private Sub MainMenu_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        mainForm = Me
        ' SET APPLICATION ICON BG TO TRANSPARENT
        Dim skin As Skin = RibbonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        Dim elem As SkinElement = skin(RibbonSkins.SkinFormApplicationButton)
        elem.Image.SetImage(CType(Nothing, Image), System.Drawing.Color.Empty)
        elem.Size.MinSize = New System.Drawing.Size(44, 42)
        '  CLOSE

        ReadBulletin()
        MarqueeTimer.Enabled = True
        dateStatus.Caption = Format(Now, "MMMM dd, yyyy")
        ApplicationAssemblyVersion.Caption = Application.ProductVersion

        ConnectServerChat()

        class_Saga_Variables.Initialize_Branch()
        class_Saga_Variables.Initialize_COA_Summary()

        class_Procedures.splash_Close()

        Dim timer = New System.Timers.Timer With {
            .Interval = 2 * 60 * 1000
        }
        timer.Start()

        AddHandler timer.Elapsed, AddressOf OnTimedEvent
    End Sub

    Private Sub OnTimedEvent(source As Object, e As System.Timers.ElapsedEventArgs)
        class_Saga_Procedures.Show_Update(False)
    End Sub

    Private Sub MainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        mg_losignout()
    End Sub

    Private Sub MainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub send(ByVal str As String)
        Try
            sWriter = New StreamWriter(client.GetStream)
            sWriter.WriteLine(str)
            sWriter.Flush()
        Catch Ex As Exception
            xUpdate("You're not connected to Broadcast Server")
        End Try
    End Sub

    Delegate Sub _xUpdate(ByVal str As String)

    Sub xUpdate(ByVal str As String)
        If InvokeRequired Then
            Invoke(New _xUpdate(AddressOf xUpdate), str)
        Else
            GroupMsg.AppendText(str & vbNewLine)
        End If
    End Sub

    Sub read(ByVal ar As IAsyncResult)
        Try
            xUpdate(New StreamReader(client.GetStream).ReadLine)
            client.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf read, Nothing)
        Catch Ex As Exception
            xUpdate("You are disconnected from Broadcast Server")
            Exit Sub
        End Try
    End Sub

    Sub ReadBulletin()

        If Connection_Form.txtServer.Text = "124.107.148.186" Then
            '  Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://" & Decrypt(class_Tools.RegKeyGet("HostServer", "HostServer", "")) & "/Autoupdate/AutoUpdate/Bulletins.txt")
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://124.107.148.186/Autoupdate/AutoUpdate/Bulletins.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            txt_Bulletin.Text = newestversion
        ElseIf Connection_Form.txtServer.Text = "192.168.13.15" Then
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://192.168.13.15/Autoupdate/AutoUpdate/Bulletins.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            txt_Bulletin.Text = newestversion
        Else

            ''  Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://" & Decrypt(class_Tools.RegKeyGet("HostServer", "HostServer", "")) & "/Autoupdate/AutoUpdate/Bulletins.txt")
            'Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://124.107.148.186/Autoupdate/AutoUpdate/Bulletins.txt")
            'Dim response As System.Net.HttpWebResponse = request.GetResponse()
            'Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            'Dim newestversion As String = sr.ReadToEnd()
            'txt_Bulletin.Text = newestversion

        End If
    End Sub

    Sub ConnectServerChat()
        If Connection_Form.txtServer.Text = "124.107.148.186" Then
            Try
                clientB = New TcpClient(class_Tools.Decrypt(class_Tools.RegKeyGet("HostServer", "HostServer", String.Empty)), CInt("3819"))
                clientB.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf readB), Nothing)

                BroadcastServ.Caption = "BROADCAST"
                BroadcastServ.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White
                BroadcastServ.ItemAppearance.Normal.BackColor = System.Drawing.Color.Green
            Catch Ex As Exception

                xUpdateB("Can't connect to the Broadcast Server!")
            End Try
        ElseIf Connection_Form.txtServer.Text = "192.168.13.15" Then
            Try
                clientB = New TcpClient("192.168.13.15", CInt("3819"))
                clientB.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf readB), Nothing)

                BroadcastServ.Caption = "BROADCAST"
                BroadcastServ.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White
                BroadcastServ.ItemAppearance.Normal.BackColor = System.Drawing.Color.Green
            Catch Ex As Exception

                xUpdateB("Can't connect to the Broadcast Server!")
            End Try
        Else
        End If

    End Sub

    Private Sub Btn_Customers_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Customers.ItemClick
        Dim xfrm As Persons.frm_Customers = New Persons.frm_Customers()
        class_Procedures.Show_Form(Me, xfrm, "Customers Management")

        'Dim xfrm As frm_Customer_Information = New frm_Customer_Information()
        'class_Procedures.Show_Form(Me, xfrm, "CUSTOMER INFORMATION")
    End Sub

    Private Sub SALESToolsMC_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles SALESToolsMC.ItemClick
        Dim frm As IS_SALES_Release = New IS_SALES_Release()
        class_Procedures.Show_Form(Me, frm, "RELEASE", False)
    End Sub

    Private Sub SPAREPARTSToolStripMenuItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles SPAREPARTSToolStripMenuItem.ItemClick
        Dim frm As Spare_Parts_Sales = New Spare_Parts_Sales()
        class_Procedures.Show_Form(Me, frm, "SPARE PARTS SALES")
    End Sub

    Private Sub MCOutgoingTool_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MCOutgoingTool.ItemClick
        'IS_Inventory_Outgoing.Text = "OUTGOING"
        'Me.IsMdiContainer = True
        'IS_Inventory_Outgoing.MdiParent = Me
        'IS_Inventory_Outgoing.Show()
        'IS_Inventory_Outgoing.Focus()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MCReceivingTool.ItemClick
        'IS_Inventory_Receiving.Text = "RECEIVING"
        'Me.IsMdiContainer = True
        'IS_Inventory_Receiving.MdiParent = Me
        'IS_Inventory_Receiving.Show()
        'IS_Inventory_Receiving.Focus()
    End Sub

    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles SALESToolStripMenuItem.ItemClick
        'IS_Inventory_Deduct.Text = "DEDUCT"
        'IS_Inventory_Deduct.Show()
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles LISTOFINVENTORYToolStripMenuItem.ItemClick
        'Me.IsMdiContainer = True
        'IS_Sales_Payments.MdiParent = Me
        'IS_Sales_Payments.Show()
        'IS_Sales_Payments.Focus()
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

    Private Sub BarButtonItem1_ItemClick_3(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles TRANSACTIONSToolStripMenuItem.ItemClick
        'Me.IsMdiContainer = True
        'IS_Cashiering_Transactions.MdiParent = Me
        'IS_Cashiering_Transactions.Show()
        'IS_Cashiering_Transactions.Focus()
    End Sub

    Private Sub BarButtonItem3_ItemClick_2(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ERRORCORRECTCASHIERINGToolStripMenuItem.ItemClick
        'Me.IsMdiContainer = True
        'admin_errorcorrectcashiering.MdiParent = Me
        'admin_errorcorrectcashiering.Show()
        'admin_errorcorrectcashiering.Focus()
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ERRORCORRECTCOLLECTIONToolStripMenuItem.ItemClick
        'Me.IsMdiContainer = True
        'admin_errorcorrectpayment.MdiParent = Me
        'admin_errorcorrectpayment.Show()
        'admin_errorcorrectpayment.Focus()
    End Sub

    Private Sub BarButtonItem3_ItemClick_4(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CORPToolStripMenuItem.ItemClick
        'admin_UpdateCorp.ShowDialog()
    End Sub

    Private Sub BarButtonItem6_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RECLASSIFICATIONToolStripMenuItem.ItemClick
        'Admin_ReclassINVTY.ShowDialog()
    End Sub

    Private Sub BarButtonItem1_ItemClick_6(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles USERCONFIGToolStripMenuItem.ItemClick
        'userConfig.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimeTmr.Tick
        'timeStatus.Caption = Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub CHANGEAPPROVERToolStripMenuItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CHANGEAPPROVERToolStripMenuItem.ItemClick
        'maint_ChangeApprover_Sales.ShowDialog()
    End Sub

    Private Sub MIGRATEACCOUNTToolStripMenuItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MIGRATEACCOUNTToolStripMenuItem.ItemClick
        'Me.IsMdiContainer = True
        'Dim formVariable = New admin_MigrateAccount With {
        '    .MdiParent = Me
        '}
        'formVariable.Show()
        'formVariable.Focus()
    End Sub

    Private Sub CreditMemoADJ_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CreditMemoADJ.ItemClick
        'Me.IsMdiContainer = True
        'Admin_CreditMemo.MdiParent = Me
        'Admin_CreditMemo.Show()
        'Admin_CreditMemo.Focus()
    End Sub

    Private Sub statusBrCode_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles statusBrCode.ItemClick
        mg_CountTotalAccount()
        ShowTotalCount.ShowDialog()
    End Sub

    Sub mg_CountTotalAccount()

        'Dim connection As New SqlConnection("Server='" & My.Settings.ServerName & "'; Database = '" & My.Settings.DatabaseName & "'; Integrated Security = true")
        Dim Parameters As SqlParameter() = {}
        'Dim rs As SqlDataReader

        ShowTotalCount.LviewTotalCnt.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_CountTotalAccount"
        
        
        New SqlParameter("@ParamBranchCode", statusBrCode.Caption)

        

        

        Do While myDataReader.Read()
                Dim li As ListViewItem = ShowTotalCount.LviewTotalCnt.Items.Add(mydatareader.Item("BranchCode").ToString())
                li.SubItems.Add(mydatareader.Item("AccountStatus").ToString())
                li.SubItems.Add(mydatareader.Item("TotCnt").ToString())


        End Using
        'class_Database.mySQLConnection.Close()



        End Using
        'class_Database.mySQLConnection.Close()


        'MsgBox("Successful Updating")

    End Sub

    Sub mg_losignout()

        Dim Parameters As SqlParameter() = {}
        'Dim rs As SqlDataReader

        ShowTotalCount.LviewTotalCnt.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_losignout"
        
        
        New SqlParameter("@ParamUsername", App_User_Name.Caption)

        

        

        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                class_Procedures.Set_Message(Me, class_Procedures.MsgMode.Info, myDataReader("Message").ToString(), "Logout")
            End If

        End Using
        'class_Database.mySQLConnection.Close()


        MsgBox(Err.Number & " - " & Err.Description, vbInformation, Application.CompanyName)
        'class_Database.mySQLConnection.Close()


        'MsgBox("Successful Updating")


    End Sub

    Private Sub ActualCol_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ActualCol.ItemClick
        Me.IsMdiContainer = True
        rpt_ActualCollections.MdiParent = Me
        rpt_ActualCollections.Show()
        rpt_ActualCollections.Focus()
    End Sub

    Private Sub Cashiering_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Cashiering.ItemClick
        Me.IsMdiContainer = True
        rpt_Cashiering.MdiParent = Me
        rpt_Cashiering.Show()
        rpt_Cashiering.Focus()
    End Sub

    Private Sub RelMonitoring_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles RelMonitoring.ItemClick
        Me.IsMdiContainer = True
        rpt_Actual_Releases.MdiParent = Me
        rpt_Actual_Releases.Show()
        rpt_Actual_Releases.Focus()
    End Sub

    Private Sub CreditMemo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CreditMemo.ItemClick
        Me.IsMdiContainer = True
        rpt_CreditMemo.MdiParent = Me
        rpt_CreditMemo.Show()
        rpt_CreditMemo.Focus()
    End Sub

    Private Sub ibpbutton_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibpbutton.ItemClick
        Me.IsMdiContainer = True
        rpt_ShowIBT.MdiParent = Me
        rpt_ShowIBT.Show()
        rpt_ShowIBT.Focus()
    End Sub

    Private Sub SPReceivingTool_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SPReceivingTool.ItemClick
        'maint_model_SP.ShowDialog()

        'Me.IsMdiContainer = True
        'SPA_Receiving.MdiParent = Me
        'SPA_Receiving.Show()
        'SPA_Receiving.Focus()
        'SPA_Receiving.ShowDialog()
        'SPA_Receiving.ShowDialog()
    End Sub

    Private Sub SPOutgoingTool_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SPOutgoingTool.ItemClick
        'Me.IsMdiContainer = True
        'SPA_Outgoing.MdiParent = Me
        'SPA_Outgoing.Show()
        'SPA_Outgoing.Focus()
        'SPA_Outgoing.ShowDialog()
    End Sub

    Private Sub spaSales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles spaSales.ItemClick
        'Me.IsMdiContainer = True
        'SPA_Sales_Summary.MdiParent = Me
        'SPA_Sales_Summary.Show()
        'SPA_Sales_Summary.Focus()
    End Sub

    Private Sub NewUpdate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Check_Update.ItemClick
        class_Saga_Procedures.Show_Update(False, True, True)
    End Sub

    Private Sub SPACol_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SPACol.ItemClick
        'SPA_Sales_Inquiry.toolPost.Enabled = True
        'SPA_Sales_Inquiry.btn_Payment.Enabled = True
        'SPA_Search_Sales_Inquiry.ShowDialog()
    End Sub

    Private Sub ErrCorrSPSales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ErrCorrSPSales.ItemClick
        'SPA_ErrorCorrect.ShowDialog()
    End Sub

    Private Sub AcctCan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles AcctCan.ItemClick
        'Me.IsMdiContainer = True
        'admin_acctCancel.MdiParent = Me
        'admin_acctCancel.Show()
        'admin_acctCancel.Focus()
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
        'Admin_DisapprovedTransactions.ShowDialog()
    End Sub

    Private Sub AECodeMgmt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles AECodeMgmt.ItemClick
        'Me.IsMdiContainer = True
        'Admin_RegAECode.MdiParent = Me
        'Admin_RegAECode.Show()
        'Admin_RegAECode.Focus()
    End Sub

    Private Sub ResellerMgmt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ResellerMgmt.ItemClick
        'Me.IsMdiContainer = True
        'Admin_AgentOutletMgmt.MdiParent = Me
        'Admin_AgentOutletMgmt.Show()
        'Admin_AgentOutletMgmt.Focus()
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

    Private Sub SPMasterMgmt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SPMasterMgmt.ItemClick

    End Sub

    Private Sub InsuRpt_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles InsuRpt.ItemClick
        'Me.IsMdiContainer = True
        'rpt_InsuranceRpt.MdiParent = Me
        'rpt_InsuranceRpt.Show()
        'rpt_InsuranceRpt.Focus()
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

    Sub readB(ByVal ar As IAsyncResult)
        Try
            xUpdateB(New StreamReader(clientB.GetStream).ReadLine)
            clientB.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf readB, Nothing)
        Catch Ex As Exception
            xUpdateB("You are disconnected from Broadcast Server")
            Exit Sub
        End Try
    End Sub

    Delegate Sub _xUpdateB(ByVal str As String)

    Sub xUpdateB(ByVal str As String)
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

    Sub sendB(ByVal str As String)
        Try
            sWriter = New StreamWriter(clientB.GetStream)
            sWriter.WriteLine(str)
            sWriter.Flush()
        Catch Ex As Exception
            xUpdate("You're not connected to Broadcast Server")
        End Try
    End Sub

    Private Sub clos_Click(sender As Object, e As EventArgs) Handles clos.Click
        BroadcastPanel.Visible = False
    End Sub

    Private Sub BroadcastServ_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BroadcastServ.ItemClick
        'If BroadCastServer.Caption = "ONLINE" Then
        '    Try
        '        'client = New TcpClient(Decrypt(class_Tools.RegKeyGet("HostServer", "HostServer", "")), CInt("3818"))
        '        clientB = New TcpClient("124.107.148.186", CInt("3819"))
        '        clientB.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf readB), Nothing)

        '        BroadcastServ.Caption = "OFFLINE"
        '        BroadcastServ.ItemAppearance.Normal.ForeColor = Color.White
        '        BroadcastServ.ItemAppearance.Normal.BackColor = Color.Green

        '        ' send(txt_FLName.Text & " is now online")
        '    Catch Ex As Exception

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

    Private Sub sp_CustDep_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles sp_CustDep.ItemClick
        Dim frm As SPA_CustDep = New SPA_CustDep()
        class_Procedures.Show_Form(Me, frm, "SALES", False)
    End Sub

    Private Sub spa_CustDepSummary_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles spa_CustDepSummary.ItemClick

    End Sub

    Private Sub MarqueeTimer_Tick(sender As Object, e As EventArgs) Handles MarqueeTimer.Tick
        'Dim LocX As Integer
        'Dim LocY As Integer

        'LocX = Label1.Location.X
        'LocY = Label1.Location.Y

        'If Label1.Location.Y + Label1.Height < 0 Then
        '    Label1.Location = New Point(LocX, LocY)
        '    MsgBox(LocX & " - " & LocY)
        'Else
        '    Label1.Location = New Point(Label1.Location.X, Label1.Location.Y - 3)
        'End If
        '   MsgBox(txt_Bulletin.Location.X & " - " & txt_Bulletin.Location.Y)
        txt_Bulletin.Location = New Point(txt_Bulletin.Location.X, txt_Bulletin.Location.Y - 1)
        If txt_Bulletin.Location = New Point(18, -txt_Bulletin.Height) Then
            ' MsgBox(Label1.Location)
            ' txt_Bulletin.Location = New Point(3, 379)  18, 320
            txt_Bulletin.Location = New Point(18, 400)
            '  MsgBox(Label1.Location)
        End If
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

    Private Sub CollectionAging_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CollectionAging.ItemClick
        'Me.IsMdiContainer = True
        'rpt_CollectionAging.MdiParent = Me
        'rpt_CollectionAging.Show()
        'rpt_CollectionAging.Focus()
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
        Login.ShowDialog()
    End Sub

    Private Sub mcForApprovalInv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mcForApprovalInv.ItemClick
        Dim frm As IS_Inventory_List = New IS_Inventory_List()
        class_Procedures.Show_Form(Me, frm, "For Approval", False)
    End Sub

    Private Sub mcInTransitInv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mcInTransitInv.ItemClick
        'Dim frm As IS_Inventory_List = New IS_Inventory_List()
        'class_Procedures.Show_Form(Me, frm, "For Transport", False)
    End Sub

    Private Sub mcPendingInv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mcPendingInv.ItemClick
        'Dim frm As IS_Inventory_List = New IS_Inventory_List()
        'class_Procedures.Show_Form(Me, frm, "PENDING", False)
    End Sub

    Private Sub mcDisapprovedInv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mcDisapprovedInv.ItemClick
        'Dim frm As IS_Inventory_List = New IS_Inventory_List()
        'class_Procedures.Show_Form(Me, frm, "Disapproved", False)
    End Sub

    Private Sub SPA_SubDealerMgmt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SPA_SubDealerMgmt.ItemClick
        'frm_SubDealer.ShowDialog()
    End Sub

    Private Sub RepositoryItemSearchControl_KeyDown(sender As Object, e As KeyEventArgs) Handles RepositoryItemSearchControl.KeyDown
        If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
            ' Try

            If SearchType.EditValue = "MC ACCOUNT" Then
                Dim SearchText As String
                SearchText = (CType(sender, BaseEdit)).Text.Trim
                IS_Sales_ReleaseAccount_List.Text = "SEARCH CONTROL"
                IS_Sales_ReleaseAccount_List.quickSearch.Text = SearchText
                IS_Sales_ReleaseAccount_List.ShowDialog()

            ElseIf SearchType.EditValue = "IB-MC ACCOUNT" Then
                Dim SearchText As String
                SearchText = (CType(sender, BaseEdit)).Text.Trim
                IS_Sales_ReleaseAccount_List.Text = "IB-MC ACCOUNT"
                IS_Sales_ReleaseAccount_List.quickSearch.Text = SearchText
                IS_Sales_ReleaseAccount_List.ShowDialog()

            ElseIf SearchType.EditValue = "MC INVENTORY" Then
                Dim SearchText As String
                SearchText = (CType(sender, BaseEdit)).Text.Trim
                IS_Inventory_DetailedSummary.quickSearch.EditValue = SearchText
                IS_Inventory_DetailedSummary.searchInventoryLocalBranch()
                'IS_Inventory_DetailedSummary.ShowDialog()
                Me.IsMdiContainer = True
                IS_Inventory_DetailedSummary.MdiParent = Me
                IS_Inventory_DetailedSummary.Show()
                IS_Inventory_DetailedSummary.Focus()

                'ElseIf SearchType.EditValue = "IB-MC INVENTORY" Then
                '    Dim SearchText As String
                '    SearchText = (CType(sender, BaseEdit)).Text.Trim
                '    IS_Inventory_DetailedSummary.Text = "IB-MC INVENTORY"
                '    IS_Inventory_DetailedSummary.quickSearch.EditValue = SearchText
                '    IS_Inventory_DetailedSummary.SearchWhat()
                '    IS_Inventory_DetailedSummary.ShowDialog()

            ElseIf SearchType.EditValue = "SPA ACCOUNT" Then
                Dim SearchText As String
                SearchText = (CType(sender, BaseEdit)).Text.Trim
                SPA_Search_Sales_Inquiry.txt_Search.Text = SearchText
                SPA_Search_Sales_Inquiry.SPA_Show_Sales_Inquiry()
                SPA_Sales_Inquiry.toolPost.Enabled = False
                SPA_Sales_Inquiry.btn_Payment.Enabled = False
                SPA_Search_Sales_Inquiry.ShowDialog()
            ElseIf SearchType.EditValue = "IB-SPA ACCOUNT" Then
                Dim SearchText As String
                SearchText = (CType(sender, BaseEdit)).Text.Trim
                SPA_Search_Sales_Inquiry.txt_Search.Text = SearchText
                SPA_Search_Sales_Inquiry.SPA_Show_Sales_Inquiry()
                SPA_Sales_Inquiry.toolPost.Enabled = False
                SPA_Sales_Inquiry.btn_Payment.Enabled = False
                SPA_Search_Sales_Inquiry.ShowDialog()
            ElseIf SearchType.EditValue = "SPA INVENTORY" Then
                Dim SearchText As String
                SearchText = (CType(sender, BaseEdit)).Text.Trim

                SPA_BranchInventory.txt_Search.EditValue = SearchText

                Me.IsMdiContainer = True
                SPA_BranchInventory.MdiParent = Me

                SPA_BranchInventory.Show()
                SPA_BranchInventory.Focus()
            End If

        End If
    End Sub

    Private Sub Model_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Model.ItemClick
        'maint_modelfrm.ShowDialog()
    End Sub

    Private Sub Brand_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Brand.ItemClick
        'maint_brandfrm.Show()
    End Sub

    Private Sub Color_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Color.ItemClick
        'maint_itemcolorfrm.ShowDialog()
    End Sub

    Private Sub MadeFrom_ItemClick(sender As Object, e As ItemClickEventArgs) Handles MadeFrom.ItemClick
        'maint_makefrm.ShowDialog()
    End Sub

    Private Sub Vendor_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Vendor.ItemClick
        'maint_vendorfrm.ShowDialog()
    End Sub

    Private Sub Warehouse_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Warehouse.ItemClick
        'maint_whcategoryfrm.ShowDialog()
    End Sub

    Private Sub ItemAttribute_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ItemAttribute.ItemClick
        'maint_item_attrib.ShowDialog()
    End Sub

    Private Sub Backup_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Backup.ItemClick
        'DatabaseBackup.ShowDialog()
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

        Dim formVariable = New rpt_DEPtoREP With {
            .MdiParent = Me,
            .Text = "REPOSSESSED TO HO REPORT"
        }
        formVariable.txt_whcode.EditValue = "REP"
        formVariable.txt_NoofDays.EditValue = 60

        formVariable.Show()
        formVariable.Focus()

    End Sub

    Private Sub InventorySummary_ItemClick(sender As Object, e As ItemClickEventArgs) Handles InventorySummaryPop.ItemClick
        Me.IsMdiContainer = True
        SPA_BranchInventory.MdiParent = Me
        SPA_BranchInventory.Show()
        SPA_BranchInventory.Focus()
    End Sub

    Private Sub CustDepSummaryPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles CustDepSummaryPop.ItemClick
        SPA_Sales_CustDep.ShowDialog()
    End Sub

    Private Sub SPA_TopMovingPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SPA_TopMovingPop.ItemClick
        Me.IsMdiContainer = True
        SPA_TopMoving.MdiParent = Me
        SPA_TopMoving.Show()
        SPA_TopMoving.Focus()
    End Sub

    Private Sub SPA_TopSellingPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SPA_TopSellingPop.ItemClick
        Me.IsMdiContainer = True
        SPA_TopSelling.MdiParent = Me
        SPA_TopSelling.Show()
        SPA_TopSelling.Focus()
    End Sub

    Private Sub SPA_MostExpensivePop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SPA_MostExpensivePop.ItemClick
        Me.IsMdiContainer = True
        SPA_MostExpensive.MdiParent = Me
        SPA_MostExpensive.Show()
        SPA_MostExpensive.Focus()
    End Sub

    Private Sub AgingInventoryPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles AgingInventoryPop.ItemClick
        Me.IsMdiContainer = True
        SPA_InventoryAging.MdiParent = Me
        SPA_InventoryAging.Show()
        SPA_InventoryAging.Focus()
    End Sub

    Private Sub SPA_PerSupplierPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SPA_PerSupplierPop.ItemClick
        Me.IsMdiContainer = True
        SPA_PerSupplier.MdiParent = Me
        SPA_PerSupplier.Show()
        SPA_PerSupplier.Focus()
    End Sub

    Private Sub SPA_CustDepDuePop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SPA_CustDepDuePop.ItemClick
        Me.IsMdiContainer = True
        SPA_ShowDueCustDep.MdiParent = Me
        SPA_ShowDueCustDep.Show()
        SPA_ShowDueCustDep.Focus()
    End Sub

    Private Sub cmd_AcctMasterList_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmd_AcctMasterList.ItemClick
        Me.IsMdiContainer = True
        rpt_AcctMasterlist.MdiParent = Me
        rpt_AcctMasterlist.Show()
        rpt_AcctMasterlist.Focus()
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

    Private Sub mcApprovedInv_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mcApprovedInv.ItemClick
        'Dim frm As IS_Inventory_List = New IS_Inventory_List()
        'class_Procedures.Show_Form(Me, frm, "Approved", False)
    End Sub

    Private Sub InTransitSP_ItemClick(sender As Object, e As ItemClickEventArgs) Handles InTransitSP.ItemClick
        'Dim frm As SPA_InTransit = New SPA_InTransit()
        'class_Procedures.Show_Form(Me, frm, "In Transit", False)
    End Sub

    Private Sub ForApprovalSP_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ForApprovalSP.ItemClick
        'Dim frm As SPA_For_Approval = New SPA_For_Approval()
        'class_Procedures.Show_Form(Me, frm, "For Approval", False)
    End Sub

    Private Sub PendingSP_ItemClick(sender As Object, e As ItemClickEventArgs) Handles PendingSP.ItemClick
        'Dim frm As SPA_Pending = New SPA_Pending()
        'class_Procedures.Show_Form(Me, frm, "PENDING", False)
    End Sub

    Private Sub ApprovedSP_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ApprovedSP.ItemClick
        'Dim frm As SPA_Approved = New SPA_Approved()
        'class_Procedures.Show_Form(Me, frm, "Approved", False)
    End Sub

    Private Sub DisapprovedSP_ItemClick(sender As Object, e As ItemClickEventArgs) Handles DisapprovedSP.ItemClick
        'Dim frm As SPA_Disapproved = New SPA_Disapproved()
        'class_Procedures.Show_Form(Me, frm, "Disapproved", False)
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

    Private Sub MCOrCrInq_ItemClick(sender As Object, e As ItemClickEventArgs) Handles MCOrCrInq.ItemClick
        'Me.IsMdiContainer = True
        'IS_InquiryORNo.MdiParent = Me
        'IS_InquiryORNo.Show()
        'IS_InquiryORNo.Focus()
    End Sub

    Private Sub spaSIORCRInq_ItemClick(sender As Object, e As ItemClickEventArgs) Handles spaSIORCRInq.ItemClick
        'Me.IsMdiContainer = True
        'SPA_SI_Inquiry.MdiParent = Me
        'SPA_SI_Inquiry.Show()
        'SPA_SI_Inquiry.Focus()
    End Sub

    Private Sub SearchControl_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SearchControl.ItemClick

    End Sub

    Private Sub MACompute_ItemClick(sender As Object, e As ItemClickEventArgs) Handles MACompute.ItemClick

    End Sub

    Private Sub AcctDueInquiry_ItemClick(sender As Object, e As ItemClickEventArgs) Handles AcctDueInquiry.ItemClick

    End Sub

    Private Sub JECashiering_ItemClick(sender As Object, e As ItemClickEventArgs) Handles JECashiering.ItemClick

    End Sub

    Private Sub SkinRibbonGalleryBarItem1_GalleryItemClick(sender As Object, e As Ribbon.GalleryItemClickEventArgs) Handles SkinRibbonGalleryBarItem1.GalleryItemClick
        class_Tools.RegKeySet("Application", "Skin", e.Item.Value.ToString)
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
        Me.IsMdiContainer = True
        Dim frmVersionUpServ As New wSClassLib.Admin_BackupAppl With {
            .MdiParent = Me
        }
        frmVersionUpServ.Show()
        frmVersionUpServ.Focus()
    End Sub

    Private Sub AutoUpdateTmr_Tick(sender As Object, e As EventArgs) Handles AutoUpdateTmr.Tick
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

    Private Sub Btn_ComputeAmort_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_ComputeAmort.ItemClick
        'Admin_MCPriceChecker.ShowDialog()
    End Sub

    Private Sub Btn_AcctDueInq_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_AcctDueInq.ItemClick
        'Me.IsMdiContainer = True
        'IS_Sales_Payments.MdiParent = Me

        'IS_Sales_Payments.Panel2.Enabled = False
        'IS_Sales_Payments.txt_TotAmtPaid.Enabled = False
        'IS_Sales_Payments.txt_remarks.Enabled = False
        'IS_Sales_Payments.txt_refno.Enabled = False
        'IS_Sales_Payments.ToolStrip1.Enabled = False

        'IS_Sales_Payments.Show()
    End Sub

    Private Sub Btn_DebitMemo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_DebitMemo.ItemClick
        'Me.IsMdiContainer = True
        'Debit_Memo.MdiParent = Me
        'Debit_Memo.Show()
        'Debit_Memo.Focus()
    End Sub

    Private Sub MCIncomingTool_ItemClick(sender As Object, e As ItemClickEventArgs) Handles MCIncomingTool.ItemClick
        'Me.IsMdiContainer = True
        'IS_Inventory_MC_FromSuppler.MdiParent = Me
        'IS_Inventory_MC_FromSuppler.Show()
        'IS_Inventory_MC_FromSuppler.Focus()
    End Sub

    Private Sub SkinPaletteRibbonGalleryBarItem1_GalleryItemClick(sender As Object, e As Ribbon.GalleryItemClickEventArgs) Handles SkinPaletteRibbonGalleryBarItem1.GalleryItemClick
        class_Tools.RegKeySet("Application", "Pallete", e.Item.Value.ToString)
    End Sub

    Private Sub ClosedAcct_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ClosedAcct.ItemClick
        'Me.IsMdiContainer = True
        'rpt_ClosedAcct.MdiParent = Me
        'rpt_ClosedAcct.Show()
        'rpt_ClosedAcct.Focus()
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

    Private Sub LogoutTimer_Tick(sender As Object, e As EventArgs) Handles LogoutTimer.Tick
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

    Private Sub FreebieList_ItemClick(sender As Object, e As ItemClickEventArgs) Handles FreebieList.ItemClick
        'Me.IsMdiContainer = True
        'rpt_MCFreebieListing.MdiParent = Me
        'rpt_MCFreebieListing.Show()
        'rpt_MCFreebieListing.Focus()
    End Sub

    Private Sub MCAccountPromo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles MCAccountPromo.ItemClick
        'Me.IsMdiContainer = True
        'rpt_MCAccountPromo.MdiParent = Me
        'rpt_MCAccountPromo.Show()
        'rpt_MCAccountPromo.Focus()
    End Sub

    Private Sub Btn_Transports_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Transports.ItemClick
        Dim xfrm As Logistics.frm_Receive_Transfers = New Logistics.frm_Receive_Transfers()
        class_Procedures.Show_Form(Me, xfrm, "MC Transports")
    End Sub

    Private Sub MCDepUnits_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_MCDepUnits.ItemClick
        Dim xfrm As MC_For_Reprice = New MC_For_Reprice()
        class_Procedures.Show_Form(Me, xfrm, "Spare Parts Master List")
    End Sub

    Private Sub Depo_For_Reprice_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Depo_For_Reprice.ItemClick
        Dim xfrm As Repricing_List = New Repricing_List()
        class_Procedures.Show_Form(Me, xfrm, "For Repricing List")
    End Sub

    Private Sub REPO_Pricelist_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_REPO_Pricelist.ItemClick
        Dim xfrm As PriceList_Summary = New PriceList_Summary()
        class_Procedures.Show_Form(Me, xfrm, "PRICELIST SUMMARY")
    End Sub

    Private Sub Btn_Cashiering_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Cashiering.ItemClick
        Dim frm As BranchAccounting.Forms.frm_Cashiering = New BranchAccounting.Forms.frm_Cashiering()
        class_Procedures.Show_Form(Me, frm, "Branch Cashiering")
    End Sub

    Private Sub Btn_Collections_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Collections.ItemClick
        Dim frm As BranchAccounting.Forms.frm_Collection = New BranchAccounting.Forms.frm_Collection()
        class_Procedures.Show_Form(Me, frm, "Branch Collections")
    End Sub

    Private Sub Btn_Credit_Memo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Credit_Memo.ItemClick
        Dim frm As Accounting.frm_Credit_Memo = New Accounting.frm_Credit_Memo()
        class_Procedures.Show_Form(Me, frm, "Branch Credit Memo")
    End Sub

    Private Sub Btn_MC_Sales_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_MC_Sales.ItemClick
        Dim frm As BranchAccounting.Forms.frm_MC_Sale = New BranchAccounting.Forms.frm_MC_Sale()
        class_Procedures.Show_Form(Me, frm, "MC Sales")
    End Sub

    Private Sub Btn_SPA_Sales_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_SPA_Sales.ItemClick
        Dim frm As BranchAccounting.Forms.frm_SPA_Sale = New BranchAccounting.Forms.frm_SPA_Sale()
        class_Procedures.Show_Form(Me, frm, "SPA Sales")
    End Sub

    Private Sub Btn_Journal_Entries_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Journal_Entries.ItemClick
        Dim frm As BranchAccounting.Forms.frm_Journal_Entries_Branch = New BranchAccounting.Forms.frm_Journal_Entries_Branch()
        class_Procedures.Show_Form(Me, frm, "Journal Entries")
    End Sub

    Private Sub Bar_PettyCash_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Bar_PettyCash.ItemClick
        If Not sBranchCode.Equals("000") Then
            class_Saga_Procedures.Show_Expense(class_Saga_Variables.sBranchCode)
        Else
            class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "HO cannot create new Expense Transaction.", "Invalid Branch", True)
        End If
    End Sub

    Private Sub Btn_Petty_Cash_Transactions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Petty_Cash_Transactions.ItemClick
        Dim frm As Petty_Cash.frm_Petty_Cash_Transactions = New Petty_Cash.frm_Petty_Cash_Transactions()
        class_Procedures.Show_Form(Me, frm, "Petty Cash Expense Summary")
    End Sub

    Private Sub Btn_Ticket_New_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Ticket_New.ItemClick
        Dim frm As SagaSupport.Forms.frm_Ticket = New SagaSupport.Forms.frm_Ticket()
        class_Procedures.Show_Form(Me, frm, "Create New Ticket", False)
    End Sub

    Private Sub Purchase_Order_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Purchase_Order.ItemClick
        Dim xfrm As frm_Spare_Parts_Purchase_Orders = New frm_Spare_Parts_Purchase_Orders()
        class_Procedures.Show_Form(Me, xfrm, "Spare Parts Purchase Order")
    End Sub

    Private Sub Btn_Ticket_List_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Ticket_List.ItemClick
        Dim frm As SagaSupport.Forms.frm_Tickets = New SagaSupport.Forms.frm_Tickets()
        class_Procedures.Show_Form(Me, frm, "Created Ticket List")
    End Sub

    Private Sub Btn_Update_Package_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Update_Package.ItemClick
        class_Saga_Procedures.Create_XML_Update(Me)
        class_Saga_Procedures.Create_App_Backup(Me, Toggle_DevExpress.Checked)
    End Sub

End Class