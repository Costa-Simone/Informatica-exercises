
namespace Esercizio_19
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
            this.dgvRubrica = new System.Windows.Forms.DataGridView();
            this.grbComandi = new System.Windows.Forms.GroupBox();
            this.txtNominativo = new System.Windows.Forms.TextBox();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCellulare = new System.Windows.Forms.TextBox();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnModificaNominativo = new System.Windows.Forms.Button();
            this.btnInserisciNominativo = new System.Windows.Forms.Button();
            this.btnVisualizzaRubricaOrdinata = new System.Windows.Forms.Button();
            this.btnVisualizzaNominativo = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubrica)).BeginInit();
            this.grbComandi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRubrica
            // 
            this.dgvRubrica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRubrica.Location = new System.Drawing.Point(12, 12);
            this.dgvRubrica.Name = "dgvRubrica";
            this.dgvRubrica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRubrica.Size = new System.Drawing.Size(504, 426);
            this.dgvRubrica.TabIndex = 0;
            // 
            // grbComandi
            // 
            this.grbComandi.Controls.Add(this.btnEsci);
            this.grbComandi.Controls.Add(this.btnVisualizzaRubricaOrdinata);
            this.grbComandi.Controls.Add(this.btnVisualizzaNominativo);
            this.grbComandi.Controls.Add(this.btnAnnulla);
            this.grbComandi.Controls.Add(this.btnSalva);
            this.grbComandi.Controls.Add(this.btnModificaNominativo);
            this.grbComandi.Controls.Add(this.btnInserisciNominativo);
            this.grbComandi.Controls.Add(this.txtCellulare);
            this.grbComandi.Controls.Add(this.txtNominativo);
            this.grbComandi.Controls.Add(this.txtIndirizzo);
            this.grbComandi.Controls.Add(this.label4);
            this.grbComandi.Controls.Add(this.label3);
            this.grbComandi.Controls.Add(this.label2);
            this.grbComandi.Location = new System.Drawing.Point(522, 12);
            this.grbComandi.Name = "grbComandi";
            this.grbComandi.Size = new System.Drawing.Size(210, 426);
            this.grbComandi.TabIndex = 16;
            this.grbComandi.TabStop = false;
            this.grbComandi.Text = "COMANDI";
            // 
            // txtNominativo
            // 
            this.txtNominativo.Location = new System.Drawing.Point(85, 20);
            this.txtNominativo.Name = "txtNominativo";
            this.txtNominativo.Size = new System.Drawing.Size(119, 20);
            this.txtNominativo.TabIndex = 14;
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(85, 49);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(119, 20);
            this.txtIndirizzo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cellulare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Indirizzo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nominativo";
            // 
            // txtCellulare
            // 
            this.txtCellulare.Location = new System.Drawing.Point(85, 78);
            this.txtCellulare.Name = "txtCellulare";
            this.txtCellulare.Size = new System.Drawing.Size(119, 20);
            this.txtCellulare.TabIndex = 15;
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(129, 202);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 19;
            this.btnAnnulla.Text = "ANNULLA";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Visible = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(9, 202);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 18;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Visible = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnModificaNominativo
            // 
            this.btnModificaNominativo.Location = new System.Drawing.Point(9, 162);
            this.btnModificaNominativo.Name = "btnModificaNominativo";
            this.btnModificaNominativo.Size = new System.Drawing.Size(195, 23);
            this.btnModificaNominativo.TabIndex = 17;
            this.btnModificaNominativo.Text = "MODIFICA NOMINATIVO";
            this.btnModificaNominativo.UseVisualStyleBackColor = true;
            this.btnModificaNominativo.Click += new System.EventHandler(this.btnModificaNominativo_Click);
            // 
            // btnInserisciNominativo
            // 
            this.btnInserisciNominativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserisciNominativo.Location = new System.Drawing.Point(9, 121);
            this.btnInserisciNominativo.Name = "btnInserisciNominativo";
            this.btnInserisciNominativo.Size = new System.Drawing.Size(195, 23);
            this.btnInserisciNominativo.TabIndex = 16;
            this.btnInserisciNominativo.Text = "INSERISCI NUOVO NOMINATIVO";
            this.btnInserisciNominativo.UseVisualStyleBackColor = true;
            this.btnInserisciNominativo.Click += new System.EventHandler(this.btnInserisciNominativo_Click);
            // 
            // btnVisualizzaRubricaOrdinata
            // 
            this.btnVisualizzaRubricaOrdinata.Location = new System.Drawing.Point(9, 288);
            this.btnVisualizzaRubricaOrdinata.Name = "btnVisualizzaRubricaOrdinata";
            this.btnVisualizzaRubricaOrdinata.Size = new System.Drawing.Size(195, 51);
            this.btnVisualizzaRubricaOrdinata.TabIndex = 21;
            this.btnVisualizzaRubricaOrdinata.Text = "VISUALIZZA RUBRICA ORDINATA ALFABETICAMENTE";
            this.btnVisualizzaRubricaOrdinata.UseVisualStyleBackColor = true;
            this.btnVisualizzaRubricaOrdinata.Click += new System.EventHandler(this.btnVisualizzaRubricaOrdinata_Click);
            // 
            // btnVisualizzaNominativo
            // 
            this.btnVisualizzaNominativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizzaNominativo.Location = new System.Drawing.Point(9, 243);
            this.btnVisualizzaNominativo.Name = "btnVisualizzaNominativo";
            this.btnVisualizzaNominativo.Size = new System.Drawing.Size(195, 23);
            this.btnVisualizzaNominativo.TabIndex = 20;
            this.btnVisualizzaNominativo.Text = "VISUALIZZA NOMINATIVO";
            this.btnVisualizzaNominativo.UseVisualStyleBackColor = true;
            this.btnVisualizzaNominativo.Click += new System.EventHandler(this.btnVisualizzaNominativo_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(9, 388);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(195, 32);
            this.btnEsci.TabIndex = 22;
            this.btnEsci.Text = "ESCI";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grbComandi);
            this.Controls.Add(this.dgvRubrica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RUBRICA TELEFONICA";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubrica)).EndInit();
            this.grbComandi.ResumeLayout(false);
            this.grbComandi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRubrica;
        private System.Windows.Forms.GroupBox grbComandi;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Button btnVisualizzaRubricaOrdinata;
        private System.Windows.Forms.Button btnVisualizzaNominativo;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnModificaNominativo;
        private System.Windows.Forms.Button btnInserisciNominativo;
        private System.Windows.Forms.TextBox txtCellulare;
        private System.Windows.Forms.TextBox txtNominativo;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

