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

        //forwarding
        private Controller controller;

        //constuctor
        public StartFrame() { controller = new Controller(); InitializeComponent(); }

        private Dictionary<string, string> drawingList = new Dictionary<string, string>();
        private Dictionary<string, string> laserList = new Dictionary<string, string>();
        private Dictionary<string, string> certList = new Dictionary<string, string>();


        /*
         * Attempts to "connect" by loading the file lists, will also clear any manually browsed-for files
         */
        private void ConnectMenuListener(object sender, EventArgs e)
        {
            drawingList.Clear();
            laserList.Clear();
            certList.Clear();

            InitialBind(controller.DrawingList(), drawingList, drawingCB);
            InitialBind(controller.LaserList(), laserList, laserCB);
            InitialBind(controller.CertList(), certList, certCB);

        }

        /*
         * Binds combobox to a dictionary
         */
        private void InitialBind(List<string> source, Dictionary<string, string> target, ComboBox display)
        {
            foreach (string s in source)
            {
                target.Add(RemoveFullPath(s, 1), s);
            }

            Bind(target, display);
        }

        /*
         * Shared binding functionality
         */
        private void Bind(Dictionary<string, string> target, ComboBox display)
        {
            display.DataSource = new BindingList<string>(target.Keys.ToList());
        }

        
        /*
         * Functions for browsing for a file/folder that's stored in a different location
         */
        private void BrowseForDrawing(object sender, EventArgs e) { BrowseHelper(drawingList, drawingCB, "file"); }
        private void BrowseForLaser(object sender, EventArgs e) { BrowseHelper(laserList, laserCB, "folder"); }
        private void BrowseForCertificate(object sender, EventArgs e) { BrowseHelper(certList, certCB, "file"); }

        private void BrowseHelper(Dictionary<string,string> target, ComboBox display, string type)
        {
            string newDocument = null;

            if (type == "file")
            {
                newDocument = controller.BrowseFile();
            }

            else if (type == "folder")
            {
                newDocument = controller.BrowseFolder();
            }

            if (newDocument != null)
            {
                string key = RemoveFullPath(newDocument, 1);
                target.Add(key, newDocument);
                Bind(target, display);
                display.SelectedItem = key;
            }

        }


        /*
         * Method for previewing a document
         */
        private void PreviewDocument(string path)
        {
            documentPreview.Navigate(path);
        }

        /*
         * Listeners that trigger a preview
         */
        private void DrawingListListener(object sender, EventArgs e)
        {
           PreviewDocument(drawingList[drawingCB.SelectedItem.ToString()]);
        }

        private void RevisionListListener(object sender, EventArgs e)
        {

        }

        private void CertListListener(object sender, EventArgs e)
        {
            PreviewDocument(certList[certCB.SelectedItem.ToString()]);

        }


        /*
         * Menu options for changing paths
         */
        private void ChangeDrawingPath(object sender, EventArgs e) { controller.DrawingPath = controller.BrowseFolder(); Save(); }
        private void ChangeLaserPath(object sender, EventArgs e) { controller.LaserPath = controller.BrowseFolder(); Save(); }
        private void ChangeCertificatePath(object sender, EventArgs e) { controller.CertPath = controller.BrowseFolder(); Save(); }


        /*
         * Saves current config to a textfile
         */
        private void Save()
        {
            string[] output = new string[3];
            output[0] = controller.DrawingPath;
            output[1] = controller.LaserPath;
            output[2] = controller.CertPath;

            SettingsLoader.Save(output);
        }


        /*
         * Display function; clears path to a set number of remaining backslashes
         */
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

                return split;
            }
            else
            {
                return null;
            }

        }


      /*
      * Prints current selection
      */
        private void PrintMenuListener(object sender, EventArgs e)
        {
            Dictionary<string, string> output = new Dictionary<string, string>();

            output.Add("drawing", drawingCB.SelectedItem.ToString());
            output.Add("laser", laserCB.SelectedItem.ToString());
            output.Add("cert", certCB.SelectedItem.ToString());
            output.Add("misc", miscText.Text);

            try
            {
                controller.Print(output);
            }
            catch (NetworkException f)
            {
                MessageBox.Show(f.ErrorMessage);
            }
        }


       


    } //class
} //namespace
