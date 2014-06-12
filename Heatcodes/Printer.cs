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


        public void Print(Dictionary<string, string> output)
        {
            var label = DYMO.Label.Framework.Label.Open(Application.GetResourceStream(new Uri(barcodeTemplateName, UriKind.Relative)).Stream);

            string barcodeData = string.Format("{0} - Laser: {1} - Cert: {2} - Misc: {3}", output["drawing"], output["laser"], output["cert"], output["misc"]);
                
            label.SetObjectText("BARCODE", barcodeData);
            label.SetObjectText("TEXT", output["note"]);

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
