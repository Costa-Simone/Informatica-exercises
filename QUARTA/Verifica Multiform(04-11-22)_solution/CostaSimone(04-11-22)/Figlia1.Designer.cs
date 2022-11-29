namespace CostaSimone_04_11_22_
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
            this.rbCabinato = new System.Windows.Forms.RadioButton();
            this.rbNonCabinato = new System.Windows.Forms.RadioButton();
            this.cmbTrattore = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rbCabinato
            // 
            this.rbCabinato.AutoSize = true;
            this.rbCabinato.Location = new System.Drawing.Point(12, 12);
            this.rbCabinato.Name = "rbCabinato";
            this.rbCabinato.Size = new System.Drawing.Size(66, 17);
            this.rbCabinato.TabIndex = 0;
            this.rbCabinato.Text = "cabinato";
            this.rbCabinato.UseVisualStyleBackColor = true;
            this.rbCabinato.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // rbNonCabinato
            // 
            this.rbNonCabinato.AutoSize = true;
            this.rbNonCabinato.Location = new System.Drawing.Point(12, 35);
            this.rbNonCabinato.Name = "rbNonCabinato";
            this.rbNonCabinato.Size = new System.Drawing.Size(87, 17);
            this.rbNonCabinato.TabIndex = 1;
            this.rbNonCabinato.Text = "non cabinato";
            this.rbNonCabinato.UseVisualStyleBackColor = true;
            this.rbNonCabinato.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // cmbTrattore
            // 
            this.cmbTrattore.FormattingEnabled = true;
            this.cmbTrattore.Items.AddRange(new object[] {
            "Trattore1",
            "Trattore2",
            "Trattore3"});
            this.cmbTrattore.Location = new System.Drawing.Point(12, 73);
            this.cmbTrattore.Name = "cmbTrattore";
            this.cmbTrattore.Size = new System.Drawing.Size(121, 21);
            this.cmbTrattore.TabIndex = 2;
            this.cmbTrattore.SelectedIndexChanged += new System.EventHandler(this.CheckBox_Changed);
            // 
            // Figlia1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 276);
            this.Controls.Add(this.cmbTrattore);
            this.Controls.Add(this.rbNonCabinato);
            this.Controls.Add(this.rbCabinato);
            this.Name = "Figlia1";
            this.Text = "Figlia1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCabinato;
        private System.Windows.Forms.RadioButton rbNonCabinato;
        private System.Windows.Forms.ComboBox cmbTrattore;
    }
}