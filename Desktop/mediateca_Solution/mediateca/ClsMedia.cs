using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediateca
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
    internal class ClsMedia
    {
        static Media[] medias = new Media[50];
        static string[] datiMedia = new string[]
        {
            "m1,La volpe,Pasolini,Libro,Narrativa,false",
            "m2,La farfalla,Manzoni,Libro,Saggio,false",
            "m3,La balena,Manzoni,DVD,Avventura,false",
            "m4,Il lupo,Verga,DVD,Avventura,false",
            "m5,La gallina,Dante,Libro,Narrativa,false",
            "m6,Il gallo,Pasolini,CD,Gioco,false",
            "m7,La faina,Dante,CD,Gioco,false"
        };

        static int nMedia;

        internal static void caricaMedia(DataGridView dgv)
        {
            caricaTabellaMedia();
            visualizzaTabellaMedia(dgv);
        }
        private static void visualizzaTabellaMedia(DataGridView dgv)
        {
            settaDgv(dgv);
            caricaDati(dgv);
        }
        private static void caricaDati(DataGridView dgv)
        {
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
        private static void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 6;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.Columns[0].HeaderText = "Codice";
            dgv.Columns[1].HeaderText = "Titolo";
            dgv.Columns[2].HeaderText = "Autore";
            dgv.Columns[3].HeaderText = "Tipo";
            dgv.Columns[4].HeaderText = "Genere";
            dgv.Columns[5].HeaderText = "In prestito";
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
    }
}
