using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineTrainer;
using DarkPluginLib;

namespace HaloOnlineTrainer.TagTool
{
    class Run
    {
        public static void Launch()
        {
            try
            {
                using (var stream = File.Open(DarkSettings.HaloOnlineFolder, FileMode.Open, FileAccess.ReadWrite)) // Open tags.dat for reading and writing
                {
                    // Load tags.dat
                    var cache = new TagCache(stream);

                    // Get the CFGT tag (this tag is loaded into every map)
                    var cfgt = cache.Tags[0];

                    // Projectiles
                    cfgt.Dependencies.Add(0x01AD); // Frag 0
                    cfgt.Dependencies.Add(0x01B0); // Plasma 1
                    cfgt.Dependencies.Add(0x01B3); // Spike 2
                    cfgt.Dependencies.Add(0x01B6); // Flame 3
                    cfgt.Dependencies.Add(0x0587); // Spike 4
                    cfgt.Dependencies.Add(0x06D9); // Flamethrower Flame 5
                    cfgt.Dependencies.Add(0x06DB); // Flamethrower Flame 2 6
                    cfgt.Dependencies.Add(0x06DC); // Flamethrower Flame 3 7
                    cfgt.Dependencies.Add(0x06FB); // Flamethrower Flame 4 8
                    cfgt.Dependencies.Add(0x15A7); // Plasma (Long Fuse) 9
                    cfgt.Dependencies.Add(0x15C8); // Fuel Rod round 1 10
                    cfgt.Dependencies.Add(0x15CF); // Fuel Rod round 2 11
                    cfgt.Dependencies.Add(0x15C9); // Rockets 12
                    cfgt.Dependencies.Add(0x15CA); // Missile Pod 13
                    cfgt.Dependencies.Add(0x15CB); // Wraith shots 14
                    cfgt.Dependencies.Add(0x15CD); // Brute Shot 15
                    cfgt.Dependencies.Add(0x15CE); // Hornet Rocket 16
                    cfgt.Dependencies.Add(0x15D0); // Frag Grenade (Red trail) 17
                    cfgt.Dependencies.Add(0x1B90); // Assault Rifle Round 18
                    cfgt.Dependencies.Add(0x1D88); // Battle Rifle Round 19
                    cfgt.Dependencies.Add(0x1DBC); // Covenant Rifle Round 20
                    cfgt.Dependencies.Add(0x1E12); // DMR/AR round 21
                    cfgt.Dependencies.Add(0x1E49); // Plasma Rifle/Ghost Round 22 
                    cfgt.Dependencies.Add(0x1F00); // Shotgun Pellet 23 
                    cfgt.Dependencies.Add(0x1F51); // Magnum Round 24
                    cfgt.Dependencies.Add(0x1F92); // Sniper Round 25
                    cfgt.Dependencies.Add(0x2058); // Spiker Round 26
                    cfgt.Dependencies.Add(0x208F); // Mauler Round 27
                    cfgt.Dependencies.Add(0x20BD); // Human Projectile 28
                    cfgt.Dependencies.Add(0x20EF); // Needler Round 29
                    cfgt.Dependencies.Add(0x219E); // Machine Gun Turret Round 30
                    cfgt.Dependencies.Add(0x225C); // Plasma Pistol 31
                    //Added in 0.1.2
                    cfgt.Dependencies.Add(0x225E); // Charged Plasma Pistol 32
                    cfgt.Dependencies.Add(0x240A); // Mauler Round (?) 33
                    cfgt.Dependencies.Add(0x2413); // Unknown 34
                    cfgt.Dependencies.Add(0x1A1E); // Plasma Bolt 1 35
                    cfgt.Dependencies.Add(0x2571); // Plasma Bolt 2 36
                    cfgt.Dependencies.Add(0x384F); // Plasma Bolt 3 37 
                    cfgt.Dependencies.Add(0x245A); // Beam Rifle 38
                    cfgt.Dependencies.Add(0x24AC); // Spartan Laser 1 39
                    cfgt.Dependencies.Add(0x24AE); // Spartan Laser 2 40
                    cfgt.Dependencies.Add(0x2528); // Banshee Projectile 41
                    cfgt.Dependencies.Add(0x2558); // Gauss Shot 1 42
                    cfgt.Dependencies.Add(0x38BF); // Gauss Shot 2 43
                    cfgt.Dependencies.Add(0x28E1); // Scorpion Shot 44
                    cfgt.Dependencies.Add(0x322D); // Sentinel Beam 45
                    cfgt.Dependencies.Add(0x3677); // Plasma Shot 1 46
                    cfgt.Dependencies.Add(0x3799); // Plasma Shot 2 47
                    cfgt.Dependencies.Add(0x37B0); // AA Wraith 48

                    // Weapons
                    cfgt.Dependencies.Add(0x150C); // Hammer
                    cfgt.Dependencies.Add(0x1A56); // Sentinel Beam

                    // Equipment/Bipeds
                    cfgt.Dependencies.Add(0x01DD); // Headless Spartan 0
                    cfgt.Dependencies.Add(0x0C13); // Headless Spartan Hologram 1
                    cfgt.Dependencies.Add(0x15A0); // Monitor 2
                    cfgt.Dependencies.Add(0x15A1); // Forge Marker 3
                    cfgt.Dependencies.Add(0x15A5); // Spawn Point 4
                    cfgt.Dependencies.Add(0x15D1); // Trip Mine (Active) 5
                    cfgt.Dependencies.Add(0x15D3); // Flare 6
                    cfgt.Dependencies.Add(0x15D2); // Power Drain (Active) 7
                    cfgt.Dependencies.Add(0x15D4); // Power Drain Red (Active) 8
                    cfgt.Dependencies.Add(0x15D5); // Power Drain Yellow (Active) 9
                    cfgt.Dependencies.Add(0x1560); // New Equipment 10
                    cfgt.Dependencies.Add(0x1562); // Cloaking 1 11
                    cfgt.Dependencies.Add(0x1563); // Cloaking 2 12
                    cfgt.Dependencies.Add(0x1561); // Power Drain (Inactive) 13
                    cfgt.Dependencies.Add(0x1564); // Bubble Shield (Inactive) 14
                    cfgt.Dependencies.Add(0x1565); // Flare (Inactive) 15
                    cfgt.Dependencies.Add(0x1566); // Regen (Inactive) 16
                    cfgt.Dependencies.Add(0x1567); // Trip Mine (Inactive) 17
                    cfgt.Dependencies.Add(0x1568); // Sentry (Inactive) 18
                    cfgt.Dependencies.Add(0x1569); // Dropshield (Inactive) 19
                    cfgt.Dependencies.Add(0x1574); // Power Drain 1 (Inactive) 20
                    cfgt.Dependencies.Add(0x1575); // Power Drain 2 (Inactive) 21
                    cfgt.Dependencies.Add(0x1576); // Power Drain 3 (Inactive) 22
                    //Added in 0.1.4
                    cfgt.Dependencies.Add(0x01AC); // Frag Grenade 23
                    cfgt.Dependencies.Add(0x01AF); // Plasma Grenade 24
                    cfgt.Dependencies.Add(0x01B2); // Spike Grenade 25
                    cfgt.Dependencies.Add(0x01B5); // Incendiary Grenade 26
                    cfgt.Dependencies.Add(0x2EBF); // Grav-Lift (Active) 27
                    cfgt.Dependencies.Add(0x2EA9); // Grav-Lift (Inactive) 28
                    cfgt.Dependencies.Add(0x317F); // Grav-Lift Explosion 29
                    cfgt.Dependencies.Add(0x1A6E); // Drop Shield (Active) 30
                    cfgt.Dependencies.Add(0x1A6B); // Drop Shield (Inactive) 31
                    cfgt.Dependencies.Add(0x1B04); // Exploding Drop Shield 32
                    cfgt.Dependencies.Add(0x016A); // Active Camo 33
                    cfgt.Dependencies.Add(0x2EAA); // Big Active Camo 34
                    cfgt.Dependencies.Add(0x2EAB); // Big Overshield 35
                    cfgt.Dependencies.Add(0x2EAC); // Big Custom Power-Up 36
                    cfgt.Dependencies.Add(0x016C); // Yellow Cloaker 1 37
                    cfgt.Dependencies.Add(0x016F); // Yellow Cloaker 2 38
                    cfgt.Dependencies.Add(0x1A6C); // Yellow Cloaker 3 39
                    cfgt.Dependencies.Add(0x18AC); // Blue Explosion 1 40
                    cfgt.Dependencies.Add(0x1B7E); // Blue Explosion 2 41
                    cfgt.Dependencies.Add(0x196E); // Yellow Explosion 42
                    cfgt.Dependencies.Add(0x1965); // Green Explosion 43
                    cfgt.Dependencies.Add(0x1B8E); // Ammo Drop (Large) 44
                    cfgt.Dependencies.Add(0x1B8F); // Ammo Drop (Small) 45
                    cfgt.Dependencies.Add(0x1CA0); // Rocket Ammo 46
                    cfgt.Dependencies.Add(0x1EFF); // Small Ammobox 47
                    cfgt.Dependencies.Add(0x1F91); // Small Ammobox 2 48
                    cfgt.Dependencies.Add(0x20EE); // Unknown 49
                    //Added in 0.2.0
                    cfgt.Dependencies.Add(0x01DD); // Headless Spartan (No Weapon) 50
                    cfgt.Dependencies.Add(0x01E3); // Headless Spartan (Tpose) 51
                    cfgt.Dependencies.Add(0x27D6); // ODST 52
                    cfgt.Dependencies.Add(0x27D7); // UNSC Marine 53

                    //Props
                    cfgt.Dependencies.Add(0x2888); // Mounted Machine gun 0
                    cfgt.Dependencies.Add(0x1A8A); // Covenant Junk 1 1
                    cfgt.Dependencies.Add(0x1A8B); // Covenant Junk 2 2
                    cfgt.Dependencies.Add(0x1A8C); // Covenant Junk 3 3
                    cfgt.Dependencies.Add(0x2603); // Junk 1 4 
                    cfgt.Dependencies.Add(0x2607); // Junk 2 5
                    cfgt.Dependencies.Add(0x2608); // Junk 3 6
                    cfgt.Dependencies.Add(0x2958); // Scorpion junk 7
                    cfgt.Dependencies.Add(0x34A4); // Fusion Coil 8
                    cfgt.Dependencies.Add(0x2EC3); // Flag Stand 9
                    cfgt.Dependencies.Add(0x2EC3); // Flag Stand 2 10
                    cfgt.Dependencies.Add(0x2EC5); // Flag Stand 3 11
                    cfgt.Dependencies.Add(0x2ECA); // Flag Stand 4 12
                    cfgt.Dependencies.Add(0x2EED); // Invisible Prop 13
                    cfgt.Dependencies.Add(0x2EEE); // Invisible Prop 2 14
                    cfgt.Dependencies.Add(0x2EEF); // Invisible Prop 3 15
                    cfgt.Dependencies.Add(0x2EBC); // Unsc Crate 16
                    cfgt.Dependencies.Add(0x2EBD); // Generator 17
                    cfgt.Dependencies.Add(0x2EBE); // Covenant Weapon Holder 18
                    cfgt.Dependencies.Add(0x2EC0); // Teleporter Sender 19
                    cfgt.Dependencies.Add(0x2EC1); // Teleporter Reciever 20
                    cfgt.Dependencies.Add(0x2EC2); // Teleporter Two-way 21
                    cfgt.Dependencies.Add(0x2EC4); // Bomb Point 1 22
                    cfgt.Dependencies.Add(0x2EC6); // Bomb Point 2 23
                    cfgt.Dependencies.Add(0x2EC7); // Bomb Point 3 24
                    cfgt.Dependencies.Add(0x2EC9); // Bomb Point 4 25
                    cfgt.Dependencies.Add(0x15A5); // Hill Marker 1 26
                    cfgt.Dependencies.Add(0x2EC8); // Hill Marker 2 27
                    cfgt.Dependencies.Add(0x2EDC); // Hill Marker 3 28
                    cfgt.Dependencies.Add(0x2EDB); // Man Cannon 1 29
                    cfgt.Dependencies.Add(0x34BE); // Man Cannon 2 30
                    cfgt.Dependencies.Add(0x34BF); // Man Cannon 3 31
                    cfgt.Dependencies.Add(0x34A5); // Radio Antenna 32
                    cfgt.Dependencies.Add(0x34A6); // Small Crate 33
                    cfgt.Dependencies.Add(0x34A7); // Small Radio 34
                    cfgt.Dependencies.Add(0x34A8); // Drop Pod 35
                    cfgt.Dependencies.Add(0x34A9); // Drop Pod Cover 36
                    cfgt.Dependencies.Add(0x34AA); // Barrier 37
                    cfgt.Dependencies.Add(0x34AB); // Medical Crate 38
                    cfgt.Dependencies.Add(0x34C0); // Covenant Weapon Crate 39
                    cfgt.Dependencies.Add(0x34C1); // Barrel 40
                    cfgt.Dependencies.Add(0x34C2); // Jerry Can 41
                    cfgt.Dependencies.Add(0x34C3); // Small Jerry Can 42
                    cfgt.Dependencies.Add(0x34C4); // Tree 43
                    cfgt.Dependencies.Add(0x34C5); // Big Tree 44 
                    //Added in 0.1.4
                    cfgt.Dependencies.Add(0x3F88); // Skybox 45
                    cfgt.Dependencies.Add(0x3F89); // Frigate 46
                    cfgt.Dependencies.Add(0x3F8A); // Red Light 47
                    cfgt.Dependencies.Add(0x3F8B); // Blue Light 48
                    cfgt.Dependencies.Add(0x3F8C); // Yellow Light 49
                    cfgt.Dependencies.Add(0x3F8D); // Sandbags 50
                    cfgt.Dependencies.Add(0x3F8E); // Sandbag 51
                    cfgt.Dependencies.Add(0x3F8F); // 2 Sandbags 52
                    cfgt.Dependencies.Add(0x3F90); // Curved Sandbags 53
                    cfgt.Dependencies.Add(0x3F91); // L Sandbags 54
                    cfgt.Dependencies.Add(0x3F92); // Long Sandbags 55
                    cfgt.Dependencies.Add(0x3F93); // Block Sandbags 56

                    // Vehicles
                    cfgt.Dependencies.Add(0x151A); // Banshee
                    cfgt.Dependencies.Add(0x1517); // Ghost
                    cfgt.Dependencies.Add(0x1596); // Mongoose
                    cfgt.Dependencies.Add(0x1518); // Chopper
                    cfgt.Dependencies.Add(0x1516); // Shade
                    cfgt.Dependencies.Add(0x1520); // Scorpion
                    cfgt.Dependencies.Add(0x151F); // Warthog
                    cfgt.Dependencies.Add(0x29EC); // Warthog (Chaingun)
                    cfgt.Dependencies.Add(0x29ED); // Warthog (Gauss Rifle)
                    cfgt.Dependencies.Add(0x29EE); // Warthog (Troop)
                    cfgt.Dependencies.Add(0x1599); // Warthog (Snow)
                    cfgt.Dependencies.Add(0x433A); // Warthog (Chaingun Snow)
                    cfgt.Dependencies.Add(0x433B); // Warthog (Gauus Rifle Snow)
                    cfgt.Dependencies.Add(0x1598); // Hornet
                    cfgt.Dependencies.Add(0x159B); // Hornet (Lite)
                    cfgt.Dependencies.Add(0x27D8); // Hornet (Main Menu)
                    cfgt.Dependencies.Add(0x1519); // Wraith
                    cfgt.Dependencies.Add(0x3742); // Wraith (Mortar)
                    cfgt.Dependencies.Add(0x3743); // Wraith (Anti Infantry)
                    cfgt.Dependencies.Add(0x3744); // Wraith (Anti Air)
                    cfgt.Dependencies.Add(0x3745); // Wraith (Anti Infantry + Air)

                    //Vehicle Turret
                    cfgt.Dependencies.Add(0x29EC); // Warthog (Chaingun) 0
                    cfgt.Dependencies.Add(0x29ED); // Warthog (Gauss Rifle) 1
                    cfgt.Dependencies.Add(0x433A); // Warthog (Chaingun Snow) 2
                    cfgt.Dependencies.Add(0x433B); // Warthog (Gauss Rifle Snow) 3
                    cfgt.Dependencies.Add(0x3742); // Wraith (Mortar) 4
                    cfgt.Dependencies.Add(0x3743); // Wraith (Anti-infantry) 5
                    cfgt.Dependencies.Add(0x3744); // Wraith (Anti-Air) 6
                    cfgt.Dependencies.Add(0x3745); // Wraith (Anti-Infantry + Air) 7
                    cfgt.Dependencies.Add(0x28C6); // Scorpion Cannon 8


                    // Finally, save CFGT back to the file:
                    cache.UpdateTag(stream, cfgt);
                }
            }
            catch (Exception e) { DarkLog.WriteLine(e.Message); }
            
    }
    }
}
