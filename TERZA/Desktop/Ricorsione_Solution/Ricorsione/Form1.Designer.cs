namespace Ricorsione
{
    partial class Form1
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
            this.btnFattoriale = new System.Windows.Forms.Button();
            this.btnProdotto = new System.Windows.Forms.Button();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFattoriale
            // 
            this.btnFattoriale.Location = new System.Drawing.Point(24, 12);
            this.btnFattoriale.Name = "btnFattoriale";
            this.btnFattoriale.Size = new System.Drawing.Size(75, 23);
            this.btnFattoriale.TabIndex = 0;
            this.btnFattoriale.Text = "Fattoriale";
            this.btnFattoriale.UseVisualStyleBackColor = true;
            this.btnFattoriale.Click += new System.EventHandler(this.btnFattoriale_Click);
            // 
            // btnProdotto
            // 
            this.btnProdotto.Location = new System.Drawing.Point(24, 41);
            this.btnProdotto.Name = "btnProdotto";
            this.btnProdotto.Size = new System.Drawing.Size(75, 23);
            this.btnProdotto.TabIndex = 1;
            this.btnProdotto.Text = "Prodotto";
            this.btnProdotto.UseVisualStyleBackColor = true;
            this.btnProdotto.Click += new System.EventHandler(this.btnProdotto_Click);
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.Location = new System.Drawing.Point(24, 70);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(75, 23);
            this.btnFibonacci.TabIndex = 2;
            this.btnFibonacci.Text = "Fibonacci";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 115);
            this.Controls.Add(this.btnFibonacci);
            this.Controls.Add(this.btnProdotto);
            this.Controls.Add(this.btnFattoriale);
            this.Name = "Form1";
            this.Text = "Ricorsione";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFattoriale;
        private System.Windows.Forms.Button btnProdotto;
        private System.Windows.Forms.Button btnFibonacci;
    }
}

