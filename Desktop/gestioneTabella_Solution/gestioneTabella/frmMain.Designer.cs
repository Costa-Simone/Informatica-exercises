
namespace gestioneTabella
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
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricola = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCercaMat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCercaMatricola = new System.Windows.Forms.Button();
            this.btnTogliFitro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbClasse2 = new System.Windows.Forms.ComboBox();
            this.btnRicercaPerClasse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOrdinaMatricola = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(21, 36);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.RowTemplate.Height = 24;
            this.dgvStudenti.Size = new System.Drawing.Size(427, 190);
            this.dgvStudenti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricola:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Classe:";
            // 
            // txtMatricola
            // 
            this.txtMatricola.Location = new System.Drawing.Point(105, 256);
            this.txtMatricola.Name = "txtMatricola";
            this.txtMatricola.Size = new System.Drawing.Size(121, 22);
            this.txtMatricola.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(105, 300);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 22);
            this.txtNome.TabIndex = 6;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(105, 340);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(121, 22);
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
            this.cmbClasse.Location = new System.Drawing.Point(105, 388);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(121, 24);
            this.cmbClasse.TabIndex = 8;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(21, 448);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(205, 31);
            this.btnInserisci.TabIndex = 9;
            this.btnInserisci.Text = "INSERISCI";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRicercaPerClasse);
            this.groupBox1.Controls.Add(this.cmbClasse2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnTogliFitro);
            this.groupBox1.Controls.Add(this.txtCercaMat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCercaMatricola);
            this.groupBox1.Location = new System.Drawing.Point(265, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 223);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CERCA";
            // 
            // txtCercaMat
            // 
            this.txtCercaMat.Location = new System.Drawing.Point(77, 24);
            this.txtCercaMat.Name = "txtCercaMat";
            this.txtCercaMat.Size = new System.Drawing.Size(150, 22);
            this.txtCercaMat.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Matricola:";
            // 
            // btnCercaMatricola
            // 
            this.btnCercaMatricola.Location = new System.Drawing.Point(24, 52);
            this.btnCercaMatricola.Name = "btnCercaMatricola";
            this.btnCercaMatricola.Size = new System.Drawing.Size(203, 37);
            this.btnCercaMatricola.TabIndex = 0;
            this.btnCercaMatricola.Text = "RICERCA PER MATRICOLA";
            this.btnCercaMatricola.UseVisualStyleBackColor = true;
            this.btnCercaMatricola.Click += new System.EventHandler(this.btnCercaMatricola_Click);
            // 
            // btnTogliFitro
            // 
            this.btnTogliFitro.BackgroundImage = global::gestioneTabella.Properties.Resources.filter_remove;
            this.btnTogliFitro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTogliFitro.Location = new System.Drawing.Point(217, 192);
            this.btnTogliFitro.Name = "btnTogliFitro";
            this.btnTogliFitro.Size = new System.Drawing.Size(28, 25);
            this.btnTogliFitro.TabIndex = 11;
            this.btnTogliFitro.UseVisualStyleBackColor = true;
            this.btnTogliFitro.Click += new System.EventHandler(this.btnTogliFitro_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Classe:";
            // 
            // cmbClasse2
            // 
            this.cmbClasse2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasse2.FormattingEnabled = true;
            this.cmbClasse2.Items.AddRange(new object[] {
            "1 INF A",
            "2 INF A",
            "3 INF A"});
            this.cmbClasse2.Location = new System.Drawing.Point(77, 102);
            this.cmbClasse2.Name = "cmbClasse2";
            this.cmbClasse2.Size = new System.Drawing.Size(150, 24);
            this.cmbClasse2.TabIndex = 13;
            // 
            // btnRicercaPerClasse
            // 
            this.btnRicercaPerClasse.Location = new System.Drawing.Point(24, 132);
            this.btnRicercaPerClasse.Name = "btnRicercaPerClasse";
            this.btnRicercaPerClasse.Size = new System.Drawing.Size(203, 40);
            this.btnRicercaPerClasse.TabIndex = 14;
            this.btnRicercaPerClasse.Text = "RICERCA PER CLASSE";
            this.btnRicercaPerClasse.UseVisualStyleBackColor = true;
            this.btnRicercaPerClasse.Click += new System.EventHandler(this.btnRicercaPerClasse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOrdinaMatricola);
            this.groupBox2.Location = new System.Drawing.Point(545, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 223);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ORDINA";
            // 
            // btnOrdinaMatricola
            // 
            this.btnOrdinaMatricola.Location = new System.Drawing.Point(6, 52);
            this.btnOrdinaMatricola.Name = "btnOrdinaMatricola";
            this.btnOrdinaMatricola.Size = new System.Drawing.Size(218, 37);
            this.btnOrdinaMatricola.TabIndex = 0;
            this.btnOrdinaMatricola.Text = "ORDINA PER MATRICOLA";
            this.btnOrdinaMatricola.UseVisualStyleBackColor = true;
            this.btnOrdinaMatricola.Click += new System.EventHandler(this.btnOrdinaMatricola_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricola);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudenti);
            this.Name = "frmMain";
            this.Text = "Gestione tabella studenti";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCercaMatricola;
        private System.Windows.Forms.TextBox txtCercaMat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTogliFitro;
        private System.Windows.Forms.Button btnRicercaPerClasse;
        private System.Windows.Forms.ComboBox cmbClasse2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOrdinaMatricola;
    }
}

