using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office.Word;
using System.IO;
using System.IO.Packaging;
using DocumentFormat;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;


namespace Hometask7
{
    class DOCHandler : AbstractHandler
    {


        public override void Change(string fullName)
        {
            WordprocessingDocument wordprocessingDocument =
                WordprocessingDocument.Open(fullName, true);

            // Assign a reference to the existing document body.
            Body body = wordprocessingDocument.MainDocumentPart.Document.Body;

            // Add new text.
            Paragraph para = body.AppendChild(new Paragraph());
            Run run = para.AppendChild(new Run());
            Console.WriteLine("Put your text");
            run.AppendChild(new Text(Console.ReadLine()));

            // Close the handle explicitly.
            wordprocessingDocument.Close();
        }

        public override void Open(string fullName)
        {

            using (WordprocessingDocument wordDocument =
                WordprocessingDocument.Open(fullName, false))
            {
                // Assign a reference to the existing document body.  
                Body body = wordDocument.MainDocumentPart.Document.Body;

                // Attempt to add some text.
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text("Append text in body, but text is not saved - OpenWordprocessingDocumentReadonly"));

                // Call Save to generate an exception and show that access is read-only.
                // wordDocument.MainDocumentPart.Document.Save();
            }
        }
            //    Body body = wordprocessingDocument.MainDocumentPart.Document.Body;
            //    Console.WriteLine();
            //}

        

        public override void Save(string fullName)
        {
            //document.Save();
            //document.Close();
        }

      
    }
}
