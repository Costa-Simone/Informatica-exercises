namespace CostaSimone_04_11_22_
{
    partial class Figlia2
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
            this.lblScelta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScelta
            // 
            this.lblScelta.AutoSize = true;
            this.lblScelta.Location = new System.Drawing.Point(12, 49);
            this.lblScelta.Name = "lblScelta";
            this.lblScelta.Size = new System.Drawing.Size(35, 13);
            this.lblScelta.TabIndex = 0;
            this.lblScelta.Text = "label1";
            // 
            // Figlia2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 126);
            this.Controls.Add(this.lblScelta);
            this.Name = "Figlia2";
            this.Text = "Figlia2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScelta;
    }
}