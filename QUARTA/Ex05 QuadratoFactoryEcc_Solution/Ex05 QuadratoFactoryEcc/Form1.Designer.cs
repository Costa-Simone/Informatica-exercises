namespace Ex05_QuadratoFactoryEcc
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
            this.btnFactory = new System.Windows.Forms.Button();
            this.btnSingleton = new System.Windows.Forms.Button();
            this.btnIndexed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFactory
            // 
            this.btnFactory.Location = new System.Drawing.Point(12, 12);
            this.btnFactory.Name = "btnFactory";
            this.btnFactory.Size = new System.Drawing.Size(84, 81);
            this.btnFactory.TabIndex = 0;
            this.btnFactory.Text = "Metodo Factory";
            this.btnFactory.UseVisualStyleBackColor = true;
            this.btnFactory.Click += new System.EventHandler(this.btnFactory_Click);
            // 
            // btnSingleton
            // 
            this.btnSingleton.Location = new System.Drawing.Point(131, 12);
            this.btnSingleton.Name = "btnSingleton";
            this.btnSingleton.Size = new System.Drawing.Size(84, 81);
            this.btnSingleton.TabIndex = 1;
            this.btnSingleton.Text = "Classe Singleton";
            this.btnSingleton.UseVisualStyleBackColor = true;
            this.btnSingleton.Click += new System.EventHandler(this.btnSingleton_Click);
            // 
            // btnIndexed
            // 
            this.btnIndexed.Location = new System.Drawing.Point(253, 12);
            this.btnIndexed.Name = "btnIndexed";
            this.btnIndexed.Size = new System.Drawing.Size(84, 81);
            this.btnIndexed.TabIndex = 2;
            this.btnIndexed.Text = "Classe Indexed";
            this.btnIndexed.UseVisualStyleBackColor = true;
            this.btnIndexed.Click += new System.EventHandler(this.btnIndexed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 107);
            this.Controls.Add(this.btnIndexed);
            this.Controls.Add(this.btnSingleton);
            this.Controls.Add(this.btnFactory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFactory;
        private System.Windows.Forms.Button btnSingleton;
        private System.Windows.Forms.Button btnIndexed;
    }
}

