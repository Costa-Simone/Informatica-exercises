namespace Ex04_Squadra_calcio
{
    partial class Form1
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
            this.txtSquadraA = new System.Windows.Forms.TextBox();
            this.txtPunteggioA = new System.Windows.Forms.TextBox();
            this.txtPunteggioB = new System.Windows.Forms.TextBox();
            this.txtSquadraB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPunteggioC = new System.Windows.Forms.TextBox();
            this.txtSquadraC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreaA = new System.Windows.Forms.Button();
            this.btnCreaB = new System.Windows.Forms.Button();
            this.btnCreaC = new System.Windows.Forms.Button();
            this.btnVinceC = new System.Windows.Forms.Button();
            this.btnVinceB = new System.Windows.Forms.Button();
            this.btnVinceA = new System.Windows.Forms.Button();
            this.btnPareggiaC = new System.Windows.Forms.Button();
            this.btnPareggiaB = new System.Windows.Forms.Button();
            this.btnPareggiaA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atlante";
            // 
            // txtSquadraA
            // 
            this.txtSquadraA.Location = new System.Drawing.Point(82, 6);
            this.txtSquadraA.Name = "txtSquadraA";
            this.txtSquadraA.Size = new System.Drawing.Size(100, 20);
            this.txtSquadraA.TabIndex = 1;
            // 
            // txtPunteggioA
            // 
            this.txtPunteggioA.Location = new System.Drawing.Point(207, 6);
            this.txtPunteggioA.Name = "txtPunteggioA";
            this.txtPunteggioA.ReadOnly = true;
            this.txtPunteggioA.Size = new System.Drawing.Size(100, 20);
            this.txtPunteggioA.TabIndex = 2;
            // 
            // txtPunteggioB
            // 
            this.txtPunteggioB.Location = new System.Drawing.Point(207, 42);
            this.txtPunteggioB.Name = "txtPunteggioB";
            this.txtPunteggioB.ReadOnly = true;
            this.txtPunteggioB.Size = new System.Drawing.Size(100, 20);
            this.txtPunteggioB.TabIndex = 5;
            // 
            // txtSquadraB
            // 
            this.txtSquadraB.Location = new System.Drawing.Point(82, 42);
            this.txtSquadraB.Name = "txtSquadraB";
            this.txtSquadraB.Size = new System.Drawing.Size(100, 20);
            this.txtSquadraB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Macedonia";
            // 
            // txtPunteggioC
            // 
            this.txtPunteggioC.Location = new System.Drawing.Point(207, 79);
            this.txtPunteggioC.Name = "txtPunteggioC";
            this.txtPunteggioC.ReadOnly = true;
            this.txtPunteggioC.Size = new System.Drawing.Size(100, 20);
            this.txtPunteggioC.TabIndex = 8;
            // 
            // txtSquadraC
            // 
            this.txtSquadraC.Location = new System.Drawing.Point(82, 79);
            this.txtSquadraC.Name = "txtSquadraC";
            this.txtSquadraC.Size = new System.Drawing.Size(100, 20);
            this.txtSquadraC.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Virtus";
            // 
            // btnCreaA
            // 
            this.btnCreaA.Location = new System.Drawing.Point(15, 124);
            this.btnCreaA.Name = "btnCreaA";
            this.btnCreaA.Size = new System.Drawing.Size(75, 23);
            this.btnCreaA.TabIndex = 9;
            this.btnCreaA.Text = "Crea A";
            this.btnCreaA.UseVisualStyleBackColor = true;
            this.btnCreaA.Click += new System.EventHandler(this.btnCreaA_Click);
            // 
            // btnCreaB
            // 
            this.btnCreaB.Location = new System.Drawing.Point(107, 124);
            this.btnCreaB.Name = "btnCreaB";
            this.btnCreaB.Size = new System.Drawing.Size(75, 23);
            this.btnCreaB.TabIndex = 10;
            this.btnCreaB.Text = "Crea B";
            this.btnCreaB.UseVisualStyleBackColor = true;
            this.btnCreaB.Click += new System.EventHandler(this.btnCreaB_Click);
            // 
            // btnCreaC
            // 
            this.btnCreaC.Location = new System.Drawing.Point(207, 124);
            this.btnCreaC.Name = "btnCreaC";
            this.btnCreaC.Size = new System.Drawing.Size(75, 23);
            this.btnCreaC.TabIndex = 11;
            this.btnCreaC.Text = "Crea C";
            this.btnCreaC.UseVisualStyleBackColor = true;
            this.btnCreaC.Click += new System.EventHandler(this.btnCreaC_Click);
            // 
            // btnVinceC
            // 
            this.btnVinceC.Location = new System.Drawing.Point(207, 169);
            this.btnVinceC.Name = "btnVinceC";
            this.btnVinceC.Size = new System.Drawing.Size(75, 23);
            this.btnVinceC.TabIndex = 14;
            this.btnVinceC.Text = "C Vince";
            this.btnVinceC.UseVisualStyleBackColor = true;
            this.btnVinceC.Click += new System.EventHandler(this.btnVinceC_Click);
            // 
            // btnVinceB
            // 
            this.btnVinceB.Location = new System.Drawing.Point(107, 169);
            this.btnVinceB.Name = "btnVinceB";
            this.btnVinceB.Size = new System.Drawing.Size(75, 23);
            this.btnVinceB.TabIndex = 13;
            this.btnVinceB.Text = "B Vince";
            this.btnVinceB.UseVisualStyleBackColor = true;
            this.btnVinceB.Click += new System.EventHandler(this.btnVinceB_Click);
            // 
            // btnVinceA
            // 
            this.btnVinceA.Location = new System.Drawing.Point(15, 169);
            this.btnVinceA.Name = "btnVinceA";
            this.btnVinceA.Size = new System.Drawing.Size(75, 23);
            this.btnVinceA.TabIndex = 12;
            this.btnVinceA.Text = "A Vince";
            this.btnVinceA.UseVisualStyleBackColor = true;
            this.btnVinceA.Click += new System.EventHandler(this.btnVinceA_Click);
            // 
            // btnPareggiaC
            // 
            this.btnPareggiaC.Location = new System.Drawing.Point(207, 216);
            this.btnPareggiaC.Name = "btnPareggiaC";
            this.btnPareggiaC.Size = new System.Drawing.Size(75, 23);
            this.btnPareggiaC.TabIndex = 17;
            this.btnPareggiaC.Text = "Pareggia C";
            this.btnPareggiaC.UseVisualStyleBackColor = true;
            this.btnPareggiaC.Click += new System.EventHandler(this.btnPareggiaC_Click);
            // 
            // btnPareggiaB
            // 
            this.btnPareggiaB.Location = new System.Drawing.Point(107, 216);
            this.btnPareggiaB.Name = "btnPareggiaB";
            this.btnPareggiaB.Size = new System.Drawing.Size(75, 23);
            this.btnPareggiaB.TabIndex = 16;
            this.btnPareggiaB.Text = "Pareggia B";
            this.btnPareggiaB.UseVisualStyleBackColor = true;
            this.btnPareggiaB.Click += new System.EventHandler(this.btnPareggiaB_Click);
            // 
            // btnPareggiaA
            // 
            this.btnPareggiaA.Location = new System.Drawing.Point(15, 216);
            this.btnPareggiaA.Name = "btnPareggiaA";
            this.btnPareggiaA.Size = new System.Drawing.Size(75, 23);
            this.btnPareggiaA.TabIndex = 15;
            this.btnPareggiaA.Text = "Pareggia A";
            this.btnPareggiaA.UseVisualStyleBackColor = true;
            this.btnPareggiaA.Click += new System.EventHandler(this.btnPareggiaA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 256);
            this.Controls.Add(this.btnPareggiaC);
            this.Controls.Add(this.btnPareggiaB);
            this.Controls.Add(this.btnPareggiaA);
            this.Controls.Add(this.btnVinceC);
            this.Controls.Add(this.btnVinceB);
            this.Controls.Add(this.btnVinceA);
            this.Controls.Add(this.btnCreaC);
            this.Controls.Add(this.btnCreaB);
            this.Controls.Add(this.btnCreaA);
            this.Controls.Add(this.txtPunteggioC);
            this.Controls.Add(this.txtSquadraC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPunteggioB);
            this.Controls.Add(this.txtSquadraB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPunteggioA);
            this.Controls.Add(this.txtSquadraA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSquadraA;
        private System.Windows.Forms.TextBox txtPunteggioA;
        private System.Windows.Forms.TextBox txtPunteggioB;
        private System.Windows.Forms.TextBox txtSquadraB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPunteggioC;
        private System.Windows.Forms.TextBox txtSquadraC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreaA;
        private System.Windows.Forms.Button btnCreaB;
        private System.Windows.Forms.Button btnCreaC;
        private System.Windows.Forms.Button btnVinceC;
        private System.Windows.Forms.Button btnVinceB;
        private System.Windows.Forms.Button btnVinceA;
        private System.Windows.Forms.Button btnPareggiaC;
        private System.Windows.Forms.Button btnPareggiaB;
        private System.Windows.Forms.Button btnPareggiaA;
    }
}

