namespace Stringhe
{
    partial class FrmStringhe
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDaStringaANumero = new System.Windows.Forms.Button();
            this.btnStringaPalindroma = new System.Windows.Forms.Button();
            this.btnInvertiStringa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(118, 9);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(148, 32);
            this.txtInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input stringa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDaStringaANumero
            // 
            this.btnDaStringaANumero.Location = new System.Drawing.Point(272, 9);
            this.btnDaStringaANumero.Name = "btnDaStringaANumero";
            this.btnDaStringaANumero.Size = new System.Drawing.Size(113, 32);
            this.btnDaStringaANumero.TabIndex = 2;
            this.btnDaStringaANumero.Text = "Da stringa a numero";
            this.btnDaStringaANumero.UseVisualStyleBackColor = true;
            this.btnDaStringaANumero.Click += new System.EventHandler(this.btnDaStringaANumero_Click);
            // 
            // btnStringaPalindroma
            // 
            this.btnStringaPalindroma.Location = new System.Drawing.Point(272, 47);
            this.btnStringaPalindroma.Name = "btnStringaPalindroma";
            this.btnStringaPalindroma.Size = new System.Drawing.Size(113, 32);
            this.btnStringaPalindroma.TabIndex = 3;
            this.btnStringaPalindroma.Text = "Stringa palindroma";
            this.btnStringaPalindroma.UseVisualStyleBackColor = true;
            this.btnStringaPalindroma.Click += new System.EventHandler(this.btnStringaPalindroma_Click);
            // 
            // btnInvertiStringa
            // 
            this.btnInvertiStringa.Location = new System.Drawing.Point(272, 85);
            this.btnInvertiStringa.Name = "btnInvertiStringa";
            this.btnInvertiStringa.Size = new System.Drawing.Size(113, 32);
            this.btnInvertiStringa.TabIndex = 4;
            this.btnInvertiStringa.Text = "Inverti stringa";
            this.btnInvertiStringa.UseVisualStyleBackColor = true;
            this.btnInvertiStringa.Click += new System.EventHandler(this.btnInvertiStringa_Click);
            // 
            // FrmStringhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 123);
            this.Controls.Add(this.btnInvertiStringa);
            this.Controls.Add(this.btnStringaPalindroma);
            this.Controls.Add(this.btnDaStringaANumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Name = "FrmStringhe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmStringhe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDaStringaANumero;
        private System.Windows.Forms.Button btnStringaPalindroma;
        private System.Windows.Forms.Button btnInvertiStringa;
    }
}

