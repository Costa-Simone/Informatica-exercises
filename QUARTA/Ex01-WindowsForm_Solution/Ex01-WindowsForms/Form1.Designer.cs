namespace Ex01_WindowsForms
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
            this.btnF2 = new System.Windows.Forms.Button();
            this.btnF3 = new System.Windows.Forms.Button();
            this.btnF4Param = new System.Windows.Forms.Button();
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.btnF5 = new System.Windows.Forms.Button();
            this.btnModale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnF2
            // 
            this.btnF2.Location = new System.Drawing.Point(12, 12);
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(75, 23);
            this.btnF2.TabIndex = 0;
            this.btnF2.Text = "Apri form F2";
            this.btnF2.UseVisualStyleBackColor = true;
            this.btnF2.Click += new System.EventHandler(this.btnF2_Click);
            // 
            // btnF3
            // 
            this.btnF3.Location = new System.Drawing.Point(93, 12);
            this.btnF3.Name = "btnF3";
            this.btnF3.Size = new System.Drawing.Size(75, 23);
            this.btnF3.TabIndex = 1;
            this.btnF3.Text = "Apri form F3";
            this.btnF3.UseVisualStyleBackColor = true;
            this.btnF3.Click += new System.EventHandler(this.btnF3_Click);
            // 
            // btnF4Param
            // 
            this.btnF4Param.Location = new System.Drawing.Point(174, 12);
            this.btnF4Param.Name = "btnF4Param";
            this.btnF4Param.Size = new System.Drawing.Size(134, 23);
            this.btnF4Param.TabIndex = 2;
            this.btnF4Param.Text = "Apri Form con parametro";
            this.btnF4Param.UseVisualStyleBackColor = true;
            this.btnF4Param.Click += new System.EventHandler(this.btnF4Param_Click);
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Location = new System.Drawing.Point(93, 41);
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.Size = new System.Drawing.Size(100, 20);
            this.txtMessaggio.TabIndex = 3;
            // 
            // btnF5
            // 
            this.btnF5.Location = new System.Drawing.Point(12, 41);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(75, 23);
            this.btnF5.TabIndex = 4;
            this.btnF5.Text = "Apri form 5";
            this.btnF5.UseVisualStyleBackColor = true;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // btnModale
            // 
            this.btnModale.Location = new System.Drawing.Point(12, 70);
            this.btnModale.Name = "btnModale";
            this.btnModale.Size = new System.Drawing.Size(105, 23);
            this.btnModale.TabIndex = 5;
            this.btnModale.Text = "Apri form modale";
            this.btnModale.UseVisualStyleBackColor = true;
            this.btnModale.Click += new System.EventHandler(this.btnModale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 116);
            this.Controls.Add(this.btnModale);
            this.Controls.Add(this.btnF5);
            this.Controls.Add(this.txtMessaggio);
            this.Controls.Add(this.btnF4Param);
            this.Controls.Add(this.btnF3);
            this.Controls.Add(this.btnF2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnF2;
        private System.Windows.Forms.Button btnF3;
        private System.Windows.Forms.Button btnF4Param;
        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.Button btnF5;
        private System.Windows.Forms.Button btnModale;
    }
}

