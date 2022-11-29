namespace Ex08_Ereditarieta03
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
            this.btnAggiungiMostro = new System.Windows.Forms.Button();
            this.btnAggiungiMannaro = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAggiungiMostro
            // 
            this.btnAggiungiMostro.Location = new System.Drawing.Point(12, 12);
            this.btnAggiungiMostro.Name = "btnAggiungiMostro";
            this.btnAggiungiMostro.Size = new System.Drawing.Size(89, 42);
            this.btnAggiungiMostro.TabIndex = 0;
            this.btnAggiungiMostro.Text = "Aggiungi Mostro";
            this.btnAggiungiMostro.UseVisualStyleBackColor = true;
            this.btnAggiungiMostro.Click += new System.EventHandler(this.btnAggiungiMostro_Click);
            // 
            // btnAggiungiMannaro
            // 
            this.btnAggiungiMannaro.Location = new System.Drawing.Point(107, 12);
            this.btnAggiungiMannaro.Name = "btnAggiungiMannaro";
            this.btnAggiungiMannaro.Size = new System.Drawing.Size(92, 42);
            this.btnAggiungiMannaro.TabIndex = 1;
            this.btnAggiungiMannaro.Text = "Aggiungi Mannaro";
            this.btnAggiungiMannaro.UseVisualStyleBackColor = true;
            this.btnAggiungiMannaro.Click += new System.EventHandler(this.btnAggiungiMannaro_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(57, 60);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(92, 42);
            this.btnVisualizza.TabIndex = 2;
            this.btnVisualizza.Text = "Visualizza elementi";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 115);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnAggiungiMannaro);
            this.Controls.Add(this.btnAggiungiMostro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungiMostro;
        private System.Windows.Forms.Button btnAggiungiMannaro;
        private System.Windows.Forms.Button btnVisualizza;
    }
}

