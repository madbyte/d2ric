Imports System.Resources

'This class contains all methods you need on the options page
Public Class OptionsClass
    Friend WithEvents Itembuild As New ItembuildClass
    Dim LocRM As New ResourceManager("D2RIC.Resources", GetType(FormMain).Assembly)

    'Save language setting
    Public Sub ChangeLang()
        Dim lang As String = ""
        Select Case FormMain.ComboBoxLang.SelectedIndex
            Case 0
                lang = "en"
            Case 1
                lang = "de"
            Case 2
                lang = "fr"
            Case 3
                lang = "es"
            Case Else
                lang = "en"
        End Select
        My.Settings.lang = lang
        My.Settings.Save()
    End Sub

    'Set ComboboxLang to the choosen language
    Public Sub InitializeLang()
        Select Case My.Settings.lang
            Case "en"
                FormMain.ComboBoxLang.SelectedIndex = 0
            Case "de"
                FormMain.ComboBoxLang.SelectedIndex = 1
            Case "fr"
                FormMain.ComboBoxLang.SelectedIndex = 2
            Case "es"
                FormMain.ComboBoxLang.SelectedIndex = 3
            Case Else
                FormMain.ComboBoxLang.SelectedIndex = 0
        End Select
    End Sub

    'Delete the backslash of a file path
    Private Function cut_file(ByVal file As String) As String
        While file.Contains("\")
            file = file.Remove(0, 1)
        End While
        Return file
    End Function

    'Create new backups with a timestring in name
    Public Sub Backup()
        If Not IO.Directory.Exists(My.Settings.dota2path & "\Backup") Then
            ' Nein! Jetzt erstellen...
            Try
                IO.Directory.CreateDirectory(My.Settings.dota2path & "\Backup")
                ' Ordner wurde korrekt erstellt!
            Catch ex As Exception
                ' Ordner wurde nich erstellt
                MessageBox.Show(LocRM.GetString("cantCreateFolder"))
            End Try
        End If
        If IO.Directory.Exists(My.Settings.dota2path & "\Backup") Then
            Try
                IO.Directory.CreateDirectory(My.Settings.dota2path & "\Backup\" & System.DateTime.Now.Year.ToString & "-" & System.DateTime.Now.Month.ToString & "-" & System.DateTime.Now.Day.ToString)
                ' Ordner wurde korrekt erstellt!
            Catch ex As Exception
                ' Ordner wurde nich erstellt
                MessageBox.Show(LocRM.GetString("cantCreateFolder"))
            End Try
        End If
        If IO.Directory.Exists(My.Settings.dota2path & "\Backup\" & System.DateTime.Now.Year.ToString & "-" & System.DateTime.Now.Month.ToString & "-" & System.DateTime.Now.Day.ToString) Then
            For Each file As String In IO.Directory.GetFiles(My.Settings.dota2path) ' Get all files in the folder
                IO.File.Copy(file, My.Settings.dota2path & "\Backup\" & System.DateTime.Now.Year.ToString & "-" & System.DateTime.Now.Month.ToString & "-" & System.DateTime.Now.Day.ToString & "\" & cut_file(file), True)  ' Copy the files
            Next
        End If
    End Sub

    'Delete all backups
    Public Sub DeleteBackup()
        If MessageBox.Show(LocRM.GetString("deleteBackupsQuestion"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If IO.Directory.Exists(My.Settings.dota2path & "\Backup") Then
                For Each folder As String In IO.Directory.GetDirectories(My.Settings.dota2path & "\Backup") ' Get all folder
                    IO.Directory.Delete(folder, True) ' Delete the folder
                Next
                For Each file As String In IO.Directory.GetFiles(My.Settings.dota2path & "\Backup") ' Get all files in the folder
                    If Not file.Contains("default") Then
                        IO.File.Delete(file)  ' Delete the files
                    End If
                Next
            End If
        End If
    End Sub

    'Open the backup folder, if it exists
    Public Sub OpenBackup()
        If IO.Directory.Exists(My.Settings.dota2path & "\Backup") Then
            System.Diagnostics.Process.Start("explorer", My.Settings.dota2path + "\Backup")
        Else
            MessageBox.Show(LocRM.GetString("noBackupFolder"))
        End If
    End Sub

End Class