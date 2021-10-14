Imports System.Xml
Imports System.IO
Imports wSClassLib.myModules
Imports DevExpress.Compression
Imports System.Windows.Forms
Imports MyClassLibrary.Classes

Public Class Admin_BackupAppl

    Private Sub Admin_BackupAppl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_URL.Text = RegKeyGet("Application", "UpdateURL", "UpdateURL")
        txt_changeLog.Text = RegKeyGet("Application", "ChangeLog", "ChangeLog")
        txt_LocPath.Text = RegKeyGet("Application", "FilePath", "FilePath")
        txt_Fileversion.Text = mFileVersion
        txt_buildNo.Text = mBuildNo
        txt_Appname.Text = mAppName
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Save.ItemClick
        RegKeySet("Application", "UpdateURL", txt_URL.Text)
        RegKeySet("Application", "ChangeLog", txt_changeLog.Text)
        RegKeySet("Application", "FilePath", txt_LocPath.Text)
    End Sub
    Public Class item
        Public Title As String
        Public Version As String
        Public url As String
        Public changelog As String
        Public mandatory As String
    End Class
    Private Sub btn_Execute_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Execute.ItemClick
        splash_Show("Back up file/s ongoing.")
        CreateXML()

        If cInclApp.Checked = True Then
            CompressedFiles()
        End If
        splash_Close()
    End Sub

    Sub CreateXML()
        Dim writer As New XmlTextWriter(txt_LocPath.Text & "\" & txt_Appname.Text & ".xml", System.Text.Encoding.UTF8)
        writer.WriteStartDocument()
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("item")

        writer.WriteStartElement("version")
        writer.WriteString(mBuildNo)
        writer.WriteEndElement()

        writer.WriteStartElement("url")
        writer.WriteString(txt_URL.Text & txt_Appname.Text & ".zip")
        writer.WriteEndElement()

        writer.WriteStartElement("changelog")
        writer.WriteString(txt_URL.Text & txt_changeLog.Text)
        writer.WriteEndElement()

        writer.WriteStartElement("mandatory")
        writer.WriteString(CBool(TMandatory.EditValue).ToString.ToLower)
        writer.WriteEndElement()

        writer.WriteEndDocument()
        writer.Close()
    End Sub
    Sub CompressedFiles()
        'Dim mPath As String = "d:\webmharjun"
        'Dim mExtractPath As String = "ab.zip"
        'ZipFile.CreateFromDirectory(mPath, "\" & mExtractPath)
        ''zipArchieved
        Dim mPath As String = txt_LocPath.Text
        'Dim mExtractPath As String = "ab.zip"
        Dim path As New IO.DirectoryInfo(Application.StartupPath)
        Using myStream As Stream = New MemoryStream(System.Text.Encoding.UTF8.GetBytes("DevExpress"))
            Using myZippedStream As Stream = New FileStream(mPath & "\" & mAppName & ".zip", System.IO.FileMode.Create)
                Using mZip As New ZipArchive
                    With mZip
                        'Dim files As IO.FileInfo() = Path.GetFiles("*.exe")
                        'For Each file As IO.FileInfo In files
                        '    .AddFile(file.Name)
                        'Next
                        mZip.AddFile("IntegratedCoreSystems.exe")
                        mZip.AddFile("wSClassLib.dll")
                        mZip.AddFile("BranchAccounting.dll")
                        mZip.AddFile("AutoUpdater.NET.dll")

                        If tInclLib.IsOn = True Then

                            Dim dllFiles As IO.FileInfo() = path.GetFiles("*.dll")
                            For Each file As IO.FileInfo In dllFiles
                                .AddFile(file.Name)
                            Next
                        End If
                        mZip.Save(myZippedStream)
                    End With
                End Using
                'Using archive As New ZipArchive()


                '    archive.AddStream("myStream", myStream)
                '    archive.Save(myZippedStream)
                'End Using
            End Using
        End Using
    End Sub

    Private Sub Admin_BackupAppl_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Initialize_ToolBars(Me, BarManager1)
    End Sub
End Class