
namespace GestioneTabella
{
    partial class FormMain
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
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricola = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.btnInserisciStudente = new System.Windows.Forms.Button();
            this.gbRicerche = new System.Windows.Forms.GroupBox();
            this.cmbRicercaClasse = new System.Windows.Forms.ComboBox();
            this.btnCercaClasse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTogliFiltro = new System.Windows.Forms.Button();
            this.txtCercaMatricola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCercaMatricola = new System.Windows.Forms.Button();
            this.gbOrdinamenti = new System.Windows.Forms.GroupBox();
            this.btnOrdinaCognome = new System.Windows.Forms.Button();
            this.btnOrdinaMatricola = new System.Windows.Forms.Button();
            this.dgvValutazioni = new System.Windows.Forms.DataGridView();
            this.btnInserisciVoto = new System.Windows.Forms.Button();
            this.cmbMatricola = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numVoto = new System.Windows.Forms.NumericUpDown();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMediaVotiMateria = new System.Windows.Forms.Button();
            this.btnMediaVotiClasse = new System.Windows.Forms.Button();
            this.btnMateriaPiuInsuff = new System.Windows.Forms.Button();
            this.btnStudenteMediaMax = new System.Windows.Forms.Button();
            this.btnMediaVotiStudente = new System.Windows.Forms.Button();
            this.btnMateriaPiuVoti = new System.Windows.Forms.Button();
            this.btnMediaStudenti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.gbRicerche.SuspendLayout();
            this.gbOrdinamenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValutazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(11, 9);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.Size = new System.Drawing.Size(283, 240);
            this.dgvStudenti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricola:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cognome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Classe:";
            // 
            // txtMatricola
            // 
            this.txtMatricola.Location = new System.Drawing.Point(71, 265);
            this.txtMatricola.Name = "txtMatricola";
            this.txtMatricola.Size = new System.Drawing.Size(115, 20);
            this.txtMatricola.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 305);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(115, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(71, 341);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(115, 20);
            this.txtCognome.TabIndex = 7;
            // 
            // cmbClasse
            // 
            this.cmbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Items.AddRange(new object[] {
            "1 INF A",
            "2 INF A",
            "3 INF A"});
            this.cmbClasse.Location = new System.Drawing.Point(71, 379);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(115, 21);
            this.cmbClasse.TabIndex = 8;
            // 
            // btnInserisciStudente
            // 
            this.btnInserisciStudente.Location = new System.Drawing.Point(15, 415);
            this.btnInserisciStudente.Name = "btnInserisciStudente";
            this.btnInserisciStudente.Size = new System.Drawing.Size(171, 23);
            this.btnInserisciStudente.TabIndex = 9;
            this.btnInserisciStudente.Text = "INSERISCI STUDENTE";
            this.btnInserisciStudente.UseVisualStyleBackColor = true;
            this.btnInserisciStudente.Click += new System.EventHandler(this.btnInserisciStudente_Click);
            // 
            // gbRicerche
            // 
            this.gbRicerche.Controls.Add(this.cmbRicercaClasse);
            this.gbRicerche.Controls.Add(this.btnCercaClasse);
            this.gbRicerche.Controls.Add(this.label6);
            this.gbRicerche.Controls.Add(this.btnTogliFiltro);
            this.gbRicerche.Controls.Add(this.txtCercaMatricola);
            this.gbRicerche.Controls.Add(this.label5);
            this.gbRicerche.Controls.Add(this.btnCercaMatricola);
            this.gbRicerche.Location = new System.Drawing.Point(221, 265);
            this.gbRicerche.Name = "gbRicerche";
            this.gbRicerche.Size = new System.Drawing.Size(247, 173);
            this.gbRicerche.TabIndex = 11;
            this.gbRicerche.TabStop = false;
            this.gbRicerche.Text = "CERCA STUDENTI";
            // 
            // cmbRicercaClasse
            // 
            this.cmbRicercaClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRicercaClasse.FormattingEnabled = true;
            this.cmbRicercaClasse.Items.AddRange(new object[] {
            "1 INF A",
            "2 INF A",
            "3 INF A"});
            this.cmbRicercaClasse.Location = new System.Drawing.Point(65, 80);
            this.cmbRicercaClasse.Name = "cmbRicercaClasse";
            this.cmbRicercaClasse.Size = new System.Drawing.Size(176, 21);
            this.cmbRicercaClasse.TabIndex = 7;
            // 
            // btnCercaClasse
            // 
            this.btnCercaClasse.Location = new System.Drawing.Point(6, 107);
            this.btnCercaClasse.Name = "btnCercaClasse";
            this.btnCercaClasse.Size = new System.Drawing.Size(235, 23);
            this.btnCercaClasse.TabIndex = 6;
            this.btnCercaClasse.Text = "Ricerca per Classe";
            this.btnCercaClasse.UseVisualStyleBackColor = true;
            this.btnCercaClasse.Click += new System.EventHandler(this.btnCercaClasse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Classe:";
            // 
            // btnTogliFiltro
            // 
            this.btnTogliFiltro.BackgroundImage = global::GestioneTabella.Properties.Resources.remove_filter;
            this.btnTogliFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTogliFiltro.Location = new System.Drawing.Point(216, 141);
            this.btnTogliFiltro.Name = "btnTogliFiltro";
            this.btnTogliFiltro.Size = new System.Drawing.Size(30, 30);
            this.btnTogliFiltro.TabIndex = 3;
            this.btnTogliFiltro.UseVisualStyleBackColor = true;
            this.btnTogliFiltro.Click += new System.EventHandler(this.btnTogliFiltro_Click);
            // 
            // txtCercaMatricola
            // 
            this.txtCercaMatricola.Location = new System.Drawing.Point(65, 24);
            this.txtCercaMatricola.Name = "txtCercaMatricola";
            this.txtCercaMatricola.Size = new System.Drawing.Size(176, 20);
            this.txtCercaMatricola.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Matricola:";
            // 
            // btnCercaMatricola
            // 
            this.btnCercaMatricola.Location = new System.Drawing.Point(6, 50);
            this.btnCercaMatricola.Name = "btnCercaMatricola";
            this.btnCercaMatricola.Size = new System.Drawing.Size(235, 23);
            this.btnCercaMatricola.TabIndex = 0;
            this.btnCercaMatricola.Text = "Ricerca per Matricola";
            this.btnCercaMatricola.UseVisualStyleBackColor = true;
            this.btnCercaMatricola.Click += new System.EventHandler(this.btnCercaMatricola_Click);
            // 
            // gbOrdinamenti
            // 
            this.gbOrdinamenti.Controls.Add(this.btnOrdinaCognome);
            this.gbOrdinamenti.Controls.Add(this.btnOrdinaMatricola);
            this.gbOrdinamenti.Location = new System.Drawing.Point(504, 382);
            this.gbOrdinamenti.Name = "gbOrdinamenti";
            this.gbOrdinamenti.Size = new System.Drawing.Size(247, 94);
            this.gbOrdinamenti.TabIndex = 8;
            this.gbOrdinamenti.TabStop = false;
            this.gbOrdinamenti.Text = "ORDINA STUDENTI";
            // 
            // btnOrdinaCognome
            // 
            this.btnOrdinaCognome.Location = new System.Drawing.Point(6, 62);
            this.btnOrdinaCognome.Name = "btnOrdinaCognome";
            this.btnOrdinaCognome.Size = new System.Drawing.Size(235, 23);
            this.btnOrdinaCognome.TabIndex = 1;
            this.btnOrdinaCognome.Text = "Ordina per Cognome";
            this.btnOrdinaCognome.UseVisualStyleBackColor = true;
            this.btnOrdinaCognome.Click += new System.EventHandler(this.btnOrdinaCognome_Click);
            // 
            // btnOrdinaMatricola
            // 
            this.btnOrdinaMatricola.Location = new System.Drawing.Point(6, 33);
            this.btnOrdinaMatricola.Name = "btnOrdinaMatricola";
            this.btnOrdinaMatricola.Size = new System.Drawing.Size(235, 23);
            this.btnOrdinaMatricola.TabIndex = 0;
            this.btnOrdinaMatricola.Text = "Ordina per Matricola";
            this.btnOrdinaMatricola.UseVisualStyleBackColor = true;
            this.btnOrdinaMatricola.Click += new System.EventHandler(this.btnOrdinaMatricola_Click);
            // 
            // dgvValutazioni
            // 
            this.dgvValutazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValutazioni.Location = new System.Drawing.Point(312, 9);
            this.dgvValutazioni.Name = "dgvValutazioni";
            this.dgvValutazioni.Size = new System.Drawing.Size(273, 240);
            this.dgvValutazioni.TabIndex = 12;
            // 
            // btnInserisciVoto
            // 
            this.btnInserisciVoto.Location = new System.Drawing.Point(607, 122);
            this.btnInserisciVoto.Name = "btnInserisciVoto";
            this.btnInserisciVoto.Size = new System.Drawing.Size(171, 23);
            this.btnInserisciVoto.TabIndex = 21;
            this.btnInserisciVoto.Text = "INSERISCI VOTO";
            this.btnInserisciVoto.UseVisualStyleBackColor = true;
            this.btnInserisciVoto.Click += new System.EventHandler(this.btnInserisciVoto_Click);
            // 
            // cmbMatricola
            // 
            this.cmbMatricola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatricola.FormattingEnabled = true;
            this.cmbMatricola.Location = new System.Drawing.Point(663, 86);
            this.cmbMatricola.Name = "cmbMatricola";
            this.cmbMatricola.Size = new System.Drawing.Size(115, 21);
            this.cmbMatricola.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Matricola:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(604, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Materia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(604, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Voto:";
            // 
            // numVoto
            // 
            this.numVoto.Location = new System.Drawing.Point(663, 13);
            this.numVoto.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numVoto.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numVoto.Name = "numVoto";
            this.numVoto.Size = new System.Drawing.Size(115, 20);
            this.numVoto.TabIndex = 22;
            this.numVoto.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Items.AddRange(new object[] {
            "Italiano",
            "Inglese",
            "Informatica",
            "Sistemi",
            "Matematica"});
            this.cmbMateria.Location = new System.Drawing.Point(663, 48);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(115, 21);
            this.cmbMateria.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMediaStudenti);
            this.groupBox1.Controls.Add(this.btnMateriaPiuVoti);
            this.groupBox1.Controls.Add(this.btnMediaVotiMateria);
            this.groupBox1.Controls.Add(this.btnMediaVotiClasse);
            this.groupBox1.Controls.Add(this.btnMateriaPiuInsuff);
            this.groupBox1.Controls.Add(this.btnStudenteMediaMax);
            this.groupBox1.Controls.Add(this.btnMediaVotiStudente);
            this.groupBox1.Location = new System.Drawing.Point(605, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 219);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUERY";
            // 
            // btnMediaVotiMateria
            // 
            this.btnMediaVotiMateria.Location = new System.Drawing.Point(6, 132);
            this.btnMediaVotiMateria.Name = "btnMediaVotiMateria";
            this.btnMediaVotiMateria.Size = new System.Drawing.Size(165, 23);
            this.btnMediaVotiMateria.TabIndex = 4;
            this.btnMediaVotiMateria.Text = "Media voti materia";
            this.btnMediaVotiMateria.UseVisualStyleBackColor = true;
            this.btnMediaVotiMateria.Click += new System.EventHandler(this.btnMediaVotiMateria_Click);
            // 
            // btnMediaVotiClasse
            // 
            this.btnMediaVotiClasse.Location = new System.Drawing.Point(6, 104);
            this.btnMediaVotiClasse.Name = "btnMediaVotiClasse";
            this.btnMediaVotiClasse.Size = new System.Drawing.Size(165, 23);
            this.btnMediaVotiClasse.TabIndex = 3;
            this.btnMediaVotiClasse.Text = "Media voti classe";
            this.btnMediaVotiClasse.UseVisualStyleBackColor = true;
            this.btnMediaVotiClasse.Click += new System.EventHandler(this.btnMediaVotiClasse_Click);
            // 
            // btnMateriaPiuInsuff
            // 
            this.btnMateriaPiuInsuff.Location = new System.Drawing.Point(6, 76);
            this.btnMateriaPiuInsuff.Name = "btnMateriaPiuInsuff";
            this.btnMateriaPiuInsuff.Size = new System.Drawing.Size(165, 23);
            this.btnMateriaPiuInsuff.TabIndex = 2;
            this.btnMateriaPiuInsuff.Text = "Materia con + insuff";
            this.btnMateriaPiuInsuff.UseVisualStyleBackColor = true;
            this.btnMateriaPiuInsuff.Click += new System.EventHandler(this.btnMateriaPiuInsuff_Click);
            // 
            // btnStudenteMediaMax
            // 
            this.btnStudenteMediaMax.Location = new System.Drawing.Point(6, 48);
            this.btnStudenteMediaMax.Name = "btnStudenteMediaMax";
            this.btnStudenteMediaMax.Size = new System.Drawing.Size(165, 23);
            this.btnStudenteMediaMax.TabIndex = 1;
            this.btnStudenteMediaMax.Text = "Studente media max";
            this.btnStudenteMediaMax.UseVisualStyleBackColor = true;
            this.btnStudenteMediaMax.Click += new System.EventHandler(this.btnStudenteMediaMax_Click);
            // 
            // btnMediaVotiStudente
            // 
            this.btnMediaVotiStudente.Location = new System.Drawing.Point(6, 20);
            this.btnMediaVotiStudente.Name = "btnMediaVotiStudente";
            this.btnMediaVotiStudente.Size = new System.Drawing.Size(165, 23);
            this.btnMediaVotiStudente.TabIndex = 0;
            this.btnMediaVotiStudente.Text = "Media voti studente";
            this.btnMediaVotiStudente.UseVisualStyleBackColor = true;
            this.btnMediaVotiStudente.Click += new System.EventHandler(this.btnMediaVotiStudente_Click);
            // 
            // btnMateriaPiuVoti
            // 
            this.btnMateriaPiuVoti.Location = new System.Drawing.Point(6, 158);
            this.btnMateriaPiuVoti.Name = "btnMateriaPiuVoti";
            this.btnMateriaPiuVoti.Size = new System.Drawing.Size(165, 23);
            this.btnMateriaPiuVoti.TabIndex = 5;
            this.btnMateriaPiuVoti.Text = "Materia piu voti";
            this.btnMateriaPiuVoti.UseVisualStyleBackColor = true;
            this.btnMateriaPiuVoti.Click += new System.EventHandler(this.btnMateriaPiuVoti_Click);
            // 
            // btnMediaStudenti
            // 
            this.btnMediaStudenti.Location = new System.Drawing.Point(6, 188);
            this.btnMediaStudenti.Name = "btnMediaStudenti";
            this.btnMediaStudenti.Size = new System.Drawing.Size(165, 23);
            this.btnMediaStudenti.TabIndex = 6;
            this.btnMediaStudenti.Text = "Media tutti studenti";
            this.btnMediaStudenti.UseVisualStyleBackColor = true;
            this.btnMediaStudenti.Click += new System.EventHandler(this.btnMediaStudenti_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.numVoto);
            this.Controls.Add(this.btnInserisciVoto);
            this.Controls.Add(this.cmbMatricola);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvValutazioni);
            this.Controls.Add(this.gbOrdinamenti);
            this.Controls.Add(this.gbRicerche);
            this.Controls.Add(this.btnInserisciStudente);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricola);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudenti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "Gestione Tabelle Studenti/Valutazioni";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.gbRicerche.ResumeLayout(false);
            this.gbRicerche.PerformLayout();
            this.gbOrdinamenti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValutazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatricola;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.Button btnInserisciStudente;
        private System.Windows.Forms.GroupBox gbRicerche;
        private System.Windows.Forms.Button btnCercaMatricola;
        private System.Windows.Forms.TextBox txtCercaMatricola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTogliFiltro;
        private System.Windows.Forms.ComboBox cmbRicercaClasse;
        private System.Windows.Forms.Button btnCercaClasse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbOrdinamenti;
        private System.Windows.Forms.Button btnOrdinaMatricola;
        private System.Windows.Forms.Button btnOrdinaCognome;
        private System.Windows.Forms.DataGridView dgvValutazioni;
        private System.Windows.Forms.Button btnInserisciVoto;
        private System.Windows.Forms.ComboBox cmbMatricola;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numVoto;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMediaVotiStudente;
        private System.Windows.Forms.Button btnStudenteMediaMax;
        private System.Windows.Forms.Button btnMateriaPiuInsuff;
        private System.Windows.Forms.Button btnMediaVotiClasse;
        private System.Windows.Forms.Button btnMediaVotiMateria;
        private System.Windows.Forms.Button btnMateriaPiuVoti;
        private System.Windows.Forms.Button btnMediaStudenti;
    }
}

