namespace Ex2pag138
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
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.dgvC = new System.Windows.Forms.DataGridView();
            this.btnIntersezione = new System.Windows.Forms.Button();
            this.btnUnione = new System.Windows.Forms.Button();
            this.btnDifferenza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvA
            // 
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(12, 12);
            this.dgvA.Name = "dgvA";
            this.dgvA.Size = new System.Drawing.Size(100, 150);
            this.dgvA.TabIndex = 0;
            // 
            // dgvB
            // 
            this.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvB.Location = new System.Drawing.Point(118, 12);
            this.dgvB.Name = "dgvB";
            this.dgvB.Size = new System.Drawing.Size(100, 150);
            this.dgvB.TabIndex = 1;
            // 
            // dgvC
            // 
            this.dgvC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvC.Location = new System.Drawing.Point(305, 12);
            this.dgvC.Name = "dgvC";
            this.dgvC.Size = new System.Drawing.Size(100, 150);
            this.dgvC.TabIndex = 2;
            // 
            // btnIntersezione
            // 
            this.btnIntersezione.Location = new System.Drawing.Point(224, 12);
            this.btnIntersezione.Name = "btnIntersezione";
            this.btnIntersezione.Size = new System.Drawing.Size(75, 23);
            this.btnIntersezione.TabIndex = 3;
            this.btnIntersezione.Text = "Intersezione";
            this.btnIntersezione.UseVisualStyleBackColor = true;
            this.btnIntersezione.Click += new System.EventHandler(this.btnIntersezione_Click);
            // 
            // btnUnione
            // 
            this.btnUnione.Location = new System.Drawing.Point(224, 41);
            this.btnUnione.Name = "btnUnione";
            this.btnUnione.Size = new System.Drawing.Size(75, 23);
            this.btnUnione.TabIndex = 4;
            this.btnUnione.Text = "Unione";
            this.btnUnione.UseVisualStyleBackColor = true;
            this.btnUnione.Click += new System.EventHandler(this.btnUnione_Click);
            // 
            // btnDifferenza
            // 
            this.btnDifferenza.Location = new System.Drawing.Point(224, 70);
            this.btnDifferenza.Name = "btnDifferenza";
            this.btnDifferenza.Size = new System.Drawing.Size(75, 23);
            this.btnDifferenza.TabIndex = 5;
            this.btnDifferenza.Text = "Differenza";
            this.btnDifferenza.UseVisualStyleBackColor = true;
            this.btnDifferenza.Click += new System.EventHandler(this.btnDifferenza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 207);
            this.Controls.Add(this.btnDifferenza);
            this.Controls.Add(this.btnUnione);
            this.Controls.Add(this.btnIntersezione);
            this.Controls.Add(this.dgvC);
            this.Controls.Add(this.dgvB);
            this.Controls.Add(this.dgvA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.DataGridView dgvC;
        private System.Windows.Forms.Button btnIntersezione;
        private System.Windows.Forms.Button btnUnione;
        private System.Windows.Forms.Button btnDifferenza;
    }
}

