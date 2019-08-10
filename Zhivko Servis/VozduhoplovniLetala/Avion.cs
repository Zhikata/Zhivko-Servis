namespace Zhivko_Servis
{
    public class Avion : VozduhoplovnoVozilo
    {

        public Avion() : base()
        {

        }

        public Avion(string tipNaGorivo) : base(tipNaGorivo)
        {
        }
        public Avion(string tipNaGorivo, int kapacitetNaRezervoar) : base(tipNaGorivo, kapacitetNaRezervoar)
        {
        }

        public Avion(string tipNaGorivo,
                                int kapacitetNaRezervoar,
                                int potrosuvackaNa100,
                                int cena,
                                string boja,
                                int godinaNaProizvodstvo,
                                string problem) :
            base(tipNaGorivo, kapacitetNaRezervoar, potrosuvackaNa100, cena, boja, godinaNaProizvodstvo, problem)
        {
        }
        public int KapacitetNaPatnici { get; set; }

        public new int MomentalnaVrednost(int cena, int godinaNaProizvodstvo, int potrosuvacka)
        {
            int momentalnaVrednost = cena - (2 * (cena - (godinaNaProizvodstvo / 100) * potrosuvacka));
            return momentalnaVrednost;
        }
     }
}