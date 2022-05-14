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
            this.btnCercareLibriAutore = new System.Windows.Forms.Button();
            this.btnCercareAutoriInputCombo = new System.Windows.Forms.Button();
            this.cmbAutori = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFileLibriAnno = new System.Windows.Forms.Button();
            this.btnDividiLibriAutore = new System.Windows.Forms.Button();
            this.btnContaLibriAutore = new System.Windows.Forms.Button();
            this.btnLibriNazione = new System.Windows.Forms.Button();
            this.dgvAutori = new System.Windows.Forms.DataGridView();
            this.btnAutorePiuLibri = new System.Windows.Forms.Button();
            this.btnAutoreNessunLibro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).BeginInit();
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
            this.dgvLibri.Location = new System.Drawing.Point(254, 12);
            this.dgvLibri.Name = "dgvLibri";
            this.dgvLibri.Size = new System.Drawing.Size(245, 247);
            this.dgvLibri.TabIndex = 2;
            // 
            // btnCercareLibriAutore
            // 
            this.btnCercareLibriAutore.Location = new System.Drawing.Point(12, 117);
            this.btnCercareLibriAutore.Name = "btnCercareLibriAutore";
            this.btnCercareLibriAutore.Size = new System.Drawing.Size(96, 40);
            this.btnCercareLibriAutore.TabIndex = 3;
            this.btnCercareLibriAutore.Text = "CERCARE LIBRI AUTORE INPUT";
            this.btnCercareLibriAutore.UseVisualStyleBackColor = true;
            this.btnCercareLibriAutore.Click += new System.EventHandler(this.btnCercareLibriAutore_Click);
            // 
            // btnCercareAutoriInputCombo
            // 
            this.btnCercareAutoriInputCombo.Location = new System.Drawing.Point(12, 163);
            this.btnCercareAutoriInputCombo.Name = "btnCercareAutoriInputCombo";
            this.btnCercareAutoriInputCombo.Size = new System.Drawing.Size(96, 53);
            this.btnCercareAutoriInputCombo.TabIndex = 4;
            this.btnCercareAutoriInputCombo.Text = "CERCARE LIBRI AUTORE INPUT VIA COMBO";
            this.btnCercareAutoriInputCombo.UseVisualStyleBackColor = true;
            this.btnCercareAutoriInputCombo.Click += new System.EventHandler(this.btnCercareAutoriInputCombo_Click);
            // 
            // cmbAutori
            // 
            this.cmbAutori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutori.FormattingEnabled = true;
            this.cmbAutori.Location = new System.Drawing.Point(114, 25);
            this.cmbAutori.Name = "cmbAutori";
            this.cmbAutori.Size = new System.Drawing.Size(134, 21);
            this.cmbAutori.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "CERCARE LIBRI CON TITOLO\r\n IN INPUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFileLibriAnno
            // 
            this.btnFileLibriAnno.Location = new System.Drawing.Point(12, 281);
            this.btnFileLibriAnno.Name = "btnFileLibriAnno";
            this.btnFileLibriAnno.Size = new System.Drawing.Size(96, 66);
            this.btnFileLibriAnno.TabIndex = 7;
            this.btnFileLibriAnno.Text = "CREARE FILE CON LIBRI SUDDIVISI PER ANNO";
            this.btnFileLibriAnno.UseVisualStyleBackColor = true;
            this.btnFileLibriAnno.Click += new System.EventHandler(this.btnFileLibriAnno_Click);
            // 
            // btnDividiLibriAutore
            // 
            this.btnDividiLibriAutore.Location = new System.Drawing.Point(114, 281);
            this.btnDividiLibriAutore.Name = "btnDividiLibriAutore";
            this.btnDividiLibriAutore.Size = new System.Drawing.Size(96, 66);
            this.btnDividiLibriAutore.TabIndex = 8;
            this.btnDividiLibriAutore.Text = "CREARE FILE CON LIBRI SUDDIVISI PER AUTORE\r\n";
            this.btnDividiLibriAutore.UseVisualStyleBackColor = true;
            this.btnDividiLibriAutore.Click += new System.EventHandler(this.btnDividiLibriAutore_Click);
            // 
            // btnContaLibriAutore
            // 
            this.btnContaLibriAutore.Location = new System.Drawing.Point(216, 281);
            this.btnContaLibriAutore.Name = "btnContaLibriAutore";
            this.btnContaLibriAutore.Size = new System.Drawing.Size(96, 66);
            this.btnContaLibriAutore.TabIndex = 9;
            this.btnContaLibriAutore.Text = "CONTA I LIBRI DI UN AUTORE IN INPUT CON COMBOBOX\r\n";
            this.btnContaLibriAutore.UseVisualStyleBackColor = true;
            this.btnContaLibriAutore.Click += new System.EventHandler(this.btnContaLibriAutore_Click);
            // 
            // btnLibriNazione
            // 
            this.btnLibriNazione.Location = new System.Drawing.Point(792, 26);
            this.btnLibriNazione.Name = "btnLibriNazione";
            this.btnLibriNazione.Size = new System.Drawing.Size(96, 85);
            this.btnLibriNazione.TabIndex = 10;
            this.btnLibriNazione.Text = "CERCA LIBRI SCRITTI DA AUTORI NAZIONE IN INPUT";
            this.btnLibriNazione.UseVisualStyleBackColor = true;
            this.btnLibriNazione.Click += new System.EventHandler(this.btnLibriNazione_Click);
            // 
            // dgvAutori
            // 
            this.dgvAutori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutori.Location = new System.Drawing.Point(505, 12);
            this.dgvAutori.Name = "dgvAutori";
            this.dgvAutori.Size = new System.Drawing.Size(260, 247);
            this.dgvAutori.TabIndex = 11;
            // 
            // btnAutorePiuLibri
            // 
            this.btnAutorePiuLibri.Location = new System.Drawing.Point(792, 117);
            this.btnAutorePiuLibri.Name = "btnAutorePiuLibri";
            this.btnAutorePiuLibri.Size = new System.Drawing.Size(96, 52);
            this.btnAutorePiuLibri.TabIndex = 12;
            this.btnAutorePiuLibri.Text = "CERCARE NOME AUTORE CON PIU LIBRI\r\n\r\n\r\n";
            this.btnAutorePiuLibri.UseVisualStyleBackColor = true;
            this.btnAutorePiuLibri.Click += new System.EventHandler(this.btnAutorePiuLibri_Click);
            // 
            // btnAutoreNessunLibro
            // 
            this.btnAutoreNessunLibro.Location = new System.Drawing.Point(792, 175);
            this.btnAutoreNessunLibro.Name = "btnAutoreNessunLibro";
            this.btnAutoreNessunLibro.Size = new System.Drawing.Size(96, 63);
            this.btnAutoreNessunLibro.TabIndex = 13;
            this.btnAutoreNessunLibro.Text = "CERCARE NOME AUTORE CON NESSUN LIBRO\r\n\r\n\r\n\r\n";
            this.btnAutoreNessunLibro.UseVisualStyleBackColor = true;
            this.btnAutoreNessunLibro.Click += new System.EventHandler(this.btnAutoreNessunLibro_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 363);
            this.Controls.Add(this.btnAutoreNessunLibro);
            this.Controls.Add(this.btnAutorePiuLibri);
            this.Controls.Add(this.dgvAutori);
            this.Controls.Add(this.btnLibriNazione);
            this.Controls.Add(this.btnContaLibriAutore);
            this.Controls.Add(this.btnDividiLibriAutore);
            this.Controls.Add(this.btnFileLibriAnno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbAutori);
            this.Controls.Add(this.btnCercareAutoriInputCombo);
            this.Controls.Add(this.btnCercareLibriAutore);
            this.Controls.Add(this.dgvLibri);
            this.Controls.Add(this.btnScriviSuFile);
            this.Controls.Add(this.btnLeggiDaFile);
            this.Name = "frmMain";
            this.Text = "Gestione base file Libri.txt";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeggiDaFile;
        private System.Windows.Forms.Button btnScriviSuFile;
        private System.Windows.Forms.DataGridView dgvLibri;
        private System.Windows.Forms.Button btnCercareLibriAutore;
        private System.Windows.Forms.Button btnCercareAutoriInputCombo;
        private System.Windows.Forms.ComboBox cmbAutori;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFileLibriAnno;
        private System.Windows.Forms.Button btnDividiLibriAutore;
        private System.Windows.Forms.Button btnContaLibriAutore;
        private System.Windows.Forms.Button btnLibriNazione;
        private System.Windows.Forms.DataGridView dgvAutori;
        private System.Windows.Forms.Button btnAutorePiuLibri;
        private System.Windows.Forms.Button btnAutoreNessunLibro;
    }
}

