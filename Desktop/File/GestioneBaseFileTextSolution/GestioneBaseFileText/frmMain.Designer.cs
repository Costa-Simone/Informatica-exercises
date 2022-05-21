namespace GestioneBaseFileText
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
            this.btnCercaLibriAutoreInput = new System.Windows.Forms.Button();
            this.btnCercaLibriAutoreCombo = new System.Windows.Forms.Button();
            this.cmbAutori = new System.Windows.Forms.ComboBox();
            this.btnCercaLibroTitolo = new System.Windows.Forms.Button();
            this.btnDividiFile = new System.Windows.Forms.Button();
            this.btnDidiviLibriAutore = new System.Windows.Forms.Button();
            this.btnContaLibriAutore = new System.Windows.Forms.Button();
            this.dgvAutori = new System.Windows.Forms.DataGridView();
            this.btnLibriNazione = new System.Windows.Forms.Button();
            this.btnAutorePiuLibri = new System.Windows.Forms.Button();
            this.btnCercaAutoreSenzaLibri = new System.Windows.Forms.Button();
            this.dgvEditori = new System.Windows.Forms.DataGridView();
            this.btnLibriAutoreEditore = new System.Windows.Forms.Button();
            this.btnCercaAutoriEditore = new System.Windows.Forms.Button();
            this.btnCreaFileEditore = new System.Windows.Forms.Button();
            this.cmbEditori = new System.Windows.Forms.ComboBox();
            this.btnConteggioLibriEditoreAutoristessaNazInput = new System.Windows.Forms.Button();
            this.btnEliminaLibro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditori)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeggiDaFile
            // 
            this.btnLeggiDaFile.Location = new System.Drawing.Point(134, 14);
            this.btnLeggiDaFile.Name = "btnLeggiDaFile";
            this.btnLeggiDaFile.Size = new System.Drawing.Size(117, 40);
            this.btnLeggiDaFile.TabIndex = 0;
            this.btnLeggiDaFile.Text = "LEGGI DA FILE";
            this.btnLeggiDaFile.UseVisualStyleBackColor = true;
            this.btnLeggiDaFile.Click += new System.EventHandler(this.btnLeggiDaFile_Click);
            // 
            // btnScriviSuFile
            // 
            this.btnScriviSuFile.Location = new System.Drawing.Point(134, 72);
            this.btnScriviSuFile.Name = "btnScriviSuFile";
            this.btnScriviSuFile.Size = new System.Drawing.Size(117, 40);
            this.btnScriviSuFile.TabIndex = 1;
            this.btnScriviSuFile.Text = "SCRIVI SU FILE";
            this.btnScriviSuFile.UseVisualStyleBackColor = true;
            this.btnScriviSuFile.Click += new System.EventHandler(this.btnScriviSuFile_Click);
            // 
            // dgvLibri
            // 
            this.dgvLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibri.Location = new System.Drawing.Point(283, 12);
            this.dgvLibri.Name = "dgvLibri";
            this.dgvLibri.RowHeadersWidth = 51;
            this.dgvLibri.Size = new System.Drawing.Size(345, 223);
            this.dgvLibri.TabIndex = 2;
            // 
            // btnCercaLibriAutoreInput
            // 
            this.btnCercaLibriAutoreInput.Location = new System.Drawing.Point(134, 129);
            this.btnCercaLibriAutoreInput.Name = "btnCercaLibriAutoreInput";
            this.btnCercaLibriAutoreInput.Size = new System.Drawing.Size(117, 40);
            this.btnCercaLibriAutoreInput.TabIndex = 3;
            this.btnCercaLibriAutoreInput.Text = "Cercare libri autore in input";
            this.btnCercaLibriAutoreInput.UseVisualStyleBackColor = true;
            this.btnCercaLibriAutoreInput.Click += new System.EventHandler(this.btnCercaLibriAutoreInput_Click);
            // 
            // btnCercaLibriAutoreCombo
            // 
            this.btnCercaLibriAutoreCombo.Location = new System.Drawing.Point(134, 175);
            this.btnCercaLibriAutoreCombo.Name = "btnCercaLibriAutoreCombo";
            this.btnCercaLibriAutoreCombo.Size = new System.Drawing.Size(117, 40);
            this.btnCercaLibriAutoreCombo.TabIndex = 4;
            this.btnCercaLibriAutoreCombo.Text = "Cercare libri autore in input via combo";
            this.btnCercaLibriAutoreCombo.UseVisualStyleBackColor = true;
            this.btnCercaLibriAutoreCombo.Click += new System.EventHandler(this.btnCercaLibriAutoreCombo_Click);
            // 
            // cmbAutori
            // 
            this.cmbAutori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutori.FormattingEnabled = true;
            this.cmbAutori.Location = new System.Drawing.Point(7, 175);
            this.cmbAutori.Name = "cmbAutori";
            this.cmbAutori.Size = new System.Drawing.Size(121, 21);
            this.cmbAutori.TabIndex = 5;
            // 
            // btnCercaLibroTitolo
            // 
            this.btnCercaLibroTitolo.Location = new System.Drawing.Point(134, 221);
            this.btnCercaLibroTitolo.Name = "btnCercaLibroTitolo";
            this.btnCercaLibroTitolo.Size = new System.Drawing.Size(117, 40);
            this.btnCercaLibroTitolo.TabIndex = 6;
            this.btnCercaLibroTitolo.Text = "Cercare libro titolo in input";
            this.btnCercaLibroTitolo.UseVisualStyleBackColor = true;
            this.btnCercaLibroTitolo.Click += new System.EventHandler(this.btnCercaLibroTitolo_Click);
            // 
            // btnDividiFile
            // 
            this.btnDividiFile.Location = new System.Drawing.Point(134, 268);
            this.btnDividiFile.Name = "btnDividiFile";
            this.btnDividiFile.Size = new System.Drawing.Size(117, 45);
            this.btnDividiFile.TabIndex = 7;
            this.btnDividiFile.Text = "Dividi i libri nei 2 anni";
            this.btnDividiFile.UseVisualStyleBackColor = true;
            this.btnDividiFile.Click += new System.EventHandler(this.btnDividiFile_Click);
            // 
            // btnDidiviLibriAutore
            // 
            this.btnDidiviLibriAutore.Location = new System.Drawing.Point(134, 319);
            this.btnDidiviLibriAutore.Name = "btnDidiviLibriAutore";
            this.btnDidiviLibriAutore.Size = new System.Drawing.Size(117, 38);
            this.btnDidiviLibriAutore.TabIndex = 8;
            this.btnDidiviLibriAutore.Text = "Dividi i libri per autore";
            this.btnDidiviLibriAutore.UseVisualStyleBackColor = true;
            this.btnDidiviLibriAutore.Click += new System.EventHandler(this.btnDidiviLibriAutore_Click);
            // 
            // btnContaLibriAutore
            // 
            this.btnContaLibriAutore.Location = new System.Drawing.Point(7, 221);
            this.btnContaLibriAutore.Name = "btnContaLibriAutore";
            this.btnContaLibriAutore.Size = new System.Drawing.Size(110, 40);
            this.btnContaLibriAutore.TabIndex = 9;
            this.btnContaLibriAutore.Text = "Contare libri autore in input via combo";
            this.btnContaLibriAutore.UseVisualStyleBackColor = true;
            this.btnContaLibriAutore.Click += new System.EventHandler(this.btnContaLibriAutore_Click);
            // 
            // dgvAutori
            // 
            this.dgvAutori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutori.Location = new System.Drawing.Point(634, 14);
            this.dgvAutori.Name = "dgvAutori";
            this.dgvAutori.RowHeadersWidth = 51;
            this.dgvAutori.Size = new System.Drawing.Size(336, 155);
            this.dgvAutori.TabIndex = 10;
            // 
            // btnLibriNazione
            // 
            this.btnLibriNazione.Location = new System.Drawing.Point(283, 254);
            this.btnLibriNazione.Name = "btnLibriNazione";
            this.btnLibriNazione.Size = new System.Drawing.Size(345, 23);
            this.btnLibriNazione.TabIndex = 11;
            this.btnLibriNazione.Text = "Cerca libri scitti da autori di una nazione in input";
            this.btnLibriNazione.UseVisualStyleBackColor = true;
            this.btnLibriNazione.Click += new System.EventHandler(this.btnLibriNazione_Click);
            // 
            // btnAutorePiuLibri
            // 
            this.btnAutorePiuLibri.Location = new System.Drawing.Point(283, 284);
            this.btnAutorePiuLibri.Name = "btnAutorePiuLibri";
            this.btnAutorePiuLibri.Size = new System.Drawing.Size(345, 23);
            this.btnAutorePiuLibri.TabIndex = 12;
            this.btnAutorePiuLibri.Text = "Cercare nome autore con più libri";
            this.btnAutorePiuLibri.UseVisualStyleBackColor = true;
            this.btnAutorePiuLibri.Click += new System.EventHandler(this.btnAutorePiuLibri_Click);
            // 
            // btnCercaAutoreSenzaLibri
            // 
            this.btnCercaAutoreSenzaLibri.Location = new System.Drawing.Point(283, 313);
            this.btnCercaAutoreSenzaLibri.Name = "btnCercaAutoreSenzaLibri";
            this.btnCercaAutoreSenzaLibri.Size = new System.Drawing.Size(345, 23);
            this.btnCercaAutoreSenzaLibri.TabIndex = 13;
            this.btnCercaAutoreSenzaLibri.Text = "Cercare autore senza libri";
            this.btnCercaAutoreSenzaLibri.UseVisualStyleBackColor = true;
            this.btnCercaAutoreSenzaLibri.Click += new System.EventHandler(this.btnCercaAutoreSenzaLibri_Click);
            // 
            // dgvEditori
            // 
            this.dgvEditori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditori.Location = new System.Drawing.Point(1009, 14);
            this.dgvEditori.Name = "dgvEditori";
            this.dgvEditori.RowHeadersWidth = 51;
            this.dgvEditori.Size = new System.Drawing.Size(354, 150);
            this.dgvEditori.TabIndex = 14;
            // 
            // btnLibriAutoreEditore
            // 
            this.btnLibriAutoreEditore.Location = new System.Drawing.Point(634, 192);
            this.btnLibriAutoreEditore.Name = "btnLibriAutoreEditore";
            this.btnLibriAutoreEditore.Size = new System.Drawing.Size(336, 23);
            this.btnLibriAutoreEditore.TabIndex = 15;
            this.btnLibriAutoreEditore.Text = "Cerca i libri di autore e editore in input";
            this.btnLibriAutoreEditore.UseVisualStyleBackColor = true;
            this.btnLibriAutoreEditore.Click += new System.EventHandler(this.btnLibriAutoreEditore_Click);
            // 
            // btnCercaAutoriEditore
            // 
            this.btnCercaAutoriEditore.Location = new System.Drawing.Point(635, 231);
            this.btnCercaAutoriEditore.Name = "btnCercaAutoriEditore";
            this.btnCercaAutoriEditore.Size = new System.Drawing.Size(335, 23);
            this.btnCercaAutoriEditore.TabIndex = 16;
            this.btnCercaAutoriEditore.Text = "Cerca gli autori che hanno scritto libri per un editore in input";
            this.btnCercaAutoriEditore.UseVisualStyleBackColor = true;
            this.btnCercaAutoriEditore.Click += new System.EventHandler(this.btnCercaAutoriEditore_Click);
            // 
            // btnCreaFileEditore
            // 
            this.btnCreaFileEditore.Location = new System.Drawing.Point(635, 261);
            this.btnCreaFileEditore.Name = "btnCreaFileEditore";
            this.btnCreaFileEditore.Size = new System.Drawing.Size(237, 23);
            this.btnCreaFileEditore.TabIndex = 17;
            this.btnCreaFileEditore.Text = "Crea un nuovo file con i libri di un editore scelto da combo";
            this.btnCreaFileEditore.UseVisualStyleBackColor = true;
            this.btnCreaFileEditore.Click += new System.EventHandler(this.btnCreaFileEditore_Click);
            // 
            // cmbEditori
            // 
            this.cmbEditori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditori.FormattingEnabled = true;
            this.cmbEditori.Location = new System.Drawing.Point(878, 263);
            this.cmbEditori.Name = "cmbEditori";
            this.cmbEditori.Size = new System.Drawing.Size(92, 21);
            this.cmbEditori.TabIndex = 18;
            // 
            // btnConteggioLibriEditoreAutoristessaNazInput
            // 
            this.btnConteggioLibriEditoreAutoristessaNazInput.Location = new System.Drawing.Point(635, 288);
            this.btnConteggioLibriEditoreAutoristessaNazInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConteggioLibriEditoreAutoristessaNazInput.Name = "btnConteggioLibriEditoreAutoristessaNazInput";
            this.btnConteggioLibriEditoreAutoristessaNazInput.Size = new System.Drawing.Size(334, 25);
            this.btnConteggioLibriEditoreAutoristessaNazInput.TabIndex = 19;
            this.btnConteggioLibriEditoreAutoristessaNazInput.Text = "Conta libri con autore e editore stessa nazione in input";
            this.btnConteggioLibriEditoreAutoristessaNazInput.UseVisualStyleBackColor = true;
            this.btnConteggioLibriEditoreAutoristessaNazInput.Click += new System.EventHandler(this.btnConteggioLibriEditoreAutoristessaNazInput_Click);
            // 
            // btnEliminaLibro
            // 
            this.btnEliminaLibro.Location = new System.Drawing.Point(1009, 192);
            this.btnEliminaLibro.Name = "btnEliminaLibro";
            this.btnEliminaLibro.Size = new System.Drawing.Size(354, 23);
            this.btnEliminaLibro.TabIndex = 20;
            this.btnEliminaLibro.Text = "Elimina libro dato il codic";
            this.btnEliminaLibro.UseVisualStyleBackColor = true;
            this.btnEliminaLibro.Click += new System.EventHandler(this.btnEliminaLibro_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 380);
            this.Controls.Add(this.btnEliminaLibro);
            this.Controls.Add(this.btnConteggioLibriEditoreAutoristessaNazInput);
            this.Controls.Add(this.cmbEditori);
            this.Controls.Add(this.btnCreaFileEditore);
            this.Controls.Add(this.btnCercaAutoriEditore);
            this.Controls.Add(this.btnLibriAutoreEditore);
            this.Controls.Add(this.dgvEditori);
            this.Controls.Add(this.btnCercaAutoreSenzaLibri);
            this.Controls.Add(this.btnAutorePiuLibri);
            this.Controls.Add(this.btnLibriNazione);
            this.Controls.Add(this.dgvAutori);
            this.Controls.Add(this.btnContaLibriAutore);
            this.Controls.Add(this.btnDidiviLibriAutore);
            this.Controls.Add(this.btnDividiFile);
            this.Controls.Add(this.btnCercaLibroTitolo);
            this.Controls.Add(this.cmbAutori);
            this.Controls.Add(this.btnCercaLibriAutoreCombo);
            this.Controls.Add(this.btnCercaLibriAutoreInput);
            this.Controls.Add(this.dgvLibri);
            this.Controls.Add(this.btnScriviSuFile);
            this.Controls.Add(this.btnLeggiDaFile);
            this.Name = "frmMain";
            this.Text = "Gestione base file Libri.txt";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeggiDaFile;
        private System.Windows.Forms.Button btnScriviSuFile;
        private System.Windows.Forms.DataGridView dgvLibri;
        private System.Windows.Forms.Button btnCercaLibriAutoreInput;
        private System.Windows.Forms.Button btnCercaLibriAutoreCombo;
        private System.Windows.Forms.ComboBox cmbAutori;
        private System.Windows.Forms.Button btnCercaLibroTitolo;
        private System.Windows.Forms.Button btnDividiFile;
        private System.Windows.Forms.Button btnDidiviLibriAutore;
        private System.Windows.Forms.Button btnContaLibriAutore;
        private System.Windows.Forms.DataGridView dgvAutori;
        private System.Windows.Forms.Button btnLibriNazione;
        private System.Windows.Forms.Button btnAutorePiuLibri;
        private System.Windows.Forms.Button btnCercaAutoreSenzaLibri;
        private System.Windows.Forms.DataGridView dgvEditori;
        private System.Windows.Forms.Button btnLibriAutoreEditore;
        private System.Windows.Forms.Button btnCercaAutoriEditore;
        private System.Windows.Forms.Button btnCreaFileEditore;
        private System.Windows.Forms.ComboBox cmbEditori;
        private System.Windows.Forms.Button btnConteggioLibriEditoreAutoristessaNazInput;
        private System.Windows.Forms.Button btnEliminaLibro;
    }
}

