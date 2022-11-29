namespace Ex11_QueueProntoSoccorso
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProssimoPaziente = new System.Windows.Forms.Label();
            this.btnProssimoPaziente = new System.Windows.Forms.Button();
            this.btnTemperatureMinMax = new System.Windows.Forms.Button();
            this.btnCreaPaziente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(88, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(88, 35);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 20);
            this.txtEta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eta\':";
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(88, 61);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(100, 20);
            this.txtColore.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Colore:";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(88, 87);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(100, 20);
            this.txtTemperatura.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Temperatura:";
            // 
            // lblProssimoPaziente
            // 
            this.lblProssimoPaziente.AutoSize = true;
            this.lblProssimoPaziente.Location = new System.Drawing.Point(12, 123);
            this.lblProssimoPaziente.Name = "lblProssimoPaziente";
            this.lblProssimoPaziente.Size = new System.Drawing.Size(95, 13);
            this.lblProssimoPaziente.TabIndex = 8;
            this.lblProssimoPaziente.Text = "Prossimo paziente:";
            // 
            // btnProssimoPaziente
            // 
            this.btnProssimoPaziente.Location = new System.Drawing.Point(7, 201);
            this.btnProssimoPaziente.Name = "btnProssimoPaziente";
            this.btnProssimoPaziente.Size = new System.Drawing.Size(83, 43);
            this.btnProssimoPaziente.TabIndex = 9;
            this.btnProssimoPaziente.Text = "Prossimo paziente";
            this.btnProssimoPaziente.UseVisualStyleBackColor = true;
            this.btnProssimoPaziente.Click += new System.EventHandler(this.btnProssimoPaziente_Click);
            // 
            // btnTemperatureMinMax
            // 
            this.btnTemperatureMinMax.Location = new System.Drawing.Point(96, 201);
            this.btnTemperatureMinMax.Name = "btnTemperatureMinMax";
            this.btnTemperatureMinMax.Size = new System.Drawing.Size(92, 43);
            this.btnTemperatureMinMax.TabIndex = 10;
            this.btnTemperatureMinMax.Text = "Temperature min e max";
            this.btnTemperatureMinMax.UseVisualStyleBackColor = true;
            this.btnTemperatureMinMax.Click += new System.EventHandler(this.btnTemperatureMinMax_Click);
            // 
            // btnCreaPaziente
            // 
            this.btnCreaPaziente.Location = new System.Drawing.Point(7, 152);
            this.btnCreaPaziente.Name = "btnCreaPaziente";
            this.btnCreaPaziente.Size = new System.Drawing.Size(181, 43);
            this.btnCreaPaziente.TabIndex = 11;
            this.btnCreaPaziente.Text = "Crea paziente";
            this.btnCreaPaziente.UseVisualStyleBackColor = true;
            this.btnCreaPaziente.Click += new System.EventHandler(this.btnCreaPaziente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 249);
            this.Controls.Add(this.btnCreaPaziente);
            this.Controls.Add(this.btnTemperatureMinMax);
            this.Controls.Add(this.btnProssimoPaziente);
            this.Controls.Add(this.lblProssimoPaziente);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProssimoPaziente;
        private System.Windows.Forms.Button btnProssimoPaziente;
        private System.Windows.Forms.Button btnTemperatureMinMax;
        private System.Windows.Forms.Button btnCreaPaziente;
    }
}

