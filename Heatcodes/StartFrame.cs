﻿using System;
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
        public StartFrame() { controller = new Controller(); InitializeComponent(); CheckDebug(); }

        private Dictionary<string, string> drawingList = new Dictionary<string, string>();
        private Dictionary<string, string> laserList = new Dictionary<string, string>();
        private Dictionary<string, string> certList = new Dictionary<string, string>();
        private Dictionary<string, string> miscList = new Dictionary<string, string>();


        /*
         * Attempts to "connect" by loading the file lists, will also clear any manually browsed-for files
         */
        private void ConnectMenuListener(object sender, EventArgs e)
        {
            try
            {
                controller.LoadSettings();

                drawingList.Clear();
                drawingListBox.Items.Clear();
                laserList.Clear();
                certList.Clear();
                miscList.Clear();

                InitialBind(controller.DrawingList(), drawingList, drawingListBox);
                InitialBind(controller.LaserList(), laserList, laserCB);
                InitialBind(controller.CertList(), certList, certCB);
                InitialBind(controller.MiscList(), miscList, miscCB);
            }
            catch (NetworkException n)
            {
                MessageBox.Show(n.ErrorMessage);
            }
            

        }

        /*
         * Binds combobox to a dictionary
         */
        private void InitialBind(List<string> source, Dictionary<string, string> target, object display)
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
        private void Bind(Dictionary<string, string> target, object display)
        {
            if (display is ComboBox)
            {
                (display as ComboBox).DataSource = new BindingList<string>(target.Keys.ToList());
            }
            else if (display is ListBox)
            {

                foreach (string s in target.Keys)
                {
                    bool exists = false;

                    foreach (string v in (display as ListBox).Items)
                    {
                        if (v == s) 
                        {
                            exists = true;
                        }
                    }
                    if (!exists)
                    {
                        (display as ListBox).Items.Add(s);

                    }
                }
            }
        }

        
        /*
         * Functions for browsing for a file/folder that's stored in a different location
         */
        private void BrowseForDrawing(object sender, EventArgs e) { BrowseHelper(drawingList, drawingListBox, "file"); }
        private void BrowseForCertificate(object sender, EventArgs e) { BrowseHelper(certList, certCB, "file"); }
        private void BrowseForMisc(object sender, EventArgs e) { BrowseHelper(miscList, miscCB, "file"); }

        private void BrowseHelper(Dictionary<string,string> target, object display, string type)
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

                if (newDocument != null)
                {
                    if (display is ComboBox)
                    {
                        Bind(target, display as ComboBox);
                        (display as ComboBox).SelectedItem = key;
                    }

                    else if (display is ListBox)
                    {
                        Bind(target, display as ListBox);
                        (display as ListBox).SelectedItem = key;
                    }

                }
            }
        

        }


        /*
         * Previews
         */
        private void PreviewDocument(string path) { documentPreview.Navigate(path); }
        private void CertListListener(object sender, EventArgs e) { PreviewDocument(certList[certCB.SelectedItem.ToString()]); }
        private void MiscListListener(object sender, EventArgs e) { PreviewDocument(miscList[miscCB.SelectedItem.ToString()]); }
        private void DrawingListListener(object sender, EventArgs e) { PreviewDocument(drawingList[drawingListBox.SelectedItem.ToString()]); }


        /*
         * Menu options for changing paths
         */
        private void ChangeDrawingPath(object sender, EventArgs e) { controller.DrawingPath = controller.BrowseFolder(); Save(); }
        private void ChangeLaserPath(object sender, EventArgs e) { controller.LaserPath = controller.BrowseFolder(); Save(); }
        private void ChangeCertificatePath(object sender, EventArgs e) { controller.CertPath = controller.BrowseFolder(); Save(); }
        private void ChangeMiscPath(object sender, EventArgs e) { controller.MiscPath = controller.BrowseFolder(); Save(); }

        /*
         * Add or remove drawings
         */
        private void AddDrawingButtonListener(object sender, EventArgs e)
        {
            if (drawingListBox.SelectedItem != null)
            {
                chosenDrawingsListBox.Items.Add(drawingListBox.SelectedItem);
            }
        }

        private void RemoveDrawingButtonListener(object sender, EventArgs e)
        {
            if (chosenDrawingsListBox.SelectedItem != null)
            {
                chosenDrawingsListBox.Items.Remove(chosenDrawingsListBox.SelectedItem);
            }

        }

        /*
         * Saves current config to a textfile
         */
        private void Save()
        {
            string[] output = new string[4];
            output[0] = controller.DrawingPath;
            output[1] = controller.LaserPath;
            output[2] = controller.CertPath;
            output[3] = controller.MiscPath;

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
                split = split.Replace(".docx", "");
                split = split.Replace(".txt", "");


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
            Dictionary<string, object> output = new Dictionary<string, object>();

            output.Add("laser", laserCB.SelectedItem as string);
            output.Add("cert", certCB.SelectedItem as string);
            output.Add("misc", miscCB.SelectedItem as string);
            output.Add("note", noteText.Text);

            List<string> drawings = new List<string>();
            foreach (string s in chosenDrawingsListBox.Items)
            {
                drawings.Add(s);
            }
            output.Add("drawing", drawings);


            try
            {
                controller.Print(output);
            }
            catch (NetworkException f)
            {
                MessageBox.Show(f.ErrorMessage);
            }
        }

        /*
         * Function specifically to disable a missed debug flag
         */
        private void MenuToggleDebug(object sender, EventArgs e)
        {
            if (Global.debug)
            {
                Global.debug = false;
            }
            else
            {
                Global.debug = true;
            }
            CheckDebug();
           
        }
        /*
         * Help function for checking debug status
         */
        private void CheckDebug()
        {
            if (Global.debug)
            {
                debugLbl.Text = "Du är i debug-läge";
            }
            else
            {
                debugLbl.Text = "";
            }

        }

        

       

       


      


       


    } //class
} //namespace
