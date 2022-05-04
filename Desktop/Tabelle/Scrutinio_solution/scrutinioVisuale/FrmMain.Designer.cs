
namespace scrutinioVisuale
{
    partial class FrmMain
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
            this.dgvMaterie = new System.Windows.Forms.DataGridView();
            this.dgvVoti = new System.Windows.Forms.DataGridView();
            this.btnMediaStudente = new System.Windows.Forms.Button();
            this.btnScrutinio = new System.Windows.Forms.Button();
            this.btnMediaMateria = new System.Windows.Forms.Button();
            this.lblMediaMateria = new System.Windows.Forms.Label();
            this.cmbMediaMaterie = new System.Windows.Forms.ComboBox();
            this.btnMediaMaggiore = new System.Windows.Forms.Button();
            this.btnMediaMinore = new System.Windows.Forms.Button();
            this.btnMaterieDaRecuperare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(16, 86);
            this.dgvStudenti.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.RowTemplate.Height = 24;
            this.dgvStudenti.Size = new System.Drawing.Size(68, 241);
            this.dgvStudenti.TabIndex = 0;
            // 
            // dgvMaterie
            // 
            this.dgvMaterie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterie.Location = new System.Drawing.Point(98, 41);
            this.dgvMaterie.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMaterie.Name = "dgvMaterie";
            this.dgvMaterie.RowHeadersWidth = 51;
            this.dgvMaterie.RowTemplate.Height = 24;
            this.dgvMaterie.Size = new System.Drawing.Size(698, 26);
            this.dgvMaterie.TabIndex = 1;
            // 
            // dgvVoti
            // 
            this.dgvVoti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoti.Location = new System.Drawing.Point(98, 86);
            this.dgvVoti.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVoti.Name = "dgvVoti";
            this.dgvVoti.RowHeadersWidth = 51;
            this.dgvVoti.RowTemplate.Height = 24;
            this.dgvVoti.Size = new System.Drawing.Size(903, 241);
            this.dgvVoti.TabIndex = 2;
            // 
            // btnMediaStudente
            // 
            this.btnMediaStudente.Location = new System.Drawing.Point(16, 344);
            this.btnMediaStudente.Margin = new System.Windows.Forms.Padding(2);
            this.btnMediaStudente.Name = "btnMediaStudente";
            this.btnMediaStudente.Size = new System.Drawing.Size(143, 32);
            this.btnMediaStudente.TabIndex = 3;
            this.btnMediaStudente.Text = "Calcola Media Studente";
            this.btnMediaStudente.UseVisualStyleBackColor = true;
            this.btnMediaStudente.Click += new System.EventHandler(this.btnMediaStudente_Click);
            // 
            // btnScrutinio
            // 
            this.btnScrutinio.Location = new System.Drawing.Point(165, 344);
            this.btnScrutinio.Name = "btnScrutinio";
            this.btnScrutinio.Size = new System.Drawing.Size(75, 31);
            this.btnScrutinio.TabIndex = 4;
            this.btnScrutinio.Text = "Scrutinio";
            this.btnScrutinio.UseVisualStyleBackColor = true;
            this.btnScrutinio.Click += new System.EventHandler(this.btnScrutinio_Click);
            // 
            // btnMediaMateria
            // 
            this.btnMediaMateria.Location = new System.Drawing.Point(16, 381);
            this.btnMediaMateria.Name = "btnMediaMateria";
            this.btnMediaMateria.Size = new System.Drawing.Size(75, 39);
            this.btnMediaMateria.TabIndex = 5;
            this.btnMediaMateria.Text = "Media Materia";
            this.btnMediaMateria.UseVisualStyleBackColor = true;
            this.btnMediaMateria.Click += new System.EventHandler(this.btnMediaMateria_Click);
            // 
            // lblMediaMateria
            // 
            this.lblMediaMateria.Location = new System.Drawing.Point(97, 391);
            this.lblMediaMateria.Name = "lblMediaMateria";
            this.lblMediaMateria.Size = new System.Drawing.Size(100, 21);
            this.lblMediaMateria.TabIndex = 6;
            this.lblMediaMateria.Text = "Materia:";
            // 
            // cmbMediaMaterie
            // 
            this.cmbMediaMaterie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMediaMaterie.FormattingEnabled = true;
            this.cmbMediaMaterie.Location = new System.Drawing.Point(141, 388);
            this.cmbMediaMaterie.Name = "cmbMediaMaterie";
            this.cmbMediaMaterie.Size = new System.Drawing.Size(121, 21);
            this.cmbMediaMaterie.TabIndex = 7;
            this.cmbMediaMaterie.SelectedIndexChanged += new System.EventHandler(this.cmbMediaMaterie_SelectedIndexChanged);
            // 
            // btnMediaMaggiore
            // 
            this.btnMediaMaggiore.Location = new System.Drawing.Point(246, 344);
            this.btnMediaMaggiore.Name = "btnMediaMaggiore";
            this.btnMediaMaggiore.Size = new System.Drawing.Size(170, 31);
            this.btnMediaMaggiore.TabIndex = 8;
            this.btnMediaMaggiore.Text = "Cerca studente media maggiore";
            this.btnMediaMaggiore.UseVisualStyleBackColor = true;
            this.btnMediaMaggiore.Click += new System.EventHandler(this.btnMediaMaggiore_Click);
            // 
            // btnMediaMinore
            // 
            this.btnMediaMinore.Location = new System.Drawing.Point(422, 344);
            this.btnMediaMinore.Name = "btnMediaMinore";
            this.btnMediaMinore.Size = new System.Drawing.Size(178, 31);
            this.btnMediaMinore.TabIndex = 9;
            this.btnMediaMinore.Text = "Cerca studente media minore";
            this.btnMediaMinore.UseVisualStyleBackColor = true;
            this.btnMediaMinore.Click += new System.EventHandler(this.btnMediaMinore_Click);
            // 
            // btnMaterieDaRecuperare
            // 
            this.btnMaterieDaRecuperare.Location = new System.Drawing.Point(606, 344);
            this.btnMaterieDaRecuperare.Name = "btnMaterieDaRecuperare";
            this.btnMaterieDaRecuperare.Size = new System.Drawing.Size(174, 31);
            this.btnMaterieDaRecuperare.TabIndex = 10;
            this.btnMaterieDaRecuperare.Text = "Visualizza materie da recuperare";
            this.btnMaterieDaRecuperare.UseVisualStyleBackColor = true;
            this.btnMaterieDaRecuperare.Click += new System.EventHandler(this.btnMaterieDaRecuperare_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 444);
            this.Controls.Add(this.btnMaterieDaRecuperare);
            this.Controls.Add(this.btnMediaMinore);
            this.Controls.Add(this.btnMediaMaggiore);
            this.Controls.Add(this.cmbMediaMaterie);
            this.Controls.Add(this.lblMediaMateria);
            this.Controls.Add(this.btnMediaMateria);
            this.Controls.Add(this.btnScrutinio);
            this.Controls.Add(this.btnMediaStudente);
            this.Controls.Add(this.dgvVoti);
            this.Controls.Add(this.dgvMaterie);
            this.Controls.Add(this.dgvStudenti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.DataGridView dgvMaterie;
        private System.Windows.Forms.DataGridView dgvVoti;
        private System.Windows.Forms.Button btnMediaStudente;
        private System.Windows.Forms.Button btnScrutinio;
        private System.Windows.Forms.Button btnMediaMateria;
        private System.Windows.Forms.Label lblMediaMateria;
        private System.Windows.Forms.ComboBox cmbMediaMaterie;
        private System.Windows.Forms.Button btnMediaMaggiore;
        private System.Windows.Forms.Button btnMediaMinore;
        private System.Windows.Forms.Button btnMaterieDaRecuperare;
    }
}

