namespace Poli
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
            this.btnSuperEnalotto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSuperEnalotto
            // 
            this.btnSuperEnalotto.Location = new System.Drawing.Point(12, 12);
            this.btnSuperEnalotto.Name = "btnSuperEnalotto";
            this.btnSuperEnalotto.Size = new System.Drawing.Size(105, 42);
            this.btnSuperEnalotto.TabIndex = 0;
            this.btnSuperEnalotto.Text = "SuperEnalotto";
            this.btnSuperEnalotto.UseVisualStyleBackColor = true;
            this.btnSuperEnalotto.Click += new System.EventHandler(this.btnSuperEnalotto_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(125, 68);
            this.Controls.Add(this.btnSuperEnalotto);
            this.Name = "FrmMain";
            this.Text = "Alcuni esami del poli";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSuperEnalotto;
    }
}

