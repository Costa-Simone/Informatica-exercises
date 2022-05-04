namespace Ex12pag150
{
    partial class FrmMain
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
            this.dgvAtleti = new System.Windows.Forms.DataGridView();
            this.lblAtleti = new System.Windows.Forms.Label();
            this.lblProve = new System.Windows.Forms.Label();
            this.dgvProve = new System.Windows.Forms.DataGridView();
            this.lblClassifica = new System.Windows.Forms.Label();
            this.dgvClassifica = new System.Windows.Forms.DataGridView();
            this.btnClassificaParziale = new System.Windows.Forms.Button();
            this.btnClassificaTotale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtleti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassifica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAtleti
            // 
            this.dgvAtleti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtleti.Location = new System.Drawing.Point(12, 35);
            this.dgvAtleti.Name = "dgvAtleti";
            this.dgvAtleti.Size = new System.Drawing.Size(100, 150);
            this.dgvAtleti.TabIndex = 0;
            // 
            // lblAtleti
            // 
            this.lblAtleti.Location = new System.Drawing.Point(12, 9);
            this.lblAtleti.Name = "lblAtleti";
            this.lblAtleti.Size = new System.Drawing.Size(100, 23);
            this.lblAtleti.TabIndex = 1;
            this.lblAtleti.Text = "Atleti";
            this.lblAtleti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProve
            // 
            this.lblProve.Location = new System.Drawing.Point(118, 9);
            this.lblProve.Name = "lblProve";
            this.lblProve.Size = new System.Drawing.Size(503, 23);
            this.lblProve.TabIndex = 2;
            this.lblProve.Text = "Prove";
            this.lblProve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProve
            // 
            this.dgvProve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProve.Location = new System.Drawing.Point(121, 35);
            this.dgvProve.Name = "dgvProve";
            this.dgvProve.Size = new System.Drawing.Size(500, 150);
            this.dgvProve.TabIndex = 3;
            // 
            // lblClassifica
            // 
            this.lblClassifica.Location = new System.Drawing.Point(627, 9);
            this.lblClassifica.Name = "lblClassifica";
            this.lblClassifica.Size = new System.Drawing.Size(100, 23);
            this.lblClassifica.TabIndex = 4;
            this.lblClassifica.Text = "Classifica";
            this.lblClassifica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvClassifica
            // 
            this.dgvClassifica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassifica.Location = new System.Drawing.Point(630, 35);
            this.dgvClassifica.Name = "dgvClassifica";
            this.dgvClassifica.Size = new System.Drawing.Size(100, 150);
            this.dgvClassifica.TabIndex = 5;
            // 
            // btnClassificaParziale
            // 
            this.btnClassificaParziale.Location = new System.Drawing.Point(736, 35);
            this.btnClassificaParziale.Name = "btnClassificaParziale";
            this.btnClassificaParziale.Size = new System.Drawing.Size(75, 42);
            this.btnClassificaParziale.TabIndex = 6;
            this.btnClassificaParziale.Text = "Classifica Parziale";
            this.btnClassificaParziale.UseVisualStyleBackColor = true;
            this.btnClassificaParziale.Click += new System.EventHandler(this.btnClassificaParziale_Click);
            // 
            // btnClassificaTotale
            // 
            this.btnClassificaTotale.Location = new System.Drawing.Point(736, 83);
            this.btnClassificaTotale.Name = "btnClassificaTotale";
            this.btnClassificaTotale.Size = new System.Drawing.Size(75, 42);
            this.btnClassificaTotale.TabIndex = 7;
            this.btnClassificaTotale.Text = "Classifica Totale";
            this.btnClassificaTotale.UseVisualStyleBackColor = true;
            this.btnClassificaTotale.Click += new System.EventHandler(this.btnClassificaTotale_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 191);
            this.Controls.Add(this.btnClassificaTotale);
            this.Controls.Add(this.btnClassificaParziale);
            this.Controls.Add(this.dgvClassifica);
            this.Controls.Add(this.lblClassifica);
            this.Controls.Add(this.dgvProve);
            this.Controls.Add(this.lblProve);
            this.Controls.Add(this.lblAtleti);
            this.Controls.Add(this.dgvAtleti);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtleti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassifica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAtleti;
        private System.Windows.Forms.Label lblAtleti;
        private System.Windows.Forms.Label lblProve;
        private System.Windows.Forms.DataGridView dgvProve;
        private System.Windows.Forms.Label lblClassifica;
        private System.Windows.Forms.DataGridView dgvClassifica;
        private System.Windows.Forms.Button btnClassificaParziale;
        private System.Windows.Forms.Button btnClassificaTotale;
    }
}

