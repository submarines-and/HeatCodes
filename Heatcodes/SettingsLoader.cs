using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heatcodes
{
    static class SettingsLoader
    {

        private static string rootPath;
        public static string RootPath { get { return rootPath; } set { rootPath = value; } }

        private static string laserPath;
        public static string LaserPath { get { return laserPath; } set { laserPath = value; } }

        private static string drawingPath;
        public static string DrawingPath { get { return drawingPath; } set { drawingPath = value; } }


        public static void LoadSettings()
        {
            StreamReader sr = File.OpenText("config.txt");

            RootPath = sr.ReadLine();
            DrawingPath = sr.ReadLine();
            LaserPath = sr.ReadLine();

            sr.Close();
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
