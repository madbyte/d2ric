Imports System.Resources

'This class contains all methods you need on the itembuild page
Public Class ItembuildClass
    Public NewText As String
    Public Shared Selected_Hero As String
    Dim LocRM As New ResourceManager("D2RIC.Resources", GetType(FormMain).Assembly)

    'Initialize the Itembuild tab
    Public Sub Initialize()
        'DISABLE THE SAVE BUTTON BECAUSE NO HERO IS CHOOSEN IF THE PROGRAM STARTS
        FormMain.ButtonSave.Enabled = False

        ChangeHeroList()
        ClearNotImplemented()
    End Sub

    'Intitialize the ListView with all items
    Public Sub InitializeListbox()
        'Listview füllen
        With FormMain.ListViewConsumables
            .Clear()
            ' Create items and add them to ListView.
            .Items.Add(New ListViewItem(New String() {"Clarity", "Consumables"}, 24))
            .Items.Add(New ListViewItem(New String() {"Mango", "Consumables"}, 134))
            .Items.Add(New ListViewItem(New String() {"Tango", "Consumables"}, 122))
            .Items.Add(New ListViewItem(New String() {"Healing Salve", "Consumables"}, 54))
            .Items.Add(New ListViewItem(New String() {"Smoke of Deceit", "Consumables"}, 116))
            .Items.Add(New ListViewItem(New String() {"Town Portal Scroll", "Consumables"}, 123))
            .Items.Add(New ListViewItem(New String() {"Dust of Appearance", "Consumables"}, 40))
            .Items.Add(New ListViewItem(New String() {"Animal Courier", "Consumables"}, 2))
            .Items.Add(New ListViewItem(New String() {"Flying Courier", "Consumables"}, 46))
            .Items.Add(New ListViewItem(New String() {"Observer Ward", "Consumables"}, 82))
            .Items.Add(New ListViewItem(New String() {"Sentry Ward", "Consumables"}, 111))
            .Items.Add(New ListViewItem(New String() {"Bottle", "Consumables"}, 17))

            'Add Tooltips to Listview
            For i = 0 To .Items.Count - 1
                .Items(i).ToolTipText = GetToolTip(.Items(i).Text)
            Next
        End With

        With FormMain.ListViewAttributes
            .Clear()
            ' Create items and add them to ListView.
            .Items.Add(New ListViewItem(New String() {"Iron Branch", "Attributes"}, 61))
            .Items.Add(New ListViewItem(New String() {"Gauntlets of Strength", "Attributes"}, 48))
            .Items.Add(New ListViewItem(New String() {"Slippers of Agility", "Attributes"}, 115))
            .Items.Add(New ListViewItem(New String() {"Mantle of Intelligence", "Attributes"}, 68))
            .Items.Add(New ListViewItem(New String() {"Circlet", "Attributes"}, 23))
            .Items.Add(New ListViewItem(New String() {"Belt of Strength", "Attributes"}, 7))
            .Items.Add(New ListViewItem(New String() {"Band of Elvenskin", "Attributes"}, 14))
            .Items.Add(New ListViewItem(New String() {"Robe of the Magi", "Attributes"}, 103))
            .Items.Add(New ListViewItem(New String() {"Ogre Club", "Attributes"}, 83))
            .Items.Add(New ListViewItem(New String() {"Blade of Alacrity", "Attributes"}, 10))
            .Items.Add(New ListViewItem(New String() {"Staff of Wizardry", "Attributes"}, 119))

            'Add Tooltips to Listview
            For i = 0 To .Items.Count - 1
                .Items(i).ToolTipText = GetToolTip(.Items(i).Text)
            Next
        End With

        With FormMain.ListViewArmaments
            .Clear()
            ' Create items and add them to ListView.
            .Items.Add(New ListViewItem(New String() {"Ring of Protection", "Armaments"}, 101))
            .Items.Add(New ListViewItem(New String() {"Stout Shield", "Armaments"}, 120))
            .Items.Add(New ListViewItem(New String() {"Quelling Blade", "Armaments"}, 94))
            .Items.Add(New ListViewItem(New String() {"Orb of Venom", "Armaments"}, 84))
            .Items.Add(New ListViewItem(New String() {"Blades of Attack", "Armaments"}, 11))
            .Items.Add(New ListViewItem(New String() {"Chainmail", "Armaments"}, 22))
            .Items.Add(New ListViewItem(New String() {"Quarterstaff", "Armaments"}, 93))
            .Items.Add(New ListViewItem(New String() {"Helm of Iron Will", "Armaments"}, 57))
            .Items.Add(New ListViewItem(New String() {"Broadsword", "Armaments"}, 19))
            .Items.Add(New ListViewItem(New String() {"Claymore", "Armaments"}, 25))
            .Items.Add(New ListViewItem(New String() {"Javelin", "Armaments"}, 62))
            .Items.Add(New ListViewItem(New String() {"Mithril Hammer", "Armaments"}, 72))

            'Add Tooltips to Listview
            For i = 0 To .Items.Count - 1
                .Items(i).ToolTipText = GetToolTip(.Items(i).Text)
            Next
        End With

        With FormMain.ListViewArcane
            .Clear()
            ' Create items and add them to ListView.
            .Items.Add(New ListViewItem(New String() {"Magic Stick", "Arcane"}, 65))
            .Items.Add(New ListViewItem(New String() {"Sage's Mask", "Arcane"}, 106))
            .Items.Add(New ListViewItem(New String() {"Ring of Regen", "Arcane"}, 102))
            .Items.Add(New ListViewItem(New String() {"Boots of Speed", "Arcane"}, 15))
            .Items.Add(New ListViewItem(New String() {"Gloves of Haste", "Arcane"}, 51))
            .Items.Add(New ListViewItem(New String() {"Cloak", "Arcane"}, 26))
            .Items.Add(New ListViewItem(New String() {"Ring of Health", "Arcane"}, 100))
            .Items.Add(New ListViewItem(New String() {"Void Stone", "Arcane"}, 131))
            .Items.Add(New ListViewItem(New String() {"Gem of True Sight", "Arcane"}, 49))
            .Items.Add(New ListViewItem(New String() {"Morbid Mask", "Arcane"}, 75))
            .Items.Add(New ListViewItem(New String() {"Shadow Amulet", "Arcane"}, 135))
            .Items.Add(New ListViewItem(New String() {"Ghost Scepter", "Arcane"}, 50))
            .Items.Add(New ListViewItem(New String() {"Blink Dagger", "Arcane"}, 12))

            'Add Tooltips to Listview
            For i = 0 To .Items.Count - 1
                .Items(i).ToolTipText = GetToolTip(.Items(i).Text)
            Next
        End With

        With FormMain.ListViewCommon
            .Clear()
            ' Create items and add them to ListView.
            .Items.Add(New ListViewItem(New String() {"Magic Wand", "Common"}, 66))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Magic Wand (Recipe)", "Common"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Null Talisman", "Common"}, 80))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Null Talisman (Recipe)", "Common"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Wraith Band", "Common"}, 132))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Wraith Band (Recipe)", "Common"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Poor Man's Shield", "Common"}, 91))
            .Items.Add(New ListViewItem(New String() {"Bracer", "Common"}, 18))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Bracer (Recipe)", "Common"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Soul Ring", "Common"}, 118))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Soul Ring (Recipe)", "Common"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Phase Boots", "Common"}, 87))
            .Items.Add(New ListViewItem(New String() {"Power Treads", "Common"}, 92))
            .Items.Add(New ListViewItem(New String() {"Oblivion Staff", "Common"}, 81))
            .Items.Add(New ListViewItem(New String() {"Perseverance", "Common"}, 86))
            .Items.Add(New ListViewItem(New String() {"Hand of Midas", "Common"}, 52))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Hand of Midas (Recipe)", "Common"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Boots of Travel", "Common"}, 16))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Boots of Travel (Recipe)", "Common"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Boots of Travel 2", "Common"}, 134))
            .Items.Add(New ListViewItem(New String() {"Moon Shard", "Common"}, 134))

            'Add Tooltips to Listview
            For i = 0 To .Items.Count - 1
                .Items(i).ToolTipText = GetToolTip(.Items(i).Text)
            Next
        End With

        With FormMain.ListViewSupport
            .Clear()
            ' Create items and add them to ListView.
            .Items.Add(New ListViewItem(New String() {"Ring of Basilius", "Support"}, 99))
            .Items.Add(New ListViewItem(New String() {"Headdress", "Support"}, 53))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Headdress (Recipe)", "Support"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Buckler", "Support"}, 20))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Buckler (Recipe)", "Support"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Urn of Shadows", "Support"}, 126))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Urn of Shadows (Recipe)", "Support"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Tranquil Boots", "Support"}, 124))
            .Items.Add(New ListViewItem(New String() {"Ring of Aquila", "Support"}, 98))
            .Items.Add(New ListViewItem(New String() {"Medallion of Courage", "Support"}, 70))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Medallion of Courage (Recipe)", "Support"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Arcane Boots", "Support"}, 3))
            .Items.Add(New ListViewItem(New String() {"Drum of Endurance", "Support"}, 39))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Drum of Endurance (Recipe)", "Support"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Mekansm", "Support"}, 71))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Mekansm (Recipe)", "Support"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Vladmir's Offering", "Support"}, 130))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Vladmir's Offering (Recipe)", "Support"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Pipe of Insight", "Support"}, 88))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Pipe of Insight (Recipe)", "Support"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Guardian Greaves", "Support"}, 134))

            'Add Tooltips to Listview
            For i = 0 To .Items.Count - 1
                .Items(i).ToolTipText = GetToolTip(.Items(i).Text)
            Next
        End With

        With FormMain.ListViewCaster
            .Clear()
            ' Create items and add them to ListView.
            .Items.Add(New ListViewItem(New String() {"Glimmer Cape", "Caster"}, 134))
            .Items.Add(New ListViewItem(New String() {"Force Staff", "Caster"}, 47))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Force Staff (Recipe)", "Caster"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Veil of Discord", "Caster"}, 128))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Veil of Discord (Recipe)", "Caster"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Necronomicon 1", "Caster"}, 77))
            .Items.Add(New ListViewItem(New String() {"Necronomicon 2", "Caster"}, 78))
            .Items.Add(New ListViewItem(New String() {"Necronomicon 3", "Caster"}, 79))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Necronomicon (Recipe)", "Caster"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Dagon 1", "Caster"}, 29))
            .Items.Add(New ListViewItem(New String() {"Dagon 2", "Caster"}, 30))
            .Items.Add(New ListViewItem(New String() {"Dagon 3", "Caster"}, 31))
            .Items.Add(New ListViewItem(New String() {"Dagon 4", "Caster"}, 32))
            .Items.Add(New ListViewItem(New String() {"Dagon 5", "Caster"}, 33))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Dagon (Recipe)", "Caster"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Eul's Scepter of Divinity", "Caster"}, 44))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Eul's Scepter of Divinity (Recipe)", "Caster"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Solar Crest", "Caster"}, 134))
            .Items.Add(New ListViewItem(New String() {"Rod of Atos", "Caster"}, 104))
            .Items.Add(New ListViewItem(New String() {"Orchid Malevolence", "Caster"}, 85))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Orchid Malevolence (Recipe)", "Caster"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Aghanim's Scepter", "Caster"}, 1))
            .Items.Add(New ListViewItem(New String() {"Refresher Orb", "Caster"}, 97))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Refresher Orb (Recipe)", "Caster"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Scythe of Vyse", "Caster"}, 110))
            .Items.Add(New ListViewItem(New String() {"Octarine Core", "Caster"}, 134))

            'Add Tooltips to Listview
            For i = 0 To .Items.Count - 1
                .Items(i).ToolTipText = GetToolTip(.Items(i).Text)
            Next
        End With

        With FormMain.ListViewWeapons
            .Clear()
            ' Create items and add them to ListView.
            .Items.Add(New ListViewItem(New String() {"Crystalys", "Weapons"}, 27))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Crystalys (Recipe)", "Weapons"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Armlet", "Weapons"}, 4))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Armlet (Recipe)", "Weapons"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Shadow Blade", "Weapons"}, 112))
            .Items.Add(New ListViewItem(New String() {"Skull Basher", "Weapons"}, 114))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Skull Basher (Recipe)", "Weapons"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Battle Fury", "Weapons"}, 6))
            .Items.Add(New ListViewItem(New String() {"Ethereal Blade", "Weapons"}, 43))
            .Items.Add(New ListViewItem(New String() {"Silver Edge", "Weapons"}, 134))
            .Items.Add(New ListViewItem(New String() {"Radiance", "Weapons"}, 95))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Radiance (Recipe)", "Weapons"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Monkey King Bar", "Weapons"}, 74))
            .Items.Add(New ListViewItem(New String() {"Daedalus", "Weapons"}, 28))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Daedalus (Recipe)", "Weapons"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Butterfly", "Weapons"}, 21))
            .Items.Add(New ListViewItem(New String() {"Divine Rapier", "Weapons"}, 38))
            .Items.Add(New ListViewItem(New String() {"Abyssal Blade", "Weapons"}, 0))

            'Add Tooltips to Listview
            For i = 0 To .Items.Count - 1
                .Items(i).ToolTipText = GetToolTip(.Items(i).Text)
            Next
        End With

        With FormMain.ListViewArmor
            .Clear()
            ' Create items and add them to ListView.
            .Items.Add(New ListViewItem(New String() {"Hood of Defiance", "Armor"}, 59))
            .Items.Add(New ListViewItem(New String() {"Vanguard", "Armor"}, 127))
            .Items.Add(New ListViewItem(New String() {"Blade Mail", "Armor"}, 9))
            .Items.Add(New ListViewItem(New String() {"Soul Booster", "Armor"}, 117))
            .Items.Add(New ListViewItem(New String() {"Crimson Guard", "Armor"}, 134))
            .Items.Add(New ListViewItem(New String() {"Black King Bar", "Armor"}, 8))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Black King Bar (Recipe)", "Armor"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Lotus Orb", "Armor"}, 134))
            .Items.Add(New ListViewItem(New String() {"Shiva's Guard", "Armor"}, 113))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Shiva's Guard (Recipe)", "Armor"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Bloodstone", "Armor"}, 13))
            .Items.Add(New ListViewItem(New String() {"Manta Style", "Armor"}, 67))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Manta Style (Recipe)", "Armor"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Linken's Sphere", "Armor"}, 63))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Linken's Sphere (Recipe)", "Armor"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Assault Cuirass", "Armor"}, 5))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Assault Cuirass (Recipe)", "Armor"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Heart of Tarrasque", "Armor"}, 55))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Heart of Tarrasque (Recipe)", "Armor"}, 134))
            End If

            'Add Tooltips to Listview
            For i = 0 To .Items.Count - 1
                .Items(i).ToolTipText = GetToolTip(.Items(i).Text)
            Next
        End With

        With FormMain.ListViewArtifacts
            .Clear()
            ' Create items and add them to ListView.
            .Items.Add(New ListViewItem(New String() {"Mask of Madness", "Artifacts"}, 69))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Mask of Madness (Recipe)", "Artifact"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Helm of the Dominator", "Artifacts"}, 58))
            .Items.Add(New ListViewItem(New String() {"Sange", "Artifacts"}, 107))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Sange (Recipe)", "Artifact"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Yasha", "Artifacts"}, 133))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Yasha (Recipe)", "Artifact"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Maelstrom", "Artifacts"}, 64))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Maelstrom (Recipe)", "Artifact"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Diffusal Blade 1", "Artifacts"}, 36))
            .Items.Add(New ListViewItem(New String() {"Diffusal Blade 2", "Artifacts"}, 37))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Diffusal Blade (Recipe)", "Artifact"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Desolator", "Artifacts"}, 35))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Desolator (Recipe)", "Artifact"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Heaven's Halberd", "Artifacts"}, 56))
            .Items.Add(New ListViewItem(New String() {"Sange and Yasha", "Artifacts"}, 108))
            .Items.Add(New ListViewItem(New String() {"Eye of Skadi", "Artifacts"}, 45))
            .Items.Add(New ListViewItem(New String() {"Mjollnir", "Artifacts"}, 73))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Mjollnir (Recipe)", "Artifact"}, 134))
            End If
            .Items.Add(New ListViewItem(New String() {"Satanic", "Artifacts"}, 109))
            If FormMain.CheckBox1.Checked Then
                .Items.Add(New ListViewItem(New String() {"Satanic (Recipe)", "Artifact"}, 134))
            End If

            'Add Tooltips to Listview
            For i = 0 To .Items.Count - 1
                .Items(i).ToolTipText = GetToolTip(.Items(i).Text)
            Next
        End With

        With FormMain.ListViewSecretShop
            .Clear()
            ' Create items and add them to ListView.
            .Items.Add(New ListViewItem(New String() {"Energy Booster", "Secret Shop"}, 42))
            .Items.Add(New ListViewItem(New String() {"Vitality Booster", "Secret Shop"}, 129))
            .Items.Add(New ListViewItem(New String() {"Point Booster", "Secret Shop"}, 90))
            .Items.Add(New ListViewItem(New String() {"Platemail", "Secret Shop"}, 89))
            .Items.Add(New ListViewItem(New String() {"Talisman of Evasion", "Secret Shop"}, 121))
            .Items.Add(New ListViewItem(New String() {"Hyperstone", "Secret Shop"}, 60))
            .Items.Add(New ListViewItem(New String() {"Ultimate Orb", "Secret Shop"}, 125))
            .Items.Add(New ListViewItem(New String() {"Demon Edge", "Secret Shop"}, 34))
            .Items.Add(New ListViewItem(New String() {"Mystic Staff", "Secret Shop"}, 76))
            .Items.Add(New ListViewItem(New String() {"Reaver", "Secret Shop"}, 96))
            .Items.Add(New ListViewItem(New String() {"Eaglesong", "Secret Shop"}, 41))
            .Items.Add(New ListViewItem(New String() {"Sacred Relic", "Secret Shop"}, 105))

            'Add Tooltips to Listview
            For i = 0 To .Items.Count - 1
                .Items(i).ToolTipText = GetToolTip(.Items(i).Text)
            Next
        End With
    End Sub

    'Reset the Itembuild tab
    Public Sub Clear()
        FormMain.TextBox1.Text = ""
        FormMain.Label1.Text = ""
        FormMain.Label15.Text = "0"
        FormMain.Itemslot1.Text = "unused"
        FormMain.Itemslot2.Text = "unused"
        FormMain.Itemslot3.Text = "unused"
        FormMain.Itemslot4.Text = "unused"
        FormMain.Itemslot5.Text = "unused"
        FormMain.Itemslot6.Text = "unused"
        FormMain.IntPrice = 0
        NewText = ""
        FormMain.ListViewItems0.Clear()
        FormMain.ListViewItems1.Clear()
        FormMain.ListViewItems2.Clear()
        FormMain.ListViewItems3.Clear()
        FormMain.ListViewItems4.Clear()
        FormMain.ListViewItems5.Clear()
    End Sub

    'Save the itembuild and change the author
    Public Sub Save()
        If (Selected_Hero <> "") Then
            SaveChanges()
            If FormMain.TextBox1.Text <> "" Then
                ChangeAuthor(FormMain.TextBox1.Text, Selected_Hero)
            End If
            IO.File.WriteAllText(My.Settings.dota2path + "\default_" + Selected_Hero + ".txt", NewText)
        Else
            MessageBox.Show(LocRM.GetString("chooseAHero"))
        End If
    End Sub

    'Return the Standard Valve label if found
    Public Function GetLabel(ByVal Label) As String
        Label = Replace(Label, """", "")
        Label = Replace(Label, " ", "")
        Label = Replace(Label, vbTab, "")
        If (Label.Contains("#")) Then
            Select Case Label
                Case "#DOTA_Item_Build_Starting_Items"
                    Label = "Starting Items"
                Case "#DOTA_Item_Build_Starting_Items_Secondary"
                    Label = "Starting Items (Secondary)"
                Case "#DOTA_Item_Build_Early_Game"
                    Label = "Early Game"
                Case "#DOTA_Item_Build_Early_Game_Secondary"
                    Label = "Early Game (Secondary)"
                Case "#DOTA_Item_Build_Core_Items"
                    Label = "Core Items"
                Case "#DOTA_Item_Build_Core_Items_Secondary"
                    Label = "Core Items (Secondary)"
                Case "#DOTA_Item_Build_Luxury"
                    Label = "Luxury"
                Case Else
                    Label = Replace(Label, "_", " ")
            End Select
        End If
        Return Label
    End Function

    'Return the Standard Valve item slot if found
    Public Function GetItemSlot(ByVal Slot) As String
        Select Case Slot
            Case "Starting Items"
                Slot = "#DOTA_Item_Build_Starting_Items"
            Case "Starting Items (Secondary)"
                Slot = "#DOTA_Item_Build_Starting_Items_Secondary"
            Case "Early Game"
                Slot = "#DOTA_Item_Build_Early_Game"
            Case "Early Game (Secondary)"
                Slot = "#DOTA_Item_Build_Early_Game_Secondary"
            Case "Core Items"
                Slot = "#DOTA_Item_Build_Core_Items"
            Case "Core Items (Secondary)"
                Slot = "#DOTA_Item_Build_Core_Items_Secondary"
            Case "Luxury"
                Slot = "#DOTA_Item_Build_Luxury"
            Case Else
                Slot = Slot
        End Select
        Return """" + Slot + """"
    End Function

    'Load an itembuild out of an itembuild file
    Public Sub CheckFile(ByVal hero As String)
        Dim File As String = My.Settings.dota2path + "\default_" + hero + ".txt"
        If IO.File.Exists(File) Then
            Dim ItemName As String
            Dim ItemList As Object = FormMain.ListViewItems0
            Dim Index As Integer = 0
            Dim price As Object = FormMain.Label15
            Dim savePrice As Boolean = True
            Dim int As Integer
            Dim LV_Index As Integer = -1
            Dim OldLine As String = ""
            For Each Zeile As String In IO.File.ReadAllLines(File)
                If Zeile.Contains("item_") Then
                    ItemName = FormMain.RenameItem(Zeile)
                    If savePrice Then
                        int = (CInt(price.Text) + GetPrice(ItemName))
                        price.Text = int.ToString
                        FormMain.CheckCosts(int)
                    End If
                    With ItemList
                        Dim item As New ListViewItem(New String() {"", ItemName}, FormMain.GetPicture(ItemName))
                        .Items.AddRange(New ListViewItem() {item})
                        .Items(Index).ToolTipText = GetToolTip(ItemName)
                    End With
                    Index = Index + 1
                ElseIf Zeile.Contains("{") Then
                    NewText &= Zeile & vbNewLine
                    LV_Index += 1
                    Select Case LV_Index
                        Case 2
                            FormMain.Itemslot1.Text = GetLabel(OldLine)
                        Case 3
                            FormMain.Itemslot2.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListViewItems1
                            Index = 0
                            savePrice = False
                        Case 4
                            FormMain.Itemslot3.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListViewItems2
                            Index = 0
                            savePrice = False
                        Case 5
                            FormMain.Itemslot4.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListViewItems3
                            Index = 0
                            savePrice = False
                        Case 6
                            FormMain.Itemslot5.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListViewItems4
                            Index = 0
                            savePrice = False
                        Case 7
                            FormMain.Itemslot6.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListViewItems5
                            Index = 0
                            savePrice = False
                        Case Else
                    End Select
                ElseIf Zeile.Contains("author") Then
                    FormMain.TextBox1.Text = Replace(Zeile, """", "")
                    FormMain.TextBox1.Text = Replace(FormMain.TextBox1.Text, "author", "")
                    FormMain.TextBox1.Text = Replace(FormMain.TextBox1.Text, vbTab, "")
                    NewText &= Zeile & vbNewLine
                Else
                    OldLine = Zeile
                    NewText &= Zeile & vbNewLine
                End If
            Next
            FormMain.ButtonSave.Enabled = True
        Else
            Clear()
            FormMain.ButtonSave.Enabled = False
            MessageBox.Show(LocRM.GetString("notImplemented"))
        End If
    End Sub

    'Load the default itembuild, if it exists
    Public Sub LoadDefault()
        Dim File As String = My.Settings.dota2path + "\Backup\default_" + Selected_Hero + ".txt"
        If IO.File.Exists(File) Then
            Dim ItemName As String
            Dim ItemList As Object = FormMain.ListViewItems0
            Dim Index As Integer = 0
            Dim price As Object = FormMain.Label15
            Dim savePrice As Boolean = True
            Dim int As Integer
            Dim LV_Index As Integer = -1
            Dim OldLine As String = ""
            Clear()
            For Each Zeile As String In IO.File.ReadAllLines(File)
                If Zeile.Contains("item_") Then
                    ItemName = FormMain.RenameItem(Zeile)
                    If savePrice Then
                        int = (CInt(price.Text) + GetPrice(ItemName))
                        price.Text = int.ToString
                        FormMain.CheckCosts(int)
                    End If
                    With ItemList
                        Dim item As New ListViewItem(New String() {"", ItemName}, FormMain.GetPicture(ItemName))
                        .Items.AddRange(New ListViewItem() {item})
                        .Items(Index).ToolTipText = GetToolTip(ItemName)
                    End With
                    Index = Index + 1
                ElseIf Zeile.Contains("{") Then
                    NewText &= Zeile & vbNewLine
                    LV_Index += 1
                    Select Case LV_Index
                        Case 2
                            FormMain.Itemslot1.Text = GetLabel(OldLine)
                        Case 3
                            FormMain.Itemslot2.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListViewItems1
                            Index = 0
                            savePrice = False
                        Case 4
                            FormMain.Itemslot3.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListViewItems2
                            Index = 0
                            savePrice = False
                        Case 5
                            FormMain.Itemslot4.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListViewItems3
                            Index = 0
                            savePrice = False
                        Case 6
                            FormMain.Itemslot5.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListViewItems4
                            Index = 0
                            savePrice = False
                        Case 7
                            FormMain.Itemslot6.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListViewItems5
                            Index = 0
                            savePrice = False
                        Case Else
                    End Select
                ElseIf Zeile.Contains("author") Then
                    FormMain.TextBox1.Text = Replace(Zeile, """", "")
                    FormMain.TextBox1.Text = Replace(FormMain.TextBox1.Text, "author", "")
                    FormMain.TextBox1.Text = Replace(FormMain.TextBox1.Text, vbTab, "")
                    NewText &= Zeile & vbNewLine
                ElseIf Zeile.Contains("hero") Then
                    Dim temp As String = Replace(Zeile, """hero""", "")
                    temp = Replace(temp, """", "")
                    temp = Replace(temp, vbTab, "")
                    FormMain.Label1.Text = renameHero(temp)
                Else
                    OldLine = Zeile
                    NewText &= Zeile & vbNewLine
                End If
            Next
            FormMain.ButtonSave.Enabled = True
        Else
            MessageBox.Show(LocRM.GetString("noBackup"))
        End If
    End Sub

    'Change the author of the itembuild file
    Public Sub ChangeAuthor(ByVal author As String, ByVal hero As String)
        IO.File.WriteAllText(My.Settings.dota2path + "\temp.txt", NewText)
        If IO.File.Exists(My.Settings.dota2path + "\temp.txt") Then
            NewText = ""
            Dim DeinPfad As String = My.Settings.dota2path + "\temp.txt"
            Dim i As Integer = 1
            For Each Zeile As String In IO.File.ReadAllLines(DeinPfad)
                If Zeile.Contains("author") Then
                    NewText &= vbTab & """author""" & vbTab & vbTab & """" & author & """" & vbNewLine
                ElseIf Zeile.Contains("hero") Then
                    NewText &= vbTab & """hero""" & vbTab & vbTab & vbTab & """npc_dota_hero_" & hero & """" & vbNewLine
                Else
                    NewText &= Zeile & vbNewLine
                End If
            Next
            IO.File.Delete(My.Settings.dota2path + "\temp.txt")
        Else

        End If
    End Sub

    'Save the itembuild of the selected hero in the variable 'NewText' and create a backup if it doesn't exists
    Public Sub SaveChanges()
        If Not IO.File.Exists(My.Settings.dota2path + "\Backup\default_" + Selected_Hero + ".txt") Then
            If Not IO.Directory.Exists(My.Settings.dota2path & "\Backup") Then
                ' Nein! Jetzt erstellen...
                Try
                    IO.Directory.CreateDirectory(My.Settings.dota2path & "\Backup")
                    ' Ordner wurde korrekt erstellt!
                Catch ex As Exception
                    ' Ordner wurde nich erstellt
                    MessageBox.Show(LocRM.GetString("cantCreateBackupFolder"))
                End Try
            End If
            'Create Backup
            Try
                IO.File.Copy(My.Settings.dota2path + "\default_" + Selected_Hero + ".txt", My.Settings.dota2path + "\Backup\default_" + Selected_Hero + ".txt", True)  ' Kopiert die Dateien
            Catch ex As Exception
                ' Ordner wurde nich erstellt
                MessageBox.Show(LocRM.GetString("cantCreateBackup"))
            End Try
        End If

        IO.File.WriteAllText(My.Settings.dota2path + "\temp.txt", NewText)
        If IO.File.Exists(My.Settings.dota2path + "\temp.txt") Then
            NewText = ""
            Dim DeinPfad As String = My.Settings.dota2path + "\temp.txt"
            For Each Zeile As String In IO.File.ReadAllLines(DeinPfad)
                If Zeile.Contains("""Items""") Then
                    NewText &= Zeile & vbNewLine
                    Exit For
                Else
                    NewText &= Zeile & vbNewLine
                End If
            Next
            IO.File.Delete(My.Settings.dota2path + "\temp.txt")

            Dim Box1 As String = ""
            Dim Box2 As String = ""
            Dim Box3 As String = ""
            Dim Box4 As String = ""
            Dim Box5 As String = ""
            Dim Box6 As String = ""
            Dim a As Integer = 1

            For i = 0 To (FormMain.ListViewItems0.Items.Count - 1)
                Box1 &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & """" & FormMain.GetItem(FormMain.ListViewItems0.Items(i).SubItems(1).Text) & """"
            Next
            For i = 0 To (FormMain.ListViewItems1.Items.Count - 1)
                Box2 &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & """" & FormMain.GetItem(FormMain.ListViewItems1.Items(i).SubItems(1).Text) & """"
            Next
            For i = 0 To (FormMain.ListViewItems2.Items.Count - 1)
                Box3 &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & """" & FormMain.GetItem(FormMain.ListViewItems2.Items(i).SubItems(1).Text) & """"
            Next
            For i = 0 To (FormMain.ListViewItems3.Items.Count - 1)
                Box4 &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & """" & FormMain.GetItem(FormMain.ListViewItems3.Items(i).SubItems(1).Text) & """"
            Next
            For i = 0 To (FormMain.ListViewItems4.Items.Count - 1)
                Box5 &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & """" & FormMain.GetItem(FormMain.ListViewItems4.Items(i).SubItems(1).Text) & """"
            Next
            For i = 0 To (FormMain.ListViewItems5.Items.Count - 1)
                Box6 &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & """" & FormMain.GetItem(FormMain.ListViewItems5.Items(i).SubItems(1).Text) & """"
            Next

            NewText &= vbTab & "{" & vbNewLine
            If Box1.Length > 0 Then
                'Add Box1 Items
                NewText &= vbTab & vbTab & GetItemSlot(FormMain.Itemslot1.Text) & vbNewLine & vbTab & vbTab & "{"
                NewText &= Box1 & vbNewLine
                NewText &= vbTab & vbTab & "}" & vbNewLine & vbNewLine
            End If
            If Box2.Length > 0 Then
                'Add Box2 Items
                NewText &= vbTab & vbTab & GetItemSlot(FormMain.Itemslot2.Text) & vbNewLine & vbTab & vbTab & "{"
                NewText &= Box2 & vbNewLine
                NewText &= vbTab & vbTab & "}" & vbNewLine & vbNewLine
            End If
            If Box3.Length > 0 Then
                'Add Box3 Items
                NewText &= vbTab & vbTab & GetItemSlot(FormMain.Itemslot3.Text) & vbNewLine & vbTab & vbTab & "{"
                NewText &= Box3 & vbNewLine
                NewText &= vbTab & vbTab & "}" & vbNewLine & vbNewLine
            End If
            If Box4.Length > 0 Then
                'Add Box4 Items
                NewText &= vbTab & vbTab & GetItemSlot(FormMain.Itemslot4.Text) & vbNewLine & vbTab & vbTab & "{"
                NewText &= Box4 & vbNewLine
                NewText &= vbTab & vbTab & "}" & vbNewLine & vbNewLine
            End If
            If Box5.Length > 0 Then
                'Add Box5 Items
                NewText &= vbTab & vbTab & GetItemSlot(FormMain.Itemslot5.Text) & vbNewLine & vbTab & vbTab & "{"
                NewText &= Box5 & vbNewLine
                NewText &= vbTab & vbTab & "}" & vbNewLine & vbNewLine
            End If
            If Box6.Length > 0 Then
                'Add Box6 Items
                NewText &= vbTab & vbTab & GetItemSlot(FormMain.Itemslot6.Text) & vbNewLine & vbTab & vbTab & "{"
                NewText &= Box6 & vbNewLine
                NewText &= vbTab & vbTab & "}" & vbNewLine & vbNewLine
            End If

            NewText &= vbTab & "}" & vbNewLine & "}"

        Else
            MessageBox.Show(LocRM.GetString("errorText"))
        End If
    End Sub

    'Return the real hero name as string out of the name in the itembuild file
    Public Function renameHero(ByVal hero) As String
        hero = hero.ToLower
        Select Case True
            Case hero Like "npc_dota_hero_alchemist"
                hero = "Alchemist"
            Case hero Like "npc_dota_hero_ancient_apparition"
                hero = "Ancient Apparition"
            Case hero Like "npc_dota_hero_antimage"
                hero = "Anti-Mage"
            Case hero Like "npc_dota_hero_axe"
                hero = "Axe"
            Case hero Like "npc_dota_hero_bane"
                hero = "Bane"
            Case hero Like "npc_dota_hero_batrider"
                hero = "Batrider"
            Case hero Like "npc_dota_hero_beastmaster"
                hero = "Beastmaster"
            Case hero Like "npc_dota_hero_bloodseeker"
                hero = "Bloodseeker"
            Case hero Like "npc_dota_hero_bounty_hunter"
                hero = "Bounty Hunter"
            Case hero Like "npc_dota_hero_broodmother"
                hero = "Broodmother"
            Case hero Like "npc_dota_hero_chaos_knight"
                hero = "Chaos Knight"
            Case hero Like "npc_dota_hero_chen"
                hero = "Chen"
            Case hero Like "npc_dota_hero_clinkz"
                hero = "Clinkz"
            Case hero Like "npc_dota_hero_rattletrap"
                hero = "Clockwerk"
            Case hero Like "npc_dota_hero_crystal_maiden"
                hero = "Crystal Maiden"
            Case hero Like "npc_dota_hero_dark_seer"
                hero = "Dark Seer"
            Case hero Like "npc_dota_hero_dazzle"
                hero = "Dazzle"
            Case hero Like "npc_dota_hero_death_prophet"
                hero = "Death Prophet"
            Case hero Like "npc_dota_hero_undying"
                hero = "Undying"
            Case hero Like "npc_dota_hero_doom_bringer"
                hero = "Doom"
            Case hero Like "npc_dota_hero_dragon_knight"
                hero = "Dragon Knight"
            Case hero Like "npc_dota_hero_drow_ranger"
                hero = "Drow Ranger"
            Case hero Like "npc_dota_hero_earthshaker"
                hero = "Earthshaker"
            Case hero Like "npc_dota_hero_enchantress"
                hero = "Enchantress"
            Case hero Like "npc_dota_hero_enigma"
                hero = "Enigma"
            Case hero Like "npc_dota_hero_faceless_void"
                hero = "Faceless Void"
            Case hero Like "npc_dota_hero_gyrocopter"
                hero = "Gyrocopter"
            Case hero Like "npc_dota_hero_huskar"
                hero = "Huskar"
            Case hero Like "npc_dota_hero_invoker"
                hero = "Invoker"
            Case hero Like "npc_dota_hero_jakiro"
                hero = "Jakiro"
            Case hero Like "npc_dota_hero_juggernaut"
                hero = "Juggernaut"
            Case hero Like "npc_dota_hero_keeper_of_the_light"
                hero = "Keeper of the Light"
            Case hero Like "npc_dota_hero_kunkka"
                hero = "Kunkka"
            Case hero Like "npc_dota_hero_templar_assassin"
                hero = "Templar Assassin"
            Case hero Like "npc_dota_hero_leshrac"
                hero = "Leshrac"
            Case hero Like "npc_dota_hero_lich"
                hero = "Lich"
            Case hero Like "npc_dota_hero_life_stealer"
                hero = "Lifestealer"
            Case hero Like "npc_dota_hero_lina"
                hero = "Lina"
            Case hero Like "npc_dota_hero_lion"
                hero = "Lion"
            Case hero Like "npc_dota_hero_lone_druid"
                hero = "Lone Druid"
            Case hero Like "npc_dota_hero_lycan"
                hero = "Lycan"
            Case hero Like "npc_dota_hero_leepo"
                hero = "Meepo"
            Case hero Like "npc_dota_hero_mirana"
                hero = "Mirana"
            Case hero Like "npc_dota_hero_morphling"
                hero = "Morphling"
            Case hero Like "npc_dota_hero_phantom_assassin"
                hero = "Phantom Assassin"
            Case hero Like "npc_dota_hero_furion"
                hero = "Nature's Prophet"
            Case hero Like "npc_dota_hero_necrolyte"
                hero = "Necrophos"
            Case hero Like "npc_dota_hero_nyx_assassin"
                hero = "Nyx Assassin"
            Case hero Like "npc_dota_hero_night_stalker"
                hero = "Night Stalker"
            Case hero Like "npc_dota_hero_ogre_magi"
                hero = "Ogre Magi"
            Case hero Like "npc_dota_hero_omniknight"
                hero = "Omniknight"
            Case hero Like "npc_dota_hero_obsidian_destroyer"
                hero = "Outworld Devourer"
            Case hero Like "npc_dota_hero_phantom_lancer"
                hero = "Phantom Lancer"
            Case hero Like "npc_dota_hero_puck"
                hero = "Puck"
            Case hero Like "npc_dota_hero_pudge"
                hero = "Pudge"
            Case hero Like "npc_dota_hero_pugna"
                hero = "Pugna"
            Case hero Like "npc_dota_hero_queenofpain"
                hero = "Queen of Pain"
            Case hero Like "npc_dota_hero_razor"
                hero = "Razor"
            Case hero Like "npc_dota_hero_riki"
                hero = "Riki"
            Case hero Like "npc_dota_hero_sand_king"
                hero = "Sand King"
            Case hero Like "npc_dota_hero_shadow_demon"
                hero = "Shadow Demon"
            Case hero Like "npc_dota_hero_nevermore"
                hero = "Shadow Fiend"
            Case hero Like "npc_dota_hero_shadow_shaman"
                hero = "Shadow Shaman"
            Case hero Like "npc_dota_hero_silencer"
                hero = "Silencer"
            Case hero Like "npc_dota_hero_skeleton_king"
                hero = "Skeleton King"
            Case hero Like "npc_dota_hero_slardar"
                hero = "Slardar"
            Case hero Like "npc_dota_hero_sniper"
                hero = "Sniper"
            Case hero Like "npc_dota_hero_spectre"
                hero = "Spectre"
            Case hero Like "npc_dota_hero_spirit_breaker"
                hero = "Spirit Breaker"
            Case hero Like "npc_dota_hero_storm_spirit"
                hero = "Storm Spirit"
            Case hero Like "npc_dota_hero_sven"
                hero = "Sven"
            Case hero Like "npc_dota_hero_tidehunter"
                hero = "Tidehunter"
            Case hero Like "npc_dota_hero_tinker"
                hero = "Tinker"
            Case hero Like "npc_dota_hero_tiny"
                hero = "Tiny"
            Case hero Like "npc_dota_hero_treant"
                hero = "Treant Protector"
            Case hero Like "npc_dota_hero_ursa"
                hero = "Ursa"
            Case hero Like "npc_dota_hero_vengefulspirit"
                hero = "Vengeful Spirit"
            Case hero Like "npc_dota_hero_venomancer"
                hero = "Venomancer"
            Case hero Like "npc_dota_hero_viper"
                hero = "Viper"
            Case hero Like "npc_dota_hero_warlock"
                hero = "Warlock"
            Case hero Like "npc_dota_hero_weaver"
                hero = "Weaver"
            Case hero Like "npc_dota_hero_windrunner"
                hero = "Windranger"
            Case hero Like "npc_dota_hero_witch_doctor"
                hero = "Witch Doctor"
            Case hero Like "npc_dota_hero_zuus"
                hero = "Zeus"
            Case hero Like "npc_dota_hero_wisp"
                hero = "Io"
            Case hero Like "npc_dota_hero_disruptor"
                hero = "Disruptor"
            Case hero Like "npc_dota_hero_luna"
                hero = "Luna"
            Case hero Like "npc_dota_hero_rubick"
                hero = "Rubick"
            Case hero Like "npc_dota_hero_naga_siren"
                hero = "Naga Siren"
            Case hero Like "npc_dota_hero_visage"
                hero = "Visage"
            Case hero Like "npc_dota_hero_centaur"
                hero = "Centaur Warrunner"
            Case hero Like "npc_dota_hero_troll_warlord"
                hero = "Troll Warlord"
            Case hero Like "npc_dota_hero_magnataur"
                hero = "Magnus"
            Case hero Like "npc_dota_hero_slark"
                hero = "Slark"
            Case hero Like "npc_dota_hero_shredder"
                hero = "Timbersaw"
            Case hero Like "npc_dota_hero_medusa"
                hero = "Medusa"
            Case hero Like "npc_dota_hero_tusk"
                hero = "Tusk"
            Case hero Like "npc_dota_hero_abaddon"
                hero = "Abaddon"
            Case hero Like "npc_dota_hero_bristleback"
                hero = "Bristleback"
            Case hero Like "npc_dota_hero_elder_titan"
                hero = "Elder Titan"
            Case hero Like "npc_dota_hero_ember_spirit"
                hero = "Ember Spirit"
            Case hero Like "npc_dota_hero_earth_spirit"
                hero = "Earth Spirit"
            Case hero Like "npc_dota_hero_legion_commander"
                hero = "Legion Commander"
            Case hero Like "npc_dota_hero_skywrath_mage"
                hero = "Skywrath Mage"
            Case hero Like "npc_dota_hero_phoenix"
                hero = "Phoenix"
            Case hero Like "npc_dota_hero_terrorblade"
                hero = "Terrorblade"
            Case hero Like "npc_dota_hero_techies"
                hero = "Techies"
            Case hero Like "npc_dota_hero_winter_wyvern"
                hero = "Winter Wyvern"
                ' FEHLENDE HEROS BTW. FEHLENDE ITEMDATEIEN
            Case hero Like "npc_dota_hero_abyssal_underlord"
                hero = "Abyssal Underlord"
            Case Else
                hero = "Unknown hero!"
        End Select
        Return hero
    End Function

    'Return the hero name as string which is written in the itembuild file
    Public Function CheckHero(ByVal hero As String) As String
        Select Case hero
            Case "Ancient Apparition"
                Selected_Hero = "ancient_apparition"
            Case "Anti-Mage"
                Selected_Hero = "antimage"
            Case "Bounty Hunter"
                Selected_Hero = "bounty_hunter"
            Case "Centaur Warrunner"
                Selected_Hero = "centaur"
            Case "Chaos Knight"
                Selected_Hero = "chaos_knight"
            Case "Clockwerk"
                Selected_Hero = "rattletrap"
            Case "Crystal Maiden"
                Selected_Hero = "crystal_maiden"
            Case "Dark Seer"
                Selected_Hero = "dark_seer"
            Case "Death Prophet"
                Selected_Hero = "death_prophet"
            Case "Doom"
                Selected_Hero = "doom_bringer"
            Case "Dragon Knight"
                Selected_Hero = "dragon_knight"
            Case "Drow Ranger"
                Selected_Hero = "drow_ranger"
            Case "Earth Spirit"
                Selected_Hero = "earth_spirit"
            Case "Elder Titan"
                Selected_Hero = "elder_titan"
            Case "Ember Spirit"
                Selected_Hero = "ember_spirit"
            Case "Faceless Void"
                Selected_Hero = "faceless_void"
            Case "Io"
                Selected_Hero = "wisp"
            Case "Keeper of the Light"
                Selected_Hero = "keeper_of_the_light"
            Case "Legion Commander"
                Selected_Hero = "legion_commander"
            Case "Lifestealer"
                Selected_Hero = "life_stealer"
            Case "Lone Druid"
                Selected_Hero = "lone_druid"
            Case "Magnus"
                Selected_Hero = "magnataur"
            Case "Naga Siren"
                Selected_Hero = "naga_siren"
            Case "Nature's Prophet"
                Selected_Hero = "furion"
            Case "Necrophos"
                Selected_Hero = "necrolyte"
            Case "Night Stalker"
                Selected_Hero = "night_stalker"
            Case "Nyx Assassin"
                Selected_Hero = "nyx_assassin"
            Case "Ogre Magi"
                Selected_Hero = "ogre_magi"
            Case "Outworld Devourer"
                Selected_Hero = "obsidian_destroyer"
            Case "Phantom Assassin"
                Selected_Hero = "phantom_assassin"
            Case "Phantom Lancer"
                Selected_Hero = "phantom_lancer"
            Case "Queen of Pain"
                Selected_Hero = "queenofpain"
            Case "Sand King"
                Selected_Hero = "sand_king"
            Case "Shadow Demon"
                Selected_Hero = "shadow_demon"
            Case "Shadow Fiend"
                Selected_Hero = "nevermore"
            Case "Shadow Shaman"
                Selected_Hero = "shadow_shaman"
            Case "Skeleton King"
                Selected_Hero = "skeleton_king"
            Case "Skywrath Mage"
                Selected_Hero = "skywrath_mage"
            Case "Spirit Breaker"
                Selected_Hero = "spirit_breaker"
            Case "Storm Spirit"
                Selected_Hero = "storm_spirit"
            Case "Techies"
                Selected_Hero = "techies"
            Case "Templar Assassin"
                Selected_Hero = "templar_assassin"
            Case "Timbersaw"
                Selected_Hero = "shredder"
            Case "Treant Protector"
                Selected_Hero = "treant"
            Case "Troll Warlord"
                Selected_Hero = "troll_warlord"
            Case "Vengeful Spirit"
                Selected_Hero = "vengefulspirit"
            Case "Windranger"
                Selected_Hero = "windrunner"
            Case "Winter Wyvern"
                Selected_Hero = "winter_wyvern"
            Case "Witch Doctor"
                Selected_Hero = "witch_doctor"
            Case "Zeus"
                Selected_Hero = "zuus"
                ' FEHLENDE HEROS BTW. FEHLENDE ITEMDATEIEN
            Case "Abyssal Underlord"
                Selected_Hero = "abyssal_underlord"
            Case Else
                Selected_Hero = hero
        End Select
        Return Selected_Hero
    End Function

    'Change the list of heros to a selection like all carrys or all agi heros
    Public Sub ChangeHeroList()
        With FormMain.ListBox1
            'Clear Listbox
            .SelectedItems.Clear()
            For i = .Items.Count - 1 To 0 Step -1
                .Items.Remove(.Items(i).ToString)
            Next

            .Items.Add("Abaddon")
            .Items.Add("Abyssal Underlord")
            .Items.Add("Alchemist")
            .Items.Add("Ancient Apparition")
            .Items.Add("Anti-Mage")
            .Items.Add("Arc Warden")
            .Items.Add("Axe")
            .Items.Add("Bane")
            .Items.Add("Batrider")
            .Items.Add("Beastmaster")
            .Items.Add("Bloodseeker")
            .Items.Add("Bounty Hunter")
            .Items.Add("Brewmaster")
            .Items.Add("Bristleback")
            .Items.Add("Broodmother")
            .Items.Add("Centaur Warrunner")
            .Items.Add("Chaos Knight")
            .Items.Add("Chen")
            .Items.Add("Clinkz")
            .Items.Add("Clockwerk")
            .Items.Add("Crystal Maiden")
            .Items.Add("Dark Seer")
            .Items.Add("Dazzle")
            .Items.Add("Death Prophet")
            .Items.Add("Disruptor")
            .Items.Add("Doom")
            .Items.Add("Dragon Knight")
            .Items.Add("Drow Ranger")
            .Items.Add("Earth Spirit")
            .Items.Add("Earthshaker")
            .Items.Add("Elder Titan")
            .Items.Add("Ember Spirit")
            .Items.Add("Enchantress")
            .Items.Add("Enigma")
            .Items.Add("Faceless Void")
            .Items.Add("Gyrocopter")
            .Items.Add("Huskar")
            .Items.Add("Invoker")
            .Items.Add("Io")
            .Items.Add("Jakiro")
            .Items.Add("Juggernaut")
            .Items.Add("Keeper of the Light")
            .Items.Add("Kunkka")
            .Items.Add("Legion Commander")
            .Items.Add("Leshrac")
            .Items.Add("Lich")
            .Items.Add("Lifestealer")
            .Items.Add("Lina")
            .Items.Add("Lion")
            .Items.Add("Lone Druid")
            .Items.Add("Luna")
            .Items.Add("Lycan")
            .Items.Add("Magnus")
            .Items.Add("Medusa")
            .Items.Add("Meepo")
            .Items.Add("Mirana")
            .Items.Add("Morphling")
            .Items.Add("Naga Siren")
            .Items.Add("Nature's Prophet")
            .Items.Add("Necrophos")
            .Items.Add("Night Stalker")
            .Items.Add("Nyx Assassin")
            .Items.Add("Ogre Magi")
            .Items.Add("Omniknight")
            .Items.Add("Oracle")
            .Items.Add("Outworld Devourer")
            .Items.Add("Phantom Assassin")
            .Items.Add("Phantom Lancer")
            .Items.Add("Phoenix")
            .Items.Add("Puck")
            .Items.Add("Pudge")
            .Items.Add("Pugna")
            .Items.Add("Queen of Pain")
            .Items.Add("Razor")
            .Items.Add("Riki")
            .Items.Add("Rubick")
            .Items.Add("Sand King")
            .Items.Add("Shadow Demon")
            .Items.Add("Shadow Fiend")
            .Items.Add("Shadow Shaman")
            .Items.Add("Silencer")
            .Items.Add("Skeleton King")
            .Items.Add("Skywrath Mage")
            .Items.Add("Slardar")
            .Items.Add("Slark")
            .Items.Add("Sniper")
            .Items.Add("Spectre")
            .Items.Add("Spirit Breaker")
            .Items.Add("Storm Spirit")
            .Items.Add("Sven")
            .Items.Add("Techies")
            .Items.Add("Templar Assassin")
            .Items.Add("Terrorblade")
            .Items.Add("Tidehunter")
            .Items.Add("Timbersaw")
            .Items.Add("Tinker")
            .Items.Add("Tiny")
            .Items.Add("Treant Protector")
            .Items.Add("Troll Warlord")
            .Items.Add("Tusk")
            .Items.Add("Undying")
            .Items.Add("Ursa")
            .Items.Add("Vengeful Spirit")
            .Items.Add("Venomancer")
            .Items.Add("Viper")
            .Items.Add("Visage")
            .Items.Add("Warlock")
            .Items.Add("Weaver")
            .Items.Add("Windranger")
            .Items.Add("Winter Wyvern")
            .Items.Add("Witch Doctor")
            .Items.Add("Zeus")
        End With
    End Sub

    'Delete all heros which are without an itembuild by valve
    Public Sub ClearNotImplemented()
        With FormMain.ListBox1
            .Items.Remove("Abyssal Underlord")
            .Items.Remove("Arc Warden")
        End With
    End Sub

    'Return the tooltip of each item
    Public Function GetToolTip(ByVal item_name As String) As String
        Dim tooltip As String
        Select Case item_name
            Case "Blink Dagger"
                tooltip = "Blink Dagger" + vbNewLine + vbNewLine + "Blink"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Blades of Attack"
                tooltip = "Blades of Attack" + vbNewLine + vbNewLine + "+9 Damage"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Aghanim's Scepter"
                tooltip = "Aghanim's Scepter" + vbNewLine + vbNewLine + "+10 All Attributes" + vbNewLine + "+200 HP" + vbNewLine + "+150 Mana" + vbNewLine + "Ultimate Upgrade (passive)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Animal Courier"
                tooltip = "Animal Courier" + vbNewLine + vbNewLine + "Summon Animal Courier"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Arcane Boots"
                tooltip = "Arcane Boots" + vbNewLine + vbNewLine + "+55 Movement Speed " + vbNewLine + "+250 Mana" + vbNewLine + "Replenish Mana (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Armlet"
                tooltip = "Armlet" + vbNewLine + vbNewLine + "+9 Damage" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+5 Armor" + vbNewLine + "+5 HP/sec Regeneration" + vbNewLine + "Unholy Strength (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Assault Cuirass"
                tooltip = "Assault Cuirass" + vbNewLine + vbNewLine + "+10 Armor" + vbNewLine + "+35 Attack Speed" + vbNewLine + "Positive Armor (Aura)" + vbNewLine + "Negative Armor (Aura)" + vbNewLine + "Attack Speed (Aura)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Battle Fury"
                tooltip = "Battle Fury" + vbNewLine + vbNewLine + "+65 Damage" + vbNewLine + "+6 HP/sec Regeneration" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "Cleave"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Belt of Strength"
                tooltip = "Belt of Strength" + vbNewLine + vbNewLine + "+6 Strength"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Black King Bar"
                tooltip = "Black King Bar" + vbNewLine + vbNewLine + "+10 Strength" + vbNewLine + "+24 Damage" + vbNewLine + "Avatar (active)"""
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Blade Mail"
                tooltip = "Blade Mail" + vbNewLine + vbNewLine + "+22 Damage" + vbNewLine + "+5 Armor" + vbNewLine + "+10 Intelligence" + vbNewLine + "Damage Return (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Blade of Alacrity"
                tooltip = "Blade of Alacrity" + vbNewLine + vbNewLine + "+10 Agility"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Bloodstone"
                tooltip = "Bloodstone" + vbNewLine + vbNewLine + "+500 HP" + vbNewLine + "+400 Mana" + vbNewLine + "+8 HP/sec Regeneration" + vbNewLine + "+200% Mana Regeneration" + vbNewLine + "+10 Damage" + vbNewLine + "Bloodpact" + vbNewLine + "5 Charges"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Band of Elvenskin"
                tooltip = "Band of Elvenskin" + vbNewLine + vbNewLine + "+6 Agility"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Boots of Speed"
                tooltip = "Boots of Speed" + vbNewLine + vbNewLine + "+55 Movement Speed"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Boots of Travel"
                tooltip = "Boots of Travel" + vbNewLine + vbNewLine + "+95 Movement Speed" + vbNewLine + "Teleport (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Bottle"
                tooltip = "Bottle" + vbNewLine + vbNewLine + "Regenerate" + vbNewLine + "Rune Capture"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Bracer"
                tooltip = "Bracer" + vbNewLine + vbNewLine + "+3 Damage" + vbNewLine + "+6 Strength" + vbNewLine + "+3 Agility" + vbNewLine + "+3 Intelligence"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Broadsword"
                tooltip = "Broadsword" + vbNewLine + vbNewLine + "+18 Damage"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Buckler"
                tooltip = "Buckler" + vbNewLine + vbNewLine + "+5 Armor" + vbNewLine + "+2 All Attributes" + vbNewLine + "Armor Bonus (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Butterfly"
                tooltip = "Butterfly" + vbNewLine + vbNewLine + "+30 Agility" + vbNewLine + "+30 Damage" + vbNewLine + "30% Evasion" + vbNewLine + "+30 Attack Speed"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Chainmail"
                tooltip = "Chainmail" + vbNewLine + vbNewLine + "+5 Armor"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Circlet"
                tooltip = "Circlet" + vbNewLine + vbNewLine + "+2 All Attributes"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Clarity"
                tooltip = "Clarity" + vbNewLine + vbNewLine + "Regenerate Mana" + vbNewLine + "1 Charges"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Claymore"
                tooltip = "Claymore" + vbNewLine + vbNewLine + "+21 Damage"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Cloak"
                tooltip = "Cloak" + vbNewLine + vbNewLine + "+15% Magic Resistance"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Crystalys"
                tooltip = "Crystalys" + vbNewLine + vbNewLine + "+35 Damage" + vbNewLine + "Critical Strike"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Daedalus"
                tooltip = "Daedalus" + vbNewLine + vbNewLine + "+81 Damage" + vbNewLine + "Critical Strike"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Dagon 1"
                tooltip = "Dagon 1" + vbNewLine + vbNewLine + "+13 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Dagon 2"
                tooltip = "Dagon 2" + vbNewLine + vbNewLine + "+15 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Dagon 3"
                tooltip = "Dagon 3" + vbNewLine + vbNewLine + "+17 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Dagon 4"
                tooltip = "Dagon 4" + vbNewLine + vbNewLine + "+19 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Dagon 5"
                tooltip = "Dagon 5" + vbNewLine + vbNewLine + "+21 Intelligence" + vbNewLine + "+3 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Energy Burst (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Demon Edge"
                tooltip = "Demon Edge" + vbNewLine + vbNewLine + "+46 Damage"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Desolator"
                tooltip = "Desolator" + vbNewLine + vbNewLine + "+60 Damage" + vbNewLine + "Corruption"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Diffusal Blade 1"
                tooltip = "Diffusal Blade 1" + vbNewLine + vbNewLine + "+22 Agility" + vbNewLine + "+6 Intelligence" + vbNewLine + "Feedback" + vbNewLine + "Purge (active)" + vbNewLine + "8 Charges"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Diffusal Blade 2"
                tooltip = "Diffusal Blade 2" + vbNewLine + vbNewLine + "+26 Agility" + vbNewLine + "+10 Intelligence" + vbNewLine + "Feedback" + vbNewLine + "Purge (active)" + vbNewLine + "8 Charges"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Divine Rapier"
                tooltip = "Divine Rapier" + vbNewLine + vbNewLine + "+250 Damage"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Drum of Endurance"
                tooltip = "Drum of Endurance" + vbNewLine + vbNewLine + "+9 All Attributes" + vbNewLine + "+9 Damage" + vbNewLine + "Endurance Aura" + vbNewLine + "Endurance (active)" + vbNewLine + "4 Charges"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Dust of Appearance"
                tooltip = "Dust of Appearance" + vbNewLine + vbNewLine + "Reveal" + vbNewLine + "2 Charges"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Eaglesong"
                tooltip = "Eaglesong" + vbNewLine + vbNewLine + "+25 Agility"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Energy Booster"
                tooltip = "Energy Booster" + vbNewLine + vbNewLine + "+250 Mana"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Ethereal Blade"
                tooltip = "Ethereal Blade" + vbNewLine + vbNewLine + "+40 Agility" + vbNewLine + "+10 Strength" + vbNewLine + "+10 Intelligence" + vbNewLine + "Ether Blast (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Eul's Scepter of Divinity"
                tooltip = "Eul's Scepter of Divinity" + vbNewLine + vbNewLine + "+10 Intelligence" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "+40 Movement Speed" + vbNewLine + "Cyclone (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Eye of Skadi"
                tooltip = "Eye of Skadi" + vbNewLine + vbNewLine + "+25 All Attributes" + vbNewLine + "+200 HP" + vbNewLine + "+150 Mana" + vbNewLine + "Cold Attack"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Flying Courier"
                tooltip = "Flying Courier" + vbNewLine + vbNewLine + "Summon Flying Courier"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Force Staff"
                tooltip = "Force Staff" + vbNewLine + vbNewLine + "+10 Intelligence" + vbNewLine + "+10 Damage" + vbNewLine + "+10 Attack Speed" + vbNewLine + "Force (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Gauntlets of Strength"
                tooltip = "Gauntlets of Strength" + vbNewLine + vbNewLine + "+3 Strength"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Gem of True Sight"
                tooltip = "Gem of True Sight" + vbNewLine + vbNewLine + "True Sight"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Ghost Scepter"
                tooltip = "Ghost Scepter" + vbNewLine + vbNewLine + "+7 All Attributes" + vbNewLine + "Ghost Form (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Gloves of Haste"
                tooltip = "Gloves of Haste" + vbNewLine + vbNewLine + "+15 Attack Speed"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Hand of Midas"
                tooltip = "Hand of Midas" + vbNewLine + vbNewLine + "+30 Attack Speed" + vbNewLine + "Transmute (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Headdress"
                tooltip = "Headdress" + vbNewLine + vbNewLine + "+2 All Attributes" + vbNewLine + "Regeneration Aura"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Healing Salve"
                tooltip = "Healing Salve" + vbNewLine + vbNewLine + "Regenerate Health" + vbNewLine + "1 Charges"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Heart of Tarrasque"
                tooltip = "Heart of Tarrasque" + vbNewLine + vbNewLine + "+40 Strength" + vbNewLine + "+300 HP" + vbNewLine + "Health Regeneration"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Helm of Iron Will"
                tooltip = "Helm of Iron Will" + vbNewLine + vbNewLine + "+5 Armor" + vbNewLine + "+3 HP/sec Regeneration"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Helm of the Dominator"
                tooltip = "Helm of the Dominator" + vbNewLine + vbNewLine + "+20 Damage" + vbNewLine + "+5 Armor" + vbNewLine + "+15% Lifesteal" + vbNewLine + "Dominate (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Hood of Defiance"
                tooltip = "Hood of Defiance" + vbNewLine + vbNewLine + "+30% Magic Resistance" + vbNewLine + "+8 HP/sec Regeneration"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Hyperstone"
                tooltip = "Hyperstone" + vbNewLine + vbNewLine + "+55 Attack Speed"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Iron Branch"
                tooltip = "Iron Branch" + vbNewLine + vbNewLine + "+1 All Attributes"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Javelin"
                tooltip = "Javelin" + vbNewLine + vbNewLine + "+21 Damage" + vbNewLine + "20% chance to deal 40 bonus damage"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Linken's Sphere"
                tooltip = "Linken's Sphere" + vbNewLine + vbNewLine + "+15 All Attributes" + vbNewLine + "+6 HP/sec Regeneration" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "Spell Block"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Maelstrom"
                tooltip = "Maelstrom" + vbNewLine + vbNewLine + "+24 Damage" + vbNewLine + "+25 Attack Speed" + vbNewLine + "Chain Lightning"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Magic Stick"
                tooltip = "Magic Stick" + vbNewLine + vbNewLine + "Energy Charge (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Magic Wand"
                tooltip = "Magic Wand" + vbNewLine + vbNewLine + "+3 All Attributes" + vbNewLine + "Energy Charge (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Manta Style"
                tooltip = "Manta Style" + vbNewLine + vbNewLine + "+26 Agility" + vbNewLine + "+10 Strength" + vbNewLine + "+10 Intelligence" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+10% Movement Speed" + vbNewLine + "Mirror Image (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Mantle of Intelligence"
                tooltip = "Mantle of Intelligence" + vbNewLine + vbNewLine + "+3 Intelligence"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Mask of Madness"
                tooltip = "Mask of Madness" + vbNewLine + vbNewLine + "+17% Lifesteal" + vbNewLine + "Berserk (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Medallion of Courage"
                tooltip = "Medallion of Courage" + vbNewLine + vbNewLine + "+6 Armor" + vbNewLine + "+50% Mana Regeneration" + vbNewLine + "Valor (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Mekansm"
                tooltip = "Mekansm" + vbNewLine + vbNewLine + "+5 All Attributes" + vbNewLine + "+5 Armor" + vbNewLine + "Mekansm Aura" + vbNewLine + "Restore (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Mithril Hammer"
                tooltip = "Mithril Hammer" + vbNewLine + vbNewLine + "+24 Damage"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Mjollnir"
                tooltip = "Mjollnir" + vbNewLine + vbNewLine + "+80 Attack Speed" + vbNewLine + "+24 Damage" + vbNewLine + "Chain Lightning" + vbNewLine + "Static Charge (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Monkey King Bar"
                tooltip = "Monkey King Bar" + vbNewLine + vbNewLine + "+88 Damage" + vbNewLine + "+15 Attack Speed" + vbNewLine + "True Strike" + vbNewLine + "Mini-Bash"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Morbid Mask"
                tooltip = "Morbid Mask" + vbNewLine + vbNewLine + "+15% Lifesteal"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Mystic Staff"
                tooltip = "Mystic Staff" + vbNewLine + vbNewLine + "+25 Intelligence"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Necronomicon 1"
                tooltip = "Necronomicon 1" + vbNewLine + vbNewLine + "+15 Intelligence" + vbNewLine + "+8 Strength" + vbNewLine + "Demonic Summoning (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Necronomicon 2"
                tooltip = "Necronomicon 2" + vbNewLine + vbNewLine + "+21 Intelligence" + vbNewLine + "+12 Strength" + vbNewLine + "Demonic Summoning (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Necronomicon 3"
                tooltip = "Necronomicon 3" + vbNewLine + vbNewLine + "+24 Intelligence" + vbNewLine + "+16 Strength" + vbNewLine + "Demonic Summoning (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Null Talisman"
                tooltip = "Null Talisman" + vbNewLine + vbNewLine + "+3 Damage" + vbNewLine + "+6 Intelligence" + vbNewLine + "+3 Strength" + vbNewLine + "+3 Agility"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Oblivion Staff"
                tooltip = "Oblivion Staff" + vbNewLine + vbNewLine + "+6 Intelligence" + vbNewLine + "+10 Attack Speed" + vbNewLine + "+15 Damage" + vbNewLine + "+75% Mana Regeneration"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Observer Ward"
                tooltip = "Observer Ward" + vbNewLine + vbNewLine + "Place Ward" + vbNewLine + "1 Charges" + vbNewLine + "shares inventory slot with Sentry Ward"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Ogre Club"
                tooltip = "Ogre Club" + vbNewLine + vbNewLine + "+10 Strength"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Orb of Venom"
                tooltip = "Orb of Venom" + vbNewLine + vbNewLine + "Poison Attack"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Orchid Malevolence"
                tooltip = "Orchid Malevolence" + vbNewLine + vbNewLine + "+20 Intelligence" + vbNewLine + "+30 Attack Speed" + vbNewLine + "+45 Damage" + vbNewLine + "+225% Mana Regeneration" + vbNewLine + "Soul Burn (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Perseverance"
                tooltip = "Perseverance" + vbNewLine + vbNewLine + "+10 Damage" + vbNewLine + "+5 HP/sec Regeneration" + vbNewLine + "+125% Mana Regeneration"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Phase Boots"
                tooltip = "Phase Boots" + vbNewLine + vbNewLine + "+50 Movement Speed" + vbNewLine + "+24 damage" + vbNewLine + "Phase (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Pipe of Insight"
                tooltip = "Pipe of Insight" + vbNewLine + vbNewLine + "+11 HP/sec Regeneration" + vbNewLine + "+30% Magic Resistance" + vbNewLine + "Barrier (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Platemail"
                tooltip = "Platemail" + vbNewLine + vbNewLine + "+10 Armor"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Point Booster"
                tooltip = "Point Booster" + vbNewLine + vbNewLine + "+200 HP" + vbNewLine + "+150 Mana"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Poor Man's Shield"
                tooltip = "Poor Man's Shield" + vbNewLine + vbNewLine + "+6 Agility" + vbNewLine + "Damage Block"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Power Treads"
                tooltip = "Power Treads" + vbNewLine + vbNewLine + "+50 Move Speed" + vbNewLine + "+8 Selected Attribute" + vbNewLine + "+25 Attack Speed" + vbNewLine + "Switch Attribute (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Quarterstaff"
                tooltip = "Quarterstaff" + vbNewLine + vbNewLine + "+10 Damage" + vbNewLine + "+10 Attack Speed"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Quelling Blade"
                tooltip = "Quelling Blade" + vbNewLine + vbNewLine + "Demolish" + vbNewLine + "Tree Chop (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Radiance"
                tooltip = "Radiance" + vbNewLine + vbNewLine + "+60 Damage" + vbNewLine + "Burn Damage"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Reaver"
                tooltip = "Reaver" + vbNewLine + vbNewLine + "+25 Strength"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Refresher Orb"
                tooltip = "Refresher Orb" + vbNewLine + vbNewLine + "+5 HP/Sec Regeneration" + vbNewLine + "+10 Damage" + vbNewLine + "+200% Mana Regeneration" + vbNewLine + "+40 Damage" + vbNewLine + "Reset Cooldowns (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Ring of Basilius"
                tooltip = "Ring of Basilius" + vbNewLine + vbNewLine + "+6 Damage" + vbNewLine + "+1 Armor" + vbNewLine + "Mana Aura" + vbNewLine + "Armor Aura"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Ring of Health"
                tooltip = "Ring of Health" + vbNewLine + vbNewLine + "+5 HP/sec Regeneration"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Ring of Protection"
                tooltip = "Ring of Protection" + vbNewLine + vbNewLine + "+3 Armor"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Ring of Regen"
                tooltip = "Ring of Regen" + vbNewLine + vbNewLine + "+2 HP/sec Regeneration"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Robe of the Magi"
                tooltip = "Robe of the Magi" + vbNewLine + vbNewLine + "+6 Intelligence"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Sacred Relic"
                tooltip = "Sacred Relic" + vbNewLine + vbNewLine + "+60 Damage"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Sage's Mask"
                tooltip = "Sage's Mask" + vbNewLine + vbNewLine + "+50% Mana Regeneration"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Sange"
                tooltip = "Sange" + vbNewLine + vbNewLine + "+16 Strength" + vbNewLine + "+10 Damage" + vbNewLine + "Lesser Maim"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Sange and Yasha"
                tooltip = "Sange and Yasha" + vbNewLine + vbNewLine + "+16 Agility" + vbNewLine + "+16 Strength" + vbNewLine + "+12 Damage" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+16% Movement Speed" + vbNewLine + "Greater Maim"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Satanic"
                tooltip = "Satanic" + vbNewLine + vbNewLine + "+25 Strength" + vbNewLine + "+20 Damage" + vbNewLine + "+5 Armor" + vbNewLine + "+25% Lifesteal" + vbNewLine + "Unholy Rage (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Scythe of Vyse"
                tooltip = "Scythe of Vyse" + vbNewLine + vbNewLine + "+35 Intelligence" + vbNewLine + "+10 Strength" + vbNewLine + "+10 Agility" + vbNewLine + "+150% Mana Regeneration" + vbNewLine + "Hex (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Sentry Ward"
                tooltip = "Sentry Ward" + vbNewLine + vbNewLine + "Place Ward" + vbNewLine + "950 Radius True Sight " + vbNewLine + "1 Charges" + vbNewLine + "shares inventory slot with Observer Ward"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Shadow Blade"
                tooltip = "Shadow Blade" + vbNewLine + vbNewLine + "+38 Damage" + vbNewLine + "+10 Attack Speed" + vbNewLine + "Shadow Walk (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Shiva's Guard"
                tooltip = "Shiva's Guard" + vbNewLine + vbNewLine + "+30 Intelligence" + vbNewLine + "+15 Armor" + vbNewLine + "Freezing Aura" + vbNewLine + "Arctic Blast (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Skull Basher"
                tooltip = "Skull Basher" + vbNewLine + vbNewLine + "+40 Damage" + vbNewLine + "+6 Strength" + vbNewLine + "Bash"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Slippers of Agility"
                tooltip = "Slippers of Agility" + vbNewLine + vbNewLine + "+3 Agility"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Smoke of Deceit"
                tooltip = "Smoke of Deceit" + vbNewLine + vbNewLine + "Smoke of Deceit (active)" + vbNewLine + "1 Charges"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Soul Booster"
                tooltip = "Soul Booster" + vbNewLine + vbNewLine + "+450 HP" + vbNewLine + "+400 Mana" + vbNewLine + "+4 HP/sec Regeneration" + vbNewLine + "+100% Mana Regeneration"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Soul Ring"
                tooltip = "Soul Ring" + vbNewLine + vbNewLine + "+3 HP/sec Regeneration" + vbNewLine + "+50% Mana Regeneration" + vbNewLine + "Sacrifice (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Staff of Wizardry"
                tooltip = "Staff of Wizardry" + vbNewLine + vbNewLine + "+10 Intelligence"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Stout Shield"
                tooltip = "Stout Shield" + vbNewLine + vbNewLine + "Damage Block"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Talisman of Evasion"
                tooltip = "Talisman of Evasion" + vbNewLine + vbNewLine + "+25% Evasion"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Tango"
                tooltip = "Tango" + vbNewLine + vbNewLine + "Eat Tree" + vbNewLine + "4 Charges"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Town Portal Scroll"
                tooltip = "Town Portal Scroll" + vbNewLine + vbNewLine + "Teleport" + vbNewLine + "1 Charges"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Ultimate Orb"
                tooltip = "Ultimate Orb" + vbNewLine + vbNewLine + "+10 All Attributes"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Urn of Shadows"
                tooltip = "Urn of Shadows" + vbNewLine + vbNewLine + "+50% Mana Regeneration" + vbNewLine + "+6 Strength" + vbNewLine + "Soul Release (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Vanguard"
                tooltip = "Vanguard" + vbNewLine + vbNewLine + "+6 HP/sec regeneration" + vbNewLine + "+275 HP" + vbNewLine + "Damage Block"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Veil of Discord"
                tooltip = "Veil of Discord" + vbNewLine + vbNewLine + "+5 Armor" + vbNewLine + "+5 HP/sec Regeneration" + vbNewLine + "+6 Intelligence" + vbNewLine + "+3 Strength" + vbNewLine + "+3 Agility" + vbNewLine + "+3 Damage" + vbNewLine + "Discord (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Vitality Booster"
                tooltip = "Vitality Booster" + vbNewLine + vbNewLine + "+250 HP"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Vladmir's Offering"
                tooltip = "Vladmir's Offering" + vbNewLine + vbNewLine + "+2 HP/sec Regeneration" + vbNewLine + "Vampiric Aura" + vbNewLine + "Damage Aura" + vbNewLine + "Armor Aura" + vbNewLine + "Mana Regeneration Aura"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Void Stone"
                tooltip = "Void Stone" + vbNewLine + vbNewLine + "+100% Mana Regeneration"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Wraith Band"
                tooltip = "Wraith Band" + vbNewLine + vbNewLine + "+3 Damage" + vbNewLine + "+6 Agility" + vbNewLine + "+3 Strength" + vbNewLine + "+3 Intelligence"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Yasha"
                tooltip = "Yasha" + vbNewLine + vbNewLine + "+16 Agility" + vbNewLine + "+15 Attack Speed" + vbNewLine + "+10% Movement Speed"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Abyssal Blade"
                tooltip = "Abyssal Blade" + vbNewLine + vbNewLine + "+100 Damage" + vbNewLine + "+10 Strength" + vbNewLine + "Bash" + vbNewLine + "Overwhelm (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Heaven's Halberd"
                tooltip = "Heaven's Halberd" + vbNewLine + vbNewLine + "+25 Damage" + vbNewLine + "+20 Strength" + vbNewLine + "+25 Evasion" + vbNewLine + "Lesser Maim" + vbNewLine + "Disarm (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Ring of Aquila"
                tooltip = "Ring of Aquila" + vbNewLine + vbNewLine + "+9 Damage" + vbNewLine + "+3 All Stats" + vbNewLine + "+3 Agility" + vbNewLine + "+1 Armor" + vbNewLine + "Armor Aura" + vbNewLine + "Mana Aura"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Rod of Atos"
                tooltip = "Rod of Atos" + vbNewLine + vbNewLine + "+25 Intelligence" + vbNewLine + "+250 HP" + vbNewLine + "Cripple (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Tranquil Boots"
                tooltip = "Tranquil Boots" + vbNewLine + vbNewLine + "(active)" + vbNewLine + "+85 Movement Speed" + vbNewLine + "+4 Armor" + vbNewLine + "+10 HP/sec Regeneration" + vbNewLine + vbNewLine + "(broken)" + vbNewLine + "+60 Movement Speed" + vbNewLine + "+4 Armor"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case "Shadow Amulet"
                tooltip = "Shadow Amulet" + vbNewLine + vbNewLine + "+30 Attack Speed" + vbNewLine + "Fade (active)"
                Return tooltip + vbNewLine + "Price: " + GetPrice(item_name).ToString
            Case Else
                Return item_name + vbNewLine + vbNewLine + "Price: " + GetPrice(item_name).ToString
        End Select
    End Function

    'Return the price of each item
    Public Function GetPrice(ByVal itemname As String) As Integer
        Select Case itemname
            'Items (abc-sorted)
            Case "Abyssal Blade"
                Return 6750
            Case "Aghanim's Scepter"
                Return 4200
            Case "Animal Courier"
                Return 120
            Case "Arcane Boots"
                Return 1350
            Case "Armlet"
                Return 2370
            Case "Assault Cuirass"
                Return 5250
            Case "Band of Elvenskin"
                Return 450
            Case "Battle Fury"
                Return 4575
            Case "Belt of Strength"
                Return 450
            Case "Black King Bar"
                Return 3975
            Case "Blade Mail"
                Return 2200
            Case "Blade of Alacrity"
                Return 1000
            Case "Blades of Attack"
                Return 420
            Case "Blink Dagger"
                Return 2250
            Case "Bloodstone"
                Return 4900
            Case "Boots of Speed"
                Return 450
            Case "Boots of Travel"
                Return 2450
            Case "Boots of Travel 2"
                Return 4450
            Case "Bottle"
                Return 700
            Case "Bracer"
                Return 525
            Case "Broadsword"
                Return 1200
            Case "Buckler"
                Return 800
            Case "Butterfly"
                Return 5875
            Case "Chainmail"
                Return 550
            Case "Circlet"
                Return 165
            Case "Clarity"
                Return 50
            Case "Claymore"
                Return 1400
            Case "Cloak"
                Return 550
            Case "Crimson Guard"
                Return 3800
            Case "Crystalys"
                Return 2120
            Case "Daedalus"
                Return 5520
            Case "Dagon 1"
                Return 2720
            Case "Dagon 2"
                Return 2720 + 1250
            Case "Dagon 3"
                Return 2720 + 1250 + 1250
            Case "Dagon 4"
                Return 2720 + 1250 + 1250 + 1250
            Case "Dagon 5"
                Return 2720 + 1250 + 1250 + 1250 + 1250
            Case "Demon Edge"
                Return 2400
            Case "Desolator"
                Return 3500
            Case "Diffusal Blade 1"
                Return 3150
            Case "Diffusal Blade 2"
                Return 3150 + 700
            Case "Divine Rapier"
                Return 6200
            Case "Drum of Endurance"
                Return 1850
            Case "Dust of Appearance"
                Return 180
            Case "Eaglesong"
                Return 3200
            Case "Energy Booster"
                Return 900
            Case "Ethereal Blade"
                Return 4700
            Case "Eul's Scepter of Divinity"
                Return 2850
            Case "Eye of Skadi"
                Return 5675
            Case "Flying Courier"
                Return 220
            Case "Force Staff"
                Return 2250
            Case "Gauntlets of Strength"
                Return 150
            Case "Gem of True Sight"
                Return 900
            Case "Ghost Scepter"
                Return 1500
            Case "Glimmer Cape"
                Return 1950
            Case "Gloves of Haste"
                Return 500
            Case "Guardian Greaves"
                Return 5300
            Case "Hand of Midas"
                Return 2050
            Case "Headdress"
                Return 600
            Case "Healing Salve"
                Return 110
            Case "Heart of Tarrasque"
                Return 5500
            Case "Heaven's Halberd"
                Return 3850
            Case "Helm of Iron Will"
                Return 950
            Case "Helm of the Dominator"
                Return 1850
            Case "Hood of Defiance"
                Return 2125
            Case "Hyperstone"
                Return 2000
            Case "Iron Branch"
                Return 50
            Case "Javelin"
                Return 1500
            Case "Linken's Sphere"
                Return 5175
            Case "Lotus Orb"
                Return 4050
            Case "Maelstrom"
                Return 2800
            Case "Magic Stick"
                Return 200
            Case "Magic Wand"
                Return 465
            Case "Mango"
                Return 150
            Case "Manta Style"
                Return 4950
            Case "Mantle of Intelligence"
                Return 150
            Case "Mask of Madness"
                Return 1800
            Case "Medallion of Courage"
                Return 1200
            Case "Mekansm"
                Return 2300
            Case "Mithril Hammer"
                Return 1600
            Case "Mjollnir"
                Return 5700
            Case "Monkey King Bar"
                Return 5400
            Case "Moon Shard"
                Return 4300
            Case "Morbid Mask"
                Return 900
            Case "Mystic Staff"
                Return 2700
            Case "Necronomicon 1"
                Return 2700
            Case "Necronomicon 2"
                Return 2700 + 1250
            Case "Necronomicon 3"
                Return 2700 + 1250 + 1250
            Case "Null Talisman"
                Return 470
            Case "Oblivion Staff"
                Return 1650
            Case "Observer Ward"
                Return 75
            Case "Octarine Core"
                Return 5900
            Case "Ogre Club"
                Return 1000
            Case "Orb of Venom"
                Return 275
            Case "Orchid Malevolence"
                Return 4075
            Case "Perseverance"
                Return 1750
            Case "Phase Boots"
                Return 1290
            Case "Pipe of Insight"
                Return 3525
            Case "Platemail"
                Return 1400
            Case "Point Booster"
                Return 1200
            Case "Poor Man's Shield"
                Return 500
            Case "Power Treads"
                Return 1400
            Case "Quarterstaff"
                Return 875
            Case "Quelling Blade"
                Return 225
            Case "Radiance"
                Return 5225
            Case "Reaver"
                Return 3000
            Case "Refresher Orb"
                Return 5300
            Case "Ring of Aquila"
                Return 1010
            Case "Ring of Basilius"
                Return 525
            Case "Ring of Health"
                Return 875
            Case "Ring of Protection"
                Return 200
            Case "Ring of Regen"
                Return 350
            Case "Robe of the Magi"
                Return 450
            Case "Rod of Atos"
                Return 3100
            Case "Sacred Relic"
                Return 3800
            Case "Sage's Mask"
                Return 325
            Case "Sange"
                Return 2050
            Case "Sange and Yasha"
                Return 4100
            Case "Satanic"
                Return 5950
            Case "Scythe of Vyse"
                Return 5675
            Case "Sentry Ward"
                Return 200
            Case "Shadow Amulet"
                Return 1400
            Case "Shadow Blade"
                Return 2800
            Case "Shiva's Guard"
                Return 4700
            Case "Silver Edge"
                Return 5200
            Case "Skull Basher"
                Return 2950
            Case "Slippers of Agility"
                Return 150
            Case "Smoke of Deceit"
                Return 100
            Case "Solar Crest"
                Return 3000
            Case "Soul Booster"
                Return 3200
            Case "Soul Ring"
                Return 800
            Case "Staff of Wizardry"
                Return 1000
            Case "Stout Shield"
                Return 200
            Case "Talisman of Evasion"
                Return 1800
            Case "Tango"
                Return 125
            Case "Town Portal Scroll"
                Return 100
            Case "Tranquil Boots"
                Return 1000
            Case "Ultimate Orb"
                Return 2100
            Case "Urn of Shadows"
                Return 875
            Case "Vanguard"
                Return 2175
            Case "Veil of Discord"
                Return 2520
            Case "Vitality Booster"
                Return 1100
            Case "Vladmir's Offering"
                Return 2325
            Case "Void Stone"
                Return 875
            Case "Wraith Band"
                Return 485
            Case "Yasha"
                Return 2050
                'Recipe (abc-sorted)
            Case "Armlet (Recipe)"
                Return 700
            Case "Assault Cuirass (Recipe)"
                Return 1300
            Case "Black King Bar (Recipe)"
                Return 1375
            Case "Boots of Travel (Recipe)"
                Return 2000
            Case "Bracer (Recipe)"
                Return 190
            Case "Buckler (Recipe)"
                Return 200
            Case "Crystalys (Recipe)"
                Return 500
            Case "Daedalus (Recipe)"
                Return 1000
            Case "Dagon (Recipe)"
                Return 1250
            Case "Desolator (Recipe)"
                Return 900
            Case "Diffusal Blade (Recipe)"
                Return 850
            Case "Drum of Endurance (Recipe)"
                Return 875
            Case "Eul's Scepter of Divinity (Recipe)"
                Return 500
            Case "Force Staff (Recipe)"
                Return 900
            Case "Hand of Midas (Recipe)"
                Return 1550
            Case "Headdress (Recipe)"
                Return 200
            Case "Heart of Tarrasque (Recipe)"
                Return 1200
            Case "Linken's Sphere (Recipe)"
                Return 1325
            Case "Maelstrom (Recipe)"
                Return 600
            Case "Magic Wand (Recipe)"
                Return 150
            Case "Manta Style (Recipe)"
                Return 900
            Case "Mask of Madness (Recipe)"
                Return 1000
            Case "Medallion of Courage (Recipe)"
                Return 200
            Case "Mekansm (Recipe)"
                Return 900
            Case "Mjollnir (Recipe)"
                Return 900
            Case "Necronomicon (Recipe)"
                Return 1250
            Case "Null Talisman (Recipe)"
                Return 135
            Case "Orchid Malevolence (Recipe)"
                Return 775
            Case "Pipe of Insight (Recipe)"
                Return 900
            Case "Radiance (Recipe)"
                Return 1350
            Case "Refresher Orb (Recipe)"
                Return 1800
            Case "Sange (Recipe)"
                Return 600
            Case "Satanic (Recipe)"
                Return 1100
            Case "Shiva's Guard (Recipe)"
                Return 600
            Case "Skull Basher (Recipe)"
                Return 1000
            Case "Soul Ring (Recipe)"
                Return 125
            Case "Urn of Shadows (Recipe)"
                Return 250
            Case "Veil of Discord (Recipe)"
                Return 1250
            Case "Vladmir's Offering (Recipe)"
                Return 300
            Case "Wraith Band (Recipe)"
                Return 150
            Case "Yasha (Recipe)"
                Return 600
            Case Else
                Return 0
        End Select
    End Function

End Class
