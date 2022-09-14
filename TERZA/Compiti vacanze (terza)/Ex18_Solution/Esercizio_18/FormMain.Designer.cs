
namespace Esercizio_18
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
            this.btnMedieCrescenteMinMax = new System.Windows.Forms.Button();
            this.btnMediaTotale = new System.Windows.Forms.Button();
            this.btnMediaMateriaX = new System.Windows.Forms.Button();
            this.btnCaricaVoti = new System.Windows.Forms.Button();
            this.btnCaricaMaterie = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.dgvElementi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMedieCrescenteMinMax
            // 
            this.btnMedieCrescenteMinMax.Enabled = false;
            this.btnMedieCrescenteMinMax.Location = new System.Drawing.Point(450, 307);
            this.btnMedieCrescenteMinMax.Name = "btnMedieCrescenteMinMax";
            this.btnMedieCrescenteMinMax.Size = new System.Drawing.Size(387, 53);
            this.btnMedieCrescenteMinMax.TabIndex = 13;
            this.btnMedieCrescenteMinMax.Text = "VISUALIZZA LE MEDIE IN ORDINE CRESCENTE, IL MIN E IL MAX ";
            this.btnMedieCrescenteMinMax.UseVisualStyleBackColor = true;
            this.btnMedieCrescenteMinMax.Click += new System.EventHandler(this.btnMedieCrescenteMinMax_Click);
            // 
            // btnMediaTotale
            // 
            this.btnMediaTotale.Enabled = false;
            this.btnMediaTotale.Location = new System.Drawing.Point(450, 248);
            this.btnMediaTotale.Name = "btnMediaTotale";
            this.btnMediaTotale.Size = new System.Drawing.Size(387, 53);
            this.btnMediaTotale.TabIndex = 12;
            this.btnMediaTotale.Text = "VISUALIZZA LA MEDIA TOTALE";
            this.btnMediaTotale.UseVisualStyleBackColor = true;
            this.btnMediaTotale.Click += new System.EventHandler(this.btnMediaTotale_Click);
            // 
            // btnMediaMateriaX
            // 
            this.btnMediaMateriaX.Enabled = false;
            this.btnMediaMateriaX.Location = new System.Drawing.Point(450, 189);
            this.btnMediaMateriaX.Name = "btnMediaMateriaX";
            this.btnMediaMateriaX.Size = new System.Drawing.Size(387, 53);
            this.btnMediaMateriaX.TabIndex = 11;
            this.btnMediaMateriaX.Text = "VISUALIZZA LA MEDIA DELLA MATERIA X";
            this.btnMediaMateriaX.UseVisualStyleBackColor = true;
            this.btnMediaMateriaX.Click += new System.EventHandler(this.btnMediaMateriaX_Click);
            // 
            // btnCaricaVoti
            // 
            this.btnCaricaVoti.Enabled = false;
            this.btnCaricaVoti.Location = new System.Drawing.Point(450, 130);
            this.btnCaricaVoti.Name = "btnCaricaVoti";
            this.btnCaricaVoti.Size = new System.Drawing.Size(387, 53);
            this.btnCaricaVoti.TabIndex = 10;
            this.btnCaricaVoti.Text = "CARICA I VOTI";
            this.btnCaricaVoti.UseVisualStyleBackColor = true;
            this.btnCaricaVoti.Click += new System.EventHandler(this.btnCaricaVoti_Click);
            // 
            // btnCaricaMaterie
            // 
            this.btnCaricaMaterie.Location = new System.Drawing.Point(450, 71);
            this.btnCaricaMaterie.Name = "btnCaricaMaterie";
            this.btnCaricaMaterie.Size = new System.Drawing.Size(387, 53);
            this.btnCaricaMaterie.TabIndex = 9;
            this.btnCaricaMaterie.Text = "CARICA LE MATERIE";
            this.btnCaricaMaterie.UseVisualStyleBackColor = true;
            this.btnCaricaMaterie.Click += new System.EventHandler(this.btnCaricaMaterie_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(450, 12);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(387, 53);
            this.btnEsci.TabIndex = 8;
            this.btnEsci.Text = "ESCI";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // dgvElementi
            // 
            this.dgvElementi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElementi.Location = new System.Drawing.Point(12, 12);
            this.dgvElementi.Name = "dgvElementi";
            this.dgvElementi.Size = new System.Drawing.Size(392, 348);
            this.dgvElementi.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 374);
            this.ControlBox = false;
            this.Controls.Add(this.btnMedieCrescenteMinMax);
            this.Controls.Add(this.btnMediaTotale);
            this.Controls.Add(this.btnMediaMateriaX);
            this.Controls.Add(this.btnCaricaVoti);
            this.Controls.Add(this.btnCaricaMaterie);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.dgvElementi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO ELETTRONICO CON FILE";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedieCrescenteMinMax;
        private System.Windows.Forms.Button btnMediaTotale;
        private System.Windows.Forms.Button btnMediaMateriaX;
        private System.Windows.Forms.Button btnCaricaVoti;
        private System.Windows.Forms.Button btnCaricaMaterie;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.DataGridView dgvElementi;
    }
}

