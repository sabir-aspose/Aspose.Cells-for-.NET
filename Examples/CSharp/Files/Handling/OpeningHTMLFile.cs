using System.IO;

using Aspose.Cells;
using System;

namespace Aspose.Cells.Examples.Files.Handling
{
    public class OpeningHTMLFile
    {
        public static void Main(string[] args)
        {
            //ExStart:1
            // The path to the documents directory.
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


            string filePath = dataDir + "Book1.html";

            //Instantiate LoadOptions specified by the LoadFormat.
            HTMLLoadOptions loadOptions = new HTMLLoadOptions(LoadFormat.Html);

            //Create a Workbook object and opening the file from its path
            Workbook wb = new Workbook(filePath, loadOptions);
            //Save the MHT file
            wb.Save(filePath + ".out.xlsx");
            //ExEnd:1


        }
    }
}