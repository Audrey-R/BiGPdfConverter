using System;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace PdfConverter
{
    public partial class PdfConverter : Form
    {
        public PdfConverter()
        {
            InitializeComponent();
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            if (SelectPdf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                timer.Enabled = true;
                timer.Start();
                timer.Interval = 1000;
                progressBar.Maximum = 10;
                timer.Tick += new EventHandler(timer_Tick);

                //Chemins des fichiers
                string path = System.IO.Path.GetDirectoryName(SelectPdf.FileName);
                string pdfFile = SelectPdf.FileName;
                string nameFile = System.IO.Path.GetFileNameWithoutExtension(SelectPdf.FileName);
                string wordFile = path + @"\" + nameFile + @".docx";
                string excelFile = path + @"\" + nameFile + @".xlsx";

                // Appel de la fonction de converion correspondante
                // dans la classe Convert
                if (Excel.Checked)
                    Convert.ConvertToExcel(pdfFile, wordFile, excelFile);
                if (Word.Checked)
                    Convert.ConvertToWord(pdfFile, wordFile);
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value != 10)
            {
                progressBar.Value++;
            }
            else
            {
                timer.Stop();
            }
        }

        private void SelectPdf_FileOk(object sender, CancelEventArgs e)
        {
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    timer.Start();
        //}

        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    progressBar.Increment(1);
        //}
    }
}
