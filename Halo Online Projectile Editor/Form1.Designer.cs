namespace HaloOnlineTrainer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vehicleTurretLabel = new System.Windows.Forms.Label();
            this.vehicleTurretCombo = new System.Windows.Forms.ComboBox();
            this.mapCheck = new System.Windows.Forms.CheckBox();
            this.propCombo = new System.Windows.Forms.ComboBox();
            this.propLabel = new System.Windows.Forms.Label();
            this.armorLabel = new System.Windows.Forms.Label();
            this.armorCombo = new System.Windows.Forms.ComboBox();
            this.vehiclesLabel = new System.Windows.Forms.Label();
            this.vehiclesCombo = new System.Windows.Forms.ComboBox();
            this.miscLabel = new System.Windows.Forms.Label();
            this.miscCombo = new System.Windows.Forms.ComboBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.projectileLabel = new System.Windows.Forms.Label();
            this.weaponsCombo = new System.Windows.Forms.ComboBox();
            this.projectileCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.godCheck = new System.Windows.Forms.CheckBox();
            this.ammoCheck = new System.Windows.Forms.CheckBox();
            this.grenadeCheck = new System.Windows.Forms.CheckBox();
            this.fireRateCheck = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jumpCheck = new System.Windows.Forms.CheckBox();
            this.jumpTrackbar = new System.Windows.Forms.TrackBar();
            this.spawnCombo = new System.Windows.Forms.ComboBox();
            this.spawnLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jumpTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.spawnLabel);
            this.groupBox2.Controls.Add(this.spawnCombo);
            this.groupBox2.Controls.Add(this.vehicleTurretLabel);
            this.groupBox2.Controls.Add(this.vehicleTurretCombo);
            this.groupBox2.Controls.Add(this.mapCheck);
            this.groupBox2.Controls.Add(this.propCombo);
            this.groupBox2.Controls.Add(this.propLabel);
            this.groupBox2.Controls.Add(this.armorLabel);
            this.groupBox2.Controls.Add(this.armorCombo);
            this.groupBox2.Controls.Add(this.vehiclesLabel);
            this.groupBox2.Controls.Add(this.vehiclesCombo);
            this.groupBox2.Controls.Add(this.miscLabel);
            this.groupBox2.Controls.Add(this.miscCombo);
            this.groupBox2.Controls.Add(this.selectLabel);
            this.groupBox2.Controls.Add(this.weaponLabel);
            this.groupBox2.Controls.Add(this.projectileLabel);
            this.groupBox2.Controls.Add(this.weaponsCombo);
            this.groupBox2.Controls.Add(this.projectileCombo);
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 336);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Projectile Selector";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // vehicleTurretLabel
            // 
            this.vehicleTurretLabel.AutoSize = true;
            this.vehicleTurretLabel.Enabled = false;
            this.vehicleTurretLabel.Location = new System.Drawing.Point(134, 211);
            this.vehicleTurretLabel.Name = "vehicleTurretLabel";
            this.vehicleTurretLabel.Size = new System.Drawing.Size(35, 13);
            this.vehicleTurretLabel.TabIndex = 15;
            this.vehicleTurretLabel.Text = "Turret";
            this.vehicleTurretLabel.Click += new System.EventHandler(this.vehicleTurretLabel_Click);
            // 
            // vehicleTurretCombo
            // 
            this.vehicleTurretCombo.Enabled = false;
            this.vehicleTurretCombo.FormattingEnabled = true;
            this.vehicleTurretCombo.Items.AddRange(new object[] {
            "Warthog (Chaingun)",
            "Warthog (Gauss Rifle)",
            "Warthog (Chaingun Snow)",
            "Warthog (Gauss Rifle Snow)",
            "Wraith (Mortar)",
            "Wraith (Anti-infantry)",
            "Wraith (Anti-Air)",
            "Wraith (Anti-Infantry + Air)",
            "Scorpion Cannon"});
            this.vehicleTurretCombo.Location = new System.Drawing.Point(137, 227);
            this.vehicleTurretCombo.Name = "vehicleTurretCombo";
            this.vehicleTurretCombo.Size = new System.Drawing.Size(106, 21);
            this.vehicleTurretCombo.TabIndex = 14;
            this.vehicleTurretCombo.SelectedIndexChanged += new System.EventHandler(this.vehicleTurretCombo_SelectedIndexChanged);
            // 
            // mapCheck
            // 
            this.mapCheck.AutoSize = true;
            this.mapCheck.Location = new System.Drawing.Point(9, 19);
            this.mapCheck.Name = "mapCheck";
            this.mapCheck.Size = new System.Drawing.Size(140, 17);
            this.mapCheck.TabIndex = 13;
            this.mapCheck.Text = "Allow Custom Projectiles";
            this.mapCheck.UseVisualStyleBackColor = true;
            this.mapCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // propCombo
            // 
            this.propCombo.Enabled = false;
            this.propCombo.FormattingEnabled = true;
            this.propCombo.Items.AddRange(new object[] {
            "Mounted Machine gun",
            "Covenant Junk 1",
            "Covenant Junk 2",
            "Covenant Junk 3",
            "Junk 1",
            "Junk 2",
            "Junk 3",
            "Scorpion junk",
            "Fusion Coil",
            "Flag Stand",
            "Flag Stand 2",
            "Flag Stand 3",
            "Flag Stand 4",
            "Invisible Prop",
            "Invisible Prop 2",
            "Invisible Prop 3",
            "Unsc Crate",
            "Generator",
            "Covenant Weapon Holder",
            "Teleporter Sender",
            "Teleporter Reciever",
            "Teleporter Two-way",
            "Bomb Point 1",
            "Bomb Point 2",
            "Bomb Point 3",
            "Bomb Point 4",
            "Hill Marker 1",
            "Hill Marker 2",
            "Hill Marker 3",
            "Man Cannon 1",
            "Man Cannon 2",
            "Man Cannon 3",
            "Radio Antenna",
            "Small Crate",
            "Small Radio",
            "Drop Pod",
            "Drop Pod Cover",
            "Barrier",
            "Medical Crate",
            "Covenant Weapon Crate",
            "Barrel",
            "Jerry Can",
            "Small Jerry Can",
            "Tree",
            "Big Tree",
            "Skybox",
            "Frigate",
            "Red Light",
            "Blue Light",
            "Yellow Light",
            "Sandbags",
            "Sandbag",
            "2 Sandbags",
            "Curved Sandbags",
            "L Sandbags",
            "Long Sandbags",
            "Block Sandbags"});
            this.propCombo.Location = new System.Drawing.Point(9, 307);
            this.propCombo.Name = "propCombo";
            this.propCombo.Size = new System.Drawing.Size(234, 21);
            this.propCombo.TabIndex = 12;
            this.propCombo.SelectedIndexChanged += new System.EventHandler(this.propCombo_SelectedIndexChanged);
            // 
            // propLabel
            // 
            this.propLabel.AutoSize = true;
            this.propLabel.Enabled = false;
            this.propLabel.Location = new System.Drawing.Point(6, 291);
            this.propLabel.Name = "propLabel";
            this.propLabel.Size = new System.Drawing.Size(34, 13);
            this.propLabel.TabIndex = 11;
            this.propLabel.Text = "Props";
            // 
            // armorLabel
            // 
            this.armorLabel.AutoSize = true;
            this.armorLabel.Enabled = false;
            this.armorLabel.Location = new System.Drawing.Point(6, 251);
            this.armorLabel.Name = "armorLabel";
            this.armorLabel.Size = new System.Drawing.Size(34, 13);
            this.armorLabel.TabIndex = 10;
            this.armorLabel.Text = "Armor";
            // 
            // armorCombo
            // 
            this.armorCombo.Enabled = false;
            this.armorCombo.FormattingEnabled = true;
            this.armorCombo.Items.AddRange(new object[] {
            "Armor 1",
            "Armor 2",
            "Armor 3",
            "Armor 4",
            "Armor 5",
            "Armor 6",
            "Armor 7",
            "Armor 8",
            "Armor 9",
            "Armor 10",
            "Armor 11",
            "Armor 12",
            "Armor 13",
            "Armor 14",
            "Armor 15",
            "Armor 16",
            "Armor 17",
            "Armor 18",
            "Armor 19",
            "Armor 20",
            "Armor 21",
            "Armor 22",
            "Armor 23",
            "Armor 24",
            "Armor 25",
            "Armor 26",
            "Armor 27"});
            this.armorCombo.Location = new System.Drawing.Point(9, 267);
            this.armorCombo.Name = "armorCombo";
            this.armorCombo.Size = new System.Drawing.Size(234, 21);
            this.armorCombo.TabIndex = 9;
            this.armorCombo.SelectedIndexChanged += new System.EventHandler(this.armorCombo_SelectedIndexChanged);
            // 
            // vehiclesLabel
            // 
            this.vehiclesLabel.AutoSize = true;
            this.vehiclesLabel.Enabled = false;
            this.vehiclesLabel.Location = new System.Drawing.Point(6, 211);
            this.vehiclesLabel.Name = "vehiclesLabel";
            this.vehiclesLabel.Size = new System.Drawing.Size(42, 13);
            this.vehiclesLabel.TabIndex = 8;
            this.vehiclesLabel.Text = "Vehicle";
            // 
            // vehiclesCombo
            // 
            this.vehiclesCombo.Enabled = false;
            this.vehiclesCombo.FormattingEnabled = true;
            this.vehiclesCombo.Items.AddRange(new object[] {
            "Banshee",
            "Ghost",
            "Mongoose",
            "Brute Chopper",
            "Shade",
            "Scorpion",
            "Warthog",
            "Warthog (Chaingun)",
            "Warthog (Gauss Rifle)",
            "Warthog (Troop)",
            "Warthog (Snow)",
            "Warthog (Chaingun Snow)",
            "Warthog (Gauss Rifle Snow)",
            "Hornet",
            "Hornet (Lite)",
            "Hornet (Main Menu)",
            "Wraith",
            "Wraith (Mortar)",
            "Wraith (Anti-infantry)",
            "Wraith (Anti-Air)",
            "Wraith (Anti-Infantry + Air)"});
            this.vehiclesCombo.Location = new System.Drawing.Point(9, 227);
            this.vehiclesCombo.Name = "vehiclesCombo";
            this.vehiclesCombo.Size = new System.Drawing.Size(131, 21);
            this.vehiclesCombo.TabIndex = 7;
            this.vehiclesCombo.SelectedIndexChanged += new System.EventHandler(this.vehiclesCombo_SelectedIndexChanged);
            // 
            // miscLabel
            // 
            this.miscLabel.AutoSize = true;
            this.miscLabel.Enabled = false;
            this.miscLabel.Location = new System.Drawing.Point(6, 169);
            this.miscLabel.Name = "miscLabel";
            this.miscLabel.Size = new System.Drawing.Size(94, 13);
            this.miscLabel.TabIndex = 6;
            this.miscLabel.Text = "Equipment/Bipeds";
            // 
            // miscCombo
            // 
            this.miscCombo.Enabled = false;
            this.miscCombo.FormattingEnabled = true;
            this.miscCombo.Items.AddRange(new object[] {
            "Headless Spartan",
            "Headless Spartan Hologram",
            "Monitor",
            "Forge Marker",
            "Spawn Point",
            "Trip Mine (Active)",
            "Flare",
            "Power Drain (Active)",
            "Power Drain Red (Active)",
            "Power Drain Yellow (Active)",
            "New Equipment",
            "Cloaking 1",
            "Cloaking 2",
            "Power Drain (Inactive)",
            "Bubble Shield (Inactive)",
            "Flare (Inactive)",
            "Regen (Inactive)",
            "Trip Mine (Inactive)",
            "Sentry (Inactive)",
            "Dropshield (Inactive)",
            "Power Drain 1 (Inactive)",
            "Power Drain 2 (Inactive)",
            "Power Drain 3 (Inactive)",
            "Frag Grenade",
            "Plasma Grenade",
            "Spike Grenade",
            "Incendiary Grenade",
            "Grav-Lift (Active)",
            "Grav-Lift (Inactive)",
            "Grav-Lift Explosion",
            "Drop Shield (Active)",
            "Drop Shield (Inactive)",
            "Exploding Drop Shield",
            "Active Camo",
            "Big Active Camo",
            "Big Overshield",
            "Big Custom Power-Up",
            "Yellow Cloaker 1",
            "Yellow Cloaker 2",
            "Blue Explosion 1",
            "Blue Explosion 2",
            "Yellow Explosion",
            "Green Explosion",
            "Ammo Drop (Large)",
            "Ammo Drop (Small)",
            "Rocket Ammo",
            "Small Ammobox",
            "Small Ammobox 2",
            "Unknown",
            "Headless Spartan (No Weapon)",
            "Headless Spartan (T Pose)",
            "ODST",
            "UNSC Marine"});
            this.miscCombo.Location = new System.Drawing.Point(9, 185);
            this.miscCombo.Name = "miscCombo";
            this.miscCombo.Size = new System.Drawing.Size(234, 21);
            this.miscCombo.TabIndex = 5;
            this.miscCombo.SelectedIndexChanged += new System.EventHandler(this.miscCombo_SelectedIndexChanged);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectLabel.Enabled = false;
            this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.selectLabel.Location = new System.Drawing.Point(9, 72);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(91, 15);
            this.selectLabel.TabIndex = 4;
            this.selectLabel.Text = "Selected: Default";
            this.selectLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Enabled = false;
            this.weaponLabel.Location = new System.Drawing.Point(6, 129);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(53, 13);
            this.weaponLabel.TabIndex = 3;
            this.weaponLabel.Text = "Weapons";
            // 
            // projectileLabel
            // 
            this.projectileLabel.AutoSize = true;
            this.projectileLabel.Enabled = false;
            this.projectileLabel.Location = new System.Drawing.Point(6, 89);
            this.projectileLabel.Name = "projectileLabel";
            this.projectileLabel.Size = new System.Drawing.Size(55, 13);
            this.projectileLabel.TabIndex = 2;
            this.projectileLabel.Text = "Projectiles";
            // 
            // weaponsCombo
            // 
            this.weaponsCombo.Enabled = false;
            this.weaponsCombo.FormattingEnabled = true;
            this.weaponsCombo.Items.AddRange(new object[] {
            "Spiker                    ",
            "Beam Rifle",
            "Hammer",
            "Plasma Turret",
            "Assault Rifle (Defualt)",
            "Assault Rifle (Red)",
            "Assault Rifle (Yellow)",
            "Assault Rifle (Green)",
            "Assault Rifle (Gold)",
            "Smg (Default)",
            "Smg (Red)",
            "Smg (Yellow)",
            "Smg (Green)",
            "Smg (Gold) ",
            "Battle Rifle (Default)",
            "Battle Rifle (Red)",
            "Battle Rifle (Yellow)",
            "Battle Rifle (Green) ",
            "Battle Rifle (Blue)",
            "Battle Rifle (Purple)",
            "Battle Rifle (Gold)",
            "DMR (Default)           ",
            "DMR (Red)          ",
            "DMR (Yellow)",
            "DMR (Green)",
            "DMR (Blue)",
            "DMR (Purple)",
            "DMR (Gold)",
            "Magnum (Default)",
            "Magnum (Red)",
            "Magnum (Gold)",
            "Carbine (Default)   ",
            "Carbine (Red)                 ",
            "Carbine (Yellow)              ",
            "Carbine (Green)               ",
            "Carbine (Blue)           ",
            "Carbine (Purple)       ",
            "Carbine (Gold)        ",
            "Mauler (Default)   ",
            "Mauler (Gold)    ",
            "Energy Sword",
            "Energy Sword (No Charge)",
            "Plasma Rifle (default)   ",
            "Plasma Rifle (gold)",
            "Plasma Pistol (default)",
            "Plasma Pistol (gold)",
            "Flag",
            "Skull             ",
            "Bomb                         ",
            "Sniper                    ",
            "Spartan Laser              ",
            "Rocker Launcher         ",
            "Needler",
            "Fuel Rod",
            "Brute Shot              ",
            "Shotgun   ",
            "Sentinel Beam       "});
            this.weaponsCombo.Location = new System.Drawing.Point(9, 145);
            this.weaponsCombo.Name = "weaponsCombo";
            this.weaponsCombo.Size = new System.Drawing.Size(234, 21);
            this.weaponsCombo.TabIndex = 1;
            this.weaponsCombo.SelectedIndexChanged += new System.EventHandler(this.weaponsCombo_SelectedIndexChanged);
            // 
            // projectileCombo
            // 
            this.projectileCombo.Enabled = false;
            this.projectileCombo.FormattingEnabled = true;
            this.projectileCombo.Items.AddRange(new object[] {
            "Frag",
            "Plasma",
            "Spike",
            "Flame",
            "Spike",
            "Flamethrower Flame",
            "Flamethrower Flame 2",
            "Flamethrower Flame 3",
            "Flamethrower Flame 4",
            "Plasma (Long Fuse)",
            "Fuel Rod round 1",
            "Fuel Rod round 2",
            "Rockets",
            "Missile Pod",
            "Wraith shots",
            "Brute Shot",
            "Hornet Rocket",
            "Frag Grenade (Red trail)",
            "Assault Rifle Round",
            "Battle Rifle Round",
            "Covenant Rifle Round",
            "DMR/AR round",
            "Plasma Rifle/Ghost Round",
            "Shotgun Pellet",
            "Magnum Round",
            "Sniper Round",
            "Spiker Round",
            "Mauler Round",
            "Human Projectile",
            "Needler Round",
            "Machine Gun Turret Round",
            "Plasma Pistol",
            "Charged Plasma Pistol",
            "Mauler Round",
            "Unknown",
            "Plasma Bolt 1",
            "Plasma Bolt 2",
            "Plasma Bolt 3",
            "Beam Rifle",
            "Spartan Laser 1",
            "Spartan Laser 2",
            "Banshee Projectile",
            "Gauss Shot 1",
            "Gauss Shot 2",
            "Scorpion Shot",
            "Sentinel Beam",
            "Plasma Shot 1",
            "Plasma Shot 2",
            "AA Wraith"});
            this.projectileCombo.Location = new System.Drawing.Point(9, 105);
            this.projectileCombo.Name = "projectileCombo";
            this.projectileCombo.Size = new System.Drawing.Size(234, 21);
            this.projectileCombo.TabIndex = 1;
            this.projectileCombo.SelectedIndexChanged += new System.EventHandler(this.projectileCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(12, 595);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(249, 23);
            this.aboutBtn.TabIndex = 6;
            this.aboutBtn.Text = "About/Version";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // godCheck
            // 
            this.godCheck.AutoSize = true;
            this.godCheck.ForeColor = System.Drawing.Color.Black;
            this.godCheck.Location = new System.Drawing.Point(7, 20);
            this.godCheck.Name = "godCheck";
            this.godCheck.Size = new System.Drawing.Size(75, 17);
            this.godCheck.TabIndex = 0;
            this.godCheck.Text = "God mode";
            this.godCheck.UseVisualStyleBackColor = true;
            this.godCheck.CheckedChanged += new System.EventHandler(this.godCheck_CheckedChanged);
            // 
            // ammoCheck
            // 
            this.ammoCheck.AutoSize = true;
            this.ammoCheck.ForeColor = System.Drawing.Color.Black;
            this.ammoCheck.Location = new System.Drawing.Point(7, 44);
            this.ammoCheck.Name = "ammoCheck";
            this.ammoCheck.Size = new System.Drawing.Size(101, 17);
            this.ammoCheck.TabIndex = 1;
            this.ammoCheck.Text = "Unlimited Ammo";
            this.ammoCheck.UseVisualStyleBackColor = true;
            this.ammoCheck.CheckedChanged += new System.EventHandler(this.ammoCheck_CheckedChanged);
            // 
            // grenadeCheck
            // 
            this.grenadeCheck.AutoSize = true;
            this.grenadeCheck.ForeColor = System.Drawing.Color.Black;
            this.grenadeCheck.Location = new System.Drawing.Point(7, 68);
            this.grenadeCheck.Name = "grenadeCheck";
            this.grenadeCheck.Size = new System.Drawing.Size(118, 17);
            this.grenadeCheck.TabIndex = 2;
            this.grenadeCheck.Text = "Unlimited Grenades";
            this.grenadeCheck.UseVisualStyleBackColor = true;
            this.grenadeCheck.CheckedChanged += new System.EventHandler(this.grenadeCheck_CheckedChanged);
            // 
            // fireRateCheck
            // 
            this.fireRateCheck.AutoSize = true;
            this.fireRateCheck.ForeColor = System.Drawing.Color.Black;
            this.fireRateCheck.Location = new System.Drawing.Point(126, 68);
            this.fireRateCheck.Name = "fireRateCheck";
            this.fireRateCheck.Size = new System.Drawing.Size(94, 17);
            this.fireRateCheck.TabIndex = 6;
            this.fireRateCheck.Text = "High Fire Rate";
            this.fireRateCheck.UseVisualStyleBackColor = true;
            this.fireRateCheck.CheckedChanged += new System.EventHandler(this.fireRateCheck_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HaloOnlineTrainer.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(-113, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.aboutBtn);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 625);
            this.panel1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.fireRateCheck);
            this.groupBox1.Controls.Add(this.jumpCheck);
            this.groupBox1.Controls.Add(this.grenadeCheck);
            this.groupBox1.Controls.Add(this.ammoCheck);
            this.groupBox1.Controls.Add(this.godCheck);
            this.groupBox1.Controls.Add(this.jumpTrackbar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Options";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // jumpCheck
            // 
            this.jumpCheck.AutoSize = true;
            this.jumpCheck.ForeColor = System.Drawing.Color.Black;
            this.jumpCheck.Location = new System.Drawing.Point(126, 44);
            this.jumpCheck.Name = "jumpCheck";
            this.jumpCheck.Size = new System.Drawing.Size(85, 17);
            this.jumpCheck.TabIndex = 3;
            this.jumpCheck.Text = "Jump Height";
            this.jumpCheck.UseVisualStyleBackColor = true;
            this.jumpCheck.CheckedChanged += new System.EventHandler(this.jumpCheck_CheckedChanged);
            // 
            // jumpTrackbar
            // 
            this.jumpTrackbar.BackColor = System.Drawing.SystemColors.Control;
            this.jumpTrackbar.Enabled = false;
            this.jumpTrackbar.Location = new System.Drawing.Point(116, 13);
            this.jumpTrackbar.Name = "jumpTrackbar";
            this.jumpTrackbar.Size = new System.Drawing.Size(104, 45);
            this.jumpTrackbar.TabIndex = 7;
            this.jumpTrackbar.Scroll += new System.EventHandler(this.jumpTrackbar_Scroll_1);
            // 
            // spawnCombo
            // 
            this.spawnCombo.Enabled = false;
            this.spawnCombo.FormattingEnabled = true;
            this.spawnCombo.Items.AddRange(new object[] {
            "Fire Weapon",
            "Throw Frag Grenade"});
            this.spawnCombo.Location = new System.Drawing.Point(94, 42);
            this.spawnCombo.Name = "spawnCombo";
            this.spawnCombo.Size = new System.Drawing.Size(149, 21);
            this.spawnCombo.TabIndex = 16;
            this.spawnCombo.SelectedIndexChanged += new System.EventHandler(this.spawnCombo_SelectedIndexChanged);
            // 
            // spawnLabel
            // 
            this.spawnLabel.AutoSize = true;
            this.spawnLabel.Enabled = false;
            this.spawnLabel.Location = new System.Drawing.Point(6, 45);
            this.spawnLabel.Name = "spawnLabel";
            this.spawnLabel.Size = new System.Drawing.Size(82, 13);
            this.spawnLabel.TabIndex = 17;
            this.spawnLabel.Text = "Spawn Method:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(273, 625);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Halo Online Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jumpTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox projectileCombo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox weaponsCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.Label projectileLabel;
        private System.Windows.Forms.Label miscLabel;
        private System.Windows.Forms.ComboBox miscCombo;
        private System.Windows.Forms.Label vehiclesLabel;
        private System.Windows.Forms.ComboBox vehiclesCombo;
        private System.Windows.Forms.Label armorLabel;
        private System.Windows.Forms.ComboBox armorCombo;
        private System.Windows.Forms.ComboBox propCombo;
        private System.Windows.Forms.Label propLabel;
        private System.Windows.Forms.CheckBox mapCheck;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox godCheck;
        private System.Windows.Forms.CheckBox ammoCheck;
        private System.Windows.Forms.CheckBox grenadeCheck;
        private System.Windows.Forms.CheckBox fireRateCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox jumpCheck;
        private System.Windows.Forms.TrackBar jumpTrackbar;
        private System.Windows.Forms.Label vehicleTurretLabel;
        private System.Windows.Forms.ComboBox vehicleTurretCombo;
        private System.Windows.Forms.Label spawnLabel;
        private System.Windows.Forms.ComboBox spawnCombo;
    }
}

