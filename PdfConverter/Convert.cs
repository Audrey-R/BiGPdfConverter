using System;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace PdfConverter
{
    public class Convert
    {
        //Définition de variables pour ouverture du fichier
        private static object missingType = Type.Missing;
        private static object ConfirmConversions = false;
        private static object ReadOnly = false;
        private static object AddToRecentFiles = false;
        private static object PasswordDocument = missingType;
        private static object PasswordTemplate = missingType;
        private static object Revert = false;
        private static object WritePasswordDocument = missingType;
        private static object WritePasswordTemplate = missingType;
        private static object Format = WdOpenFormat.wdOpenFormatAuto;
        private static object Encoding = missingType;
        private static object Visible = false;
        private static object OpenAndRepair = false;
        private static object DocumentDirection = missingType;
        private static object NoEncodingDialog = true;
        private static object XMLTransform = missingType;

        //Définition de variables pour conversion du fichier en .docx
        private static object FileFormat = WdSaveFormat.wdFormatXMLDocument;
        private static object LockComments = false;
        private static object Password = missingType;
        private static object WritePassword = missingType;
        private static object ReadOnlyRecommended = false;
        private static object EmbedTrueTypeFonts = false;
        private static object SaveNativePictureFormat = false;
        private static object SaveFormsData = false;
        private static object SaveAsAOCELetter = false;
        private static object InsertLineBreaks = false;
        private static object AllowSubstitutions = false;
        private static object LineEnding = missingType;
        private static object AddBiDiMarks = missingType;
        private static object CompatibilityMode = 15;

        private static Document OpenAndConvertToWord(string pdfFile, string wordFile)
        {
            //Instanciation d'un nouvel objet Word
            Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();

            //Ouverture du fichier PDF dans Word
            Microsoft.Office.Interop.Word.Document document =
                application.Documents.Open(
                    pdfFile, ref ConfirmConversions,
                    ref ReadOnly, ref AddToRecentFiles,
                    ref PasswordDocument, ref PasswordTemplate,
                    ref Revert, ref WritePasswordDocument,
                    ref WritePasswordTemplate, ref Format,
                    ref Encoding, ref Visible,
                    ref OpenAndRepair, ref DocumentDirection,
                    ref NoEncodingDialog, ref XMLTransform
                );

            //Enregistrement du fichier PDF au format .docx
            document.SaveAs2(
                wordFile, FileFormat, LockComments,
                Password, AddToRecentFiles, WritePassword,
                ReadOnlyRecommended, EmbedTrueTypeFonts,
                SaveNativePictureFormat, SaveFormsData,
                SaveAsAOCELetter, Encoding, InsertLineBreaks,
                AllowSubstitutions, LineEnding, AddBiDiMarks,
                CompatibilityMode
            );

            return document;
        }

        public static void ConvertToWord(string pdfFile, string wordFile)
        {
            Document document = OpenAndConvertToWord(pdfFile, wordFile);
            document.Application.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            
            //Enregistrement du fichier PDF au format .docx
            document.SaveAs2(
                wordFile, FileFormat, LockComments,
                Password, AddToRecentFiles, WritePassword,
                ReadOnlyRecommended, EmbedTrueTypeFonts,
                SaveNativePictureFormat, SaveFormsData,
                SaveAsAOCELetter, Encoding, InsertLineBreaks,
                AllowSubstitutions, LineEnding, AddBiDiMarks,
                CompatibilityMode
            );

            // Fermeture des process liés au document
            foreach (System.Diagnostics.Process process in System.Diagnostics.Process.GetProcessesByName("WINWORD"))
            {
                process.Kill();
            }

            //Ouverture du document converti
            System.Diagnostics.Process.Start(wordFile);

            //Fermeture du formulaire 
            PdfConverter.ActiveForm.Close();
        }

        public static void ConvertToExcel(string pdfFile, string wordFile, string excelFile)
        {
            Document document = OpenAndConvertToWord(pdfFile, wordFile);
            document.Application.DisplayAlerts = WdAlertLevel.wdAlertsNone;

            //Copie des pages du fichier source
            document.Application.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            document.Application.Visible = false;
            document.Activate();
            document.ActiveWindow.Selection.WholeStory();
            document.ActiveWindow.Selection.Copy();

            //// Création d'un classeur de destination
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.DisplayAlerts = true;
            excel.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(missingType);
            Microsoft.Office.Interop.Excel._Worksheet activeSheet = excel.ActiveWorkbook.Sheets[1];
            
            //Collage des données dans le classeur
            Microsoft.Office.Interop.Excel.Range cellA1 = activeSheet.get_Range("A1", Type.Missing);
            cellA1.Select();
            activeSheet.PasteSpecial(
                "HTML", System.Type.Missing, System.Type.Missing, System.Type.Missing,
                System.Type.Missing, System.Type.Missing
                );

            //Enregistrement du classeur
            workbook.SaveAs(excelFile);

            //Fermeture des process de l'application Excel
            foreach (System.Diagnostics.Process process in System.Diagnostics.Process.GetProcessesByName("EXCEL"))
            {
                process.Kill();
            }
            //Fermeture des process de l'application Word
            foreach (System.Diagnostics.Process process in System.Diagnostics.Process.GetProcessesByName("WINWORD"))
            {
                process.Kill();
            }
            
            //Ouverture du document converti
            System.Diagnostics.Process.Start(excelFile);

            //Suppression du fichier Word créé pour la copie des données
            File.Delete(wordFile);

            //Fermeture du formulaire 
            PdfConverter.ActiveForm.Close();
        }
    }
}
