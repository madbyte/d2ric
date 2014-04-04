<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ListViewSecretShop = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListViewArcane = New System.Windows.Forms.ListView()
        Me.ListViewArmaments = New System.Windows.Forms.ListView()
        Me.ListViewCommon = New System.Windows.Forms.ListView()
        Me.ListViewArtifacts = New System.Windows.Forms.ListView()
        Me.ListViewAttributes = New System.Windows.Forms.ListView()
        Me.ListViewArmor = New System.Windows.Forms.ListView()
        Me.ListViewSupport = New System.Windows.Forms.ListView()
        Me.ListViewConsumables = New System.Windows.Forms.ListView()
        Me.ListViewCaster = New System.Windows.Forms.ListView()
        Me.Itemslot6 = New System.Windows.Forms.TextBox()
        Me.Itemslot5 = New System.Windows.Forms.TextBox()
        Me.Itemslot4 = New System.Windows.Forms.TextBox()
        Me.Itemslot3 = New System.Windows.Forms.TextBox()
        Me.Itemslot2 = New System.Windows.Forms.TextBox()
        Me.Itemslot1 = New System.Windows.Forms.TextBox()
        Me.ListViewItems5 = New System.Windows.Forms.ListView()
        Me.ListViewItems4 = New System.Windows.Forms.ListView()
        Me.ListViewItems3 = New System.Windows.Forms.ListView()
        Me.ListViewItems2 = New System.Windows.Forms.ListView()
        Me.ListViewItems1 = New System.Windows.Forms.ListView()
        Me.ListViewItems0 = New System.Windows.Forms.ListView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ListViewWeapons = New System.Windows.Forms.ListView()
        Me.ButtonDefaultItembuild = New System.Windows.Forms.Button()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ButtonOpenFolder = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ButtonOpenTextfile = New System.Windows.Forms.Button()
        Me.ButtonImport = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ButtonSaveTextfile = New System.Windows.Forms.Button()
        Me.ButtonCopy = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ComboBoxLang = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ButtonOpenBackupFolder = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonBackup = New System.Windows.Forms.Button()
        Me.ButtonDeleteBackup = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.LabelWait = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AllowDrop = True
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.ListViewSecretShop)
        Me.TabPage1.Controls.Add(Me.ListViewArcane)
        Me.TabPage1.Controls.Add(Me.ListViewArmaments)
        Me.TabPage1.Controls.Add(Me.ListViewCommon)
        Me.TabPage1.Controls.Add(Me.ListViewArtifacts)
        Me.TabPage1.Controls.Add(Me.ListViewAttributes)
        Me.TabPage1.Controls.Add(Me.ListViewArmor)
        Me.TabPage1.Controls.Add(Me.ListViewSupport)
        Me.TabPage1.Controls.Add(Me.ListViewConsumables)
        Me.TabPage1.Controls.Add(Me.ListViewCaster)
        Me.TabPage1.Controls.Add(Me.Itemslot6)
        Me.TabPage1.Controls.Add(Me.Itemslot5)
        Me.TabPage1.Controls.Add(Me.Itemslot4)
        Me.TabPage1.Controls.Add(Me.Itemslot3)
        Me.TabPage1.Controls.Add(Me.Itemslot2)
        Me.TabPage1.Controls.Add(Me.Itemslot1)
        Me.TabPage1.Controls.Add(Me.ListViewItems5)
        Me.TabPage1.Controls.Add(Me.ListViewItems4)
        Me.TabPage1.Controls.Add(Me.ListViewItems3)
        Me.TabPage1.Controls.Add(Me.ListViewItems2)
        Me.TabPage1.Controls.Add(Me.ListViewItems1)
        Me.TabPage1.Controls.Add(Me.ListViewItems0)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.ListViewWeapons)
        Me.TabPage1.Controls.Add(Me.ButtonDefaultItembuild)
        Me.TabPage1.Controls.Add(Me.Label0)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.ButtonOpenFolder)
        Me.TabPage1.Controls.Add(Me.ButtonSave)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'CheckBox1
        '
        resources.ApplyResources(Me.CheckBox1, "CheckBox1")
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ListViewSecretShop
        '
        resources.ApplyResources(Me.ListViewSecretShop, "ListViewSecretShop")
        Me.ListViewSecretShop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewSecretShop.LargeImageList = Me.ImageList1
        Me.ListViewSecretShop.MultiSelect = False
        Me.ListViewSecretShop.Name = "ListViewSecretShop"
        Me.ListViewSecretShop.ShowGroups = False
        Me.ListViewSecretShop.ShowItemToolTips = True
        Me.ListViewSecretShop.SmallImageList = Me.ImageList1
        Me.ListViewSecretShop.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewSecretShop.UseCompatibleStateImageBehavior = False
        Me.ListViewSecretShop.View = System.Windows.Forms.View.Tile
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "40px-Abyssal_Blade.png")
        Me.ImageList1.Images.SetKeyName(1, "40px-Aghanim's_Scepter.png")
        Me.ImageList1.Images.SetKeyName(2, "40px-Animal_Courier_(Radiant).png")
        Me.ImageList1.Images.SetKeyName(3, "40px-Arcane_Boots.png")
        Me.ImageList1.Images.SetKeyName(4, "40px-Armlet_of_Mordiggian.png")
        Me.ImageList1.Images.SetKeyName(5, "40px-Assault_Cuirass.png")
        Me.ImageList1.Images.SetKeyName(6, "40px-Battle_Fury.png")
        Me.ImageList1.Images.SetKeyName(7, "40px-Belt_of_Strength.png")
        Me.ImageList1.Images.SetKeyName(8, "40px-Black_King_Bar.png")
        Me.ImageList1.Images.SetKeyName(9, "40px-Blade_Mail.png")
        Me.ImageList1.Images.SetKeyName(10, "40px-Blade_of_Alacrity.png")
        Me.ImageList1.Images.SetKeyName(11, "40px-Blades_of_Attack.png")
        Me.ImageList1.Images.SetKeyName(12, "40px-Blink_Dagger.png")
        Me.ImageList1.Images.SetKeyName(13, "40px-Bloodstone.png")
        Me.ImageList1.Images.SetKeyName(14, "40px-Band_of_Elvenskin.png")
        Me.ImageList1.Images.SetKeyName(15, "40px-Boots_of_Speed.png")
        Me.ImageList1.Images.SetKeyName(16, "40px-Boots_of_Travel.png")
        Me.ImageList1.Images.SetKeyName(17, "40px-Bottle.png")
        Me.ImageList1.Images.SetKeyName(18, "40px-Bracer.png")
        Me.ImageList1.Images.SetKeyName(19, "40px-Broadsword.png")
        Me.ImageList1.Images.SetKeyName(20, "40px-Buckler.png")
        Me.ImageList1.Images.SetKeyName(21, "40px-Butterfly.png")
        Me.ImageList1.Images.SetKeyName(22, "40px-Chainmail.png")
        Me.ImageList1.Images.SetKeyName(23, "40px-Circlet.png")
        Me.ImageList1.Images.SetKeyName(24, "40px-Clarity.png")
        Me.ImageList1.Images.SetKeyName(25, "40px-Claymore.png")
        Me.ImageList1.Images.SetKeyName(26, "40px-Cloak.png")
        Me.ImageList1.Images.SetKeyName(27, "40px-Crystalys.png")
        Me.ImageList1.Images.SetKeyName(28, "40px-Daedalus.png")
        Me.ImageList1.Images.SetKeyName(29, "40px-Dagon.png")
        Me.ImageList1.Images.SetKeyName(30, "40px-Dagon2.png")
        Me.ImageList1.Images.SetKeyName(31, "40px-Dagon3.png")
        Me.ImageList1.Images.SetKeyName(32, "40px-Dagon4.png")
        Me.ImageList1.Images.SetKeyName(33, "40px-Dagon5.png")
        Me.ImageList1.Images.SetKeyName(34, "40px-Demon_Edge.png")
        Me.ImageList1.Images.SetKeyName(35, "40px-Desolator.png")
        Me.ImageList1.Images.SetKeyName(36, "40px-Diffusal_Blade.png")
        Me.ImageList1.Images.SetKeyName(37, "40px-Diffusal_Blade2.png")
        Me.ImageList1.Images.SetKeyName(38, "40px-Divine_Rapier.png")
        Me.ImageList1.Images.SetKeyName(39, "40px-Drum_of_Endurance.png")
        Me.ImageList1.Images.SetKeyName(40, "40px-Dust_of_Appearance.png")
        Me.ImageList1.Images.SetKeyName(41, "40px-Eaglesong.png")
        Me.ImageList1.Images.SetKeyName(42, "40px-Energy_Booster.png")
        Me.ImageList1.Images.SetKeyName(43, "40px-Ethereal_Blade.png")
        Me.ImageList1.Images.SetKeyName(44, "40px-Eul's_Scepter_of_Divinity.png")
        Me.ImageList1.Images.SetKeyName(45, "40px-Eye_of_Skadi.png")
        Me.ImageList1.Images.SetKeyName(46, "40px-Flying_Courier_(Radiant).png")
        Me.ImageList1.Images.SetKeyName(47, "40px-Force_Staff.png")
        Me.ImageList1.Images.SetKeyName(48, "40px-Gauntlets_of_Strength.png")
        Me.ImageList1.Images.SetKeyName(49, "40px-Gem_of_True_Sight.png")
        Me.ImageList1.Images.SetKeyName(50, "40px-Ghost_Scepter.png")
        Me.ImageList1.Images.SetKeyName(51, "40px-Gloves_of_Haste.png")
        Me.ImageList1.Images.SetKeyName(52, "40px-Hand_of_Midas.png")
        Me.ImageList1.Images.SetKeyName(53, "40px-Headdress.png")
        Me.ImageList1.Images.SetKeyName(54, "40px-Healing_Salve.png")
        Me.ImageList1.Images.SetKeyName(55, "40px-Heart_of_Tarrasque.png")
        Me.ImageList1.Images.SetKeyName(56, "40px-Heaven's_Halberd.png")
        Me.ImageList1.Images.SetKeyName(57, "40px-Helm_of_Iron_Will.png")
        Me.ImageList1.Images.SetKeyName(58, "40px-Helm_of_the_Dominator.png")
        Me.ImageList1.Images.SetKeyName(59, "40px-Hood_of_Defiance.png")
        Me.ImageList1.Images.SetKeyName(60, "40px-Hyperstone.png")
        Me.ImageList1.Images.SetKeyName(61, "40px-Iron_Branch.png")
        Me.ImageList1.Images.SetKeyName(62, "40px-Javelin.png")
        Me.ImageList1.Images.SetKeyName(63, "40px-Linken's_Sphere.png")
        Me.ImageList1.Images.SetKeyName(64, "40px-Maelstrom.png")
        Me.ImageList1.Images.SetKeyName(65, "40px-Magic_Stick.png")
        Me.ImageList1.Images.SetKeyName(66, "40px-Magic_Wand.png")
        Me.ImageList1.Images.SetKeyName(67, "40px-Manta_Style.png")
        Me.ImageList1.Images.SetKeyName(68, "40px-Mantle_of_Intelligence.png")
        Me.ImageList1.Images.SetKeyName(69, "40px-Mask_of_Madness.png")
        Me.ImageList1.Images.SetKeyName(70, "40px-Medallion_of_Courage.png")
        Me.ImageList1.Images.SetKeyName(71, "40px-Mekansm.png")
        Me.ImageList1.Images.SetKeyName(72, "40px-Mithril_Hammer.png")
        Me.ImageList1.Images.SetKeyName(73, "40px-Mjollnir.png")
        Me.ImageList1.Images.SetKeyName(74, "40px-Monkey_King_Bar.png")
        Me.ImageList1.Images.SetKeyName(75, "40px-Morbid_Mask.png")
        Me.ImageList1.Images.SetKeyName(76, "40px-Mystic_Staff.png")
        Me.ImageList1.Images.SetKeyName(77, "40px-Necronomicon.png")
        Me.ImageList1.Images.SetKeyName(78, "40px-Necronomicon2.png")
        Me.ImageList1.Images.SetKeyName(79, "40px-Necronomicon3.png")
        Me.ImageList1.Images.SetKeyName(80, "40px-Null_Talisman.png")
        Me.ImageList1.Images.SetKeyName(81, "40px-Oblivion_Staff.png")
        Me.ImageList1.Images.SetKeyName(82, "40px-Observer_Ward.png")
        Me.ImageList1.Images.SetKeyName(83, "40px-Ogre_Club.png")
        Me.ImageList1.Images.SetKeyName(84, "40px-Orb_of_Venom.png")
        Me.ImageList1.Images.SetKeyName(85, "40px-Orchid_Malevolence.png")
        Me.ImageList1.Images.SetKeyName(86, "40px-Perseverance.png")
        Me.ImageList1.Images.SetKeyName(87, "40px-Phase_Boots.png")
        Me.ImageList1.Images.SetKeyName(88, "40px-Pipe_of_Insight.png")
        Me.ImageList1.Images.SetKeyName(89, "40px-Platemail.png")
        Me.ImageList1.Images.SetKeyName(90, "40px-Point_Booster.png")
        Me.ImageList1.Images.SetKeyName(91, "40px-Poor_Man's_Shield.png")
        Me.ImageList1.Images.SetKeyName(92, "40px-Power_Treads.png")
        Me.ImageList1.Images.SetKeyName(93, "40px-Quarterstaff.png")
        Me.ImageList1.Images.SetKeyName(94, "40px-Quelling_Blade.png")
        Me.ImageList1.Images.SetKeyName(95, "40px-Radiance.png")
        Me.ImageList1.Images.SetKeyName(96, "40px-Reaver.png")
        Me.ImageList1.Images.SetKeyName(97, "40px-Refresher_Orb.png")
        Me.ImageList1.Images.SetKeyName(98, "40px-Ring_of_Aquila.png")
        Me.ImageList1.Images.SetKeyName(99, "40px-Ring_of_Basilius.png")
        Me.ImageList1.Images.SetKeyName(100, "40px-Ring_of_Health.png")
        Me.ImageList1.Images.SetKeyName(101, "40px-Ring_of_Protection.png")
        Me.ImageList1.Images.SetKeyName(102, "40px-Ring_of_Regen.png")
        Me.ImageList1.Images.SetKeyName(103, "40px-Robe_of_the_Magi.png")
        Me.ImageList1.Images.SetKeyName(104, "40px-Rod_of_Atos.png")
        Me.ImageList1.Images.SetKeyName(105, "40px-Sacred_Relic.png")
        Me.ImageList1.Images.SetKeyName(106, "40px-Sage's_Mask.png")
        Me.ImageList1.Images.SetKeyName(107, "40px-Sange.png")
        Me.ImageList1.Images.SetKeyName(108, "40px-Sange_and_Yasha.png")
        Me.ImageList1.Images.SetKeyName(109, "40px-Satanic.png")
        Me.ImageList1.Images.SetKeyName(110, "40px-Scythe_of_Vyse.png")
        Me.ImageList1.Images.SetKeyName(111, "40px-Sentry_Ward.png")
        Me.ImageList1.Images.SetKeyName(112, "40px-Shadow_Blade.png")
        Me.ImageList1.Images.SetKeyName(113, "40px-Shiva's_Guard.png")
        Me.ImageList1.Images.SetKeyName(114, "40px-Skull_Basher.png")
        Me.ImageList1.Images.SetKeyName(115, "40px-Slippers_of_Agility.png")
        Me.ImageList1.Images.SetKeyName(116, "40px-Smoke_of_Deceit.png")
        Me.ImageList1.Images.SetKeyName(117, "40px-Soul_Booster.png")
        Me.ImageList1.Images.SetKeyName(118, "40px-Soul_Ring.png")
        Me.ImageList1.Images.SetKeyName(119, "40px-Staff_of_Wizardry.png")
        Me.ImageList1.Images.SetKeyName(120, "40px-Stout_Shield.png")
        Me.ImageList1.Images.SetKeyName(121, "40px-Talisman_of_Evasion.png")
        Me.ImageList1.Images.SetKeyName(122, "40px-Tango.png")
        Me.ImageList1.Images.SetKeyName(123, "40px-Town_Portal_Scroll.png")
        Me.ImageList1.Images.SetKeyName(124, "40px-Tranquil_Boots.png")
        Me.ImageList1.Images.SetKeyName(125, "40px-Ultimate_Orb.png")
        Me.ImageList1.Images.SetKeyName(126, "40px-Urn_of_Shadows.png")
        Me.ImageList1.Images.SetKeyName(127, "40px-Vanguard.png")
        Me.ImageList1.Images.SetKeyName(128, "40px-Veil_of_Discord.png")
        Me.ImageList1.Images.SetKeyName(129, "40px-Vitality_Booster.png")
        Me.ImageList1.Images.SetKeyName(130, "40px-Vladmir's_Offering.png")
        Me.ImageList1.Images.SetKeyName(131, "40px-Void_Stone.png")
        Me.ImageList1.Images.SetKeyName(132, "40px-Wraith_Band.png")
        Me.ImageList1.Images.SetKeyName(133, "40px-Yasha.png")
        Me.ImageList1.Images.SetKeyName(134, "Recipe_Scroll.png")
        Me.ImageList1.Images.SetKeyName(135, "40px-Shadow_Amulet.png")
        '
        'ListViewArcane
        '
        resources.ApplyResources(Me.ListViewArcane, "ListViewArcane")
        Me.ListViewArcane.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewArcane.LargeImageList = Me.ImageList1
        Me.ListViewArcane.MultiSelect = False
        Me.ListViewArcane.Name = "ListViewArcane"
        Me.ListViewArcane.ShowGroups = False
        Me.ListViewArcane.ShowItemToolTips = True
        Me.ListViewArcane.SmallImageList = Me.ImageList1
        Me.ListViewArcane.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewArcane.UseCompatibleStateImageBehavior = False
        Me.ListViewArcane.View = System.Windows.Forms.View.Tile
        '
        'ListViewArmaments
        '
        resources.ApplyResources(Me.ListViewArmaments, "ListViewArmaments")
        Me.ListViewArmaments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewArmaments.LargeImageList = Me.ImageList1
        Me.ListViewArmaments.MultiSelect = False
        Me.ListViewArmaments.Name = "ListViewArmaments"
        Me.ListViewArmaments.ShowGroups = False
        Me.ListViewArmaments.ShowItemToolTips = True
        Me.ListViewArmaments.SmallImageList = Me.ImageList1
        Me.ListViewArmaments.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewArmaments.UseCompatibleStateImageBehavior = False
        Me.ListViewArmaments.View = System.Windows.Forms.View.Tile
        '
        'ListViewCommon
        '
        resources.ApplyResources(Me.ListViewCommon, "ListViewCommon")
        Me.ListViewCommon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewCommon.LargeImageList = Me.ImageList1
        Me.ListViewCommon.MultiSelect = False
        Me.ListViewCommon.Name = "ListViewCommon"
        Me.ListViewCommon.ShowGroups = False
        Me.ListViewCommon.ShowItemToolTips = True
        Me.ListViewCommon.SmallImageList = Me.ImageList1
        Me.ListViewCommon.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewCommon.UseCompatibleStateImageBehavior = False
        Me.ListViewCommon.View = System.Windows.Forms.View.Tile
        '
        'ListViewArtifacts
        '
        resources.ApplyResources(Me.ListViewArtifacts, "ListViewArtifacts")
        Me.ListViewArtifacts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewArtifacts.LargeImageList = Me.ImageList1
        Me.ListViewArtifacts.MultiSelect = False
        Me.ListViewArtifacts.Name = "ListViewArtifacts"
        Me.ListViewArtifacts.ShowGroups = False
        Me.ListViewArtifacts.ShowItemToolTips = True
        Me.ListViewArtifacts.SmallImageList = Me.ImageList1
        Me.ListViewArtifacts.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewArtifacts.UseCompatibleStateImageBehavior = False
        Me.ListViewArtifacts.View = System.Windows.Forms.View.Tile
        '
        'ListViewAttributes
        '
        resources.ApplyResources(Me.ListViewAttributes, "ListViewAttributes")
        Me.ListViewAttributes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewAttributes.LargeImageList = Me.ImageList1
        Me.ListViewAttributes.MultiSelect = False
        Me.ListViewAttributes.Name = "ListViewAttributes"
        Me.ListViewAttributes.ShowGroups = False
        Me.ListViewAttributes.ShowItemToolTips = True
        Me.ListViewAttributes.SmallImageList = Me.ImageList1
        Me.ListViewAttributes.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewAttributes.UseCompatibleStateImageBehavior = False
        Me.ListViewAttributes.View = System.Windows.Forms.View.Tile
        '
        'ListViewArmor
        '
        resources.ApplyResources(Me.ListViewArmor, "ListViewArmor")
        Me.ListViewArmor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewArmor.LargeImageList = Me.ImageList1
        Me.ListViewArmor.MultiSelect = False
        Me.ListViewArmor.Name = "ListViewArmor"
        Me.ListViewArmor.ShowGroups = False
        Me.ListViewArmor.ShowItemToolTips = True
        Me.ListViewArmor.SmallImageList = Me.ImageList1
        Me.ListViewArmor.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewArmor.UseCompatibleStateImageBehavior = False
        Me.ListViewArmor.View = System.Windows.Forms.View.Tile
        '
        'ListViewSupport
        '
        resources.ApplyResources(Me.ListViewSupport, "ListViewSupport")
        Me.ListViewSupport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewSupport.LargeImageList = Me.ImageList1
        Me.ListViewSupport.MultiSelect = False
        Me.ListViewSupport.Name = "ListViewSupport"
        Me.ListViewSupport.ShowGroups = False
        Me.ListViewSupport.ShowItemToolTips = True
        Me.ListViewSupport.SmallImageList = Me.ImageList1
        Me.ListViewSupport.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewSupport.UseCompatibleStateImageBehavior = False
        Me.ListViewSupport.View = System.Windows.Forms.View.Tile
        '
        'ListViewConsumables
        '
        resources.ApplyResources(Me.ListViewConsumables, "ListViewConsumables")
        Me.ListViewConsumables.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewConsumables.LargeImageList = Me.ImageList1
        Me.ListViewConsumables.MultiSelect = False
        Me.ListViewConsumables.Name = "ListViewConsumables"
        Me.ListViewConsumables.ShowGroups = False
        Me.ListViewConsumables.ShowItemToolTips = True
        Me.ListViewConsumables.SmallImageList = Me.ImageList1
        Me.ListViewConsumables.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewConsumables.UseCompatibleStateImageBehavior = False
        Me.ListViewConsumables.View = System.Windows.Forms.View.Tile
        '
        'ListViewCaster
        '
        resources.ApplyResources(Me.ListViewCaster, "ListViewCaster")
        Me.ListViewCaster.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewCaster.LargeImageList = Me.ImageList1
        Me.ListViewCaster.MultiSelect = False
        Me.ListViewCaster.Name = "ListViewCaster"
        Me.ListViewCaster.ShowGroups = False
        Me.ListViewCaster.ShowItemToolTips = True
        Me.ListViewCaster.SmallImageList = Me.ImageList1
        Me.ListViewCaster.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewCaster.UseCompatibleStateImageBehavior = False
        Me.ListViewCaster.View = System.Windows.Forms.View.Tile
        '
        'Itemslot6
        '
        resources.ApplyResources(Me.Itemslot6, "Itemslot6")
        Me.Itemslot6.Name = "Itemslot6"
        '
        'Itemslot5
        '
        resources.ApplyResources(Me.Itemslot5, "Itemslot5")
        Me.Itemslot5.Name = "Itemslot5"
        '
        'Itemslot4
        '
        resources.ApplyResources(Me.Itemslot4, "Itemslot4")
        Me.Itemslot4.Name = "Itemslot4"
        '
        'Itemslot3
        '
        resources.ApplyResources(Me.Itemslot3, "Itemslot3")
        Me.Itemslot3.Name = "Itemslot3"
        '
        'Itemslot2
        '
        resources.ApplyResources(Me.Itemslot2, "Itemslot2")
        Me.Itemslot2.Name = "Itemslot2"
        '
        'Itemslot1
        '
        resources.ApplyResources(Me.Itemslot1, "Itemslot1")
        Me.Itemslot1.Name = "Itemslot1"
        '
        'ListViewItems5
        '
        Me.ListViewItems5.LargeImageList = Me.ImageList1
        resources.ApplyResources(Me.ListViewItems5, "ListViewItems5")
        Me.ListViewItems5.MultiSelect = False
        Me.ListViewItems5.Name = "ListViewItems5"
        Me.ListViewItems5.ShowGroups = False
        Me.ListViewItems5.ShowItemToolTips = True
        Me.ListViewItems5.SmallImageList = Me.ImageList1
        Me.ListViewItems5.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewItems5.UseCompatibleStateImageBehavior = False
        Me.ListViewItems5.View = System.Windows.Forms.View.Tile
        '
        'ListViewItems4
        '
        Me.ListViewItems4.LargeImageList = Me.ImageList1
        resources.ApplyResources(Me.ListViewItems4, "ListViewItems4")
        Me.ListViewItems4.MultiSelect = False
        Me.ListViewItems4.Name = "ListViewItems4"
        Me.ListViewItems4.ShowGroups = False
        Me.ListViewItems4.ShowItemToolTips = True
        Me.ListViewItems4.SmallImageList = Me.ImageList1
        Me.ListViewItems4.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewItems4.UseCompatibleStateImageBehavior = False
        Me.ListViewItems4.View = System.Windows.Forms.View.Tile
        '
        'ListViewItems3
        '
        Me.ListViewItems3.LargeImageList = Me.ImageList1
        resources.ApplyResources(Me.ListViewItems3, "ListViewItems3")
        Me.ListViewItems3.MultiSelect = False
        Me.ListViewItems3.Name = "ListViewItems3"
        Me.ListViewItems3.ShowGroups = False
        Me.ListViewItems3.ShowItemToolTips = True
        Me.ListViewItems3.SmallImageList = Me.ImageList1
        Me.ListViewItems3.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewItems3.UseCompatibleStateImageBehavior = False
        Me.ListViewItems3.View = System.Windows.Forms.View.Tile
        '
        'ListViewItems2
        '
        Me.ListViewItems2.LargeImageList = Me.ImageList1
        resources.ApplyResources(Me.ListViewItems2, "ListViewItems2")
        Me.ListViewItems2.MultiSelect = False
        Me.ListViewItems2.Name = "ListViewItems2"
        Me.ListViewItems2.ShowGroups = False
        Me.ListViewItems2.ShowItemToolTips = True
        Me.ListViewItems2.SmallImageList = Me.ImageList1
        Me.ListViewItems2.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewItems2.UseCompatibleStateImageBehavior = False
        Me.ListViewItems2.View = System.Windows.Forms.View.Tile
        '
        'ListViewItems1
        '
        Me.ListViewItems1.LargeImageList = Me.ImageList1
        resources.ApplyResources(Me.ListViewItems1, "ListViewItems1")
        Me.ListViewItems1.MultiSelect = False
        Me.ListViewItems1.Name = "ListViewItems1"
        Me.ListViewItems1.ShowGroups = False
        Me.ListViewItems1.ShowItemToolTips = True
        Me.ListViewItems1.SmallImageList = Me.ImageList1
        Me.ListViewItems1.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewItems1.UseCompatibleStateImageBehavior = False
        Me.ListViewItems1.View = System.Windows.Forms.View.Tile
        '
        'ListViewItems0
        '
        Me.ListViewItems0.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewItems0.LargeImageList = Me.ImageList1
        resources.ApplyResources(Me.ListViewItems0, "ListViewItems0")
        Me.ListViewItems0.MultiSelect = False
        Me.ListViewItems0.Name = "ListViewItems0"
        Me.ListViewItems0.ShowGroups = False
        Me.ListViewItems0.ShowItemToolTips = True
        Me.ListViewItems0.SmallImageList = Me.ImageList1
        Me.ListViewItems0.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewItems0.UseCompatibleStateImageBehavior = False
        Me.ListViewItems0.View = System.Windows.Forms.View.Tile
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'ListViewWeapons
        '
        resources.ApplyResources(Me.ListViewWeapons, "ListViewWeapons")
        Me.ListViewWeapons.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewWeapons.LargeImageList = Me.ImageList1
        Me.ListViewWeapons.MultiSelect = False
        Me.ListViewWeapons.Name = "ListViewWeapons"
        Me.ListViewWeapons.ShowGroups = False
        Me.ListViewWeapons.ShowItemToolTips = True
        Me.ListViewWeapons.SmallImageList = Me.ImageList1
        Me.ListViewWeapons.TileSize = New System.Drawing.Size(44, 34)
        Me.ListViewWeapons.UseCompatibleStateImageBehavior = False
        Me.ListViewWeapons.View = System.Windows.Forms.View.Tile
        '
        'ButtonDefaultItembuild
        '
        resources.ApplyResources(Me.ButtonDefaultItembuild, "ButtonDefaultItembuild")
        Me.ButtonDefaultItembuild.Name = "ButtonDefaultItembuild"
        Me.ButtonDefaultItembuild.UseVisualStyleBackColor = True
        '
        'Label0
        '
        resources.ApplyResources(Me.Label0, "Label0")
        Me.Label0.Name = "Label0"
        '
        'ListBox1
        '
        resources.ApplyResources(Me.ListBox1, "ListBox1")
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {resources.GetString("ListBox1.Items")})
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Sorted = True
        '
        'ButtonOpenFolder
        '
        resources.ApplyResources(Me.ButtonOpenFolder, "ButtonOpenFolder")
        Me.ButtonOpenFolder.Name = "ButtonOpenFolder"
        Me.ButtonOpenFolder.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        resources.ApplyResources(Me.ButtonSave, "ButtonSave")
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ButtonOpenTextfile)
        Me.TabPage3.Controls.Add(Me.ButtonImport)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ButtonOpenTextfile
        '
        resources.ApplyResources(Me.ButtonOpenTextfile, "ButtonOpenTextfile")
        Me.ButtonOpenTextfile.Name = "ButtonOpenTextfile"
        Me.ButtonOpenTextfile.UseVisualStyleBackColor = True
        '
        'ButtonImport
        '
        resources.ApplyResources(Me.ButtonImport, "ButtonImport")
        Me.ButtonImport.Name = "ButtonImport"
        Me.ButtonImport.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.Name = "TextBox2"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ButtonSaveTextfile)
        Me.TabPage4.Controls.Add(Me.ButtonCopy)
        Me.TabPage4.Controls.Add(Me.TextBox3)
        resources.ApplyResources(Me.TabPage4, "TabPage4")
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ButtonSaveTextfile
        '
        resources.ApplyResources(Me.ButtonSaveTextfile, "ButtonSaveTextfile")
        Me.ButtonSaveTextfile.Name = "ButtonSaveTextfile"
        Me.ButtonSaveTextfile.UseVisualStyleBackColor = True
        '
        'ButtonCopy
        '
        resources.ApplyResources(Me.ButtonCopy, "ButtonCopy")
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        resources.ApplyResources(Me.TextBox3, "TextBox3")
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ComboBoxLang)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Controls.Add(Me.ButtonOpenBackupFolder)
        Me.TabPage5.Controls.Add(Me.Label9)
        Me.TabPage5.Controls.Add(Me.Label7)
        Me.TabPage5.Controls.Add(Me.ButtonBackup)
        Me.TabPage5.Controls.Add(Me.ButtonDeleteBackup)
        resources.ApplyResources(Me.TabPage5, "TabPage5")
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ComboBoxLang
        '
        Me.ComboBoxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.ComboBoxLang, "ComboBoxLang")
        Me.ComboBoxLang.FormattingEnabled = True
        Me.ComboBoxLang.Items.AddRange(New Object() {resources.GetString("ComboBoxLang.Items"), resources.GetString("ComboBoxLang.Items1"), resources.GetString("ComboBoxLang.Items2"), resources.GetString("ComboBoxLang.Items3")})
        Me.ComboBoxLang.Name = "ComboBoxLang"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'ButtonOpenBackupFolder
        '
        resources.ApplyResources(Me.ButtonOpenBackupFolder, "ButtonOpenBackupFolder")
        Me.ButtonOpenBackupFolder.Name = "ButtonOpenBackupFolder"
        Me.ButtonOpenBackupFolder.UseVisualStyleBackColor = True
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'ButtonBackup
        '
        resources.ApplyResources(Me.ButtonBackup, "ButtonBackup")
        Me.ButtonBackup.Name = "ButtonBackup"
        Me.ButtonBackup.UseVisualStyleBackColor = True
        '
        'ButtonDeleteBackup
        '
        resources.ApplyResources(Me.ButtonDeleteBackup, "ButtonDeleteBackup")
        Me.ButtonDeleteBackup.Name = "ButtonDeleteBackup"
        Me.ButtonDeleteBackup.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        resources.ApplyResources(Me.ButtonUpdate, "ButtonUpdate")
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'LabelWait
        '
        resources.ApplyResources(Me.LabelWait, "LabelWait")
        Me.LabelWait.ForeColor = System.Drawing.Color.Red
        Me.LabelWait.Name = "LabelWait"
        '
        'FormMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.LabelWait)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormMain"
        Me.ShowIcon = False
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label0 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ButtonOpenFolder As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonOpenTextfile As System.Windows.Forms.Button
    Friend WithEvents ButtonImport As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSaveTextfile As System.Windows.Forms.Button
    Friend WithEvents ButtonCopy As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonBackup As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteBackup As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonOpenBackupFolder As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents LabelWait As System.Windows.Forms.Label
    Friend WithEvents ButtonDefaultItembuild As System.Windows.Forms.Button
    Friend WithEvents ListViewWeapons As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ListViewItems0 As System.Windows.Forms.ListView
    Friend WithEvents ListViewItems1 As System.Windows.Forms.ListView
    Friend WithEvents ListViewItems3 As System.Windows.Forms.ListView
    Friend WithEvents ListViewItems2 As System.Windows.Forms.ListView
    Friend WithEvents ListViewItems5 As System.Windows.Forms.ListView
    Friend WithEvents ListViewItems4 As System.Windows.Forms.ListView
    Friend WithEvents ComboBoxLang As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Itemslot6 As System.Windows.Forms.TextBox
    Friend WithEvents Itemslot5 As System.Windows.Forms.TextBox
    Friend WithEvents Itemslot4 As System.Windows.Forms.TextBox
    Friend WithEvents Itemslot3 As System.Windows.Forms.TextBox
    Friend WithEvents Itemslot2 As System.Windows.Forms.TextBox
    Friend WithEvents Itemslot1 As System.Windows.Forms.TextBox
    Friend WithEvents ListViewCaster As System.Windows.Forms.ListView
    Friend WithEvents ListViewAttributes As System.Windows.Forms.ListView
    Friend WithEvents ListViewArmor As System.Windows.Forms.ListView
    Friend WithEvents ListViewSupport As System.Windows.Forms.ListView
    Friend WithEvents ListViewConsumables As System.Windows.Forms.ListView
    Friend WithEvents ListViewSecretShop As System.Windows.Forms.ListView
    Friend WithEvents ListViewArcane As System.Windows.Forms.ListView
    Friend WithEvents ListViewArmaments As System.Windows.Forms.ListView
    Friend WithEvents ListViewCommon As System.Windows.Forms.ListView
    Friend WithEvents ListViewArtifacts As System.Windows.Forms.ListView
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
