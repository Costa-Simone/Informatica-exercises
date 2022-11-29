
namespace _08_EsercitazioneVerifica
{
    partial class Modale
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
            this.lblAvviso = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAvviso
            // 
            this.lblAvviso.AutoSize = true;
            this.lblAvviso.Location = new System.Drawing.Point(12, 9);
            this.lblAvviso.Name = "lblAvviso";
            this.lblAvviso.Size = new System.Drawing.Size(339, 13);
            this.lblAvviso.TabIndex = 0;
            this.lblAvviso.Text = "Non hai effettuato le scelte nella form Figlia1, premere il pulsante Apri1.";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(15, 52);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(336, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // Modale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 86);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblAvviso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvviso;
        private System.Windows.Forms.Button btnOk;
    }
}