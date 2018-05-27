namespace PdfConverter
{
    partial class PdfConverter
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SelectPdf = new System.Windows.Forms.OpenFileDialog();
            this.SelectFile = new System.Windows.Forms.Button();
            this.Word = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Excel = new System.Windows.Forms.RadioButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectPdf
            // 
            this.SelectPdf.FileName = "Pdf";
            this.SelectPdf.Filter = "PDF Files|*.pdf";
            this.SelectPdf.FileOk += new System.ComponentModel.CancelEventHandler(this.SelectPdf_FileOk);
            // 
            // SelectFile
            // 
            this.SelectFile.AutoSize = true;
            this.SelectFile.BackColor = System.Drawing.Color.Plum;
            this.SelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SelectFile.FlatAppearance.BorderSize = 3;
            this.SelectFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.SelectFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFile.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SelectFile.Location = new System.Drawing.Point(41, 79);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(205, 35);
            this.SelectFile.TabIndex = 1;
            this.SelectFile.Text = "SELECTIONNER UN FICHIER";
            this.SelectFile.UseVisualStyleBackColor = false;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // Word
            // 
            this.Word.AutoSize = true;
            this.Word.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Word.Font = new System.Drawing.Font("Calibri", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Word.Location = new System.Drawing.Point(135, 36);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(66, 25);
            this.Word.TabIndex = 3;
            this.Word.TabStop = true;
            this.Word.Text = "Word";
            this.Word.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Convertir vers :";
            // 
            // Excel
            // 
            this.Excel.AutoSize = true;
            this.Excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Excel.Font = new System.Drawing.Font("Calibri", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Excel.Location = new System.Drawing.Point(207, 36);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(64, 25);
            this.Excel.TabIndex = 5;
            this.Excel.TabStop = true;
            this.Excel.Text = "Excel";
            this.Excel.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 145);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(254, 23);
            this.progressBar.TabIndex = 6;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PdfConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(286, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Excel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.SelectFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PdfConverter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PDF Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog SelectPdf;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.RadioButton Word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Excel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button1;
    }
}

