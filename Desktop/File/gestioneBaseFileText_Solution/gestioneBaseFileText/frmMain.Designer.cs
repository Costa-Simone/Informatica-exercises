namespace gestioneBaseFileText
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLeggiDaFile = new System.Windows.Forms.Button();
            this.btnScriviSuFile = new System.Windows.Forms.Button();
            this.dgvLibri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeggiDaFile
            // 
            this.btnLeggiDaFile.Location = new System.Drawing.Point(12, 25);
            this.btnLeggiDaFile.Name = "btnLeggiDaFile";
            this.btnLeggiDaFile.Size = new System.Drawing.Size(96, 40);
            this.btnLeggiDaFile.TabIndex = 0;
            this.btnLeggiDaFile.Text = "LEGGI DA FILE";
            this.btnLeggiDaFile.UseVisualStyleBackColor = true;
            this.btnLeggiDaFile.Click += new System.EventHandler(this.btnLeggiDaFile_Click);
            // 
            // btnScriviSuFile
            // 
            this.btnScriviSuFile.Location = new System.Drawing.Point(12, 71);
            this.btnScriviSuFile.Name = "btnScriviSuFile";
            this.btnScriviSuFile.Size = new System.Drawing.Size(96, 40);
            this.btnScriviSuFile.TabIndex = 1;
            this.btnScriviSuFile.Text = "SCRIVI SU FILE";
            this.btnScriviSuFile.UseVisualStyleBackColor = true;
            this.btnScriviSuFile.Click += new System.EventHandler(this.btnScriviSuFile_Click);
            // 
            // dgvLibri
            // 
            this.dgvLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibri.Location = new System.Drawing.Point(114, 12);
            this.dgvLibri.Name = "dgvLibri";
            this.dgvLibri.Size = new System.Drawing.Size(245, 247);
            this.dgvLibri.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 272);
            this.Controls.Add(this.dgvLibri);
            this.Controls.Add(this.btnScriviSuFile);
            this.Controls.Add(this.btnLeggiDaFile);
            this.Name = "frmMain";
            this.Text = "Gestione base file Libri.txt";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeggiDaFile;
        private System.Windows.Forms.Button btnScriviSuFile;
        private System.Windows.Forms.DataGridView dgvLibri;
    }
}

