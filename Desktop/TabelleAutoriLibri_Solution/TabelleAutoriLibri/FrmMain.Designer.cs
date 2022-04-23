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
            this.btnContaLibriGeneri = new System.Windows.Forms.Button();
            this.dgvGeneri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneri)).BeginInit();
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
            this.dgvAutori.Location = new System.Drawing.Point(289, 12);
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
            this.btnCercaLibriAutoreNazione.Size = new System.Drawing.Size(163, 52);
            this.btnCercaLibriAutoreNazione.TabIndex = 4;
            this.btnCercaLibriAutoreNazione.Text = "Visualizzare i libri scritti da autori di una nazione in input via combo";
            this.btnCercaLibriAutoreNazione.UseVisualStyleBackColor = true;
            this.btnCercaLibriAutoreNazione.Click += new System.EventHandler(this.btnCercaLibriAutoreNazione_Click);
            // 
            // cmbNazione
            // 
            this.cmbNazione.FormattingEnabled = true;
            this.cmbNazione.Location = new System.Drawing.Point(25, 260);
            this.cmbNazione.Name = "cmbNazione";
            this.cmbNazione.Size = new System.Drawing.Size(121, 21);
            this.cmbNazione.TabIndex = 5;
            // 
            // btnContaLibriGeneri
            // 
            this.btnContaLibriGeneri.Location = new System.Drawing.Point(168, 301);
            this.btnContaLibriGeneri.Name = "btnContaLibriGeneri";
            this.btnContaLibriGeneri.Size = new System.Drawing.Size(163, 58);
            this.btnContaLibriGeneri.TabIndex = 6;
            this.btnContaLibriGeneri.Text = "Contare per ogni genere il numero di libri stampando output in nuova dgv";
            this.btnContaLibriGeneri.UseVisualStyleBackColor = true;
            this.btnContaLibriGeneri.Click += new System.EventHandler(this.btnContaLibriGeneri_Click);
            // 
            // dgvGeneri
            // 
            this.dgvGeneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneri.Location = new System.Drawing.Point(535, 12);
            this.dgvGeneri.Name = "dgvGeneri";
            this.dgvGeneri.Size = new System.Drawing.Size(138, 150);
            this.dgvGeneri.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 371);
            this.Controls.Add(this.dgvGeneri);
            this.Controls.Add(this.btnContaLibriGeneri);
            this.Controls.Add(this.cmbNazione);
            this.Controls.Add(this.btnCercaLibriAutoreNazione);
            this.Controls.Add(this.cmbAutori);
            this.Controls.Add(this.btnCeraLibriAutore);
            this.Controls.Add(this.dgvAutori);
            this.Controls.Add(this.dgvLibri);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabelle Autori/Libri";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibri;
        private System.Windows.Forms.DataGridView dgvAutori;
        private System.Windows.Forms.Button btnCeraLibriAutore;
        private System.Windows.Forms.ComboBox cmbAutori;
        private System.Windows.Forms.Button btnCercaLibriAutoreNazione;
        private System.Windows.Forms.ComboBox cmbNazione;
        private System.Windows.Forms.Button btnContaLibriGeneri;
        private System.Windows.Forms.DataGridView dgvGeneri;
    }
}

