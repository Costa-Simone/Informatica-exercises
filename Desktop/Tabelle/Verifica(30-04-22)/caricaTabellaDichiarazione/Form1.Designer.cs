namespace caricaTabellaDichiarazione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
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
            this.btnEsercizio = new System.Windows.Forms.Button();
            this.dgvClassifica = new System.Windows.Forms.DataGridView();
            this.btnClassificaParimerito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassifica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEsercizio
            // 
            this.btnEsercizio.Location = new System.Drawing.Point(12, 12);
            this.btnEsercizio.Name = "btnEsercizio";
            this.btnEsercizio.Size = new System.Drawing.Size(579, 40);
            this.btnEsercizio.TabIndex = 0;
            this.btnEsercizio.Text = "Visualizzare in una griglia la classifica dei cantanti in base al venduto totale " +
    "delle loro canzoni.\r\n ";
            this.btnEsercizio.UseVisualStyleBackColor = true;
            this.btnEsercizio.Click += new System.EventHandler(this.btnEsercizio_Click);
            // 
            // dgvClassifica
            // 
            this.dgvClassifica.AllowUserToAddRows = false;
            this.dgvClassifica.AllowUserToDeleteRows = false;
            this.dgvClassifica.AllowUserToResizeColumns = false;
            this.dgvClassifica.AllowUserToResizeRows = false;
            this.dgvClassifica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassifica.Location = new System.Drawing.Point(12, 104);
            this.dgvClassifica.Name = "dgvClassifica";
            this.dgvClassifica.ReadOnly = true;
            this.dgvClassifica.Size = new System.Drawing.Size(212, 150);
            this.dgvClassifica.TabIndex = 1;
            // 
            // btnClassificaParimerito
            // 
            this.btnClassificaParimerito.Location = new System.Drawing.Point(12, 58);
            this.btnClassificaParimerito.Name = "btnClassificaParimerito";
            this.btnClassificaParimerito.Size = new System.Drawing.Size(579, 40);
            this.btnClassificaParimerito.TabIndex = 2;
            this.btnClassificaParimerito.Text = "Visualizzare in una griglia la classifica dei cantanti in base al venduto totale " +
    "delle loro canzoni con parimerito ";
            this.btnClassificaParimerito.UseVisualStyleBackColor = true;
            this.btnClassificaParimerito.Click += new System.EventHandler(this.btnClassificaParimerito_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 289);
            this.Controls.Add(this.btnClassificaParimerito);
            this.Controls.Add(this.dgvClassifica);
            this.Controls.Add(this.btnEsercizio);
            this.Name = "Form1";
            this.Text = "Metttere il vostro cognome";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassifica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEsercizio;
        private System.Windows.Forms.DataGridView dgvClassifica;
        private System.Windows.Forms.Button btnClassificaParimerito;
    }
}

