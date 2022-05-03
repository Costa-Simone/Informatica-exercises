using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediateca
{
    public struct Media
    {
        public string codMedia;
        public string titolo;
        public string autore;
        public string tipo;
        public string genere;
        public bool isInPrestito;
    }

    class ClsMedia
    {
        public static Media[] medias = new Media[50];
        public static string[] datiMedia = new string[]
        {
            "m1,La Volpe,Pasolini,Libro,Narrativa,false",
            "m2,La Farfalla,Manzoni,Libro,Saggio,false",
            "m3,La Balena,Manzoni,DVD,Avventura,false",
            "m4,Il Lupo,Verga,DVD,Avventura,false",
            "m5,La Gallina,Dante,Libro,Narrativa,false",
            "m6,Il Gallo,Pasolini,CD,Gioco,false",
            "m7,La Faina,Dante,CD,Gioco,false"
        };

        public static int nMedia;

        internal static void caricaMedia(DataGridView dgv)
        {
            caricaTabellaMedia();
            visualizzaTabellaMedia(dgv);
        }
        private static void caricaTabellaMedia()
        {
            for (int i = 0; i < datiMedia.Length; i++)
            {
                string[] dati = datiMedia[i].Split(',');
                medias[i].codMedia = dati[0];
                medias[i].titolo = dati[1];
                medias[i].autore = dati[2];
                medias[i].tipo = dati[3];
                medias[i].genere = dati[4];
                medias[i].isInPrestito = dati[5] == "true";
            }
            nMedia = datiMedia.Length;
        }
        private static void visualizzaTabellaMedia(DataGridView dgv)
        {
            settaDgv(dgv);
            caricaDati(dgv);
        }
        private static void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 6;
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.Columns[0].HeaderText = "Codice";
            dgv.Columns[1].HeaderText = "Titolo";
            dgv.Columns[2].HeaderText = "Autore";
            dgv.Columns[3].HeaderText = "Tipo";
            dgv.Columns[4].HeaderText = "Genere";
            dgv.Columns[5].HeaderText = "In Prestito";
        }
        private static void caricaDati(DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < nMedia; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = medias[i].codMedia;
                dgv.Rows[i].Cells[1].Value = medias[i].titolo;
                dgv.Rows[i].Cells[2].Value = medias[i].autore;
                dgv.Rows[i].Cells[3].Value = medias[i].tipo;
                dgv.Rows[i].Cells[4].Value = medias[i].genere;
                dgv.Rows[i].Cells[5].Value = medias[i].isInPrestito;
            }
        }
        internal static void inserisciMedia(string titolo, string autore, string tipo, string genere, DataGridView dgv)
        {
            string lastCode = medias[nMedia - 1].codMedia.Remove(0, 1);
            int newCode = int.Parse(lastCode) + 1;
            Media m = new Media();
            m.codMedia = "m" + newCode;
            m.titolo = titolo;
            m.autore = autore;
            m.tipo = tipo;
            m.genere = genere;
            m.isInPrestito = false;
            medias[nMedia] = m;
            nMedia++;
            visualizzaTabellaMedia(dgv);
            
        }
        internal static void cancellaMedia(int index, DataGridView dgv)
        {
            Media[] newMedias = new Media[50];
            int j = 0;
            for (int i = 0; i < index; i++) newMedias[j++] = medias[i];
            for (int i = index + 1; i < nMedia; i++) newMedias[j++] = medias[i];
            medias = newMedias;
            nMedia--;
            visualizzaTabellaMedia(dgv);
        }
        internal static void modificaMedia(string titolo, string autore, string tipo, string genere, int index, DataGridView dgv)
        {
            medias[index].titolo = titolo;
            medias[index].autore = autore;
            medias[index].tipo = tipo;
            medias[index].genere = genere;
            visualizzaTabellaMedia(dgv);
        }
        internal static void assegnaPrestito(string codMedia, DataGridView dgv)
        {
            int i = 0;

            while (medias[i].codMedia != codMedia && i < nMedia)
            {
                i++;
            }

            medias[i].isInPrestito = true;
            visualizzaTabellaMedia(dgv);
        }
        internal static void consegnaPrestito(string codMedia, DataGridView dgv)
        {
            int i = 0;

            while (medias[i].codMedia != codMedia && i < nMedia)
            {
                i++;
            }

            medias[i].isInPrestito = false;
            visualizzaTabellaMedia(dgv);
        }
    }
}
