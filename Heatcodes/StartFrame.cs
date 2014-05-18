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
using Heatcodes;

namespace HeatCodes
{
    public partial class StartFrame : Form
    {
        private Controller controller;

        internal Controller Controller
        {
            get { return controller; }
            set { controller = value; }
        }

        public StartFrame()
        {
            Controller = new Controller();
            InitializeComponent();
    
        }

   
        private void RefreshConfig()
        {
            drawingCB.Items.Clear();

            foreach (List<string> l in Controller.Drawings)
            {
                drawingCB.Items.Add(l[0]);
            }
            try
            {
                drawingCB.SelectedIndex = 0;
            }
            catch(ArgumentOutOfRangeException){
            }
            try
            {
                revisionCB.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException)
            {

            }

        }

        private void RefreshLaser()
        {
            laserCB.Items.Clear();

            foreach (string s in Controller.Lasers)
            {
                laserCB.Items.Add(s);

            }
            try
            {
                laserCB.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        private void RefreshRevisionCB()
        {
            revisionCB.Items.Clear();

            foreach (List<string> l in Controller.Drawings)
            {
                if (drawingCB.SelectedItem.ToString() == l[0])
                {
                    for (int i = 1; i < l.Count; i++)
                    {
                        string[] stringSeparators = stringSeparators = new string[] { "." };
                        string cut = l[i].Split(stringSeparators, StringSplitOptions.None)[0];
                        revisionCB.Items.Add(cut);
                    }
                }
            }
            if (revisionCB.Items.Count > 0)
            {
                revisionCB.SelectedIndex = 0;
            }
        }

      

        private void DrawingListListener(object sender, EventArgs e)
        {
            RefreshRevisionCB();

            PreviewDrawing();
        }

        private void LaserListlistener(object sender, EventArgs e)
        {
            PreviewLaser();
        }


        private void PreviewDrawing()
        {
            string rev = "rev";
            if (revisionCB.SelectedItem == null)
            {
                rev = "rev0";
            }
            string path = Controller.RootPath
                       + drawingCB.SelectedItem
                       + rev
                       + revisionCB.SelectedItem
                       + ".pdf";
           // MessageBox.Show(path);
            drawingPreview.Navigate(path);
        }

        private void PreviewLaser()
        {
            string path = Controller.LaserPath
                       + laserCB.SelectedItem
                       + ".csv";

            try
            {
                StreamReader sr = new StreamReader(path);
                var lines = new List<string[]>();
                int Row = 0;
                while (!sr.EndOfStream)
                {
                    string[] Line = sr.ReadLine().Split(';');
                    lines.Add(Line);
                    Row++;
                    Console.WriteLine(Row);
                }

                var data = lines.ToArray();

                FillTable(data);
            }
            catch (DirectoryNotFoundException)
            {

            }
            
        }

        private void FillTable(string[][] matrix)
        {
            DataTable tb = new DataTable();
            tb.Clear();
            int j = 0;
            foreach (string[] list in matrix)
            {
                tb.Columns.Add(j.ToString());
                j++;
            }

            foreach (string[] list in matrix)
            {
                int i = 0;
                DataRow row = tb.NewRow();

                foreach (string s in list)
                {
                    row[i] = s;
                    i++;
                }
                tb.Rows.Add(row);
            }

            laserPreview.DataSource = tb;

        }

        private void RevisionListListener(object sender, EventArgs e)
        {
            PreviewDrawing();
        }

        private void BrowseForDrawing(object sender, EventArgs e)
        {
            string newDocument = Controller.BrowseFile();

            if (newDocument != null)
            {
                drawingCB.Items.Add(newDocument);
                drawingCB.SelectedItem = newDocument;
            }
            
        }

       

        private void BrowseForLaser(object sender, EventArgs e)
        {
            string newDocument = Controller.BrowseFile();
            if (newDocument != null)
            {
                laserCB.Items.Add(newDocument);
                laserCB.SelectedItem = newDocument;
            }
        
        }

        private void ConnectMenuListener(object sender, EventArgs e)
        {
            try
            {
                Controller.Refresh();
                RefreshConfig();
                RefreshLaser();
            }
            catch (NetworkException f)
            {
                MessageBox.Show(f.ErrorMessage);
            }
        }

        private void PrintMenuListener(object sender, EventArgs e)
        {
            Dictionary<string, string> output = new Dictionary<string, string>();

            string drawing = Controller.RemoveFullPath(drawingCB.SelectedItem as string, 1);
            string revision = "Rev" + Controller.RemoveFullPath(revisionCB.SelectedItem as string, 1);

            output.Add("drawing", drawing);
            output.Add("revision", revision);
            output.Add("misc", miscText.Text);
            output.Add("laser", laserCB.SelectedItem as string);

            try
            {
                Controller.Print(output);
            }
            catch (NetworkException f)
            {
                MessageBox.Show(f.ErrorMessage);
            }
        }




        /**
         * Paths
         * 
         **/

        private String BrowseFolder()
        {
            string folderPath = "";

            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }

            return folderPath + "\\";
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            Controller.RootPath = BrowseFolder();
            Save();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            Controller.DrawingPath = BrowseFolder();
            Save();
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            Controller.LaserPath = BrowseFolder();
            Save();
        }

        private void Save()
        {
            string[] output = new string[3];
            output[0] = Controller.RootPath;
            output[1] = Controller.DrawingPath;
            output[2] = Controller.LaserPath;

            SettingsLoader.Save(output);
        }

      






    } //class
} //namespace
