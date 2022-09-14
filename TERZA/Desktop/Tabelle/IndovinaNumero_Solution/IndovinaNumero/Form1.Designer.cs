namespace IndovinaNumero
{
    partial class FrmIndovina
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
            this.txtTentativo = new System.Windows.Forms.TextBox();
            this.btnGioca = new System.Windows.Forms.Button();
            this.lblRisposta = new System.Windows.Forms.Label();
            this.txtNs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fai un tentativo";
            // 
            // txtTentativo
            // 
            this.txtTentativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentativo.ForeColor = System.Drawing.Color.Red;
            this.txtTentativo.Location = new System.Drawing.Point(114, 36);
            this.txtTentativo.Name = "txtTentativo";
            this.txtTentativo.Size = new System.Drawing.Size(100, 20);
            this.txtTentativo.TabIndex = 1;
            this.txtTentativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGioca
            // 
            this.btnGioca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioca.Location = new System.Drawing.Point(15, 88);
            this.btnGioca.Name = "btnGioca";
            this.btnGioca.Size = new System.Drawing.Size(199, 23);
            this.btnGioca.TabIndex = 2;
            this.btnGioca.Text = "Gioca";
            this.btnGioca.UseVisualStyleBackColor = true;
            this.btnGioca.Click += new System.EventHandler(this.btnGioca_Click);
            // 
            // lblRisposta
            // 
            this.lblRisposta.AutoSize = true;
            this.lblRisposta.Location = new System.Drawing.Point(12, 133);
            this.lblRisposta.Name = "lblRisposta";
            this.lblRisposta.Size = new System.Drawing.Size(37, 13);
            this.lblRisposta.TabIndex = 3;
            this.lblRisposta.Text = "?????";
            this.lblRisposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNs
            // 
            this.txtNs.AutoSize = true;
            this.txtNs.Location = new System.Drawing.Point(15, 69);
            this.txtNs.Name = "txtNs";
            this.txtNs.Size = new System.Drawing.Size(0, 13);
            this.txtNs.TabIndex = 4;
            // 
            // FrmIndovina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 170);
            this.Controls.Add(this.txtNs);
            this.Controls.Add(this.lblRisposta);
            this.Controls.Add(this.btnGioca);
            this.Controls.Add(this.txtTentativo);
            this.Controls.Add(this.label1);
            this.Name = "FrmIndovina";
            this.Text = "Indovina il testo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTentativo;
        private System.Windows.Forms.Button btnGioca;
        private System.Windows.Forms.Label lblRisposta;
        private System.Windows.Forms.Label txtNs;
    }
}

