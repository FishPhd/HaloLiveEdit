using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo_Online_Projectile_Editor
{
    public abstract class GenericHandler
    {
        // Sets the projectile of either the grenade throw spawn entity or shoot spawn entity
        public static void SetNewProjectile(uint hex,uint addr) 
        {
            byte[] hexData = BitConverter.GetBytes(hex);

            if (addr == 0xB5DBA5) // Shoot to spawn
            {
                byte[] rawData = new byte[6];
                hexData.CopyTo(rawData, 1);
                rawData[0] = 0xBA; // mov edx, {projectile}
                rawData[5] = 0x90; // nop
                // BA {projectile hex} 00 00 90
                MemoryManager.WriteToAddress(addr, rawData);
            }
            else // Grenade to spawn
            {
                MemoryManager.WriteToAddress(addr, hexData);
            }
        } 
    }
}
