using System;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using PdfConverterLibrary;

namespace PdfConverter
{
    public partial class PdfConverter : Form
    {
        private Timer time = new Timer();
        private int counter {get; set;}

        public PdfConverter()
        {
            InitializeComponent();
            progressBar.Maximum = 10;
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            if(ExcelOption.Checked || WordOption.Checked)
            {
                if (SelectPdf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Chemins des fichiers
                    string path = System.IO.Path.GetDirectoryName(SelectPdf.FileName);
                    string pdfFile = SelectPdf.FileName;
                    string nameFile = System.IO.Path.GetFileNameWithoutExtension(SelectPdf.FileName);
                    string wordFile = path + @"\" + nameFile + @".docx";
                    string excelFile = path + @"\" + nameFile + @".xlsx";


                    // Conversion au format Excel
                    if (ExcelOption.Checked)
                    {
                        InitializeMyTimerExcel();
                        Word word = new Word();
                        Timer_Tick_Excel(null, null);
                        word.OuvrirPdf(pdfFile);
                        Timer_Tick_Excel(null, null);
                        word.CopierLesDonnees();
                        Timer_Tick_Excel(null, null);
                        Excel excel = new Excel();
                        Timer_Tick_Excel(null, null);
                        excel.CollerLesDonnees();
                        Timer_Tick_Excel(null, null);
                        //excel.EnregistrerClasseur(excelFile);
                        //Timer_Tick_Excel(null, null);
                        //word.FermerTousLesProcessus();
                        //Timer_Tick_Excel(null, null);
                        //excel.FermerTousLesProcessus();
                        //Timer_Tick_Excel(null, null);
                        word.FermerDocumentEtApplication();
                        Timer_Tick_Excel(null, null);
                        excel.AfficherClasseur();
                        //excel.OuvrirClasseurEnregistre(excelFile);
                    }

                    //Converison au format Word
                    else if (WordOption.Checked)
                    {
                        InitializeMyTimerWord();
                        Word word = new Word();
                        Timer_Tick_Word(null, null);
                        word.OuvrirPdf(pdfFile);
                        Timer_Tick_Word(null, null);
                        //word.EnregistrerPdfAuFormatWord(wordFile);
                        //Timer_Tick_Word(null, null);
                        word.AfficherDocument();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Aucun fichier sélectionné.", "ATTENTION !", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Selectionnez un format de conversion.", "ATTENTION !", MessageBoxButtons.OK);
            }
        }

        private void InitializeMyTimerExcel()
        {
            counter = 0;
            time.Enabled = true;
            Timer_Tick_Excel(null, null);
            time.Tick += new EventHandler(Timer_Tick_Excel);
        }

        private void Timer_Tick_Excel(object sender, EventArgs e)
        {
            if (counter >= 10)
            {
                timer.Enabled = false;
            }
            else
            {
                //do something here
                counter++;
                progressBar.Increment(2);
            }
        }

        private void InitializeMyTimerWord()
        {
            counter = 0;
            time.Enabled = true;
            Timer_Tick_Word(null, null);
            time.Tick += new EventHandler(Timer_Tick_Word);
        }

        private void Timer_Tick_Word(object sender, EventArgs e)
        {
            if (counter >= 10)
            {
                time.Enabled = false;
            }
            else
            {
                counter++;
                progressBar.Increment(5);
            }
        }
    }
}
