namespace CostaSimone_25_05_22
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
            this.btnCreaFileCantante = new System.Windows.Forms.Button();
            this.cmbCantanti = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreaFileCantante
            // 
            this.btnCreaFileCantante.Location = new System.Drawing.Point(12, 12);
            this.btnCreaFileCantante.Name = "btnCreaFileCantante";
            this.btnCreaFileCantante.Size = new System.Drawing.Size(241, 45);
            this.btnCreaFileCantante.TabIndex = 0;
            this.btnCreaFileCantante.Text = "Crea file venduti.txt con titoli dei cd pubblicati e numero cd venduti dato canta" +
    "nte in input";
            this.btnCreaFileCantante.UseVisualStyleBackColor = true;
            this.btnCreaFileCantante.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCantanti
            // 
            this.cmbCantanti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantanti.FormattingEnabled = true;
            this.cmbCantanti.Location = new System.Drawing.Point(634, 29);
            this.cmbCantanti.Name = "cmbCantanti";
            this.cmbCantanti.Size = new System.Drawing.Size(121, 21);
            this.cmbCantanti.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crea file venduti.txt con titoli dei cd pubblicati e numero cd venduti dato canta" +
    "nte con combo\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbCantanti);
            this.Controls.Add(this.btnCreaFileCantante);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreaFileCantante;
        private System.Windows.Forms.ComboBox cmbCantanti;
        private System.Windows.Forms.Button button1;
    }
}

