using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace PdfConverter
{
    public class Word
    {
        public Application WordApp { get; set; }
        public Document WordDocument { get; set; }

        public Word()
        {
            WordApp = new Application();
        }

        public void OuvrirPdf(string pdfFile)
        {
            WordDocument = WordApp.Documents.Open(
                    pdfFile, false,false, false,Type.Missing, 
                    Type.Missing, false, Type.Missing,
                    Type.Missing, WdOpenFormat.wdOpenFormatAuto,
                    Type.Missing, false, false, Type.Missing,
                    true, Type.Missing
                );
        }

        public void CopierLesDonnees()
        {
            WordDocument.Activate();
            WordDocument.ActiveWindow.Selection.WholeStory();
            WordDocument.ActiveWindow.Selection.Copy();
        }

        public void EnregistrerPdfAuFormatWord(string wordFile)
        {
            WordDocument.Application.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            WordDocument.SaveAs2(
                    wordFile, WdSaveFormat.wdFormatXMLDocument, false,
                    Type.Missing, false, Type.Missing,
                    false, false,false, false,
                    false, Type.Missing, false,
                    false, Type.Missing, Type.Missing,15
            );
        }

        public void AfficherDocument()
        {
            WordApp.Visible = true;
        }

        public void FermerDocumentEtApplication()
        {
            WordApp.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            WordDocument.Close();
            WordApp.Quit();
        }

        public void FermerTousLesProcessus()
        {
            foreach (System.Diagnostics.Process process in System.Diagnostics.Process.GetProcessesByName("WINWORD"))
            {
                process.Kill();
            }
        }

        public void OuvrirDocumentEnregistre(string wordFile)
        {
            System.Diagnostics.Process.Start(wordFile);
        }
    }
}
