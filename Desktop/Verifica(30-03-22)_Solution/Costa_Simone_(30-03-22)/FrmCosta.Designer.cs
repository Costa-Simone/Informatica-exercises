namespace Costa_Simone__30_03_22_
{
    partial class FrmCosta
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
            this.dgvCandidati = new System.Windows.Forms.DataGridView();
            this.dgvPartito = new System.Windows.Forms.DataGridView();
            this.dgvVoti = new System.Windows.Forms.DataGridView();
            this.btnVincitore = new System.Windows.Forms.Button();
            this.btnSindaco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidati
            // 
            this.dgvCandidati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidati.Location = new System.Drawing.Point(12, 12);
            this.dgvCandidati.Name = "dgvCandidati";
            this.dgvCandidati.Size = new System.Drawing.Size(100, 150);
            this.dgvCandidati.TabIndex = 0;
            // 
            // dgvPartito
            // 
            this.dgvPartito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartito.Location = new System.Drawing.Point(118, 12);
            this.dgvPartito.Name = "dgvPartito";
            this.dgvPartito.Size = new System.Drawing.Size(100, 150);
            this.dgvPartito.TabIndex = 1;
            // 
            // dgvVoti
            // 
            this.dgvVoti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoti.Location = new System.Drawing.Point(224, 12);
            this.dgvVoti.Name = "dgvVoti";
            this.dgvVoti.Size = new System.Drawing.Size(400, 150);
            this.dgvVoti.TabIndex = 2;
            // 
            // btnVincitore
            // 
            this.btnVincitore.Location = new System.Drawing.Point(630, 12);
            this.btnVincitore.Name = "btnVincitore";
            this.btnVincitore.Size = new System.Drawing.Size(75, 40);
            this.btnVincitore.TabIndex = 3;
            this.btnVincitore.Text = "Visualizza partito vincitore";
            this.btnVincitore.UseVisualStyleBackColor = true;
            this.btnVincitore.Click += new System.EventHandler(this.btnVincitore_Click);
            // 
            // btnSindaco
            // 
            this.btnSindaco.Location = new System.Drawing.Point(630, 58);
            this.btnSindaco.Name = "btnSindaco";
            this.btnSindaco.Size = new System.Drawing.Size(75, 40);
            this.btnSindaco.TabIndex = 4;
            this.btnSindaco.Text = "Visualizza sindaco";
            this.btnSindaco.UseVisualStyleBackColor = true;
            this.btnSindaco.Click += new System.EventHandler(this.btnSindaco_Click);
            // 
            // FrmCosta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 174);
            this.Controls.Add(this.btnSindaco);
            this.Controls.Add(this.btnVincitore);
            this.Controls.Add(this.dgvVoti);
            this.Controls.Add(this.dgvPartito);
            this.Controls.Add(this.dgvCandidati);
            this.Name = "FrmCosta";
            this.Text = "Verifica_Costa";
            this.Load += new System.EventHandler(this.FrmCosta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidati;
        private System.Windows.Forms.DataGridView dgvPartito;
        private System.Windows.Forms.DataGridView dgvVoti;
        private System.Windows.Forms.Button btnVincitore;
        private System.Windows.Forms.Button btnSindaco;
    }
}

