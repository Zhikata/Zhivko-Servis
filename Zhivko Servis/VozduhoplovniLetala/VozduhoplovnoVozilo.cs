namespace Zhivko_Servis
{
    public class VozduhoplovnoVozilo : Vozilo
    {

        public VozduhoplovnoVozilo() : base()
        {

        }

        public VozduhoplovnoVozilo(string tipNaGorivo) : base(tipNaGorivo)
        {
        }
        public VozduhoplovnoVozilo(string tipNaGorivo, int kapacitetNaRezervoar) : base(tipNaGorivo, kapacitetNaRezervoar)
        {
        }

        public VozduhoplovnoVozilo(string tipNaGorivo,
                                int kapacitetNaRezervoar,
                                int potrosuvackaNa100,
                                int cena,
                                string boja,
                                int godinaNaProizvodstvo,
                                string problem) :
            base(tipNaGorivo, kapacitetNaRezervoar, potrosuvackaNa100, cena, boja, godinaNaProizvodstvo, problem)
        {
        }
        public new int MomentalnaVrednost(int cena, int godinaNaProizvodstvo, int potrosuvacka)
        {
            int momentalnaVrednost = cena - (2 * (cena - (godinaNaProizvodstvo / 100) * potrosuvacka));
            return momentalnaVrednost;
        }
    }
}