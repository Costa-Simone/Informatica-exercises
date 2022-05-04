using System;
using System.Windows.Forms;

namespace Ex9_11pag150
{
    internal class ClsSquadre
    {
        static Random rnd = new Random();
        internal static void creaSchedina(string[] squadre, DataGridView dgvPartite, DataGridView dgvRisultato, string[] risultato, string[] squadCasa, string[] squadFuori)
        {
            int[] aus = new int[26];

            for (int i = 0; i < (squadre.Length / 2); i++)
            {
                int s1, s2, ris;

                do
                {
                    s1 = rnd.Next(0, 26);
                } while (aus[s1] == 1);

                aus[s1] = 1;

                do
                {
                    s2 = rnd.Next(0, 26);
                } while (aus[s2] == 1);

                aus[s2] = 1;

                squadCasa[i] = squadre[s1];
                squadFuori[i] = squadre[s2];

                ris = rnd.Next(1, 4);

                if (ris == 3)
                {
                    dgvRisultato.Rows.Add("x");
                }
                else
                {
                    dgvRisultato.Rows.Add(ris.ToString());
                }

                dgvPartite.Rows.Add("\n" + squadCasa[i] + " vs " + squadFuori[i] + " = " + risultato[i]);
            }
        }
        internal static void creaCampionato(string[] squadre, DataGridView dgvPartite, DataGridView dgvRisultato, DataGridView dgvSquadre, string[] risultato, string[] squadCasa, string[] squadFuori, DataGridView dgvPunti)
        {
            int[] punteggio = new int[26];

            for (int j = 0; j < 5; j++)
            {
                ClsSquadre.creaSchedina(squadre, dgvPartite, dgvRisultato, risultato, squadCasa, squadFuori);

                for (int i = 0; i < risultato.Length; i++)
                {
                    int s;
                    if (risultato[i] == "1")
                    {
                        string squad = squadCasa[i];
                        s = cercaSquadra(squadre, squad);
                        dgvPunti.Rows[i].Cells[0].Value = (Convert.ToInt32(dgvPunti.Rows[i].Cells[0].Value) + 3).ToString();
                    }
                    else if (risultato[i] == "2")
                    {
                        string squad = squadFuori[i];
                        s = cercaSquadra(squadre, squad);
                        dgvPunti.Rows[i].Cells[0].Value = (Convert.ToInt32(dgvPunti.Rows[i].Cells[0].Value) + 3).ToString();
                    }
                    else
                    {
                        string squad = squadCasa[i];
                        s = cercaSquadra(squadre, squad);
                        punteggio[s]++;
                        dgvPunti.Rows[i].Cells[0].Value = (Convert.ToInt32(dgvPunti.Rows[i].Cells[0].Value) + 1).ToString();
                        squad = squadFuori[i];
                        s = cercaSquadra(squadre, squad);
                        punteggio[s]++;
                    }
                }
            }

            ClsSquadre.ordinaSquadre(squadre, punteggio, dgvSquadre, dgvPunti);
        }
        private static int cercaSquadra(string[] squadre, string squad)
        {
            int sup = 0, inf = squadre.Length - 1;
            int meta;

            do
            {
                meta = (inf + sup) / 2;

                if (squadre[meta] != squad)
                {
                    if (string.Compare(squadre[meta], squad) > 0)
                    {
                        inf = meta - 1;
                    }
                    else
                    {
                        sup = meta + 1;
                    }
                }
            } while (squadre[meta] != squad && sup <= inf);

            return meta;
        }
        internal static void ordinaSquadre(string[] squadre, int[] punteggio, DataGridView dgvSquadre, DataGridView dgvPunti)
        {
            int PosMin, aus;
            string squad;

            for (int i = 0; i <= squadre.Length - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= squadre.Length - 1; j++)
                {
                    if (punteggio[PosMin] < punteggio[j])
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    squad = squadre[i];
                    aus = punteggio[i];
                    squadre[i] = squadre[PosMin];
                    dgvSquadre.Rows[i].Cells[0].Value = squadre[PosMin];
                    punteggio[i] = punteggio[PosMin];
                    squadre[PosMin] = squad;
                    punteggio[PosMin] = aus;
                    dgvPunti.Rows[i].Cells[0].Value = punteggio[PosMin].ToString();
                }
            }
        }
    }
}
