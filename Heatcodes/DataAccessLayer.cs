using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Heatcodes;

namespace HeatCodes
{
    class DataAccessLayer
    {

        //global debug flag
        public static bool debug = true;


        /*
         * Constructor; currently only sets default paths
         */
        public DataAccessLayer()
        {
            if(debug)
            {
                drawingPath = @"C:\Users\submarines\Documents\GitHub\HeatCodes\Tree\Produkt\Ritningar\";
                laserPath = @"C:\Users\submarines\Documents\GitHub\HeatCodes\Tree\Produkt\Laser\";
                certPath = @"C:\Users\submarines\Documents\GitHub\HeatCodes\Tree\Produkt\Certifikat\";

            }
            else
            {
                SettingsLoader.LoadSettings();
                certPath = SettingsLoader.CertPath;
                drawingPath = SettingsLoader.DrawingPath;
                laserPath = SettingsLoader.LaserPath;
            }

        }


        /*
         * Access methods for paths
         */
        private string drawingPath;
        public string DrawingPath { get { return drawingPath; } set { drawingPath = value; } }

        private string laserPath;
        public string LaserPath { get { return laserPath; } set { laserPath = value; } }

        private string certPath;
        public string CertPath { get { return certPath; } set { certPath = value; } }


        /*
         * Methods for getting full paths of all files
         */
        public List<string> DrawingList()
        {
            return Directory.GetFiles(DrawingPath).ToList();
        }

        public List<string> LaserList()
        {
            return Directory.GetDirectories(LaserPath).ToList();
        }

        public List<string> CertList()
        {
            return Directory.GetFiles(CertPath).ToList();
        }

   
        /*
         * Browse for files (paths to) when it's stored elsewhere
         */
        public string BrowseFile()
        {
            string fileName = null;

            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);

                fileName = File.FullName;
            }

            return fileName;
        }


        /*
        * Browse for folders (paths to) when it's stored elsewhere
        */
        public String BrowseFolder()
        {
            string folderPath = "";

            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }

            return folderPath + "\\";
        }



    } //class
} //namespace
