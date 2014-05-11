using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HeatCodes
{
    class DataAccessLayer
    {
        bool debug = true;

        public DataAccessLayer()
        {
            if(debug)
            {
                rootPath = @"C:\Users\submarines\Documents\GitHub\HeatCodes\Tree\";
                laserPath = @"Laser\";
                drawingPath = @"Ritningar\";
            }
            else{
                rootPath = @"\\umacserver\Group-HeatCore\20_Produkt\";
                 laserPath = @"Laser\";
                 drawingPath = @"Ritning\PDC v2.1\";
            }
        }

        private readonly string rootPath;
        private readonly string laserPath;
        private readonly string drawingPath;
        public string RootPath { get { return rootPath; } }
        public string LaserPath { get { return laserPath; } }
        public string DrawingPath { get { return drawingPath; } }



        private List<string> laserList = new List<string>();

        public List<string> Lasers
        {
            get { return laserList; }
            set { laserList = value; }
        }
        private List<List<string>> drawingList = new List<List<string>>();

        public List<List<string>> Drawings
        {
            get { return drawingList; }
            set { drawingList = value; }
        }

        public void Refresh()
        {
          //  try
         //   {
            UpdateLasers();
            UpdateDrawings();
                
         /*   }
            catch (IOException)
            {
                throw new NetworkException("Servern verkar vara nere...");
            }*/
        }

        
        private void UpdateLasers()
        {
            laserList.Clear();
            foreach (var file in Directory.GetFiles(RootPath + LaserPath))
            {
                laserList.Add(RemoveFullPath(file, 1));
            }

        }

        private void UpdateDrawings()
        {
            laserList.Clear();
            foreach (var file in Directory.GetFiles(RootPath + DrawingPath))
            {
                MessageBox.Show(file);
                List<string> list= new List<string>();
                list.Add(RemoveFullPath(file, 1));
                drawingList.Add(list);
            }

        }



        private void UpdateDrawings2()
        {
            string path = RootPath + DrawingPath;
            drawingList.Clear();
            string[] fileList;

            var dirInfo = new DirectoryInfo(path);
            FileInfo[] files = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);

            if (dirInfo.Exists)
            {
                fileList = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

                foreach (string currentFile in fileList)
                {

                    string split = RemoveFullPath(currentFile, 2);

                    if (split.Contains("90"))
                    {

                        string[] stringSeparators = new string[] { "rev" };
                        string[] rev = split.Split(stringSeparators, StringSplitOptions.None);
                        bool exists = false;

                        foreach (List<string> l in drawingList)
                        {
                            if (rev[0].Equals(l[0]))
                            {
                                try
                                {
                                    l.Add(rev[1]);
                                    exists = true;
                                }
                                catch (IndexOutOfRangeException)
                                {
                                }

                            }
                        }

                        if (!exists)
                        {
                            List<string> drw = new List<string>();
                            drw.Add(rev[0]);

                            try
                            {
                                drw.Add(rev[1]);
                            }
                            catch (IndexOutOfRangeException)
                            {
                            }
                            drawingList.Add(drw);
                        }


                    }



                }

            }
        }
        
        public string RemoveFullPath(string input, int count)
        {
            if (input != null)
            {
                string lower = input.ToLower();

                string[] stringSeparators = new string[] { "\\" };
                string[] all = lower.Split(stringSeparators, StringSplitOptions.None);
                int size = all.Length;
                string split = "";

                if (count == 1)
                {
                    split = all[size - 1];
                }
                else if (count == 2)
                {
                    split = all[size - 2] + "\\" + all[size - 1];
                }


                split = split.Replace(".pdf", "");
                split = split.Replace(".csv", "");

                return split;
            }
            else
            {
                return null;
            }
            
        }


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


            return RemoveFullPath(fileName, 2);
        }



    } //class
} //namespace
