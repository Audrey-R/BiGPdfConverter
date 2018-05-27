using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace PdfConverter
{
    public class Excel
    {
        public Application ExcelApp { get; set; }
        public Workbook Workbook { get; set; }
        public _Worksheet ActiveSheet { get; set; }
        public Range CellA1 { get; set; }

        public Excel()
        {
            ExcelApp = new Application();
            ExcelApp.Application.DisplayAlerts = true;
            ExcelApp.Visible = false;
            Workbook = ExcelApp.Workbooks.Add(Type.Missing);
            ActiveSheet = ExcelApp.ActiveWorkbook.Sheets[1];
            CellA1 = ActiveSheet.get_Range("A1", Type.Missing);
        }

        public void CollerLesDonnees()
        {
            CellA1.Select();
            ActiveSheet.PasteSpecial(
                "HTML", System.Type.Missing, System.Type.Missing, System.Type.Missing,
                System.Type.Missing, System.Type.Missing
            );
        }

        public void AfficherClasseur()
        {
            ExcelApp.Visible = true;
        }

        public void EnregistrerClasseur(string excelFile)
        {
            Workbook.Application.DisplayAlerts = false;
            Workbook.SaveAs(excelFile);
        }

        public void FermerTousLesProcessus()
        {
            foreach (System.Diagnostics.Process process in System.Diagnostics.Process.GetProcessesByName("EXCEL"))
            {
                process.Kill();
            }
        }

        public void OuvrirClasseurEnregistre(string excelFile)
        {
            System.Diagnostics.Process.Start(excelFile);
        }

        void Application_WorkbookAfterSave(Workbook Workbook, bool Success)
        {
            Workbook.Close();
            ExcelApp.Quit();
        }
    }
}
