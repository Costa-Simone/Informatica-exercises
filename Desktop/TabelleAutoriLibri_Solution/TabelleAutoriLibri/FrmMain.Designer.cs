namespace TabelleAutoriLibri
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
            this.dgvLibri = new System.Windows.Forms.DataGridView();
            this.dgvAutori = new System.Windows.Forms.DataGridView();
            this.btnCeraLibriAutore = new System.Windows.Forms.Button();
            this.cmbAutori = new System.Windows.Forms.ComboBox();
            this.btnCercaLibriAutoreNazione = new System.Windows.Forms.Button();
            this.cmbNazione = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibri
            // 
            this.dgvLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibri.Location = new System.Drawing.Point(12, 12);
            this.dgvLibri.Name = "dgvLibri";
            this.dgvLibri.Size = new System.Drawing.Size(271, 150);
            this.dgvLibri.TabIndex = 0;
            // 
            // dgvAutori
            // 
            this.dgvAutori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutori.Location = new System.Drawing.Point(309, 12);
            this.dgvAutori.Name = "dgvAutori";
            this.dgvAutori.Size = new System.Drawing.Size(240, 150);
            this.dgvAutori.TabIndex = 1;
            // 
            // btnCeraLibriAutore
            // 
            this.btnCeraLibriAutore.Location = new System.Drawing.Point(168, 197);
            this.btnCeraLibriAutore.Name = "btnCeraLibriAutore";
            this.btnCeraLibriAutore.Size = new System.Drawing.Size(163, 40);
            this.btnCeraLibriAutore.TabIndex = 2;
            this.btnCeraLibriAutore.Text = "Cercare i libri di un autore in input attraverso combobox";
            this.btnCeraLibriAutore.UseVisualStyleBackColor = true;
            this.btnCeraLibriAutore.Click += new System.EventHandler(this.btnCeraLibriAutore_Click);
            // 
            // cmbAutori
            // 
            this.cmbAutori.FormattingEnabled = true;
            this.cmbAutori.Location = new System.Drawing.Point(25, 208);
            this.cmbAutori.Name = "cmbAutori";
            this.cmbAutori.Size = new System.Drawing.Size(121, 21);
            this.cmbAutori.TabIndex = 3;
            // 
            // btnCercaLibriAutoreNazione
            // 
            this.btnCercaLibriAutoreNazione.Location = new System.Drawing.Point(168, 243);
            this.btnCercaLibriAutoreNazione.Name = "btnCercaLibriAutoreNazione";
            this.btnCercaLibriAutoreNazione.Size = new System.Drawing.Size(163, 40);
            this.btnCercaLibriAutoreNazione.TabIndex = 4;
            this.btnCercaLibriAutoreNazione.Text = "Visualizzare i libri scritti da autori di una nazione in input via combo";
            this.btnCercaLibriAutoreNazione.UseVisualStyleBackColor = true;
            this.btnCercaLibriAutoreNazione.Click += new System.EventHandler(this.btnCercaLibriAutoreNazione_Click);
            // 
            // cmbNazione
            // 
            this.cmbNazione.FormattingEnabled = true;
            this.cmbNazione.Location = new System.Drawing.Point(25, 254);
            this.cmbNazione.Name = "cmbNazione";
            this.cmbNazione.Size = new System.Drawing.Size(121, 21);
            this.cmbNazione.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 368);
            this.Controls.Add(this.cmbNazione);
            this.Controls.Add(this.btnCercaLibriAutoreNazione);
            this.Controls.Add(this.cmbAutori);
            this.Controls.Add(this.btnCeraLibriAutore);
            this.Controls.Add(this.dgvAutori);
            this.Controls.Add(this.dgvLibri);
            this.Name = "frmMain";
            this.Text = "Tabelle Autori/Libri";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibri;
        private System.Windows.Forms.DataGridView dgvAutori;
        private System.Windows.Forms.Button btnCeraLibriAutore;
        private System.Windows.Forms.ComboBox cmbAutori;
        private System.Windows.Forms.Button btnCercaLibriAutoreNazione;
        private System.Windows.Forms.ComboBox cmbNazione;
    }
}

