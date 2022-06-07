namespace Multiform
{
    partial class FormRisultati
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lbxNumeri = new System.Windows.Forms.ListBox();
            this.lblTotale = new System.Windows.Forms.Label();
            this.btnGenera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(179, 24);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "(qui appare il nome)";
            // 
            // lbxNumeri
            // 
            this.lbxNumeri.FormattingEnabled = true;
            this.lbxNumeri.Location = new System.Drawing.Point(12, 85);
            this.lbxNumeri.Name = "lbxNumeri";
            this.lbxNumeri.Size = new System.Drawing.Size(198, 225);
            this.lbxNumeri.TabIndex = 1;
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotale.Location = new System.Drawing.Point(12, 324);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(47, 20);
            this.lblTotale.TabIndex = 2;
            this.lblTotale.Text = "TOT: ";
            // 
            // btnGenera
            // 
            this.btnGenera.Location = new System.Drawing.Point(16, 50);
            this.btnGenera.Name = "btnGenera";
            this.btnGenera.Size = new System.Drawing.Size(194, 23);
            this.btnGenera.TabIndex = 3;
            this.btnGenera.Text = "Genera Valori";
            this.btnGenera.UseVisualStyleBackColor = true;
            this.btnGenera.Click += new System.EventHandler(this.btnGenera_Click);
            // 
            // FormRisultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 353);
            this.Controls.Add(this.btnGenera);
            this.Controls.Add(this.lblTotale);
            this.Controls.Add(this.lbxNumeri);
            this.Controls.Add(this.lblNome);
            this.Name = "FormRisultati";
            this.Text = "FormRisultati";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ListBox lbxNumeri;
        private System.Windows.Forms.Label lblTotale;
        private System.Windows.Forms.Button btnGenera;
    }
}