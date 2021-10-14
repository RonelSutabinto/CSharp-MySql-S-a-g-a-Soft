Imports AutoUpdaterDotNET

Public Class Admin_AutoUpdate

    Private Sub Admin_AutoUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub CheckForUpdatesMirror1()
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://122.3.54.38/Autoupdate/version.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        'If newestversion.Contains(currentversion) Then
        '    MsgBox("You are up to date!")
        'Else
        '    MsgBox("There is a new update we, will download it now for you.")
        '    WebBrowser1.Navigate("http://122.3.54.38/Autoupdate/IntegratedCoreSystems.exe")
        'End If
        If newestversion = Login.Application_Version.Text Then
            MsgBox("You are up to date!", vbInformation, Application.CompanyName)
        Else
            MsgBox("There is a new update we will download it now for you.", vbInformation, Application.CompanyName)
            WebBrowser1.Navigate("http://122.3.54.38/Autoupdate/IntegratedCoreSystems.exe")
        End If
        'MsgBox(newestversion & " - " & Application.ProductVersion)
    End Sub

    Private Sub cmd_autoupdates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_autoupdateM1.Click
        Process.Start("AutoUpdateM1.exe")
        End
    End Sub

    Sub CheckForUpdatesMirror2()
        'Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://124.107.148.186/Autoupdate/version.txt")
        'Dim response As System.Net.HttpWebResponse = request.GetResponse()
        'Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        'Dim newestversion As String = sr.ReadToEnd()
        'Dim currentversion As String = Application.ProductVersion
        ''If newestversion.Contains(currentversion) Then
        ''    MsgBox("You are up to date!")
        ''Else
        ''    MsgBox("There is a new update we, will download it now for you.")
        ''    WebBrowser1.Navigate("http://124.107.148.186/Autoupdate/IntegratedCoreSystems.exe")
        ''End If
        'If newestversion = Login.version.Text Then
        '    MsgBox("You are up to date!", vbInformation, Application.CompanyName)
        'Else
        '    MsgBox("There is a new update we will download it now for you.", vbInformation, Application.CompanyName)
        '    WebBrowser1.Navigate("http://124.107.148.186/Autoupdate/IntegratedCoreSystems.exe")
        'End If
        ''MsgBox(newestversion & " - " & Application.ProductVersion)

        Dim document As XDocument = XDocument.Load("http://124.107.148.186/Autoupdate/Autoupdate/IntegratedCoreSystems.xml")
        Dim title = From t In document.Descendants("version") Select t.Value
        Login.curversion.Text = title.First
        If Application.ProductVersion = Login.curversion.Text Then
            MsgBox("You are up to date!", vbInformation, Application.CompanyName)
        Else
            MsgBox("There is a new update we will download it now for you.", vbInformation, Application.CompanyName)
            WebBrowser1.Navigate("http://124.107.148.186/Autoupdate/AutoUpdate/IntegratedCoreSystems.exe")
        End If
    End Sub

    Private Sub cmd_updateMirror3_Click(sender As Object, e As EventArgs) Handles cmd_updateMirror3.Click
        show_Update(False)
    End Sub

    Friend Sub show_Update(ByVal bMandatory As Boolean)
        AutoUpdater.Start($"http://124.107.148.186/AutoUpdate/AutoUpdate/IntegratedCoreSystems.xml")
        AutoUpdater.Mandatory = bMandatory
        AutoUpdater.ReportErrors = True
    End Sub

    Private Sub cmd_autoupdateM2_Click(sender As Object, e As EventArgs) Handles cmd_autoupdateM2.Click
        Dim document As XDocument = XDocument.Load("http://124.107.148.186/Autoupdate/Autoupdate/IntegratedCoreSystems.xml")
        Dim title = From t In document.Descendants("version") Select t.Value

        If Me.GetType.Assembly.GetName.Version.ToString = title.First Then
            'Login.curversion.Text = title.First
            ' MsgBox(title.First & " - " & Application.ProductVersion & " - " & Me.GetType.Assembly.GetName.Version.ToString)
            ' If Application.ProductVersion = Login.curversion.Text Then
            ' MsgBox("Go to update!", vbInformation, Application.CompanyName)
            Process.Start("AutoUpdateM2.exe")
        Else
            MsgBox("You don't have the same File Version. Please use MIRROR 3 first prior to this process. ", vbInformation, Application.CompanyName)
            ' WebBrowser1.Navigate("http://124.107.148.186/Autoupdate/AutoUpdate/IntegratedCoreSystems.exe")
        End If

        End
    End Sub

    Private Sub Admin_AutoUpdate_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

End Class