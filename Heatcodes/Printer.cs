using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HeatCodes
{
    class Printer
    {
        private readonly String barcodeTemplateName = "small.label";
        private DYMO.Label.Framework.IPrinter currentPrinter;

        public Printer()
        {
            List<DYMO.Label.Framework.IPrinter> printers = new List<DYMO.Label.Framework.IPrinter>();
            foreach (var s in DYMO.Label.Framework.Framework.GetLabelWriterPrinters())
                printers.Add(s);

            try
            {
                currentPrinter = printers[0];

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Inga printers anslutna");
            }
        }


        public void Print(Dictionary<string, object> output)
        {
            var label = DYMO.Label.Framework.Label.Open(Application.GetResourceStream(new Uri(barcodeTemplateName, UriKind.Relative)).Stream);

            string laser = output["laser"] as string;
            string cert = output["cert"] as string;
            string config = output["misc"] as string;
            
            string drawings = "";
            List<string> drawingsList = output["drawing"] as List<string>;
            int size = drawingsList.Count;
            int i = 1;
            foreach(string s in drawingsList)
            {
                drawings += s;
                if(i < size)
                {
                    drawings += ", ";
                }

                i++;
            }

            string barcodeData = string.Format("{0} - Laser: {1} - Cert: {2} - Config: {3}", drawings, laser, cert, config);

            MessageBox.Show(barcodeData);
                
            label.SetObjectText("BARCODE", barcodeData);
            label.SetObjectText("TEXT", output["note"] as string);

            try
            {
                label.Print(currentPrinter);
            }
            catch (Exception)
            {
                throw new NetworkException("Ingen printer ansluten");
            }
            

        }

       
    } //class
} //namespace
