namespace VettoreConGriglia
{
    partial class FrmVettoreConGriglia
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
            this.DgvVettore = new System.Windows.Forms.DataGridView();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnMassimo = new System.Windows.Forms.Button();
            this.btnContaPariDispari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVettore)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvVettore
            // 
            this.DgvVettore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVettore.Location = new System.Drawing.Point(12, 12);
            this.DgvVettore.Name = "DgvVettore";
            this.DgvVettore.Size = new System.Drawing.Size(143, 408);
            this.DgvVettore.TabIndex = 0;
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(194, 12);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(75, 23);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = true;
            // 
            // btnMassimo
            // 
            this.btnMassimo.Location = new System.Drawing.Point(194, 42);
            this.btnMassimo.Name = "btnMassimo";
            this.btnMassimo.Size = new System.Drawing.Size(75, 23);
            this.btnMassimo.TabIndex = 2;
            this.btnMassimo.Text = "Massimo";
            this.btnMassimo.UseVisualStyleBackColor = true;
            // 
            // btnContaPariDispari
            // 
            this.btnContaPariDispari.Location = new System.Drawing.Point(194, 71);
            this.btnContaPariDispari.Name = "btnContaPariDispari";
            this.btnContaPariDispari.Size = new System.Drawing.Size(75, 43);
            this.btnContaPariDispari.TabIndex = 3;
            this.btnContaPariDispari.Text = "Conta Pari Dispari";
            this.btnContaPariDispari.UseVisualStyleBackColor = true;
            // 
            // FrmVettoreConGriglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 450);
            this.Controls.Add(this.btnContaPariDispari);
            this.Controls.Add(this.btnMassimo);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.DgvVettore);
            this.Name = "FrmVettoreConGriglia";
            this.Text = "Gestione vettore con data grid view";
            this.Load += new System.EventHandler(this.FrmVettoreConGriglia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVettore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvVettore;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnMassimo;
        private System.Windows.Forms.Button btnContaPariDispari;
    }
}

