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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfConverter));
            this.SelectPdf = new System.Windows.Forms.OpenFileDialog();
            this.SelectFile = new System.Windows.Forms.Button();
            this.WordOption = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ExcelOption = new System.Windows.Forms.RadioButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SelectPdf
            // 
            this.SelectPdf.FileName = "Pdf";
            this.SelectPdf.Filter = "PDF Files|*.pdf";
            // 
            // SelectFile
            // 
            this.SelectFile.AutoSize = true;
            this.SelectFile.BackColor = System.Drawing.Color.Gainsboro;
            this.SelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SelectFile.FlatAppearance.BorderSize = 3;
            this.SelectFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.SelectFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectFile.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SelectFile.Image = ((System.Drawing.Image)(resources.GetObject("SelectFile.Image")));
            this.SelectFile.Location = new System.Drawing.Point(115, 77);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(60, 67);
            this.SelectFile.TabIndex = 1;
            this.SelectFile.UseVisualStyleBackColor = false;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // WordOption
            // 
            this.WordOption.AutoSize = true;
            this.WordOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WordOption.Font = new System.Drawing.Font("Calibri", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.WordOption.Location = new System.Drawing.Point(135, 36);
            this.WordOption.Name = "WordOption";
            this.WordOption.Size = new System.Drawing.Size(66, 25);
            this.WordOption.TabIndex = 3;
            this.WordOption.TabStop = true;
            this.WordOption.Text = "Word";
            this.WordOption.UseVisualStyleBackColor = true;
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
            // ExcelOption
            // 
            this.ExcelOption.AutoSize = true;
            this.ExcelOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExcelOption.Font = new System.Drawing.Font("Calibri", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcelOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ExcelOption.Location = new System.Drawing.Point(207, 36);
            this.ExcelOption.Name = "ExcelOption";
            this.ExcelOption.Size = new System.Drawing.Size(64, 25);
            this.ExcelOption.TabIndex = 5;
            this.ExcelOption.TabStop = true;
            this.ExcelOption.Text = "Excel";
            this.ExcelOption.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 163);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(254, 12);
            this.progressBar.TabIndex = 6;
            // 
            // PdfConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(286, 201);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ExcelOption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WordOption);
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
        private System.Windows.Forms.RadioButton WordOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ExcelOption;
        private System.Windows.Forms.ProgressBar progressBar;
        public System.Windows.Forms.Timer timer;
    }
}

