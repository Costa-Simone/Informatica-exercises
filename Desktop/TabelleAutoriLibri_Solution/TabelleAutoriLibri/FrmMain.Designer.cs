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
            this.cmbNazioni = new System.Windows.Forms.ComboBox();
            this.btnContaLibriGenere = new System.Windows.Forms.Button();
            this.dgvGeneriLibri = new System.Windows.Forms.DataGridView();
            this.btnAutoreScarso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneriLibri)).BeginInit();
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
            this.cmbAutori.Location = new System.Drawing.Point(25, 197);
            this.cmbAutori.Name = "cmbAutori";
            this.cmbAutori.Size = new System.Drawing.Size(121, 21);
            this.cmbAutori.TabIndex = 3;
            // 
            // btnCercaLibriAutoreNazione
            // 
            this.btnCercaLibriAutoreNazione.Location = new System.Drawing.Point(168, 252);
            this.btnCercaLibriAutoreNazione.Name = "btnCercaLibriAutoreNazione";
            this.btnCercaLibriAutoreNazione.Size = new System.Drawing.Size(163, 62);
            this.btnCercaLibriAutoreNazione.TabIndex = 4;
            this.btnCercaLibriAutoreNazione.Text = "Visualizzare i libri scritti da autori di una nazione in input via combo";
            this.btnCercaLibriAutoreNazione.UseVisualStyleBackColor = true;
            this.btnCercaLibriAutoreNazione.Click += new System.EventHandler(this.btnCercaLibriAutoreNazione_Click);
            // 
            // cmbNazioni
            // 
            this.cmbNazioni.FormattingEnabled = true;
            this.cmbNazioni.Location = new System.Drawing.Point(25, 252);
            this.cmbNazioni.Name = "cmbNazioni";
            this.cmbNazioni.Size = new System.Drawing.Size(121, 21);
            this.cmbNazioni.TabIndex = 5;
            // 
            // btnContaLibriGenere
            // 
            this.btnContaLibriGenere.Location = new System.Drawing.Point(360, 197);
            this.btnContaLibriGenere.Name = "btnContaLibriGenere";
            this.btnContaLibriGenere.Size = new System.Drawing.Size(163, 62);
            this.btnContaLibriGenere.TabIndex = 6;
            this.btnContaLibriGenere.Text = "Contare per ogni genere il numero di libri stampando output in nuova DGV";
            this.btnContaLibriGenere.UseVisualStyleBackColor = true;
            this.btnContaLibriGenere.Click += new System.EventHandler(this.btnContaLibriGenere_Click);
            // 
            // dgvGeneriLibri
            // 
            this.dgvGeneriLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneriLibri.Location = new System.Drawing.Point(552, 197);
            this.dgvGeneriLibri.Name = "dgvGeneriLibri";
            this.dgvGeneriLibri.Size = new System.Drawing.Size(240, 150);
            this.dgvGeneriLibri.TabIndex = 7;
            // 
            // btnAutoreScarso
            // 
            this.btnAutoreScarso.Location = new System.Drawing.Point(360, 265);
            this.btnAutoreScarso.Name = "btnAutoreScarso";
            this.btnAutoreScarso.Size = new System.Drawing.Size(163, 64);
            this.btnAutoreScarso.TabIndex = 8;
            this.btnAutoreScarso.Text = "Cercare l\'autore che ha scritto meno libri";
            this.btnAutoreScarso.UseVisualStyleBackColor = true;
            this.btnAutoreScarso.Click += new System.EventHandler(this.btnAutoreScarso_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 368);
            this.Controls.Add(this.btnAutoreScarso);
            this.Controls.Add(this.dgvGeneriLibri);
            this.Controls.Add(this.btnContaLibriGenere);
            this.Controls.Add(this.cmbNazioni);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneriLibri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibri;
        private System.Windows.Forms.DataGridView dgvAutori;
        private System.Windows.Forms.Button btnCeraLibriAutore;
        private System.Windows.Forms.ComboBox cmbAutori;
        private System.Windows.Forms.Button btnCercaLibriAutoreNazione;
        private System.Windows.Forms.ComboBox cmbNazioni;
        private System.Windows.Forms.Button btnContaLibriGenere;
        private System.Windows.Forms.DataGridView dgvGeneriLibri;
        private System.Windows.Forms.Button btnAutoreScarso;
    }
}

