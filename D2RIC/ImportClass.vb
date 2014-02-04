Imports System.Resources

'This class contains all methods you need on the import page
Public Class ImportClass
    Friend WithEvents Itembuild As New ItembuildClass
    Dim LocRM As New ResourceManager("D2RIC.Resources", GetType(FormMain).Assembly)

    'Import the itembuild out of textbox2 and switch to the itembuild tab
    Public Sub Import()
        If FormMain.TextBox2.Text <> "" Then
            Dim File As String = My.Settings.dota2path + "\temp.txt"
            IO.File.WriteAllText(File, FormMain.TextBox2.Text)
            If IO.File.Exists(File) Then
                Dim ItemName As String
                Dim ItemList As Object = FormMain.ListView2
                Dim Index As Integer = 0
                Dim price As Object = FormMain.Label15
                Dim savePrice As Boolean = True
                Dim int As Integer
                Dim LV_Index As Integer = -1
                Dim OldLine As String = ""
                Itembuild.Clear()
                FormMain.ListBox1.SelectedItems.Clear()
                ItembuildClass.Selected_Hero = ""
                For Each Zeile As String In IO.File.ReadAllLines(File)
                    If Zeile.Contains("item_") Then
                        ItemName = FormMain.RenameItem(Zeile)
                        If savePrice Then
                            int = (CInt(price.Text) + Itembuild.GetPrice(ItemName))
                            price.Text = int.ToString
                            FormMain.CheckCosts(int)
                        End If
                        With ItemList
                            Dim item As New ListViewItem(New String() {"", ItemName}, FormMain.GetPicture(ItemName))
                            .Items.AddRange(New ListViewItem() {item})
                            .Items(Index).ToolTipText = Itembuild.GetToolTip(ItemName)
                        End With
                        Index = Index + 1
                    ElseIf Zeile.Contains("{") Then
                        Itembuild.NewText &= Zeile & vbNewLine
                        LV_Index += 1
                        Select Case LV_Index
                            Case 2
                                FormMain.Itemslot1.Text = Itembuild.GetLabel(OldLine)
                            Case 3
                                FormMain.Itemslot2.Text = Itembuild.GetLabel(OldLine)
                                ItemList = FormMain.ListView3
                                Index = 0
                                savePrice = False
                            Case 4
                                FormMain.Itemslot3.Text = Itembuild.GetLabel(OldLine)
                                ItemList = FormMain.ListView4
                                Index = 0
                                savePrice = False
                            Case 5
                                FormMain.Itemslot4.Text = Itembuild.GetLabel(OldLine)
                                ItemList = FormMain.ListView5
                                Index = 0
                                savePrice = False
                            Case 6
                                FormMain.Itemslot5.Text = Itembuild.GetLabel(OldLine)
                                ItemList = FormMain.ListView6
                                Index = 0
                                savePrice = False
                            Case 7
                                FormMain.Itemslot6.Text = Itembuild.GetLabel(OldLine)
                                ItemList = FormMain.ListView7
                                Index = 0
                                savePrice = False
                            Case Else
                        End Select
                    ElseIf Zeile.Contains("author") Then
                        FormMain.TextBox1.Text = Replace(Zeile, """", "")
                        FormMain.TextBox1.Text = Replace(FormMain.TextBox1.Text, "author", "")
                        FormMain.TextBox1.Text = Replace(FormMain.TextBox1.Text, vbTab, "")
                        Itembuild.NewText &= Zeile & vbNewLine
                    ElseIf Zeile.Contains("hero") Then
                        Dim temp As String = Replace(Zeile, """hero""", "")
                        temp = Replace(temp, """", "")
                        temp = Replace(temp, vbTab, "")
                        ItembuildClass.Selected_Hero = Itembuild.renameHero(temp)
                        FormMain.Label1.Text = ItembuildClass.Selected_Hero
                        If ItembuildClass.Selected_Hero <> "Unknown hero!" Then
                            FormMain.ImportHero = True
                            FormMain.ListBox1.SelectedItem = ItembuildClass.Selected_Hero
                            FormMain.ButtonSave.Enabled = True
                        End If
                    Else
                        OldLine = Zeile
                        Itembuild.NewText &= Zeile & vbNewLine
                    End If
                Next
                IO.File.Delete(My.Settings.dota2path + "\temp.txt")
                FormMain.TabControl1.SelectedTab = FormMain.TabPage1
            Else
                MessageBox.Show(LocRM.GetString("cantLoadItembuild"))
            End If
        End If
    End Sub

    'Open a textfile and write to textbox2
    Public Sub OpenFile()
        Using OpenFileDialog1 As OpenFileDialog = New OpenFileDialog
            OpenFileDialog1.Filter = "txt(*.txt)| *.txt"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName <> "" Then
                If IO.File.Exists(OpenFileDialog1.FileName) Then
                    FormMain.TextBox2.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
                Else
                    MessageBox.Show(LocRM.GetString("cantRead"))
                End If
            Else
                FormMain.TextBox2.Text = "Error!"
            End If
        End Using
    End Sub
End Class
