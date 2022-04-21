namespace TabelleAutoriLibri
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
            this.dgvLibri = new System.Windows.Forms.DataGridView();
            this.dgvAutori = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibri
            // 
            this.dgvLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibri.Location = new System.Drawing.Point(12, 12);
            this.dgvLibri.Name = "dgvLibri";
            this.dgvLibri.Size = new System.Drawing.Size(240, 150);
            this.dgvLibri.TabIndex = 0;
            // 
            // dgvAutori
            // 
            this.dgvAutori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutori.Location = new System.Drawing.Point(258, 12);
            this.dgvAutori.Name = "dgvAutori";
            this.dgvAutori.Size = new System.Drawing.Size(240, 150);
            this.dgvAutori.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAutori);
            this.Controls.Add(this.dgvLibri);
            this.Name = "FrmMain";
            this.Text = "Tabelle Libri Autori";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibri;
        private System.Windows.Forms.DataGridView dgvAutori;
    }
}

