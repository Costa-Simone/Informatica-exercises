namespace Prodotti
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
            this.btnCercaMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCercaMax
            // 
            this.btnCercaMax.Location = new System.Drawing.Point(12, 12);
            this.btnCercaMax.Name = "btnCercaMax";
            this.btnCercaMax.Size = new System.Drawing.Size(75, 23);
            this.btnCercaMax.TabIndex = 0;
            this.btnCercaMax.Text = "Cerca Max";
            this.btnCercaMax.UseVisualStyleBackColor = true;
            this.btnCercaMax.Click += new System.EventHandler(this.btnCercaMax_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCercaMax);
            this.Name = "FrmMain";
            this.Text = "Prodotti";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCercaMax;
    }
}

