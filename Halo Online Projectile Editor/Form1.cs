using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HaloOnlineTrainer.TagTool;


namespace HaloOnlineTrainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TagTool.Run.Launch();

            weaponsCombo.Items.Clear();
            vehiclesCombo.Items.Clear();
            propCombo.Items.Clear();
            projectileCombo.Items.Clear();
            miscCombo.Items.Clear();

            //Weapons
            for (int i = 0; i <= 56; i++)
            {
                weaponsCombo.Items.Add(WeaponHandler.list[i]);
            }
            //Vehicles
            for (int i = 0; i <= 20; i++)
            {
                vehiclesCombo.Items.Add(VehicleHandler.list[i]);
            }
            //Projectiles 32-48 Added in 0.1.2
            for (int i = 0; i <= 48; i++)
            {
                projectileCombo.Items.Add(ProjectileHandler.list[i]);
            }
            //Props 45-56 Added in 0.1.4
            for (int i = 0; i <= 56; i++)
            {
                propCombo.Items.Add(PropHandler.list[i]);
            }
            //Armor 
            for (int i = 0; i <= 26; i++)
            {
                armorCombo.Items.Add(ArmorHandler.list[i]);
            }
            //Equipment/Bipeds (Added in 0.1.4)
            for (int i = 0; i <= 52; i++)
            {
                miscCombo.Items.Add(MiscHandler.list[i]);
            }
        }

        // Used for reseting vehicles and grenade spawn
        private uint vt_address;
        private String vt_prev;
        private uint sg_address = 0xB5DBA5; // (shoot/grenade address) Initialized to default address for projectile
        private uint sg_prev = 0x0001AD; // (shoot/grenade previous value) Initialized to default grenade spawn (Only covers reset for grenades)

        private void godCheck_CheckedChanged(object sender, EventArgs e)
        {
            uint addr = 0xB555DC;

            if (godCheck.Checked)
            {
                byte[] data = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
                // nop, nop, nop, nop, nop, nop, nop, nop
                MemoryManager.WriteToAddress(addr, data);
            }
            else
            {
                byte[] data = { 0xF3, 0x0F, 0x11, 0x87, 0x00, 0x01, 0x00, 0x00 };
                // movss dword ptr [edi+100h], xmm0
                MemoryManager.WriteToAddress(addr, data);
            }
        }

        private void ammoCheck_CheckedChanged(object sender, EventArgs e)
        {
            uint addr = 0xB5FACD;

            if (ammoCheck.Checked)
            {
                byte[] data = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
                // nop, nop, nop, nop, nop, nop, nop, nop
                MemoryManager.WriteToAddress(addr, data);
            }
            else
            {
                byte[] data = { 0x66, 0x29, 0x94, 0x31, 0x8E, 0x02, 0x00, 0x00 };
                // sub [ecx+esi+28Eh], dx
                MemoryManager.WriteToAddress(addr, data);
            }
        }

        private void grenadeCheck_CheckedChanged(object sender, EventArgs e)
        {
            uint addr = 0xBA3C01;

            if (grenadeCheck.Checked)
            {
                byte[] data = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
                // nop, nop, nop, nop, nop, nop
                MemoryManager.WriteToAddress(addr, data);
            }
            else
            {
                byte[] data = { 0x88, 0x81, 0x20, 0x03, 0x00, 0x00 };
                // mov [ecx+320h], al
                MemoryManager.WriteToAddress(addr, data);
            }
        }

        private void grenadeSpawnCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (grenadeSpawnCheck.Checked)
            {
                sg_address = VehicleTurretHandler.SetNewProjectile(sg_prev, "Grenade");
            }
            else // could lead to issues (shooting grenades) if spammed
            {
                sg_prev = 0x0001AD;
                GenericHandler.SetNewProjectile(sg_prev, sg_address); // be careful changing maps
                sg_address = 0xB5DBA5;
                vehicleTurretCombo.Enabled = false;
                projectileCombo.Text = "";
                weaponsCombo.Text = "";
                vehiclesCombo.Text = "";
                propCombo.Text = "";
                miscCombo.Text = "";
                vehicleTurretCombo.Text = "";
                armorCombo.Text = "";
                selectLabel.Text = "Selected: Default Grenade";
            }
        }

        private void projectileCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                ComboBox box = (ComboBox)sender;
                int index = Array.IndexOf(ProjectileHandler.list, projectileCombo.SelectedItem);
                ProjectileHandler.SetNewProjectile(ProjectileHandler.projectiles[index], sg_address);
                vehicleTurretCombo.Enabled = false;
                sg_prev = ProjectileHandler.projectiles[index];
                selectLabel.Text = "Selected: " + projectileCombo.SelectedItem;
                weaponsCombo.Text = "";
                miscCombo.Text = "";
                vehiclesCombo.Text = "";
                armorCombo.Text = "";
                propCombo.Text = "";
                vehicleTurretCombo.Text = "";
            }
        }

        private void weaponsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                ComboBox box = (ComboBox)sender;
                int index = Array.IndexOf(WeaponHandler.list, weaponsCombo.SelectedItem);
                WeaponHandler.SetNewProjectile(WeaponHandler.projectiles[index], sg_address);
                vehicleTurretCombo.Enabled = false;
                sg_prev = WeaponHandler.projectiles[index];
                selectLabel.Text = "Selected: " + weaponsCombo.SelectedItem;
                projectileCombo.Text = "";
                miscCombo.Text = "";
                vehiclesCombo.Text = "";
                armorCombo.Text = "";
                propCombo.Text = "";
                vehicleTurretCombo.Text = "";
            }
        }

        private void miscCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                ComboBox box = (ComboBox)sender;
                int index = Array.IndexOf(MiscHandler.list, miscCombo.SelectedItem);
                MiscHandler.SetNewProjectile(MiscHandler.projectiles[index], sg_address);
                vehicleTurretCombo.Enabled = false;
                sg_prev = MiscHandler.projectiles[index];
                selectLabel.Text = "Selected: " + miscCombo.SelectedItem;
                projectileCombo.Text = "";
                weaponsCombo.Text = "";
                vehiclesCombo.Text = "";
                armorCombo.Text = "";
                propCombo.Text = "";
                vehicleTurretCombo.Text = "";
            }
        }

        private void vehiclesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                ComboBox box = (ComboBox)sender;
                int index = Array.IndexOf(VehicleHandler.list, vehiclesCombo.SelectedItem);
                VehicleHandler.SetNewProjectile(VehicleHandler.projectiles[index], sg_address);
                vehicleTurretCombo.Enabled = VehicleTurretHandler.accept_list.Contains((string)vehiclesCombo.SelectedItem); // Enable the vehicle turret combo box if the vehicle is in the accepted list of vehicles
                if (vt_address != 0)
                {
                    VehicleTurretHandler.SetNewProjectile(VehicleTurretHandler.patch_reset[vt_prev], vt_address); // reset the old vehicles main gun back
                    vt_address = 0;
                }
                sg_prev = VehicleHandler.projectiles[index];
                selectLabel.Text = "Selected: " + vehiclesCombo.SelectedItem;
                projectileCombo.Text = "";
                weaponsCombo.Text = "";
                miscCombo.Text = "";
                armorCombo.Text = "";
                propCombo.Text = "";
                vehicleTurretCombo.Text = "";
            }
        }

        private void vehicleTurretCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                ComboBox box = (ComboBox)sender;
                int index = Array.IndexOf(VehicleTurretHandler.list, vehicleTurretCombo.SelectedItem);
                if (vt_address == 0) // Address not yet scanned (TODO: Consider storing previously scanned addresses in a structure and reset on map change or scan for all addresses during map load)
                {
                    vt_address = VehicleTurretHandler.SetNewProjectile(VehicleTurretHandler.projectiles[index], (string)vehiclesCombo.SelectedItem);
                    if (vt_address != 0) // Scan success
                    {
                        vt_prev = (string)vehiclesCombo.SelectedItem;
                        selectLabel.Text = "Selected: " + vehicleTurretCombo.SelectedItem;
                    }
                    else // Scan failure
                    {
                        selectLabel.Text = "Scanning Failed";
                        vehicleTurretCombo.Text = "";
                    }
                }
                else // Address already scanned. No need to search again. 
                {
                    VehicleTurretHandler.SetNewProjectile(VehicleTurretHandler.projectiles[index], vt_address);
                    selectLabel.Text = "Selected: " + vehicleTurretCombo.SelectedItem;
                }

                projectileCombo.Text = "";
                weaponsCombo.Text = "";
                propCombo.Text = "";
                miscCombo.Text = "";
                armorCombo.Text = "";
            }
        }

        private void armorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                ComboBox box = (ComboBox)sender;
                int index = Array.IndexOf(ArmorHandler.list, armorCombo.SelectedItem);
                ArmorHandler.SetNewProjectile(ArmorHandler.projectiles[index], sg_address);
                vehicleTurretCombo.Enabled = false;
                sg_prev = ArmorHandler.projectiles[index];
                selectLabel.Text = "Selected: " + armorCombo.SelectedItem;
                projectileCombo.Text = "";
                weaponsCombo.Text = "";
                vehiclesCombo.Text = "";
                propCombo.Text = "";
                miscCombo.Text = "";
                vehicleTurretCombo.Text = "";
            }
        }

        private void propCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                ComboBox box = (ComboBox)sender;
                int index = Array.IndexOf(PropHandler.list, propCombo.SelectedItem);
                PropHandler.SetNewProjectile(PropHandler.projectiles[index], sg_address);
                vehicleTurretCombo.Enabled = false;
                sg_prev = PropHandler.projectiles[index];
                selectLabel.Text = "Selected: " + propCombo.SelectedItem;
                projectileCombo.Text = "";
                weaponsCombo.Text = "";
                vehiclesCombo.Text = "";
                armorCombo.Text = "";
                miscCombo.Text = "";
                vehicleTurretCombo.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nexusau.com/halo-online-trainer");
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }


        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (mapCheck.Checked)
            {
                projectileCombo.Enabled = true;
                weaponsCombo.Enabled = true;
                miscCombo.Enabled = true;
                vehiclesCombo.Enabled = true;
                armorCombo.Enabled = true;
                propCombo.Enabled = true;
                selectLabel.Enabled = true;
                projectileLabel.Enabled = true;
                weaponLabel.Enabled = true;
                miscLabel.Enabled = true;
                vehiclesLabel.Enabled = true;
                armorLabel.Enabled = true;
                propLabel.Enabled = true;
                vehiclesLabel.Enabled = true;
                vehicleTurretCombo.Enabled = true;
                vehicleTurretLabel.Enabled = true;
            }
            else
            {
                projectileCombo.Enabled = false;
                weaponsCombo.Enabled = false;
                miscCombo.Enabled = false;
                vehiclesCombo.Enabled = false;
                armorCombo.Enabled = false;
                propCombo.Enabled = false;
                selectLabel.Enabled = false;
                projectileLabel.Enabled = false;
                weaponLabel.Enabled = false;
                miscLabel.Enabled = false;
                vehiclesLabel.Enabled = false;
                armorLabel.Enabled = false;
                propLabel.Enabled = false;
                vehiclesLabel.Enabled = false;
                vehicleTurretCombo.Enabled = false;
                vehicleTurretLabel.Enabled = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void jumpCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (jumpCheck.Checked)
            {
                jumpTrackbar.Enabled = true;
                byte[] rawData = new byte[10];
                rawData[0] = 0xB8; // mov eax

                byte[] heightData = BitConverter.GetBytes((float)jumpTrackbar.Value);
                byte[] paddingData = { 0x89, 0x45, 0xF8, 0x90, 0x90 };

                heightData.CopyTo(rawData, 1);
                paddingData.CopyTo(rawData, 5);

                MemoryManager.WriteToAddress(0xBE1C23, rawData);
                // mov eax, {jump height} -> mov [ebp-8], eax -> nop padding
            }
            else
            {
                jumpTrackbar.Enabled = false;
                byte[] rawData = { 0xF3, 0x0F, 0x59, 0x4D, 0xF8, 0xF3, 0x0F, 0x11, 0x4D, 0xF8 };
                MemoryManager.WriteToAddress(0xBE1C23, rawData);
                // mulss xmm1, [ebp+var_8] - > movss [ebp+var_8], xmm1
            }
        }

        private void jumpTrackbar_ValueChanged(object sender, EventArgs e)
        {
            if (jumpCheck.Checked)
            {
                byte[] rawData = new byte[10];
                rawData[0] = 0xB8; // mov eax

                byte[] heightData = BitConverter.GetBytes((float)jumpTrackbar.Value);
                byte[] paddingData = { 0x89, 0x45, 0xF8, 0x90, 0x90 };

                heightData.CopyTo(rawData, 1);
                paddingData.CopyTo(rawData, 5);

                MemoryManager.WriteToAddress(0xBE1C23, rawData);
                // mov eax, {jump height} -> mov [ebp-8], eax -> nop padding
            }
        }

        private void jumpTrackbar_Scroll(object sender, EventArgs e)
        {

        }

        private void fireRateCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (fireRateCheck.Checked)
            {
                byte[] rawData = { 0x90, 0x90 }; // nop, nop
                MemoryManager.WriteToAddress(0xB60E60, rawData);
            }

            else
            {
                byte[] rawData = { 0x74, 0x49 }; // jz short loc_B60EAB
                MemoryManager.WriteToAddress(0xB60E60, rawData);
            }
        }

        private void resetHeightBtn_Click(object sender, EventArgs e)
        {

        }
        private void aboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Halo Online Trainer \r\n\r\nCreated by: \r\nRazzile \r\nNexusAU \r\nFeesh \r\nFishPhd \r\nBivi \r\nShockfire \r\nand many more from the ElDorito IRC \nVersion 0.2.2", "About/Version");
        }

        // No references
        //private void label11_Click(object sender, EventArgs e)
        //{

        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // No references
        //private void tabPage1_Click(object sender, EventArgs e)
        //{

        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // No references
        //private void tabPage1_Click_1(object sender, EventArgs e)
        //{

        //}

        // No references
        //private void trackBar1_Scroll(object sender, EventArgs e)
        //{

        //}

        private void jumpTrackbar_Scroll_1(object sender, EventArgs e)
        {
        }

        private void vehicleTurretLabel_Click(object sender, EventArgs e)
        {

        }

        // No references
        //public void comboBox1_SelectedIndexChanged_3(object sender, EventArgs e)
        //{

        //}



    }
}