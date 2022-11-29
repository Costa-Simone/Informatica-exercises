namespace Ex12_StackContainer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAggiungiContainer = new System.Windows.Forms.Button();
            this.btnEstraiContainer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codice:";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(61, 6);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 20);
            this.txtCodice.TabIndex = 1;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(61, 32);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peso:";
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(61, 58);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(100, 20);
            this.txtTara.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tara:";
            // 
            // btnAggiungiContainer
            // 
            this.btnAggiungiContainer.Location = new System.Drawing.Point(15, 84);
            this.btnAggiungiContainer.Name = "btnAggiungiContainer";
            this.btnAggiungiContainer.Size = new System.Drawing.Size(146, 23);
            this.btnAggiungiContainer.TabIndex = 6;
            this.btnAggiungiContainer.Text = "Aggiungi container";
            this.btnAggiungiContainer.UseVisualStyleBackColor = true;
            this.btnAggiungiContainer.Click += new System.EventHandler(this.btnAggiungiContainer_Click);
            // 
            // btnEstraiContainer
            // 
            this.btnEstraiContainer.Location = new System.Drawing.Point(15, 113);
            this.btnEstraiContainer.Name = "btnEstraiContainer";
            this.btnEstraiContainer.Size = new System.Drawing.Size(146, 23);
            this.btnEstraiContainer.TabIndex = 7;
            this.btnEstraiContainer.Text = "Estrai container";
            this.btnEstraiContainer.UseVisualStyleBackColor = true;
            this.btnEstraiContainer.Click += new System.EventHandler(this.btnEstraiContainer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 155);
            this.Controls.Add(this.btnEstraiContainer);
            this.Controls.Add(this.btnAggiungiContainer);
            this.Controls.Add(this.txtTara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAggiungiContainer;
        private System.Windows.Forms.Button btnEstraiContainer;
    }
}

