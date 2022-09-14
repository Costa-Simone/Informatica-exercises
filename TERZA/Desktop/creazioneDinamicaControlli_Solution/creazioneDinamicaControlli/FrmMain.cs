using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creazioneDinamicaControlli
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                // creo istanza di un bottone
                Button btn = new Button();
                // setto proprietà bottone
                btn.Text = i.ToString();
                btn.Name = "btn" + i;
                btn.Height = 100;
                btn.Width = 100;
                btn.Top = 20;
                btn.Left = 100 * (i - 1) + 10;
                btn.Click += Btn_Click;
                // btn.Click +=  new EventHandler(Btn_Click);
                btn.MouseHover += Btn_MouseHover;
                btn.MouseLeave += Btn_MouseLeave;

                this.Controls.Add(btn);
            }
            // creo la label
            Label lbl = new Label();

            lbl.Text = "Numero del bottone: ";
            lbl.Top = 150;
            lbl.Left = 10;
            lbl.AutoSize = true;
            lbl.Font = new Font("Calibri", 20);

            this.Controls.Add(lbl);
            // creo textbox
            TextBox txtNum = new TextBox();

            txtNum.Text = "";
            txtNum.Name = "txtNum";
            txtNum.TextAlign = HorizontalAlignment.Center;
            txtNum.Font = new Font("Calibri", 20);
            txtNum.Top = 150;
            txtNum.Left = 310;

            this.Controls.Add(txtNum);
            // creo bottone disabilita
            Button btnDisabilita = new Button();

            btnDisabilita.Text = "Disabilita bottone selezionato";
            btnDisabilita.Name = "btnDisabilita";
            btnDisabilita.AutoSize = true;
            btnDisabilita.Top = 220;
            btnDisabilita.Left = 10;
            btnDisabilita.Font = new Font("Calibri", 20);
            btnDisabilita.Click += BtnDisabilita_Click;

            this.Controls.Add(btnDisabilita);
            // creo bottone disabilita tutti
            Button btnDisabilitaTutti = new Button();

            btnDisabilitaTutti.Text = "Disabilita tutti i bottoni";
            btnDisabilitaTutti.Name = "btnDisabilitaTutti";
            btnDisabilitaTutti.AutoSize = true;
            btnDisabilitaTutti.Top = 290;
            btnDisabilitaTutti.Left = 10;
            btnDisabilitaTutti.Font = new Font("Calibri", 20);
            btnDisabilitaTutti.Click += BtnDisabilitaTutti_Click;

            this.Controls.Add(btnDisabilitaTutti);
            // cancella bottone selezionato
            Button btnCancella = new Button();

            btnCancella.Text = "Cancella bottone selezionato";
            btnCancella.Name = "btnCancella";
            btnCancella.AutoSize = true;
            btnCancella.Top = 360;
            btnCancella.Left = 10;
            btnCancella.Font = new Font("Calibri", 20);
            btnCancella.Click += BtnCancella_Click;

            this.Controls.Add(btnCancella);
        }
        private void BtnCancella_Click(object sender, EventArgs e)
        {
            // cancella il bottone numerato indicato da txtBox
            TextBox txt = (TextBox)this.Controls["txtNum"];
            string buttonName = "btn" + txt.Text;
            Button btn = (Button)this.Controls[buttonName];

            if (btn == null)
            {
                MessageBox.Show("Numero non corretto");
            }
            else
            {
                this.Controls.Remove(btn);
            }
        }
        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = SystemColors.ButtonFace;
            btn.UseVisualStyleBackColor = true;
        }
        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.Aquamarine;
        }
        private void BtnDisabilitaTutti_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    if (int.TryParse(btn.Text, out int i))
                    {
                        btn.Enabled = !btn.Enabled;
                    }
                }
            }
        }
        private void BtnDisabilita_Click(object sender, EventArgs e)
        {
            // disabilito il bottone numerato indicato da txtBox
            TextBox txt = (TextBox)this.Controls["txtNum"];
            string buttonName = "btn" + txt.Text;
            Button btn = (Button)this.Controls[buttonName];

            if (btn == null)
            {
                MessageBox.Show("Numero non corretto");
            }
            else
            {
                btn.Enabled = false;
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            MessageBox.Show("Sono il btn numero " + btn.Text);
        }
    }
}
