namespace Zhivko_Servis
{
    partial class Program
    {
        class AvtomobilSportski
        {
            private string TipNaGorivo { get; set; }
            private int KapacitetNaRezervoar { get; set; }
            private int PotrosuvackaNa100 { get; set; }
            private int Cena { get; set; }
            private string Boja { get; set; }
            private int GodinaNaProizvodstvo { get; set; }
            private string Problem { get; set; }


            AvtomobilSportski()
            {
            }

            AvtomobilSportski(string TipNaGorivo, int KapacitetNaRezervoar,
                int PotrosuvackaNa100, int Cena, string Boja,
                int GodinaNaProizvodstvo, string Problem)

            {
                string tipnagorivo = TipNaGorivo;
                int kapacitetNaRezervoar = KapacitetNaRezervoar;
                int potrosuvackaNa100 = PotrosuvackaNa100;
                int cena = Cena;
                string boja = Boja;
                int godinaNaProizvodstvo = GodinaNaProizvodstvo;
                string problem = Problem;


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