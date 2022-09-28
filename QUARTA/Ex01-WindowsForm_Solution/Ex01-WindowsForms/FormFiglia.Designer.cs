namespace Ex01_WindowsForms
{
    partial class FormFiglia
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
            this.btnFigliaDiChi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFigliaDiChi
            // 
            this.btnFigliaDiChi.Location = new System.Drawing.Point(12, 12);
            this.btnFigliaDiChi.Name = "btnFigliaDiChi";
            this.btnFigliaDiChi.Size = new System.Drawing.Size(108, 23);
            this.btnFigliaDiChi.TabIndex = 1;
            this.btnFigliaDiChi.Text = "Di chi sono figlia?";
            this.btnFigliaDiChi.UseVisualStyleBackColor = true;
            this.btnFigliaDiChi.Click += new System.EventHandler(this.btnFigliaDiChi_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 62);
            this.Controls.Add(this.btnFigliaDiChi);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFigliaDiChi;
    }
}