namespace Ex06_Ereditarieta01
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
            this.btnMannaro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMannaro
            // 
            this.btnMannaro.Location = new System.Drawing.Point(47, 51);
            this.btnMannaro.Name = "btnMannaro";
            this.btnMannaro.Size = new System.Drawing.Size(127, 77);
            this.btnMannaro.TabIndex = 0;
            this.btnMannaro.Text = "Crea Mannaro e testa";
            this.btnMannaro.UseVisualStyleBackColor = true;
            this.btnMannaro.Click += new System.EventHandler(this.btnMannaro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 182);
            this.Controls.Add(this.btnMannaro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMannaro;
    }
}

