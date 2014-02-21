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

        'PRESELECT THE BOX
        FormMain.ComboBox2.SelectedIndex = 0
        FormMain.ComboBox3.SelectedIndex = 0

        ClearNotImplemented()
    End Sub

    'Intitialize the ListView with all items
    Public Sub InitializeListbox()
        'Listview füllen
        With FormMain.ListView1
            .Clear()
            ' Add column headers so the subitems will appear.
            .Columns.AddRange(New ColumnHeader() {New ColumnHeader(), New ColumnHeader()})
            ' Create items and add them to ListView.
            Dim item0 As New ListViewItem(New String() {"Abyssal Blade", "Weapons", "PLACEHOLDER"}, 0)
            Dim item1 As New ListViewItem(New String() {"Aghanim's Scepter", "Caster", "PLACEHOLDER"}, 1)
            Dim item2 As New ListViewItem(New String() {"Animal Courier", "Consumables", "PLACEHOLDER"}, 2)
            Dim item3 As New ListViewItem(New String() {"Arcane Boots", "Support, Side Lane Shop", "PLACEHOLDER"}, 3)
            Dim item4 As New ListViewItem(New String() {"Armlet", "Weapons", "PLACEHOLDER"}, 4)
            Dim item5 As New ListViewItem(New String() {"Assault Cuirass", "Armor", "PLACEHOLDER"}, 5)
            Dim item6 As New ListViewItem(New String() {"Battle Fury", "Weapons", "PLACEHOLDER"}, 6)
            Dim item7 As New ListViewItem(New String() {"Belt of Strength", "Attributes, Side Lane Shop", "PLACEHOLDER"}, 7)
            Dim item8 As New ListViewItem(New String() {"Black King Bar", "Armor", "PLACEHOLDER"}, 8)
            Dim item9 As New ListViewItem(New String() {"Blade Mail", "Armor", "PLACEHOLDER"}, 9)
            Dim item10 As New ListViewItem(New String() {"Blade of Alacrity", "Attributes", "PLACEHOLDER"}, 10)
            Dim item11 As New ListViewItem(New String() {"Blades of Attack", "Armaments, Side Lane Shop", "PLACEHOLDER"}, 11)
            Dim item12 As New ListViewItem(New String() {"Blink Dagger", "Arcane, Side Lane Shop", "PLACEHOLDER"}, 12)
            Dim item13 As New ListViewItem(New String() {"Bloodstone", "Armor", "PLACEHOLDER"}, 13)
            Dim item14 As New ListViewItem(New String() {"Boots of Elvenskin", "Attributes, Side Lane Shop", "PLACEHOLDER"}, 14)
            Dim item15 As New ListViewItem(New String() {"Boots of Speed", "Arcane, Side Lane Shop", "PLACEHOLDER"}, 15)
            Dim item16 As New ListViewItem(New String() {"Boots of Travel", "Common", "PLACEHOLDER"}, 16)
            Dim item17 As New ListViewItem(New String() {"Bottle", "Consumables", "PLACEHOLDER"}, 17)
            Dim item18 As New ListViewItem(New String() {"Bracer", "Common", "PLACEHOLDER"}, 18)
            Dim item19 As New ListViewItem(New String() {"Broadsword", "Armaments", "PLACEHOLDER"}, 19)
            Dim item20 As New ListViewItem(New String() {"Buckler", "Support", "PLACEHOLDER"}, 20)
            Dim item21 As New ListViewItem(New String() {"Butterfly", "Weapons", "PLACEHOLDER"}, 21)
            Dim item22 As New ListViewItem(New String() {"Chainmail", "Armaments, Side Lane Shop", "PLACEHOLDER"}, 22)
            Dim item23 As New ListViewItem(New String() {"Circlet", "Attributes", "PLACEHOLDER"}, 23)
            Dim item24 As New ListViewItem(New String() {"Clarity", "Consumables", "PLACEHOLDER"}, 24)
            Dim item25 As New ListViewItem(New String() {"Claymore", "Armaments", "PLACEHOLDER"}, 25)
            Dim item26 As New ListViewItem(New String() {"Cloak", "Arcane, Side Lane Shop", "PLACEHOLDER"}, 26)
            Dim item27 As New ListViewItem(New String() {"Crystalys", "Weapons", "PLACEHOLDER"}, 27)
            Dim item28 As New ListViewItem(New String() {"Daedalus", "Weapons", "PLACEHOLDER"}, 28)
            Dim item29 As New ListViewItem(New String() {"Dagon 1", "Caster", "PLACEHOLDER"}, 29)
            Dim item30 As New ListViewItem(New String() {"Dagon 2", "Caster", "PLACEHOLDER"}, 30)
            Dim item31 As New ListViewItem(New String() {"Dagon 3", "Caster", "PLACEHOLDER"}, 31)
            Dim item32 As New ListViewItem(New String() {"Dagon 4", "Caster", "PLACEHOLDER"}, 32)
            Dim item33 As New ListViewItem(New String() {"Dagon 5", "Caster", "PLACEHOLDER"}, 33)
            Dim item34 As New ListViewItem(New String() {"Demon Edge", "Secret Shop", "PLACEHOLDER"}, 34)
            Dim item35 As New ListViewItem(New String() {"Desolator", "Artifacts", "PLACEHOLDER"}, 35)
            Dim item36 As New ListViewItem(New String() {"Diffusal Blade 1", "Artifacts", "PLACEHOLDER"}, 36)
            Dim item37 As New ListViewItem(New String() {"Diffusal Blade 2", "Artifacts", "PLACEHOLDER"}, 37)
            Dim item38 As New ListViewItem(New String() {"Divine Rapier", "Weapons", "PLACEHOLDER"}, 38)
            Dim item39 As New ListViewItem(New String() {"Drum of Endurance", "Support", "PLACEHOLDER"}, 39)
            Dim item40 As New ListViewItem(New String() {"Dust of Appearance", "Consumables", "PLACEHOLDER"}, 40)
            Dim item41 As New ListViewItem(New String() {"Eaglesong", "Secret Shop", "PLACEHOLDER"}, 41)
            Dim item42 As New ListViewItem(New String() {"Energy Booster", "Secret Shop, Side Lane Shop", "PLACEHOLDER"}, 42)
            Dim item43 As New ListViewItem(New String() {"Ethereal Blade", "Weapons", "PLACEHOLDER"}, 43)
            Dim item44 As New ListViewItem(New String() {"Eul's Scepter of Divinity", "Caster", "PLACEHOLDER"}, 44)
            Dim item45 As New ListViewItem(New String() {"Eye of Skadi", "Artifacts", "PLACEHOLDER"}, 45)
            Dim item46 As New ListViewItem(New String() {"Flying Courier", "Consumables", "PLACEHOLDER"}, 46)
            Dim item47 As New ListViewItem(New String() {"Force Staff", "Caster", "PLACEHOLDER"}, 47)
            Dim item48 As New ListViewItem(New String() {"Gauntlets of Strength", "Attributes", "PLACEHOLDER"}, 48)
            Dim item49 As New ListViewItem(New String() {"Gem of True Sight", "Arcane", "PLACEHOLDER"}, 49)
            Dim item50 As New ListViewItem(New String() {"Ghost Scepter", "Arcane", "PLACEHOLDER"}, 50)
            Dim item51 As New ListViewItem(New String() {"Gloves of Haste", "Arcane, Side Lane Shop", "PLACEHOLDER"}, 51)
            Dim item52 As New ListViewItem(New String() {"Hand of Midas", "Common", "PLACEHOLDER"}, 52)
            Dim item53 As New ListViewItem(New String() {"Headdress", "Support", "PLACEHOLDER"}, 53)
            Dim item54 As New ListViewItem(New String() {"Healing Salve", "Consumables", "PLACEHOLDER"}, 54)
            Dim item55 As New ListViewItem(New String() {"Heart of Tarrasque", "Armor", "PLACEHOLDER"}, 55)
            Dim item56 As New ListViewItem(New String() {"Heaven's Halberd", "Artifacts", "PLACEHOLDER"}, 56)
            Dim item57 As New ListViewItem(New String() {"Helm of Iron Will", "Armaments, Side Lane Shop", "PLACEHOLDER"}, 57)
            Dim item58 As New ListViewItem(New String() {"Helm of the Dominator", "Artifacts, Side Lane Shop", "PLACEHOLDER"}, 58)
            Dim item59 As New ListViewItem(New String() {"Hood of Defiance", "Armor, Side Lane Shop", "PLACEHOLDER"}, 59)
            Dim item60 As New ListViewItem(New String() {"Hyperstone", "Secret Shop", "PLACEHOLDER"}, 60)
            Dim item61 As New ListViewItem(New String() {"Iron Branch", "Attributes", "PLACEHOLDER"}, 61)
            Dim item62 As New ListViewItem(New String() {"Javelin", "Armaments", "PLACEHOLDER"}, 62)
            Dim item63 As New ListViewItem(New String() {"Linken's Sphere", "Armor", "PLACEHOLDER"}, 63)
            Dim item64 As New ListViewItem(New String() {"Maelstrom", "Artifacts", "PLACEHOLDER"}, 64)
            Dim item65 As New ListViewItem(New String() {"Magic Stick", "Arcane, Side Lane Shop", "PLACEHOLDER"}, 65)
            Dim item66 As New ListViewItem(New String() {"Magic Wand", "Common", "PLACEHOLDER"}, 66)
            Dim item67 As New ListViewItem(New String() {"Manta Style", "Armor", "PLACEHOLDER"}, 67)
            Dim item68 As New ListViewItem(New String() {"Mantle of Intelligence", "Attributes", "PLACEHOLDER"}, 68)
            Dim item69 As New ListViewItem(New String() {"Mask of Madness", "Artifacts", "PLACEHOLDER"}, 69)
            Dim item70 As New ListViewItem(New String() {"Medallion of Courage", "Support", "PLACEHOLDER"}, 70)
            Dim item71 As New ListViewItem(New String() {"Mekansm", "Support", "PLACEHOLDER"}, 71)
            Dim item72 As New ListViewItem(New String() {"Mithril Hammer", "Armaments", "PLACEHOLDER"}, 72)
            Dim item73 As New ListViewItem(New String() {"Mjollnir", "Artifacts", "PLACEHOLDER"}, 73)
            Dim item74 As New ListViewItem(New String() {"Monkey King Bar", "Weapons", "PLACEHOLDER"}, 74)
            Dim item75 As New ListViewItem(New String() {"Morbid Mask", "Arcane, Side Lane Shop", "PLACEHOLDER"}, 75)
            Dim item76 As New ListViewItem(New String() {"Mystic Staff", "Secret Shop", "PLACEHOLDER"}, 76)
            Dim item77 As New ListViewItem(New String() {"Necronomicon 1", "Caster", "PLACEHOLDER"}, 77)
            Dim item78 As New ListViewItem(New String() {"Necronomicon 2", "Caster", "PLACEHOLDER"}, 78)
            Dim item79 As New ListViewItem(New String() {"Necronomicon 3", "Caster", "PLACEHOLDER"}, 79)
            Dim item80 As New ListViewItem(New String() {"Null Talisman", "Common", "PLACEHOLDER"}, 80)
            Dim item81 As New ListViewItem(New String() {"Oblivion Staff", "Common, Side Lane Shop", "PLACEHOLDER"}, 81)
            Dim item82 As New ListViewItem(New String() {"Observer Ward", "Consumables", "PLACEHOLDER"}, 82)
            Dim item83 As New ListViewItem(New String() {"Ogre Club", "Attributes", "PLACEHOLDER"}, 83)
            Dim item84 As New ListViewItem(New String() {"Orb of Venom", "Secret Shop, Side Lane Shop", "PLACEHOLDER"}, 84)
            Dim item85 As New ListViewItem(New String() {"Orchid Malevolence", "Caster", "PLACEHOLDER"}, 85)
            Dim item86 As New ListViewItem(New String() {"Perseverance", "Common", "PLACEHOLDER"}, 86)
            Dim item87 As New ListViewItem(New String() {"Phase Boots", "Common, Side Lane Shop", "PLACEHOLDER"}, 87)
            Dim item88 As New ListViewItem(New String() {"Pipe of Insight", "Support", "PLACEHOLDER"}, 88)
            Dim item89 As New ListViewItem(New String() {"Platemail", "Armaments", "PLACEHOLDER"}, 89)
            Dim item90 As New ListViewItem(New String() {"Point Booster", "Secret Shop", "PLACEHOLDER"}, 90)
            Dim item91 As New ListViewItem(New String() {"Poor Man's Shield", "Common, Side Lane Shop", "PLACEHOLDER"}, 91)
            Dim item92 As New ListViewItem(New String() {"Power Treads", "Common, Side Lane Shop", "PLACEHOLDER"}, 92)
            Dim item93 As New ListViewItem(New String() {"Quarterstaff", "Armaments, Side Lane Shop", "PLACEHOLDER"}, 93)
            Dim item94 As New ListViewItem(New String() {"Quelling Blade", "Armaments, Side Lane Shop", "PLACEHOLDER"}, 94)
            Dim item95 As New ListViewItem(New String() {"Radiance", "Weapons", "PLACEHOLDER"}, 95)
            Dim item96 As New ListViewItem(New String() {"Reaver", "Secret Shop", "PLACEHOLDER"}, 96)
            Dim item97 As New ListViewItem(New String() {"Refresher Orb", "Caster", "PLACEHOLDER"}, 97)
            Dim item98 As New ListViewItem(New String() {"Ring of Aquila", "Support", "PLACEHOLDER"}, 98)
            Dim item99 As New ListViewItem(New String() {"Ring of Basilius", "Support", "PLACEHOLDER"}, 99)
            Dim item100 As New ListViewItem(New String() {"Ring of Health", "Secret Shop, Side Lane Shop", "PLACEHOLDER"}, 100)
            Dim item101 As New ListViewItem(New String() {"Ring of Protection", "Armaments", "PLACEHOLDER"}, 101)
            Dim item102 As New ListViewItem(New String() {"Ring of Regen", "Arcane, Side Lane Shop", "PLACEHOLDER"}, 102)
            Dim item103 As New ListViewItem(New String() {"Robe of the Magi", "Attributes, Side Lane Shop", "PLACEHOLDER"}, 103)
            Dim item104 As New ListViewItem(New String() {"Rod of Atos", "Caster", "PLACEHOLDER"}, 104)
            Dim item105 As New ListViewItem(New String() {"Sacred Relic", "Secret Shop", "PLACEHOLDER"}, 105)
            Dim item106 As New ListViewItem(New String() {"Sage's Mask", "Arcane, Side Lane Shop", "PLACEHOLDER"}, 106)
            Dim item107 As New ListViewItem(New String() {"Sange", "Artifacts", "PLACEHOLDER"}, 107)
            Dim item108 As New ListViewItem(New String() {"Sange and Yasha", "Artifacts", "PLACEHOLDER"}, 108)
            Dim item109 As New ListViewItem(New String() {"Satanic", "Artifacts", "PLACEHOLDER"}, 109)
            Dim item110 As New ListViewItem(New String() {"Scythe of Vyse", "Caster", "PLACEHOLDER"}, 110)
            Dim item111 As New ListViewItem(New String() {"Sentry Ward", "Consumables", "PLACEHOLDER"}, 111)
            Dim item112 As New ListViewItem(New String() {"Shadow Blade", "Weapons", "PLACEHOLDER"}, 112)
            Dim item113 As New ListViewItem(New String() {"Shiva's Guard", "Armor", "PLACEHOLDER"}, 113)
            Dim item114 As New ListViewItem(New String() {"Skull Basher", "Weapons", "PLACEHOLDER"}, 114)
            Dim item115 As New ListViewItem(New String() {"Slippers of Agility", "Attributes, Side Lane Shop", "PLACEHOLDER"}, 115)
            Dim item116 As New ListViewItem(New String() {"Smoke of Deceit", "Consumables", "PLACEHOLDER"}, 116)
            Dim item117 As New ListViewItem(New String() {"Soul Booster", "Armor", "PLACEHOLDER"}, 117)
            Dim item118 As New ListViewItem(New String() {"Soul Ring", "Common", "PLACEHOLDER"}, 118)
            Dim item119 As New ListViewItem(New String() {"Staff of Wizardry", "Attributes", "PLACEHOLDER"}, 119)
            Dim item120 As New ListViewItem(New String() {"Stout Shield", "Armaments, Side Lane Shop", "PLACEHOLDER"}, 120)
            Dim item121 As New ListViewItem(New String() {"Talisman of Evasion", "Arcane, Side Lane Shop", "PLACEHOLDER"}, 121)
            Dim item122 As New ListViewItem(New String() {"Tango", "Consumables", "PLACEHOLDER"}, 122)
            Dim item123 As New ListViewItem(New String() {"Town Portal Scroll", "Consumables, Side Lane Shop", "PLACEHOLDER"}, 123)
            Dim item124 As New ListViewItem(New String() {"Tranquil Boots", "Support", "PLACEHOLDER"}, 124)
            Dim item125 As New ListViewItem(New String() {"Ultimate Orb", "Attributes, Side Lane Shop", "PLACEHOLDER"}, 125)
            Dim item126 As New ListViewItem(New String() {"Urn of Shadows", "Support", "PLACEHOLDER"}, 126)
            Dim item127 As New ListViewItem(New String() {"Vanguard", "Armor", "PLACEHOLDER"}, 127)
            Dim item128 As New ListViewItem(New String() {"Veil of Discord", "Caster", "PLACEHOLDER"}, 128)
            Dim item129 As New ListViewItem(New String() {"Vitality Booster", "Secret Shop", "PLACEHOLDER"}, 129)
            Dim item130 As New ListViewItem(New String() {"Vladmir's Offering", "Support", "PLACEHOLDER"}, 130)
            Dim item131 As New ListViewItem(New String() {"Void Stone", "Secret Shop", "PLACEHOLDER"}, 131)
            Dim item132 As New ListViewItem(New String() {"Wraith Band", "Common", "PLACEHOLDER"}, 132)
            Dim item133 As New ListViewItem(New String() {"Yasha", "Artifacts", "PLACEHOLDER"}, 133)
            Dim item134 As New ListViewItem(New String() {"Wraith Band (Recipe)", "Common", "PLACEHOLDER"}, 134)
            Dim item135 As New ListViewItem(New String() {"Bracer (Recipe)", "Common", "PLACEHOLDER"}, 134)
            Dim item136 As New ListViewItem(New String() {"Null Talisman (Recipe)", "Common", "PLACEHOLDER"}, 134)
            Dim item137 As New ListViewItem(New String() {"Magic Wand (Recipe)", "Common", "PLACEHOLDER"}, 134)
            Dim item138 As New ListViewItem(New String() {"Hand of Midas (Recipe)", "Common", "PLACEHOLDER"}, 134)
            Dim item139 As New ListViewItem(New String() {"Soul Ring (Recipe)", "Common", "PLACEHOLDER"}, 134)
            Dim item140 As New ListViewItem(New String() {"Boots of Travel (Recipe)", "Common", "PLACEHOLDER"}, 134)
            Dim item141 As New ListViewItem(New String() {"Headdress (Recipe)", "Support", "PLACEHOLDER"}, 134)
            Dim item142 As New ListViewItem(New String() {"Buckler (Recipe)", "Support", "PLACEHOLDER"}, 134)
            Dim item143 As New ListViewItem(New String() {"Urn of Shadows (Recipe)", "Support", "PLACEHOLDER"}, 134)
            Dim item144 As New ListViewItem(New String() {"Mekansm (Recipe)", "Support", "PLACEHOLDER"}, 134)
            Dim item145 As New ListViewItem(New String() {"Medallion of Courage (Recipe)", "Support", "PLACEHOLDER"}, 134)
            Dim item146 As New ListViewItem(New String() {"Vladmir's Offering (Recipe)", "Support", "PLACEHOLDER"}, 134)
            Dim item147 As New ListViewItem(New String() {"Pipe of Insight (Recipe)", "Support", "PLACEHOLDER"}, 134)
            Dim item148 As New ListViewItem(New String() {"Drum of Endurance (Recipe)", "Support", "PLACEHOLDER"}, 134)
            Dim item149 As New ListViewItem(New String() {"Necronomicon (Recipe)", "Caster", "PLACEHOLDER"}, 134)
            Dim item150 As New ListViewItem(New String() {"Eul's Scepter of Divinity (Recipe)", "Caster", "PLACEHOLDER"}, 134)
            Dim item151 As New ListViewItem(New String() {"Dagon (Recipe)", "Caster", "PLACEHOLDER"}, 134)
            Dim item152 As New ListViewItem(New String() {"Veil of Discord (Recipe)", "Caster", "PLACEHOLDER"}, 134)
            Dim item153 As New ListViewItem(New String() {"Orchid Malevolence (Recipe)", "Caster", "PLACEHOLDER"}, 134)
            Dim item154 As New ListViewItem(New String() {"Refresher Orb (Recipe)", "Caster", "PLACEHOLDER"}, 134)
            Dim item155 As New ListViewItem(New String() {"Force Staff (Recipe)", "Caster", "PLACEHOLDER"}, 134)
            Dim item156 As New ListViewItem(New String() {"Armlet (Recipe)", "Weapons", "PLACEHOLDER"}, 134)
            Dim item157 As New ListViewItem(New String() {"Crystalys (Recipe)", "Weapons", "PLACEHOLDER"}, 134)
            Dim item158 As New ListViewItem(New String() {"Daedalus (Recipe)", "Weapons", "PLACEHOLDER"}, 134)
            Dim item159 As New ListViewItem(New String() {"Skull Basher (Recipe)", "Weapons", "PLACEHOLDER"}, 134)
            Dim item160 As New ListViewItem(New String() {"Radiance (Recipe)", "Weapons", "PLACEHOLDER"}, 134)
            Dim item161 As New ListViewItem(New String() {"Black King Bar (Recipe)", "Armor", "PLACEHOLDER"}, 134)
            Dim item162 As New ListViewItem(New String() {"Assault Cuirass (Recipe)", "Armor", "PLACEHOLDER"}, 134)
            Dim item163 As New ListViewItem(New String() {"Manta Style (Recipe)", "Armor", "PLACEHOLDER"}, 134)
            Dim item164 As New ListViewItem(New String() {"Shiva's Guard (Recipe)", "Armor", "PLACEHOLDER"}, 134)
            Dim item165 As New ListViewItem(New String() {"Linken's Sphere (Recipe)", "Armor", "PLACEHOLDER"}, 134)
            Dim item166 As New ListViewItem(New String() {"Heart of Tarrasque (Recipe)", "Armor", "PLACEHOLDER"}, 134)
            Dim item167 As New ListViewItem(New String() {"Desolator (Recipe)", "Artifact", "PLACEHOLDER"}, 134)
            Dim item168 As New ListViewItem(New String() {"Mjollnir (Recipe)", "Artifact", "PLACEHOLDER"}, 134)
            Dim item169 As New ListViewItem(New String() {"Satanic (Recipe)", "Artifact", "PLACEHOLDER"}, 134)
            Dim item170 As New ListViewItem(New String() {"Yasha (Recipe)", "Artifact", "PLACEHOLDER"}, 134)
            Dim item171 As New ListViewItem(New String() {"Diffusal Blade (Recipe)", "Artifact", "PLACEHOLDER"}, 134)
            Dim item172 As New ListViewItem(New String() {"Sange (Recipe)", "Artifact", "PLACEHOLDER"}, 134)
            Dim item173 As New ListViewItem(New String() {"Mask of Madness (Recipe)", "Artifact", "PLACEHOLDER"}, 134)
            Dim item174 As New ListViewItem(New String() {"Maelstrom (Recipe)", "Artifact", "PLACEHOLDER"}, 134)
            Dim item175 As New ListViewItem(New String() {"Shadow Amulet", "Arcane", "PLACEHOLDER"}, 135)
            .Items.AddRange(New ListViewItem() {item0, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20, item21, item22, item23, item24, item25, item26, item27, item28, item29, item30, item31, item32, item33, item34, item35, item36, item37, item38, item39, item40, item41, item42, item43, item44, item45, item46, item47, item48, item49, item50, item51, item52, item53, item54, item55, item56, item57, item58, item59, item60, item61, item62, item63, item64, item65, item66, item67, item68, item69, item70, item71, item72, item73, item74, item75, item76, item77, item78, item79, item80, item81, item82, item83, item84, item85, item86, item87, item88, item89, item90, item91, item92, item93, item94, item95, item96, item97, item98, item99, item100, item101, item102, item103, item104, item105, item106, item107, item108, item109, item110, item111, item112, item113, item114, item115, item116, item117, item118, item119, item120, item121, item122, item123, item124, item125, item126, item127, item128, item129, item130, item131, item132, item133, item134, item135, item136, item137, item138, item139, item140, item141, item142, item143, item144, item145, item146, item147, item148, item149, item150, item151, item152, item153, item154, item155, item156, item157, item158, item159, item160, item161, item162, item163, item164, item165, item166, item167, item168, item169, item170, item171, item172, item173, item174, item175})

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
        FormMain.ListView2.Clear()
        FormMain.ListView3.Clear()
        FormMain.ListView4.Clear()
        FormMain.ListView5.Clear()
        FormMain.ListView6.Clear()
        FormMain.ListView7.Clear()

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
            Dim ItemList As Object = FormMain.ListView2
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
                            ItemList = FormMain.ListView3
                            Index = 0
                            savePrice = False
                        Case 4
                            FormMain.Itemslot3.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListView4
                            Index = 0
                            savePrice = False
                        Case 5
                            FormMain.Itemslot4.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListView5
                            Index = 0
                            savePrice = False
                        Case 6
                            FormMain.Itemslot5.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListView6
                            Index = 0
                            savePrice = False
                        Case 7
                            FormMain.Itemslot6.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListView7
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
            Dim ItemList As Object = FormMain.ListView2
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
                            ItemList = FormMain.ListView3
                            Index = 0
                            savePrice = False
                        Case 4
                            FormMain.Itemslot3.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListView4
                            Index = 0
                            savePrice = False
                        Case 5
                            FormMain.Itemslot4.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListView5
                            Index = 0
                            savePrice = False
                        Case 6
                            FormMain.Itemslot5.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListView6
                            Index = 0
                            savePrice = False
                        Case 7
                            FormMain.Itemslot6.Text = GetLabel(OldLine)
                            ItemList = FormMain.ListView7
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

            For i = 0 To (FormMain.ListView2.Items.Count - 1)
                Box1 &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & """" & FormMain.GetItem(FormMain.ListView2.Items(i).SubItems(1).Text) & """"
            Next
            For i = 0 To (FormMain.ListView3.Items.Count - 1)
                Box2 &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & """" & FormMain.GetItem(FormMain.ListView3.Items(i).SubItems(1).Text) & """"
            Next
            For i = 0 To (FormMain.ListView4.Items.Count - 1)
                Box3 &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & """" & FormMain.GetItem(FormMain.ListView4.Items(i).SubItems(1).Text) & """"
            Next
            For i = 0 To (FormMain.ListView5.Items.Count - 1)
                Box4 &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & """" & FormMain.GetItem(FormMain.ListView5.Items(i).SubItems(1).Text) & """"
            Next
            For i = 0 To (FormMain.ListView6.Items.Count - 1)
                Box5 &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & """" & FormMain.GetItem(FormMain.ListView6.Items(i).SubItems(1).Text) & """"
            Next
            For i = 0 To (FormMain.ListView7.Items.Count - 1)
                Box6 &= vbNewLine & vbTab & vbTab & vbTab & """Item""" & vbTab & vbTab & """" & FormMain.GetItem(FormMain.ListView7.Items(i).SubItems(1).Text) & """"
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
                ' FEHLENDE HEROS BTW. FEHLENDE ITEMDATEIEN
            Case hero Like "npc_dota_hero_goblin_techies"
                hero = "Goblin Techies"
            Case hero Like "npc_dota_hero_phoenix"
                hero = "Phoenix"
            Case hero Like "npc_dota_hero_abyssal_underlord"
                hero = "Abyssal Underlord"
            Case hero Like "npc_dota_hero_soul_keeper"
                hero = "Soul Keeper"
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
            Case "Faceless Void"
                Selected_Hero = "faceless_void"
            Case "Keeper of the Light"
                Selected_Hero = "keeper_of_the_light"
            Case "Templar Assassin"
                Selected_Hero = "templar_assassin"
            Case "Lifestealer"
                Selected_Hero = "life_stealer"
            Case "Lone Druid"
                Selected_Hero = "lone_druid"
            Case "Phantom Assassin"
                Selected_Hero = "phantom_assassin"
            Case "Nyx Assassin"
                Selected_Hero = "nyx_assassin"
            Case "Nature's Prophet"
                Selected_Hero = "furion"
            Case "Night Stalker"
                Selected_Hero = "night_stalker"
            Case "Ogre Magi"
                Selected_Hero = "ogre_magi"
            Case "Outworld Devourer"
                Selected_Hero = "obsidian_destroyer"
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
            Case "Spirit Breaker"
                Selected_Hero = "spirit_breaker"
            Case "Storm Spirit"
                Selected_Hero = "storm_spirit"
            Case "Treant Protector"
                Selected_Hero = "treant"
            Case "Vengeful Spirit"
                Selected_Hero = "vengefulspirit"
            Case "Witch Doctor"
                Selected_Hero = "witch_doctor"
            Case "Zeus"
                Selected_Hero = "zuus"
            Case "Centaur Warrunner"
                Selected_Hero = "centaur"
            Case "Troll Warlord"
                Selected_Hero = "troll_warlord"
            Case "Naga Siren"
                Selected_Hero = "naga_siren"
            Case "Magnus"
                Selected_Hero = "magnataur"
            Case "Timbersaw"
                Selected_Hero = "shredder"
            Case "Earth Spirit"
                Selected_Hero = "earth_spirit"
            Case "Elder Titan"
                Selected_Hero = "elder_titan"
            Case "Ember Spirit"
                Selected_Hero = "ember_spirit"
            Case "Legion Commander"
                Selected_Hero = "legion_commander"
            Case "Skywrath Mage"
                Selected_Hero = "skywrath_mage"
            Case "Io"
                Selected_Hero = "wisp"
            Case "Necrophos"
                Selected_Hero = "necrolyte"
            Case "Windranger"
                Selected_Hero = "windrunner"
                ' FEHLENDE HEROS BTW. FEHLENDE ITEMDATEIEN
            Case "Goblin Techies"
                Selected_Hero = "goblin_techies"
            Case "Abyssal Underlord"
                Selected_Hero = "abyssal_underlord"
            Case "Soul Keeper"
                Selected_Hero = "soul_keeper"
            Case "Tauren Chieftain"
                Selected_Hero = "tauren_chieftain"
            Case Else
                Selected_Hero = hero
        End Select
        Return Selected_Hero
    End Function

    'Change the list of heros to a selection like all carrys or all agi heros
    Public Sub ChangeHeroList(ByVal cb As Object, ByVal lb As Object)
        Dim i As Integer
        Dim sI As Integer = cb.SelectedIndex

        'Clear Listbox
        lb.SelectedItems.Clear()
        For i = lb.Items.Count - 1 To 0 Step -1
            lb.Items.Remove(lb.Items(i).ToString)
        Next

        Select Case sI
            Case 0
                'All
                lb.Items.Add("Abaddon")
                lb.Items.Add("Abyssal Underlord")
                lb.Items.Add("Alchemist")
                lb.Items.Add("Ancient Apparition")
                lb.Items.Add("Anti-Mage")
                lb.Items.Add("Arc Warden")
                lb.Items.Add("Axe")
                lb.Items.Add("Bane")
                lb.Items.Add("Batrider")
                lb.Items.Add("Beastmaster")
                lb.Items.Add("Bloodseeker")
                lb.Items.Add("Bounty Hunter")
                lb.Items.Add("Brewmaster")
                lb.Items.Add("Bristleback")
                lb.Items.Add("Broodmother")
                lb.Items.Add("Centaur Warrunner")
                lb.Items.Add("Chaos Knight")
                lb.Items.Add("Chen")
                lb.Items.Add("Clinkz")
                lb.Items.Add("Clockwerk")
                lb.Items.Add("Crystal Maiden")
                lb.Items.Add("Dark Seer")
                lb.Items.Add("Dazzle")
                lb.Items.Add("Death Prophet")
                lb.Items.Add("Disruptor")
                lb.Items.Add("Doom")
                lb.Items.Add("Dragon Knight")
                lb.Items.Add("Drow Ranger")
                lb.Items.Add("Earth Spirit")
                lb.Items.Add("Earthshaker")
                lb.Items.Add("Elder Titan")
                lb.Items.Add("Ember Spirit")
                lb.Items.Add("Enchantress")
                lb.Items.Add("Enigma")
                lb.Items.Add("Faceless Void")
                lb.Items.Add("Goblin Techies")
                lb.Items.Add("Gyrocopter")
                lb.Items.Add("Huskar")
                lb.Items.Add("Invoker")
                lb.Items.Add("Io")
                lb.Items.Add("Jakiro")
                lb.Items.Add("Juggernaut")
                lb.Items.Add("Keeper of the Light")
                lb.Items.Add("Kunkka")
                lb.Items.Add("Legion Commander")
                lb.Items.Add("Leshrac")
                lb.Items.Add("Lich")
                lb.Items.Add("Lifestealer")
                lb.Items.Add("Lina")
                lb.Items.Add("Lion")
                lb.Items.Add("Lone Druid")
                lb.Items.Add("Luna")
                lb.Items.Add("Lycan")
                lb.Items.Add("Magnus")
                lb.Items.Add("Medusa")
                lb.Items.Add("Meepo")
                lb.Items.Add("Mirana")
                lb.Items.Add("Morphling")
                lb.Items.Add("Naga Siren")
                lb.Items.Add("Nature's Prophet")
                lb.Items.Add("Necrophos")
                lb.Items.Add("Night Stalker")
                lb.Items.Add("Nyx Assassin")
                lb.Items.Add("Ogre Magi")
                lb.Items.Add("Omniknight")
                lb.Items.Add("Oracle")
                lb.Items.Add("Outworld Devourer")
                lb.Items.Add("Phantom Assassin")
                lb.Items.Add("Phantom Lancer")
                lb.Items.Add("Phoenix")
                lb.Items.Add("Puck")
                lb.Items.Add("Pudge")
                lb.Items.Add("Pugna")
                lb.Items.Add("Queen of Pain")
                lb.Items.Add("Razor")
                lb.Items.Add("Riki")
                lb.Items.Add("Rubick")
                lb.Items.Add("Sand King")
                lb.Items.Add("Shadow Demon")
                lb.Items.Add("Shadow Fiend")
                lb.Items.Add("Shadow Shaman")
                lb.Items.Add("Silencer")
                lb.Items.Add("Skeleton King")
                lb.Items.Add("Skywrath Mage")
                lb.Items.Add("Slardar")
                lb.Items.Add("Slark")
                lb.Items.Add("Sniper")
                lb.Items.Add("Soul Keeper")
                lb.Items.Add("Spectre")
                lb.Items.Add("Spirit Breaker")
                lb.Items.Add("Storm Spirit")
                lb.Items.Add("Sven")
                lb.Items.Add("Templar Assassin")
                lb.Items.Add("Tidehunter")
                lb.Items.Add("Timbersaw")
                lb.Items.Add("Tinker")
                lb.Items.Add("Tiny")
                lb.Items.Add("Treant Protector")
                lb.Items.Add("Troll Warlord")
                lb.Items.Add("Tusk")
                lb.Items.Add("Undying")
                lb.Items.Add("Ursa")
                lb.Items.Add("Vengeful Spirit")
                lb.Items.Add("Venomancer")
                lb.Items.Add("Viper")
                lb.Items.Add("Visage")
                lb.Items.Add("Warlock")
                lb.Items.Add("Weaver")
                lb.Items.Add("Windranger")
                lb.Items.Add("Winter Wyvern")
                lb.Items.Add("Witch Doctor")
                lb.Items.Add("Zeus")
            Case 1
                'Strenght
                lb.Items.Add("Abaddon")
                lb.Items.Add("Abyssal Underlord")
                lb.Items.Add("Alchemist")
                lb.Items.Add("Axe")
                lb.Items.Add("Beastmaster")
                lb.Items.Add("Brewmaster")
                lb.Items.Add("Bristleback")
                lb.Items.Add("Centaur Warrunner")
                lb.Items.Add("Chaos Knight")
                lb.Items.Add("Clockwerk")
                lb.Items.Add("Doom")
                lb.Items.Add("Dragon Knight")
                lb.Items.Add("Earth Spirit")
                lb.Items.Add("Earthshaker")
                lb.Items.Add("Elder Titan")
                lb.Items.Add("Huskar")
                lb.Items.Add("Io")
                lb.Items.Add("Kunkka")
                lb.Items.Add("Legion Commander")
                lb.Items.Add("Lifestealer")
                lb.Items.Add("Lycan")
                lb.Items.Add("Magnus")
                lb.Items.Add("Night Stalker")
                lb.Items.Add("Omniknight")
                lb.Items.Add("Phoenix")
                lb.Items.Add("Pudge")
                lb.Items.Add("Sand King")
                lb.Items.Add("Skeleton King")
                lb.Items.Add("Slardar")
                lb.Items.Add("Spirit Breaker")
                lb.Items.Add("Sven")
                lb.Items.Add("Tidehunter")
                lb.Items.Add("Timbersaw")
                lb.Items.Add("Tiny")
                lb.Items.Add("Treant Protector")
                lb.Items.Add("Tusk")
                lb.Items.Add("Undying")
            Case 2
                'Agility
                lb.Items.Add("Anti-Mage")
                lb.Items.Add("Arc Warden")
                lb.Items.Add("Bloodseeker")
                lb.Items.Add("Bounty Hunter")
                lb.Items.Add("Broodmother")
                lb.Items.Add("Clinkz")
                lb.Items.Add("Drow Ranger")
                lb.Items.Add("Ember Spirit")
                lb.Items.Add("Faceless Void")
                lb.Items.Add("Gyrocopter")
                lb.Items.Add("Juggernaut")
                lb.Items.Add("Lone Druid")
                lb.Items.Add("Luna")
                lb.Items.Add("Medusa")
                lb.Items.Add("Meepo")
                lb.Items.Add("Mirana")
                lb.Items.Add("Morphling")
                lb.Items.Add("Naga Siren")
                lb.Items.Add("Nyx Assassin")
                lb.Items.Add("Phantom Assassin")
                lb.Items.Add("Phantom Lancer")
                lb.Items.Add("Razor")
                lb.Items.Add("Riki")
                lb.Items.Add("Shadow Fiend")
                lb.Items.Add("Slark")
                lb.Items.Add("Sniper")
                lb.Items.Add("Soul Keeper")
                lb.Items.Add("Spectre")
                lb.Items.Add("Templar Assassin")
                lb.Items.Add("Troll Warlord")
                lb.Items.Add("Ursa")
                lb.Items.Add("Vengeful Spirit")
                lb.Items.Add("Venomancer")
                lb.Items.Add("Viper")
                lb.Items.Add("Weaver")
            Case 3
                'Intelligence
                lb.Items.Add("Ancient Apparition")
                lb.Items.Add("Bane")
                lb.Items.Add("Batrider")
                lb.Items.Add("Chen")
                lb.Items.Add("Crystal Maiden")
                lb.Items.Add("Dark Seer")
                lb.Items.Add("Dazzle")
                lb.Items.Add("Death Prophet")
                lb.Items.Add("Disruptor")
                lb.Items.Add("Enchantress")
                lb.Items.Add("Enigma")
                lb.Items.Add("Goblin Techies")
                lb.Items.Add("Invoker")
                lb.Items.Add("Jakiro")
                lb.Items.Add("Keeper of the Light")
                lb.Items.Add("Leshrac")
                lb.Items.Add("Lich")
                lb.Items.Add("Lina")
                lb.Items.Add("Lion")
                lb.Items.Add("Nature's Prophet")
                lb.Items.Add("Necrophos")
                lb.Items.Add("Ogre Magi")
                lb.Items.Add("Oracle")
                lb.Items.Add("Outworld Devourer")
                lb.Items.Add("Puck")
                lb.Items.Add("Pugna")
                lb.Items.Add("Queen of Pain")
                lb.Items.Add("Rubick")
                lb.Items.Add("Shadow Demon")
                lb.Items.Add("Shadow Shaman")
                lb.Items.Add("Silencer")
                lb.Items.Add("Skywrath Mage")
                lb.Items.Add("Storm Spirit")
                lb.Items.Add("Tinker")
                lb.Items.Add("Visage")
                lb.Items.Add("Warlock")
                lb.Items.Add("Windranger")
                lb.Items.Add("Winter Wyvern")
                lb.Items.Add("Witch Doctor")
                lb.Items.Add("Zeus")
            Case 4
                'Carry
                lb.Items.Add("Alchemist")
                lb.Items.Add("Anti-Mage")
                lb.Items.Add("Bloodseeker")
                lb.Items.Add("Bounty Hunter")
                lb.Items.Add("Broodmother")
                lb.Items.Add("Clinkz")
                lb.Items.Add("Doom")
                lb.Items.Add("Dragon Knight")
                lb.Items.Add("Drow Ranger")
                lb.Items.Add("Ember Spirit")
                lb.Items.Add("Faceless Void")
                lb.Items.Add("Goblin Techies")
                lb.Items.Add("Gyrocopter")
                lb.Items.Add("Huskar")
                lb.Items.Add("Invoker")
                lb.Items.Add("Juggernaut")
                lb.Items.Add("Kunkka")
                lb.Items.Add("Templar Assassin")
                lb.Items.Add("Legion Commander")
                lb.Items.Add("Leshrac")
                lb.Items.Add("Lone Druid")
                lb.Items.Add("Luna")
                lb.Items.Add("Lycan")
                lb.Items.Add("Medusa")
                lb.Items.Add("Meepo")
                lb.Items.Add("Mirana")
                lb.Items.Add("Morphling")
                lb.Items.Add("Phantom Assassin")
                lb.Items.Add("Necrophos")
                lb.Items.Add("Night Stalker")
                lb.Items.Add("Outworld Devourer")
                lb.Items.Add("Phantom Lancer")
                lb.Items.Add("Phoenix")
                lb.Items.Add("Queen of Pain")
                lb.Items.Add("Razor")
                lb.Items.Add("Riki")
                lb.Items.Add("Shadow Fiend")
                lb.Items.Add("Silencer")
                lb.Items.Add("Skeleton King")
                lb.Items.Add("Skywrath Mage")
                lb.Items.Add("Slardar")
                lb.Items.Add("Sniper")
                lb.Items.Add("Soul Keeper")
                lb.Items.Add("Spectre")
                lb.Items.Add("Storm Spirit")
                lb.Items.Add("Sven")
                lb.Items.Add("Tinker")
                lb.Items.Add("Troll Warlord")
                lb.Items.Add("Ursa")
                lb.Items.Add("Venomancer")
                lb.Items.Add("Viper")
                lb.Items.Add("Weaver")
                lb.Items.Add("Windranger")
            Case 5
                'Support
                lb.Items.Add("Abaddon")
                lb.Items.Add("Ancient Apparition")
                lb.Items.Add("Bane")
                lb.Items.Add("Chen")
                lb.Items.Add("Crystal Maiden")
                lb.Items.Add("Dark Seer")
                lb.Items.Add("Dazzle")
                lb.Items.Add("Disruptor")
                lb.Items.Add("Goblin Techies")
                lb.Items.Add("Io")
                lb.Items.Add("Invoker")
                lb.Items.Add("Keeper of the Light")
                lb.Items.Add("Lich")
                lb.Items.Add("Lion")
                lb.Items.Add("Necrophos")
                lb.Items.Add("Ogre Magi")
                lb.Items.Add("Omniknight")
                lb.Items.Add("Rubick")
                lb.Items.Add("Shadow Demon")
                lb.Items.Add("Silencer")
                lb.Items.Add("Vengeful Spirit")
                lb.Items.Add("Warlock")
                lb.Items.Add("Witch Doctor")
            Case 6
                'Ganker
                lb.Items.Add("Ancient Apparition")
                lb.Items.Add("Bane")
                lb.Items.Add("Batrider")
                lb.Items.Add("Beastmaster")
                lb.Items.Add("Bloodseeker")
                lb.Items.Add("Bounty Hunter")
                lb.Items.Add("Bristleback")
                lb.Items.Add("Chaos Knight")
                lb.Items.Add("Clockwerk")
                lb.Items.Add("Undying")
                lb.Items.Add("Disruptor")
                lb.Items.Add("Doom")
                lb.Items.Add("Earthshaker")
                lb.Items.Add("Timbersaw")
                lb.Items.Add("Goblin Techies")
                lb.Items.Add("Invoker")
                lb.Items.Add("Jakiro")
                lb.Items.Add("Kunkka")
                lb.Items.Add("Templar Assassin")
                lb.Items.Add("Legion Commander")
                lb.Items.Add("Lich")
                lb.Items.Add("Lifestealer")
                lb.Items.Add("Lina")
                lb.Items.Add("Lion")
                lb.Items.Add("Mirana")
                lb.Items.Add("Morphling")
                lb.Items.Add("Naga Siren")
                lb.Items.Add("Nature's Prophet")
                lb.Items.Add("Nyx Assassin")
                lb.Items.Add("Night Stalker")
                lb.Items.Add("Phoenix")
                lb.Items.Add("Pudge")
                lb.Items.Add("Queen of Pain")
                lb.Items.Add("Riki")
                lb.Items.Add("Rubick")
                lb.Items.Add("Sand King")
                lb.Items.Add("Skywrath Mage")
                lb.Items.Add("Slark")
                lb.Items.Add("Spirit Breaker")
                lb.Items.Add("Storm Spirit")
                lb.Items.Add("Sven")
                lb.Items.Add("Elder Titan")
                lb.Items.Add("Tidehunter")
                lb.Items.Add("Tinker")
                lb.Items.Add("Tiny")
                lb.Items.Add("Tusk")
                lb.Items.Add("Vengeful Spirit")
                lb.Items.Add("Weaver")
                lb.Items.Add("Witch Doctor")
                lb.Items.Add("Zeus")
            Case 7
                'Initiator
                lb.Items.Add("Axe")
                lb.Items.Add("Brewmaster")
                lb.Items.Add("Clockwerk")
                lb.Items.Add("Earthshaker")
                lb.Items.Add("Earth Spirit")
                lb.Items.Add("Enigma")
                lb.Items.Add("Magnus")
                lb.Items.Add("Naga Siren")
                lb.Items.Add("Phoenix")
                lb.Items.Add("Puck")
                lb.Items.Add("Pudge")
                lb.Items.Add("Sand King")
                lb.Items.Add("Slardar")
                lb.Items.Add("Tidehunter")
                lb.Items.Add("Tiny")
                lb.Items.Add("Treant Protector")
            Case 8
                'Pusher
                lb.Items.Add("Broodmother")
                lb.Items.Add("Chen")
                lb.Items.Add("Death Prophet")
                lb.Items.Add("Enchantress")
                lb.Items.Add("Goblin Techies")
                lb.Items.Add("Invoker")
                lb.Items.Add("Keeper of the Light")
                lb.Items.Add("Kunkka")
                lb.Items.Add("Leshrac")
                lb.Items.Add("Lone Druid")
                lb.Items.Add("Lycan")
                lb.Items.Add("Meepo")
                lb.Items.Add("Nature's Prophet")
                lb.Items.Add("Necrophos")
                lb.Items.Add("Phantom Lancer")
                lb.Items.Add("Pit Lord")
                lb.Items.Add("Pugna")
                lb.Items.Add("Shadow Shaman")
                lb.Items.Add("Tinker")
                lb.Items.Add("Venomancer")
            Case 9
                'Jungler
                lb.Items.Add("Axe")
                lb.Items.Add("Chen")
                lb.Items.Add("Enigma")
                lb.Items.Add("Lycan")
                lb.Items.Add("Nature's Prophet")
                lb.Items.Add("Ursa")
            Case 10
                'Tank
                lb.Items.Add("Brewmaster")
                lb.Items.Add("Centaur Warrunner")
                lb.Items.Add("Death Prophet")
                lb.Items.Add("Undying")
                lb.Items.Add("Timbersaw")
                lb.Items.Add("Legion Commander")
                lb.Items.Add("Phoenix")
                lb.Items.Add("Skeleton King")
            Case Else
                'All
                lb.Items.Add("Abaddon")
                lb.Items.Add("Abyssal Underlord")
                lb.Items.Add("Alchemist")
                lb.Items.Add("Ancient Apparition")
                lb.Items.Add("Anti-Mage")
                lb.Items.Add("Arc Warden")
                lb.Items.Add("Axe")
                lb.Items.Add("Bane")
                lb.Items.Add("Batrider")
                lb.Items.Add("Beastmaster")
                lb.Items.Add("Bloodseeker")
                lb.Items.Add("Bounty Hunter")
                lb.Items.Add("Brewmaster")
                lb.Items.Add("Bristleback")
                lb.Items.Add("Broodmother")
                lb.Items.Add("Centaur Warrunner")
                lb.Items.Add("Chaos Knight")
                lb.Items.Add("Chen")
                lb.Items.Add("Clinkz")
                lb.Items.Add("Clockwerk")
                lb.Items.Add("Crystal Maiden")
                lb.Items.Add("Dark Seer")
                lb.Items.Add("Dazzle")
                lb.Items.Add("Death Prophet")
                lb.Items.Add("Disruptor")
                lb.Items.Add("Doom")
                lb.Items.Add("Dragon Knight")
                lb.Items.Add("Drow Ranger")
                lb.Items.Add("Earth Spirit")
                lb.Items.Add("Earthshaker")
                lb.Items.Add("Elder Titan")
                lb.Items.Add("Ember Spirit")
                lb.Items.Add("Enchantress")
                lb.Items.Add("Enigma")
                lb.Items.Add("Faceless Void")
                lb.Items.Add("Goblin Techies")
                lb.Items.Add("Gyrocopter")
                lb.Items.Add("Huskar")
                lb.Items.Add("Invoker")
                lb.Items.Add("Io")
                lb.Items.Add("Jakiro")
                lb.Items.Add("Juggernaut")
                lb.Items.Add("Keeper of the Light")
                lb.Items.Add("Kunkka")
                lb.Items.Add("Legion Commander")
                lb.Items.Add("Leshrac")
                lb.Items.Add("Lich")
                lb.Items.Add("Lifestealer")
                lb.Items.Add("Lina")
                lb.Items.Add("Lion")
                lb.Items.Add("Lone Druid")
                lb.Items.Add("Luna")
                lb.Items.Add("Lycan")
                lb.Items.Add("Magnus")
                lb.Items.Add("Medusa")
                lb.Items.Add("Meepo")
                lb.Items.Add("Mirana")
                lb.Items.Add("Morphling")
                lb.Items.Add("Naga Siren")
                lb.Items.Add("Nature's Prophet")
                lb.Items.Add("Necrophos")
                lb.Items.Add("Night Stalker")
                lb.Items.Add("Nyx Assassin")
                lb.Items.Add("Ogre Magi")
                lb.Items.Add("Omniknight")
                lb.Items.Add("Oracle")
                lb.Items.Add("Outworld Devourer")
                lb.Items.Add("Phantom Assassin")
                lb.Items.Add("Phantom Lancer")
                lb.Items.Add("Phoenix")
                lb.Items.Add("Puck")
                lb.Items.Add("Pudge")
                lb.Items.Add("Pugna")
                lb.Items.Add("Queen of Pain")
                lb.Items.Add("Razor")
                lb.Items.Add("Riki")
                lb.Items.Add("Rubick")
                lb.Items.Add("Sand King")
                lb.Items.Add("Shadow Demon")
                lb.Items.Add("Shadow Fiend")
                lb.Items.Add("Shadow Shaman")
                lb.Items.Add("Silencer")
                lb.Items.Add("Skeleton King")
                lb.Items.Add("Skywrath Mage")
                lb.Items.Add("Slardar")
                lb.Items.Add("Slark")
                lb.Items.Add("Sniper")
                lb.Items.Add("Soul Keeper")
                lb.Items.Add("Spectre")
                lb.Items.Add("Spirit Breaker")
                lb.Items.Add("Storm Spirit")
                lb.Items.Add("Sven")
                lb.Items.Add("Templar Assassin")
                lb.Items.Add("Tidehunter")
                lb.Items.Add("Timbersaw")
                lb.Items.Add("Tinker")
                lb.Items.Add("Tiny")
                lb.Items.Add("Treant Protector")
                lb.Items.Add("Troll Warlord")
                lb.Items.Add("Tusk")
                lb.Items.Add("Undying")
                lb.Items.Add("Ursa")
                lb.Items.Add("Vengeful Spirit")
                lb.Items.Add("Venomancer")
                lb.Items.Add("Viper")
                lb.Items.Add("Visage")
                lb.Items.Add("Warlock")
                lb.Items.Add("Weaver")
                lb.Items.Add("Windranger")
                lb.Items.Add("Winter Wyvern")
                lb.Items.Add("Witch Doctor")
                lb.Items.Add("Zeus")
        End Select
    End Sub

    'Delete all heros which are without an itembuild by valve
    Public Sub ClearNotImplemented()
        With FormMain.ListBox1
            .Items.Remove("Abyssal Underlord")
            .Items.Remove("Arc Warden")
            .Items.Remove("Goblin Techies")
            .Items.Remove("Oracle")
            .Items.Remove("Phoenix")
            .Items.Remove("Soul Keeper")
            .Items.Remove("Winter Wyvern")
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
            Case "Boots of Elvenskin"
                tooltip = "Boots of Elvenskin" + vbNewLine + vbNewLine + "+6 Agility"
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
                tooltip = "Observer Ward" + vbNewLine + vbNewLine + "Place Ward" + vbNewLine + "2 Charges"
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
                tooltip = "Ring of Protection" + vbNewLine + vbNewLine + "+2 Armor"
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
                tooltip = "Sentry Ward" + vbNewLine + vbNewLine + "Place Ward" + vbNewLine + "950 Radius True Sight " + vbNewLine + "2 Charges"
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
            Case "Abyssal Blade"
                Return 6750
            Case "Aghanim's Scepter"
                Return 4200
            Case "Animal Courier"
                Return 150
            Case "Arcane Boots"
                Return 1450
            Case "Armlet"
                Return 2600
            Case "Assault Cuirass"
                Return 5250
            Case "Battle Fury"
                Return 4350
            Case "Belt of Strength"
                Return 450
            Case "Black King Bar"
                Return 3975
            Case "Blade Mail"
                Return 2200
            Case "Blade of Alacrity"
                Return 1000
            Case "Blades of Attack"
                Return 450
            Case "Blink Dagger"
                Return 2150
            Case "Bloodstone"
                Return 5050
            Case "Boots of Elvenskin"
                Return 450
            Case "Boots of Speed"
                Return 450
            Case "Boots of Travel"
                Return 2450
            Case "Bottle"
                Return 650
            Case "Bracer"
                Return 525
            Case "Broadsword"
                Return 1200
            Case "Buckler"
                Return 800
            Case "Butterfly"
                Return 6000
            Case "Chainmail"
                Return 550
            Case "Circlet"
                Return 185
            Case "Clarity"
                Return 50
            Case "Claymore"
                Return 1400
            Case "Cloak"
                Return 550
            Case "Crystalys"
                Return 2150
            Case "Daedalus"
                Return 5550
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
                Return 4100
            Case "Diffusal Blade 1"
                Return 3300
            Case "Diffusal Blade 2"
                Return 3300 + 850
            Case "Divine Rapier"
                Return 6200
            Case "Drum of Endurance"
                Return 1850
            Case "Dust of Appearance"
                Return 180
            Case "Eaglesong"
                Return 3300
            Case "Energy Booster"
                Return 1000
            Case "Ethereal Blade"
                Return 4900
            Case "Eul's Scepter of Divinity"
                Return 2700
            Case "Eye of Skadi"
                Return 5675
            Case "Flying Courier"
                Return 370
            Case "Force Staff"
                Return 2250
            Case "Gauntlets of Strength"
                Return 150
            Case "Gem of True Sight"
                Return 900
            Case "Ghost Scepter"
                Return 1600
            Case "Gloves of Haste"
                Return 500
            Case "Hand of Midas"
                Return 2050
            Case "Headdress"
                Return 600
            Case "Healing Salve"
                Return 115
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
            Case "Maelstrom"
                Return 2700
            Case "Magic Stick"
                Return 200
            Case "Magic Wand"
                Return 500
            Case "Manta Style"
                Return 5050
            Case "Mantle of Intelligence"
                Return 150
            Case "Mask of Madness"
                Return 1900
            Case "Medallion of Courage"
                Return 1075
            Case "Mekansm"
                Return 2300
            Case "Mithril Hammer"
                Return 1600
            Case "Mjollnir"
                Return 5300
            Case "Monkey King Bar"
                Return 5400
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
                Return 1675
            Case "Observer Ward"
                Return 150
            Case "Ogre Club"
                Return 1000
            Case "Orb of Venom"
                Return 275
            Case "Orchid Malevolence"
                Return 4125
            Case "Perseverance"
                Return 1750
            Case "Phase Boots"
                Return 1350
            Case "Pipe of Insight"
                Return 3625
            Case "Platemail"
                Return 1400
            Case "Point Booster"
                Return 1200
            Case "Poor Man's Shield"
                Return 550
            Case "Power Treads"
                Return 1400
            Case "Quarterstaff"
                Return 900
            Case "Quelling Blade"
                Return 225
            Case "Radiance"
                Return 5150
            Case "Reaver"
                Return 3200
            Case "Refresher Orb"
                Return 5225
            Case "Ring of Aquila"
                Return 985
            Case "Ring of Basilius"
                Return 500
            Case "Ring of Health"
                Return 875
            Case "Ring of Protection"
                Return 175
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
                Return 6150
            Case "Scythe of Vyse"
                Return 5675
            Case "Sentry Ward"
                Return 200
            Case "Shadow Blade"
                Return 3000
            Case "Shiva's Guard"
                Return 4700
            Case "Skull Basher"
                Return 2950
            Case "Slippers of Agility"
                Return 150
            Case "Smoke of Deceit"
                Return 100
            Case "Soul Booster"
                Return 3300
            Case "Soul Ring"
                Return 800
            Case "Staff of Wizardry"
                Return 1000
            Case "Stout Shield"
                Return 250
            Case "Talisman of Evasion"
                Return 1800
            Case "Tango"
                Return 125
            Case "Town Portal Scroll"
                Return 135
            Case "Tranquil Boots"
                Return 975
            Case "Ultimate Orb"
                Return 2100
            Case "Urn of Shadows"
                Return 875
            Case "Vanguard"
                Return 2225
            Case "Veil of Discord"
                Return 2670
            Case "Vitality Booster"
                Return 1100
            Case "Vladmir's Offering"
                Return 2050
            Case "Void Stone"
                Return 875
            Case "Wraith Band"
                Return 485
            Case "Yasha"
                Return 2050
            Case "Wraith Band (Recipe)"
                Return 150
            Case "Bracer (Recipe)"
                Return 190
            Case "Null Talisman (Recipe)"
                Return 135
            Case "Magic Wand (Recipe)"
                Return 150
            Case "Hand of Midas (Recipe)"
                Return 1550
            Case "Soul Ring (Recipe)"
                Return 125
            Case "Boots of Travel (Recipe)"
                Return 2000
            Case "Headdress (Recipe)"
                Return 200
            Case "Buckler (Recipe)"
                Return 200
            Case "Urn of Shadows (Recipe)"
                Return 250
            Case "Mekansm (Recipe)"
                Return 900
            Case "Medallion of Courage (Recipe)"
                Return 200
            Case "Vladmir's Offering (Recipe)"
                Return 300
            Case "Pipe of Insight (Recipe)"
                Return 900
            Case "Drum of Endurance (Recipe)"
                Return 875
            Case "Necronomicon (Recipe)"
                Return 1250
            Case "Eul's Scepter of Divinity (Recipe)"
                Return 500
            Case "Dagon (Recipe)"
                Return 1250
            Case "Veil of Discord (Recipe)"
                Return 1250
            Case "Orchid Malevolence (Recipe)"
                Return 775
            Case "Refresher Orb (Recipe)"
                Return 1800
            Case "Force Staff (Recipe)"
                Return 900
            Case "Armlet (Recipe)"
                Return 700
            Case "Crystalys (Recipe)"
                Return 500
            Case "Daedalus (Recipe)"
                Return 1000
            Case "Skull Basher (Recipe)"
                Return 1000
            Case "Radiance (Recipe)"
                Return 1350
            Case "Black King Bar (Recipe)"
                Return 1375
            Case "Assault Cuirass (Recipe)"
                Return 1300
            Case "Manta Style (Recipe)"
                Return 900
            Case "Shiva's Guard (Recipe)"
                Return 600
            Case "Linken's Sphere (Recipe)"
                Return 1325
            Case "Heart of Tarrasque (Recipe)"
                Return 1200
            Case "Desolator (Recipe)"
                Return 900
            Case "Mjollnir (Recipe)"
                Return 600
            Case "Satanic (Recipe)"
                Return 1100
            Case "Yasha (Recipe)"
                Return 600
            Case "Diffusal Blade (Recipe)"
                Return 850
            Case "Sange (Recipe)"
                Return 600
            Case "Mask of Madness (Recipe)"
                Return 1000
            Case "Maelstrom (Recipe)"
                Return 600
            Case "Shadow Amulet"
                Return 1600
            Case Else
                Return 0
        End Select
    End Function

End Class
