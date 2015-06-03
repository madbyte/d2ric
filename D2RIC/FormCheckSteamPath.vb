Imports System.Globalization, System.Threading, System.Resources
Imports Microsoft.Win32

Public Class FormCheckSteamPath
    ' Declare a Resource Manager instance.
    Dim LocRM As New ResourceManager("D2RIC.Resources", GetType(FormCheckSteamPath).Assembly)
    Dim Dota2Path As String = ""

    Public Sub New()
        ' Sets the UI culture to the choosen language
        If My.Settings.lang <> "" Then
            Thread.CurrentThread.CurrentUICulture = New CultureInfo(My.Settings.lang)
        Else
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("en")
        End If

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
    End Sub

    Private Sub FormCheckSteamPath_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (My.Settings.dota2path <> "") Then
            TextBox1.Text = Microsoft.VisualBasic.Left(My.Settings.dota2path, My.Settings.dota2path.IndexOf("\SteamApps"))
            If My.Computer.FileSystem.DirectoryExists(My.Settings.dota2path) Then
                FormMain.Visible = True
                Me.Close()
            Else
                MessageBox.Show(LocRM.GetString("checkPath"))
            End If
        Else
            IsDotaAvailble()
            Check(Dota2Path + "\dota\itembuilds")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim path As String
        Dota2Path = TextBox1.Text
        path = Dota2Path + "\dota\itembuilds"
        Check(path)
    End Sub

    Private Sub Check(ByVal dota_path As String)
        If My.Computer.FileSystem.DirectoryExists(dota_path) Then
            ' existiert
            My.Settings.dota2path = dota_path
            My.Settings.Save()
            FormMain.Visible = True
            Me.Close()
        Else
            ' existiert nicht
            MessageBox.Show(LocRM.GetString("checkPath"))
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Using FolderBrowserDialog1 As FolderBrowserDialog = New FolderBrowserDialog
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                TextBox1.Text = FolderBrowserDialog1.SelectedPath
            End If
        End Using
    End Sub

    Public Sub IsDotaAvailble()
        ' Check if it's 64 bit system
        Dim Is64Bit As Boolean = Environment.Is64BitOperatingSystem

        ' Get registery key
        Dim dota2Key = Registry.LocalMachine.OpenSubKey("SOFTWARE\" + If(Is64Bit, "Wow6432Node\", "") + "Microsoft\Windows\CurrentVersion\Uninstall\Steam App 570")
        If dota2Key IsNot Nothing Then
            If Not String.IsNullOrEmpty(dota2Key.ToString) Then
                ' Get installation directory of Dota2
                Dim dotaKeyValue = dota2Key.GetValue("InstallLocation")
                If Not String.IsNullOrEmpty(dotaKeyValue.ToString) Then
                    Dota2Path = dotaKeyValue.ToString()
                    Return
                End If
            End If
        End If
        Dota2Path = "Error!"
    End Sub

End Class
