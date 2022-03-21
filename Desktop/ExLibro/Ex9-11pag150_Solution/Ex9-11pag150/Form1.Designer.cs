namespace Ex9_11pag150
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
            this.dgvSquadre = new System.Windows.Forms.DataGridView();
            this.lblSquadre = new System.Windows.Forms.Label();
            this.lblPartite = new System.Windows.Forms.Label();
            this.dgvPartite = new System.Windows.Forms.DataGridView();
            this.btnTurno = new System.Windows.Forms.Button();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.dgvRisultato = new System.Windows.Forms.DataGridView();
            this.btnCampionato = new System.Windows.Forms.Button();
            this.dgvPunti = new System.Windows.Forms.DataGridView();
            this.lblPunti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSquadre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisultato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPunti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSquadre
            // 
            this.dgvSquadre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSquadre.Location = new System.Drawing.Point(16, 39);
            this.dgvSquadre.Name = "dgvSquadre";
            this.dgvSquadre.Size = new System.Drawing.Size(97, 150);
            this.dgvSquadre.TabIndex = 0;
            // 
            // lblSquadre
            // 
            this.lblSquadre.Location = new System.Drawing.Point(13, 13);
            this.lblSquadre.Name = "lblSquadre";
            this.lblSquadre.Size = new System.Drawing.Size(100, 23);
            this.lblSquadre.TabIndex = 1;
            this.lblSquadre.Text = "Squadre";
            this.lblSquadre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartite
            // 
            this.lblPartite.Location = new System.Drawing.Point(297, 9);
            this.lblPartite.Name = "lblPartite";
            this.lblPartite.Size = new System.Drawing.Size(100, 23);
            this.lblPartite.TabIndex = 2;
            this.lblPartite.Text = "Partite";
            this.lblPartite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPartite
            // 
            this.dgvPartite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartite.Location = new System.Drawing.Point(300, 39);
            this.dgvPartite.Name = "dgvPartite";
            this.dgvPartite.Size = new System.Drawing.Size(97, 150);
            this.dgvPartite.TabIndex = 3;
            // 
            // btnTurno
            // 
            this.btnTurno.Location = new System.Drawing.Point(222, 39);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(72, 23);
            this.btnTurno.TabIndex = 4;
            this.btnTurno.Text = "Crea Turno";
            this.btnTurno.UseVisualStyleBackColor = true;
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // lblRisultato
            // 
            this.lblRisultato.Location = new System.Drawing.Point(400, 9);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(100, 23);
            this.lblRisultato.TabIndex = 5;
            this.lblRisultato.Text = "Risultato";
            this.lblRisultato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRisultato
            // 
            this.dgvRisultato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRisultato.Location = new System.Drawing.Point(403, 39);
            this.dgvRisultato.Name = "dgvRisultato";
            this.dgvRisultato.Size = new System.Drawing.Size(97, 150);
            this.dgvRisultato.TabIndex = 6;
            // 
            // btnCampionato
            // 
            this.btnCampionato.Location = new System.Drawing.Point(222, 68);
            this.btnCampionato.Name = "btnCampionato";
            this.btnCampionato.Size = new System.Drawing.Size(72, 38);
            this.btnCampionato.TabIndex = 7;
            this.btnCampionato.Text = "Crea campionato";
            this.btnCampionato.UseVisualStyleBackColor = true;
            this.btnCampionato.Click += new System.EventHandler(this.btnCampionato_Click);
            // 
            // dgvPunti
            // 
            this.dgvPunti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPunti.Location = new System.Drawing.Point(119, 39);
            this.dgvPunti.Name = "dgvPunti";
            this.dgvPunti.Size = new System.Drawing.Size(97, 150);
            this.dgvPunti.TabIndex = 8;
            // 
            // lblPunti
            // 
            this.lblPunti.Location = new System.Drawing.Point(119, 9);
            this.lblPunti.Name = "lblPunti";
            this.lblPunti.Size = new System.Drawing.Size(100, 23);
            this.lblPunti.TabIndex = 9;
            this.lblPunti.Text = "Punti";
            this.lblPunti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 654);
            this.Controls.Add(this.lblPunti);
            this.Controls.Add(this.dgvPunti);
            this.Controls.Add(this.btnCampionato);
            this.Controls.Add(this.dgvRisultato);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.btnTurno);
            this.Controls.Add(this.dgvPartite);
            this.Controls.Add(this.lblPartite);
            this.Controls.Add(this.lblSquadre);
            this.Controls.Add(this.dgvSquadre);
            this.Name = "FrmMain";
            this.Text = "Ex9-11pag150";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSquadre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisultato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPunti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSquadre;
        private System.Windows.Forms.Label lblSquadre;
        private System.Windows.Forms.Label lblPartite;
        private System.Windows.Forms.DataGridView dgvPartite;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.DataGridView dgvRisultato;
        private System.Windows.Forms.Button btnCampionato;
        private System.Windows.Forms.DataGridView dgvPunti;
        private System.Windows.Forms.Label lblPunti;
    }
}

