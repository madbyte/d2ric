Imports System.Security.Cryptography, System.Net, vb = Microsoft.VisualBasic, System.Resources, System.Globalization, System.Threading

Public Class FormMain
    Dim FirstLangChange As Boolean = True
    Friend WithEvents Import As New ImportClass
    Friend WithEvents Export As New ExportClass
    Friend WithEvents Options As New OptionsClass
    Friend WithEvents Itembuild As New ItembuildClass
    Private WithEvents WebClient1 As New WebClient
    Public IntPrice As Integer
    Dim Unsaved As Boolean = False
    Public ImportHero As Boolean = False
    Dim active_itembox As ListView
    ' Declare a Resource Manager instance.
    Dim LocRM As New ResourceManager("D2RIC.Resources", GetType(FormMain).Assembly)

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

    Private Sub FormMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Save all Settings
        My.Settings.Save()
        'Exit the programm
        End
    End Sub

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Itembuild.Initialize()
        Itembuild.InitializeListbox()

        Options.InitializeLang()

        active_itembox = ListViewItems0
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Itembuild.InitializeListbox()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If Unsaved = True Then
            If MessageBox.Show(LocRM.GetString("unsavedChanges_Pt1") + vbNewLine + LocRM.GetString("unsavedChanges_Pt2"), LocRM.GetString("unsavedChanges_Title"), MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If ListBox1.SelectedItem <> "" Then
                    If ImportHero Then
                        ImportHero = False
                    Else
                        Itembuild.CheckHero(ListBox1.SelectedItem.ToString)
                        Itembuild.Clear()
                        Label1.Text = ListBox1.SelectedItem.ToString
                        Itembuild.CheckFile(ItembuildClass.Selected_Hero)
                        resetItemboxes()
                        Unsaved = False
                    End If
                End If
            End If
        Else
            If ListBox1.SelectedItem <> "" Then
                If ImportHero Then
                    ImportHero = False
                Else
                    Itembuild.CheckHero(ListBox1.SelectedItem.ToString)
                    Itembuild.Clear()
                    Label1.Text = ListBox1.SelectedItem.ToString
                    Itembuild.CheckFile(ItembuildClass.Selected_Hero)
                    resetItemboxes()
                End If
            End If
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage4 Then
            TextBox3.Text = LocRM.GetString("chooseAHero")
            If (ItembuildClass.Selected_Hero <> "") Then
                Itembuild.SaveChanges()
                Itembuild.ChangeAuthor(TextBox1.Text, ItembuildClass.Selected_Hero)
                My.Settings.clipboard = Itembuild.NewText
                If (My.Settings.clipboard <> "") Then
                    TextBox3.Text = My.Settings.clipboard
                Else
                    TextBox3.Text = "Error!"
                End If
            End If
        ElseIf TabControl1.SelectedTab Is TabPage3 Then
            'Focus on TextBox2
            TextBox2.Select()
        End If
    End Sub

    'Allow ctrl+a to select all text in this textbox
    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar = vb.Chr(1)) Then
            TextBox2.SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBoxLang_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxLang.SelectedIndexChanged
        Options.ChangeLang()
        If Not FirstLangChange Then
            MessageBox.Show(LocRM.GetString("restartNeeded"))
        Else
            FirstLangChange = False
        End If
    End Sub

    Private Sub ListViewWeapons_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewWeapons.MouseClick
        If e.Button = MouseButtons.Right Then
            addItem(ListViewWeapons)
        End If
    End Sub

    Private Sub ListViewConsumables_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewConsumables.MouseClick
        If e.Button = MouseButtons.Right Then
            addItem(ListViewConsumables)
        End If
    End Sub

    Private Sub ListViewAttributes_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewAttributes.MouseClick
        If e.Button = MouseButtons.Right Then
            addItem(ListViewAttributes)
        End If
    End Sub

    Private Sub ListViewArmaments_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewArmaments.MouseClick
        If e.Button = MouseButtons.Right Then
            addItem(ListViewArmaments)
        End If
    End Sub

    Private Sub ListViewArcane_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewArcane.MouseClick
        If e.Button = MouseButtons.Right Then
            addItem(ListViewArcane)
        End If
    End Sub

    Private Sub ListViewCommon_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewCommon.MouseClick
        If e.Button = MouseButtons.Right Then
            addItem(ListViewCommon)
        End If
    End Sub

    Private Sub ListViewSupport_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewSupport.MouseClick
        If e.Button = MouseButtons.Right Then
            addItem(ListViewSupport)
        End If
    End Sub

    Private Sub ListViewCaster_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewCaster.MouseClick
        If e.Button = MouseButtons.Right Then
            addItem(ListViewCaster)
        End If
    End Sub

    Private Sub ListViewArmor_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewArmor.MouseClick
        If e.Button = MouseButtons.Right Then
            addItem(ListViewArmor)
        End If
    End Sub

    Private Sub ListViewArtifacts_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewArtifacts.MouseClick
        If e.Button = MouseButtons.Right Then
            addItem(ListViewArtifacts)
        End If
    End Sub

    Private Sub ListViewSecretShop_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewSecretShop.MouseClick
        If e.Button = MouseButtons.Right Then
            addItem(ListViewSecretShop)
        End If
    End Sub

    Private Sub ListViewConsumables_MouseEnter(sender As Object, e As EventArgs) Handles ListViewConsumables.MouseEnter
        ListViewConsumables.Focus()
    End Sub

    Private Sub ListViewAttributes_MouseEnter(sender As Object, e As EventArgs) Handles ListViewAttributes.MouseEnter
        ListViewAttributes.Focus()
    End Sub

    Private Sub ListViewArmaments_MouseEnter(sender As Object, e As EventArgs) Handles ListViewArmaments.MouseEnter
        ListViewArmaments.Focus()
    End Sub

    Private Sub ListViewArcane_MouseEnter(sender As Object, e As EventArgs) Handles ListViewArcane.MouseEnter
        ListViewArcane.Focus()
    End Sub

    Private Sub ListViewCommon_MouseEnter(sender As Object, e As EventArgs) Handles ListViewCommon.MouseEnter
        ListViewCommon.Focus()
    End Sub

    Private Sub ListViewSupport_MouseEnter(sender As Object, e As EventArgs) Handles ListViewSupport.MouseEnter
        ListViewSupport.Focus()
    End Sub

    Private Sub ListViewCaster_MouseEnter(sender As Object, e As EventArgs) Handles ListViewCaster.MouseEnter
        ListViewCaster.Focus()
    End Sub

    Private Sub ListViewWeapons_MouseEnter(sender As Object, e As EventArgs) Handles ListViewWeapons.MouseEnter
        ListViewWeapons.Focus()
    End Sub

    Private Sub ListViewArmor_MouseEnter(sender As Object, e As EventArgs) Handles ListViewArmor.MouseEnter
        ListViewArmor.Focus()
    End Sub

    Private Sub ListViewArtifacts_MouseEnter(sender As Object, e As EventArgs) Handles ListViewArtifacts.MouseEnter
        ListViewArtifacts.Focus()
    End Sub

    Private Sub ListViewSecretShop_MouseEnter(sender As Object, e As EventArgs) Handles ListViewSecretShop.MouseEnter
        ListViewSecretShop.Focus()
    End Sub

    Private Sub addItem(source As ListView)
        active_itembox.Items.Add(source.SelectedItems.Item(0).Clone)
        active_itembox.Items(active_itembox.Items.Count - 1).SubItems(1).Text = active_itembox.Items(active_itembox.Items.Count - 1).Text
        Unsaved = True
        If active_itembox.Name = "ListViewItems0" Then
            Label15.Text = GetStartCosts()
            CheckCosts(CInt(Label15.Text))
        End If
    End Sub

#Region "Updater"
    Private Sub Check4Update()
        'if internet is available
        If connectionInternet() = True Then
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '' Syntax checkForUpdate ("link to a version.txt file containing the current version of the application on the server updates", "version of the new build")
            '' The version.txt file must be in Read mode Execute on the server and must contain only ex Version: 2.0.0
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''we check if an update is available '-> here to change the version of the update
            Dim pgversion As String = Application.ProductVersion
            If pgversion.Substring(pgversion.Length - 1) = "0" Then
                pgversion = pgversion.Substring(0, pgversion.Length - 2)
            End If
            checkforupdate("https://dl.dropboxusercontent.com/u/15746440/D2RIC/d2ric_version.txt", pgversion)
        Else
            ''no connection is informed that he is available and can not vériffier update
            MsgBox("You are not connected to the Internet!" & vbCrLf _
            & "It is therefore impossible to determine whether an update of the application is available.", _
            MsgBoxStyle.Information, "Internet connection not available")
        End If
    End Sub

    'Variable declaration for the update.
    Public Progress As New ProgressBar
    Public url As String
    Public bool_showUI As Boolean
    Public Timer3 As New Windows.Forms.Timer

    'function to check if the internet is available
    Private Function connectionInternet() As Boolean
        Dim objUrl As New System.Uri("http://www.google.com/")
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objResp As System.Net.WebResponse
        Try
            objResp = objWebReq.GetResponse
            objResp.Close()
            objWebReq = Nothing
            Return True
        Catch ex As Exception
            objWebReq = Nothing
            Return False
        End Try
    End Function

    ''::::::::::::::::::::::::::::::::::::::::::::::::: UPDATE :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::'
    '' To configure the system update.
    ''
    '' 1)
    '' -> You must have a web server configured or you can use Dropbox Free
    '' -> A folder on your web server
    '' Eg Update version.txt file containing a sfx archive release.exe
    '' In this file version.text you go up the version of the application that is on the server
    ''
    '' In the sfx archives created with WinRAR file. Exe application and the file you
    '' You want déploiyer during the update eg release.exe <- (Archive sfx created with winrar)
    ''
    '' -> You need to edit the following line in the checkForUpdate sub ():
    ''
    '' DownloadUpdate ("http://server-adresse/Update/Release.exe", True)
    ''
    '' Replace the link to point to your sfx archive on your server
    '' In our example http://server-adresse/Update/Release.exe
    ''
    '' 2)
    '' -> In frmMain_Load () change the following line:
    '' CheckForUpdate ("http://localhost/update/version.txt", "2.0.4")
    ''
    '' Replace the link to point to your version.txt
    '' Eg http://server-adresse/Update/version.txt
    '' And put the num / ro version of the build you are currently creating
    ''
    '' Version in version.txt and the version in the release.exe and line
    '' CheckForUpdate () must be the same for The application does not require update
    ''::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

    Sub checkforupdate(ByVal updatetextfileurl As String, ByVal currentversion As String)
        'we remove the old version of file version
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "/version.dat") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "/version.dat")
        End If

        'we remove the old version of update file
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "/update.exe") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "/update.exe")
        End If

        Try
            My.Computer.Network.DownloadFile(updatetextfileurl, My.Application.Info.DirectoryPath + "/version.dat")
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "/version.dat") Then
                Dim reader As New System.IO.StreamReader(My.Application.Info.DirectoryPath + "/version.dat")
                Dim read As String = reader.ReadToEnd
                reader.Close()
                If read <> currentversion Then
                    MsgBox("A new version is available. " & vbCrLf & _
                     "You currently have version " & currentversion & "." & vbCrLf & _
                     "The latest version is " & read & "." & vbCrLf & vbCrLf & _
                     "The updated program will be launched automatically when closing the window." & vbCrLf & vbCrLf & _
                     "Press OK to continue.", _
                    MsgBoxStyle.Information, "Update Available")

                    Try
                        'the version file is deleted
                        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "/version.dat") Then
                            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "/version.dat")
                        End If
                        'the update files are removed
                        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "/update.exe") Then
                            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "/update.exe")
                        End If
                        'we call the sup downloadUpdate
                        downloadupdate("https://dl.dropboxusercontent.com/u/15746440/D2RIC/release.exe", True)

                    Catch ex As Exception
                        MsgBox("Error: " + ex.Message)
                    End Try

                Else
                    'we do nothing the program is up to date.
                End If
            Else
                MsgBox("An error occurred while checking the version of the program.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Error with program update, " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub downloadupdate(ByVal updaterexecuteableurl As String, ByVal showUI As Boolean)
        Try
            My.Computer.Network.DownloadFile(updaterexecuteableurl, My.Application.Info.DirectoryPath + "/update.exe", "", "", showUI, 99999999, True)
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "/update.exe") Then

                url = updaterexecuteableurl
                bool_showUI = showUI
                Timer3.Interval = 10
                Progress.Maximum = 1000
                Timer3.Enabled = True
                Timer3.Start()
                AddHandler Timer3.Tick, AddressOf Timer3_tick
            Else
                downloadupdate(updaterexecuteableurl, showUI)
            End If

        Catch ex As Exception
            MsgBox("Error downloading the update, " + ex.Message)
        End Try
    End Sub

    Sub Timer3_tick(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Do Until Progress.Value = 1000
                Progress.Value = Progress.Value + 1
            Loop
            If Progress.Value = 1000 Then
                If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "/update.exe") Then
                    Timer3.Stop()
                    Timer3.Enabled = False
                    Shell(My.Application.Info.DirectoryPath + "/update.exe", AppWinStyle.NormalFocus)
                    Me.Close()
                    Exit Sub
                Else
                    downloadupdate(url, bool_showUI)
                End If
            End If
        Catch ex As Exception
            If ex.Message.Contains("not") Then
                Timer3.Stop()
                Timer3.Enabled = False
                Shell(My.Application.Info.DirectoryPath + "/update.exe", AppWinStyle.NormalFocus)
                Me.Close()
            End If
        End Try
    End Sub
#End Region

#Region "Button"
    Private Sub ButtonUpdate_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdate.Click
        LabelWait.Visible = True
        Me.Update()
        Check4Update()
        LabelWait.Visible = False
    End Sub

    Private Sub ButtonOpenFolder_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOpenFolder.Click
        System.Diagnostics.Process.Start("explorer", My.Settings.dota2path)
    End Sub

    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click
        Unsaved = False
        Itembuild.Save()
    End Sub

    Private Sub ButtonBackup_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBackup.Click
        Options.Backup()
    End Sub

    Private Sub ButtonDeleteBackup_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDeleteBackup.Click
        Options.DeleteBackup()
    End Sub

    Private Sub ButtonOpenTextfile_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOpenTextfile.Click
        Import.OpenFile()
    End Sub

    Private Sub ButtonImport_Click(sender As System.Object, e As System.EventArgs) Handles ButtonImport.Click
        Import.Import()
    End Sub

    Private Sub ButtonCopy_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCopy.Click
        Export.CopyToClipboard()
    End Sub

    Private Sub ButtonSaveTextfile_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSaveTextfile.Click
        Export.SavingToTextfile()
    End Sub

    Private Sub ButtonOpenBackupFolder_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOpenBackupFolder.Click
        Options.OpenBackup()
    End Sub

    Private Sub ButtonDefaultItembuild_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDefaultItembuild.Click
        Itembuild.LoadDefault()
    End Sub
#End Region

#Region "Items"
    'Changes color to red when the costs exceed 625, otherwise to blue
    Public Sub CheckCosts(ByVal price As Integer)
        If (price > 625) Then
            Label15.ForeColor = Color.Red
        Else
            Label15.ForeColor = Color.Black
        End If
    End Sub

    'Calculate the item costs for the starting items
    Private Function GetStartCosts() As String
        IntPrice = 0
        For i = 0 To ListViewItems0.Items.Count - 1
            IntPrice += (Itembuild.GetPrice(ListViewItems0.Items(i).SubItems(1).Text))
        Next
        Return IntPrice.ToString
    End Function

    'Return the normal itemname, needs the itemname of the itembuild file
    Public Function RenameItem(ByVal item_name As String) As String
        Dim rename_item_name, item_name2 As String
        item_name2 = Replace(item_name, """", "")
        item_name2 = Replace(item_name2, vbTab, "")
        Select Case True
            Case item_name2 Like "*item_blink"
                rename_item_name = "Blink Dagger"
            Case item_name2 Like "*item_blades_of_attack"
                rename_item_name = "Blades of Attack"
            Case item_name2 Like "*item_basher"
                rename_item_name = "Skull Basher"
            Case item_name2 Like "*item_tango"
                rename_item_name = "Tango"
            Case item_name2 Like "*item_ancient_janggo"
                rename_item_name = "Drum of Endurance"
            Case item_name2 Like "*item_arcane_boots"
                rename_item_name = "Arcane Boots"
            Case item_name2 Like "*item_armlet"
                rename_item_name = "Armlet"
            Case item_name2 Like "*item_assault"
                rename_item_name = "Assault Cuirass"
            Case item_name2 Like "*item_assault_cuirass"
                rename_item_name = "Assault Cuirass"
            Case item_name2 Like "*item_bfury"
                rename_item_name = "Battle Fury"
            Case item_name2 Like "*item_belt_of_strength"
                rename_item_name = "Belt of Strength"
            Case item_name2 Like "*item_black_king_bar"
                rename_item_name = "Black King Bar"
            Case item_name2 Like "*item_blade_mail"
                rename_item_name = "Blade Mail"
            Case item_name2 Like "*item_blade_of_alacrity"
                rename_item_name = "Blade of Alacrity"
            Case item_name2 Like "*item_bloodstone"
                rename_item_name = "Bloodstone"
            Case item_name2 Like "*item_boots"
                rename_item_name = "Boots of Speed"
            Case item_name2 Like "*item_boots_of_speed"
                rename_item_name = "Boots of Speed"
            Case item_name2 Like "*item_boots_of_elves"
                rename_item_name = "Band of Elvenskin"
            Case item_name2 Like "*item_bottle"
                rename_item_name = "Bottle"
            Case item_name2 Like "*item_bracer"
                rename_item_name = "Bracer"
            Case item_name2 Like "*item_branches"
                rename_item_name = "Iron Branch"
            Case item_name2 Like "*item_branch"
                rename_item_name = "Iron Branch"
            Case item_name2 Like "*item_broadsword"
                rename_item_name = "Broadsword"
            Case item_name2 Like "*item_buckler"
                rename_item_name = "Buckler"
            Case item_name2 Like "*item_butterfly"
                rename_item_name = "Butterfly"
            Case item_name2 Like "*item_chainmail"
                rename_item_name = "Chainmail"
            Case item_name2 Like "*item_circlet"
                rename_item_name = "Circlet"
            Case item_name2 Like "*item_circlet_of_nobility"
                rename_item_name = "Circlet"
            Case item_name2 Like "*item_clarity"
                rename_item_name = "Clarity"
            Case item_name2 Like "*item_claymore"
                rename_item_name = "Claymore"
            Case item_name2 Like "*item_cloak"
                rename_item_name = "Cloak"
            Case item_name2 Like "*item_courier"
                rename_item_name = "Animal Courier"
            Case item_name2 Like "*item_cyclone"
                rename_item_name = "Eul's Scepter of Divinity"
            Case item_name2 Like "*item_dagon"
                rename_item_name = "Dagon 1"
            Case item_name2 Like "*item_dagon_2"
                rename_item_name = "Dagon 2"
            Case item_name2 Like "*item_dagon_3"
                rename_item_name = "Dagon 3"
            Case item_name2 Like "*item_dagon_4"
                rename_item_name = "Dagon 4"
            Case item_name2 Like "*item_dagon_5"
                rename_item_name = "Dagon 5"
            Case item_name2 Like "*item_demon_edge"
                rename_item_name = "Demon Edge"
            Case item_name2 Like "*item_desolator"
                rename_item_name = "Desolator"
            Case item_name2 Like "*item_desolater"
                rename_item_name = "Desolator"
            Case item_name2 Like "*item_diffusal_blade"
                rename_item_name = "Diffusal Blade 1"
            Case item_name2 Like "*item_diffusal_blade_2"
                rename_item_name = "Diffusal Blade 2"
            Case item_name2 Like "*item_dust"
                rename_item_name = "Dust of Appearance"
            Case item_name2 Like "*item_eagle"
                rename_item_name = "Eaglesong"
            Case item_name2 Like "*item_energy_booster"
                rename_item_name = "Energy Booster"
            Case item_name2 Like "*item_ethereal_blade"
                rename_item_name = "Ethereal Blade"
            Case item_name2 Like "*item_flask"
                rename_item_name = "Healing Salve"
            Case item_name2 Like "*item_flying_courier"
                rename_item_name = "Flying Courier"
            Case item_name2 Like "*item_force_staff"
                rename_item_name = "Force Staff"
            Case item_name2 Like "*item_gauntlets"
                rename_item_name = "Gauntlets of Strength"
            Case item_name2 Like "*item_gauntlet"
                rename_item_name = "Gauntlets of Strength"
            Case item_name2 Like "*item_gem"
                rename_item_name = "Gem of True Sight"
            Case item_name2 Like "*item_ghost"
                rename_item_name = "Ghost Scepter"
            Case item_name2 Like "*item_gloves"
                rename_item_name = "Gloves of Haste"
            Case item_name2 Like "*item_greater_crit"
                rename_item_name = "Daedalus"
            Case item_name2 Like "*item_hand_of_midas"
                rename_item_name = "Hand of Midas"
            Case item_name2 Like "*item_headdress"
                rename_item_name = "Headdress"
            Case item_name2 Like "*item_heart"
                rename_item_name = "Heart of Tarrasque"
            Case item_name2 Like "*item_helm_of_iron_will"
                rename_item_name = "Helm of Iron Will"
            Case item_name2 Like "*item_helm_of_the_dominator"
                rename_item_name = "Helm of the Dominator"
            Case item_name2 Like "*item_hood_of_defiance"
                rename_item_name = "Hood of Defiance"
            Case item_name2 Like "*item_hyperstone"
                rename_item_name = "Hyperstone"
            Case item_name2 Like "*item_invis_sword"
                rename_item_name = "Shadow Blade"
            Case item_name2 Like "*item_javelin"
                rename_item_name = "Javelin"
            Case item_name2 Like "*item_lesser_crit"
                rename_item_name = "Crystalys"
            Case item_name2 Like "*item_lifesteal"
                rename_item_name = "Morbid Mask"
            Case item_name2 Like "*item_maelstrom"
                rename_item_name = "Maelstrom"
            Case item_name2 Like "*item_magic_stick"
                rename_item_name = "Magic Stick"
            Case item_name2 Like "*item_magic_wand"
                rename_item_name = "Magic Wand"
            Case item_name2 Like "*item_manta"
                rename_item_name = "Manta Style"
            Case item_name2 Like "*item_mantle"
                rename_item_name = "Mantle of Intelligence"
            Case item_name2 Like "*item_mask_of_madness"
                rename_item_name = "Mask of Madness"
            Case item_name2 Like "*item_medallion_of_courage"
                rename_item_name = "Medallion of Courage"
            Case item_name2 Like "*item_mekansm"
                rename_item_name = "Mekansm"
            Case item_name2 Like "*item_mithril_hammer"
                rename_item_name = "Mithril Hammer"
            Case item_name2 Like "*item_mjollnir"
                rename_item_name = "Mjollnir"
            Case item_name2 Like "*item_monkey_king_bar"
                rename_item_name = "Monkey King Bar"
            Case item_name2 Like "*item_mystic_staff"
                rename_item_name = "Mystic Staff"
            Case item_name2 Like "*item_necronomicon"
                rename_item_name = "Necronomicon 1"
            Case item_name2 Like "*item_necronomicon_2"
                rename_item_name = "Necronomicon 2"
            Case item_name2 Like "*item_necronomicon_3"
                rename_item_name = "Necronomicon 3"
            Case item_name2 Like "*item_null_talisman"
                rename_item_name = "Null Talisman"
            Case item_name2 Like "*item_oblivion_staff"
                rename_item_name = "Oblivion Staff"
            Case item_name2 Like "*item_ward_observer"
                rename_item_name = "Observer Ward"
            Case item_name2 Like "*item_ogre_axe"
                rename_item_name = "Ogre Club"
            Case item_name2 Like "*item_orb_of_venom"
                rename_item_name = "Orb of Venom"
            Case item_name2 Like "*item_orchid"
                rename_item_name = "Orchid Malevolence"
            Case item_name2 Like "*item_pers"
                rename_item_name = "Perseverance"
            Case item_name2 Like "*item_phase_boots"
                rename_item_name = "Phase Boots"
            Case item_name2 Like "*item_pipe"
                rename_item_name = "Pipe of Insight"
            Case item_name2 Like "*item_platemail"
                rename_item_name = "Platemail"
            Case item_name2 Like "*item_point_booster"
                rename_item_name = "Point Booster"
            Case item_name2 Like "*item_poor_mans_shield"
                rename_item_name = "Poor Man's Shield"
            Case item_name2 Like "*item_power_treads"
                rename_item_name = "Power Treads"
            Case item_name2 Like "*item_quarterstaff"
                rename_item_name = "Quarterstaff"
            Case item_name2 Like "*item_quelling_blade"
                rename_item_name = "Quelling Blade"
            Case item_name2 Like "*item_radiance"
                rename_item_name = "Radiance"
            Case item_name2 Like "*item_rapier"
                rename_item_name = "Divine Rapier"
            Case item_name2 Like "*item_reaver"
                rename_item_name = "Reaver"
            Case item_name2 Like "*item_refresher"
                rename_item_name = "Refresher Orb"
            Case item_name2 Like "*item_ring_of_basilius"
                rename_item_name = "Ring of Basilius"
            Case item_name2 Like "*item_ring_of_health"
                rename_item_name = "Ring of Health"
            Case item_name2 Like "*item_ring_of_protection"
                rename_item_name = "Ring of Protection"
            Case item_name2 Like "*item_ring_of_regen"
                rename_item_name = "Ring of Regen"
            Case item_name2 Like "*item_robe"
                rename_item_name = "Robe of the Magi"
            Case item_name2 Like "*item_relic"
                rename_item_name = "Sacred Relic"
            Case item_name2 Like "*item_sange"
                rename_item_name = "Sange"
            Case item_name2 Like "*item_sange_and_yasha"
                rename_item_name = "Sange and Yasha"
            Case item_name2 Like "*item_satanic"
                rename_item_name = "Satanic"
            Case item_name2 Like "*item_ultimate_scepter"
                rename_item_name = "Aghanim's Scepter"
            Case item_name2 Like "*item_ward_sentry"
                rename_item_name = "Sentry Ward"
            Case item_name2 Like "*item_sheep"
                rename_item_name = "Scythe of Vyse"
            Case item_name2 Like "*item_sheepstick"
                rename_item_name = "Scythe of Vyse"
            Case item_name2 Like "*item_shivas_guard"
                rename_item_name = "Shiva's Guard"
            Case item_name2 Like "*item_shivas"
                rename_item_name = "Shiva's Guard"
            Case item_name2 Like "*item_skadi"
                rename_item_name = "Eye of Skadi"
            Case item_name2 Like "*item_slippers"
                rename_item_name = "Slippers of Agility"
            Case item_name2 Like "*item_smoke_of_deceit"
                rename_item_name = "Smoke of Deceit"
            Case item_name2 Like "*item_sobi_mask"
                rename_item_name = "Sage's Mask"
            Case item_name2 Like "*item_soul_booster"
                rename_item_name = "Soul Booster"
            Case item_name2 Like "*item_soul_ring"
                rename_item_name = "Soul Ring"
            Case item_name2 Like "*item_sphere"
                rename_item_name = "Linken's Sphere"
            Case item_name2 Like "*item_staff_of_wizardry"
                rename_item_name = "Staff of Wizardry"
            Case item_name2 Like "*item_stout_shield"
                rename_item_name = "Stout Shield"
            Case item_name2 Like "*item_talisman_of_evasion"
                rename_item_name = "Talisman of Evasion"
            Case item_name2 Like "*item_tpscroll"
                rename_item_name = "Town Portal Scroll"
            Case item_name2 Like "*item_travel_boots"
                rename_item_name = "Boots of Travel"
            Case item_name2 Like "*item_ultimate_orb"
                rename_item_name = "Ultimate Orb"
            Case item_name2 Like "*item_urn_of_shadows"
                rename_item_name = "Urn of Shadows"
            Case item_name2 Like "*item_vanguard"
                rename_item_name = "Vanguard"
            Case item_name2 Like "*item_veil_of_discord"
                rename_item_name = "Veil of Discord"
            Case item_name2 Like "*item_vitality_booster"
                rename_item_name = "Vitality Booster"
            Case item_name2 Like "*item_vladmir"
                rename_item_name = "Vladmir's Offering"
            Case item_name2 Like "*item_void_stone"
                rename_item_name = "Void Stone"
            Case item_name2 Like "*item_wraith_band"
                rename_item_name = "Wraith Band"
            Case item_name2 Like "*item_yasha"
                rename_item_name = "Yasha"
            Case item_name2 Like "*item_abyssal_blade"
                rename_item_name = "Abyssal Blade"
            Case item_name2 Like "*item_heavens_halberd"
                rename_item_name = "Heaven's Halberd"
            Case item_name2 Like "*item_ring_of_aquila"
                rename_item_name = "Ring of Aquila"
            Case item_name2 Like "*item_rod_of_atos"
                rename_item_name = "Rod of Atos"
            Case item_name2 Like "*item_tranquil_boots"
                rename_item_name = "Tranquil Boots"
            Case item_name2 Like "*item_recipe_wraith_band"
                rename_item_name = "Wraith Band (Recipe)"
            Case item_name2 Like "*item_recipe_bracer"
                rename_item_name = "Bracer (Recipe)"
            Case item_name2 Like "*item_recipe_null_talisman"
                rename_item_name = "Null Talisman (Recipe)"
            Case item_name2 Like "*item_recipe_magic_wand"
                rename_item_name = "Magic Wand (Recipe)"
            Case item_name2 Like "*item_recipe_hand_of_midas"
                rename_item_name = "Hand of Midas (Recipe)"
            Case item_name2 Like "*item_recipe_soul_ring"
                rename_item_name = "Soul Ring (Recipe)"
            Case item_name2 Like "*item_recipe_travel_boots"
                rename_item_name = "Boots of Travel (Recipe)"
            Case item_name2 Like "*item_recipe_headdress"
                rename_item_name = "Headdress (Recipe)"
            Case item_name2 Like "*item_recipe_buckler"
                rename_item_name = "Buckler (Recipe)"
            Case item_name2 Like "*item_recipe_urn_of_shadows"
                rename_item_name = "Urn of Shadows (Recipe)"
            Case item_name2 Like "*item_recipe_mekansm"
                rename_item_name = "Mekansm (Recipe)"
            Case item_name2 Like "*item_recipe_medallion_of_courage"
                rename_item_name = "Medallion of Courage (Recipe)"
            Case item_name2 Like "*item_recipe_vladmir"
                rename_item_name = "Vladmir's Offering (Recipe)"
            Case item_name2 Like "*item_recipe_pipe"
                rename_item_name = "Pipe of Insight (Recipe)"
            Case item_name2 Like "*item_recipe_ancient_janggo"
                rename_item_name = "Drum of Endurance (Recipe)"
            Case item_name2 Like "*item_recipe_necronomicon"
                rename_item_name = "Necronomicon (Recipe)"
            Case item_name2 Like "*item_recipe_cyclone"
                rename_item_name = "Eul's Scepter of Divinity (Recipe)"
            Case item_name2 Like "*item_recipe_dagon"
                rename_item_name = "Dagon (Recipe)"
            Case item_name2 Like "*item_recipe_veil_of_discord"
                rename_item_name = "Veil of Discord (Recipe)"
            Case item_name2 Like "*item_recipe_orchid"
                rename_item_name = "Orchid Malevolence (Recipe)"
            Case item_name2 Like "*item_recipe_refresher"
                rename_item_name = "Refresher Orb (Recipe)"
            Case item_name2 Like "*item_recipe_force_staff"
                rename_item_name = "Force Staff (Recipe)"
            Case item_name2 Like "*item_recipe_armlet"
                rename_item_name = "Armlet (Recipe)"
            Case item_name2 Like "*item_recipe_lesser_crit"
                rename_item_name = "Crystalys (Recipe)"
            Case item_name2 Like "*item_recipe_greater_crit"
                rename_item_name = "Daedalus (Recipe)"
            Case item_name2 Like "*item_recipe_basher"
                rename_item_name = "Skull Basher (Recipe)"
            Case item_name2 Like "*item_recipe_invis_sword"
                rename_item_name = "Shadow Blade (Recipe)"
            Case item_name2 Like "*item_recipe_radiance"
                rename_item_name = "Radiance (Recipe)"
            Case item_name2 Like "*item_recipe_black_king_bar"
                rename_item_name = "Black King Bar (Recipe)"
            Case item_name2 Like "*item_recipe_assault"
                rename_item_name = "Assault Cuirass (Recipe)"
            Case item_name2 Like "*item_recipe_manta"
                rename_item_name = "Manta Style (Recipe)"
            Case item_name2 Like "*item_recipe_shivas_guard"
                rename_item_name = "Shiva's Guard (Recipe)"
            Case item_name2 Like "*item_recipe_sphere"
                rename_item_name = "Linken's Sphere (Recipe)"
            Case item_name2 Like "*item_recipe_heart"
                rename_item_name = "Heart of Tarrasque (Recipe)"
            Case item_name2 Like "*item_recipe_desolator"
                rename_item_name = "Desolator (Recipe)"
            Case item_name2 Like "*item_recipe_mjollnir"
                rename_item_name = "Mjollnir (Recipe)"
            Case item_name2 Like "*item_recipe_satanic"
                rename_item_name = "Satanic (Recipe)"
            Case item_name2 Like "*item_recipe_yasha"
                rename_item_name = "Yasha (Recipe)"
            Case item_name2 Like "*item_recipe_diffusal_blade"
                rename_item_name = "Diffusal Blade (Recipe)"
            Case item_name2 Like "*item_recipe_sange"
                rename_item_name = "Sange (Recipe)"
            Case item_name2 Like "*item_recipe_mask_of_madness"
                rename_item_name = "Mask of Madness (Recipe)"
            Case item_name2 Like "*item_recipe_maelstrom"
                rename_item_name = "Maelstrom (Recipe)"
            Case item_name2 Like "*item_shadow_amulet"
                rename_item_name = "Shadow Amulet"
            Case item_name2 Like "*item_silver_edge"
                rename_item_name = "Silver Edge"
            Case item_name2 Like "*item_glimmer_cape"
                rename_item_name = "Glimmer Cape"
            Case item_name2 Like "*item_octarine_core"
                rename_item_name = "Octarine Core"
            Case item_name2 Like "*item_guardian_greaves"
                rename_item_name = "Guardian Greaves"
            Case item_name2 Like "*item_solar_crest"
                rename_item_name = "Solar Crest"
            Case item_name2 Like "*item_travel_boots_2"
                rename_item_name = "Boots of Travel 2"
            Case item_name2 Like "*item_lotus_orb"
                rename_item_name = "Lotus Orb"
            Case item_name2 Like "*item_crimson_guard"
                rename_item_name = "Crimson Guard"
            Case item_name2 Like "*item_moon_shard"
                rename_item_name = "Moon Shard"
            Case item_name2 Like "*item_enchanted_mango"
                rename_item_name = "Enchanted Mango"
            Case item_name2 Like "*item_faerie_fire"
                rename_item_name = "Faerie Fire"
            Case item_name2 Like "*item_aether_lens"
                rename_item_name = "Aether Lens"
            Case item_name2 Like "*item_blight_stone"
                rename_item_name = "Blight Stone"
            Case item_name2 Like "*item_bloodthorn"
                rename_item_name = "Bloodthorn"
            Case item_name2 Like "*item_dragon_lance"
                rename_item_name = "Dragon Lance"
            Case item_name2 Like "*item_echo_sabre"
                rename_item_name = "Echo Sabre"
            Case item_name2 Like "*item_hurricane_pike"
                rename_item_name = "Hurricane Pike"
            Case item_name2 Like "*item_infused_raindrop"
                rename_item_name = "Infused Raindrop"
            Case item_name2 Like "*item_iron_talon"
                rename_item_name = "Iron Talon"
            Case item_name2 Like "*item_tome_of_knowledge"
                rename_item_name = "Tome of Knowledge"
            Case item_name2 Like "*item_wind_lace"
                rename_item_name = "Wind Lace"
            Case item_name2 Like "*item_recipe_aether_lens"
                rename_item_name = "Aether Lens (Recipe)"
            Case item_name2 Like "*item_recipe_hurricane_pike"
                rename_item_name = "Hurricane Pike (Recipe)"
            Case item_name2 Like "*item_recipe_iron_talon"
                rename_item_name = "Iron Talon (Recipe)"
            Case Else
                rename_item_name = "Error! " + item_name
        End Select

        Return rename_item_name
    End Function

    'Return the itemname for the itembuild file, needs the normal itemname
    Public Function GetItem(ByVal item_name As String) As String
        Select Case item_name
            Case "Blink Dagger"
                Return "item_blink"
            Case "Blades of Attack"
                Return "item_blades_of_attack"
            Case "Skull Basher"
                Return "item_basher"
            Case "Tango"
                Return "item_tango"
            Case "Drum of Endurance"
                Return "item_ancient_janggo"
            Case "Arcane Boots"
                Return "item_arcane_boots"
            Case "Armlet"
                Return "item_armlet"
            Case "Assault Cuirass"
                Return "item_assault"
            Case "Battle Fury"
                Return "item_bfury"
            Case "Belt of Strength"
                Return "item_belt_of_strength"
            Case "Black King Bar"
                Return "item_black_king_bar"
            Case "Blade Mail"
                Return "item_blade_mail"
            Case "Blade of Alacrity"
                Return "item_blade_of_alacrity"
            Case "Bloodstone"
                Return "item_bloodstone"
            Case "Boots of Speed"
                Return "item_boots"
            Case "Band of Elvenskin"
                Return "item_boots_of_elves"
            Case "Bottle"
                Return "item_bottle"
            Case "Bracer"
                Return "item_bracer"
            Case "Iron Branch"
                Return "item_branches"
            Case "Broadsword"
                Return "item_broadsword"
            Case "Buckler"
                Return "item_buckler"
            Case "Butterfly"
                Return "item_butterfly"
            Case "Chainmail"
                Return "item_chainmail"
            Case "Circlet"
                Return "item_circlet"
            Case "Clarity"
                Return "item_clarity"
            Case "Claymore"
                Return "item_claymore"
            Case "Cloak"
                Return "item_cloak"
            Case "Animal Courier"
                Return "item_courier"
            Case "Eul's Scepter of Divinity"
                Return "item_cyclone"
            Case "Dagon 1"
                Return "item_dagon"
            Case "Dagon 2"
                Return "item_dagon_2"
            Case "Dagon 3"
                Return "item_dagon_3"
            Case "Dagon 4"
                Return "item_dagon_4"
            Case "Dagon 5"
                Return "item_dagon_5"
            Case "Demon Edge"
                Return "item_demon_edge"
            Case "Desolator"
                Return "item_desolator"
            Case "Diffusal Blade 1"
                Return "item_diffusal_blade"
            Case "Diffusal Blade 2"
                Return "item_diffusal_blade_2"
            Case "Dust of Appearance"
                Return "item_dust"
            Case "Eaglesong"
                Return "item_eagle"
            Case "Energy Booster"
                Return "item_energy_booster"
            Case "Ethereal Blade"
                Return "item_ethereal_blade"
            Case "Healing Salve"
                Return "item_flask"
            Case "Flying Courier"
                Return "item_flying_courier"
            Case "Force Staff"
                Return "item_force_staff"
            Case "Gauntlets of Strength"
                Return "item_gauntlets"
            Case "Gem of True Sight"
                Return "item_gem"
            Case "Ghost Scepter"
                Return "item_ghost"
            Case "Gloves of Haste"
                Return "item_gloves"
            Case "Daedalus"
                Return "item_greater_crit"
            Case "Hand of Midas"
                Return "item_hand_of_midas"
            Case "Headdress"
                Return "item_headdress"
            Case "Heart of Tarrasque"
                Return "item_heart"
            Case "Helm of Iron Will"
                Return "item_helm_of_iron_will"
            Case "Helm of the Dominator"
                Return "item_helm_of_the_dominator"
            Case "Hood of Defiance"
                Return "item_hood_of_defiance"
            Case "Hyperstone"
                Return "item_hyperstone"
            Case "Shadow Blade"
                Return "item_invis_sword"
            Case "Javelin"
                Return "item_javelin"
            Case "Crystalys"
                Return "item_lesser_crit"
            Case "Morbid Mask"
                Return "item_lifesteal"
            Case Is = "Maelstrom"
                Return "item_maelstrom"
            Case Is = "Magic Stick"
                Return "item_magic_stick"
            Case Is = "Magic Wand"
                Return "item_magic_wand"
            Case Is = "Manta Style"
                Return "item_manta"
            Case "Mantle of Intelligence"
                Return "item_mantle"
            Case Is = "Mask of Madness"
                Return "item_mask_of_madness"
            Case "Medallion of Courage"
                Return "item_medallion_of_courage"
            Case "Mekansm"
                Return "item_mekansm"
            Case "Mithril Hammer"
                Return "item_mithril_hammer"
            Case "Mjollnir"
                Return "item_mjollnir"
            Case "Monkey King Bar"
                Return "item_monkey_king_bar"
            Case "Mystic Staff"
                Return "item_mystic_staff"
            Case "Necronomicon 1"
                Return "item_necronomicon"
            Case "Necronomicon 2"
                Return "item_necronomicon_2"
            Case "Necronomicon 3"
                Return "item_necronomicon_3"
            Case "Null Talisman"
                Return "item_null_talisman"
            Case "Oblivion Staff"
                Return "item_oblivion_staff"
            Case "Observer Ward"
                Return "item_ward_observer"
            Case "Ogre Club"
                Return "item_ogre_axe"
            Case "Orb of Venom"
                Return "item_orb_of_venom"
            Case "Orchid Malevolence"
                Return "item_orchid"
            Case "Perseverance"
                Return "item_pers"
            Case "Phase Boots"
                Return "item_phase_boots"
            Case "Pipe of Insight"
                Return "item_pipe"
            Case "Platemail"
                Return "item_platemail"
            Case "Point Booster"
                Return "item_point_booster"
            Case "Poor Man's Shield"
                Return "item_poor_mans_shield"
            Case "Power Treads"
                Return "item_power_treads"
            Case "Quarterstaff"
                Return "item_quarterstaff"
            Case "Quelling Blade"
                Return "item_quelling_blade"
            Case "Radiance"
                Return "item_radiance"
            Case "Divine Rapier"
                Return "item_rapier"
            Case "Reaver"
                Return "item_reaver"
            Case "Refresher Orb"
                Return "item_refresher"
            Case "Ring of Basilius"
                Return "item_ring_of_basilius"
            Case "Ring of Health"
                Return "item_ring_of_health"
            Case "Ring of Protection"
                Return "item_ring_of_protection"
            Case "Ring of Regen"
                Return "item_ring_of_regen"
            Case "Robe of the Magi"
                Return "item_robe"
            Case "Sacred Relic"
                Return "item_relic"
            Case "Sange"
                Return "item_sange"
            Case "Sange and Yasha"
                Return "item_sange_and_yasha"
            Case "Satanic"
                Return "item_satanic"
            Case "Aghanim's Scepter"
                Return "item_ultimate_scepter"
            Case "Sentry Ward"
                Return "item_ward_sentry"
            Case "Scythe of Vyse"
                Return "item_sheep"
            Case "Shiva's Guard"
                Return "item_shivas_guard"
            Case "Eye of Skadi"
                Return "item_skadi"
            Case "Slippers of Agility"
                Return "item_slippers"
            Case "Smoke of Deceit"
                Return "item_smoke_of_deceit"
            Case "Sage's Mask"
                Return "item_sobi_mask"
            Case "Soul Booster"
                Return "item_soul_booster"
            Case "Soul Ring"
                Return "item_soul_ring"
            Case "Linken's Sphere"
                Return "item_sphere"
            Case "Staff of Wizardry"
                Return "item_staff_of_wizardry"
            Case "Stout Shield"
                Return "item_stout_shield"
            Case "Talisman of Evasion"
                Return "item_talisman_of_evasion"
            Case "Town Portal Scroll"
                Return "item_tpscroll"
            Case "Boots of Travel"
                Return "item_travel_boots"
            Case "Ultimate Orb"
                Return "item_ultimate_orb"
            Case "Urn of Shadows"
                Return "item_urn_of_shadows"
            Case "Vanguard"
                Return "item_vanguard"
            Case "Veil of Discord"
                Return "item_veil_of_discord"
            Case "Vitality Booster"
                Return "item_vitality_booster"
            Case "Vladmir's Offering"
                Return "item_vladmir"
            Case "Void Stone"
                Return "item_void_stone"
            Case "Wraith Band"
                Return "item_wraith_band"
            Case "Yasha"
                Return "item_yasha"
            Case "Abyssal Blade"
                Return "item_abyssal_blade"
            Case "Heaven's Halberd"
                Return "item_heavens_halberd"
            Case "Ring of Aquila"
                Return "item_ring_of_aquila"
            Case "Rod of Atos"
                Return "item_rod_of_atos"
            Case "Tranquil Boots"
                Return "item_tranquil_boots"
            Case "Wraith Band (Recipe)"
                Return "item_recipe_wraith_band"
            Case "Bracer (Recipe)"
                Return "item_recipe_bracer"
            Case "Null Talisman (Recipe)"
                Return "item_recipe_null_talisman"
            Case "Magic Wand (Recipe)"
                Return "item_recipe_magic_wand"
            Case "Hand of Midas (Recipe)"
                Return "item_recipe_hand_of_midas"
            Case "Soul Ring (Recipe)"
                Return "item_recipe_soul_ring"
            Case "Boots of Travel (Recipe)"
                Return "item_recipe_travel_boots"
            Case "Headdress (Recipe)"
                Return "item_recipe_headdress"
            Case "Buckler (Recipe)"
                Return "item_recipe_buckler"
            Case "Urn of Shadows (Recipe)"
                Return "item_recipe_urn_of_shadows"
            Case "Mekansm (Recipe)"
                Return "item_recipe_mekansm"
            Case "Medallion of Courage (Recipe)"
                Return "item_recipe_medallion_of_courage"
            Case "Vladmir's Offering (Recipe)"
                Return "item_recipe_vladmir"
            Case "Pipe of Insight (Recipe)"
                Return "item_recipe_pipe"
            Case "Drum of Endurance (Recipe)"
                Return "item_recipe_ancient_janggo"
            Case "Necronomicon (Recipe)"
                Return "item_recipe_necronomicon"
            Case "Eul's Scepter of Divinity (Recipe)"
                Return "item_recipe_cyclone"
            Case "Dagon (Recipe)"
                Return "item_recipe_dagon"
            Case "Veil of Discord (Recipe)"
                Return "item_recipe_veil_of_discord"
            Case "Orchid Malevolence (Recipe)"
                Return "item_recipe_orchid"
            Case "Refresher Orb (Recipe)"
                Return "item_recipe_refresher"
            Case "Force Staff (Recipe)"
                Return "item_recipe_force_staff"
            Case "Armlet (Recipe)"
                Return "item_recipe_armlet"
            Case "Crystalys (Recipe)"
                Return "item_recipe_lesser_crit"
            Case "Daedalus (Recipe)"
                Return "item_recipe_greater_crit"
            Case "Skull Basher (Recipe)"
                Return "item_recipe_basher"
            Case "Shadow Blade (Recipe)"
                Return "item_recipe_invis_sword"
            Case "Radiance (Recipe)"
                Return "item_recipe_radiance"
            Case "Black King Bar (Recipe)"
                Return "item_recipe_black_king_bar"
            Case "Assault Cuirass (Recipe)"
                Return "item_recipe_assault"
            Case "Manta Style (Recipe)"
                Return "item_recipe_manta"
            Case "Shiva's Guard (Recipe)"
                Return "item_recipe_shivas_guard"
            Case "Linken's Sphere (Recipe)"
                Return "item_recipe_sphere"
            Case "Heart of Tarrasque (Recipe)"
                Return "item_recipe_heart"
            Case "Desolator (Recipe)"
                Return "item_recipe_desolator"
            Case "Mjollnir (Recipe)"
                Return "item_recipe_mjollnir"
            Case "Satanic (Recipe)"
                Return "item_recipe_satanic"
            Case "Yasha (Recipe)"
                Return "item_recipe_yasha"
            Case "Diffusal Blade (Recipe)"
                Return "item_recipe_diffusal_blade"
            Case "Sange (Recipe)"
                Return "item_recipe_sange"
            Case "Mask of Madness (Recipe)"
                Return "item_recipe_mask_of_madness"
            Case "Maelstrom (Recipe)"
                Return "item_recipe_maelstrom"
            Case "Shadow Amulet"
                Return "item_shadow_amulet"
            Case "Silver Edge"
                Return "item_silver_edge"
            Case "Glimmer Cape"
                Return "item_glimmer_cape"
            Case "Octarine Core"
                Return "item_octarine_core"
            Case "Guardian Greaves"
                Return "item_guardian_greaves"
            Case "Solar Crest"
                Return "item_solar_crest"
            Case "Travel Boots 2"
                Return "item_travel_boots_2"
            Case "Lotus Orb"
                Return "item_lotus_orb"
            Case "Crimson Guard"
                Return "item_crimson_guard"
            Case "Moon Shard"
                Return "item_moon_shard"
            Case "Enchanted Mango"
                Return "item_enchanted_mango"
            Case "Faerie Fire"
                Return "item_faerie_fire"
            Case "Aether Lens"
                Return "item_aether_lens"
            Case "Blight Stone"
                Return "item_blight_stone"
            Case "Bloodthorn"
                Return "item_bloodthorn"
            Case "Dragon Lance"
                Return "item_dragon_lance"
            Case "Echo Sabre"
                Return "item_echo_sabre"
            Case "Hurricane Pike"
                Return "item_hurricane_pike"
            Case "Infused Raindrop"
                Return "item_infused_raindrop"
            Case "Iron Talon"
                Return "item_iron_talon"
            Case "Tome of Knowledge"
                Return "item_tome_of_knowledge"
            Case "Wind Lace"
                Return "item_wind_lace"
            Case "Aether Lens (Recipe)"
                Return "item_recipe_aether_lens"
            Case "Hurricane Pike (Recipe)"
                Return "item_recipe_hurricane_pike"
            Case "Iron Talon (Recipe)"
                Return "item_recipe_iron_talon"
            Case Else
                Return "Error! Itemname: " + item_name
        End Select
    End Function

    'Return the pictureID (ImageList1) for each Item
    Public Function GetPicture(ByVal item_name As String) As Integer
        Select Case item_name
            Case "Abyssal Blade"
                Return 0
            Case "Aghanim's Scepter"
                Return 1
            Case "Animal Courier"
                Return 2
            Case "Arcane Boots"
                Return 3
            Case "Armlet"
                Return 4
            Case "Assault Cuirass"
                Return 5
            Case "Battle Fury"
                Return 6
            Case "Belt of Strength"
                Return 7
            Case "Black King Bar"
                Return 8
            Case "Blade Mail"
                Return 9
            Case "Blade of Alacrity"
                Return 10
            Case "Blades of Attack"
                Return 11
            Case "Blink Dagger"
                Return 12
            Case "Bloodstone"
                Return 13
            Case "Band of Elvenskin"
                Return 14
            Case "Boots of Speed"
                Return 15
            Case "Boots of Travel"
                Return 16
            Case "Bottle"
                Return 17
            Case "Bracer"
                Return 18
            Case "Broadsword"
                Return 19
            Case "Buckler"
                Return 20
            Case "Butterfly"
                Return 21
            Case "Chainmail"
                Return 22
            Case "Circlet"
                Return 23
            Case "Clarity"
                Return 24
            Case "Claymore"
                Return 25
            Case "Cloak"
                Return 26
            Case "Crystalys"
                Return 27
            Case "Daedalus"
                Return 28
            Case "Dagon 1"
                Return 29
            Case "Dagon 2"
                Return 30
            Case "Dagon 3"
                Return 31
            Case "Dagon 4"
                Return 32
            Case "Dagon 5"
                Return 33
            Case "Demon Edge"
                Return 34
            Case "Desolator"
                Return 35
            Case "Diffusal Blade 1"
                Return 36
            Case "Diffusal Blade 2"
                Return 37
            Case "Divine Rapier"
                Return 38
            Case "Drum of Endurance"
                Return 39
            Case "Dust of Appearance"
                Return 40
            Case "Eaglesong"
                Return 41
            Case "Energy Booster"
                Return 42
            Case "Ethereal Blade"
                Return 43
            Case "Eul's Scepter of Divinity"
                Return 44
            Case "Eye of Skadi"
                Return 45
            Case "Flying Courier"
                Return 46
            Case "Force Staff"
                Return 47
            Case "Gauntlets of Strength"
                Return 48
            Case "Gem of True Sight"
                Return 49
            Case "Ghost Scepter"
                Return 50
            Case "Gloves of Haste"
                Return 51
            Case "Hand of Midas"
                Return 52
            Case "Headdress"
                Return 53
            Case "Healing Salve"
                Return 54
            Case "Heart of Tarrasque"
                Return 55
            Case "Heaven's Halberd"
                Return 56
            Case "Helm of Iron Will"
                Return 57
            Case "Helm of the Dominator"
                Return 58
            Case "Hood of Defiance"
                Return 59
            Case "Hyperstone"
                Return 60
            Case "Iron Branch"
                Return 61
            Case "Javelin"
                Return 62
            Case "Linken's Sphere"
                Return 63
            Case "Maelstrom"
                Return 64
            Case "Magic Stick"
                Return 65
            Case "Magic Wand"
                Return 66
            Case "Manta Style"
                Return 67
            Case "Mantle of Intelligence"
                Return 68
            Case "Mask of Madness"
                Return 69
            Case "Medallion of Courage"
                Return 70
            Case "Mekansm"
                Return 71
            Case "Mithril Hammer"
                Return 72
            Case "Mjollnir"
                Return 73
            Case "Monkey King Bar"
                Return 74
            Case "Morbid Mask"
                Return 75
            Case "Mystic Staff"
                Return 76
            Case "Necronomicon 1"
                Return 77
            Case "Necronomicon 2"
                Return 78
            Case "Necronomicon 3"
                Return 79
            Case "Null Talisman"
                Return 80
            Case "Oblivion Staff"
                Return 81
            Case "Observer Ward"
                Return 82
            Case "Ogre Club"
                Return 83
            Case "Orb of Venom"
                Return 84
            Case "Orchid Malevolence"
                Return 85
            Case "Perseverance"
                Return 86
            Case "Phase Boots"
                Return 87
            Case "Pipe of Insight"
                Return 88
            Case "Platemail"
                Return 89
            Case "Point Booster"
                Return 90
            Case "Poor Man's Shield"
                Return 91
            Case "Power Treads"
                Return 92
            Case "Quarterstaff"
                Return 93
            Case "Quelling Blade"
                Return 94
            Case "Radiance"
                Return 95
            Case "Reaver"
                Return 96
            Case "Refresher Orb"
                Return 97
            Case "Ring of Aquila"
                Return 98
            Case "Ring of Basilius"
                Return 99
            Case "Ring of Health"
                Return 100
            Case "Ring of Protection"
                Return 101
            Case "Ring of Regen"
                Return 102
            Case "Robe of the Magi"
                Return 103
            Case "Rod of Atos"
                Return 104
            Case "Sacred Relic"
                Return 105
            Case "Sage's Mask"
                Return 106
            Case "Sange"
                Return 107
            Case "Sange and Yasha"
                Return 108
            Case "Satanic"
                Return 109
            Case "Scythe of Vyse"
                Return 110
            Case "Sentry Ward"
                Return 111
            Case "Shadow Blade"
                Return 112
            Case "Shiva's Guard"
                Return 113
            Case "Skull Basher"
                Return 114
            Case "Slippers of Agility"
                Return 115
            Case "Smoke of Deceit"
                Return 116
            Case "Soul Booster"
                Return 117
            Case "Soul Ring"
                Return 118
            Case "Staff of Wizardry"
                Return 119
            Case "Stout Shield"
                Return 120
            Case "Talisman of Evasion"
                Return 121
            Case "Tango"
                Return 122
            Case "Town Portal Scroll"
                Return 123
            Case "Tranquil Boots"
                Return 124
            Case "Ultimate Orb"
                Return 125
            Case "Urn of Shadows"
                Return 126
            Case "Vanguard"
                Return 127
            Case "Veil of Discord"
                Return 128
            Case "Vitality Booster"
                Return 129
            Case "Vladmir's Offering"
                Return 130
            Case "Void Stone"
                Return 131
            Case "Wraith Band"
                Return 132
            Case "Yasha"
                Return 133
            Case "Shadow Amulet"
                Return 135
            Case "Boots of Travel 2"
                Return 136
            Case "Crimson Guard"
                Return 137
            Case "Enchanted Mango"
                Return 138
            Case "Faerie Fire"
                Return 139
            Case "Glimmer Cape"
                Return 140
            Case "Guardian Greaves"
                Return 141
            Case "Lotus Orb"
                Return 142
            Case "Moon Shard"
                Return 143
            Case "Octarine Core"
                Return 144
            Case "Silver Edge"
                Return 145
            Case "Solar Crest"
                Return 146
            Case "Aether Lens"
                Return 147
            Case "Blight Stone"
                Return 148
            Case "Bloodthorn"
                Return 149
            Case "Dragon Lance"
                Return 150
            Case "Echo Sabre"
                Return 151
            Case "Hurricane Pike"
                Return 152
            Case "Infused Raindrop"
                Return 153
            Case "Iron Talon"
                Return 154
            Case "Tome of Knowledge"
                Return 155
            Case "Wind Lace"
                Return 156
            Case Else
                Return 134
        End Select
    End Function
#End Region

#Region "Itemboxes"
    Private Sub ListViewItems0_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewItems0.MouseClick
        If e.Button = MouseButtons.Right Then
            IntPrice = (CInt(Label15.Text) - Itembuild.GetPrice(ListViewItems0.SelectedItems.Item(0).SubItems(1).Text))
            Label15.Text = IntPrice.ToString
            CheckCosts(IntPrice.ToString)
            ListViewItems0.SelectedItems.Item(0).Remove()
            Unsaved = True
        End If
    End Sub

    Private Sub ListViewItems1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewItems1.MouseClick
        If e.Button = MouseButtons.Right Then
            ListViewItems1.SelectedItems.Item(0).Remove()
            Unsaved = True
        End If
    End Sub

    Private Sub ListViewItems2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewItems2.MouseClick
        If e.Button = MouseButtons.Right Then
            ListViewItems2.SelectedItems.Item(0).Remove()
            Unsaved = True
        End If
    End Sub

    Private Sub ListViewItems3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewItems3.MouseClick
        If e.Button = MouseButtons.Right Then
            ListViewItems3.SelectedItems.Item(0).Remove()
            Unsaved = True
        End If
    End Sub

    Private Sub ListViewItems4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewItems4.MouseClick
        If e.Button = MouseButtons.Right Then
            ListViewItems4.SelectedItems.Item(0).Remove()
            Unsaved = True
        End If
    End Sub

    Private Sub ListViewItems5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewItems5.MouseClick
        If e.Button = MouseButtons.Right Then
            ListViewItems5.SelectedItems.Item(0).Remove()
            Unsaved = True
        End If
    End Sub

    Private Sub resetItemboxes()
        active_itembox = ListViewItems0
        ListViewItems0.BackColor = Color.White
        ListViewItems1.BackColor = Color.White
        ListViewItems2.BackColor = Color.White
        ListViewItems3.BackColor = Color.White
        ListViewItems4.BackColor = Color.White
        ListViewItems5.BackColor = Color.White
    End Sub

    Private Sub ListViewItems0_MouseDown(sender As Object, e As MouseEventArgs) Handles ListViewItems0.MouseDown
        resetItemboxes()
        active_itembox = ListViewItems0
        ListViewItems0.BackColor = Color.LightGreen
    End Sub
    Private Sub ListViewItems1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListViewItems1.MouseDown
        resetItemboxes()
        active_itembox = ListViewItems1
        ListViewItems1.BackColor = Color.LightGreen
    End Sub
    Private Sub ListViewItems2_MouseDown(sender As Object, e As MouseEventArgs) Handles ListViewItems2.MouseDown
        resetItemboxes()
        active_itembox = ListViewItems2
        ListViewItems2.BackColor = Color.LightGreen
    End Sub
    Private Sub ListViewItems3_MouseDown(sender As Object, e As MouseEventArgs) Handles ListViewItems3.MouseDown
        resetItemboxes()
        active_itembox = ListViewItems3
        ListViewItems3.BackColor = Color.LightGreen
    End Sub
    Private Sub ListViewItems4_MouseDown(sender As Object, e As MouseEventArgs) Handles ListViewItems4.MouseDown
        resetItemboxes()
        active_itembox = ListViewItems4
        ListViewItems4.BackColor = Color.LightGreen
    End Sub
    Private Sub ListViewItems5_MouseDown(sender As Object, e As MouseEventArgs) Handles ListViewItems5.MouseDown
        resetItemboxes()
        active_itembox = ListViewItems5
        ListViewItems5.BackColor = Color.LightGreen
    End Sub
#End Region

End Class