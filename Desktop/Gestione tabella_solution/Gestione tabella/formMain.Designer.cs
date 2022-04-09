namespace Gestione_tabella
{
    partial class formMain
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtMatricola = new System.Windows.Forms.TextBox();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.btnInserisciStudente = new System.Windows.Forms.Button();
            this.btnCercaMatricola = new System.Windows.Forms.Button();
            this.gbRicerche = new System.Windows.Forms.GroupBox();
            this.btnCercaClasse = new System.Windows.Forms.Button();
            this.cmbCercaClasse = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTogliFiltro = new System.Windows.Forms.Button();
            this.txtCercaMatricola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbOrdinamenti = new System.Windows.Forms.GroupBox();
            this.btnMateriaPiuInsuff = new System.Windows.Forms.Button();
            this.btnMediaMaggiore = new System.Windows.Forms.Button();
            this.btnMediaVotiStudente = new System.Windows.Forms.Button();
            this.btnOrdinaCognome = new System.Windows.Forms.Button();
            this.btnOrdinaMatricola = new System.Windows.Forms.Button();
            this.dgvValutazioni = new System.Windows.Forms.DataGridView();
            this.btnInserisciVoto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numVoto = new System.Windows.Forms.NumericUpDown();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.cmbMatricola = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMediaClasse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.gbRicerche.SuspendLayout();
            this.gbOrdinamenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValutazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(45, 34);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.Size = new System.Drawing.Size(281, 186);
            this.dgvStudenti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricola: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Classe: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(75, 39);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 6;
            // 
            // txtMatricola
            // 
            this.txtMatricola.Location = new System.Drawing.Point(75, 15);
            this.txtMatricola.Name = "txtMatricola";
            this.txtMatricola.Size = new System.Drawing.Size(100, 20);
            this.txtMatricola.TabIndex = 7;
            // 
            // cmbClasse
            // 
            this.cmbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Items.AddRange(new object[] {
            "1 INF A",
            "2 INF A",
            "3 INF A"});
            this.cmbClasse.Location = new System.Drawing.Point(75, 95);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(121, 21);
            this.cmbClasse.TabIndex = 8;
            // 
            // btnInserisciStudente
            // 
            this.btnInserisciStudente.Location = new System.Drawing.Point(16, 121);
            this.btnInserisciStudente.Name = "btnInserisciStudente";
            this.btnInserisciStudente.Size = new System.Drawing.Size(192, 34);
            this.btnInserisciStudente.TabIndex = 9;
            this.btnInserisciStudente.Text = "Inserisci lo studente";
            this.btnInserisciStudente.UseVisualStyleBackColor = true;
            this.btnInserisciStudente.Click += new System.EventHandler(this.btnInserisciStudente_Click);
            // 
            // btnCercaMatricola
            // 
            this.btnCercaMatricola.Location = new System.Drawing.Point(11, 47);
            this.btnCercaMatricola.Name = "btnCercaMatricola";
            this.btnCercaMatricola.Size = new System.Drawing.Size(246, 24);
            this.btnCercaMatricola.TabIndex = 10;
            this.btnCercaMatricola.Text = "Cerca la matricola";
            this.btnCercaMatricola.UseVisualStyleBackColor = true;
            this.btnCercaMatricola.Click += new System.EventHandler(this.btnCercaMatricola_Click);
            // 
            // gbRicerche
            // 
            this.gbRicerche.Controls.Add(this.btnCercaClasse);
            this.gbRicerche.Controls.Add(this.cmbCercaClasse);
            this.gbRicerche.Controls.Add(this.label6);
            this.gbRicerche.Controls.Add(this.btnTogliFiltro);
            this.gbRicerche.Controls.Add(this.txtCercaMatricola);
            this.gbRicerche.Controls.Add(this.label5);
            this.gbRicerche.Controls.Add(this.btnCercaMatricola);
            this.gbRicerche.Location = new System.Drawing.Point(601, 222);
            this.gbRicerche.Name = "gbRicerche";
            this.gbRicerche.Size = new System.Drawing.Size(263, 179);
            this.gbRicerche.TabIndex = 11;
            this.gbRicerche.TabStop = false;
            this.gbRicerche.Text = "CERCA";
            // 
            // btnCercaClasse
            // 
            this.btnCercaClasse.Location = new System.Drawing.Point(11, 103);
            this.btnCercaClasse.Name = "btnCercaClasse";
            this.btnCercaClasse.Size = new System.Drawing.Size(246, 24);
            this.btnCercaClasse.TabIndex = 16;
            this.btnCercaClasse.Text = "Cerca la classe";
            this.btnCercaClasse.UseVisualStyleBackColor = true;
            this.btnCercaClasse.Click += new System.EventHandler(this.btnCercaClasse_Click);
            // 
            // cmbCercaClasse
            // 
            this.cmbCercaClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCercaClasse.FormattingEnabled = true;
            this.cmbCercaClasse.Items.AddRange(new object[] {
            "1 INF A",
            "2 INF A",
            "3 INF A"});
            this.cmbCercaClasse.Location = new System.Drawing.Point(80, 75);
            this.cmbCercaClasse.Name = "cmbCercaClasse";
            this.cmbCercaClasse.Size = new System.Drawing.Size(177, 21);
            this.cmbCercaClasse.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Classe:";
            // 
            // btnTogliFiltro
            // 
            this.btnTogliFiltro.Location = new System.Drawing.Point(182, 230);
            this.btnTogliFiltro.Name = "btnTogliFiltro";
            this.btnTogliFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnTogliFiltro.TabIndex = 13;
            this.btnTogliFiltro.Text = "Togli i filtri";
            this.btnTogliFiltro.UseVisualStyleBackColor = true;
            this.btnTogliFiltro.Click += new System.EventHandler(this.btnTogliFiltro_Click);
            // 
            // txtCercaMatricola
            // 
            this.txtCercaMatricola.Location = new System.Drawing.Point(80, 25);
            this.txtCercaMatricola.Name = "txtCercaMatricola";
            this.txtCercaMatricola.Size = new System.Drawing.Size(177, 20);
            this.txtCercaMatricola.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Matricola:";
            // 
            // gbOrdinamenti
            // 
            this.gbOrdinamenti.Controls.Add(this.btnMediaClasse);
            this.gbOrdinamenti.Controls.Add(this.btnMateriaPiuInsuff);
            this.gbOrdinamenti.Controls.Add(this.btnMediaMaggiore);
            this.gbOrdinamenti.Controls.Add(this.btnMediaVotiStudente);
            this.gbOrdinamenti.Controls.Add(this.btnOrdinaCognome);
            this.gbOrdinamenti.Controls.Add(this.btnOrdinaMatricola);
            this.gbOrdinamenti.Location = new System.Drawing.Point(332, 222);
            this.gbOrdinamenti.Name = "gbOrdinamenti";
            this.gbOrdinamenti.Size = new System.Drawing.Size(263, 217);
            this.gbOrdinamenti.TabIndex = 12;
            this.gbOrdinamenti.TabStop = false;
            this.gbOrdinamenti.Text = "ORDINA E QUERY";
            // 
            // btnMateriaPiuInsuff
            // 
            this.btnMateriaPiuInsuff.Location = new System.Drawing.Point(7, 148);
            this.btnMateriaPiuInsuff.Name = "btnMateriaPiuInsuff";
            this.btnMateriaPiuInsuff.Size = new System.Drawing.Size(245, 23);
            this.btnMateriaPiuInsuff.TabIndex = 4;
            this.btnMateriaPiuInsuff.Text = "MATERIE PIU INSUFFICIENZE";
            this.btnMateriaPiuInsuff.UseVisualStyleBackColor = true;
            this.btnMateriaPiuInsuff.Click += new System.EventHandler(this.btnMateriaPiuInsuff_Click);
            // 
            // btnMediaMaggiore
            // 
            this.btnMediaMaggiore.Location = new System.Drawing.Point(6, 119);
            this.btnMediaMaggiore.Name = "btnMediaMaggiore";
            this.btnMediaMaggiore.Size = new System.Drawing.Size(245, 23);
            this.btnMediaMaggiore.TabIndex = 3;
            this.btnMediaMaggiore.Text = "STUDENTE CON MEDIA PIU\' ALTA";
            this.btnMediaMaggiore.UseVisualStyleBackColor = true;
            this.btnMediaMaggiore.Click += new System.EventHandler(this.btnMediaMaggiore_Click);
            // 
            // btnMediaVotiStudente
            // 
            this.btnMediaVotiStudente.Location = new System.Drawing.Point(7, 90);
            this.btnMediaVotiStudente.Name = "btnMediaVotiStudente";
            this.btnMediaVotiStudente.Size = new System.Drawing.Size(245, 23);
            this.btnMediaVotiStudente.TabIndex = 2;
            this.btnMediaVotiStudente.Text = "MEDIA VOTI STUDENTE";
            this.btnMediaVotiStudente.UseVisualStyleBackColor = true;
            this.btnMediaVotiStudente.Click += new System.EventHandler(this.btnMediaVotiStudente_Click);
            // 
            // btnOrdinaCognome
            // 
            this.btnOrdinaCognome.Location = new System.Drawing.Point(5, 58);
            this.btnOrdinaCognome.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdinaCognome.Name = "btnOrdinaCognome";
            this.btnOrdinaCognome.Size = new System.Drawing.Size(247, 24);
            this.btnOrdinaCognome.TabIndex = 1;
            this.btnOrdinaCognome.Text = "Ordina in base ai cognomi / tabella studenti";
            this.btnOrdinaCognome.UseVisualStyleBackColor = true;
            this.btnOrdinaCognome.Click += new System.EventHandler(this.btnOrdinaCognome_Click);
            // 
            // btnOrdinaMatricola
            // 
            this.btnOrdinaMatricola.Location = new System.Drawing.Point(6, 25);
            this.btnOrdinaMatricola.Name = "btnOrdinaMatricola";
            this.btnOrdinaMatricola.Size = new System.Drawing.Size(246, 26);
            this.btnOrdinaMatricola.TabIndex = 0;
            this.btnOrdinaMatricola.Text = "Ordina in base alla matricola / tabella studenti";
            this.btnOrdinaMatricola.UseVisualStyleBackColor = true;
            this.btnOrdinaMatricola.Click += new System.EventHandler(this.btnOrdinaMatricola_Click);
            // 
            // dgvValutazioni
            // 
            this.dgvValutazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValutazioni.Location = new System.Drawing.Point(45, 225);
            this.dgvValutazioni.Margin = new System.Windows.Forms.Padding(2);
            this.dgvValutazioni.Name = "dgvValutazioni";
            this.dgvValutazioni.RowHeadersWidth = 51;
            this.dgvValutazioni.RowTemplate.Height = 24;
            this.dgvValutazioni.Size = new System.Drawing.Size(281, 186);
            this.dgvValutazioni.TabIndex = 13;
            // 
            // btnInserisciVoto
            // 
            this.btnInserisciVoto.Location = new System.Drawing.Point(13, 117);
            this.btnInserisciVoto.Name = "btnInserisciVoto";
            this.btnInserisciVoto.Size = new System.Drawing.Size(192, 34);
            this.btnInserisciVoto.TabIndex = 22;
            this.btnInserisciVoto.Text = "INSERISCI IL VOTO";
            this.btnInserisciVoto.UseVisualStyleBackColor = true;
            this.btnInserisciVoto.Click += new System.EventHandler(this.btnInserisciVoto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Matricola";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Materia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Voto";
            // 
            // numVoto
            // 
            this.numVoto.Location = new System.Drawing.Point(72, 15);
            this.numVoto.Margin = new System.Windows.Forms.Padding(2);
            this.numVoto.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numVoto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVoto.Name = "numVoto";
            this.numVoto.Size = new System.Drawing.Size(90, 20);
            this.numVoto.TabIndex = 23;
            this.numVoto.Value = new decimal(new int[] {
            1,
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
            this.cmbMateria.Location = new System.Drawing.Point(72, 41);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(121, 21);
            this.cmbMateria.TabIndex = 24;
            // 
            // cmbMatricola
            // 
            this.cmbMatricola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatricola.FormattingEnabled = true;
            this.cmbMatricola.Location = new System.Drawing.Point(72, 73);
            this.cmbMatricola.Name = "cmbMatricola";
            this.cmbMatricola.Size = new System.Drawing.Size(121, 21);
            this.cmbMatricola.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbMatricola);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbMateria);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numVoto);
            this.groupBox1.Controls.Add(this.btnInserisciVoto);
            this.groupBox1.Location = new System.Drawing.Point(556, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 163);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VOTI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.btnInserisciStudente);
            this.groupBox2.Controls.Add(this.txtCognome);
            this.groupBox2.Controls.Add(this.cmbClasse);
            this.groupBox2.Controls.Add(this.txtMatricola);
            this.groupBox2.Location = new System.Drawing.Point(332, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 166);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STUDENTI";
            // 
            // btnMediaClasse
            // 
            this.btnMediaClasse.Location = new System.Drawing.Point(7, 177);
            this.btnMediaClasse.Name = "btnMediaClasse";
            this.btnMediaClasse.Size = new System.Drawing.Size(245, 23);
            this.btnMediaClasse.TabIndex = 5;
            this.btnMediaClasse.Text = "MEDIA VOTI CLASSE";
            this.btnMediaClasse.UseVisualStyleBackColor = true;
            this.btnMediaClasse.Click += new System.EventHandler(this.btnMediaClasse_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvValutazioni);
            this.Controls.Add(this.gbOrdinamenti);
            this.Controls.Add(this.gbRicerche);
            this.Controls.Add(this.dgvStudenti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.gbRicerche.ResumeLayout(false);
            this.gbRicerche.PerformLayout();
            this.gbOrdinamenti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValutazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtMatricola;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.Button btnInserisciStudente;
        private System.Windows.Forms.Button btnCercaMatricola;
        private System.Windows.Forms.GroupBox gbRicerche;
        private System.Windows.Forms.TextBox txtCercaMatricola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTogliFiltro;
        private System.Windows.Forms.Button btnCercaClasse;
        private System.Windows.Forms.ComboBox cmbCercaClasse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbOrdinamenti;
        private System.Windows.Forms.Button btnOrdinaMatricola;
        private System.Windows.Forms.Button btnOrdinaCognome;
        private System.Windows.Forms.DataGridView dgvValutazioni;
        private System.Windows.Forms.Button btnInserisciVoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numVoto;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbMatricola;
        private System.Windows.Forms.Button btnMediaVotiStudente;
        private System.Windows.Forms.Button btnMediaMaggiore;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMateriaPiuInsuff;
        private System.Windows.Forms.Button btnMediaClasse;
    }
}

