namespace ProdottoVettorialScalare
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvC = new System.Windows.Forms.DataGridView();
            this.btnProdottoScalare = new System.Windows.Forms.Button();
            this.btnProdottoVettoriale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvA
            // 
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(39, 83);
            this.dgvA.Name = "dgvA";
            this.dgvA.Size = new System.Drawing.Size(101, 322);
            this.dgvA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vettore A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vettore B";
            // 
            // dgvB
            // 
            this.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvB.Location = new System.Drawing.Point(204, 83);
            this.dgvB.Name = "dgvB";
            this.dgvB.Size = new System.Drawing.Size(101, 322);
            this.dgvB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vettore A";
            // 
            // dgvC
            // 
            this.dgvC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvC.Location = new System.Drawing.Point(517, 83);
            this.dgvC.Name = "dgvC";
            this.dgvC.Size = new System.Drawing.Size(101, 322);
            this.dgvC.TabIndex = 4;
            // 
            // btnProdottoScalare
            // 
            this.btnProdottoScalare.Location = new System.Drawing.Point(360, 163);
            this.btnProdottoScalare.Name = "btnProdottoScalare";
            this.btnProdottoScalare.Size = new System.Drawing.Size(103, 43);
            this.btnProdottoScalare.TabIndex = 6;
            this.btnProdottoScalare.Text = "PRODOTTO SCALARE";
            this.btnProdottoScalare.UseVisualStyleBackColor = true;
            this.btnProdottoScalare.Click += new System.EventHandler(this.btnProdottoScalare_Click);
            // 
            // btnProdottoVettoriale
            // 
            this.btnProdottoVettoriale.Location = new System.Drawing.Point(360, 243);
            this.btnProdottoVettoriale.Name = "btnProdottoVettoriale";
            this.btnProdottoVettoriale.Size = new System.Drawing.Size(103, 43);
            this.btnProdottoVettoriale.TabIndex = 7;
            this.btnProdottoVettoriale.Text = "PRODOTTO VETTORIALE";
            this.btnProdottoVettoriale.UseVisualStyleBackColor = true;
            this.btnProdottoVettoriale.Click += new System.EventHandler(this.btnProdottoVettoriale_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.btnProdottoVettoriale);
            this.Controls.Add(this.btnProdottoScalare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvA);
            this.Name = "FrmMain";
            this.Text = "Prodotto scalare e vettoriale";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvC;
        private System.Windows.Forms.Button btnProdottoScalare;
        private System.Windows.Forms.Button btnProdottoVettoriale;
    }
}

