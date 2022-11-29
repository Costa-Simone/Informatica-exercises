namespace Ex10_DictionaryNegozio
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
            this.btnCreaArticolo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtChiave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNumeroArticoli = new System.Windows.Forms.Button();
            this.lblNumeroArticoli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // btnCreaArticolo
            // 
            this.btnCreaArticolo.Location = new System.Drawing.Point(12, 97);
            this.btnCreaArticolo.Name = "btnCreaArticolo";
            this.btnCreaArticolo.Size = new System.Drawing.Size(151, 23);
            this.btnCreaArticolo.TabIndex = 4;
            this.btnCreaArticolo.Text = "Crea articolo";
            this.btnCreaArticolo.UseVisualStyleBackColor = true;
            this.btnCreaArticolo.Click += new System.EventHandler(this.btnCreaArticolo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Visualizza articolo per chiave";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtChiave
            // 
            this.txtChiave.Location = new System.Drawing.Point(63, 57);
            this.txtChiave.Name = "txtChiave";
            this.txtChiave.Size = new System.Drawing.Size(100, 20);
            this.txtChiave.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chiave:";
            // 
            // btnNumeroArticoli
            // 
            this.btnNumeroArticoli.Location = new System.Drawing.Point(91, 126);
            this.btnNumeroArticoli.Name = "btnNumeroArticoli";
            this.btnNumeroArticoli.Size = new System.Drawing.Size(72, 53);
            this.btnNumeroArticoli.TabIndex = 8;
            this.btnNumeroArticoli.Text = "Numero articoli";
            this.btnNumeroArticoli.UseVisualStyleBackColor = true;
            this.btnNumeroArticoli.Click += new System.EventHandler(this.btnNumeroArticoli_Click);
            // 
            // lblNumeroArticoli
            // 
            this.lblNumeroArticoli.AutoSize = true;
            this.lblNumeroArticoli.Location = new System.Drawing.Point(17, 9);
            this.lblNumeroArticoli.Name = "lblNumeroArticoli";
            this.lblNumeroArticoli.Size = new System.Drawing.Size(100, 13);
            this.lblNumeroArticoli.TabIndex = 9;
            this.lblNumeroArticoli.Text = "Numero di articoli: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 190);
            this.Controls.Add(this.lblNumeroArticoli);
            this.Controls.Add(this.btnNumeroArticoli);
            this.Controls.Add(this.txtChiave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreaArticolo);
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
        private System.Windows.Forms.Button btnCreaArticolo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtChiave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNumeroArticoli;
        private System.Windows.Forms.Label lblNumeroArticoli;
    }
}

