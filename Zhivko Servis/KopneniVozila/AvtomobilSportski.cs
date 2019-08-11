namespace Zhivko_Servis
{
       public class AvtomobilSportski : KopnenoVozilo
    {

        public int EmisijaNaGasovi { get; }
        private int _emisijaNaGasovi;
        public AvtomobilSportski() : base()
        {

        }

        public AvtomobilSportski(string tipNaGorivo) : base(tipNaGorivo)
        {
        }
        public AvtomobilSportski(string tipNaGorivo, int kapacitetNaRezervoar) : base(tipNaGorivo, kapacitetNaRezervoar)
        {
        }

        public AvtomobilSportski(string tipNaGorivo,
                                int kapacitetNaRezervoar,
                                int potrosuvackaNa100,
                                int cena,
                                string boja,
                                int godinaNaProizvodstvo,
                                string problem) :
            base(tipNaGorivo, kapacitetNaRezervoar, potrosuvackaNa100, cena, boja, godinaNaProizvodstvo, problem)
        {
        }
        public AvtomobilSportski(int EmisijaNaGasovi,
                                string tipNaGorivo,
                                int kapacitetNaRezervoar,
                                int potrosuvackaNa100,
                                int cena,
                                string boja,
                                int godinaNaProizvodstvo,
                                string problem)
        {
        }
        public new int MomentalnaVrednost(int cena, int godinaNaProizvodstvo, int potrosuvacka)
            {
                int momentalnaVrednost = cena - (2 * (cena - (godinaNaProizvodstvo / 100) * potrosuvacka));
                return momentalnaVrednost;
            }


        }
}