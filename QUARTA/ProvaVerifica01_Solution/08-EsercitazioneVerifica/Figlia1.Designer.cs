
namespace _08_EsercitazioneVerifica
{
    partial class Figlia1
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
            this.ckbPelle = new System.Windows.Forms.CheckBox();
            this.ckbStoffa = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ckbPelle
            // 
            this.ckbPelle.AutoSize = true;
            this.ckbPelle.Location = new System.Drawing.Point(12, 12);
            this.ckbPelle.Name = "ckbPelle";
            this.ckbPelle.Size = new System.Drawing.Size(92, 17);
            this.ckbPelle.TabIndex = 0;
            this.ckbPelle.Text = "Interni in Pelle";
            this.ckbPelle.UseVisualStyleBackColor = true;
            this.ckbPelle.CheckedChanged += new System.EventHandler(this.Figlia1_CheckControl);
            // 
            // ckbStoffa
            // 
            this.ckbStoffa.AutoSize = true;
            this.ckbStoffa.Location = new System.Drawing.Point(12, 35);
            this.ckbStoffa.Name = "ckbStoffa";
            this.ckbStoffa.Size = new System.Drawing.Size(97, 17);
            this.ckbStoffa.TabIndex = 1;
            this.ckbStoffa.Text = "Interni in Stoffa";
            this.ckbStoffa.UseVisualStyleBackColor = true;
            this.ckbStoffa.CheckedChanged += new System.EventHandler(this.Figlia1_CheckControl);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BMW",
            "SEAT",
            "OPEL"});
            this.comboBox1.Location = new System.Drawing.Point(12, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.Figlia1_ChangeValue);
            // 
            // Figlia1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 88);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ckbStoffa);
            this.Controls.Add(this.ckbPelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Figlia1";
            this.Text = "Figlia1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbPelle;
        private System.Windows.Forms.CheckBox ckbStoffa;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}