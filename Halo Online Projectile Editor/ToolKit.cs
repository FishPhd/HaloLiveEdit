/*
using DarkPluginLib;
using System;
using System.Reflection;
using System.Windows.Forms;
using HaloOnlineTrainer;

namespace PluginExample
{

    public class ToolKit : DarkPlugin
    {
        #region DarkPlugin Members

        public string Title
        {
            get
            {
                return "Halo: Online Trainer";
            }
        }
        public string Description
        {
            get
            {
                return "A trainer for Halo: Online that centers around projectile modification.";
            }
        }
        public string Author
        {
            get
            {
                return "Razzile, FishPhd, NexusAu, Feesh, Bivi, Shockfire";
            }
        }
        public string Url
        {
            get
            {
                return "https://github.com/FishPhd/HaloLiveEdit";
            }
        }
        public string Version
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        public string Built
        {
            get
            {
                System.IO.FileInfo fi = new System.IO.FileInfo("Plugins/" + Assembly.GetExecutingAssembly().GetName().Name + ".dll");
                return fi.LastWriteTime.ToString();
            }
        }
        public Form MainForm
        {
            get
            {
                return helloForm;
            }
        }

        public Form1 helloForm;
        public static bool runningForm = false;
        public void DarkPluginMain()
        {
            DarkLog.WriteLine("DarkPluginMain() has been hit in Halo Online Trainer");
            if (!runningForm)
            {
                helloForm = new Form1();

                helloForm.Show();
                runningForm = true;
            }
            else
            {
                DarkLog.WriteLine("Plugin already running!");

                helloForm.Show();
            }
        }

        #endregion
    }

}
*/