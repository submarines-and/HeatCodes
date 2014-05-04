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
        private readonly String barcodeTemplateName = "alt1.label";
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
                //MessageBox.Show("Inga printers anslutna");
            }
        }


        public void Print(Dictionary<string, string> output)
        {
            var label = DYMO.Label.Framework.Label.Open(Application.GetResourceStream(new Uri(barcodeTemplateName, UriKind.Relative)).Stream);

            string barcodeData = output["drawing"]
                                + " "
                                + output["revision"]
                                + " "
                                + output["laser"];


            label.SetObjectText("BARCODE", barcodeData);
            label.SetObjectText("TEXT", output["misc"]);

           

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
