using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DYMO;

namespace HeatCodes
{
    class Controller
    {
        private Printer printer;
        private DataAccessLayer dal;

        //forwarding
        internal DataAccessLayer Dal { get { return dal; } set { dal = value; } }
        internal Printer Printer { get { return printer; } set { printer = value; } }

        //constructor
        public Controller() { Printer = new Printer(); Dal = new DataAccessLayer();  }

        //printer
        public void Print(Dictionary<string, string> output) { Printer.Print(output); }

        //paths
        public string DrawingPath { get { return dal.DrawingPath; } set { dal.DrawingPath = value; } }
        public string LaserPath { get { return dal.LaserPath; } set { dal.LaserPath = value; } }
        public string CertPath { get { return dal.CertPath; } set { dal.CertPath = value; } }

        //lists
        public List<string> DrawingList() { return dal.DrawingList(); }
        public List<string> LaserList() { return dal.LaserList(); }
        public List<string> CertList() { return dal.CertList(); }

        //browsing
        public string BrowseFile(){ return dal.BrowseFile();}
        public String BrowseFolder() { return dal.BrowseFolder(); }
       



    } //class
} //namespace
