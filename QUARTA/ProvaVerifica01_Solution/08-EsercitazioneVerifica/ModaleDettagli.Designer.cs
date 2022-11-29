
namespace _08_EsercitazioneVerifica
{
    partial class ModaleDettagli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModaleDettagli));
            this.lblDettagli = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDettagli
            // 
            this.lblDettagli.AutoSize = true;
            this.lblDettagli.Location = new System.Drawing.Point(12, 9);
            this.lblDettagli.Name = "lblDettagli";
            this.lblDettagli.Size = new System.Drawing.Size(1103, 78);
            this.lblDettagli.TabIndex = 0;
            this.lblDettagli.Text = resources.GetString("lblDettagli.Text");
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(15, 105);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(1100, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // ModaleDettagli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 135);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblDettagli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModaleDettagli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dettagli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDettagli;
        private System.Windows.Forms.Button btnOk;
    }
}