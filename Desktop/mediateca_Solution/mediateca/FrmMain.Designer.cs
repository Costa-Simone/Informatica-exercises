namespace mediateca
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpMedia = new System.Windows.Forms.TabPage();
            this.dgvMedia = new System.Windows.Forms.DataGridView();
            this.gbComandiMedia = new System.Windows.Forms.GroupBox();
            this.tpSoci = new System.Windows.Forms.TabPage();
            this.tpOperazioni = new System.Windows.Forms.TabPage();
            this.dgvSoci = new System.Windows.Forms.DataGridView();
            this.gbSoci = new System.Windows.Forms.GroupBox();
            this.dgvOperazioni = new System.Windows.Forms.DataGridView();
            this.gbOperazioni = new System.Windows.Forms.GroupBox();
            this.tcMain.SuspendLayout();
            this.tpMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).BeginInit();
            this.tpSoci.SuspendLayout();
            this.tpOperazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperazioni)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMedia);
            this.tcMain.Controls.Add(this.tpSoci);
            this.tcMain.Controls.Add(this.tpOperazioni);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(800, 450);
            this.tcMain.TabIndex = 0;
            // 
            // tpMedia
            // 
            this.tpMedia.Controls.Add(this.dgvMedia);
            this.tpMedia.Controls.Add(this.gbComandiMedia);
            this.tpMedia.Location = new System.Drawing.Point(4, 22);
            this.tpMedia.Name = "tpMedia";
            this.tpMedia.Padding = new System.Windows.Forms.Padding(3);
            this.tpMedia.Size = new System.Drawing.Size(792, 424);
            this.tpMedia.TabIndex = 0;
            this.tpMedia.Text = "Media";
            this.tpMedia.UseVisualStyleBackColor = true;
            // 
            // dgvMedia
            // 
            this.dgvMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedia.Location = new System.Drawing.Point(3, 3);
            this.dgvMedia.Name = "dgvMedia";
            this.dgvMedia.Size = new System.Drawing.Size(586, 418);
            this.dgvMedia.TabIndex = 0;
            // 
            // gbComandiMedia
            // 
            this.gbComandiMedia.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbComandiMedia.Location = new System.Drawing.Point(589, 3);
            this.gbComandiMedia.Name = "gbComandiMedia";
            this.gbComandiMedia.Size = new System.Drawing.Size(200, 418);
            this.gbComandiMedia.TabIndex = 1;
            this.gbComandiMedia.TabStop = false;
            this.gbComandiMedia.Text = "Comandi";
            // 
            // tpSoci
            // 
            this.tpSoci.Controls.Add(this.dgvSoci);
            this.tpSoci.Controls.Add(this.gbSoci);
            this.tpSoci.Location = new System.Drawing.Point(4, 22);
            this.tpSoci.Name = "tpSoci";
            this.tpSoci.Padding = new System.Windows.Forms.Padding(3);
            this.tpSoci.Size = new System.Drawing.Size(792, 424);
            this.tpSoci.TabIndex = 1;
            this.tpSoci.Text = "Soci";
            this.tpSoci.UseVisualStyleBackColor = true;
            // 
            // tpOperazioni
            // 
            this.tpOperazioni.Controls.Add(this.dgvOperazioni);
            this.tpOperazioni.Controls.Add(this.gbOperazioni);
            this.tpOperazioni.Location = new System.Drawing.Point(4, 22);
            this.tpOperazioni.Name = "tpOperazioni";
            this.tpOperazioni.Padding = new System.Windows.Forms.Padding(3);
            this.tpOperazioni.Size = new System.Drawing.Size(792, 424);
            this.tpOperazioni.TabIndex = 2;
            this.tpOperazioni.Text = "Operazioni";
            this.tpOperazioni.UseVisualStyleBackColor = true;
            // 
            // dgvSoci
            // 
            this.dgvSoci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoci.Location = new System.Drawing.Point(3, 3);
            this.dgvSoci.Name = "dgvSoci";
            this.dgvSoci.Size = new System.Drawing.Size(586, 418);
            this.dgvSoci.TabIndex = 0;
            // 
            // gbSoci
            // 
            this.gbSoci.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbSoci.Location = new System.Drawing.Point(589, 3);
            this.gbSoci.Name = "gbSoci";
            this.gbSoci.Size = new System.Drawing.Size(200, 418);
            this.gbSoci.TabIndex = 1;
            this.gbSoci.TabStop = false;
            this.gbSoci.Text = "Comandi";
            // 
            // dgvOperazioni
            // 
            this.dgvOperazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperazioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOperazioni.Location = new System.Drawing.Point(3, 3);
            this.dgvOperazioni.Name = "dgvOperazioni";
            this.dgvOperazioni.Size = new System.Drawing.Size(586, 418);
            this.dgvOperazioni.TabIndex = 0;
            // 
            // gbOperazioni
            // 
            this.gbOperazioni.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbOperazioni.Location = new System.Drawing.Point(589, 3);
            this.gbOperazioni.Name = "gbOperazioni";
            this.gbOperazioni.Size = new System.Drawing.Size(200, 418);
            this.gbOperazioni.TabIndex = 1;
            this.gbOperazioni.TabStop = false;
            this.gbOperazioni.Text = "Comandi";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcMain);
            this.Name = "FrmMain";
            this.Text = "Mediateca";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tcMain.ResumeLayout(false);
            this.tpMedia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).EndInit();
            this.tpSoci.ResumeLayout(false);
            this.tpOperazioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperazioni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpMedia;
        private System.Windows.Forms.TabPage tpSoci;
        private System.Windows.Forms.TabPage tpOperazioni;
        private System.Windows.Forms.DataGridView dgvMedia;
        private System.Windows.Forms.GroupBox gbComandiMedia;
        private System.Windows.Forms.DataGridView dgvSoci;
        private System.Windows.Forms.GroupBox gbSoci;
        private System.Windows.Forms.DataGridView dgvOperazioni;
        private System.Windows.Forms.GroupBox gbOperazioni;
    }
}

