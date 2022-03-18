namespace Ex1pag150
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
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.btnTurni = new System.Windows.Forms.Button();
            this.lblCognomi = new System.Windows.Forms.Label();
            this.dgvTurni = new System.Windows.Forms.DataGridView();
            this.lblTurni = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(12, 48);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.RowTemplate.Height = 20;
            this.dgvStudenti.Size = new System.Drawing.Size(100, 220);
            this.dgvStudenti.StandardTab = true;
            this.dgvStudenti.TabIndex = 0;
            // 
            // btnTurni
            // 
            this.btnTurni.Location = new System.Drawing.Point(12, 278);
            this.btnTurni.Name = "btnTurni";
            this.btnTurni.Size = new System.Drawing.Size(75, 26);
            this.btnTurni.TabIndex = 1;
            this.btnTurni.Text = "Crea turni";
            this.btnTurni.UseVisualStyleBackColor = true;
            this.btnTurni.Click += new System.EventHandler(this.btnTurni_Click);
            // 
            // lblCognomi
            // 
            this.lblCognomi.Location = new System.Drawing.Point(12, 22);
            this.lblCognomi.Name = "lblCognomi";
            this.lblCognomi.Size = new System.Drawing.Size(100, 23);
            this.lblCognomi.TabIndex = 2;
            this.lblCognomi.Text = "Cognomi";
            this.lblCognomi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTurni
            // 
            this.dgvTurni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurni.Location = new System.Drawing.Point(118, 48);
            this.dgvTurni.Name = "dgvTurni";
            this.dgvTurni.RowTemplate.Height = 20;
            this.dgvTurni.Size = new System.Drawing.Size(100, 60);
            this.dgvTurni.TabIndex = 3;
            // 
            // lblTurni
            // 
            this.lblTurni.Location = new System.Drawing.Point(118, 22);
            this.lblTurni.Name = "lblTurni";
            this.lblTurni.Size = new System.Drawing.Size(100, 23);
            this.lblTurni.TabIndex = 4;
            this.lblTurni.Text = "Turni";
            this.lblTurni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTurni);
            this.Controls.Add(this.dgvTurni);
            this.Controls.Add(this.lblCognomi);
            this.Controls.Add(this.btnTurni);
            this.Controls.Add(this.dgvStudenti);
            this.Name = "FrmMain";
            this.Text = "Ex1pag150";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Button btnTurni;
        private System.Windows.Forms.Label lblCognomi;
        private System.Windows.Forms.DataGridView dgvTurni;
        private System.Windows.Forms.Label lblTurni;
    }
}

