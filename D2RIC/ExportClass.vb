Imports System.Resources

'This class contains all methods you need on the export page
Public Class ExportClass
    Dim LocRM As New ResourceManager("D2RIC.Resources", GetType(FormMain).Assembly)

    'Save the text to the clipboard
    Public Sub CopyToClipboard()
        Clipboard.Clear()
        If FormMain.TextBox3.Text <> "" Then
            Clipboard.SetText(FormMain.TextBox3.Text)
        End If
    End Sub

    'Save the text to a textfile
    Public Sub SavingToTextfile()
        Using SaveFileDialog1 As SaveFileDialog = New SaveFileDialog
            SaveFileDialog1.Filter = "txt(*.txt)| *.txt"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName <> "" Then
                FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
                PrintLine(1, FormMain.TextBox3.Text)
                FileClose(1)
                MessageBox.Show(LocRM.GetString("fileSaved"))
            End If
        End Using
    End Sub
End Class
