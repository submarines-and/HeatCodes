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

        //folders
        public void Refresh() { dal.Refresh(); }
        public List<List<string>> Drawings { get { return dal.Drawings; } set { dal.Drawings = value; } }
        public List<string> Lasers { get { return dal.Lasers; }  set { dal.Lasers = value; } }

        //paths
        public string RootPath { get { return dal.RootPath; } }
        public string LaserPath { get { return dal.LaserPath; } }
        public string DrawingPath { get { return dal.DrawingPath; } }

        //misc? lol
        public string BrowseFile() { return dal.BrowseFile(); }
        public string RemoveFullPath(string input, int count) { return dal.RemoveFullPath(input, count); }


    } //class
} //namespace
