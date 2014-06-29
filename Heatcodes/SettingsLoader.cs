using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeatCodes;

namespace Heatcodes
{
    static class SettingsLoader
    {

        private static string certPath;
        public static string CertPath { get { return certPath; } set { certPath = value; } }

        private static string laserPath;
        public static string LaserPath { get { return laserPath; } set { laserPath = value; } }

        private static string drawingPath;
        public static string DrawingPath { get { return drawingPath; } set { drawingPath = value; } }

        private static string miscPath;
        public static string MiscPath { get { return miscPath; } set { miscPath = value; } }


        public static void LoadSettings()
        {
            try
            {
                StreamReader sr = File.OpenText("config.txt");
                DrawingPath = sr.ReadLine();
                LaserPath = sr.ReadLine();
                CertPath = sr.ReadLine();
                MiscPath = sr.ReadLine();

                sr.Close();
            }
            catch (FileNotFoundException)
            {
                throw new NetworkException("Config-fil för paths saknas");
            }

           
        }



        public static void Save(string[] output)
        {
            using (StreamWriter writer = new StreamWriter("config.txt", false))
            {
            }

            foreach (string s in output)
            {
                using (StreamWriter writer = new StreamWriter("config.txt", true))
                {
                    writer.WriteLine(s);
                }
            }
           
        }


      





    } //class
} //namespace
