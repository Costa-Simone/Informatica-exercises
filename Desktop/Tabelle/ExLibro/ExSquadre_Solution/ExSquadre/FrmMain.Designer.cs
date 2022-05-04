namespace ExSquadre
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
            this.dgvAtleti = new System.Windows.Forms.DataGridView();
            this.dgvNazioni = new System.Windows.Forms.DataGridView();
            this.dgvTeam = new System.Windows.Forms.DataGridView();
            this.btnTopSquadre = new System.Windows.Forms.Button();
            this.lblTopSquadre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtleti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAtleti
            // 
            this.dgvAtleti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtleti.Location = new System.Drawing.Point(12, 12);
            this.dgvAtleti.Name = "dgvAtleti";
            this.dgvAtleti.Size = new System.Drawing.Size(100, 150);
            this.dgvAtleti.TabIndex = 0;
            // 
            // dgvNazioni
            // 
            this.dgvNazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNazioni.Location = new System.Drawing.Point(118, 12);
            this.dgvNazioni.Name = "dgvNazioni";
            this.dgvNazioni.Size = new System.Drawing.Size(100, 150);
            this.dgvNazioni.TabIndex = 1;
            // 
            // dgvTeam
            // 
            this.dgvTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeam.Location = new System.Drawing.Point(224, 12);
            this.dgvTeam.Name = "dgvTeam";
            this.dgvTeam.Size = new System.Drawing.Size(100, 150);
            this.dgvTeam.TabIndex = 2;
            // 
            // btnTopSquadre
            // 
            this.btnTopSquadre.Location = new System.Drawing.Point(330, 12);
            this.btnTopSquadre.Name = "btnTopSquadre";
            this.btnTopSquadre.Size = new System.Drawing.Size(75, 65);
            this.btnTopSquadre.TabIndex = 3;
            this.btnTopSquadre.Text = "Top Squadre";
            this.btnTopSquadre.UseVisualStyleBackColor = true;
            this.btnTopSquadre.Click += new System.EventHandler(this.btnTopSquadre_Click);
            // 
            // lblTopSquadre
            // 
            this.lblTopSquadre.Location = new System.Drawing.Point(411, 26);
            this.lblTopSquadre.Name = "lblTopSquadre";
            this.lblTopSquadre.Size = new System.Drawing.Size(100, 23);
            this.lblTopSquadre.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.lblTopSquadre);
            this.Controls.Add(this.btnTopSquadre);
            this.Controls.Add(this.dgvTeam);
            this.Controls.Add(this.dgvNazioni);
            this.Controls.Add(this.dgvAtleti);
            this.Name = "FrmMain";
            this.Text = "Squadre";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtleti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAtleti;
        private System.Windows.Forms.DataGridView dgvNazioni;
        private System.Windows.Forms.DataGridView dgvTeam;
        private System.Windows.Forms.Button btnTopSquadre;
        private System.Windows.Forms.Label lblTopSquadre;
    }
}

