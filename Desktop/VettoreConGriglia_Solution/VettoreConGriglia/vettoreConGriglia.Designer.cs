namespace vettoreConGriglia
{
    partial class vettoreConGriglia
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
            this.dgvVettore = new System.Windows.Forms.DataGridView();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnContPariDispari = new System.Windows.Forms.Button();
            this.btnInverti = new System.Windows.Forms.Button();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.btnCercaX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVettore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVettore
            // 
            this.dgvVettore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVettore.Location = new System.Drawing.Point(42, 32);
            this.dgvVettore.Name = "dgvVettore";
            this.dgvVettore.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvVettore.Size = new System.Drawing.Size(99, 257);
            this.dgvVettore.TabIndex = 0;
            this.dgvVettore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVettore_CellContentClick);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(213, 32);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(127, 33);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "MEDIA";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(213, 71);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(127, 31);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "MASSIMO";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnContPariDispari
            // 
            this.btnContPariDispari.Location = new System.Drawing.Point(213, 108);
            this.btnContPariDispari.Name = "btnContPariDispari";
            this.btnContPariDispari.Size = new System.Drawing.Size(127, 38);
            this.btnContPariDispari.TabIndex = 3;
            this.btnContPariDispari.Text = "CONTA PARI/DISPARI";
            this.btnContPariDispari.UseVisualStyleBackColor = true;
            this.btnContPariDispari.Click += new System.EventHandler(this.btnContPariDispari_Click);
            // 
            // btnInverti
            // 
            this.btnInverti.Location = new System.Drawing.Point(213, 152);
            this.btnInverti.Name = "btnInverti";
            this.btnInverti.Size = new System.Drawing.Size(127, 32);
            this.btnInverti.TabIndex = 4;
            this.btnInverti.Text = "INVERTI";
            this.btnInverti.UseVisualStyleBackColor = true;
            this.btnInverti.Click += new System.EventHandler(this.btnInverti_Click);
            // 
            // btnOrdina
            // 
            this.btnOrdina.Location = new System.Drawing.Point(213, 190);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(127, 30);
            this.btnOrdina.TabIndex = 5;
            this.btnOrdina.Text = "ORDINA";
            this.btnOrdina.UseVisualStyleBackColor = true;
            this.btnOrdina.Click += new System.EventHandler(this.btnOrdina_Click);
            // 
            // btnCercaX
            // 
            this.btnCercaX.Location = new System.Drawing.Point(213, 226);
            this.btnCercaX.Name = "btnCercaX";
            this.btnCercaX.Size = new System.Drawing.Size(127, 30);
            this.btnCercaX.TabIndex = 6;
            this.btnCercaX.Text = "RICERCA";
            this.btnCercaX.UseVisualStyleBackColor = true;
            this.btnCercaX.Click += new System.EventHandler(this.btnCercaX_Click);
            // 
            // vettoreConGriglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.btnCercaX);
            this.Controls.Add(this.btnOrdina);
            this.Controls.Add(this.btnInverti);
            this.Controls.Add(this.btnContPariDispari);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.dgvVettore);
            this.Name = "vettoreConGriglia";
            this.Text = "vettoreConGriglia";
            this.Load += new System.EventHandler(this.vettoreConGriglia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVettore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVettore;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnContPariDispari;
        private System.Windows.Forms.Button btnInverti;
        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.Button btnCercaX;
    }
}

