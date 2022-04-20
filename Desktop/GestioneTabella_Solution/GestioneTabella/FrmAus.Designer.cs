namespace GestioneTabella
{
    partial class FrmAus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMedieStudenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedieStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedieStudenti
            // 
            this.dgvMedieStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedieStudenti.Location = new System.Drawing.Point(12, 12);
            this.dgvMedieStudenti.Name = "dgvMedieStudenti";
            this.dgvMedieStudenti.Size = new System.Drawing.Size(213, 150);
            this.dgvMedieStudenti.TabIndex = 0;
            // 
            // FrmAus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 312);
            this.Controls.Add(this.dgvMedieStudenti);
            this.Name = "FrmAus";
            this.Text = "Medie degli studenti";
            this.Load += new System.EventHandler(this.FrmAus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedieStudenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedieStudenti;
    }
}