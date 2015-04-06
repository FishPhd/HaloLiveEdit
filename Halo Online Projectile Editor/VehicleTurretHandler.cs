using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloOnlineTrainer
{
    public class VehicleTurretHandler : GenericHandler
    {
        public static uint[] projectiles =
        {
            /* to add your own projectiles from any of the spreadsheets, add the reverse endian of the hex to this list
             * e.g DD010000 for headless spartan will become 0x000001DD here.
             * Just remember to add your changes to the combo box in the form as well (and at the right place) */

            0x0029EC, // Warthog (Chaingun) 0
            0x0029ED, // Warthog (Gauss Rifle) 1
            0x00433A, // Warthog (Chaingun Snow) 2
            0x00433B, // Warthog (Gauss Rifle Snow) 3
            0x003742, // Wraith (Mortar) 4
            0x003743, // Wraith (Anti-infantry) 5
            0x003744, // Wraith (Anti-Air) 6
            0x003745, // Wraith (Anti-Infantry + Air) 7
            0x0028C6, // Scorpion Cannon 8
        };
        public static string[] list =
        {
            "Warthog (Chaingun)",
            "Warthog (Gauss Rifle)",
            "Warthog (Chaingun Snow)",
            "Warthog (Gauss Rifle Snow)",
            "Wraith (Mortar)",
            "Wraith (Anti-infantry)",
            "Wraith (Anti-Air)",
            "Wraith (Anti-Infantry + Air)",
            "Scorpion Cannon",
        };

        public static string[] accept_list = // Valid vehicles to be modified
        {
            "Warthog",
            "Wraith",
            "Scorpion",
        };

        private static Dictionary<String, byte[]> search_bytes = new Dictionary<String,byte[]> // Byte arrays used to search memory
        {
            {"Grenade",new byte[] {0x6A,0x6F,0x72,0x70,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xAD,0x01,0x00,0x00,0x02,0x00}},
            {"Warthog",new byte[] {0x00,0x00,0x00,0x00,0xEC,0x29,0x00,0x00,0x8D,0x13}},
            {"Wraith",new byte[] {0x00,0x00,0x00,0x00,0x42,0x37,0x00,0x00,0xD4,0x17}},
            {"Scorpion",new byte[] {0x00,0x00,0x00,0x00,0xC6,0x28,0x00,0x00,0xD4,0x17}},
        };

        private static Dictionary<String, uint> search_offset = new Dictionary<String, uint> // Offsets from the address found when using search_bytes
        {
            {"Grenade",0xC},
            {"Warthog",0x4},
            {"Wraith",0x4},
            {"Scorpion",0x4},
        };

        public static Dictionary<String, uint> patch_reset = new Dictionary<String, uint> // Values used to reset state to default
        {
            {"Grenade",0x0001AD},
            {"Warthog",0x0029EC},
            {"Wraith",0x003742},
            {"Scorpion",0x0028C6}
        }; 

        public static uint SetNewProjectile(uint hex, string search_str)
        {
            byte[] hexData = BitConverter.GetBytes(hex);
            if (search_bytes.ContainsKey(search_str))
            {
                uint Base_Addr = MemoryManager.ReadUntilFindBytes(search_bytes[search_str]);
                if (Base_Addr == 0) return 0;
                Base_Addr += search_offset[search_str];
                // BA {projectile hex} 00 00 90
                MemoryManager.WriteToAddress(Base_Addr, hexData);
                return Base_Addr;
            }
            return 0;
        }  
    }
}
