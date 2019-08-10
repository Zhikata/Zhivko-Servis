namespace Zhivko_Servis
{
     partial class Program
    {
        class Tovarno
        {
            private string TipNaGorivo { get; set; }
            private int KapacitetNaRezervoar { get; set; }
            private int PotrosuvackaNa100 { get; set; }
            private int Cena { get; set; }
            private string Boja { get; set; }
            private int GodinaNaProizvodstvo { get; set; }
            private string Problem { get; set; }


            Tovarno()
            {
            }

            Tovarno(string tipNaGorivo, int kapacitetNaRezervoar,
            int potrosuvackaNa100, int cena, string boja,
            int godinaNaProizvodstvo, string problem)

            {
                TipNaGorivo = tipNaGorivo;
                KapacitetNaRezervoar = kapacitetNaRezervoar;
                PotrosuvackaNa100 = potrosuvackaNa100;
                Cena = cena;
                Boja = boja;
                GodinaNaProizvodstvo = godinaNaProizvodstvo;
                Problem = problem;

            }


            public float MaksimalenDomet(int kapacitetNaRezervoar, int potrosuvackaNa100)
            {
                float maksimalendomet = (kapacitetNaRezervoar / potrosuvackaNa100);
                return maksimalendomet;
            }

            public int MomentalnaVrednost(int cena, int godinaNaProizvodstvo, int potrosuvacka)
            {
                int momentalnaVrednost = cena - (2 * (cena - (godinaNaProizvodstvo / 100) * potrosuvacka));
                return momentalnaVrednost;
            }


        }
    }
}